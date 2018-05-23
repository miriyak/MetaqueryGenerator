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
		public DBStatusOfRun()
		{
			InitializeComponent();
		}
		public void FillDBDropDownList()
		{
			DatabaseManagement database = new DatabaseManagement();

			var lst = DBQueries.GetAllDB();
			comboDB.DataSource = lst;
			comboDB.ValueMember = "Key";
			comboDB.DisplayMember = "Value";

		}

		private void DBStatusOfRun_Load(object sender, EventArgs e)
		{
			FillDBDropDownList();
		}
		List<VMetaquery> metaqueriesList;
		private void comboDB_SelectedIndexChanged(object sender, EventArgs e)
		{
			ShowMetaqueryGridBySelectedDB();

		}
		public void ShowMetaqueryGridBySelectedDB()
		{
			int dbID;
			if (int.TryParse(comboDB.SelectedValue.ToString(), out dbID))
				//var dbID = (KeyValuePair<int, string>)comboDB.SelectedValue ;
				if (dbID > 0)
				{
					metaqueriesList = DBQueries.GetMetaqueriesByDBID(dbID);
				}
				else
					metaqueriesList = null;

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
			ShowMetaqueryGridBySelectedDB();

		}

		
	}
}
