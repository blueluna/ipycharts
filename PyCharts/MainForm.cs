using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace PyCharts
{
    public partial class MainForm : Form
    {
        ScriptEngine scriptEngine;
        ScriptScope scriptScope;
        CompiledCode script = null;

        MemoryStream scriptStream;
        ScriptStreamWriter scriptWriter;

        double offset = 0.0;
        double[] xValues = null;
        double[] yValues = null;

        public MainForm()
        {
            InitializeComponent();

            scriptStream = new MemoryStream();
            MemoryStream ms = new MemoryStream();
            scriptWriter = new ScriptStreamWriter(scriptStream);
            scriptWriter.StringWritten += scriptOuput;

            scriptEngine = Python.CreateEngine();
            scriptEngine.Runtime.IO.SetOutput(scriptStream, scriptWriter);
            ScriptSource src = scriptEngine.CreateScriptSourceFromString("import clr\r\nclr.AddReference('System')\r\nfrom System import Math\r\n");
            src.Execute();
            scriptScope = scriptEngine.CreateScope();
            scriptScope.SetVariable("series", chart.Series["series1"]);

            xValues = new double[200];
            yValues = new double[200];
            scriptScope.SetVariable("x", xValues);
            scriptScope.SetVariable("y", yValues);

            plotTimer.Interval = 33;
            plotTimer.Start();
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            string code = codeText.Text;
            ScriptSource scriptSource = scriptEngine.CreateScriptSourceFromString(code);
            try
            {
                script = scriptSource.Compile();
                offset = 0.0;
            }
            catch (Exception ex)
            {
                codeOutput.Text += ex.Message + "\r\n";
            }
        }

        private void scriptOuput(object sender, ScriptOutputArgs args)
        {
            codeOutput.Text += args.Value;
        }

        private void plotTimer_Tick(object sender, EventArgs e)
        {
            runScript();
        }

        private void runScript()
        {
            if (script == null) { return; }
            double t = offset;
            for (int n = 0; n < xValues.Length; n++)
            {
                xValues[n] = t;
                yValues[n] = Math.Sin(t);
                t += 0.01;
            }

            Stopwatch stopwatch = Stopwatch.StartNew();
            try
            {
                script.Execute(scriptScope);
            }
            catch (Exception ex)
            {
                codeOutput.Text += ex.Message + "\r\n";
            }
            stopwatch.Stop();
            double secs = stopwatch.ElapsedMilliseconds / 1000.0;
            elapsedLabel.Text = String.Format("{0:f9}", secs);
            offset += 0.1;
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
