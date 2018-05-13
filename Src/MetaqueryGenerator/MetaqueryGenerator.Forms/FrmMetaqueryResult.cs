using MetaqueryGenerator.BL;
using MetaqueryGenerator.DS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaqueryGenerator.Forms
{
	public partial class FrmMetaqueryResult : Form
	{
		public FrmMetaqueryResult()
		{
			InitializeComponent();
		}
		public int MetaqueryID { get; set; }
		public FrmMetaqueryResult(int metaqueryID)
		{
			InitializeComponent();
			this.MetaqueryID = metaqueryID;
		}

		private void FrmMetaqueryResult_Load(object sender, EventArgs e)
		{
			List<VMetaqueriesResult> list =  DBQueries.GetMetaqueriesResultByID(MetaqueryID);
			gridMetaqueryResult.DataSource = list;
			foreach (VMetaqueriesResult vresult in list)
			{
				UserControls.MQResults mqResults = new UserControls.MQResults(vresult);
				flowLayoutPanel1.Controls.Add(mqResults);
			}
		}
	}
}
