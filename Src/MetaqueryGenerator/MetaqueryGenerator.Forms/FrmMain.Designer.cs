namespace MetaqueryGenerator.Forms
{
    partial class FrmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.leftPanel = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.logoPanel = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.headerPanel = new System.Windows.Forms.Panel();
			this.lblPage = new System.Windows.Forms.Label();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.baseUserControl1 = new MetaqueryGenerator.Forms.BaseControls.BaseUserControl();
			this.button5 = new MetaqueryGenerator.Forms.BaseControls.CustomButton();
			this.button4 = new MetaqueryGenerator.Forms.BaseControls.CustomButton();
			this.button2 = new MetaqueryGenerator.Forms.BaseControls.CustomButton();
			this.button1 = new MetaqueryGenerator.Forms.BaseControls.CustomButton();
			this.button6 = new MetaqueryGenerator.Forms.BaseControls.CustomButton();
			this.leftPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.logoPanel.SuspendLayout();
			this.headerPanel.SuspendLayout();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// leftPanel
			// 
			this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
			this.leftPanel.Controls.Add(this.button6);
			this.leftPanel.Controls.Add(this.panel1);
			this.leftPanel.Controls.Add(this.button5);
			this.leftPanel.Controls.Add(this.button4);
			this.leftPanel.Controls.Add(this.button2);
			this.leftPanel.Controls.Add(this.button1);
			this.leftPanel.Controls.Add(this.logoPanel);
			this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.leftPanel.Location = new System.Drawing.Point(0, 0);
			this.leftPanel.Name = "leftPanel";
			this.leftPanel.Size = new System.Drawing.Size(310, 1033);
			this.leftPanel.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(129)))), ((int)(((byte)(49)))));
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 933);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(310, 100);
			this.panel1.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label2.Location = new System.Drawing.Point(12, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 28);
			this.label2.TabIndex = 2;
			this.label2.Text = "Miri Yakobi";
			// 
			// logoPanel
			// 
			this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(129)))), ((int)(((byte)(49)))));
			this.logoPanel.Controls.Add(this.pictureBox1);
			this.logoPanel.Controls.Add(this.label1);
			this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.logoPanel.Location = new System.Drawing.Point(0, 0);
			this.logoPanel.Name = "logoPanel";
			this.logoPanel.Size = new System.Drawing.Size(310, 100);
			this.logoPanel.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label1.Location = new System.Drawing.Point(71, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(218, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Metaquery Generator";
			// 
			// headerPanel
			// 
			this.headerPanel.BackColor = System.Drawing.Color.White;
			this.headerPanel.Controls.Add(this.lblPage);
			this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.headerPanel.Location = new System.Drawing.Point(310, 0);
			this.headerPanel.Name = "headerPanel";
			this.headerPanel.Size = new System.Drawing.Size(1592, 100);
			this.headerPanel.TabIndex = 1;
			// 
			// lblPage
			// 
			this.lblPage.AutoSize = true;
			this.lblPage.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.lblPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(129)))), ((int)(((byte)(49)))));
			this.lblPage.Location = new System.Drawing.Point(47, 27);
			this.lblPage.Name = "lblPage";
			this.lblPage.Size = new System.Drawing.Size(294, 37);
			this.lblPage.TabIndex = 2;
			this.lblPage.Text = "Metaquery Generator";
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.baseUserControl1);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.mainPanel.Location = new System.Drawing.Point(310, 100);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1592, 933);
			this.mainPanel.TabIndex = 2;
			this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.ImageLocation = "";
			this.pictureBox2.InitialImage = null;
			this.pictureBox2.Location = new System.Drawing.Point(215, 25);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(64, 54);
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.ImageLocation = "";
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(16, 26);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(50, 50);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// baseUserControl1
			// 
			this.baseUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(129)))), ((int)(((byte)(49)))));
			this.baseUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.baseUserControl1.Location = new System.Drawing.Point(0, 0);
			this.baseUserControl1.Name = "baseUserControl1";
			this.baseUserControl1.Size = new System.Drawing.Size(1592, 933);
			this.baseUserControl1.TabIndex = 0;
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
			this.button5.Dock = System.Windows.Forms.DockStyle.Top;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.White;
			this.button5.Location = new System.Drawing.Point(0, 286);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(310, 62);
			this.button5.TabIndex = 5;
			this.button5.Text = "MetaquerySolver Demo";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
			this.button4.Dock = System.Windows.Forms.DockStyle.Top;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Location = new System.Drawing.Point(0, 224);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(310, 62);
			this.button4.TabIndex = 4;
			this.button4.Text = "Test Buttons";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
			this.button2.Dock = System.Windows.Forms.DockStyle.Top;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(0, 162);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(310, 62);
			this.button2.TabIndex = 2;
			this.button2.Text = "Status Page";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
			this.button1.Dock = System.Windows.Forms.DockStyle.Top;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(0, 100);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(310, 62);
			this.button1.TabIndex = 1;
			this.button1.Text = "Init Database";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
			this.button6.Dock = System.Windows.Forms.DockStyle.Top;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.ForeColor = System.Drawing.Color.White;
			this.button6.Location = new System.Drawing.Point(0, 348);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(310, 62);
			this.button6.TabIndex = 7;
			this.button6.Text = "Probability experiment results";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.ClientSize = new System.Drawing.Size(1902, 1033);
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.headerPanel);
			this.Controls.Add(this.leftPanel);
			this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmMain";
			this.Text = "Metaquery Generator";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.leftPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.logoPanel.ResumeLayout(false);
			this.logoPanel.PerformLayout();
			this.headerPanel.ResumeLayout(false);
			this.headerPanel.PerformLayout();
			this.mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label label1;
        private BaseControls.CustomButton button1;
        private BaseControls.CustomButton button5;
        private BaseControls.CustomButton button4;
        private BaseControls.CustomButton button2;
        private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblPage;
		private BaseControls.BaseUserControl baseUserControl1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label2;
		private BaseControls.CustomButton button6;
	}
}

