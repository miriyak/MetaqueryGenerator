using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetaqueryGenerator.BL;
using MetaqueryGenerator.Common;
using MetaqueryGenerator.Forms.UserControls;

namespace MetaqueryGenerator.Forms
{
    public partial class FrmMain : Form
    {
		List<KeyValue> ListOfDB = DBQueries.GetDBNotForExperiment();
		UserControl lastPanel;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
			lastPanel = baseUserControl1;

		}

		private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }


		private void setButtonPressed(Button pressedButton)
        {
			lblPage.Text = pressedButton.Text;
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.BorderSize = 0;
            pressedButton.FlatAppearance.BorderSize = 3;



		}
		private void openNewPanel(UserControl uc)
        {

			//if (lastPanel != null)
            this.mainPanel.Controls.Remove(lastPanel);
            this.mainPanel.Controls.Add(uc);
			//this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			uc.Dock = System.Windows.Forms.DockStyle.Fill;

			this.lastPanel = uc;

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            setButtonPressed(button1);
			InitializeDB uc = new InitializeDB();
            openNewPanel(uc);
        }
        private void button2_Click(object sender, EventArgs e)
        {

			setButtonPressed(button2);
			DBStatusOfRun uc = new DBStatusOfRun(ListOfDB);
			openNewPanel(uc);

		}



		private void button4_Click(object sender, EventArgs e)
		{
			setButtonPressed(button4);
			TestJobsButtons uc = new TestJobsButtons();
			openNewPanel(uc);
		}

		private void button5_Click(object sender, EventArgs e)
        {
			setButtonPressed(button5);
			MetaquerySolverDemoButtons uc = new MetaquerySolverDemoButtons();
			openNewPanel(uc);

		}
	}
}
