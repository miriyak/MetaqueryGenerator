﻿using System;
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
			ShowMessage("Start Run MQ Solver Consumer ");
		}

		private void customButton2_Click(object sender, EventArgs e)
		{
			if (demo == null)
				ShowMessage("No Consumer Started");
			else
			{
				demo.StopConsume();
				ShowMessage("MQ Solver Consumer has stopped");
			}
		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void customButton4_Click(object sender, EventArgs e)
		{
			string queueToMQSolverName = ConfigurationManager.AppSettings["QueueToMQSolverName"];
			demo = new MetaquerySolverDemoRandom();
			int supportProbability = (int)numericSupport.Value;
			int confidenceProbability = (int)numericConfidence.Value;
			(demo as MetaquerySolverDemoRandom).RunConsumer(queueToMQSolverName, supportProbability,confidenceProbability);
			ShowMessage("Start Run MQ Solver Consumer ");
		}
	}
}
