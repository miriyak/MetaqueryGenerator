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
			this.gridMetaquery = new System.Windows.Forms.DataGridView();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.customLabel1 = new MetaqueryGenerator.Forms.BaseControls.CustomLabel();
			((System.ComponentModel.ISupportInitialize)(this.gridMetaquery)).BeginInit();
			this.SuspendLayout();
			// 
			// comboDB
			// 
			this.comboDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.comboDB.FormattingEnabled = true;
			this.comboDB.Location = new System.Drawing.Point(242, 25);
			this.comboDB.Name = "comboDB";
			this.comboDB.Size = new System.Drawing.Size(235, 33);
			this.comboDB.TabIndex = 1;
			this.comboDB.SelectedIndexChanged += new System.EventHandler(this.comboDB_SelectedIndexChanged);
			// 
			// gridMetaquery
			// 
			this.gridMetaquery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridMetaquery.Location = new System.Drawing.Point(18, 84);
			this.gridMetaquery.Name = "gridMetaquery";
			this.gridMetaquery.RowTemplate.Height = 24;
			this.gridMetaquery.Size = new System.Drawing.Size(915, 370);
			this.gridMetaquery.TabIndex = 3;
			this.gridMetaquery.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMetaquery_CellClick);
			// 
			// btnRefresh
			// 
			this.btnRefresh.BackgroundImage = global::MetaqueryGenerator.Forms.Properties.Resources.refresh;
			this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.btnRefresh.Location = new System.Drawing.Point(533, 15);
			this.btnRefresh.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnRefresh.Size = new System.Drawing.Size(52, 51);
			this.btnRefresh.TabIndex = 6;
			this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// customLabel1
			// 
			this.customLabel1.AutoSize = true;
			this.customLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customLabel1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customLabel1.ForeColor = System.Drawing.Color.White;
			this.customLabel1.Location = new System.Drawing.Point(135, 28);
			this.customLabel1.Name = "customLabel1";
			this.customLabel1.Size = new System.Drawing.Size(90, 24);
			this.customLabel1.TabIndex = 7;
			this.customLabel1.Text = "Select DB";
			// 
			// DBStatusOfRun
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.customLabel1);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.gridMetaquery);
			this.Controls.Add(this.comboDB);
			this.Name = "DBStatusOfRun";
			this.Load += new System.EventHandler(this.DBStatusOfRun_Load);
			this.Controls.SetChildIndex(this.comboDB, 0);
			this.Controls.SetChildIndex(this.gridMetaquery, 0);
			this.Controls.SetChildIndex(this.btnRefresh, 0);
			this.Controls.SetChildIndex(this.customLabel1, 0);
			((System.ComponentModel.ISupportInitialize)(this.gridMetaquery)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboDB;
		private System.Windows.Forms.DataGridView gridMetaquery;
		private System.Windows.Forms.Button btnRefresh;
		private BaseControls.CustomLabel customLabel1;
	}
}
