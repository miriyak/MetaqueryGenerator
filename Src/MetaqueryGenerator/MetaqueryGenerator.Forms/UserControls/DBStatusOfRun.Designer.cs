namespace MetaqueryGenerator.Forms.UserControls
{
	partial class DBStatusOfRun
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
			this.comboDB = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.gridMetaquery = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.gridMetaquery)).BeginInit();
			this.SuspendLayout();
			// 
			// comboDB
			// 
			this.comboDB.FormattingEnabled = true;
			this.comboDB.Location = new System.Drawing.Point(256, 54);
			this.comboDB.Name = "comboDB";
			this.comboDB.Size = new System.Drawing.Size(235, 24);
			this.comboDB.TabIndex = 1;
			this.comboDB.SelectedIndexChanged += new System.EventHandler(this.comboDB_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(138, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Chose DB";
			// 
			// gridMetaquery
			// 
			this.gridMetaquery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridMetaquery.Location = new System.Drawing.Point(0, 84);
			this.gridMetaquery.Name = "gridMetaquery";
			this.gridMetaquery.RowTemplate.Height = 24;
			this.gridMetaquery.Size = new System.Drawing.Size(915, 370);
			this.gridMetaquery.TabIndex = 3;
			this.gridMetaquery.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMetaquery_CellClick);
			// 
			// DBStatusOfRun
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.gridMetaquery);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboDB);
			this.Name = "DBStatusOfRun";
			this.Load += new System.EventHandler(this.DBStatusOfRun_Load);
			this.Controls.SetChildIndex(this.comboDB, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.gridMetaquery, 0);
			((System.ComponentModel.ISupportInitialize)(this.gridMetaquery)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboDB;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView gridMetaquery;
	}
}
