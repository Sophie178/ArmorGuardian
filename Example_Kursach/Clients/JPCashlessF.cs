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

namespace Example_Kursach.Clients
{
    public partial class JPCashlessF : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=PERIIT\MY_INSTANCE;Initial Catalog=kursach;Integrated Security=True");

        string query = "select * from JPCashlessPayment";

        string _table = "JPCashlessPayment";
        string _contract = "JPContractID";
        string _bic = "BIC";
        string _tranAcc = "TransactAccount";
        string _corrAcc = "CorrespondentAcc";
        string _paymentDT = "PaymentDateTime";
        string _paid = "PaidAmount";


        public JPCashlessF()
        {
            InitializeComponent();
            LoadPayment();

        }
        private void LoadPayment()
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            DataTable contractTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(contractTable);

            PaymentGrid.DataSource = contractTable;

            connection.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MinimizeButton_MouseEnter(object sender, EventArgs e)
        {
            MinimizeButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void MinimizeButton_MouseLeave(object sender, EventArgs e)
        {
            MinimizeButton.ForeColor = Color.FromArgb(234, 211, 144);
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

        private JPCashless ValidatePayment()
        {
            DateTime date = Convert.ToDateTime(PaymentGrid.CurrentRow.Cells[_paymentDT].Value.ToString());
            int contract = Convert.ToInt32(PaymentGrid.CurrentRow.Cells[_contract].Value.ToString());
            string bic = PaymentGrid.CurrentRow.Cells[_bic].Value.ToString();
            string tranAcc = PaymentGrid.CurrentRow.Cells[_tranAcc].Value.ToString();
            string corrAcc = PaymentGrid.CurrentRow.Cells[_corrAcc].Value.ToString();
            string paid = PaymentGrid.CurrentRow.Cells[_paid].Value.ToString();

            JPCashless jPCashless = new JPCashless(contract, bic, tranAcc, corrAcc, date, paid);
            return jPCashless;
        }
        private void Updating(string table, JPCashless jPCashless)
        {
            if (MessageBox.Show("Edit this record?", $"{table} table", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                connection.Open();
                string wID = PaymentGrid.CurrentRow.Cells["CashlesPID"].Value.ToString();

                string query2 = $"update {table} set  " +
                    $" {_contract}  = {jPCashless.JPContract}, {_bic} = '{jPCashless.BIC}', " +
                    $"{_tranAcc} = '{jPCashless.TranAcc}', {_corrAcc} = '{jPCashless.CorrAcc}', " +
                    $"{_paymentDT} = '{jPCashless.PaymentDT}', {_paid}  = '{jPCashless.PaidAmount}' " +
                    $"where CashlesPID = {wID} ";
                SqlCommand sqlCommand = new SqlCommand(query2, connection);
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    connection.Close();

                    LoadPayment();
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

        private void Adding(string table, JPCashless jPCashless)
        {
            if (MessageBox.Show("Add this record?", $"{table} table", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                connection.Open();


                string query2 = $"insert into {table} values ( " +
                     $" {jPCashless.JPContract}, '{jPCashless.BIC}', '{jPCashless.TranAcc}', " +
                     $" '{jPCashless.CorrAcc}' , '{jPCashless.PaymentDT}', '{jPCashless.PaidAmount}' )";

                SqlCommand sqlCommand = new SqlCommand(query2, connection);
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    connection.Close();
                    LoadPayment();
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

                Updating(_table, ValidatePayment());
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
                Adding(_table, ValidatePayment());
            }
            catch
            {
                MessageBox.Show("Invalid format");
            }
        }

        private void PaymentGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Invalid format");
        }
    }
}
