using System;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace HealthCare_Plus
{
    public partial class helth_resouce : Form
    {
        bool flag = true;
        DataTable dt = new DataTable("helth_resource");
        public helth_resouce()
        {
            InitializeComponent();
            FILLDGV();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I6FK5GB\SQLEXPRESS;Initial Catalog=helth_care;Integrated Security=True");

        private void pt_add_Click(object sender, EventArgs e)
        {
            string hr_id;
            int lastHrId;
            int gen_id;

            if (hr_name.Text == "" || hr_qt.Text == "")
            {
                MessageBox.Show("please fill All  Details about resource");
                return;
            }
            else
            {
                con.Open();
                SqlCommand check = new SqlCommand();
                check.CommandText = "select * from [helth_resource]";
                check.Connection = con;
                SqlDataReader check_data = check.ExecuteReader();

                while (check_data.Read())
                {
                    // Compare values from the database with your input values
                    if (check_data["hr_name"].ToString() == hr_name.Text)
                    {
                        flag = false;
                        break;
                    }
                }
                con.Close();
                check_data.Close();
                check.Dispose();



                if (flag == true)
                {

                    con.Open();
                    //genarate doctor ID
                    hr_id = "SELECT TOP 1 hr_id FROM helth_resource ORDER BY hr_id DESC";
                    using (SqlCommand get_id = new SqlCommand(hr_id, con))
                    {
                        lastHrId = Convert.ToInt32(get_id.ExecuteScalar());
                        gen_id = lastHrId + 1;
                    }

                    int HrId = gen_id;
                    string HrName = hr_name.Text;
                    string HrQt = hr_qt.Text;

                    // Use a parameterized query to prevent SQL injection
                    string query = "INSERT INTO helth_resource (hr_id, hr_name, hr_qt) VALUES " +
                                                     "(@Hrid, @HrName, @HrQt" +
                                                     " )";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@Hrid", HrId);
                        command.Parameters.AddWithValue("@HrName", HrName);
                        command.Parameters.AddWithValue("@HrQt", HrQt);

                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Successfully added Resource Details." + HrName);
                            RefreshDataGridView();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                    con.Close();
                }

                else
                {
                    MessageBox.Show("You Enterd Details Alredy Exist");
                    flag = true;
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pt_clear_Click(object sender, EventArgs e)
        {
            hr_name.Text = "";
            hr_qt.Text = "";
        }

        private void FILLDGV()
        {
            con.Open();
            using (SqlDataAdapter da = new SqlDataAdapter("select * from helth_resource", con))
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

        private void search_text_TextChanged(object sender, EventArgs e)
        {
            DataView dataGridView1 = dt.DefaultView;
            dataGridView1.RowFilter = $"hr_name LIKE '%{search_text.Text}%'";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (MessageBox.Show(string.Format("Do you want delete this ?", row.Cells["hr_name"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                using (SqlCommand cmd = new SqlCommand("Delete from helth_resource where hr_name= @hr_name", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@hr_name", row.Cells["hr_name"].Value);
                    cmd.ExecuteNonQuery();
                    RefreshDataGridView();
                    con.Close();
                }

            }
        }
        private void LoadData()
        {


            // Define a SQL query to retrieve data from the database
            string query = "SELECT * FROM helth_resource"; // Replace with your actual query

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to your DataGridView
                    dataGridView1.DataSource = dataTable;
                    helth_resouce form9 = new helth_resouce();
                    form9.Refresh();
                }
            }

        }
        private void RefreshDataGridView()
        {
            // Assuming you have a method to re-populate the DataGridView (e.g., LoadData())
            // Call that method to refresh the DataGridView
            LoadData();

        }

        private void update_Click(object sender, EventArgs e)
        {
            edit_hr form = new edit_hr();
            form.search = search_text.Text;
            form.ShowDialog();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            this.Close();
            helth_resouce form = new helth_resouce();
            form.Show();
        }
    }
}
