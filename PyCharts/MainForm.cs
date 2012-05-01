using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using ScintillaNET;

namespace PyCharts
{
    public partial class MainForm : Form
    {
        Properties.Settings settings;

        ScriptEngine scriptEngine;
        ScriptScope scriptScope;
        CompiledCode script = null;

        MemoryStream scriptStream;
        ScriptStreamWriter scriptWriter;

        double offset = 0.0;
        double[] xValues = null;
        double[] yValues = null;
        long startTicks = 0;

        object pythonClass = null;
        Func<double, double[], double[], object> runner = null;

        public MainForm()
        {
            settings = new Properties.Settings();
            settings.Reload();

            InitializeComponent();
            
            Size = settings.WindowSize;
            Location = settings.WindowPosition;
            WindowState = settings.WindowState;

            ConfigureCodeEditor();
            codeText.Text = settings.Code;

            scriptStream = new MemoryStream();
            MemoryStream ms = new MemoryStream();
            scriptWriter = new ScriptStreamWriter(scriptStream);
            scriptWriter.StringWritten += scriptOuput;

            scriptEngine = Python.CreateEngine();
            scriptEngine.Runtime.IO.SetOutput(scriptStream, scriptWriter);
            scriptScope = scriptEngine.CreateScope();
            scriptScope.SetVariable("chart", chart);

            xValues = new double[400];
            yValues = new double[400];

            compileScript();

            plotTimer.Interval = 32;
            plotTimer.Start();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            settings.WindowSize = Size;
            settings.WindowPosition = Location;
            settings.WindowState = WindowState;
            settings.Save();
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            compileScript();
        }

        private void scriptOuput(object sender, ScriptOutputArgs args)
        {
            codeOutput.Text += args.Value;
        }

        private void plotTimer_Tick(object sender, EventArgs e)
        {
            runScript();
        }

        private void compileScript()
        {
            string code = codeText.Text;
            ScriptSource scriptSource = scriptEngine.CreateScriptSourceFromString(code);
            try
            {
                script = scriptSource.Compile();
                offset = 0.0;
                startTicks = DateTime.UtcNow.Ticks;
                settings.Code = code;
            }
            catch (Exception ex)
            {
                codeOutput.Text += ex.Message + "\r\n";
            }
            Func<object> factory = null;
            try
            {
                script.Execute(scriptScope);
                if (!scriptScope.TryGetVariable("Factory", out factory))
                {
                    factory = null;
                }
            }
            catch (Exception ex)
            {
                codeOutput.Text += ex.Message + "\r\n";
            }
            if (factory != null)
            {
                pythonClass = factory();
                try
                {
                    runner = scriptEngine.Operations.GetMember(pythonClass, "run");
                }
                catch (MissingMemberException) {
                    runner = null;
                }
            }
            if (runner != null) {
                try
                {
                    runner(offset, xValues, yValues);
                    settings.Code = code;
                }
                catch (Exception ex)
                {
                    codeOutput.Text += ex.Message + "\r\n";
                    runner = null;
                }
            }
        }

        private void runScript()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            if (runner != null)
            {
                offset = (DateTime.UtcNow.Ticks - startTicks) / 10000000.0;
                try
                {
                    runner(offset, xValues, yValues);
                }
                catch (Exception ex)
                {
                    codeOutput.Text += ex.Message + "\r\n";
                    runner = null;
                }
            }
            stopwatch.Stop();
            double secs = (1000.0 * stopwatch.ElapsedTicks) / (double)(Stopwatch.Frequency);
            elapsedLabel.Text = String.Format("{0:f3}ms", secs);
            chart.Series["series1"].Points.DataBindXY(xValues, yValues);
        }

        private void ConfigureCodeEditor()
        {
            codeText.ConfigurationManager.Language = "python";
            codeText.ConfigurationManager.Configure();
        }
    }

    public class ScriptOutputArgs : EventArgs
    {
        public string Value
        {
            get;
            private set;
        }

        public ScriptOutputArgs(string value)
        {
            this.Value = value;
        }
    }

    public class ScriptStreamWriter : StreamWriter
    {
        #region Event
        public event EventHandler<ScriptOutputArgs> StringWritten;
        #endregion

        public ScriptStreamWriter(Stream s)
            : base(s)
        { }

        #region Private Methods
        private void LaunchEvent(string txtWritten)
        {
            if (StringWritten != null)
            {
                StringWritten(this, new ScriptOutputArgs(txtWritten));
            }
        }
        #endregion


        #region Overrides

        public override void Write(string value)
        {
            base.Write(value);
            LaunchEvent(value);
        }
        public override void Write(bool value)
        {
            base.Write(value);
            LaunchEvent(value.ToString());
        }
        // here override all writing methods...

        #endregion
    }

}
