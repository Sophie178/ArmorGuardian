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
    public partial class ServicesForm : Form
    {
        public ServicesForm()
        {
            InitializeComponent();
        }

        Point lastPoint;
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void MinimizeButton_MouseEnter(object sender, EventArgs e)
        {
            MinimizeButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void MinimizeButton_MouseLeave(object sender, EventArgs e)
        {
            MinimizeButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void AllServiceButton_MouseEnter(object sender, EventArgs e)
        {
            AllServiceButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void AllServiceButton_MouseLeave(object sender, EventArgs e)
        {
            AllServiceButton.ForeColor = Color.FromArgb(234, 211, 144);
        }


        private void CargoButton_MouseEnter(object sender, EventArgs e)
        {
            CargoButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void CargoButton_MouseLeave(object sender, EventArgs e)
        {
            CargoButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void FacilityButton_MouseEnter(object sender, EventArgs e)
        {
            FacilityButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void FacilityButton_MouseLeave(object sender, EventArgs e)
        {
            FacilityButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void MassEventsButton_MouseEnter(object sender, EventArgs e)
        {
            MassEventsButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void MassEventsButton_MouseLeave(object sender, EventArgs e)
        {
            MassEventsButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void TechButton_MouseEnter(object sender, EventArgs e)
        {
            TechButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void TechButton_MouseLeave(object sender, EventArgs e)
        {
            TechButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void BodyGuard_MouseEnter(object sender, EventArgs e)
        {
            BodyGuardButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void BodyGuard_MouseLeave(object sender, EventArgs e)
        {
            BodyGuardButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void AllServiceButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllTariffsForm tariffForm = new AllTariffsForm();
            tariffForm.Show();
        }

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

        private void BodyGuardButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BGForm bGForm = new BGForm();
            bGForm.Show();
        }

        private void CargoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CargoEsc cargoEscForm = new CargoEsc();
            cargoEscForm.Show();
        }

        private void FacilityButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacilityForm facilityForm = new FacilityForm();
            facilityForm.Show();
        }

        private void MassEventsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MassEventsForm massEventsForm = new MassEventsForm();
            massEventsForm.Show();
        }

        private void TechButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TechServices techServicesForm = new TechServices();
            techServicesForm.Show();
        }
    }
}
