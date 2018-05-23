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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSupport = new System.Windows.Forms.TextBox();
			this.txtConfidence = new System.Windows.Forms.TextBox();
			this.txtConnectionString = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDbName = new System.Windows.Forms.TextBox();
			this.btnSave = new MetaqueryGenerator.Forms.BaseControls.CustomButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtMaxArity = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnUrlDialog = new System.Windows.Forms.Button();
			this.btnClear = new MetaqueryGenerator.Forms.BaseControls.CustomButton();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label1.Location = new System.Drawing.Point(56, 235);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Support threshold";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label2.Location = new System.Drawing.Point(56, 280);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(197, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Confidence threshold";
			// 
			// txtSupport
			// 
			this.txtSupport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.txtSupport.Location = new System.Drawing.Point(296, 231);
			this.txtSupport.Name = "txtSupport";
			this.txtSupport.Size = new System.Drawing.Size(140, 30);
			this.txtSupport.TabIndex = 2;
			// 
			// txtConfidence
			// 
			this.txtConfidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.txtConfidence.Location = new System.Drawing.Point(296, 277);
			this.txtConfidence.Name = "txtConfidence";
			this.txtConfidence.Size = new System.Drawing.Size(140, 30);
			this.txtConfidence.TabIndex = 3;
			// 
			// txtConnectionString
			// 
			this.txtConnectionString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.txtConnectionString.Location = new System.Drawing.Point(296, 103);
			this.txtConnectionString.Multiline = true;
			this.txtConnectionString.Name = "txtConnectionString";
			this.txtConnectionString.Size = new System.Drawing.Size(510, 60);
			this.txtConnectionString.TabIndex = 4;
			this.txtConnectionString.Text = "\\";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label3.Location = new System.Drawing.Point(47, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(155, 25);
			this.label3.TabIndex = 6;
			this.label3.Text = "Connection URL";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label4.Location = new System.Drawing.Point(47, 59);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 25);
			this.label4.TabIndex = 1;
			this.label4.Text = "DB Name";
			// 
			// txtDbName
			// 
			this.txtDbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.txtDbName.Location = new System.Drawing.Point(296, 56);
			this.txtDbName.Name = "txtDbName";
			this.txtDbName.Size = new System.Drawing.Size(140, 30);
			this.txtDbName.TabIndex = 3;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(805, 10);
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
			this.panel2.Location = new System.Drawing.Point(0, 394);
			this.panel2.Margin = new System.Windows.Forms.Padding(10);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(10);
			this.panel2.Size = new System.Drawing.Size(960, 66);
			this.panel2.TabIndex = 8;
			// 
			// txtMaxArity
			// 
			this.txtMaxArity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.txtMaxArity.Location = new System.Drawing.Point(296, 186);
			this.txtMaxArity.Name = "txtMaxArity";
			this.txtMaxArity.Size = new System.Drawing.Size(140, 30);
			this.txtMaxArity.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label5.Location = new System.Drawing.Point(56, 196);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 25);
			this.label5.TabIndex = 9;
			this.label5.Text = "Max Arity";
			// 
			// btnUrlDialog
			// 
			this.btnUrlDialog.BackgroundImage = global::MetaqueryGenerator.Forms.Properties.Resources.selectDB;
			this.btnUrlDialog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnUrlDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.btnUrlDialog.Location = new System.Drawing.Point(256, 103);
			this.btnUrlDialog.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
			this.btnUrlDialog.Name = "btnUrlDialog";
			this.btnUrlDialog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnUrlDialog.Size = new System.Drawing.Size(34, 34);
			this.btnUrlDialog.TabIndex = 5;
			this.btnUrlDialog.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnUrlDialog.UseVisualStyleBackColor = true;
			this.btnUrlDialog.Click += new System.EventHandler(this.btnUrlDialog_Click);
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(654, 10);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(145, 50);
			this.btnClear.TabIndex = 8;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// InitializeDB
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txtMaxArity);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnUrlDialog);
			this.Controls.Add(this.txtConnectionString);
			this.Controls.Add(this.txtDbName);
			this.Controls.Add(this.txtConfidence);
			this.Controls.Add(this.txtSupport);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "InitializeDB";
			this.Load += new System.EventHandler(this.InitializeDB_Load);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.txtSupport, 0);
			this.Controls.SetChildIndex(this.txtConfidence, 0);
			this.Controls.SetChildIndex(this.txtDbName, 0);
			this.Controls.SetChildIndex(this.txtConnectionString, 0);
			this.Controls.SetChildIndex(this.btnUrlDialog, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.panel2, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.txtMaxArity, 0);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSupport;
        private System.Windows.Forms.TextBox txtConfidence;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Button btnUrlDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDbName;
        private BaseControls.CustomButton btnSave;
        private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtMaxArity;
		private System.Windows.Forms.Label label5;
		private BaseControls.CustomButton btnClear;
	}
}
