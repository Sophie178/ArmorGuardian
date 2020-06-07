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
    public partial class BGForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=PERIIT\MY_INSTANCE;Initial Catalog=kursach;Integrated Security=True");

        string query = "select * from BodyGuardServices";

        string table = "BodyGuardServices";
        string _tId = "TariffID";
        string _nId = "Name";
        string _dId = "Days";
        string _mHours = "MaxHours";
        string prPerDay = "PricePerDay";
        string mPrice = "MonthPrice";
        string armed = "Armed";
        string transport = "Transport";
        string _guards = "Guards";


        public BGForm()
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

        private BGService ValidateBGService()
        {
            int tariff = Convert.ToInt32(TariffGrid.CurrentRow.Cells[_tId].Value.ToString());
            string name = TariffGrid.CurrentRow.Cells[_nId].Value.ToString();
            int days = Convert.ToInt32(TariffGrid.CurrentRow.Cells[_dId].Value.ToString());
            int maxHours = Convert.ToInt32(TariffGrid.CurrentRow.Cells[_mHours].Value.ToString());
            string perDay;
            string monthPrice;
            int arm;
            int trans;

            if ((TariffGrid.CurrentRow.Cells[_mHours].Value != DBNull.Value || TariffGrid.CurrentRow.Cells[mPrice].Value != DBNull.Value)
                && Convert.ToInt32(TariffGrid.CurrentRow.Cells[_mHours].Value.ToString()) <= 24)
            {

                if (TariffGrid.CurrentRow.Cells[prPerDay].Value.ToString() != "")
                {
                    try
                    {
                        decimal firstTry = Convert.ToDecimal(TariffGrid.CurrentRow.Cells[prPerDay].Value.ToString());
                        perDay = TariffGrid.CurrentRow.Cells[prPerDay].Value.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Invalid format");
                        perDay = "";

                    }
                }
                else { perDay = "NULL"; }

                if (TariffGrid.CurrentRow.Cells[mPrice].Value.ToString() != "")
                {
                    try
                    {
                        decimal secondTry = Convert.ToDecimal(TariffGrid.CurrentRow.Cells[mPrice].Value.ToString());
                        monthPrice = TariffGrid.CurrentRow.Cells[mPrice].Value.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Invalid format");
                        monthPrice = "";
                    }

                }
                else
                {
                    monthPrice = "NULL";
                }

                if (TariffGrid.CurrentRow.Cells[armed].Value.ToString() == "")
                {
                    arm = 0;
                }
                else
                {
                    arm = 1;
                }

                if (TariffGrid.CurrentRow.Cells[transport].Value.ToString() == "")
                {
                    trans = 0;
                }
                else
                {
                    trans = 1;
                }

                int guards = Convert.ToInt32(TariffGrid.CurrentRow.Cells[_guards].Value.ToString());

                BGService bGService = new BGService(tariff, name, days, maxHours, perDay, monthPrice, arm, trans, guards);
                return bGService;
            }
            else
            {
                MessageBox.Show("Invalid Format");
                return null;
            }


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


        private void MinimizeButton_MouseEnter(object sender, EventArgs e)
        {
            MinimizeButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void MinimizeButton_MouseLeave(object sender, EventArgs e)
        {
            MinimizeButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void TariffGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (TariffGrid.CurrentRow.Cells["TariffID"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Delete this record?", "Body-guard services table", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    string id = TariffGrid.CurrentRow.Cells["TariffID"].Value.ToString();
                    connection.Open();
                    string query2 = $"delete from BodyGuardServices where TariffID = {id}";
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

        private void Updating(string table, BGService bGService)
        {
            if (MessageBox.Show("Edit this record?", $"{table} table", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                connection.Open();


                string query2 = $"update {table} set  " +
                     $@" {_nId} = '{bGService.Name}', " +
                    $" {_dId} = {bGService.Days}, {_mHours} = {bGService.MaxHours}, {prPerDay} = {bGService.PricePerDay}, " +
                    $" {mPrice} = {bGService.MonthPrice}, {armed} = {bGService.Armed}, {transport} = {bGService.Transport}, {_guards} = {bGService.Guards} " +
                    $"where  {_tId} = {bGService.TariffID}";
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

        private void Adding(string table, BGService bGService)
        {
            if (MessageBox.Show("Add this record?", $"{table} table", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                connection.Open();


                string query2 = $"insert into {table} values ({bGService.TariffID}, " +
                     $@" '{bGService.Name}', " +
                    $" {bGService.Days}, {bGService.MaxHours}, {bGService.PricePerDay}, " +
                    $"{ bGService.MonthPrice}, {bGService.Armed}, {bGService.Transport}, {bGService.Guards})";
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

        private void AddButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (ValidateBGService() != null)
                    Adding(table, ValidateBGService());
                else { MessageBox.Show("Empty cells are not allowed"); }
            }
            catch
            {
                MessageBox.Show("Invalid format");
            }


        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateBGService() != null)
                    Updating(table, ValidateBGService());
                else { MessageBox.Show("Empty cells are not allowed"); }
            }
            catch
            {
                MessageBox.Show("Invalid format");
            }
        }
    }
}
