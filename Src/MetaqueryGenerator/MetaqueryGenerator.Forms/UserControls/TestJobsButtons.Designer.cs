namespace MetaqueryGenerator.Forms.UserControls
{
    partial class TestJobsButtons 
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
            this.btnStartDBProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartDBProcess
            // 
            this.btnStartDBProcess.Location = new System.Drawing.Point(184, 132);
            this.btnStartDBProcess.Name = "btnStartDBProcess";
            this.btnStartDBProcess.Size = new System.Drawing.Size(108, 116);
            this.btnStartDBProcess.TabIndex = 0;
            this.btnStartDBProcess.Text = "Start DB Process";
            this.btnStartDBProcess.UseVisualStyleBackColor = true;
            this.btnStartDBProcess.Click += new System.EventHandler(this.btnStartDBProcess_Click);
            // 
            // TestJobsButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnStartDBProcess);
            this.Name = "TestJobsButtons";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartDBProcess;
    }
}
