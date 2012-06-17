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

        ScriptEngine scriptEngine = null;
        ScriptScope scriptScope;
        CompiledCode script = null;

        MemoryStream scriptStream;
        ScriptStreamWriter scriptWriter;

        double offset = 0.0;
        double[] xValues = null;
        double[] yValues = null;
        long startTicks = 0;

        object scriptClass = null;
        Func<double, double[], double[], object> scriptCalculate = null;

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

            plotTimer.Interval = 33;

            compileScript();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            settings.WindowSize = Size;
            settings.WindowPosition = Location;
            settings.WindowState = WindowState;
            settings.Save();
        }

        private void doCompileScript(object sender, EventArgs e)
        {
            compileScript();
        }

        private void scriptOuput(object sender, ScriptOutputArgs args)
        {
            outputText.Text += args.Value;
        }

        private void plotTimer_Tick(object sender, EventArgs e)
        {
            runScript();
        }

        private void initializeEngine()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            scriptStream = new MemoryStream();
            MemoryStream ms = new MemoryStream();
            scriptWriter = new ScriptStreamWriter(scriptStream);
            scriptWriter.StringWritten += scriptOuput;

            scriptEngine = Python.CreateEngine();
            scriptEngine.Runtime.IO.SetOutput(scriptStream, scriptWriter);
            scriptScope = scriptEngine.CreateScope();
            scriptScope.SetVariable("chart", chart);

            double secs = (1000.0 * stopwatch.ElapsedTicks) / (double)(Stopwatch.Frequency);
            buildInfo(String.Format("Initialize engine took {0:f3}ms", secs));
        }

        private void buildClear()
        {
            buildText.Text = "";
        }

        private void buildError(string message)
        {
            buildText.Text += "ERROR:\t" + message + "\r\n";
        }

        private void buildWarning(string message)
        {
            buildText.Text += "WARNING:\t" + message + "\r\n";
        }

        private void buildInfo(string message)
        {
            buildText.Text += "INFO:\t" + message + "\r\n";
        }

        private void compileScript()
        {
            buildClear();
            outputClear();
            if (scriptEngine == null) {
                initializeEngine();
            }
            Stopwatch stopwatch = Stopwatch.StartNew();
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
                buildError(ex.Message);
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
                buildError(ex.Message);
            }
            if (factory != null)
            {
                try
                {
                    scriptClass = factory();
                }
                catch (Exception ex)
                {
                    buildError(ex.Message);
                    scriptClass = null;
                }
            }
            if (scriptClass != null)
            {
                try
                {
                    Func<UInt32> sampleCount = scriptEngine.Operations.GetMember(scriptClass, "sampleCount");
                    UInt32 samples = sampleCount();
                    xValues = new double[samples];
                    yValues = new double[samples];
                }
                catch (MissingMemberException)
                {
                    if (xValues == null || yValues == null)
                    {
                        xValues = new double[200];
                        yValues = new double[200];
                    }
                }
                try
                {
                    scriptCalculate = scriptEngine.Operations.GetMember(scriptClass, "calculate");
                }
                catch (MissingMemberException)
                {
                    scriptCalculate = null;
                }
            }
            if (scriptCalculate != null)
            {
                try
                {
                    scriptCalculate(offset, xValues, yValues);
                    settings.Code = code;
                    plotTimer.Start();
                }
                catch (Exception ex)
                {
                    buildError(ex.Message);
                    scriptCalculate = null;
                }
            }
            stopwatch.Stop();
            double secs = (1000.0 * stopwatch.ElapsedTicks) / (double)(Stopwatch.Frequency);
            buildInfo(String.Format("Compiled in {0:f3}ms", secs));
        }

        private void outputClear()
        {
            outputText.Text = "";
        }

        private void outputError(string message)
        {
            outputText.Text += "ERROR:\t" + message + "\r\n";
        }

        private void runScript()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            if (scriptCalculate != null)
            {
                offset = (DateTime.UtcNow.Ticks - startTicks) / 10000000.0;
                try
                {
                    scriptCalculate(offset, xValues, yValues);
                }
                catch (Exception ex)
                {
                    outputError(ex.Message);
                    scriptCalculate = null;
                }
            }
            stopwatch.Stop();
            double secs = (1000.0 * stopwatch.ElapsedTicks) / (double)(Stopwatch.Frequency);
            exeTimeLabel.Text = String.Format("{0:f3}ms", secs);

            chart.Series["series1"].Points.DataBindXY(xValues, yValues);
        }

        private void ConfigureCodeEditor()
        {
            codeText.ConfigurationManager.Language = "python";
            codeText.ConfigurationManager.Configure();
        }

        private void exitFileMenu_Click(object sender, EventArgs e)
        {
            Close();
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
