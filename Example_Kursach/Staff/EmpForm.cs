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
    public partial class EmpForm : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=PERIIT\MY_INSTANCE;Initial Catalog=kursach;Integrated Security=True");

        string query = "select * from Employee";

        string _table = "Employee";

        string _surname = "Surname";
        string _name = "Name";
        string _dob = "DoB";
        string _address = "Address";
        string _phNumber = "PhoneNumber";
        string _email = "Email";
        string _room = "Room";
        string _dep = "DepID";
        string _position = "Position";
        string phoneNumberFormat = @"\+7-9[0-9]{2}-[0-9]{3}-[0-9]{2}-[0-9]{2}";

        public EmpForm()
        {
            InitializeComponent();

            LoadWorkers();
        }

        private void LoadWorkers()
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
            if (StaffGrid.CurrentRow.Cells["EmployeeID"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Delete this record?", "Departments' Employees table", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string id = StaffGrid.CurrentRow.Cells["EmployeeID"].Value.ToString();
                    connection.Open();
                    string query2 = $"delete from Employee where EmpID = {id}";
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

        private void StaffGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewCellStyle newStyle = new DataGridViewCellStyle();
            newStyle.Font = new Font("Times New Roman", 24, FontStyle.Regular);
            StaffGrid.CurrentRow.DefaultCellStyle.Font = newStyle.Font;
        }

        private void StaffGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellStyle newStyle = new DataGridViewCellStyle();
            newStyle.Font = new Font("Perpetua Titling MT", 24, FontStyle.Regular);
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

        private Employee ValidateEmployee()
        {
            string name = StaffGrid.CurrentRow.Cells[_name].Value.ToString();
            string surname = StaffGrid.CurrentRow.Cells[_surname].Value.ToString();
            string phNumber = StaffGrid.CurrentRow.Cells[_phNumber].Value.ToString();
            DateTime dob = Convert.ToDateTime(StaffGrid.CurrentRow.Cells[_dob].Value.ToString());
            string email = StaffGrid.CurrentRow.Cells[_email].Value.ToString();
            int dep = Convert.ToInt32(StaffGrid.CurrentRow.Cells[_dep].Value.ToString());
            int room = Convert.ToInt32(StaffGrid.CurrentRow.Cells[_room].Value.ToString());
            string address = StaffGrid.CurrentRow.Cells[_address].Value.ToString();
            string position = StaffGrid.CurrentRow.Cells[_position].Value.ToString();

            if (name != null && surname != null)
            {

                Employee employee = new Employee(surname, name, dob, position, phNumber, address, email, dep, room);
                return employee;
            }
            else
            {
                MessageBox.Show("Invalid Format");
                return null;
            }

        }
        private void Updating(string table, Employee emp)
        {
            if (MessageBox.Show("Edit this record?", $"{table} table", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                connection.Open();
                string wID = StaffGrid.CurrentRow.Cells["EmployeeID"].Value.ToString();

                string query2 = $"update {table} set  " +
                    $" {_name}  = '{emp.Name}', {_phNumber} = '{emp.PhoneNumber}', {_surname} = '{emp.Surname}', {_address} = '{emp.Address}', " +
                    $"{_dep} = {emp.DepID}, {_position}  = '{emp.Position}', {_room} = {emp.Room}," +
                    $" {_email} = '{emp.Email}', {_dob} = '{emp.DoB.Date.ToString("d")}' " +
                    $"where EmpID = {wID} ";
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

        private void Adding(string table, Employee emp)
        {
            if (MessageBox.Show("Add this record?", $"{table} table", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                connection.Open();


                string query2 = $"insert into {table} values ( " +
                     $@" '{emp.Surname}', '{emp.Name}', '{emp.DoB.Date.ToString("d")}', '{emp.Position}', " +
                    $" '{emp.PhoneNumber}' , '{emp.Address}', '{emp.Email}', {emp.DepID}, {emp.Room} )";

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
                if (ValidateEmployee().Name != "" && Regex.IsMatch(ValidateEmployee().PhoneNumber, phoneNumberFormat) 
                    && ValidateEmployee().Surname != "" && ValidateEmployee().Address != "" && ValidateEmployee().Position != "")
                    Updating(_table, ValidateEmployee());
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
                if (ValidateEmployee().Name != "" && Regex.IsMatch(ValidateEmployee().PhoneNumber, phoneNumberFormat) 
                    && ValidateEmployee().Surname != "" && ValidateEmployee().Address != "" && ValidateEmployee().Position != "")
                    Adding(_table, ValidateEmployee());
                else { MessageBox.Show("Check empty cells or input format"); }
            }
            catch
            {
                MessageBox.Show("Invalid format");
            }
        }

        private void StaffGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Invalid format");
        }
    }
}
