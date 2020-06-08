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
    public partial class OfficesStocksForm : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=PERIIT\MY_INSTANCE;Initial Catalog=kursach;Integrated Security=True");

        string query = "select * from Office";
        string query1 = "select * from Stock";

        string tableO = "Office";
        string tableS = "Stock";

        string _addressO = "Address";
        string _phNumberO = "Phone";

        string _addressS = "StockAddress";
        string _phNumberS = "PhoneNumber";
        string _office = "OfficeID";


        public OfficesStocksForm()
        {
            InitializeComponent();

            SqlCommand cmd = new SqlCommand(query, connection);
            SqlCommand cmd2 = new SqlCommand(query1, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            DataTable officeTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(officeTable);

            DataTable stockTable = new DataTable();
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(cmd2);
            sqlDataAdapter1.Fill(stockTable);

            Grid.DataSource = officeTable;
            StockGrid.DataSource = stockTable;

            connection.Close();
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

        private void UpdateButton_MouseEnter(object sender, EventArgs e)
        {
            UpdateButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void UpdateButton_MouseLeave(object sender, EventArgs e)
        {
            UpdateButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            AddButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void Grid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewCellStyle newStyle = new DataGridViewCellStyle();
            newStyle.Font = new Font("Times New Roman", 22, FontStyle.Regular);
            Grid.CurrentRow.DefaultCellStyle.Font = newStyle.Font;
        }

        private void Grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellStyle newStyle = new DataGridViewCellStyle();
            newStyle.Font = new Font("Perpetua Titling MT", 24, FontStyle.Regular);
            Grid.CurrentRow.DefaultCellStyle.Font = newStyle.Font;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateStock() != null && ValidateStock().Address != "")
                    UpdatingS(tableS, ValidateStock());
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
                if (ValidateStock() != null  &&  ValidateStock().Address != "")
                    AddingS(tableS, ValidateStock());
                else { MessageBox.Show("Empty cells are not allowed"); }
            }
            catch
            {
                MessageBox.Show("Invalid format");
            }
        }

        private OfficeClass ValidateOffice()
        {
            string address = Grid.CurrentRow.Cells[_addressO].Value.ToString();
            string phNumber = Grid.CurrentRow.Cells[_phNumberO].Value.ToString();

            if (address != null && phNumber != null)
            {

                OfficeClass equip = new OfficeClass(address, phNumber);
                return equip;
            }
            else
            {
                MessageBox.Show("Invalid Format");
                return null;
            }

        }
        private StockClass ValidateStock()
        {
            string address = StockGrid.CurrentRow.Cells[_addressS].Value.ToString();
            string phNumber = StockGrid.CurrentRow.Cells[_phNumberS].Value.ToString();
            int office = Convert.ToInt32(StockGrid.CurrentRow.Cells["OfficeID"].Value.ToString());

            if (address != null && phNumber != null)
            {

                StockClass stock = new StockClass(address, phNumber, office);
                return stock;
            }
            else
            {
                MessageBox.Show("Invalid Format");
                return null;
            }

        }

        private void UpdatingS(string table, StockClass stock)
        {
            if (MessageBox.Show("Edit this record?", $"{table} table", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                connection.Open();
                string sID = StockGrid.CurrentRow.Cells["StockID"].Value.ToString();

                string queryS = $"update {tableS} set  " +
                    $" {_addressS}  = '{stock.Address}', {_phNumberS} = '{stock.PhoneNumber}', {_office} = {stock.Office} " +
                    $"where StockID = {sID} ";
                SqlCommand sqlCommand2 = new SqlCommand(queryS, connection);
                try
                {
                    sqlCommand2.ExecuteNonQuery();
                    SqlCommand cmd = new SqlCommand(query1, connection);
                    cmd.ExecuteNonQuery();
                    DataTable Table = new DataTable();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    sqlDataAdapter.Fill(Table);

                    StockGrid.DataSource = Table;
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

        private void AddingS( string table, StockClass stock)
        {
            if (MessageBox.Show("Add this record?", $"{table} table", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                connection.Open();
               
                string queryS = $"insert into {table} values ( " +
                     $@" '{stock.Address}', " +
                    $" '{stock.PhoneNumber}' , {stock.Office})";

                SqlCommand sqlCommand = new SqlCommand(queryS, connection);
                
                try
                {
                    sqlCommand.ExecuteNonQuery();

                    SqlCommand cmd = new SqlCommand(query1, connection);
                    cmd.ExecuteNonQuery();
                    DataTable Table = new DataTable();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    sqlDataAdapter.Fill(Table);

                    StockGrid.DataSource = Table;

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
        private void AddingO(string table, OfficeClass office)
        {
            if (MessageBox.Show("Add this record?", $"{table} table", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                connection.Open();

                string queryO = $"insert into {table} values ( " +
                     $@" '{office.Address}', " +
                    $" '{office.PhoneNumber}' )";

                SqlCommand sqlCommand = new SqlCommand(queryO, connection);

                try
                {
                    sqlCommand.ExecuteNonQuery();

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    DataTable Table = new DataTable();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    sqlDataAdapter.Fill(Table);

                    Grid.DataSource = Table;

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

        private void UpOButton_MouseEnter(object sender, EventArgs e)
        {
            UpOButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void UpOButton_MouseLeave(object sender, EventArgs e)
        {
            UpOButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void addOButton_MouseEnter(object sender, EventArgs e)
        {
            addOButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void addOButton_MouseLeave(object sender, EventArgs e)
        {
            addOButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void addOButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateOffice() != null && ValidateOffice().Address != "")
                    AddingO(tableO, ValidateOffice());
                else { MessageBox.Show("Empty cells are not allowed"); }
            }
            catch
            {
                MessageBox.Show("Invalid format");
            }
        }

        private void UpOButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateOffice() != null && ValidateOffice().Address != "")
                    UpdatingO(tableO, ValidateOffice());
                else { MessageBox.Show("Empty cells are not allowed"); }
            }
            catch
            {
                MessageBox.Show("Invalid format");
            }
        }
        private void UpdatingO(string table, OfficeClass office)
        {
            if (MessageBox.Show("Edit this record?", $"{table} table", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                connection.Open();
                string oID = Grid.CurrentRow.Cells["OfficeID"].Value.ToString();

                string queryO = $"update {tableO} set  " +
                    $" {_addressO}  = '{office.Address}', {_phNumberO} = '{office.PhoneNumber}' " +
                    $"where OfficeID = {oID} ";

                SqlCommand sqlCommand1 = new SqlCommand(queryO, connection);
                
                try
                {
                    sqlCommand1.ExecuteNonQuery();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    DataTable Table = new DataTable();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    sqlDataAdapter.Fill(Table);

                    Grid.DataSource = Table;
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

        private void Grid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string id = "OfficeID";
            Deleting(tableO, id, Grid, e);
        }

        private void StockGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string id = "StockID";
            Deleting(tableS, id, StockGrid, e);
        }

        private void Deleting(string table, string id, DataGridView dataGridView, DataGridViewRowCancelEventArgs e)
        {
            if (dataGridView.CurrentRow.Cells[id].Value != DBNull.Value)
            {
                if (MessageBox.Show("Delete this record?", $"{table} services table", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string id_table = dataGridView.CurrentRow.Cells[id].Value.ToString();
                    connection.Open();
                    string query2 = $"delete from {table} where {id} = {id_table}";
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
    }
}
