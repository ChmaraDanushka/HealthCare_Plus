using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus
{
    public partial class p_report : Form
    {
        DataTable dt = new DataTable("doctor");
        public p_report()
        {
            InitializeComponent();
            LoadData();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I6FK5GB\SQLEXPRESS;Initial Catalog=helth_care;Integrated Security=True");

        private void FILLDGV()
        {
            con.Open();
            using (SqlDataAdapter da = new SqlDataAdapter("select *from patient", con))
            {
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            dataGridView1.AllowUserToAddRows = false;
            DataGridViewButtonColumn buttoncolumn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Insert(0, buttoncolumn);
            buttoncolumn.HeaderText = "Delete";
            buttoncolumn.Width = 100;
            buttoncolumn.Text = "DELETE";
            buttoncolumn.UseColumnTextForButtonValue = true;
            con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

        }

        private void LoadData()
        {


            // Define a SQL query to retrieve data from the database
            string query = "SELECT * FROM patient"; // Replace with your actual query

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to  DataGridView
                    dataGridView1.DataSource = dataTable;
                    Form7 form7 = new Form7();
                    form7.Refresh();
                }
            }

        }

        private void RefreshDataGridView()
        {
            // Assuming you have a method to re-populate the DataGridView (e.g., LoadData())
            // Call that method to refresh the DataGridView
            LoadData();

        }

    }
}
