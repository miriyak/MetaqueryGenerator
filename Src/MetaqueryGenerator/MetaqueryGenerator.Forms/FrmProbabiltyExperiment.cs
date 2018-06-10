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
	public partial class FrmProbabiltyExperiment : Form
	{
		public FrmProbabiltyExperiment()
		{
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			int count = 0;

			MetaqueryGenerator.BL.ProbabilityExperiment probabilityExperiment = new BL.ProbabilityExperiment();
			int confidenceProbFrom, confidenceProbTo, supportProbFrom, supportProbTo, probStep;
			int maxArity, increaseByArity, maxVariablesInRelation;
			int.TryParse(numericConfidenceProbFrom.Text, out confidenceProbFrom);
			int.TryParse(numericConfidenceProbTo.Text, out confidenceProbTo);
			int.TryParse(numericSupportProbFrom.Text, out supportProbFrom);
			int.TryParse(numericSupportProbTo.Text, out supportProbTo);
			int.TryParse(numericMaxArity.Text, out maxArity);
			int.TryParse(numericMaxColumns.Text, out maxVariablesInRelation);
			int.TryParse(numericIncreaseByArity.Text, out increaseByArity);
			int.TryParse(numericProbStep.Text, out probStep);

			for (int supportProb = supportProbFrom; supportProb <= supportProbTo; supportProb += probStep)
				for (int confidenceProb = confidenceProbFrom; confidenceProb <= confidenceProbTo; confidenceProb += probStep)
				{
					if (probabilityExperiment.Create(supportProb, confidenceProb, maxVariablesInRelation, maxArity))
					{
						count++;
					}

				}
			baseUserControl1.ShowMessage(count + " DB initialized successfully for experimnet");
		}
	}
}
