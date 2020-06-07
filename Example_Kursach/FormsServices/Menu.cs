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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void Gap_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Gap_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MinimizeButton_MouseEnter(object sender, EventArgs e)
        {
            MinimizeButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void MinimizeButton_MouseLeave(object sender, EventArgs e)
        {
            MinimizeButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void ServiceButton_MouseEnter(object sender, EventArgs e)
        {
            ServiceButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void ServiceButton_MouseLeave(object sender, EventArgs e)
        {
            ServiceButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void StaffButton_MouseEnter(object sender, EventArgs e)
        {
            StaffButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void StaffButton_MouseLeave(object sender, EventArgs e)
        {
            StaffButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void BuildingsButton_MouseEnter(object sender, EventArgs e)
        {
            BuildingsButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void BuildingsButton_MouseLeave(object sender, EventArgs e)
        {
            BuildingsButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void ContractButton_MouseEnter(object sender, EventArgs e)
        {
            ContractButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void ContractButton_MouseLeave(object sender, EventArgs e)
        {
            ContractButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void EquipmentButton_MouseEnter(object sender, EventArgs e)
        {
            EquipmentButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void EquipmentButton_MouseLeave(object sender, EventArgs e)
        {
            EquipmentButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void TransportButton_MouseEnter(object sender, EventArgs e)
        {
            TransportButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void TransportButton_MouseLeave(object sender, EventArgs e)
        {
            TransportButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void ServiceButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            ServicesForm services = new ServicesForm();
            services.StartPosition = FormStartPosition.CenterScreen;
            services.Show();

        }

        private void BuildingsButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            OfficesStocksForm officesStocksForm = new OfficesStocksForm();
            officesStocksForm.Show();

        }

        private void ContractButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Contracts_Clients contracts_clients = new Contracts_Clients();
            contracts_clients.Show();
        }

        private void StaffButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Staff staff = new Staff();
            staff.Show();
        }

        private void EquipmentButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Eq_WeaponForm eq_WeaponForm = new Eq_WeaponForm();
            eq_WeaponForm.Show();
        }

        private void TransportButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            TranspForm transpForm = new TranspForm();
            transpForm.StartPosition = FormStartPosition.CenterScreen;
            transpForm.Show();
        }

        private void SupplyButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Stock_All stock_All = new Stock_All();
            stock_All.Show();
        }

        private void SupplyButton_MouseEnter(object sender, EventArgs e)
        {
            SupplyButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void SupplyButton_MouseLeave(object sender, EventArgs e)
        {
            SupplyButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void StaffSupplyButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            SWorker_All sWorker_All = new SWorker_All();
            sWorker_All.Show();

        }

        private void StaffSupplyButton_MouseEnter(object sender, EventArgs e)
        {
            StaffSupplyButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void StaffSupplyButton_MouseLeave(object sender, EventArgs e)
        {
            StaffSupplyButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

        private void timetable_Click(object sender, EventArgs e)
        {
            this.Hide();

            NPC_Workers _Workers = new NPC_Workers();
            _Workers.Show();

        }

        private void timetable_MouseEnter(object sender, EventArgs e)
        {
            TimetableB.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void timetable_MouseLeave(object sender, EventArgs e)
        {
            TimetableB.ForeColor = Color.FromArgb(234, 211, 144);
        }
    }
}
