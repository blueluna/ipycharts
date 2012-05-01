namespace PyCharts
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitter = new System.Windows.Forms.SplitContainer();
            this.vSplitter = new System.Windows.Forms.SplitContainer();
            this.codeText = new ScintillaNET.Scintilla();
            this.elapsedLabel = new System.Windows.Forms.Label();
            this.goBtn = new System.Windows.Forms.Button();
            this.codeOutput = new System.Windows.Forms.RichTextBox();
            this.plotTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).BeginInit();
            this.splitter.Panel1.SuspendLayout();
            this.splitter.Panel2.SuspendLayout();
            this.splitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vSplitter)).BeginInit();
            this.vSplitter.Panel1.SuspendLayout();
            this.vSplitter.Panel2.SuspendLayout();
            this.vSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeText)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.LabelStyle.Format = "F3";
            chartArea1.AxisX.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Margin = new System.Windows.Forms.Padding(0);
            this.chart.Name = "chart";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.SkyBlue;
            series1.Legend = "Legend1";
            series1.Name = "series1";
            series1.ShadowColor = System.Drawing.Color.White;
            series1.ShadowOffset = 1;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(441, 354);
            this.chart.TabIndex = 0;
            this.chart.Text = "Chart";
            // 
            // splitter
            // 
            this.splitter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitter.Location = new System.Drawing.Point(12, 12);
            this.splitter.Name = "splitter";
            // 
            // splitter.Panel1
            // 
            this.splitter.Panel1.Controls.Add(this.vSplitter);
            // 
            // splitter.Panel2
            // 
            this.splitter.Panel2.Controls.Add(this.chart);
            this.splitter.Size = new System.Drawing.Size(711, 354);
            this.splitter.SplitterDistance = 266;
            this.splitter.TabIndex = 2;
            // 
            // vSplitter
            // 
            this.vSplitter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vSplitter.Location = new System.Drawing.Point(3, 3);
            this.vSplitter.Name = "vSplitter";
            this.vSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // vSplitter.Panel1
            // 
            this.vSplitter.Panel1.Controls.Add(this.codeText);
            this.vSplitter.Panel1.Controls.Add(this.elapsedLabel);
            this.vSplitter.Panel1.Controls.Add(this.goBtn);
            // 
            // vSplitter.Panel2
            // 
            this.vSplitter.Panel2.Controls.Add(this.codeOutput);
            this.vSplitter.Size = new System.Drawing.Size(260, 348);
            this.vSplitter.SplitterDistance = 258;
            this.vSplitter.TabIndex = 3;
            // 
            // codeText
            // 
            this.codeText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeText.ConfigurationManager.CustomLocation = "ScintillaNET.xml";
            this.codeText.ConfigurationManager.LoadOrder = ScintillaNET.Configuration.ConfigurationLoadOrder.BuiltInUserCustom;
            this.codeText.Folding.IsEnabled = false;
            this.codeText.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeText.Indentation.IndentWidth = 4;
            this.codeText.Indentation.ShowGuides = true;
            this.codeText.Indentation.TabWidth = 4;
            this.codeText.Lexing.Lexer = ScintillaNET.Lexer.Python;
            this.codeText.Lexing.LexerName = "python";
            this.codeText.Lexing.LineCommentPrefix = "";
            this.codeText.Lexing.StreamCommentPrefix = "";
            this.codeText.Lexing.StreamCommentSufix = "";
            this.codeText.Location = new System.Drawing.Point(3, 3);
            this.codeText.Name = "codeText";
            this.codeText.Size = new System.Drawing.Size(254, 223);
            this.codeText.Styles.BraceBad.Size = 9F;
            this.codeText.Styles.BraceLight.Size = 9F;
            this.codeText.Styles.ControlChar.Size = 9F;
            this.codeText.Styles.Default.BackColor = System.Drawing.SystemColors.Window;
            this.codeText.Styles.Default.CharacterSet = ScintillaNET.CharacterSet.Ansi;
            this.codeText.Styles.Default.FontName = "Consolas";
            this.codeText.Styles.Default.Size = 9F;
            this.codeText.Styles.IndentGuide.Size = 9F;
            this.codeText.Styles.LastPredefined.Size = 9F;
            this.codeText.Styles.LineNumber.Size = 9F;
            this.codeText.Styles.Max.Size = 9F;
            this.codeText.TabIndex = 5;
            this.codeText.Whitespace.ForeColor = System.Drawing.Color.Gainsboro;
            this.codeText.Whitespace.Mode = ScintillaNET.WhitespaceMode.VisibleAlways;
            // 
            // elapsedLabel
            // 
            this.elapsedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elapsedLabel.Location = new System.Drawing.Point(0, 237);
            this.elapsedLabel.Name = "elapsedLabel";
            this.elapsedLabel.Size = new System.Drawing.Size(176, 18);
            this.elapsedLabel.TabIndex = 4;
            // 
            // goBtn
            // 
            this.goBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.goBtn.Location = new System.Drawing.Point(182, 232);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(75, 23);
            this.goBtn.TabIndex = 2;
            this.goBtn.Text = "Apply";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // codeOutput
            // 
            this.codeOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeOutput.Location = new System.Drawing.Point(0, 0);
            this.codeOutput.Name = "codeOutput";
            this.codeOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.codeOutput.Size = new System.Drawing.Size(260, 86);
            this.codeOutput.TabIndex = 0;
            this.codeOutput.Text = "";
            this.codeOutput.WordWrap = false;
            // 
            // plotTimer
            // 
            this.plotTimer.Tick += new System.EventHandler(this.plotTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 378);
            this.Controls.Add(this.splitter);
            this.Name = "MainForm";
            this.Text = "PyChart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.splitter.Panel1.ResumeLayout(false);
            this.splitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).EndInit();
            this.splitter.ResumeLayout(false);
            this.vSplitter.Panel1.ResumeLayout(false);
            this.vSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vSplitter)).EndInit();
            this.vSplitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.codeText)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.SplitContainer splitter;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.SplitContainer vSplitter;
        private System.Windows.Forms.RichTextBox codeOutput;
        private System.Windows.Forms.Timer plotTimer;
        private System.Windows.Forms.Label elapsedLabel;
        private ScintillaNET.Scintilla codeText;
    }
}

