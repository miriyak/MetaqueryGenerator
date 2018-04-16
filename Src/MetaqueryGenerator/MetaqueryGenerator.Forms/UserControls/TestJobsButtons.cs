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

namespace MetaqueryGenerator.Forms.UserControls
{
    public partial class TestJobsButtons : BaseUserControl
    {
        public TestJobsButtons()
        {
            InitializeComponent();
        }

        private void btnStartDBProcess_Click(object sender, EventArgs e)
        {
            MQGenerator generator = new MQGenerator();
            generator.StartDBProcess();
            ShowMessage("Start DB Process Job run successfuly");

        }
    }
}
