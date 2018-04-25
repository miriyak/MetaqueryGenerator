using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetaqueryGenerator.BL;
using RabbitMQFactory;
using System.Configuration;

namespace MetaqueryGenerator.Forms.UserControls
{
    public partial class TestJobsButtons : BaseControls.BaseUserControl
	{
		private MQGenerator generator;
		private MQGeneratorConsumer generatorConsumer;

		public TestJobsButtons()
        {
            InitializeComponent();
			generator = new MQGenerator();
			generatorConsumer = new MQGeneratorConsumer();
		}

		private void btnStartDBProcess_Click(object sender, EventArgs e)
        {
            generator.StartDBProcess();
            ShowMessage("Start DB Process Job run successfuly");

        }

		private void btnSendMQToSolver_Click(object sender, EventArgs e)
		{
			string queueToMQSolverName = ConfigurationManager.AppSettings["QueueToMQSolverName"];
			int count = generator.StartSendMQToSolver();
			ShowMessage("Start Send MQ To Solver Job run successfuly"); 
			ShowMessage(count + " MQ sent sucessfuly");
		}

		private void btnExpandMQP_Click(object sender, EventArgs e)
		{
			generator.StartExpandMQProcess();
			ShowMessage("Start Expand MQ Process Job run successfuly"); 
		}

		private void customButton1_Click(object sender, EventArgs e)
		{
			RabbitProducer<string> producer = new RabbitProducer<string>("MiriTest");
			producer.SendMessage("TEST1");
			ShowMessage("All sent");

		}

		private void btnRunConsumer_Click(object sender, EventArgs e)
		{
			generatorConsumer.StartRunConsumer();
			ShowMessage("Start Run MQ Generator Consumer ");
		}

		private void btnStopConsumer_Click(object sender, EventArgs e)
		{
			generatorConsumer.StopConsumer();
			ShowMessage("MQ Generator Consumer has stopped");
		}
	}
}
