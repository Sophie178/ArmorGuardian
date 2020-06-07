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
    public partial class OfficesStocksForm : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=PERIIT\MY_INSTANCE;Initial Catalog=kursach;Integrated Security=True");

        string query = "select * from Office inner join Stock on Stock.OfficeID = Office.OfficeID";

        public OfficesStocksForm()
        {
            InitializeComponent();

            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            DataTable tariffTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(tariffTable);

            TariffGrid.DataSource = tariffTable;

            connection.Close();
        }

        private void MainPageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mainMenu = new Menu();
            mainMenu.StartPosition = FormStartPosition.CenterScreen;
            mainMenu.Show();
        }

        private void MainPageButton_MouseEnter(object sender, EventArgs e)
        {
            MainPageButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void MainPageButton_MouseLeave(object sender, EventArgs e)
        {
            MainPageButton.ForeColor = Color.FromArgb(234, 211, 144);
        }
    }
}
