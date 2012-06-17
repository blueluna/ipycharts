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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitter = new System.Windows.Forms.SplitContainer();
            this.vSplitter = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.codeText = new ScintillaNET.Scintilla();
            this.exeTimeLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.outputPage = new System.Windows.Forms.TabPage();
            this.outputText = new System.Windows.Forms.RichTextBox();
            this.buildPage = new System.Windows.Forms.TabPage();
            this.buildText = new System.Windows.Forms.RichTextBox();
            this.plotTimer = new System.Windows.Forms.Timer(this.components);
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshScriptMenu = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tabControl1.SuspendLayout();
            this.outputPage.SuspendLayout();
            this.buildPage.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX.LabelStyle.Format = "F3";
            chartArea2.AxisX.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea2.BackSecondaryColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Margin = new System.Windows.Forms.Padding(0);
            this.chart.Name = "chart";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Color = System.Drawing.Color.SkyBlue;
            series2.Legend = "Legend1";
            series2.Name = "series1";
            series2.ShadowColor = System.Drawing.Color.White;
            series2.ShadowOffset = 1;
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(624, 532);
            this.chart.TabIndex = 0;
            this.chart.Text = "Chart";
            // 
            // splitter
            // 
            this.splitter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitter.Location = new System.Drawing.Point(0, 27);
            this.splitter.Margin = new System.Windows.Forms.Padding(0);
            this.splitter.Name = "splitter";
            // 
            // splitter.Panel1
            // 
            this.splitter.Panel1.Controls.Add(this.vSplitter);
            // 
            // splitter.Panel2
            // 
            this.splitter.Panel2.Controls.Add(this.chart);
            this.splitter.Size = new System.Drawing.Size(1001, 532);
            this.splitter.SplitterDistance = 373;
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
            this.vSplitter.Panel1.Controls.Add(this.label1);
            this.vSplitter.Panel1.Controls.Add(this.codeText);
            this.vSplitter.Panel1.Controls.Add(this.exeTimeLabel);
            // 
            // vSplitter.Panel2
            // 
            this.vSplitter.Panel2.Controls.Add(this.tabControl1);
            this.vSplitter.Size = new System.Drawing.Size(367, 526);
            this.vSplitter.SplitterDistance = 389;
            this.vSplitter.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Execution time:";
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
            this.codeText.Margins.Margin1.Width = 0;
            this.codeText.Name = "codeText";
            this.codeText.Size = new System.Drawing.Size(361, 354);
            this.codeText.Styles.BraceBad.Size = 9F;
            this.codeText.Styles.BraceLight.Size = 9F;
            this.codeText.Styles.ControlChar.Size = 9F;
            this.codeText.Styles.Default.BackColor = System.Drawing.SystemColors.Window;
            this.codeText.Styles.Default.CharacterSet = ScintillaNET.CharacterSet.Ansi;
            this.codeText.Styles.Default.FontName = "Consolas";
            this.codeText.Styles.Default.Size = 9F;
            this.codeText.Styles.IndentGuide.Size = 9F;
            this.codeText.Styles.LastPredefined.Size = 9F;
            this.codeText.Styles.LineNumber.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.codeText.Styles.LineNumber.Size = 9F;
            this.codeText.Styles.Max.Size = 9F;
            this.codeText.TabIndex = 5;
            this.codeText.Whitespace.ForeColor = System.Drawing.Color.Gainsboro;
            this.codeText.Whitespace.Mode = ScintillaNET.WhitespaceMode.VisibleAlways;
            // 
            // exeTimeLabel
            // 
            this.exeTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exeTimeLabel.Location = new System.Drawing.Point(85, 368);
            this.exeTimeLabel.Name = "exeTimeLabel";
            this.exeTimeLabel.Size = new System.Drawing.Size(279, 18);
            this.exeTimeLabel.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.outputPage);
            this.tabControl1.Controls.Add(this.buildPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(364, 127);
            this.tabControl1.TabIndex = 0;
            // 
            // outputPage
            // 
            this.outputPage.Controls.Add(this.outputText);
            this.outputPage.Location = new System.Drawing.Point(4, 22);
            this.outputPage.Name = "outputPage";
            this.outputPage.Padding = new System.Windows.Forms.Padding(3);
            this.outputPage.Size = new System.Drawing.Size(356, 101);
            this.outputPage.TabIndex = 0;
            this.outputPage.Text = "Output";
            this.outputPage.UseVisualStyleBackColor = true;
            // 
            // outputText
            // 
            this.outputText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputText.Location = new System.Drawing.Point(0, 3);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(356, 98);
            this.outputText.TabIndex = 0;
            this.outputText.Text = "";
            // 
            // buildPage
            // 
            this.buildPage.Controls.Add(this.buildText);
            this.buildPage.Location = new System.Drawing.Point(4, 22);
            this.buildPage.Name = "buildPage";
            this.buildPage.Padding = new System.Windows.Forms.Padding(3);
            this.buildPage.Size = new System.Drawing.Size(356, 101);
            this.buildPage.TabIndex = 1;
            this.buildPage.Text = "Build Messages";
            this.buildPage.UseVisualStyleBackColor = true;
            // 
            // buildText
            // 
            this.buildText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buildText.Location = new System.Drawing.Point(0, 3);
            this.buildText.Name = "buildText";
            this.buildText.Size = new System.Drawing.Size(356, 98);
            this.buildText.TabIndex = 0;
            this.buildText.Text = "";
            // 
            // plotTimer
            // 
            this.plotTimer.Tick += new System.EventHandler(this.plotTimer_Tick);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.scriptToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1001, 24);
            this.mainMenu.TabIndex = 3;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitFileMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // exitFileMenu
            // 
            this.exitFileMenu.Name = "exitFileMenu";
            this.exitFileMenu.Size = new System.Drawing.Size(92, 22);
            this.exitFileMenu.Text = "E&xit";
            this.exitFileMenu.Click += new System.EventHandler(this.exitFileMenu_Click);
            // 
            // scriptToolStripMenuItem
            // 
            this.scriptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshScriptMenu});
            this.scriptToolStripMenuItem.Name = "scriptToolStripMenuItem";
            this.scriptToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.scriptToolStripMenuItem.Text = "&Script";
            // 
            // refreshScriptMenu
            // 
            this.refreshScriptMenu.Name = "refreshScriptMenu";
            this.refreshScriptMenu.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshScriptMenu.Size = new System.Drawing.Size(132, 22);
            this.refreshScriptMenu.Text = "&Refresh";
            this.refreshScriptMenu.Click += new System.EventHandler(this.doCompileScript);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 571);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "PyChart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.splitter.Panel1.ResumeLayout(false);
            this.splitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).EndInit();
            this.splitter.ResumeLayout(false);
            this.vSplitter.Panel1.ResumeLayout(false);
            this.vSplitter.Panel1.PerformLayout();
            this.vSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vSplitter)).EndInit();
            this.vSplitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.codeText)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.outputPage.ResumeLayout(false);
            this.buildPage.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.SplitContainer splitter;
        private System.Windows.Forms.SplitContainer vSplitter;
        private System.Windows.Forms.Timer plotTimer;
        private System.Windows.Forms.Label exeTimeLabel;
        private ScintillaNET.Scintilla codeText;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitFileMenu;
        private System.Windows.Forms.ToolStripMenuItem scriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshScriptMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage outputPage;
        private System.Windows.Forms.RichTextBox outputText;
        private System.Windows.Forms.TabPage buildPage;
        private System.Windows.Forms.RichTextBox buildText;
    }
}

