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
    public partial class TranspForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=PERIIT\MY_INSTANCE;Initial Catalog=kursach;Integrated Security=True");

        string query = "select * from Transport";

        string table = "Transport";
        string _model = "Model";
        string _seats = "Seats";
        string _armor = "ArmorPlating";
        string _cStyle = "CarBodyStyle";
        string _year = "ManufactureYear";
        string _cit = "CIT";


        public TranspForm()
        {
            InitializeComponent();

            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            DataTable transportTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(transportTable);

            TransportGrid.DataSource = transportTable;

            connection.Close();
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

        private void TransportGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string table = "Transport";
            string id = "TransportID";

            Deleting(table, id, TransportGrid, e);
        }

        private void UpdateButton_MouseEnter(object sender, EventArgs e)
        {
            UpdateButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void UpdateButton_MouseLeave(object sender, EventArgs e)
        {
            UpdateButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void TransportGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewCellStyle newStyle = new DataGridViewCellStyle();
            newStyle.Font = new Font("Times New Roman", 20, FontStyle.Regular);
            TransportGrid.CurrentRow.DefaultCellStyle.Font = newStyle.Font;

        }

        private void TransportGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellStyle newStyle = new DataGridViewCellStyle();
            newStyle.Font = new Font("Perpetua Titling MT", 20, FontStyle.Regular);
            TransportGrid.CurrentRow.DefaultCellStyle.Font = newStyle.Font;
        }
        private TransportClass ValidateTransport()
        {
            string model = TransportGrid.CurrentRow.Cells[_model].Value.ToString();
            int seats = Convert.ToInt32(TransportGrid.CurrentRow.Cells[_seats].Value.ToString());
            string carStyle = TransportGrid.CurrentRow.Cells[_cStyle].Value.ToString();
            int manYear;
            int armor;
            int cit;


            if (Convert.ToInt32(TransportGrid.CurrentRow.Cells[_year].Value.ToString()) >= 1980 && model != null && carStyle != null)
            {

                if (TransportGrid.CurrentRow.Cells[_armor].Value.ToString() == "")
                {
                    armor = 0;
                }
                else
                {
                    armor = 1;
                }

                if (TransportGrid.CurrentRow.Cells[_cit].Value.ToString() == "")
                {
                    cit = 0;
                }
                else
                {
                    cit = 1;
                }

                manYear = Convert.ToInt32(TransportGrid.CurrentRow.Cells[_year].Value.ToString());

                TransportClass transport = new TransportClass( model, seats, armor, carStyle, manYear, cit);
                return transport;
            }
            else
            {
                MessageBox.Show("Invalid Format");
                return null;
            }

        }

        private void Updating(string table, TransportClass transport)
        {
            if (MessageBox.Show("Edit this record?", $"{table} table", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                connection.Open();
                string tID = TransportGrid.CurrentRow.Cells["TransportID"].Value.ToString();

                string query2 = $"update {table} set  {_model} = '{transport.Model}', " +
                    $" {_armor} = {transport.ArmorPlating}, {_seats} = {transport.Seats}, {_year} = {transport.ManufactureYear}, {_cStyle} = '{transport.CarBodyStyle}'," +
                    $" {_cit}  = {transport.CIT} " +
                    $"where TransportID = {tID} ";
                SqlCommand sqlCommand = new SqlCommand(query2, connection);
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    DataTable tariffTable = new DataTable();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    sqlDataAdapter.Fill(tariffTable);

                    TransportGrid.DataSource = tariffTable;
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

        private void Adding(string table, TransportClass transport)
        {
            if (MessageBox.Show("Add this record?", $"{table} table", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                connection.Open();


                string query2 = $"insert into {table} values ( " +
                     $@" '{transport.Model}', " +
                    $" {transport.Seats},  " +
                    $" {transport.ArmorPlating}, '{transport.CarBodyStyle}', {transport.ManufactureYear}, {transport.CIT})";
                SqlCommand sqlCommand = new SqlCommand(query2, connection);
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    DataTable tariffTable = new DataTable();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    sqlDataAdapter.Fill(tariffTable);

                    TransportGrid.DataSource = tariffTable;
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
                if (ValidateTransport() != null && ValidateTransport().Model != "" && ValidateTransport().CarBodyStyle != "")
                    Updating(table, ValidateTransport());
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
                if (ValidateTransport() != null && ValidateTransport().Model != "" && ValidateTransport().CarBodyStyle != "")
                    Adding(table, ValidateTransport());
                else { MessageBox.Show("Empty cells are not allowed"); }
            }
            catch
            {
                MessageBox.Show("Invalid format");
            }
        }

        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            AddButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.ForeColor = Color.FromArgb(234, 211, 144);
        }
    }
}
