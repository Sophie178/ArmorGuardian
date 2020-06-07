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
    public partial class Stock_All : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=PERIIT\MY_INSTANCE;Initial Catalog=kursach;Integrated Security=True");

        
        public Stock_All()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            string query1 = "select StockID, " +
                "se.EquipID, Equipment.[Name] as Category, Equipment.Model, TotalQuantity," +
                " Taken, FreeToUse as Free" +
                " from Stock_Equipment as se" +
                " inner join Equipment on Equipment.EquipID = se.EquipID";
            string query2 = "select StockID, sw.WeaponID," +
                " WName as Model, Description, TotalQuantity, Free " +
                " from Stock_Weapon as sw inner join Weapon " +
                "on sw.WeaponID = Weapon.WeaponID";
            string query3 = "select StockID, st.TransportID," +
                " Transport.Model, Transport.ManufactureYear, TotalQuantity, InUse as Taken, Free" +
                " from Stock_Transport as st " +
                " inner join Transport " +
                " on st.TransportID = Transport.TransportID";

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

        private void Deleting(string table, string id1, string id2,  DataGridView dataGridView, DataGridViewRowCancelEventArgs e)
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

        private void EqGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string table = "Stock_Equipment";
            string id1 = "StockID";
            string id2 = "EquipID";

            Deleting(table, id1, id2, EqGrid, e);
        }

        private void WeaponGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string table = "Stock_Weapon";
            string id1 = "StockID";
            string id2 = "WeaponID";

            Deleting(table, id1, id2, WeaponGrid, e);
        }

        private void TranGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string table = "Stock_Transport";
            string id1 = "StockID";
            string id2 = "TransportID";

            Deleting(table, id1, id2, TranGrid, e);
        }

    }
}
