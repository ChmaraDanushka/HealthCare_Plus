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

namespace HealthCare_Plus
{
    public partial class medicine : Form
    {
        bool flag = true;
        DataTable dt = new DataTable("doctor");
        public medicine()
        {
            InitializeComponent();
            FILLDGV();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I6FK5GB\SQLEXPRESS;Initial Catalog=helth_care;Integrated Security=True");

        private void md_add_Click(object sender, EventArgs e)
        {
            string md_id;
            int lastmdId;
            int gen_id;



            //input feld validity........ 
            if (md_name.Text == "" || md_qt.Text == "" || md_price.Text == "")
            {
                MessageBox.Show("please fill All Add Doctor Details");
                return;
            }
            else
            {
                con.Open();
                SqlCommand check = new SqlCommand();
                check.CommandText = "select * from [medicine]";
                check.Connection = con;
                SqlDataReader check_data = check.ExecuteReader();

                while (check_data.Read())
                {
                    // Compare values from the database with your input values
                    if (check_data["md_name"].ToString() == md_name.Text)
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
                    md_id = "SELECT TOP 1 md_id FROM medicine ORDER BY md_id DESC";
                    using (SqlCommand get_id = new SqlCommand(md_id, con))
                    {
                        lastmdId = Convert.ToInt32(get_id.ExecuteScalar());
                        gen_id = lastmdId + 1;
                    }

                    int mdId = gen_id;
                    string mdName = md_name.Text;
                    string mdqt = md_qt.Text;
                    string mdprice = md_price.Text;

                    //check equality of pasword and confirm password


                    // Use a parameterized query to prevent SQL injection
                    string query = "INSERT INTO medicine (md_id, md_name, md_qt, md_price) VALUES " +
                                                     "(@mdid, @mdname, @mdqt, @mdprice" +
                                                     " )";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@mdid", mdId);
                        command.Parameters.AddWithValue("@mdname", mdName);
                        command.Parameters.AddWithValue("@mdqt", mdqt);
                        command.Parameters.AddWithValue("@mdprice", mdprice);

                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Successfully added the new Medi." + mdName);
                            RefreshDataGridView();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }


                    }
                }

                else
                {
                    MessageBox.Show("ReEnter Medi Name");
                    md_name.BackColor = System.Drawing.Color.LightPink;
                    return;
                }
                con.Close();
            }
        }

        private void md_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void md_clear_Click(object sender, EventArgs e)
        {
            md_name.Text = "";
            md_qt.Text = "";
            md_price.Text = "";

        }
        private void FILLDGV()
        {
            con.Open();
            using (SqlDataAdapter da = new SqlDataAdapter("select *from medicine", con))
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
            dataGridView1.RowFilter = $"md_name LIKE '%{search_text.Text}%'";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (MessageBox.Show(string.Format("Do you want delete this ?", row.Cells["md_name"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                using (SqlCommand cmd = new SqlCommand("Delete from medicine where md_name = @md_name", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@md_name", row.Cells["md_name"].Value);
                    cmd.ExecuteNonQuery();
                    RefreshDataGridView();
                    con.Close();
                }

            }
        }
        private void LoadData()
        {


            // Define a SQL query to retrieve data from the database
            string query = "SELECT * FROM medicine"; // Replace with your actual query

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to  DataGridView
                    dataGridView1.DataSource = dataTable;
                    medicine form11 = new medicine();
                    form11.Refresh();
                }
            }

        }
        private void RefreshDataGridView()
        {
            // Assuming you have a method to re-populate the DataGridView (e.g., LoadData())
            // Call that method to refresh the DataGridView
            LoadData();

        }

        private void refresh_Click(object sender, EventArgs e)
        {

            // Close the current form
            this.Close();
            medicine form = new medicine();
            form.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            mdedit form = new mdedit();
            form.search = search_text.Text;
            form.ShowDialog();
        }
    }
}
