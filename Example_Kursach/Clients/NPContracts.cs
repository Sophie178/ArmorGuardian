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
using Example_Kursach.Clients;

namespace Example_Kursach
{
    public partial class NPContracts : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=PERIIT\MY_INSTANCE;Initial Catalog=kursach;Integrated Security=True");

        string query = "select * from NPContract";

        string _table = "NPContract";
        string _client = "NPClientID";
        string _start = "Start";
        string _end = "End";
        string _dateOfC = "DateOfContract";
        string _active = "Active";
        string _total = "TotalCost";
        string _cash = "CashPayment";
        string _tariff = "TariffID";

        public NPContracts()
        {
            InitializeComponent();
            LoadContracts();
           
        }

        private void LoadContracts()
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            DataTable contractTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(contractTable);

            ContractGrid.DataSource = contractTable;

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

        private void InfoButton_Click(object sender, EventArgs e)
        {
            NPCashlessF nPCashlessF = new NPCashlessF();
            nPCashlessF.Show();

        }

        Point lastPoint;
        private void LoginPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LoginPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void InfoButton_MouseEnter(object sender, EventArgs e)
        {
            InfoButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void InfoButton_MouseLeave(object sender, EventArgs e)
        {
            InfoButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void ContractGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Invalid format");
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

        private ContractClass ValidateContract()
        {
            DateTime end = Convert.ToDateTime(ContractGrid.CurrentRow.Cells[_end].Value.ToString());
            DateTime date = Convert.ToDateTime(ContractGrid.CurrentRow.Cells[_dateOfC].Value.ToString());
            DateTime start = Convert.ToDateTime(ContractGrid.CurrentRow.Cells[_start].Value.ToString());
            int client = Convert.ToInt32(ContractGrid.CurrentRow.Cells[_client].Value.ToString());
            int tariff = Convert.ToInt32(ContractGrid.CurrentRow.Cells[_tariff].Value.ToString());
            string total = ContractGrid.CurrentRow.Cells[_total].Value.ToString();
            int cash;
            int active;

            if (ContractGrid.CurrentRow.Cells[_active].Value.ToString() == "")
            {
                active = 0;
            }
            else
            {
                active = 1;
            }

            if (ContractGrid.CurrentRow.Cells[_cash].Value.ToString() == "")
            {
                cash = 0;
            }
            else
            {
                cash = 1;
            }

            ContractClass contractClass = new ContractClass(client, start, end, date, active, total, cash, tariff);
            return contractClass;
        }
        private void Updating(string table, ContractClass contractClass)
        {
            if (MessageBox.Show("Edit this record?", $"{table} table", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                connection.Open();
                string wID = ContractGrid.CurrentRow.Cells["NPContractID"].Value.ToString();

                string query2 = $"update {table} set  " +
                    $" {_client}  = {contractClass.ClientID}, {_start} = '{contractClass.Start.Date.ToString("d")}', " +
                    $" [{_end}] = '{contractClass.End.Date.ToString("d")}', {_dateOfC} = '{contractClass.DateOfContract.Date.ToString("d")}', " +
                    $"{_active} = {contractClass.Active}, {_total}  = '{contractClass.TotalCost}', {_cash} = {contractClass.CashPayment} , " +
                    $"{_tariff} = {contractClass.TariffID} " +
                    $"where NPContractID = {wID} ";
                SqlCommand sqlCommand = new SqlCommand(query2, connection);
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    connection.Close();

                    LoadContracts();
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

        private void Adding(string table, ContractClass contractClass)
        {
            if (MessageBox.Show("Add this record?", $"{table} table", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                connection.Open();


                string query2 = $"insert into {table} values ( " +
                     $" {contractClass.ClientID}, '{contractClass.Start.Date.ToString("d")}', '{contractClass.End.Date.ToString("d")}', " +
                     $" '{contractClass.DateOfContract.Date.ToString("d")}' , {contractClass.Active}, " +
                    $" '{contractClass.TotalCost}', {contractClass.CashPayment}, {contractClass.TariffID} )";

                SqlCommand sqlCommand = new SqlCommand(query2, connection);
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    connection.Close();
                    LoadContracts();
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
                
                Updating(_table, ValidateContract());
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
                 Adding(_table, ValidateContract());
            }
            catch
            {
                MessageBox.Show("Invalid format");
            }
        }
    }
}
