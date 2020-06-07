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
    public partial class TranspForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=PERIIT\MY_INSTANCE;Initial Catalog=kursach;Integrated Security=True");

        string query = "select * from Transport";



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
    }
}
