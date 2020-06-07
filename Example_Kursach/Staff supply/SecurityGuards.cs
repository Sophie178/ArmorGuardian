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
    public partial class SecurityGuards : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=PERIIT\MY_INSTANCE;Initial Catalog=kursach;Integrated Security=True");

        string query = "select * from SecurityWorkers";

        public SecurityGuards()
        {
            InitializeComponent();

            LoadStaff();
        }
        private void LoadStaff()
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            DataTable staffTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(staffTable);

            StaffGrid.DataSource = staffTable;

            connection.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Staff staff = new Staff();
            staff.Show();
        }

        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            BackButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            BackButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void StaffGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (StaffGrid.CurrentRow.Cells["SWorkerID"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Delete this record?", "Security Workers table", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string id = StaffGrid.CurrentRow.Cells["SWorkerID"].Value.ToString();
                    connection.Open();
                    string query2 = $"delete from SecurityWorkers where SWorkerID = {id}";
                    SqlCommand sqlCommand = new SqlCommand(query2, connection);
                    try
                    {
                        sqlCommand.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch
                    {
                        MessageBox.Show(" Error. Firstly, check other service tables");
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

        private void InfoButton_Click_1(object sender, EventArgs e)
        {
            if (StaffGrid.CurrentRow.Cells["SWorkerID"].Value != DBNull.Value)
            {
                this.Hide();
                string id = StaffGrid.CurrentRow.Cells["SWorkerID"].Value.ToString();
                SecurityWInfo securityWInfo = new SecurityWInfo(id);
                securityWInfo.Show();
            }
        }

        private void InfoButton_MouseEnter(object sender, EventArgs e)
        {
            InfoButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void InfoButton_MouseLeave(object sender, EventArgs e)
        {
            InfoButton.ForeColor = Color.FromArgb(234, 211, 144);
        }
    }
}
