namespace MetaqueryGenerator.Forms.UserControls
{
	partial class MQResults
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
			this.lblSupport = new System.Windows.Forms.Label();
			this.lblConfidence = new System.Windows.Forms.Label();
			this.lblAssignment = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblSupport
			// 
			this.lblSupport.AutoSize = true;
			this.lblSupport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.lblSupport.Location = new System.Drawing.Point(108, 24);
			this.lblSupport.Name = "lblSupport";
			this.lblSupport.Size = new System.Drawing.Size(59, 20);
			this.lblSupport.TabIndex = 1;
			this.lblSupport.Text = "label1";
			// 
			// lblConfidence
			// 
			this.lblConfidence.AutoSize = true;
			this.lblConfidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.lblConfidence.Location = new System.Drawing.Point(108, 65);
			this.lblConfidence.Name = "lblConfidence";
			this.lblConfidence.Size = new System.Drawing.Size(59, 20);
			this.lblConfidence.TabIndex = 2;
			this.lblConfidence.Text = "label1";
			// 
			// lblAssignment
			// 
			this.lblAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.lblAssignment.Location = new System.Drawing.Point(115, 17);
			this.lblAssignment.Name = "lblAssignment";
			this.lblAssignment.Size = new System.Drawing.Size(530, 65);
			this.lblAssignment.TabIndex = 3;
			this.lblAssignment.Text = "label1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label1.Location = new System.Drawing.Point(15, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 20);
			this.label1.TabIndex = 7;
			this.label1.Text = "Assignment:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label2.Location = new System.Drawing.Point(14, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Confidence:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label3.Location = new System.Drawing.Point(14, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Support:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblSupport);
			this.panel1.Controls.Add(this.lblConfidence);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(620, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 110);
			this.panel1.TabIndex = 8;
			// 
			// MQResults
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblAssignment);
			this.Name = "MQResults";
			this.Size = new System.Drawing.Size(820, 110);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lblSupport;
		private System.Windows.Forms.Label lblConfidence;
		private System.Windows.Forms.Label lblAssignment;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
	}
}
