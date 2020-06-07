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
    public partial class TechServices : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=PERIIT\MY_INSTANCE;Initial Catalog=kursach;Integrated Security=True");

        string query = "select * from TechnicalSecurity";

        string table = "TechnicalSecurity";
        string _tId = "TariffID";
        string _space = "MaxRoomSpace(m2)";
        string _mPrice = "MinPrice";
        string _desc = "Description";
        string _minMain = "MinMaintenancePrice";

        public TechServices()
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

        private void MainPageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mainMenu = new Menu();
            mainMenu.StartPosition = FormStartPosition.CenterScreen;
            mainMenu.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            AddButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void MainPageButton_MouseEnter(object sender, EventArgs e)
        {
            MainPageButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void MainPageButton_MouseLeave(object sender, EventArgs e)
        {
            MainPageButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void TariffGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (TariffGrid.CurrentRow.Cells["TariffID"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Delete this record?", "Technical services table", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string id = TariffGrid.CurrentRow.Cells["TariffID"].Value.ToString();
                    connection.Open();
                    string query2 = $"delete from TechnicalSecurity where TariffID = {id}";
                    SqlCommand sqlCommand = new SqlCommand(query2, connection);
                    try
                    {
                        sqlCommand.ExecuteNonQuery();
                        SqlCommand cmd = new SqlCommand(query, connection);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        DataTable tariffTable = new DataTable();
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                        sqlDataAdapter.Fill(tariffTable);

                        TariffGrid.DataSource = tariffTable;
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

        private void UpdateButton_MouseEnter(object sender, EventArgs e)
        {
            UpdateButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void UpdateButton_MouseLeave(object sender, EventArgs e)
        {
            UpdateButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private TechServicesClass ValidateTSService()
        {
            int tariff = Convert.ToInt32(TariffGrid.CurrentRow.Cells[_tId].Value.ToString());
            int maxRoom = Convert.ToInt32(TariffGrid.CurrentRow.Cells[_space].Value.ToString());
            string desc = TariffGrid.CurrentRow.Cells[_desc].Value.ToString();
            string mPrice;
            string maint = TariffGrid.CurrentRow.Cells[_minMain].Value.ToString();


            if (maxRoom> 0)
            {

                if (TariffGrid.CurrentRow.Cells[_mPrice].Value.ToString() != "")
                {
                    try
                    {
                        decimal secondTry = Convert.ToDecimal(TariffGrid.CurrentRow.Cells[_mPrice].Value.ToString());
                        mPrice = TariffGrid.CurrentRow.Cells[_mPrice].Value.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Invalid format");
                        mPrice = "";
                    }

                }
                else
                {
                    mPrice = "0";
                }



                TechServicesClass tsService = new TechServicesClass(tariff, maxRoom, desc, mPrice, maint);
                return tsService;
            }
            else
            {
                MessageBox.Show("Invalid Format");
                return null;
            }

        }

        private void Updating(string table, TechServicesClass Service)
        {
            if (MessageBox.Show("Edit this record?", $"{table} table", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                connection.Open();


                string query2 = $"update {table} set  " +
                    $" {_space} = {Service.MaxRoomSpace}, " +
                    $" {_mPrice} = {Service.MinPrice},  " +
                    $" {_desc} = '{Service.Description}', " +
                    $" {_minMain} = {Service.MinMaintenancePrice}" +
                    $" where  {_tId} = {Service.TariffID}";
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
                    MessageBox.Show(" Error.");
                    connection.Close();
                }

            }
            else
            {
                connection.Close();
            }
        }

        private void Adding(string table, TechServicesClass Service)
        {
            if (MessageBox.Show("Add this record?", $"{table} table", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                connection.Open();


                string query2 = $"insert into {table} values ({Service.TariffID}, " +
                    $" {Service.MaxRoomSpace},  " +
                    $" '{Service.Description}', {Service.MinPrice}, {Service.MinMaintenancePrice})";
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
                    MessageBox.Show(" Error.");
                    connection.Close();
                }

            }
            else
            {
                connection.Close();
            }
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateTSService() != null && ValidateTSService().Description != "")
                    Updating(table, ValidateTSService());
                else { MessageBox.Show("Invalid format"); }
            }
            catch
            {
                MessageBox.Show("Invalid format");
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateTSService() != null && ValidateTSService().Description != "")
                    Adding(table, ValidateTSService());
                else { MessageBox.Show("Invalid format"); }
            }
            catch
            {
                MessageBox.Show("Invalid format");
            }
        }

    }
}
