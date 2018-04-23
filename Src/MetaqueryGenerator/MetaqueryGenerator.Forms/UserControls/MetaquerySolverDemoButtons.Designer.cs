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
			this.SuspendLayout();
			// 
			// customButton1
			// 
			this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
			this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customButton1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customButton1.ForeColor = System.Drawing.Color.White;
			this.customButton1.Location = new System.Drawing.Point(95, 63);
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
			this.customButton2.Location = new System.Drawing.Point(259, 63);
			this.customButton2.Name = "customButton2";
			this.customButton2.Size = new System.Drawing.Size(120, 120);
			this.customButton2.TabIndex = 5;
			this.customButton2.Text = "Stop Consumer";
			this.customButton2.UseVisualStyleBackColor = false;
			this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
			// 
			// MetaquerySolverDemoButtons
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.customButton2);
			this.Controls.Add(this.customButton1);
			this.Name = "MetaquerySolverDemoButtons";
			this.Controls.SetChildIndex(this.customButton1, 0);
			this.Controls.SetChildIndex(this.customButton2, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private BaseControls.CustomButton customButton1;
		private BaseControls.CustomButton customButton2;
	}
}
