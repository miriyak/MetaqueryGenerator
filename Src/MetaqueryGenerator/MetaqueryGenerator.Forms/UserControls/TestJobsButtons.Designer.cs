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
			this.btnRunConsumer = new System.Windows.Forms.Button();
			this.btnStopConsumer = new System.Windows.Forms.Button();
			this.btnIncreaseArity = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnStartDBProcess
			// 
			this.btnStartDBProcess.Location = new System.Drawing.Point(46, 37);
			this.btnStartDBProcess.Name = "btnStartDBProcess";
			this.btnStartDBProcess.Size = new System.Drawing.Size(108, 116);
			this.btnStartDBProcess.TabIndex = 0;
			this.btnStartDBProcess.Text = "Start DB Process";
			this.btnStartDBProcess.UseVisualStyleBackColor = true;
			this.btnStartDBProcess.Click += new System.EventHandler(this.btnStartDBProcess_Click);
			// 
			// btnSendMQToSolver
			// 
			this.btnSendMQToSolver.Location = new System.Drawing.Point(179, 37);
			this.btnSendMQToSolver.Name = "btnSendMQToSolver";
			this.btnSendMQToSolver.Size = new System.Drawing.Size(108, 116);
			this.btnSendMQToSolver.TabIndex = 1;
			this.btnSendMQToSolver.Text = "Start Send MQ To Solver";
			this.btnSendMQToSolver.UseVisualStyleBackColor = true;
			this.btnSendMQToSolver.Click += new System.EventHandler(this.btnSendMQToSolver_Click);
			// 
			// btnExpandMQP
			// 
			this.btnExpandMQP.Location = new System.Drawing.Point(303, 37);
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
			this.customButton1.Location = new System.Drawing.Point(46, 184);
			this.customButton1.Name = "customButton1";
			this.customButton1.Size = new System.Drawing.Size(120, 120);
			this.customButton1.TabIndex = 3;
			this.customButton1.Text = "Test RabbitMQ send MQ";
			this.customButton1.UseVisualStyleBackColor = false;
			this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
			// 
			// btnRunConsumer
			// 
			this.btnRunConsumer.Location = new System.Drawing.Point(179, 184);
			this.btnRunConsumer.Name = "btnRunConsumer";
			this.btnRunConsumer.Size = new System.Drawing.Size(108, 116);
			this.btnRunConsumer.TabIndex = 4;
			this.btnRunConsumer.Text = "Run RabbitMQ Generator Consumer";
			this.btnRunConsumer.UseVisualStyleBackColor = true;
			this.btnRunConsumer.Click += new System.EventHandler(this.btnRunConsumer_Click);
			// 
			// btnStopConsumer
			// 
			this.btnStopConsumer.Location = new System.Drawing.Point(317, 184);
			this.btnStopConsumer.Name = "btnStopConsumer";
			this.btnStopConsumer.Size = new System.Drawing.Size(108, 116);
			this.btnStopConsumer.TabIndex = 5;
			this.btnStopConsumer.Text = "Stop Consumer";
			this.btnStopConsumer.UseVisualStyleBackColor = true;
			this.btnStopConsumer.Click += new System.EventHandler(this.btnStopConsumer_Click);
			// 
			// btnIncreaseArity
			// 
			this.btnIncreaseArity.Location = new System.Drawing.Point(433, 37);
			this.btnIncreaseArity.Name = "btnIncreaseArity";
			this.btnIncreaseArity.Size = new System.Drawing.Size(108, 116);
			this.btnIncreaseArity.TabIndex = 2;
			this.btnIncreaseArity.Text = "Start Increase DB Arity";
			this.btnIncreaseArity.UseVisualStyleBackColor = true;
			this.btnIncreaseArity.Click += new System.EventHandler(this.btnIncreaseArity_Click);
			// 
			// TestJobsButtons
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnStopConsumer);
			this.Controls.Add(this.btnRunConsumer);
			this.Controls.Add(this.customButton1);
			this.Controls.Add(this.btnIncreaseArity);
			this.Controls.Add(this.btnExpandMQP);
			this.Controls.Add(this.btnSendMQToSolver);
			this.Controls.Add(this.btnStartDBProcess);
			this.Name = "TestJobsButtons";
			this.Controls.SetChildIndex(this.btnStartDBProcess, 0);
			this.Controls.SetChildIndex(this.btnSendMQToSolver, 0);
			this.Controls.SetChildIndex(this.btnExpandMQP, 0);
			this.Controls.SetChildIndex(this.btnIncreaseArity, 0);
			this.Controls.SetChildIndex(this.customButton1, 0);
			this.Controls.SetChildIndex(this.btnRunConsumer, 0);
			this.Controls.SetChildIndex(this.btnStopConsumer, 0);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartDBProcess;
		private System.Windows.Forms.Button btnSendMQToSolver;
		private System.Windows.Forms.Button btnExpandMQP;
		private BaseControls.CustomButton customButton1;
		private System.Windows.Forms.Button btnRunConsumer;
		private System.Windows.Forms.Button btnStopConsumer;
		private System.Windows.Forms.Button btnIncreaseArity;
	}
}
