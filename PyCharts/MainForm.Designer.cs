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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.codeText = new System.Windows.Forms.RichTextBox();
            this.splitter = new System.Windows.Forms.SplitContainer();
            this.vSplitter = new System.Windows.Forms.SplitContainer();
            this.codeOutput = new System.Windows.Forms.RichTextBox();
            this.goBtn = new System.Windows.Forms.Button();
            this.plotTimer = new System.Windows.Forms.Timer(this.components);
            this.elapsedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).BeginInit();
            this.splitter.Panel1.SuspendLayout();
            this.splitter.Panel2.SuspendLayout();
            this.splitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vSplitter)).BeginInit();
            this.vSplitter.Panel1.SuspendLayout();
            this.vSplitter.Panel2.SuspendLayout();
            this.vSplitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.SystemColors.Control;
            chartArea4.AxisX.IsLabelAutoFit = false;
            chartArea4.AxisX.LabelStyle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DarkGray;
            chartArea4.AxisX.LabelStyle.Format = "F3";
            chartArea4.AxisX.LineColor = System.Drawing.Color.Gainsboro;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea4.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea4.AxisY.IsLabelAutoFit = false;
            chartArea4.AxisY.LabelStyle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.DarkGray;
            chartArea4.AxisY.LineColor = System.Drawing.Color.Gainsboro;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea4.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea4.BackColor = System.Drawing.SystemColors.Control;
            chartArea4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea4.BackSecondaryColor = System.Drawing.Color.WhiteSmoke;
            chartArea4.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea4);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chart.Legends.Add(legend4);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Margin = new System.Windows.Forms.Padding(0);
            this.chart.Name = "chart";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Color = System.Drawing.Color.SkyBlue;
            series4.Legend = "Legend1";
            series4.Name = "series1";
            series4.ShadowColor = System.Drawing.Color.White;
            series4.ShadowOffset = 1;
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart.Series.Add(series4);
            this.chart.Size = new System.Drawing.Size(441, 354);
            this.chart.TabIndex = 0;
            this.chart.Text = "Chart";
            // 
            // codeText
            // 
            this.codeText.AcceptsTab = true;
            this.codeText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeText.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeText.Location = new System.Drawing.Point(0, 0);
            this.codeText.Name = "codeText";
            this.codeText.Size = new System.Drawing.Size(260, 237);
            this.codeText.TabIndex = 1;
            this.codeText.Text = "from System import Math\n\nfor n in xrange(len(x)):\n\ty[n] = Math.Sin(x[n]*Math.PI)\n" +
    "series.Points.DataBindXY(x, y)";
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
            this.splitter.Panel1.Controls.Add(this.elapsedLabel);
            this.splitter.Panel1.Controls.Add(this.vSplitter);
            this.splitter.Panel1.Controls.Add(this.goBtn);
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
            // 
            // vSplitter.Panel2
            // 
            this.vSplitter.Panel2.Controls.Add(this.codeOutput);
            this.vSplitter.Size = new System.Drawing.Size(260, 319);
            this.vSplitter.SplitterDistance = 237;
            this.vSplitter.TabIndex = 3;
            // 
            // codeOutput
            // 
            this.codeOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeOutput.Location = new System.Drawing.Point(0, 0);
            this.codeOutput.Name = "codeOutput";
            this.codeOutput.Size = new System.Drawing.Size(260, 78);
            this.codeOutput.TabIndex = 0;
            this.codeOutput.Text = "";
            // 
            // goBtn
            // 
            this.goBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.goBtn.Location = new System.Drawing.Point(188, 328);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(75, 23);
            this.goBtn.TabIndex = 2;
            this.goBtn.Text = "Apply";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // plotTimer
            // 
            this.plotTimer.Tick += new System.EventHandler(this.plotTimer_Tick);
            // 
            // elapsedLabel
            // 
            this.elapsedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elapsedLabel.Location = new System.Drawing.Point(3, 333);
            this.elapsedLabel.Name = "elapsedLabel";
            this.elapsedLabel.Size = new System.Drawing.Size(179, 18);
            this.elapsedLabel.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 378);
            this.Controls.Add(this.splitter);
            this.Name = "MainForm";
            this.Text = "PyChart";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.splitter.Panel1.ResumeLayout(false);
            this.splitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).EndInit();
            this.splitter.ResumeLayout(false);
            this.vSplitter.Panel1.ResumeLayout(false);
            this.vSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vSplitter)).EndInit();
            this.vSplitter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.RichTextBox codeText;
        private System.Windows.Forms.SplitContainer splitter;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.SplitContainer vSplitter;
        private System.Windows.Forms.RichTextBox codeOutput;
        private System.Windows.Forms.Timer plotTimer;
        private System.Windows.Forms.Label elapsedLabel;
    }
}

