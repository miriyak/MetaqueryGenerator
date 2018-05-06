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
			int dbID;
			if (int.TryParse(comboDB.SelectedValue.ToString(), out dbID))
			//var dbID = (KeyValuePair<int, string>)comboDB.SelectedValue ;
			{
				metaqueriesList = DBQueries.GetMetaqueriesByDBID(dbID);
				gridMetaquery.DataSource = metaqueriesList;
			}
		}

		private void gridMetaquery_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int metaqueryID = metaqueriesList[e.RowIndex].Id;
			gridMetaqueryResult.DataSource = DBQueries.GetMetaqueriesResultByID(metaqueryID);
		}

	}
}
