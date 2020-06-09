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
    public partial class SecurityWInfo : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=PERIIT\MY_INSTANCE;Initial Catalog=kursach;Integrated Security=True");


        public SecurityWInfo(string id)
        {
            InitializeComponent();

            LoadData(id);
        }

        private void LoadData(string id)
        {
            string query1 = "select SecurityWorkers.SWorkerID, " +
                "[dbo].[Equipment].EquipID, " +
                "swe.Received, " +
                "[dbo].[Equipment].[Name], " +
                "[dbo].[Equipment].Model, " +
                "[dbo].[Equipment].[Description] from SecurityWorkers " +
                "inner join[dbo].[SecurityWorkers_Equipment] as swe " +
                "on SecurityWorkers.SWorkerID = swe.SWorkerID" +
                " inner join[dbo].[Equipment] " +
                "on [dbo].[Equipment].EquipID = swe.EquipID " +
                $"where SecurityWorkers.SWorkerID = {id}";

            string query2 = "select SecurityWorkers.SWorkerID," +
                " [dbo].[Weapon].WeaponID, " +
                "sww.Received, " +
                "[dbo].[Weapon].Model, " +
                "[dbo].[Weapon].[Description]  from SecurityWorkers " +
                "inner join[dbo].[SecurityWorkers_Weapon] as sww" +
                " on SecurityWorkers.SWorkerID = sww.SWorkerID" +
                " inner join[dbo].[Weapon]" +
                " on [dbo].[Weapon].WeaponID = sww.WeaponID" +
                $" where SecurityWorkers.SWorkerID = {id}";

            string query3 = "select SecurityWorkers.SWorkerID, " +
                "[dbo].[Transport].TransportID, " +
                "swt.Received ,[dbo].[Transport].Model, " +
                "[dbo].[Transport].CarBodyStyle from SecurityWorkers " +
                "inner join[dbo].[Transport_SecurityWorkers] as swt " +
                "on SecurityWorkers.SWorkerID = swt.SWorkerID " +
                "inner join[dbo].[Transport] " +
                "on [dbo].[Transport].TransportID = swt.TransportID " +
                $"where SecurityWorkers.SWorkerID = {id}";

            SqlCommand cmd = new SqlCommand(query1, connection);
            SqlCommand cmd2 = new SqlCommand(query2, connection);
            SqlCommand cmd3 = new SqlCommand(query3, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();

            DataTable equipTable = new DataTable();
            DataTable weapTable = new DataTable();
            DataTable tranTable = new DataTable();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(cmd2);
            SqlDataAdapter sqlDataAdapter3 = new SqlDataAdapter(cmd3);

            sqlDataAdapter.Fill(equipTable);
            sqlDataAdapter2.Fill(weapTable);
            sqlDataAdapter3.Fill(tranTable);

            EqGrid.DataSource = equipTable;
            WeaponGrid.DataSource = weapTable;
            TranGrid.DataSource = tranTable;

            connection.Close();

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            SecurityGuards securityGuards = new SecurityGuards();
            securityGuards.Show();
        }

        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            BackButton.ForeColor = Color.FromArgb(204, 32, 20);
        }

        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            BackButton.ForeColor = Color.FromArgb(234, 211, 144);
        }

    }
}
