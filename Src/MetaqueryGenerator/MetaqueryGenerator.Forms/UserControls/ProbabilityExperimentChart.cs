using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetaqueryGenerator.Common;
using MetaqueryGenerator.BL;
using MetaqueryGenerator.DS;

namespace MetaqueryGenerator.Forms.UserControls
{
	public partial class ProbabilityExperimentChart : BaseControls.BaseUserControl
	{
		List<VProbabilityExperimentResult> ListAllExperiment; 
		public ProbabilityExperimentChart()
		{
			InitializeComponent();
			GetAllExperiment();
		}
		public void GetAllExperiment()
		{
			ListAllExperiment = DBQueries.GetProbabilityExperimentResult();
		}
		//fillChart method  
		private void fillChart(int probabilty, string probabilityXType)
		{
			for (int maxCol = 3; maxCol <= 5; maxCol++)
			{
				string seriesName = maxCol + " Columns";
				chart1.Series[seriesName].XValueMember = probabilityXType + "Probability";
				//set the member columns of the chart data source used to data bind to the X-values of the series  
				//chart1.Series[seriesName].YValueMembers = "Count";
			}
			if (probabilityXType == "Support")
				chart1.DataSource = ListAllExperiment.Where(x => x.ConfidenceProbability == probabilty);
			else
				chart1.DataSource = ListAllExperiment.Where(x => x.SupportProbability == probabilty);
			
			chart1.DataBind();

		}
		public void FillComboProbabilty()
		{

			List<KeyValue> ListOfDB = DBQueries.GetSupportExistsInProbabiltyExperiment();
			comboSupportProbabilty.DataSource = ListOfDB;
			comboSupportProbabilty.ValueMember = "Key";
			comboSupportProbabilty.DisplayMember = "Value";

			ListOfDB = DBQueries.GetConfidenceExistsInProbabiltyExperiment();
			comboConfidenceProbabilty.DataSource = ListOfDB;
			comboConfidenceProbabilty.ValueMember = "Key";
			comboConfidenceProbabilty.DisplayMember = "Value";


		}
		private void ProbabilityExperimentChart_Load(object sender, EventArgs e)
		{
			FillComboProbabilty();
			
		}
		private void ClearChartTitle()
		{
			if(chart1.Titles.Count > 0) 
				chart1.Titles.RemoveAt(0);
		}
		private void comboSupportProbabilty_SelectedIndexChanged(object sender, EventArgs e)
		{
			int supportProbabilty;
			if (int.TryParse(comboSupportProbabilty.SelectedValue.ToString(), out supportProbabilty))
			{
				if (supportProbabilty > 0)
				{
					ClearChartTitle();
					chart1.Titles.Add(supportProbabilty + "% Support Probabilty Chart");
					comboConfidenceProbabilty.SelectedIndex = 0;

					fillChart(supportProbabilty, "Confidence");
				}
			}

		}

		private void comboConfidenceProbabilty_SelectedIndexChanged(object sender, EventArgs e)
		{
			int confidenceProbabilty;
			if (int.TryParse(comboConfidenceProbabilty.SelectedValue.ToString(), out confidenceProbabilty))
			{
				if (confidenceProbabilty > 0)
				{
					ClearChartTitle();
					chart1.Titles.Add(confidenceProbabilty + "% Confidence Probabilty Chart");
					comboSupportProbabilty.SelectedIndex = 0;
					fillChart(confidenceProbabilty, "Support");
				}
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			GetAllExperiment();
			if (comboSupportProbabilty.SelectedIndex > 0)
				comboSupportProbabilty_SelectedIndexChanged(null, null);
			else if (comboConfidenceProbabilty.SelectedIndex > 0)
				comboConfidenceProbabilty_SelectedIndexChanged(null, null);
		}

	}
}
