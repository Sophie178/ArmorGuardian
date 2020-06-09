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
    public partial class AllTariffsForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=PERIIT\MY_INSTANCE;Initial Catalog=kursach;Integrated Security=True");

        string query = "select TariffID, se.ServiceID, " +
            "se.Name as Category, " +
            "su.UnitID, " +
            "su.UnitName as Unit_Name " +
            "from AllTariffs " +
            "as ats inner join Service as se" +
            " on ats.ServiceID = se.ServiceID " +
            "inner join SecurityUnit as su " +
            "on su.UnitID = ats.UnitID ";

        public AllTariffsForm()
        {
            InitializeComponent();

            LoadTariff();
           
        }
        private void LoadTariff()
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            DataTable tariffTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(tariffTable);

            TariffGrid.DataSource = tariffTable;
            
            connection.Close();
        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainPageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mainMenu = new Menu();
            mainMenu.StartPosition = FormStartPosition.CenterScreen;
            mainMenu.Show();
        }

        private void MainPageButton_MouseEnter(object sender, EventArgs e)
        {
            MainPageButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void MainPageButton_MouseLeave(object sender, EventArgs e)
        {
            MainPageButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void MinimizeButton_MouseEnter(object sender, EventArgs e)
        {
            MinimizeButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void MinimizeButton_MouseLeave(object sender, EventArgs e)
        {
            MinimizeButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void SaveButton_MouseEnter(object sender, EventArgs e)
        {
            AddButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void SaveButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void TariffGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if(TariffGrid.CurrentRow.Cells["TariffID"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Delete this record?", "All services table", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //SqlCommand cmd = new SqlCommand(query, connection);
                    string id = TariffGrid.CurrentRow.Cells["TariffID"].Value.ToString();
                    connection.Open();
                    string query2 = $"delete from AllTariffs where TariffID = {id}";
                    SqlCommand sqlCommand = new SqlCommand(query2, connection);
                    try
                    {
                        sqlCommand.ExecuteNonQuery();
                        
                        connection.Close();
                    }
                    catch
                    {
                        MessageBox.Show(" Error. Firstly, check other service tables");
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

        private void Updating(string table, string tid, string sid, string uid)
        {
            if (TariffGrid.CurrentRow.Cells[tid].Value != DBNull.Value || 
                TariffGrid.CurrentRow.Cells[sid].Value != DBNull.Value || TariffGrid.CurrentRow.Cells[uid].Value != DBNull.Value)
            {
                string id1 = TariffGrid.CurrentRow.Cells[tid].Value.ToString();
                string id2 = TariffGrid.CurrentRow.Cells[sid].Value.ToString();
                string id3 = TariffGrid.CurrentRow.Cells[uid].Value.ToString();


                if (MessageBox.Show("Update this record?", "All services table", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    connection.Open();
                    string query2 = $"update {table} set {tid} = {id1}, {sid} = {id2}, {uid} = {id3}  where TariffID = {id1}";
                    SqlCommand sqlCommand = new SqlCommand(query2, connection);
                    try
                    {
                        sqlCommand.ExecuteNonQuery();
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        DataTable tariffTable = new DataTable();
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                        sqlDataAdapter.Fill(tariffTable);

                        TariffGrid.DataSource = tariffTable;
                        connection.Close();
                    }
                    catch
                    {
                        MessageBox.Show(" Error. ");
                        connection.Close();
                    }

                }
                else
                {
                    connection.Close();
                }
            }
        }

        private void Adding(string table, string tid, string sid, string uid)
        {
            if (TariffGrid.CurrentRow.Cells[tid].Value != DBNull.Value ||
                TariffGrid.CurrentRow.Cells[sid].Value != DBNull.Value || TariffGrid.CurrentRow.Cells[uid].Value != DBNull.Value)
            {
                string id1 = TariffGrid.CurrentRow.Cells[tid].Value.ToString();
                string id2 = TariffGrid.CurrentRow.Cells[sid].Value.ToString();
                string id3 = TariffGrid.CurrentRow.Cells[uid].Value.ToString();


                if (MessageBox.Show("Add this record?", "All services table", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    connection.Open();
                    string query2 = $"insert into {table} values ( {id1}, {id2}, {id3})";
                    SqlCommand sqlCommand = new SqlCommand(query2, connection);
                    try
                    {
                        sqlCommand.ExecuteNonQuery();
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        DataTable tariffTable = new DataTable();
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                        sqlDataAdapter.Fill(tariffTable);

                        TariffGrid.DataSource = tariffTable;
                        connection.Close();
                    }
                    catch
                    {
                        MessageBox.Show(" Error ");
                        connection.Close();
                    }

                }
                else
                {
                    connection.Close();
                }
            }
        }

        private void TariffGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewCellStyle newStyle = new DataGridViewCellStyle();
            newStyle.Font = new Font("Times New Roman", 20, FontStyle.Regular);
            TariffGrid.CurrentRow.DefaultCellStyle.Font = newStyle.Font;

        }

        private void TariffGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellStyle newStyle = new DataGridViewCellStyle();
            newStyle.Font = new Font("Perpetua Titling MT", 20, FontStyle.Regular);
            TariffGrid.CurrentRow.DefaultCellStyle.Font = newStyle.Font;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string table = "AllTariffs";
            string _tId = "TariffID";
            string _sId = "ServiceID";
            string _uId = "UnitID";

            Updating(table, _tId, _sId, _uId);

        }

        private void UpdateButton_MouseEnter(object sender, EventArgs e)
        {
            UpdateButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void UpdateButton_MouseLeave(object sender, EventArgs e)
        {
            UpdateButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string table = "AllTariffs";
            string _tId = "TariffID";
            string _sId = "ServiceID";
            string _uId = "UnitID";

            Adding(table, _tId, _sId, _uId);
        }

        private void TariffGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Invalid format");
        }
    }
}
