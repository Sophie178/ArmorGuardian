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
    public partial class JPClients : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=PERIIT\MY_INSTANCE;Initial Catalog=kursach;Integrated Security=True");

        string query = "select * from JuridicalPersonClients ";

        string _table = "JuridicalPersonClients";
        string _name = "ClientName";
        string _address = "Address";
        string _phNumber = "PhoneNumber";
        string _taxreg = "TaxRegReasonPoint";
        string _taxref = "TaxReferNumber";
        string _psrn = "PSRN";
        string _add = "Additional";

        public JPClients()
        {
            InitializeComponent();

            LoadData();

        }

        private void LoadData()
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

        private JPClientsClass ValidateClients()
        {
            string name = ClientsGrid.CurrentRow.Cells[_name].Value.ToString();
            string add = ClientsGrid.CurrentRow.Cells[_add].Value.ToString();
            string phNumber = ClientsGrid.CurrentRow.Cells[_phNumber].Value.ToString();
            string taxref = ClientsGrid.CurrentRow.Cells[_taxref].Value.ToString();
            string taxreg = ClientsGrid.CurrentRow.Cells[_taxreg].Value.ToString();
            string psrn = ClientsGrid.CurrentRow.Cells[_psrn].Value.ToString();
            string address = ClientsGrid.CurrentRow.Cells[_address].Value.ToString();

            if (name != null && phNumber != null && address != null && add != null)
            {
                JPClientsClass jPClientsClass = new JPClientsClass(name, taxreg, taxref, address, psrn, phNumber, add);
                return jPClientsClass;
            }
            else
            {
                MessageBox.Show("Invalid Format");
                return null;
            }

        }
        private void Updating(string table, JPClientsClass jPClientsClass)
        {
            if (MessageBox.Show("Edit this record?", $"{table} table", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                connection.Open();
                string wID = ClientsGrid.CurrentRow.Cells["JPClientID"].Value.ToString();

                string query2 = $"update {table} set  " +
                    $" {_name}  = '{jPClientsClass.ClientName}', {_phNumber} = '{jPClientsClass.PhoneNumber}', {_address} = '{jPClientsClass.Address}', " +
                    $"{_psrn} = {jPClientsClass.PSRN}, {_taxreg}  = {jPClientsClass.TaxRegreasonPoint}, {_taxref} = {jPClientsClass.TaxReferNumber}, " +
                    $"{_add} = '{jPClientsClass.Additional}' " +
                    $"where JPClientID = {wID} ";
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

        private void Adding(string table, JPClientsClass jPClientsClass)
        {
            if (MessageBox.Show("Add this record?", $"{table} table", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                connection.Open();


                string query2 = $"insert into {table} values ( " +
                     $" '{jPClientsClass.ClientName}', '{jPClientsClass.TaxRegreasonPoint}', " +
                     $" '{jPClientsClass.TaxReferNumber}' , '{jPClientsClass.Address}' , '{jPClientsClass.PSRN}', " +
                    $" '{jPClientsClass.PhoneNumber}', '{jPClientsClass.Additional}') ";

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
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateClients().ClientName != "" && ValidateClients().PhoneNumber != ""
                    && ValidateClients().PSRN.ToString() != "" && ValidateClients().Address != "")
                    Updating(_table, ValidateClients());
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
                if (ValidateClients().ClientName != "" && ValidateClients().PhoneNumber != ""
                    && ValidateClients().PSRN.ToString() != "" && ValidateClients().Address != "")
                    Adding(_table, ValidateClients());
                else { MessageBox.Show("Empty cells are not allowed"); }
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
