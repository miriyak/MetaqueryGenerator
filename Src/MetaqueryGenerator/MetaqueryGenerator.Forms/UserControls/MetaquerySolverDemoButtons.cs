using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetaquerySolver.Demo;
using System.Configuration;

namespace MetaqueryGenerator.Forms.UserControls
{
	public partial class MetaquerySolverDemoButtons : BaseControls.BaseUserControl
	{
		public MetaquerySolverDemoButtons()
		{
			InitializeComponent();
		}
		MetaquerySolverDemo demo;
		private void customButton1_Click(object sender, EventArgs e)
		{
			string queueToMQSolverName = ConfigurationManager.AppSettings["QueueToMQSolverName"];
			demo = new MetaquerySolverDemo();
			demo.RunConsumer(queueToMQSolverName);
		}

		private void customButton2_Click(object sender, EventArgs e)
		{
			demo.StopConsume();
		}
	}
}
