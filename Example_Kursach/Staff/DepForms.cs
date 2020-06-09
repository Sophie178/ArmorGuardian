﻿using System;
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
    public partial class DepForms : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=PERIIT\MY_INSTANCE;Initial Catalog=kursach;Integrated Security=True");

        string query = "select * from Department";

        string _table = "Department";
        string _name = "Name";
        string _phNumber = "PhoneNumber";
        string _office = "OfficeID";
        string _floor = "Floor";

        public DepForms()
        {
            InitializeComponent();

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
        private void StaffGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string id = "DepID";
            Deleting(_table, id, StaffGrid, e);
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

        private DepClass ValidateDep()
        {
            string name = StaffGrid.CurrentRow.Cells[_name].Value.ToString();
            string phNumber = StaffGrid.CurrentRow.Cells[_phNumber].Value.ToString();
            int office = Convert.ToInt32(StaffGrid.CurrentRow.Cells[_office].Value.ToString());
            int floor = Convert.ToInt32(StaffGrid.CurrentRow.Cells[_floor].Value.ToString());

            if (name != null && phNumber != null)
            {

                DepClass depClass = new DepClass(name, phNumber, office, floor);
                return depClass;
            }
            else
            {
                MessageBox.Show("Invalid Format");
                return null;
            }

        }
        private void Updating(string table, DepClass depClass)
        {
            if (MessageBox.Show("Edit this record?", $"{table} table", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                connection.Open();
                string wID = StaffGrid.CurrentRow.Cells["DepID"].Value.ToString();

                string query2 = $"update {table} set  " +
                    $" {_name}  = '{depClass.Name}', {_phNumber} = '{depClass.PhoneNumber}', {_office} = {depClass.OfficeID}, {_floor}  = {depClass.Floor} " +
                    $"where DepID = {wID} ";
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

        private void Adding(string table, DepClass depClass)
        {
            if (MessageBox.Show("Add this record?", $"{table} table", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                connection.Open();


                string query2 = $"insert into {table} values ( " +
                     $@" '{depClass.Name}', " +
                    $" '{depClass.PhoneNumber}' , {depClass.OfficeID}, {depClass.Floor} )";

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
                if (ValidateDep() != null && ValidateDep().Name != "" && ValidateDep().PhoneNumber != "")
                    Updating(_table, ValidateDep());
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
                if (ValidateDep() != null && ValidateDep().Name != "" && ValidateDep().PhoneNumber != "")
                    Adding(_table, ValidateDep());
                else { MessageBox.Show("Empty cells are not allowed"); }
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
