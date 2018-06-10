namespace MetaqueryGenerator.Forms
{
	partial class FrmMetaqueryResult
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMetaqueryResult));
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblMetaquery = new MetaqueryGenerator.Forms.BaseControls.CustomLabel();
			this.customLabel1 = new MetaqueryGenerator.Forms.BaseControls.CustomLabel();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.Controls.Add(this.panel1);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(842, 493);
			this.flowLayoutPanel1.TabIndex = 6;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.lblMetaquery);
			this.panel1.Controls.Add(this.customLabel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(842, 89);
			this.panel1.TabIndex = 8;
			// 
			// lblMetaquery
			// 
			this.lblMetaquery.AutoSize = true;
			this.lblMetaquery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblMetaquery.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMetaquery.ForeColor = System.Drawing.Color.Black;
			this.lblMetaquery.Location = new System.Drawing.Point(293, 30);
			this.lblMetaquery.Name = "lblMetaquery";
			this.lblMetaquery.OutlineForeColor = System.Drawing.Color.Black;
			this.lblMetaquery.OutlineWidth = 1F;
			this.lblMetaquery.Size = new System.Drawing.Size(173, 29);
			this.lblMetaquery.TabIndex = 1;
			this.lblMetaquery.Text = "Metaquery text";
			// 
			// customLabel1
			// 
			this.customLabel1.AutoSize = true;
			this.customLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customLabel1.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customLabel1.ForeColor = System.Drawing.Color.White;
			this.customLabel1.Location = new System.Drawing.Point(21, 30);
			this.customLabel1.Name = "customLabel1";
			this.customLabel1.OutlineForeColor = System.Drawing.Color.Black;
			this.customLabel1.OutlineWidth = 4F;
			this.customLabel1.Size = new System.Drawing.Size(246, 29);
			this.customLabel1.TabIndex = 0;
			this.customLabel1.Text = "Restuls for metaquery:";
			// 
			// FrmMetaqueryResult
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(129)))), ((int)(((byte)(49)))));
			this.ClientSize = new System.Drawing.Size(842, 493);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmMetaqueryResult";
			this.Text = "Metaquery Results";
			this.Load += new System.EventHandler(this.FrmMetaqueryResult_Load);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private BaseControls.CustomLabel lblMetaquery;
		private BaseControls.CustomLabel customLabel1;
	}
}