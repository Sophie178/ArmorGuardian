using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Example_Kursach
{
    public partial class NPC_Workers : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=PERIIT\MY_INSTANCE;Initial Catalog=kursach;Integrated Security=True");


        public NPC_Workers()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            string queryNP = "select ncs.SWorkerID, ncs.NPContractID, " +
                "nclients.Surname as Client_Surname, nclients.[Name] as Client_Name, " +
                "sw.Surname as Guard_Surname, sw.[Name] as Guard_Name " +
                "from NPContract_SecurityWorkers as ncs " +
                "inner join[dbo].[NPContract] as nc " +
                "on ncs.NPContractID = nc.NPContractID " +
                "inner join[dbo].[SecurityWorkers] as sw " +
                "on sw.SWorkerID = ncs.SWorkerID " +
                "inner join NaturalPersonClients nclients " +
                "on nclients.NPClientID = nc.NPClientID";

            string queryJP = "select jcs.SWorkerID, jcs.JPContractID, jclients.ClientName,  " +
                "sw.Surname as Guard_Surname, sw.[Name] as Guard_Name " +
                "from JPContract_SecurityWorkers as jcs " +
                "inner join[dbo].[JPContract] as jc " +
                "on jcs.JPContractID = jc.JPContractID " +
                "inner join[dbo].[SecurityWorkers] as sw " +
                "on sw.SWorkerID = jcs.SWorkerID " +
                "inner join JuridicalPersonClients as jclients " +
                "on jclients.JPClientID = jc.JPClientID";

            SqlCommand cmd = new SqlCommand(queryNP, connection);
            SqlCommand cmd2 = new SqlCommand(queryJP, connection);


            connection.Open();
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            DataTable staffTable = new DataTable();
            DataTable dataTable = new DataTable();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(cmd2);

            sqlDataAdapter.Fill(staffTable);
            sqlDataAdapter1.Fill(dataTable);

            NPCGrid.DataSource = staffTable;
            JPCGrid.DataSource = dataTable;

            connection.Close();

        }


        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu mainMenu = new Menu();
            mainMenu.StartPosition = FormStartPosition.CenterScreen;
            mainMenu.Show();

        }

        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            BackButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            BackButton.ForeColor = Color.FromArgb(234, 211, 144);
        }


    }
}
