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
    public partial class SWorker_All : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=PERIIT\MY_INSTANCE;Initial Catalog=kursach;Integrated Security=True");


        public SWorker_All()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            string query1 = "select SecurityWorkers.SWorkerID, SecurityWorkers.Surname, SecurityWorkers.[Name], " +
                "[dbo].[Equipment].EquipID, " +
                "swe.DateReceived, " +
                "[dbo].[Equipment].[Name] as Category, " +
                "[dbo].[Equipment].Model, " +
                " StockID,  " +
                "swe.Returned from SecurityWorkers " +
                "inner join [dbo].[SecurityWorkers_Equipment] as swe " +
                "on SecurityWorkers.SWorkerID = swe.SWorkerID" +
                " inner join [dbo].[Equipment] " +
                "on [dbo].[Equipment].EquipID = swe.EquipID ";

            string query2 = "select SecurityWorkers.SWorkerID, SecurityWorkers.Surname, SecurityWorkers.[Name], " +
                " [dbo].[Weapon].WeaponID, " +
                "sww.Received, " +
                "[dbo].[Weapon].WName as model, " +
                "[dbo].[Weapon].[Description], StockID, " +
                "sww.Returned from SecurityWorkers " +
                "inner join[dbo].[SecurityWorkers_Weapon] as sww" +
                " on SecurityWorkers.SWorkerID = sww.SWorkerID" +
                " inner join[dbo].[Weapon]" +
                " on [dbo].[Weapon].WeaponID = sww.WeaponID";

            string query3 = "select SecurityWorkers.SWorkerID, SecurityWorkers.Surname, SecurityWorkers.[Name], " +
                "[dbo].[Transport].TransportID, " +
                "swt.Received, [dbo].[Transport].Model, " +
                "[dbo].[Transport].CarBodyStyle, StockID, " +
                "swt.Returned " +
                "from SecurityWorkers " +
                "inner join[dbo].[Transport_SecurityWorkers] as swt " +
                "on SecurityWorkers.SWorkerID = swt.SWorkerID " +
                "inner join[dbo].[Transport] " +
                "on [dbo].[Transport].TransportID = swt.TransportID ";

            SqlCommand cmd = new SqlCommand(query1, connection);
            SqlCommand cmd2 = new SqlCommand(query2, connection);
            SqlCommand cmd3 = new SqlCommand(query3, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();

            DataTable equipTable = new DataTable();
            DataTable weapTable = new DataTable();
            DataTable tranTable = new DataTable();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(cmd2);
            SqlDataAdapter sqlDataAdapter3 = new SqlDataAdapter(cmd3);

            sqlDataAdapter.Fill(equipTable);
            sqlDataAdapter2.Fill(weapTable);
            sqlDataAdapter3.Fill(tranTable);

            EqGrid.DataSource = equipTable;
            WeaponGrid.DataSource = weapTable;
            TranGrid.DataSource = tranTable;

            connection.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu mainMenu = new Menu();
            mainMenu.StartPosition = FormStartPosition.CenterScreen;
            mainMenu.Show();

        }
        private void Deleting(string table, string id1, string id2, DataGridView dataGridView, DataGridViewRowCancelEventArgs e)
        {
            if (dataGridView.CurrentRow.Cells[id1].Value != DBNull.Value)
            {
                if (MessageBox.Show("Delete this record?", $"{table} services table", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string id_table1 = dataGridView.CurrentRow.Cells[id1].Value.ToString();
                    string id_table2 = dataGridView.CurrentRow.Cells[id2].Value.ToString();
                    connection.Open();
                    string query2 = $"delete from {table} where {id1} = {id_table1} and {id2} = {id_table2}";
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

        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            BackButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            BackButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void TranGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string table = "Transport_SecurityWorkers";
            string id1 = "SWorkerID";
            string id2 = "TransportID";

            Deleting(table, id1, id2, TranGrid, e);
        }

        private void WeaponGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string table = "SecurityWorkers_Weapon";
            string id1 = "SWorkerID";
            string id2 = "WeaponID";

            Deleting(table, id1, id2, WeaponGrid, e);
        }

        private void EqGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string table = "SecurityWorkers_Equipment";
            string id1 = "SWorkerID";
            string id2 = "EquipID";

            Deleting(table, id1, id2, EqGrid, e);
        }
    }
}
