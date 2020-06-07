using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_Kursach
{
    public partial class Contracts_Clients : Form
    {
        public Contracts_Clients()
        {
            InitializeComponent();
        }

        private void MainPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mainMenu = new Menu();
            mainMenu.StartPosition = FormStartPosition.CenterScreen;
            mainMenu.Show();
        }

        private void JPContractsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            JPContracts jPContracts = new JPContracts();
            jPContracts.Show();
        }

        private void NPContractsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            NPContracts nPContracts = new NPContracts();
            nPContracts.Show();
        }

        private void JPClientsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            JPClients jPClients = new JPClients();
            jPClients.Show();
        }

        private void NPClientsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            NPClients nPClients = new NPClients();
            nPClients.Show();
        }

        private void MainPage_MouseEnter(object sender, EventArgs e)
        {
            MainPage.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void MainPage_MouseLeave(object sender, EventArgs e)
        {
            MainPage.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void JPClientsButton_MouseEnter(object sender, EventArgs e)
        {
            JPClientsButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void JPClientsButton_MouseLeave(object sender, EventArgs e)
        {
            JPClientsButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void JPContractsButton_MouseEnter(object sender, EventArgs e)
        {
            JPContractsButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void JPContractsButton_MouseLeave(object sender, EventArgs e)
        {
            JPContractsButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void NPClientsButton_MouseEnter(object sender, EventArgs e)
        {
            NPClientsButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void NPClientsButton_MouseLeave(object sender, EventArgs e)
        {
            NPClientsButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void NPContractsButton_MouseEnter(object sender, EventArgs e)
        {
            NPContractsButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void NPContractsButton_MouseLeave(object sender, EventArgs e)
        {
            NPContractsButton.ForeColor = Color.FromArgb(234, 211, 144);
        }
    }
}
