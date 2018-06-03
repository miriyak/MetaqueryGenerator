using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetaqueryGenerator.Forms.BaseControls;
using MetaqueryGenerator.BL;
using MetaqueryGenerator.DS;
using MetaqueryGenerator.Common;

namespace MetaqueryGenerator.Forms.UserControls
{
	public partial class DBStatusOfRun : BaseUserControl
	{
		List<KeyValue> ListOfDB;
		public DBStatusOfRun(List<KeyValue>  listOfDB)
		{
			InitializeComponent();
			ListOfDB = listOfDB;

		}
		public void FillDBDropDownList()
		{
			comboDB.DataSource = ListOfDB;
			comboDB.ValueMember = "Key";
			comboDB.DisplayMember = "Value";

		}
		public void FillArityDropDownList(int dbID)
		{
			var lst = DBQueries.GetDBArityExists(dbID);
			comboArity.DataSource = lst;
			comboArity.ValueMember = "Key";
			comboArity.DisplayMember = "Value";

		}

		private void DBStatusOfRun_Load(object sender, EventArgs e)
		{
			FillDBDropDownList();
		}
		List<VMetaquery> metaqueriesList;
		private void comboDB_SelectedIndexChanged(object sender, EventArgs e)
		{
			ShowDataBySelectedDB();

		}
		public void ShowDataBySelectedDB()
		{
			int dbID;
			if (int.TryParse(comboDB.SelectedValue.ToString(), out dbID))
			{
				FillArityDropDownList(dbID);

				ShowDBProperties(dbID);
				ShowMetaqueryGridBySelectedDB(dbID);

			}
		}
		public void ShowDBProperties(int dbID)
		{

			TblDatabaseManagement tblDatabaseManagement = DatabaseManagementsDS.Get(dbID);
			if (dbID > 0)
			{
				pnlDBProperties.Visible = true;
				pnlFilter.Visible = true;

				propMaxArity.ValueLabel = tblDatabaseManagement.MaxArity.ToString();
				propCurrentArity.ValueLabel = tblDatabaseManagement.CurrentArity.ToString();
				propSupportThreshold.ValueLabel = tblDatabaseManagement.SupportThreshold.ToString();
				propConfidenceThreshold.ValueLabel = tblDatabaseManagement.ConfidenceThreshold.ToString();
				propStatus.ValueLabel = tblDatabaseManagement.TblStatus.Description;

				if (tblDatabaseManagement.StartTime.HasValue)
					propStartTime.ValueLabel = tblDatabaseManagement.StartTime.Value.ToString(Consts.DateTimeFormat);
				else
					propStartTime.ValueLabel = "";

				if (tblDatabaseManagement.FinishTime.HasValue)
					propFinishTime.ValueLabel = tblDatabaseManagement.FinishTime.Value.ToString(Consts.DateTimeFormat);
				else
					propFinishTime.ValueLabel = "";

				propMaxColumn.ValueLabel = tblDatabaseManagement.MaxVariablesInRelation.ToString();
			}
			else
			{
				pnlDBProperties.Visible = false;
				pnlFilter.Visible = false;
			}
		}
		public void ShowMetaqueryGridBySelectedDB(int dbID)
		{
			if (dbID > 0)
			{
				metaqueriesList = DBQueries.GetMetaqueriesByDBID(dbID);
				propMQCount.ValueLabel = metaqueriesList.Count().ToString();
				propHasAnswer.ValueLabel = metaqueriesList.Count(x => x.FkResult == (int)ResultMQ.HasAnswers).ToString();
				propSupportFailure.ValueLabel = metaqueriesList.Count(x => x.FkResult == (int)ResultMQ.SupportFailure).ToString();
				propConfidenceFailure.ValueLabel = metaqueriesList.Count(x => x.FkResult == (int)ResultMQ.ConfidenceFailure).ToString();
				pnlCountMQ.Visible = true;

			}
			else
			{
				metaqueriesList = null;
				pnlCountMQ.Visible = false;
			}
			gridMetaquery.DataSource = metaqueriesList;

			
		}

		private void gridMetaquery_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				int metaqueryID = metaqueriesList[e.RowIndex].Id;
				if (metaqueriesList.First(x => x.Id == metaqueryID).FkResult == (int)ResultMQ.HasAnswers)
				{
					FrmMetaqueryResult frm = new FrmMetaqueryResult(metaqueryID);
					frm.ShowDialog();
				}
			}
			//gridMetaqueryResult.DataSource = DBQueries.GetMetaqueriesResultByID(metaqueryID);
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			ShowDataBySelectedDB(); 

		}

		private void comboArity_SelectedIndexChanged(object sender, EventArgs e)
		{
			int arity;
			if (int.TryParse(comboArity.SelectedValue.ToString(), out arity))
			{
				if(arity > 0 )
					gridMetaquery.DataSource = metaqueriesList.Where(x => x.Arity == arity).ToList();
				else
					gridMetaquery.DataSource = metaqueriesList;

			}
		}

	
	}
}
