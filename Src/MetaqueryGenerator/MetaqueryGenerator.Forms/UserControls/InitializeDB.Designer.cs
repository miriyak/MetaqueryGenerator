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
			this.btnUrlDialog = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDbName = new System.Windows.Forms.TextBox();
			this.btnSave = new MetaqueryGenerator.Forms.BaseControls.CustomButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(83, 104);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "support";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(83, 149);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "confidence";
			// 
			// txtSupport
			// 
			this.txtSupport.Location = new System.Drawing.Point(278, 100);
			this.txtSupport.Name = "txtSupport";
			this.txtSupport.Size = new System.Drawing.Size(140, 22);
			this.txtSupport.TabIndex = 2;
			// 
			// txtConfidence
			// 
			this.txtConfidence.Location = new System.Drawing.Point(278, 146);
			this.txtConfidence.Name = "txtConfidence";
			this.txtConfidence.Size = new System.Drawing.Size(140, 22);
			this.txtConfidence.TabIndex = 3;
			// 
			// txtConnectionString
			// 
			this.txtConnectionString.Location = new System.Drawing.Point(278, 199);
			this.txtConnectionString.Name = "txtConnectionString";
			this.txtConnectionString.Size = new System.Drawing.Size(495, 22);
			this.txtConnectionString.TabIndex = 4;
			this.txtConnectionString.Text = "\\";
			// 
			// btnUrlDialog
			// 
			this.btnUrlDialog.Location = new System.Drawing.Point(199, 199);
			this.btnUrlDialog.Name = "btnUrlDialog";
			this.btnUrlDialog.Size = new System.Drawing.Size(37, 23);
			this.btnUrlDialog.TabIndex = 5;
			this.btnUrlDialog.Text = "button1";
			this.btnUrlDialog.UseVisualStyleBackColor = true;
			this.btnUrlDialog.Click += new System.EventHandler(this.btnUrlDialog_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(83, 203);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(111, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "Connection URL";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(83, 59);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 17);
			this.label4.TabIndex = 1;
			this.label4.Text = "DB Name";
			// 
			// txtDbName
			// 
			this.txtDbName.Location = new System.Drawing.Point(278, 56);
			this.txtDbName.Name = "txtDbName";
			this.txtDbName.Size = new System.Drawing.Size(140, 22);
			this.txtDbName.TabIndex = 3;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(785, 10);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(165, 80);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnSave);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 360);
			this.panel2.Margin = new System.Windows.Forms.Padding(10);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(10);
			this.panel2.Size = new System.Drawing.Size(960, 100);
			this.panel2.TabIndex = 8;
			// 
			// InitializeDB
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
