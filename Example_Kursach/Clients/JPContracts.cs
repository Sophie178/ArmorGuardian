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
using Example_Kursach.Clients;

namespace Example_Kursach
{
    public partial class JPContracts : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=PERIIT\MY_INSTANCE;Initial Catalog=kursach;Integrated Security=True");

        string query = "select * from JPContract";

        public JPContracts()
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
            //this.Hide();

            JPPaymentF jPPaymentF = new JPPaymentF();
            jPPaymentF.Show();

        }

        private void InfoButton_MouseEnter(object sender, EventArgs e)
        {
            InfoButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void InfoButton_MouseLeave(object sender, EventArgs e)
        {
            InfoButton.ForeColor = Color.FromArgb(234, 211, 144);
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
    }
}
