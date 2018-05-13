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
			this.lblMessage = new System.Windows.Forms.Label();
			this.gridMetaqueryResult = new System.Windows.Forms.DataGridView();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.gridMetaqueryResult)).BeginInit();
			this.SuspendLayout();
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.Location = new System.Drawing.Point(501, 62);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(234, 17);
			this.lblMessage.TabIndex = 0;
			this.lblMessage.Text = "There is no metaquery or no results";
			this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// gridMetaqueryResult
			// 
			this.gridMetaqueryResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridMetaqueryResult.Location = new System.Drawing.Point(398, 137);
			this.gridMetaqueryResult.Name = "gridMetaqueryResult";
			this.gridMetaqueryResult.RowTemplate.Height = 24;
			this.gridMetaqueryResult.Size = new System.Drawing.Size(240, 150);
			this.gridMetaqueryResult.TabIndex = 5;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(352, 450);
			this.flowLayoutPanel1.TabIndex = 6;
			// 
			// FrmMetaqueryResult
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.gridMetaqueryResult);
			this.Controls.Add(this.lblMessage);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmMetaqueryResult";
			this.Text = "Metaquery Results";
			this.Load += new System.EventHandler(this.FrmMetaqueryResult_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridMetaqueryResult)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.DataGridView gridMetaqueryResult;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	}
}