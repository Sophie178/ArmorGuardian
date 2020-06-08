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
using Example_Kursach.Models;

namespace Example_Kursach
{
    public partial class NPC_Workers : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=PERIIT\MY_INSTANCE;Initial Catalog=kursach;Integrated Security=True");

        string table1 = "NPContract_SecurityWorkers";
        string table2 = "JPContract_SecurityWorkers";

        string _swID = "SWorkerID";
        string _npcID = "NPContractID";
        string _jpcID = "JPContractID";

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
        private void Deleting(string table, string id1, string id2, DataGridView dataGridView, DataGridViewRowCancelEventArgs e)
        {
            if (dataGridView.CurrentRow.Cells[id1].Value != DBNull.Value && dataGridView.CurrentRow.Cells[id2].Value != DBNull.Value)
            {
                if (MessageBox.Show("Delete this record?", $"{table} services table", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string id_table1 = dataGridView.CurrentRow.Cells[id1].Value.ToString();
                    string id_table2 = dataGridView.CurrentRow.Cells[id2].Value.ToString();
                    connection.Open();
                    string query2 = $"delete from {table} where SWorkerID = {id_table1} and {id2} = {id_table2}";
                    SqlCommand sqlCommand = new SqlCommand(query2, connection);
                    try
                    {
                        sqlCommand.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch
                    {
                        MessageBox.Show(" Error.");
                        e.Cancel = true;
                        connection.Close();
                    }

                }
                else
                {
                    e.Cancel = true;
                    connection.Close();
                }

            }
        }
        private void NPCGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            Deleting(table1, _swID, _npcID, NPCGrid, e);
        }

        private void JPCGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            Deleting(table2, "SWorkerID3", _jpcID, JPCGrid, e);
        }

        private void AddJPButton_MouseEnter(object sender, EventArgs e)
        {
            AddJPButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void AddJPButton_MouseLeave(object sender, EventArgs e)
        {
            AddJPButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void AddNPButton_MouseEnter(object sender, EventArgs e)
        {
            AddNPButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void AddNPButton_MouseLeave(object sender, EventArgs e)
        {
            AddNPButton.ForeColor = Color.FromArgb(234, 211, 144);
        }
        private void Adding(string table, Contract_W contract_W)
        {
            if (MessageBox.Show("Add this record?", $"{table} table", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                connection.Open();

                string query2 = $"insert into {table} values ( " +
                    $" {contract_W.ContractID} , {contract_W.SWorkerID} )";
                SqlCommand sqlCommand = new SqlCommand(query2, connection);
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    connection.Close();
                    LoadData();
                }
                catch
                {
                    MessageBox.Show(" Error.");
                    connection.Close();
                }

            }
            else
            {
                connection.Close();
            }
        }

        private void AddNPButton_Click(object sender, EventArgs e)
        {
            try
            {
                int cid = Convert.ToInt32(NPCGrid.CurrentRow.Cells[_npcID].Value.ToString());
                int swid = Convert.ToInt32(NPCGrid.CurrentRow.Cells[_swID].Value.ToString());

                Contract_W contract_W = new Contract_W(cid, swid);
                Adding(table1, contract_W);
            }
            catch
            {
                MessageBox.Show("Invalid format");
            }
        }

        private void AddJPButton_Click(object sender, EventArgs e)
        {
            try
            {
                int cid = Convert.ToInt32(JPCGrid.CurrentRow.Cells[_jpcID].Value.ToString());
                int swid = Convert.ToInt32(JPCGrid.CurrentRow.Cells["SWorkerID3"].Value.ToString());

                Contract_W contract_W = new Contract_W(cid, swid);
                Adding(table2, contract_W);
            }
            catch
            {
                MessageBox.Show("Invalid format");
            }
        }
    }
}
