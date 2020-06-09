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
using System.Text.RegularExpressions;

namespace Example_Kursach
{
    public partial class NPClients : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=PERIIT\MY_INSTANCE;Initial Catalog=kursach;Integrated Security=True");

        string query = "select * from NaturalPersonClients";

        string _table = "NaturalPersonClients";
        string _surname = "Surname";
        string _name = "Name";
        string _dob = "DoB";
        string _address = "Address";
        string _phNumber = "PhoneNumber";
        string _email = "Email";
        string _pseries = "PSeries";
        string _passnumber = "PassNumber";
        string phoneNumberFormat = @"\+7-9[0-9]{2}-[0-9]{3}-[0-9]{2}-[0-9]{2}";


        public NPClients()
        {
            InitializeComponent();

            LoadClients();
        }

        private void LoadClients()
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            DataTable clientTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(clientTable);

            ClientsGrid.DataSource = clientTable;

            connection.Close();
        }

        private void MainPageButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Contracts_Clients contracts_clients = new Contracts_Clients();
            contracts_clients.Show();
        }

        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            BackButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            BackButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            AddButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void UpdateButton_MouseEnter(object sender, EventArgs e)
        {
            UpdateButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void UpdateButton_MouseLeave(object sender, EventArgs e)
        {
            UpdateButton.ForeColor = Color.FromArgb(234, 211, 144);
        
        }

        private NPClientClass ValidateClients()
        {
            string name = ClientsGrid.CurrentRow.Cells[_name].Value.ToString();
            string surname = ClientsGrid.CurrentRow.Cells[_surname].Value.ToString();
            string phNumber = ClientsGrid.CurrentRow.Cells[_phNumber].Value.ToString();
            DateTime dob = Convert.ToDateTime(ClientsGrid.CurrentRow.Cells[_dob].Value.ToString());
            int pseries = Convert.ToInt32(ClientsGrid.CurrentRow.Cells[_pseries].Value.ToString());
            int passnumber = Convert.ToInt32(ClientsGrid.CurrentRow.Cells[_passnumber].Value.ToString());
            string address = ClientsGrid.CurrentRow.Cells[_address].Value.ToString();
            string email = ClientsGrid.CurrentRow.Cells[_email].Value.ToString();

            if (name != null && surname != null)
            {

                NPClientClass nPClients = new NPClientClass(name, surname, dob, phNumber, address, email, pseries, passnumber);
                return nPClients;
            }
            else
            {
                MessageBox.Show("Invalid Format");
                return null;
            }

        }
        private void Updating(string table, NPClientClass nPClients)
        {
            if (MessageBox.Show("Edit this record?", $"{table} table", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                connection.Open();
                string wID = ClientsGrid.CurrentRow.Cells["NPClientID"].Value.ToString();

                string query2 = $"update {table} set  " +
                    $" {_name}  = '{nPClients.Name}', {_phNumber} = '{nPClients.PhoneNumber}', {_surname} = '{nPClients.Surname}', {_address} = '{nPClients.Address}', " +
                    $"{_pseries} = {nPClients.PSeries}, {_passnumber}  = {nPClients.PassNumber}, {_email} = '{nPClients.Email}' , " +
                    $"{_dob} = '{nPClients.DoB.Date.ToString("d")}' " +
                    $"where NPClientID = {wID} ";
                SqlCommand sqlCommand = new SqlCommand(query2, connection);
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    connection.Close();

                    LoadClients();
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

        private void Adding(string table, NPClientClass nPClients)
        {
            if (MessageBox.Show("Add this record?", $"{table} table", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                connection.Open();


                string query2 = $"insert into {table} values ( " +
                     $@" '{nPClients.Name}', '{nPClients.Surname}', '{nPClients.DoB.Date.ToString("d")}', '{nPClients.PhoneNumber}' , '{nPClients.Address}', " +
                    $" '{nPClients.Email}', {nPClients.PSeries}, {nPClients.PassNumber} )";

                SqlCommand sqlCommand = new SqlCommand(query2, connection);
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    connection.Close();
                    LoadClients();
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
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try 
            {
                if (ValidateClients() != null && ValidateClients().Name != "" && Regex.IsMatch(ValidateClients().PhoneNumber, phoneNumberFormat)
                    && ValidateClients().PassNumber.ToString() != "" && ValidateClients().Surname != "")
                    Updating(_table, ValidateClients());
                else { MessageBox.Show("Check empty cells or input format"); }
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
                if (ValidateClients() != null && ValidateClients().Name != "" && Regex.IsMatch(ValidateClients().PhoneNumber, phoneNumberFormat)
                    && ValidateClients().PassNumber.ToString() != "" && ValidateClients().Surname != "")
                    Adding(_table, ValidateClients());
                else { MessageBox.Show("Check empty cells or input format"); }
            }
            catch
            {
                MessageBox.Show("Invalid format");
            }
        }

        private void ClientsGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellStyle newStyle = new DataGridViewCellStyle();
            newStyle.Font = new Font("Perpetua Titling MT", 20, FontStyle.Regular);
            ClientsGrid.CurrentRow.DefaultCellStyle.Font = newStyle.Font;
        }

        private void ClientsGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewCellStyle newStyle = new DataGridViewCellStyle();
            newStyle.Font = new Font("Times New Roman", 20, FontStyle.Regular);
            ClientsGrid.CurrentRow.DefaultCellStyle.Font = newStyle.Font;
        }

        private void ClientsGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Invalid format");
        }
    }
}
