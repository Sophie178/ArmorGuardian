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
    public partial class MassEventsForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=PERIIT\MY_INSTANCE;Initial Catalog=kursach;Integrated Security=True");

        string query = "select * from MassEventsProtection";

        string table = "MassEventsProtection";
        string _tId = "TariffID";
        string _mHours = "MaxHours";
        string _shifts = "Shifts";
        string _mPrice = "MinPrice";
        string _desc = "Description";

        public MassEventsForm()
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
                if (MessageBox.Show("Delete this record?", "Mass events protection services table", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string id = TariffGrid.CurrentRow.Cells["TariffID"].Value.ToString();
                    connection.Open();
                    string query2 = $"delete from MassEventsProtection where TariffID = {id}";
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

        private MassEventsClass ValidateMEService()
        {
            int tariff = Convert.ToInt32(TariffGrid.CurrentRow.Cells[_tId].Value.ToString());
            int maxHours = Convert.ToInt32(TariffGrid.CurrentRow.Cells[_mHours].Value.ToString());
            string desc = TariffGrid.CurrentRow.Cells[_desc].Value.ToString();
            string mPrice;
            int shifts = Convert.ToInt32(TariffGrid.CurrentRow.Cells[_shifts].Value.ToString());


            if (shifts > 0 && maxHours > 0)
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


                MassEventsClass meService = new MassEventsClass(tariff, maxHours, shifts, mPrice, desc);
                return meService;
            }
            else
            {
                MessageBox.Show("Invalid Format");
                return null;
            }

        }

        private void Updating(string table, MassEventsClass Service)
        {
            if (MessageBox.Show("Edit this record?", $"{table} table", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                connection.Open();


                string query2 = $"update {table} set  " +
                    $" {_mHours} = {Service.MaxHours}, " +
                    $" {_mPrice} = {Service.MinPrice},  " +
                    $" {_desc} = '{Service.Description}', " +
                    $" {_shifts} = {Service.Shifts}" +
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

        private void Adding(string table, MassEventsClass Service)
        {
            if (MessageBox.Show("Add this record?", $"{table} table", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                connection.Open();


                string query2 = $"insert into {table} values ({Service.TariffID}, " +
                    $" {Service.MaxHours},  {Service.Shifts}, {Service.MinPrice}, " +
                    $" '{Service.Description}')";
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
                if (ValidateMEService() != null && ValidateMEService().Description != "")
                    Updating(table, ValidateMEService());
                else { MessageBox.Show("Empty cells are not allowed"); }
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
                if (ValidateMEService() != null && ValidateMEService().Description != "")
                    Adding(table, ValidateMEService());
                else { MessageBox.Show("Empty cells are not allowed"); }
            }
            catch
            {
                MessageBox.Show("Invalid format");
            }
        }
    }
}
