namespace MetaqueryGenerator.Forms.UserControls
{
	partial class MetaquerySolverDemoButtons
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
			this.customButton1 = new MetaqueryGenerator.Forms.BaseControls.CustomButton();
			this.customButton2 = new MetaqueryGenerator.Forms.BaseControls.CustomButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.customLabel1 = new MetaqueryGenerator.Forms.BaseControls.CustomLabel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.numericConfidence = new System.Windows.Forms.NumericUpDown();
			this.numericSupport = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.customButton4 = new MetaqueryGenerator.Forms.BaseControls.CustomButton();
			this.customButton3 = new MetaqueryGenerator.Forms.BaseControls.CustomButton();
			this.label3 = new System.Windows.Forms.Label();
			this.customLabel5 = new MetaqueryGenerator.Forms.BaseControls.CustomLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericConfidence)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericSupport)).BeginInit();
			this.SuspendLayout();
			// 
			// customButton1
			// 
			this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
			this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customButton1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customButton1.ForeColor = System.Drawing.Color.White;
			this.customButton1.Location = new System.Drawing.Point(74, 228);
			this.customButton1.Name = "customButton1";
			this.customButton1.Size = new System.Drawing.Size(120, 120);
			this.customButton1.TabIndex = 4;
			this.customButton1.Text = "Run RabbitMQ solver Consumer";
			this.customButton1.UseVisualStyleBackColor = false;
			this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
			// 
			// customButton2
			// 
			this.customButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
			this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customButton2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customButton2.ForeColor = System.Drawing.Color.White;
			this.customButton2.Location = new System.Drawing.Point(261, 228);
			this.customButton2.Name = "customButton2";
			this.customButton2.Size = new System.Drawing.Size(120, 120);
			this.customButton2.TabIndex = 5;
			this.customButton2.Text = "Stop Consumer";
			this.customButton2.UseVisualStyleBackColor = false;
			this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.customLabel1);
			this.groupBox1.Controls.Add(this.customButton2);
			this.groupBox1.Controls.Add(this.customButton1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.groupBox1.Location = new System.Drawing.Point(46, 82);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(436, 372);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "MQ Solver DB Demo";
			// 
			// customLabel1
			// 
			this.customLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customLabel1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customLabel1.ForeColor = System.Drawing.Color.White;
			this.customLabel1.Location = new System.Drawing.Point(30, 49);
			this.customLabel1.Name = "customLabel1";
			this.customLabel1.Size = new System.Drawing.Size(374, 75);
			this.customLabel1.TabIndex = 13;
			this.customLabel1.Text = "Allow you to run demo that based on db containig results from solver";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.numericConfidence);
			this.groupBox2.Controls.Add(this.numericSupport);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.customButton4);
			this.groupBox2.Controls.Add(this.customButton3);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.customLabel5);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.groupBox2.Location = new System.Drawing.Point(522, 82);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(436, 372);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "MQ Solver Random Demo";
			this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// numericConfidence
			// 
			this.numericConfidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.numericConfidence.Location = new System.Drawing.Point(198, 170);
			this.numericConfidence.Name = "numericConfidence";
			this.numericConfidence.Size = new System.Drawing.Size(71, 22);
			this.numericConfidence.TabIndex = 12;
			// 
			// numericSupport
			// 
			this.numericSupport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.numericSupport.Location = new System.Drawing.Point(198, 139);
			this.numericSupport.Name = "numericSupport";
			this.numericSupport.Size = new System.Drawing.Size(71, 22);
			this.numericSupport.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label4.Location = new System.Drawing.Point(275, 170);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(21, 17);
			this.label4.TabIndex = 11;
			this.label4.Text = "%";
			// 
			// customButton4
			// 
			this.customButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
			this.customButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customButton4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customButton4.ForeColor = System.Drawing.Color.White;
			this.customButton4.Location = new System.Drawing.Point(68, 228);
			this.customButton4.Name = "customButton4";
			this.customButton4.Size = new System.Drawing.Size(120, 120);
			this.customButton4.TabIndex = 4;
			this.customButton4.Text = "Run RabbitMQ solver Consumer";
			this.customButton4.UseVisualStyleBackColor = false;
			this.customButton4.Click += new System.EventHandler(this.customButton4_Click);
			// 
			// customButton3
			// 
			this.customButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
			this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customButton3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customButton3.ForeColor = System.Drawing.Color.White;
			this.customButton3.Location = new System.Drawing.Point(258, 228);
			this.customButton3.Name = "customButton3";
			this.customButton3.Size = new System.Drawing.Size(120, 120);
			this.customButton3.TabIndex = 5;
			this.customButton3.Text = "Stop Consumer";
			this.customButton3.UseVisualStyleBackColor = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label3.Location = new System.Drawing.Point(275, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(21, 17);
			this.label3.TabIndex = 10;
			this.label3.Text = "%";
			// 
			// customLabel5
			// 
			this.customLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customLabel5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customLabel5.ForeColor = System.Drawing.Color.White;
			this.customLabel5.Location = new System.Drawing.Point(24, 49);
			this.customLabel5.Name = "customLabel5";
			this.customLabel5.Size = new System.Drawing.Size(374, 75);
			this.customLabel5.TabIndex = 8;
			this.customLabel5.Text = "Allow you to run demo that based on random results from solver";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label1.Location = new System.Drawing.Point(25, 170);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 17);
			this.label1.TabIndex = 9;
			this.label1.Text = "Confidence failure";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label2.Location = new System.Drawing.Point(25, 141);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 17);
			this.label2.TabIndex = 8;
			this.label2.Text = "Support failure";
			// 
			// MetaquerySolverDemoButtons
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "MetaquerySolverDemoButtons";
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.groupBox2, 0);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericConfidence)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericSupport)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private BaseControls.CustomButton customButton1;
		private BaseControls.CustomButton customButton2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private BaseControls.CustomButton customButton3;
		private BaseControls.CustomButton customButton4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericConfidence;
		private System.Windows.Forms.NumericUpDown numericSupport;
		private BaseControls.CustomLabel customLabel5;
		private BaseControls.CustomLabel customLabel1;
	}
}
