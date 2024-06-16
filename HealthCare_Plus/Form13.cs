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
    public partial class appoinment : Form
    {
        DataTable dt = new DataTable("helth_resource");
        public appoinment()
        {
            InitializeComponent();
            FILLDGV();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I6FK5GB\SQLEXPRESS;Initial Catalog=helth_care;Integrated Security=True");


        private void do_combo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT do_name FROM doctor ", con);
            DataTable DT = new DataTable();
            SDA.Fill(DT);
            do_combo.Items.Add("-----SELECT-----");
            foreach (DataRow ROW in DT.Rows)
            {
                do_combo.Items.Add(ROW["do_name"].ToString());
            }
        }

        private void p_find_Click(object sender, EventArgs e)
        {
            con.Open();
            string getsearch = p_tp.Text;
            string query = "SELECT * FROM patient WHERE p_tp = @search";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                // Add the parameter for the search value
                cmd.Parameters.AddWithValue("@search", getsearch);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Check if any rows were returned
                    if (dataTable.Rows.Count > 0)
                    {
                        // Assuming your table has columns named "p_name", "p_tp", and "p_age"
                        // Populate the text boxes with data from the selected row
                        p_name.Text = dataTable.Rows[0]["p_name"].ToString();
                        pa_tp.Text = dataTable.Rows[0]["p_tp"].ToString();
                        p_age.Text = dataTable.Rows[0]["p_age"].ToString();

                        // Add more text boxes as needed
                    }
                    else
                    {
                        // Handle the case when no row was found with the given search value
                        MessageBox.Show("No matching row found.");
                    }
                }
            }


            con.Close();
        }

        private void md_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {

            string pa_name = p_name.Text;
            string p_tp = pa_tp.Text;
            string do_name = do_combo.Text;
            string p_room = room.Text;
            string p_date = date.Text;
            string p_time = time.Text;


            // Use a parameterized query to prevent SQL injection
            string query = "INSERT INTO appoinment (p_name, p_tp, do_name, ap_room, ap_date, ap_time) VALUES " +
                                             "(@name, @tp, @d_name, @room, @date, @time" +
                                             " )";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@name", pa_name);
                command.Parameters.AddWithValue("@tp", p_tp);
                command.Parameters.AddWithValue("@d_name", do_name);
                command.Parameters.AddWithValue("@room", p_room);
                command.Parameters.AddWithValue("@date", p_date);
                command.Parameters.AddWithValue("@time", p_time);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Apoinment Successfully added ." + p_name);
                    RefreshDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            con.Close();
        }

        private void FILLDGV()
        {
            con.Open();
            using (SqlDataAdapter da = new SqlDataAdapter("select * from appoinment", con))
            {
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            dataGridView1.AllowUserToAddRows = false;
            DataGridViewButtonColumn buttoncolumn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Insert(0, buttoncolumn);
            buttoncolumn.HeaderText = "REJECT";
            buttoncolumn.Width = 100;
            buttoncolumn.Text = "DELETE";
            buttoncolumn.UseColumnTextForButtonValue = true;
            con.Close();
        }

        private void search_text_TextChanged(object sender, EventArgs e)
        {
            DataView dataGridView1 = dt.DefaultView;
            dataGridView1.RowFilter = $"p_tp LIKE '%{search_text.Text}%'";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (MessageBox.Show(string.Format("Do you want delete this ?", row.Cells["p_tp"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                using (SqlCommand cmd = new SqlCommand("Delete from appoinment where p_tp= @pa_tp", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@pa_tp", row.Cells["p_tp"].Value);
                    cmd.ExecuteNonQuery();
                    RefreshDataGridView();
                    con.Close();
                }

            }
        }

        private void LoadData()
        {
            // Define a SQL query to retrieve data from the database
            string query = "SELECT * FROM appoinment";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to your DataGridView
                    dataGridView1.DataSource = dataTable;
                    appoinment form13 = new appoinment();
                    form13.Refresh();
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
            ap_rechedule form = new ap_rechedule();
            form.search = search_text.Text;
            form.ShowDialog();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            this.Close();

            // Reopen the form (assuming it's named 'YourFormName')
            appoinment form = new appoinment();
            form.Show();
        }
    }
}
