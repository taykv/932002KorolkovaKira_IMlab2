namespace IMlab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonClear = new System.Windows.Forms.Button();
			this.editExRateDollar = new System.Windows.Forms.NumericUpDown();
			this.labelDollar = new System.Windows.Forms.Label();
			this.buttonStart = new System.Windows.Forms.Button();
			this.labelIP = new System.Windows.Forms.Label();
			this.editExRateEuro = new System.Windows.Forms.NumericUpDown();
			this.chartLines = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.CurEuro = new System.Windows.Forms.Label();
			this.CurDollar = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.editExRateDollar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.editExRateEuro)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartLines)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.CurDollar);
			this.panel1.Controls.Add(this.CurEuro);
			this.panel1.Controls.Add(this.buttonClear);
			this.panel1.Controls.Add(this.editExRateDollar);
			this.panel1.Controls.Add(this.labelDollar);
			this.panel1.Controls.Add(this.buttonStart);
			this.panel1.Controls.Add(this.labelIP);
			this.panel1.Controls.Add(this.editExRateEuro);
			this.panel1.Location = new System.Drawing.Point(11, 2);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(874, 83);
			this.panel1.TabIndex = 0;
			// 
			// buttonClear
			// 
			this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.buttonClear.Location = new System.Drawing.Point(361, 22);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(69, 33);
			this.buttonClear.TabIndex = 7;
			this.buttonClear.Text = "Clear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// editExRateDollar
			// 
			this.editExRateDollar.DecimalPlaces = 2;
			this.editExRateDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.editExRateDollar.Location = new System.Drawing.Point(142, 47);
			this.editExRateDollar.Margin = new System.Windows.Forms.Padding(2);
			this.editExRateDollar.Name = "editExRateDollar";
			this.editExRateDollar.Size = new System.Drawing.Size(90, 23);
			this.editExRateDollar.TabIndex = 6;
			this.editExRateDollar.Value = new decimal(new int[] {
            7620,
            0,
            0,
            131072});
			// 
			// labelDollar
			// 
			this.labelDollar.AutoSize = true;
			this.labelDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.labelDollar.Location = new System.Drawing.Point(21, 49);
			this.labelDollar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelDollar.Name = "labelDollar";
			this.labelDollar.Size = new System.Drawing.Size(117, 17);
			this.labelDollar.TabIndex = 5;
			this.labelDollar.Text = "Dollar Initial Price";
			// 
			// buttonStart
			// 
			this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.buttonStart.Location = new System.Drawing.Point(277, 22);
			this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(69, 33);
			this.buttonStart.TabIndex = 4;
			this.buttonStart.Text = "Start";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonPredict_Click);
			// 
			// labelIP
			// 
			this.labelIP.AutoSize = true;
			this.labelIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.labelIP.Location = new System.Drawing.Point(21, 11);
			this.labelIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelIP.Name = "labelIP";
			this.labelIP.Size = new System.Drawing.Size(110, 17);
			this.labelIP.TabIndex = 1;
			this.labelIP.Text = "Euro Initial Price";
			// 
			// editExRateEuro
			// 
			this.editExRateEuro.DecimalPlaces = 2;
			this.editExRateEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.editExRateEuro.Location = new System.Drawing.Point(142, 9);
			this.editExRateEuro.Margin = new System.Windows.Forms.Padding(2);
			this.editExRateEuro.Name = "editExRateEuro";
			this.editExRateEuro.Size = new System.Drawing.Size(90, 23);
			this.editExRateEuro.TabIndex = 0;
			this.editExRateEuro.Value = new decimal(new int[] {
            8113,
            0,
            0,
            131072});
			// 
			// chartLines
			// 
			chartArea2.AxisX.Minimum = 0D;
			chartArea2.AxisY.Minimum = 65D;
			chartArea2.Name = "ChartArea1";
			this.chartLines.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.chartLines.Legends.Add(legend2);
			this.chartLines.Location = new System.Drawing.Point(11, 90);
			this.chartLines.Margin = new System.Windows.Forms.Padding(2);
			this.chartLines.Name = "chartLines";
			series3.BorderWidth = 3;
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			series3.IsValueShownAsLabel = true;
			series3.LabelFormat = "C";
			series3.Legend = "Legend1";
			series3.Name = "Euro";
			series4.BorderWidth = 3;
			series4.ChartArea = "ChartArea1";
			series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series4.Color = System.Drawing.Color.Red;
			series4.IsValueShownAsLabel = true;
			series4.LabelFormat = "C";
			series4.Legend = "Legend1";
			series4.Name = "Dollar";
			this.chartLines.Series.Add(series3);
			this.chartLines.Series.Add(series4);
			this.chartLines.Size = new System.Drawing.Size(1188, 465);
			this.chartLines.TabIndex = 1;
			this.chartLines.Text = "chart1";
			// 
			// timer1
			// 
			this.timer1.Interval = 500;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// CurEuro
			// 
			this.CurEuro.AutoSize = true;
			this.CurEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.CurEuro.Location = new System.Drawing.Point(496, 18);
			this.CurEuro.Name = "CurEuro";
			this.CurEuro.Size = new System.Drawing.Size(0, 17);
			this.CurEuro.TabIndex = 8;
			// 
			// CurDollar
			// 
			this.CurDollar.AutoSize = true;
			this.CurDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.CurDollar.Location = new System.Drawing.Point(496, 47);
			this.CurDollar.Name = "CurDollar";
			this.CurDollar.Size = new System.Drawing.Size(0, 17);
			this.CurDollar.TabIndex = 9;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1210, 566);
			this.Controls.Add(this.chartLines);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.editExRateDollar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.editExRateEuro)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartLines)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLines;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.NumericUpDown editExRateEuro;
        private System.Windows.Forms.NumericUpDown editExRateDollar;
        private System.Windows.Forms.Label labelDollar;
        private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Label CurDollar;
		private System.Windows.Forms.Label CurEuro;
	}
}

