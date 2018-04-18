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
			this.btnSendMQToSolver = new System.Windows.Forms.Button();
			this.btnExpandMQP = new System.Windows.Forms.Button();
			this.customButton1 = new MetaqueryGenerator.Forms.BaseControls.CustomButton();
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
			// btnSendMQToSolver
			// 
			this.btnSendMQToSolver.Location = new System.Drawing.Point(317, 132);
			this.btnSendMQToSolver.Name = "btnSendMQToSolver";
			this.btnSendMQToSolver.Size = new System.Drawing.Size(108, 116);
			this.btnSendMQToSolver.TabIndex = 1;
			this.btnSendMQToSolver.Text = "Start Send MQ To Solver";
			this.btnSendMQToSolver.UseVisualStyleBackColor = true;
			this.btnSendMQToSolver.Click += new System.EventHandler(this.btnSendMQToSolver_Click);
			// 
			// btnExpandMQP
			// 
			this.btnExpandMQP.Location = new System.Drawing.Point(441, 132);
			this.btnExpandMQP.Name = "btnExpandMQP";
			this.btnExpandMQP.Size = new System.Drawing.Size(108, 116);
			this.btnExpandMQP.TabIndex = 2;
			this.btnExpandMQP.Text = "Start Expand MQ Process";
			this.btnExpandMQP.UseVisualStyleBackColor = true;
			this.btnExpandMQP.Click += new System.EventHandler(this.btnExpandMQP_Click);
			// 
			// customButton1
			// 
			this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
			this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customButton1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customButton1.ForeColor = System.Drawing.Color.White;
			this.customButton1.Location = new System.Drawing.Point(657, 128);
			this.customButton1.Name = "customButton1";
			this.customButton1.Size = new System.Drawing.Size(120, 120);
			this.customButton1.TabIndex = 3;
			this.customButton1.Text = "Test RabbitMQ send MQ";
			this.customButton1.UseVisualStyleBackColor = false;
			this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
			// 
			// TestJobsButtons
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.customButton1);
			this.Controls.Add(this.btnExpandMQP);
			this.Controls.Add(this.btnSendMQToSolver);
			this.Controls.Add(this.btnStartDBProcess);
			this.Name = "TestJobsButtons";
			this.Controls.SetChildIndex(this.btnStartDBProcess, 0);
			this.Controls.SetChildIndex(this.btnSendMQToSolver, 0);
			this.Controls.SetChildIndex(this.btnExpandMQP, 0);
			this.Controls.SetChildIndex(this.customButton1, 0);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartDBProcess;
		private System.Windows.Forms.Button btnSendMQToSolver;
		private System.Windows.Forms.Button btnExpandMQP;
		private BaseControls.CustomButton customButton1;
	}
}
