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
    public partial class DeleteForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=PERIIT\MY_INSTANCE;Initial Catalog=kursach;Integrated Security=True");

        public DeleteForm(string ServiceType)
        {
            InitializeComponent();

            string query = "select * from BodyGuardServices";

            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            DataTable tariffTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(tariffTable);

            connection.Close();
        }

        private void CancelTButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string tariffId = TariffIDBoxDelete.Text;
            int id;
            try
            {
                id = Convert.ToInt32(tariffId);


            }
            catch 
            {
                MessageBox.Show("Invalid ID");
            }


        }
    }
}
