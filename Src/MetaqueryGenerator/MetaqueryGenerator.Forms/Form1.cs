using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetaqueryGenerator.Forms.UserControls;

namespace MetaqueryGenerator.Forms
{
    public partial class Form1 : Form
    {
        UserControl lastPanel;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.BorderSize = 0;
            pressedButton.FlatAppearance.BorderSize = 3;
        }
        private void openNewPanel(UserControl uc)
        {
            
            if (lastPanel != null)
                this.mainPanel.Controls.Remove(lastPanel);
            this.mainPanel.Controls.Add(uc);
            this.lastPanel = uc;

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            InitializeDB uc = new InitializeDB();
            setButtonPressed(button1);
            openNewPanel(uc);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            setButtonPressed(button2);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            TestJobsButtons uc = new TestJobsButtons();
            setButtonPressed(button5);
            openNewPanel(uc);

        }

		private void customButton1_Click(object sender, EventArgs e)
		{

		}
	}
}
