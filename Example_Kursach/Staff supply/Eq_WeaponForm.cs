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
using System.Collections.Specialized;

namespace Example_Kursach
{
    public partial class Eq_WeaponForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=PERIIT\MY_INSTANCE;Initial Catalog=kursach;Integrated Security=True");

        string equipQ = "select * from Equipment";
        string weaponQ = "select * from Weapon";

        public Eq_WeaponForm()
        {
            InitializeComponent();

            SqlCommand cmd1 = new SqlCommand(equipQ, connection);
            connection.Open();
            cmd1.ExecuteNonQuery();
            DataTable eqTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd1);
            sqlDataAdapter.Fill(eqTable);

            EqGrid.DataSource = eqTable;


            SqlCommand cmd2 = new SqlCommand(weaponQ, connection);
            cmd1.ExecuteNonQuery();
            DataTable wTable = new DataTable();
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(cmd2);
            sqlDataAdapter2.Fill(wTable);

            WeaponGrid.DataSource = wTable;


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

        private void EqGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string table = "Equipment";
            string id = "EquipID";

            Deleting(table, id, EqGrid, e);
        }

        private void WeaponGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string table = "Weapon";
            string id = "WeaponID";

            Deleting(table, id, WeaponGrid, e);
        }

        private void WeaponGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewCellStyle newStyle = new DataGridViewCellStyle();
            newStyle.Font = new Font("Times New Roman", 20, FontStyle.Regular);
            WeaponGrid.CurrentRow.DefaultCellStyle.Font = newStyle.Font;
        }

        private void WeaponGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellStyle newStyle = new DataGridViewCellStyle();
            newStyle.Font = new Font("Perpetua Titling MT", 20, FontStyle.Regular);
            WeaponGrid.CurrentRow.DefaultCellStyle.Font = newStyle.Font;
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

        private void UpdateWeapButton_MouseEnter(object sender, EventArgs e)
        {
            UpdateWeapButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void UpdateWeapButton_MouseLeave(object sender, EventArgs e)
        {
            UpdateWeapButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void AddWeaponButton_MouseEnter(object sender, EventArgs e)
        {
            UpdateWeapButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void AddWeaponButton_MouseLeave(object sender, EventArgs e)
        {
            AddWeaponButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void EqGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellStyle newStyle = new DataGridViewCellStyle();
            newStyle.Font = new Font("Perpetua Titling MT", 20, FontStyle.Regular);
            EqGrid.CurrentRow.DefaultCellStyle.Font = newStyle.Font;
        }

        private void EqGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewCellStyle newStyle = new DataGridViewCellStyle();
            newStyle.Font = new Font("Times New Roman", 20, FontStyle.Regular);
            EqGrid.CurrentRow.DefaultCellStyle.Font = newStyle.Font;

        }
    }
}
