namespace elips_buton_olusturma
{
	partial class Form1
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
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chartBirinciDerece = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.shapedButton1 = new elips_buton_olusturma.ShapedButton();
			this.shapedButton2 = new elips_buton_olusturma.ShapedButton();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.chartBirinciDerece)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// chartBirinciDerece
			// 
			chartArea1.Name = "ChartArea1";
			this.chartBirinciDerece.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chartBirinciDerece.Legends.Add(legend1);
			this.chartBirinciDerece.Location = new System.Drawing.Point(12, 13);
			this.chartBirinciDerece.Name = "chartBirinciDerece";
			this.chartBirinciDerece.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
			series1.BorderWidth = 3;
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.Color = System.Drawing.Color.Red;
			series1.Legend = "Legend1";
			series1.Name = "birinci yük";
			series2.BorderWidth = 3;
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series2.Color = System.Drawing.Color.DarkBlue;
			series2.Legend = "Legend1";
			series2.Name = "ikinci yük";
			this.chartBirinciDerece.Series.Add(series1);
			this.chartBirinciDerece.Series.Add(series2);
			this.chartBirinciDerece.Size = new System.Drawing.Size(357, 313);
			this.chartBirinciDerece.TabIndex = 0;
			this.chartBirinciDerece.Text = "chart1";
			// 
			// shapedButton1
			// 
			this.shapedButton1.BackColor = System.Drawing.SystemColors.GrayText;
			this.shapedButton1.Location = new System.Drawing.Point(637, 157);
			this.shapedButton1.Name = "shapedButton1";
			this.shapedButton1.Size = new System.Drawing.Size(183, 190);
			this.shapedButton1.TabIndex = 0;
			this.shapedButton1.Text = "shapedButton1";
			this.shapedButton1.UseVisualStyleBackColor = false;
			this.shapedButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Down);
			this.shapedButton1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move);
			this.shapedButton1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Up);
			// 
			// shapedButton2
			// 
			this.shapedButton2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.shapedButton2.Location = new System.Drawing.Point(401, 163);
			this.shapedButton2.Name = "shapedButton2";
			this.shapedButton2.Size = new System.Drawing.Size(178, 179);
			this.shapedButton2.TabIndex = 1;
			this.shapedButton2.Text = "shapedButton2";
			this.shapedButton2.UseVisualStyleBackColor = false;
			this.shapedButton2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Down);
			this.shapedButton2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move);
			this.shapedButton2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Up);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"mavi",
									"gri"});
			this.comboBox1.Location = new System.Drawing.Point(500, 18);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 22);
			this.comboBox1.TabIndex = 2;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(500, 44);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 3;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(500, 70);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(422, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "küreseç";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(422, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "yarıçap";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(422, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "yükü";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(624, 70);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "güncelle";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// chart1
			// 
			chartArea2.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.chart1.Legends.Add(legend2);
			this.chart1.Location = new System.Drawing.Point(12, 350);
			this.chart1.Name = "chart1";
			this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
			series3.BorderWidth = 4;
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			series3.Legend = "Legend1";
			series3.Name = "itme çekme";
			series3.YValuesPerPoint = 2;
			this.chart1.Series.Add(series3);
			this.chart1.Size = new System.Drawing.Size(376, 208);
			this.chart1.TabIndex = 8;
			this.chart1.Text = "chart1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1306, 570);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.shapedButton2);
			this.Controls.Add(this.shapedButton1);
			this.Controls.Add(this.chartBirinciDerece);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.chartBirinciDerece)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartBirinciDerece;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private elips_buton_olusturma.ShapedButton shapedButton2;
		private elips_buton_olusturma.ShapedButton shapedButton1;

		#endregion
	}
}

