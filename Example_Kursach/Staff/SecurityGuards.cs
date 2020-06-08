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
    public partial class SecurityGuards : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=PERIIT\MY_INSTANCE;Initial Catalog=kursach;Integrated Security=True");

        string query = "select * from SecurityWorkers";

        string _table = "SecurityWorkers";
        string _surname = "Surname";
        string _name = "Name";
        string _dob = "DoB";
        string _address = "Address";
        string _phNumber = "PhoneNumber";
        string _rank = "LRank";
        string _license = "LicenseExpDate";
        string _unit = "UnitID";
        string _position = "Position";


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

        private void StaffGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellStyle newStyle = new DataGridViewCellStyle();
            newStyle.Font = new Font("Perpetua Titling MT", 24, FontStyle.Regular);
            StaffGrid.CurrentRow.DefaultCellStyle.Font = newStyle.Font;
        }

        private void StaffGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewCellStyle newStyle = new DataGridViewCellStyle();
            newStyle.Font = new Font("Times New Roman", 24, FontStyle.Regular);
            StaffGrid.CurrentRow.DefaultCellStyle.Font = newStyle.Font;
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

        private Guard ValidateGuard()
        {
            string name = StaffGrid.CurrentRow.Cells[_name].Value.ToString();
            string surname = StaffGrid.CurrentRow.Cells[_surname].Value.ToString();
            string phNumber = StaffGrid.CurrentRow.Cells[_phNumber].Value.ToString();
            DateTime dob = Convert.ToDateTime(StaffGrid.CurrentRow.Cells[_dob].Value.ToString());
            DateTime licenseExp = Convert.ToDateTime(StaffGrid.CurrentRow.Cells[_license].Value.ToString());
            int unit = Convert.ToInt32(StaffGrid.CurrentRow.Cells[_unit].Value.ToString());
            int rank = Convert.ToInt32(StaffGrid.CurrentRow.Cells[_rank].Value.ToString());
            string address = StaffGrid.CurrentRow.Cells[_address].Value.ToString();
            string position = StaffGrid.CurrentRow.Cells[_position].Value.ToString();

            if (name != null && surname != null)
            {

                Guard guard = new Guard(surname, name, dob, address, phNumber, rank, licenseExp,unit, position);
                return guard;
            }
            else
            {
                MessageBox.Show("Invalid Format");
                return null;
            }

        }
        private void Updating(string table, Guard guard)
        {
            if (MessageBox.Show("Edit this record?", $"{table} table", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                connection.Open();
                string wID = StaffGrid.CurrentRow.Cells["SWorkerID"].Value.ToString();

                string query2 = $"update {table} set  " +
                    $" {_name}  = '{guard.Name}', {_phNumber} = '{guard.PhoneNumber}', {_surname} = '{guard.Surname}', {_address} = '{guard.Address}', " +
                    $"{_unit} = {guard.UnitID}, {_position}  = '{guard.Position}', {_rank} = {guard.LRank}, " +
                    $"{_license} = '{guard.License.Date.ToString("d")}', {_dob} = '{guard.DoB.Date.ToString("d")}' " +
                    $"where SWorkerID = {wID} ";
                SqlCommand sqlCommand = new SqlCommand(query2, connection);
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    DataTable tariffTable = new DataTable();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    sqlDataAdapter.Fill(tariffTable);

                    StaffGrid.DataSource = tariffTable;
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

        private void Adding(string table, Guard guard)
        {
            if (MessageBox.Show("Add this record?", $"{table} table", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                connection.Open();


                string query2 = $"insert into {table} values ( " +
                     $@" '{guard.Surname}', '{guard.Name}', '{guard.DoB.Date.ToString("d")}', '{guard.Address}', " +
                    $" '{guard.PhoneNumber}' , {guard.LRank}, '{guard.License.Date.ToString("d")}', {guard.UnitID}, '{guard.Position}' )";

                SqlCommand sqlCommand = new SqlCommand(query2, connection);
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    DataTable Table = new DataTable();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    sqlDataAdapter.Fill(Table);

                    StaffGrid.DataSource = Table;
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
                if (ValidateGuard() != null && ValidateGuard().Name != "" && ValidateGuard().PhoneNumber != "" 
                    && ValidateGuard().UnitID.ToString() != "" && ValidateGuard().LRank <= 6 && ValidateGuard().LRank >= 4)
                    Updating(_table, ValidateGuard());
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
                if (ValidateGuard() != null && ValidateGuard().Name != "" && ValidateGuard().PhoneNumber != ""
                    && ValidateGuard().UnitID.ToString() != "" && ValidateGuard().LRank <= 6 && ValidateGuard().LRank >= 4)
                    Adding(_table, ValidateGuard());
                else { MessageBox.Show("Empty cells are not allowed"); }
            }
            catch
            {
                MessageBox.Show("Invalid format");
            }
        }
    }
}
