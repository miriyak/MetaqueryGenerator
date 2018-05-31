using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.ConnectionUI;
using MetaqueryGenerator.BL;
using System.Configuration;

namespace MetaqueryGenerator.Forms.UserControls
{
    public partial class InitializeDB : BaseControls.BaseUserControl
	{
        bool TryGetDataConnectionStringFromUser(out string outConnectionString)
        {
            using (var dialog = new DataConnectionDialog())
            {
                // If you want the user to select from any of the available data sources, do this:
                DataSource.AddStandardDataSources(dialog);

                // OR, if you want only certain data sources to be available
                // (e.g. only SQL Server), do something like this instead: 
                dialog.DataSources.Add(DataSource.SqlDataSource);
                dialog.DataSources.Add(DataSource.SqlFileDataSource);
        

        // The way how you show the dialog is somewhat unorthodox; `dialog.ShowDialog()`
        // would throw a `NotSupportedException`. Do it this way instead:
        DialogResult userChoice = DataConnectionDialog.Show(dialog);

                // Return the resulting connection string if a connection was selected:
                if (userChoice == DialogResult.OK)
                {
                    outConnectionString = dialog.ConnectionString;
                    return true;
                }
                else
                {
                    outConnectionString = null;
                    return false;
                }
            }
        }

        public InitializeDB()
        {
            InitializeComponent();

            

        }
        
        private void btnUrlDialog_Click(object sender, EventArgs e)
        {
            string outConnectionString;
            if (TryGetDataConnectionStringFromUser(out outConnectionString))
                txtConnectionString.Text = outConnectionString;
            
        }

        private void InitializeDB_Load(object sender, EventArgs e)
        {
            //MTODO - REMOVE DEFAULT
            txtConnectionString.Text = @"Data Source =.\SQLEXPRESS; Initial Catalog = TestMQ; Integrated Security = True";
			numericSupport.Text = "0.3";
			numericConfidence.Text = "0.2";
			numericMaxArity.Text = "10";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MetaqueryGenerator.BL.DatabaseManagement dbManagement = new BL.DatabaseManagement();
            decimal confidence, support;
            int maxArity;
            decimal.TryParse(numericConfidence.Text,out confidence);
            decimal.TryParse(numericSupport.Text,out support);
			int.TryParse(numericMaxArity.Text,out maxArity);
			
			if (dbManagement.Create(txtDbName.Text, txtConnectionString.Text, support, confidence,maxArity))
			{
				if(MQGenerator.IsAutoRunJobs)
					MQGenerator.StartDBProcess();
				ShowMessage("DB Initialized successfuly");
				txtDbName.Text = "";
			}
        }
		public void ClearTextboxes()
		{
			txtDbName.Text = "";
			txtConnectionString.Text = "";
			numericConfidence.Text = "";
			numericSupport.Text = "";
			numericMaxArity.Text = "";
		}
		private void btnClear_Click(object sender, EventArgs e)
		{
			ClearTextboxes();
		}



		//public bool GetConnection(ref string DataSource, bool SaveConfiguration)
		//{
		//    object success = false;
		//    // Warning!!! Optional parameters not supported
		//    DataConnectionDialog dcd = new DataConnectionDialog();
		//    DataConnectionConfiguration dcs = new DataConnectionConfiguration(null);
		//    dcs.LoadConfiguration(dcd);
		//    if ((DataConnectionDialog.Show(dcd) == DialogResult.OK))
		//    {
		//        DbProviderFactory factory = DbProviderFactories.GetFactory(dcd.SelectedDataProvider.Name);
		//        Using;
		//        connection = factory.CreateConnection();
		//        connection.ConnectionString = dcd.ConnectionString;
		//        DataSource = connection.DataSource;
		//        connection.Open();
		//        object cmd = connection.CreateCommand();
		//        cmd.CommandType = CommandType.Text;
		//        cmd.CommandText = "SELECT * FROM INFORMATION_SCHEMA.TABLES";
		//        object dt = new DataTable();
		//        dt.Load(cmd.ExecuteReader());
		//        TableNames = dt.AsEnumerable().Select(Function, row, row.Field(Of, String)["table_name"]).OrderBy(Function, field, field).ToList();
		//    }

		//    mBuilder = new SqlConnectionStringBuilder();
		//    // With...
		//    ConnectionString = dcd.ConnectionString;
		//    ServerName = mBuilder.DataSource;
		//    if (SaveConfiguration)
		//    {
		//        dcs.SaveConfiguration(dcd);
		//    }

		//    if ((TableNames.Count > 0))
		//    {
		//        success = true;
		//    }

		//    return success;
		//}

	}
}
