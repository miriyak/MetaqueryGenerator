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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.comboDB = new System.Windows.Forms.ComboBox();
			this.gridMetaquery = new System.Windows.Forms.DataGridView();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pnlFilter = new System.Windows.Forms.Panel();
			this.comboArity = new System.Windows.Forms.ComboBox();
			this.customLabel2 = new MetaqueryGenerator.Forms.BaseControls.CustomLabel();
			this.customLabel1 = new MetaqueryGenerator.Forms.BaseControls.CustomLabel();
			this.pnlDBProperties = new System.Windows.Forms.FlowLayoutPanel();
			this.propMaxArity = new MetaqueryGenerator.Forms.BaseControls.PropertyLabelControl();
			this.propCurrentArity = new MetaqueryGenerator.Forms.BaseControls.PropertyLabelControl();
			this.propSupportThreshold = new MetaqueryGenerator.Forms.BaseControls.PropertyLabelControl();
			this.propConfidenceThreshold = new MetaqueryGenerator.Forms.BaseControls.PropertyLabelControl();
			this.propStatus = new MetaqueryGenerator.Forms.BaseControls.PropertyLabelControl();
			this.propStartTime = new MetaqueryGenerator.Forms.BaseControls.PropertyLabelControl();
			this.propFinishTime = new MetaqueryGenerator.Forms.BaseControls.PropertyLabelControl();
			this.propMaxColumn = new MetaqueryGenerator.Forms.BaseControls.PropertyLabelControl();
			this.propMQCount = new MetaqueryGenerator.Forms.BaseControls.PropertyLabelControl();
			this.propHasAnswer = new MetaqueryGenerator.Forms.BaseControls.PropertyLabelControl();
			this.propSupportFailure = new MetaqueryGenerator.Forms.BaseControls.PropertyLabelControl();
			this.propConfidenceFailure = new MetaqueryGenerator.Forms.BaseControls.PropertyLabelControl();
			this.pnlCountMQ = new System.Windows.Forms.Panel();
			this.Arity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Metaquery = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StatusDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ResultDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IsExpanded = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FinishTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FK_DatabaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FK_StatusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FK_Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastUpdatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.gridMetaquery)).BeginInit();
			this.panel2.SuspendLayout();
			this.pnlFilter.SuspendLayout();
			this.pnlDBProperties.SuspendLayout();
			this.pnlCountMQ.SuspendLayout();
			this.SuspendLayout();
			// 
			// comboDB
			// 
			this.comboDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.comboDB.FormattingEnabled = true;
			this.comboDB.Location = new System.Drawing.Point(132, 28);
			this.comboDB.Name = "comboDB";
			this.comboDB.Size = new System.Drawing.Size(235, 33);
			this.comboDB.TabIndex = 1;
			this.comboDB.SelectedIndexChanged += new System.EventHandler(this.comboDB_SelectedIndexChanged);
			// 
			// gridMetaquery
			// 
			this.gridMetaquery.AllowUserToAddRows = false;
			this.gridMetaquery.AllowUserToDeleteRows = false;
			this.gridMetaquery.BackgroundColor = System.Drawing.SystemColors.Control;
			this.gridMetaquery.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			this.gridMetaquery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridMetaquery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Arity,
            this.Id,
            this.Metaquery,
            this.StatusDescription,
            this.ResultDescription,
            this.IsExpanded,
            this.StartTime,
            this.FinishTime,
            this.FK_DatabaseID,
            this.FK_StatusId,
            this.FK_Result,
            this.CreatedDate,
            this.LastUpdatedDate});
			this.gridMetaquery.GridColor = System.Drawing.SystemColors.Control;
			this.gridMetaquery.Location = new System.Drawing.Point(512, 122);
			this.gridMetaquery.Name = "gridMetaquery";
			this.gridMetaquery.ReadOnly = true;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridMetaquery.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
			this.gridMetaquery.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.gridMetaquery.RowTemplate.Height = 24;
			this.gridMetaquery.Size = new System.Drawing.Size(1202, 495);
			this.gridMetaquery.TabIndex = 3;
			this.gridMetaquery.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMetaquery_CellClick);
			// 
			// btnRefresh
			// 
			this.btnRefresh.BackgroundImage = global::MetaqueryGenerator.Forms.Properties.Resources.refresh;
			this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.btnRefresh.Location = new System.Drawing.Point(423, 18);
			this.btnRefresh.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnRefresh.Size = new System.Drawing.Size(52, 51);
			this.btnRefresh.TabIndex = 6;
			this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.pnlFilter);
			this.panel2.Controls.Add(this.comboDB);
			this.panel2.Controls.Add(this.btnRefresh);
			this.panel2.Controls.Add(this.customLabel1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1610, 100);
			this.panel2.TabIndex = 16;
			// 
			// pnlFilter
			// 
			this.pnlFilter.Controls.Add(this.comboArity);
			this.pnlFilter.Controls.Add(this.customLabel2);
			this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlFilter.Location = new System.Drawing.Point(496, 0);
			this.pnlFilter.Name = "pnlFilter";
			this.pnlFilter.Size = new System.Drawing.Size(1114, 100);
			this.pnlFilter.TabIndex = 11;
			// 
			// comboArity
			// 
			this.comboArity.FormattingEnabled = true;
			this.comboArity.Location = new System.Drawing.Point(175, 31);
			this.comboArity.Name = "comboArity";
			this.comboArity.Size = new System.Drawing.Size(121, 24);
			this.comboArity.TabIndex = 8;
			this.comboArity.SelectedIndexChanged += new System.EventHandler(this.comboArity_SelectedIndexChanged);
			// 
			// customLabel2
			// 
			this.customLabel2.AutoSize = true;
			this.customLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customLabel2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customLabel2.ForeColor = System.Drawing.Color.White;
			this.customLabel2.Location = new System.Drawing.Point(18, 31);
			this.customLabel2.Name = "customLabel2";
			this.customLabel2.OutlineForeColor = System.Drawing.Color.Black;
			this.customLabel2.OutlineWidth = 2F;
			this.customLabel2.Size = new System.Drawing.Size(105, 24);
			this.customLabel2.TabIndex = 10;
			this.customLabel2.Text = "Select arity";
			// 
			// customLabel1
			// 
			this.customLabel1.AutoSize = true;
			this.customLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customLabel1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customLabel1.ForeColor = System.Drawing.Color.White;
			this.customLabel1.Location = new System.Drawing.Point(25, 31);
			this.customLabel1.Name = "customLabel1";
			this.customLabel1.OutlineForeColor = System.Drawing.Color.Black;
			this.customLabel1.OutlineWidth = 2F;
			this.customLabel1.Size = new System.Drawing.Size(90, 24);
			this.customLabel1.TabIndex = 7;
			this.customLabel1.Text = "Select DB";
			// 
			// pnlDBProperties
			// 
			this.pnlDBProperties.Controls.Add(this.propMaxArity);
			this.pnlDBProperties.Controls.Add(this.propCurrentArity);
			this.pnlDBProperties.Controls.Add(this.propSupportThreshold);
			this.pnlDBProperties.Controls.Add(this.propConfidenceThreshold);
			this.pnlDBProperties.Controls.Add(this.propStatus);
			this.pnlDBProperties.Controls.Add(this.propStartTime);
			this.pnlDBProperties.Controls.Add(this.propFinishTime);
			this.pnlDBProperties.Controls.Add(this.propMaxColumn);
			this.pnlDBProperties.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlDBProperties.Location = new System.Drawing.Point(0, 100);
			this.pnlDBProperties.Name = "pnlDBProperties";
			this.pnlDBProperties.Size = new System.Drawing.Size(490, 805);
			this.pnlDBProperties.TabIndex = 23;
			// 
			// propMaxArity
			// 
			this.propMaxArity.Location = new System.Drawing.Point(3, 3);
			this.propMaxArity.Name = "propMaxArity";
			this.propMaxArity.Size = new System.Drawing.Size(490, 59);
			this.propMaxArity.TabIndex = 1;
			this.propMaxArity.TextLabel = "Max arity:";
			this.propMaxArity.ValueLabel = "";
			// 
			// propCurrentArity
			// 
			this.propCurrentArity.Location = new System.Drawing.Point(3, 68);
			this.propCurrentArity.Name = "propCurrentArity";
			this.propCurrentArity.Size = new System.Drawing.Size(490, 59);
			this.propCurrentArity.TabIndex = 0;
			this.propCurrentArity.TextLabel = "Current arity:";
			this.propCurrentArity.ValueLabel = "";
			// 
			// propSupportThreshold
			// 
			this.propSupportThreshold.Location = new System.Drawing.Point(3, 133);
			this.propSupportThreshold.Name = "propSupportThreshold";
			this.propSupportThreshold.Size = new System.Drawing.Size(490, 59);
			this.propSupportThreshold.TabIndex = 4;
			this.propSupportThreshold.TextLabel = "Support threshold:";
			this.propSupportThreshold.ValueLabel = "";
			// 
			// propConfidenceThreshold
			// 
			this.propConfidenceThreshold.Location = new System.Drawing.Point(3, 198);
			this.propConfidenceThreshold.Name = "propConfidenceThreshold";
			this.propConfidenceThreshold.Size = new System.Drawing.Size(490, 59);
			this.propConfidenceThreshold.TabIndex = 5;
			this.propConfidenceThreshold.TextLabel = "Confidence threshold:";
			this.propConfidenceThreshold.ValueLabel = "";
			// 
			// propStatus
			// 
			this.propStatus.Location = new System.Drawing.Point(3, 263);
			this.propStatus.Name = "propStatus";
			this.propStatus.Size = new System.Drawing.Size(490, 59);
			this.propStatus.TabIndex = 7;
			this.propStatus.TextLabel = "Status:";
			this.propStatus.ValueLabel = "";
			// 
			// propStartTime
			// 
			this.propStartTime.Location = new System.Drawing.Point(3, 328);
			this.propStartTime.Name = "propStartTime";
			this.propStartTime.Size = new System.Drawing.Size(490, 59);
			this.propStartTime.TabIndex = 2;
			this.propStartTime.TextLabel = "Start time:";
			this.propStartTime.ValueLabel = "";
			// 
			// propFinishTime
			// 
			this.propFinishTime.Location = new System.Drawing.Point(3, 393);
			this.propFinishTime.Name = "propFinishTime";
			this.propFinishTime.Size = new System.Drawing.Size(490, 59);
			this.propFinishTime.TabIndex = 3;
			this.propFinishTime.TextLabel = "Finish time:";
			this.propFinishTime.ValueLabel = "";
			// 
			// propMaxColumn
			// 
			this.propMaxColumn.Location = new System.Drawing.Point(3, 458);
			this.propMaxColumn.Name = "propMaxColumn";
			this.propMaxColumn.Size = new System.Drawing.Size(490, 59);
			this.propMaxColumn.TabIndex = 6;
			this.propMaxColumn.TextLabel = "Max column:";
			this.propMaxColumn.ValueLabel = "";
			// 
			// propMQCount
			// 
			this.propMQCount.Location = new System.Drawing.Point(129, 0);
			this.propMQCount.Name = "propMQCount";
			this.propMQCount.Size = new System.Drawing.Size(393, 59);
			this.propMQCount.TabIndex = 24;
			this.propMQCount.TextLabel = "Metaqueries count:";
			this.propMQCount.ValueLabel = "";
			// 
			// propHasAnswer
			// 
			this.propHasAnswer.Location = new System.Drawing.Point(129, 45);
			this.propHasAnswer.Name = "propHasAnswer";
			this.propHasAnswer.Size = new System.Drawing.Size(393, 59);
			this.propHasAnswer.TabIndex = 25;
			this.propHasAnswer.TextLabel = "Has answer:";
			this.propHasAnswer.ValueLabel = "";
			// 
			// propSupportFailure
			// 
			this.propSupportFailure.Location = new System.Drawing.Point(752, 1);
			this.propSupportFailure.Name = "propSupportFailure";
			this.propSupportFailure.Size = new System.Drawing.Size(393, 59);
			this.propSupportFailure.TabIndex = 26;
			this.propSupportFailure.TextLabel = "Support failure:";
			this.propSupportFailure.ValueLabel = "";
			// 
			// propConfidenceFailure
			// 
			this.propConfidenceFailure.Location = new System.Drawing.Point(748, 45);
			this.propConfidenceFailure.Name = "propConfidenceFailure";
			this.propConfidenceFailure.Size = new System.Drawing.Size(393, 59);
			this.propConfidenceFailure.TabIndex = 27;
			this.propConfidenceFailure.TextLabel = "Confidence failure:";
			this.propConfidenceFailure.ValueLabel = "";
			// 
			// pnlCountMQ
			// 
			this.pnlCountMQ.Controls.Add(this.propMQCount);
			this.pnlCountMQ.Controls.Add(this.propConfidenceFailure);
			this.pnlCountMQ.Controls.Add(this.propHasAnswer);
			this.pnlCountMQ.Controls.Add(this.propSupportFailure);
			this.pnlCountMQ.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlCountMQ.Location = new System.Drawing.Point(490, 785);
			this.pnlCountMQ.Name = "pnlCountMQ";
			this.pnlCountMQ.Size = new System.Drawing.Size(1120, 120);
			this.pnlCountMQ.TabIndex = 28;
			// 
			// Arity
			// 
			this.Arity.DataPropertyName = "Arity";
			this.Arity.HeaderText = "Arity";
			this.Arity.Name = "Arity";
			this.Arity.ReadOnly = true;
			this.Arity.Width = 60;
			// 
			// Id
			// 
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "ID";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Width = 80;
			// 
			// Metaquery
			// 
			this.Metaquery.DataPropertyName = "Metaquery";
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.Metaquery.DefaultCellStyle = dataGridViewCellStyle1;
			this.Metaquery.HeaderText = "Metaquery";
			this.Metaquery.Name = "Metaquery";
			this.Metaquery.ReadOnly = true;
			this.Metaquery.Width = 300;
			// 
			// StatusDescription
			// 
			this.StatusDescription.DataPropertyName = "StatusDescription";
			this.StatusDescription.HeaderText = "Status";
			this.StatusDescription.Name = "StatusDescription";
			this.StatusDescription.ReadOnly = true;
			this.StatusDescription.Width = 120;
			// 
			// ResultDescription
			// 
			this.ResultDescription.DataPropertyName = "ResultDescription";
			this.ResultDescription.HeaderText = "Result";
			this.ResultDescription.Name = "ResultDescription";
			this.ResultDescription.ReadOnly = true;
			this.ResultDescription.Width = 110;
			// 
			// IsExpanded
			// 
			this.IsExpanded.DataPropertyName = "IsExpanded";
			this.IsExpanded.HeaderText = "Expanded";
			this.IsExpanded.Name = "IsExpanded";
			this.IsExpanded.ReadOnly = true;
			this.IsExpanded.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.IsExpanded.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.IsExpanded.Width = 70;
			// 
			// StartTime
			// 
			this.StartTime.DataPropertyName = "StartTime";
			this.StartTime.HeaderText = "Start Time";
			this.StartTime.Name = "StartTime";
			this.StartTime.ReadOnly = true;
			this.StartTime.Width = 130;
			// 
			// FinishTime
			// 
			this.FinishTime.DataPropertyName = "FinishTime";
			this.FinishTime.HeaderText = "Finish time";
			this.FinishTime.Name = "FinishTime";
			this.FinishTime.ReadOnly = true;
			this.FinishTime.Width = 130;
			// 
			// FK_DatabaseID
			// 
			this.FK_DatabaseID.DataPropertyName = "FkDatabaseID";
			this.FK_DatabaseID.HeaderText = "FK_DatabaseID";
			this.FK_DatabaseID.Name = "FK_DatabaseID";
			this.FK_DatabaseID.ReadOnly = true;
			this.FK_DatabaseID.Visible = false;
			// 
			// FK_StatusId
			// 
			this.FK_StatusId.DataPropertyName = "FkStatusId";
			this.FK_StatusId.HeaderText = "FK_StatusId";
			this.FK_StatusId.Name = "FK_StatusId";
			this.FK_StatusId.ReadOnly = true;
			this.FK_StatusId.Visible = false;
			// 
			// FK_Result
			// 
			this.FK_Result.DataPropertyName = "FkResult";
			this.FK_Result.HeaderText = "FK_Result";
			this.FK_Result.Name = "FK_Result";
			this.FK_Result.ReadOnly = true;
			this.FK_Result.Visible = false;
			// 
			// CreatedDate
			// 
			this.CreatedDate.DataPropertyName = "CreatedDate";
			this.CreatedDate.HeaderText = "CreatedDate";
			this.CreatedDate.Name = "CreatedDate";
			this.CreatedDate.ReadOnly = true;
			this.CreatedDate.Visible = false;
			// 
			// LastUpdatedDate
			// 
			this.LastUpdatedDate.DataPropertyName = "LastUpdatedDate";
			this.LastUpdatedDate.HeaderText = "LastUpdatedDate";
			this.LastUpdatedDate.Name = "LastUpdatedDate";
			this.LastUpdatedDate.ReadOnly = true;
			this.LastUpdatedDate.Visible = false;
			// 
			// DBStatusOfRun
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnlCountMQ);
			this.Controls.Add(this.pnlDBProperties);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.gridMetaquery);
			this.Name = "DBStatusOfRun";
			this.Load += new System.EventHandler(this.DBStatusOfRun_Load);
			this.Controls.SetChildIndex(this.gridMetaquery, 0);
			this.Controls.SetChildIndex(this.panel2, 0);
			this.Controls.SetChildIndex(this.pnlDBProperties, 0);
			this.Controls.SetChildIndex(this.pnlCountMQ, 0);
			((System.ComponentModel.ISupportInitialize)(this.gridMetaquery)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.pnlFilter.ResumeLayout(false);
			this.pnlFilter.PerformLayout();
			this.pnlDBProperties.ResumeLayout(false);
			this.pnlCountMQ.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox comboDB;
		private System.Windows.Forms.DataGridView gridMetaquery;
		private System.Windows.Forms.Button btnRefresh;
		private BaseControls.CustomLabel customLabel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.FlowLayoutPanel pnlDBProperties;
		private BaseControls.PropertyLabelControl propCurrentArity;
		private BaseControls.PropertyLabelControl propMaxArity;
		private BaseControls.PropertyLabelControl propStartTime;
		private BaseControls.PropertyLabelControl propFinishTime;
		private BaseControls.PropertyLabelControl propSupportThreshold;
		private BaseControls.PropertyLabelControl propConfidenceThreshold;
		private BaseControls.PropertyLabelControl propMaxColumn;
		private BaseControls.PropertyLabelControl propStatus;
		private BaseControls.PropertyLabelControl propMQCount;
		private BaseControls.PropertyLabelControl propHasAnswer;
		private BaseControls.PropertyLabelControl propSupportFailure;
		private BaseControls.PropertyLabelControl propConfidenceFailure;
		private System.Windows.Forms.Panel pnlCountMQ;
		private BaseControls.CustomLabel customLabel2;
		private System.Windows.Forms.ComboBox comboArity;
		private System.Windows.Forms.Panel pnlFilter;
		private System.Windows.Forms.DataGridViewTextBoxColumn Arity;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Metaquery;
		private System.Windows.Forms.DataGridViewTextBoxColumn StatusDescription;
		private System.Windows.Forms.DataGridViewTextBoxColumn ResultDescription;
		private System.Windows.Forms.DataGridViewCheckBoxColumn IsExpanded;
		private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn FinishTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn FK_DatabaseID;
		private System.Windows.Forms.DataGridViewTextBoxColumn FK_StatusId;
		private System.Windows.Forms.DataGridViewTextBoxColumn FK_Result;
		private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdatedDate;
	}
}
