namespace MetaqueryGenerator.Forms.UserControls
{
    partial class InitializeDB
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
			this.txtConnectionString = new System.Windows.Forms.TextBox();
			this.txtDbName = new System.Windows.Forms.TextBox();
			this.btnSave = new MetaqueryGenerator.Forms.BaseControls.CustomButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnClear = new MetaqueryGenerator.Forms.BaseControls.CustomButton();
			this.btnUrlDialog = new System.Windows.Forms.Button();
			this.customLabel1 = new MetaqueryGenerator.Forms.BaseControls.CustomLabel();
			this.customLabel2 = new MetaqueryGenerator.Forms.BaseControls.CustomLabel();
			this.customLabel3 = new MetaqueryGenerator.Forms.BaseControls.CustomLabel();
			this.customLabel4 = new MetaqueryGenerator.Forms.BaseControls.CustomLabel();
			this.customLabel5 = new MetaqueryGenerator.Forms.BaseControls.CustomLabel();
			this.numericConfidence = new System.Windows.Forms.NumericUpDown();
			this.numericSupport = new System.Windows.Forms.NumericUpDown();
			this.numericMaxArity = new System.Windows.Forms.NumericUpDown();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericConfidence)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericSupport)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericMaxArity)).BeginInit();
			this.SuspendLayout();
			// 
			// txtConnectionString
			// 
			this.txtConnectionString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.txtConnectionString.Location = new System.Drawing.Point(345, 114);
			this.txtConnectionString.Multiline = true;
			this.txtConnectionString.Name = "txtConnectionString";
			this.txtConnectionString.Size = new System.Drawing.Size(510, 99);
			this.txtConnectionString.TabIndex = 4;
			this.txtConnectionString.Text = "\\";
			// 
			// txtDbName
			// 
			this.txtDbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.txtDbName.Location = new System.Drawing.Point(345, 56);
			this.txtDbName.Name = "txtDbName";
			this.txtDbName.Size = new System.Drawing.Size(510, 30);
			this.txtDbName.TabIndex = 3;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(720, 13);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(145, 50);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnClear);
			this.panel2.Controls.Add(this.btnSave);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 562);
			this.panel2.Margin = new System.Windows.Forms.Padding(10);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(10);
			this.panel2.Size = new System.Drawing.Size(1610, 271);
			this.panel2.TabIndex = 8;
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.ForeColor = System.Drawing.Color.White;
			this.btnClear.Location = new System.Drawing.Point(550, 13);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(145, 50);
			this.btnClear.TabIndex = 8;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnUrlDialog
			// 
			this.btnUrlDialog.BackgroundImage = global::MetaqueryGenerator.Forms.Properties.Resources.selectDB;
			this.btnUrlDialog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnUrlDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.btnUrlDialog.Location = new System.Drawing.Point(257, 120);
			this.btnUrlDialog.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
			this.btnUrlDialog.Name = "btnUrlDialog";
			this.btnUrlDialog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnUrlDialog.Size = new System.Drawing.Size(65, 60);
			this.btnUrlDialog.TabIndex = 5;
			this.btnUrlDialog.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnUrlDialog.UseVisualStyleBackColor = true;
			this.btnUrlDialog.Click += new System.EventHandler(this.btnUrlDialog_Click);
			// 
			// customLabel1
			// 
			this.customLabel1.AutoSize = true;
			this.customLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customLabel1.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customLabel1.ForeColor = System.Drawing.Color.White;
			this.customLabel1.Location = new System.Drawing.Point(50, 59);
			this.customLabel1.Name = "customLabel1";
			this.customLabel1.OutlineForeColor = System.Drawing.Color.Black;
			this.customLabel1.OutlineWidth = 2F;
			this.customLabel1.Size = new System.Drawing.Size(107, 29);
			this.customLabel1.TabIndex = 11;
			this.customLabel1.Text = "DB Name";
			// 
			// customLabel2
			// 
			this.customLabel2.AutoSize = true;
			this.customLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customLabel2.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customLabel2.ForeColor = System.Drawing.Color.White;
			this.customLabel2.Location = new System.Drawing.Point(60, 253);
			this.customLabel2.Name = "customLabel2";
			this.customLabel2.OutlineForeColor = System.Drawing.Color.Black;
			this.customLabel2.OutlineWidth = 2F;
			this.customLabel2.Size = new System.Drawing.Size(114, 29);
			this.customLabel2.TabIndex = 12;
			this.customLabel2.Text = "Max Arity";
			// 
			// customLabel3
			// 
			this.customLabel3.AutoSize = true;
			this.customLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customLabel3.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customLabel3.ForeColor = System.Drawing.Color.White;
			this.customLabel3.Location = new System.Drawing.Point(57, 318);
			this.customLabel3.Name = "customLabel3";
			this.customLabel3.OutlineForeColor = System.Drawing.Color.Black;
			this.customLabel3.OutlineWidth = 2F;
			this.customLabel3.Size = new System.Drawing.Size(199, 29);
			this.customLabel3.TabIndex = 12;
			this.customLabel3.Text = "Support threshold";
			// 
			// customLabel4
			// 
			this.customLabel4.AutoSize = true;
			this.customLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customLabel4.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customLabel4.ForeColor = System.Drawing.Color.White;
			this.customLabel4.Location = new System.Drawing.Point(56, 376);
			this.customLabel4.Name = "customLabel4";
			this.customLabel4.OutlineForeColor = System.Drawing.Color.Black;
			this.customLabel4.OutlineWidth = 2F;
			this.customLabel4.Size = new System.Drawing.Size(230, 29);
			this.customLabel4.TabIndex = 12;
			this.customLabel4.Text = "Confidence threshold";
			// 
			// customLabel5
			// 
			this.customLabel5.AutoSize = true;
			this.customLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customLabel5.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customLabel5.ForeColor = System.Drawing.Color.White;
			this.customLabel5.Location = new System.Drawing.Point(46, 119);
			this.customLabel5.Name = "customLabel5";
			this.customLabel5.OutlineForeColor = System.Drawing.Color.Black;
			this.customLabel5.OutlineWidth = 2F;
			this.customLabel5.Size = new System.Drawing.Size(176, 29);
			this.customLabel5.TabIndex = 12;
			this.customLabel5.Text = "Connection URL";
			// 
			// numericConfidence
			// 
			this.numericConfidence.DecimalPlaces = 2;
			this.numericConfidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.numericConfidence.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericConfidence.Location = new System.Drawing.Point(345, 376);
			this.numericConfidence.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericConfidence.Name = "numericConfidence";
			this.numericConfidence.Size = new System.Drawing.Size(140, 30);
			this.numericConfidence.TabIndex = 13;
			// 
			// numericSupport
			// 
			this.numericSupport.DecimalPlaces = 2;
			this.numericSupport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.numericSupport.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericSupport.Location = new System.Drawing.Point(345, 317);
			this.numericSupport.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericSupport.Name = "numericSupport";
			this.numericSupport.Size = new System.Drawing.Size(140, 30);
			this.numericSupport.TabIndex = 13;
			// 
			// numericMaxArity
			// 
			this.numericMaxArity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.numericMaxArity.Location = new System.Drawing.Point(345, 250);
			this.numericMaxArity.Name = "numericMaxArity";
			this.numericMaxArity.Size = new System.Drawing.Size(140, 30);
			this.numericMaxArity.TabIndex = 14;
			// 
			// InitializeDB
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.numericMaxArity);
			this.Controls.Add(this.numericSupport);
			this.Controls.Add(this.numericConfidence);
			this.Controls.Add(this.customLabel5);
			this.Controls.Add(this.customLabel4);
			this.Controls.Add(this.customLabel3);
			this.Controls.Add(this.customLabel2);
			this.Controls.Add(this.customLabel1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btnUrlDialog);
			this.Controls.Add(this.txtConnectionString);
			this.Controls.Add(this.txtDbName);
			this.Name = "InitializeDB";
			this.Load += new System.EventHandler(this.InitializeDB_Load);
			this.Controls.SetChildIndex(this.txtDbName, 0);
			this.Controls.SetChildIndex(this.txtConnectionString, 0);
			this.Controls.SetChildIndex(this.btnUrlDialog, 0);
			this.Controls.SetChildIndex(this.panel2, 0);
			this.Controls.SetChildIndex(this.customLabel1, 0);
			this.Controls.SetChildIndex(this.customLabel2, 0);
			this.Controls.SetChildIndex(this.customLabel3, 0);
			this.Controls.SetChildIndex(this.customLabel4, 0);
			this.Controls.SetChildIndex(this.customLabel5, 0);
			this.Controls.SetChildIndex(this.numericConfidence, 0);
			this.Controls.SetChildIndex(this.numericSupport, 0);
			this.Controls.SetChildIndex(this.numericMaxArity, 0);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericConfidence)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericSupport)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericMaxArity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Button btnUrlDialog;
        private System.Windows.Forms.TextBox txtDbName;
        private BaseControls.CustomButton btnSave;
        private System.Windows.Forms.Panel panel2;
		private BaseControls.CustomButton btnClear;
		private BaseControls.CustomLabel customLabel1;
		private BaseControls.CustomLabel customLabel2;
		private BaseControls.CustomLabel customLabel3;
		private BaseControls.CustomLabel customLabel4;
		private BaseControls.CustomLabel customLabel5;
		private System.Windows.Forms.NumericUpDown numericConfidence;
		private System.Windows.Forms.NumericUpDown numericSupport;
		private System.Windows.Forms.NumericUpDown numericMaxArity;
	}
}
