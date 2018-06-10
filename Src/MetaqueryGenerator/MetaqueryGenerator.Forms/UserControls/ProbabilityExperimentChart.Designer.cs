namespace MetaqueryGenerator.Forms.UserControls
{
	partial class ProbabilityExperimentChart
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.customLabel1 = new MetaqueryGenerator.Forms.BaseControls.CustomLabel();
			this.comboSupportProbabilty = new System.Windows.Forms.ComboBox();
			this.customLabel3 = new MetaqueryGenerator.Forms.BaseControls.CustomLabel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.comboConfidenceProbabilty = new System.Windows.Forms.ComboBox();
			this.customLabel2 = new MetaqueryGenerator.Forms.BaseControls.CustomLabel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(182, 106);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.IsValueShownAsLabel = true;
			series1.Legend = "Legend1";
			series1.Name = "3 Columns";
			series1.XValueMember = "ConfidenceProbability";
			series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
			series1.YValueMembers = "Col3Count";
			series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
			series2.ChartArea = "ChartArea1";
			series2.IsValueShownAsLabel = true;
			series2.Legend = "Legend1";
			series2.Name = "4 Columns";
			series2.XValueMember = "ConfidenceProbability";
			series2.YValueMembers = "Col4Count";
			series3.ChartArea = "ChartArea1";
			series3.IsValueShownAsLabel = true;
			series3.Legend = "Legend1";
			series3.Name = "5 Columns";
			series3.XValueMember = "ConfidenceProbability";
			series3.YValueMembers = "Col5Count";
			this.chart1.Series.Add(series1);
			this.chart1.Series.Add(series2);
			this.chart1.Series.Add(series3);
			this.chart1.Size = new System.Drawing.Size(1217, 589);
			this.chart1.TabIndex = 1;
			this.chart1.Text = "chart1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(325, 107);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(173, 25);
			this.label1.TabIndex = 18;
			this.label1.Text = "Metaqueries count";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(1189, 593);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(170, 25);
			this.label2.TabIndex = 19;
			this.label2.Text = "Support probabilty";
			// 
			// customLabel1
			// 
			this.customLabel1.AutoSize = true;
			this.customLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customLabel1.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customLabel1.ForeColor = System.Drawing.Color.White;
			this.customLabel1.Location = new System.Drawing.Point(187, 31);
			this.customLabel1.Name = "customLabel1";
			this.customLabel1.OutlineForeColor = System.Drawing.Color.Black;
			this.customLabel1.OutlineWidth = 2F;
			this.customLabel1.Size = new System.Drawing.Size(281, 29);
			this.customLabel1.TabIndex = 7;
			this.customLabel1.Text = "Select Support probabilty:";
			// 
			// comboSupportProbabilty
			// 
			this.comboSupportProbabilty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.comboSupportProbabilty.FormattingEnabled = true;
			this.comboSupportProbabilty.Location = new System.Drawing.Point(522, 27);
			this.comboSupportProbabilty.Name = "comboSupportProbabilty";
			this.comboSupportProbabilty.Size = new System.Drawing.Size(137, 33);
			this.comboSupportProbabilty.TabIndex = 1;
			this.comboSupportProbabilty.SelectedIndexChanged += new System.EventHandler(this.comboSupportProbabilty_SelectedIndexChanged);
			// 
			// customLabel3
			// 
			this.customLabel3.AutoSize = true;
			this.customLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customLabel3.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customLabel3.ForeColor = System.Drawing.Color.White;
			this.customLabel3.Location = new System.Drawing.Point(778, 31);
			this.customLabel3.Name = "customLabel3";
			this.customLabel3.OutlineForeColor = System.Drawing.Color.Black;
			this.customLabel3.OutlineWidth = 2F;
			this.customLabel3.Size = new System.Drawing.Size(50, 33);
			this.customLabel3.TabIndex = 10;
			this.customLabel3.Text = "OR";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnRefresh);
			this.panel2.Controls.Add(this.customLabel3);
			this.panel2.Controls.Add(this.comboConfidenceProbabilty);
			this.panel2.Controls.Add(this.comboSupportProbabilty);
			this.panel2.Controls.Add(this.customLabel2);
			this.panel2.Controls.Add(this.customLabel1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1610, 100);
			this.panel2.TabIndex = 17;
			// 
			// btnRefresh
			// 
			this.btnRefresh.BackgroundImage = global::MetaqueryGenerator.Forms.Properties.Resources.refresh;
			this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.btnRefresh.Location = new System.Drawing.Point(1484, 16);
			this.btnRefresh.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnRefresh.Size = new System.Drawing.Size(52, 51);
			this.btnRefresh.TabIndex = 22;
			this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// comboConfidenceProbabilty
			// 
			this.comboConfidenceProbabilty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.comboConfidenceProbabilty.FormattingEnabled = true;
			this.comboConfidenceProbabilty.Location = new System.Drawing.Point(1272, 27);
			this.comboConfidenceProbabilty.Name = "comboConfidenceProbabilty";
			this.comboConfidenceProbabilty.Size = new System.Drawing.Size(126, 33);
			this.comboConfidenceProbabilty.TabIndex = 20;
			this.comboConfidenceProbabilty.SelectedIndexChanged += new System.EventHandler(this.comboConfidenceProbabilty_SelectedIndexChanged);
			// 
			// customLabel2
			// 
			this.customLabel2.AutoSize = true;
			this.customLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customLabel2.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customLabel2.ForeColor = System.Drawing.Color.White;
			this.customLabel2.Location = new System.Drawing.Point(965, 35);
			this.customLabel2.Name = "customLabel2";
			this.customLabel2.OutlineForeColor = System.Drawing.Color.Black;
			this.customLabel2.OutlineWidth = 2F;
			this.customLabel2.Size = new System.Drawing.Size(312, 29);
			this.customLabel2.TabIndex = 21;
			this.customLabel2.Text = "Select Confidence probabilty:";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.White;
			this.pictureBox2.BackgroundImage = global::MetaqueryGenerator.Forms.Properties.Resources.arrow_up;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Location = new System.Drawing.Point(311, 107);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(16, 55);
			this.pictureBox2.TabIndex = 21;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.BackgroundImage = global::MetaqueryGenerator.Forms.Properties.Resources.arrow_right;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(1183, 632);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(166, 10);
			this.pictureBox1.TabIndex = 20;
			this.pictureBox1.TabStop = false;
			// 
			// ProbabilityExperimentChart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.chart1);
			this.Name = "ProbabilityExperimentChart";
			this.Load += new System.EventHandler(this.ProbabilityExperimentChart_Load);
			this.Controls.SetChildIndex(this.chart1, 0);
			this.Controls.SetChildIndex(this.panel2, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.pictureBox1, 0);
			this.Controls.SetChildIndex(this.pictureBox2, 0);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private BaseControls.CustomLabel customLabel1;
		private System.Windows.Forms.ComboBox comboSupportProbabilty;
		private BaseControls.CustomLabel customLabel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.ComboBox comboConfidenceProbabilty;
		private BaseControls.CustomLabel customLabel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}
