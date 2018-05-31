namespace MetaqueryGenerator.Forms.BaseControls
{
	partial class PropertyLabelControl
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
			this.lblText = new MetaqueryGenerator.Forms.BaseControls.CustomLabel();
			this.lblValue = new MetaqueryGenerator.Forms.BaseControls.CustomLabel();
			this.SuspendLayout();
			// 
			// lblText
			// 
			this.lblText.AutoSize = true;
			this.lblText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblText.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblText.ForeColor = System.Drawing.Color.White;
			this.lblText.Location = new System.Drawing.Point(23, 19);
			this.lblText.Name = "lblText";
			this.lblText.OutlineForeColor = System.Drawing.Color.Black;
			this.lblText.OutlineWidth = 2F;
			this.lblText.Size = new System.Drawing.Size(58, 29);
			this.lblText.TabIndex = 14;
			this.lblText.Text = "Text";
			// 
			// lblValue
			// 
			this.lblValue.AutoSize = true;
			this.lblValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblValue.Location = new System.Drawing.Point(309, 19);
			this.lblValue.Name = "lblValue";
			this.lblValue.TabIndex = 13;
			// 
			// PropertyLabelControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblText);
			this.Controls.Add(this.lblValue);
			this.Name = "PropertyLabelControl";
			this.Size = new System.Drawing.Size(490, 59);
			this.Load += new System.EventHandler(this.PropertyLabelControl_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CustomLabel lblText;
		private CustomLabel lblValue;

		public string TextLabel
		{
			get
			{
				return lblText.Text;
			}
			set
			{
				lblText.Text = value;
			}
		}
		public string ValueLabel
		{
			get
			{
				return lblValue.Text;
			}
			set
			{
				lblValue.Text = value;
			}
		}
	}
}
