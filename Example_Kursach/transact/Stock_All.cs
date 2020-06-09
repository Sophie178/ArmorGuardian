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
    public partial class Stock_All : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=PERIIT\MY_INSTANCE;Initial Catalog=kursach;Integrated Security=True");

        string tableE = "Stock_Equipment";
        string tableW = "Stock_Weapon";
        string tableT = "Stock_Transport";

        string _sID = "StockID";
        string _eID = "EquipID";
        string _wID = "WeaponID";
        string _tID = "TransportID";

        string _total = "TotalQuantity";
        string _free = "Free";
        string _inUse = "InUse";
        
        public Stock_All()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            string query1 = "select StockID, " +
                "se.EquipID, Equipment.[Name] as Category, Equipment.Model, TotalQuantity," +
                " Free, InUse " +
                " from Stock_Equipment as se" +
                " inner join Equipment on Equipment.EquipID = se.EquipID";
            string query2 = "select StockID, sw.WeaponID," +
                " Model, Description, TotalQuantity, Free , InUse" +
                " from Stock_Weapon as sw inner join Weapon " +
                "on sw.WeaponID = Weapon.WeaponID";
            string query3 = "select StockID, st.TransportID," +
                " Transport.Model, Transport.ManufactureYear, TotalQuantity, Free, InUse" +
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
                    string query2 = $"delete from {table} where StockID = {id_table1} and {id2} = {id_table2}";
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
            string id1 = "StockID2";
            string id2 = "WeaponID";

            Deleting(table, id1, id2, WeaponGrid, e);
        }

        private void TranGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string table = "Stock_Transport";
            string id1 = "StockID3";
            string id2 = "TransportID";

            Deleting(table, id1, id2, TranGrid, e);
        }

        private void AddEButton_MouseEnter(object sender, EventArgs e)
        {
            AddEButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void AddEButton_MouseLeave(object sender, EventArgs e)
        {
            AddEButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void AddWButton_MouseEnter(object sender, EventArgs e)
        {
            AddWButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void AddWButton_MouseLeave(object sender, EventArgs e)
        {
            AddWButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            AddTransportB.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void AddTransport_MouseLeave(object sender, EventArgs e)
        {
            AddTransportB.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void Adding(string table, All_Stock all_Stock)
        {
            if (MessageBox.Show("Add this record?", $"{table} table", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                connection.Open();

                string query2 = $"insert into {table} values ( " +
                    $" {all_Stock.StockID} , {all_Stock.ItemId}, {all_Stock.Total}, {all_Stock.Free}, {all_Stock.InUse} )";
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

        private void AddEButton_Click(object sender, EventArgs e)
        {
            try
            {
                int itemId = Convert.ToInt32(EqGrid.CurrentRow.Cells[_eID].Value.ToString());
                int sid = Convert.ToInt32(EqGrid.CurrentRow.Cells[_sID].Value.ToString());
                int total = Convert.ToInt32(EqGrid.CurrentRow.Cells[_total].Value.ToString());
                int free = Convert.ToInt32(EqGrid.CurrentRow.Cells[_free].Value.ToString());
                int inU = Convert.ToInt32(EqGrid.CurrentRow.Cells[_inUse].Value.ToString());

                All_Stock all_Stock = new All_Stock(sid, itemId, total, free, inU);
                Adding(tableE, all_Stock);
            }
            catch
            {
                MessageBox.Show("Invalid format");
            }
        }

        private void AddWButton_Click(object sender, EventArgs e)
        {
            try
            {
                int itemId = Convert.ToInt32(WeaponGrid.CurrentRow.Cells[_wID].Value.ToString());
                int sid = Convert.ToInt32(WeaponGrid.CurrentRow.Cells["StockID2"].Value.ToString());
                int total = Convert.ToInt32(WeaponGrid.CurrentRow.Cells[_total].Value.ToString());
                int free = Convert.ToInt32(WeaponGrid.CurrentRow.Cells[_free].Value.ToString());
                int inU = Convert.ToInt32(WeaponGrid.CurrentRow.Cells[_inUse].Value.ToString());

                All_Stock all_Stock = new All_Stock(sid, itemId, total, free, inU);
                Adding(tableW, all_Stock);
            }
            catch
            {
                MessageBox.Show("Invalid format");
            }
        }
        private void AddTransportB_Click(object sender, EventArgs e)
        {
            try
            {
                int itemId = Convert.ToInt32(TranGrid.CurrentRow.Cells[_tID].Value.ToString());
                int sid = Convert.ToInt32(TranGrid.CurrentRow.Cells["StockID3"].Value.ToString());
                int total = Convert.ToInt32(TranGrid.CurrentRow.Cells[_total].Value.ToString());
                int free = Convert.ToInt32(TranGrid.CurrentRow.Cells[_free].Value.ToString());
                int inU = Convert.ToInt32(TranGrid.CurrentRow.Cells[_inUse].Value.ToString());

                All_Stock all_Stock = new All_Stock(sid, itemId, total, free, inU);
                Adding(tableT, all_Stock);
            }
            catch
            {
                MessageBox.Show("Invalid format");
            }
        }

        private void EqGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Invalid format");
        }

        private void TranGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Invalid format");
        }

        private void WeaponGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Invalid format");
        }
    }
}
