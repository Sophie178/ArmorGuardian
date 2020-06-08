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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void MainPageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mainMenu = new Menu();
            mainMenu.StartPosition = FormStartPosition.CenterScreen;
            mainMenu.Show();
        }

        private void DepButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepForms depForm = new DepForms();
            depForm.Show();
        }

        private void DStaffButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            EmpForm empForm = new EmpForm();
            empForm.Show();
        }

        private void SUnitButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            UnitForm unitForm = new UnitForm();
            unitForm.Show();
        }

        private void SGuardButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            SecurityGuards guardForm = new SecurityGuards();
            guardForm.Show();
        }

        private void MainPageButton_MouseEnter(object sender, EventArgs e)
        {
            MainPageButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void MainPageButton_MouseLeave(object sender, EventArgs e)
        {
            MainPageButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void DepButton_MouseEnter(object sender, EventArgs e)
        {
            DepButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void DepButton_MouseLeave(object sender, EventArgs e)
        {
            DepButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void DStaffButton_MouseEnter(object sender, EventArgs e)
        {
            DStaffButton.ForeColor = Color.FromArgb(204, 32, 20);

        }

        private void DStaffButton_MouseLeave(object sender, EventArgs e)
        {
            DStaffButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void SUnitButton_MouseEnter(object sender, EventArgs e)
        {
            SUnitButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void SUnitButton_MouseLeave(object sender, EventArgs e)
        {
            SUnitButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void SGuardButton_MouseEnter(object sender, EventArgs e)
        {
            SGuardButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void SGuardButton_MouseLeave(object sender, EventArgs e)
        {
            SGuardButton.ForeColor = Color.FromArgb(234, 211, 144);
        }
    }
}
