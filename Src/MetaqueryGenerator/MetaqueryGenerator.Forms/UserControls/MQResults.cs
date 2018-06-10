using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetaqueryGenerator.DS;

namespace MetaqueryGenerator.Forms.UserControls
{
	public partial class MQResults : UserControl
	{
		public MQResults()
		{
			InitializeComponent();
		}
		public MQResults(VMetaqueriesResult vresult)
			:this()
		{
			//lblMetaquery.Text = vresult.Metaquery;
			lblAssignment.Text = vresult.Assignment;
			lblConfidence.Text = vresult.ConfidenceValue.ToString();
			lblSupport.Text = vresult.SupportValue.ToString();
		}
	}
}
