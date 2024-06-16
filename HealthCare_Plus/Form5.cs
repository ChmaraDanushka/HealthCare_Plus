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
    public partial class admin : Form
    {
        bool flag = false;

        DataTable dt = new DataTable("Patient");
        public admin()
        {
            InitializeComponent();
            //data grid view display
            FILLDGV();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I6FK5GB\SQLEXPRESS;Initial Catalog=helth_care;Integrated Security=True");

        private void pt_add_Click(object sender, EventArgs e)
        {
            con.Open();

            //input feld validity........ 
            if (admin_name.Text == "" || admin_email.Text == "" || admin_tp.Text == "" || admin_level.Text == "" || admin_password.Text == "" || admin_confiram_password.Text == "")
            {
                MessageBox.Show("please fill All Add Admin Details");
                return;
            }
            else
            {
                SqlCommand check = new SqlCommand();
                check.CommandText = "select * from [login]";
                check.Connection = con;
                SqlDataReader check_data = check.ExecuteReader();

                while (check_data.Read())
                {
                    if (check_data["user_username"].ToString() == admin_username.Text || check_data["user_email"].ToString() == admin_email.Text || check_data["user_tp"].ToString() == admin_tp.Text || check_data["password"].ToString() == admin_confiram_password.Text)
                    {
                        flag = true;
                        break;
                    }
                }
                check_data.Close();
                check.Dispose();
                if (flag == false)
                {


                    string adminName = admin_name.Text;
                    string adminUserName = admin_username.Text;
                    string adminEmail = admin_email.Text;
                    string adminTp = admin_tp.Text;
                    string adminLevel = admin_level.Text;
                    string adminPassword = admin_password.Text;
                    string adminConfiramPassword = admin_confiram_password.Text;
                    //check equality of pasword and confirm password
                    if (adminPassword == adminConfiramPassword)
                    {

                        // Use a parameterized query to prevent SQL injection
                        string query = "INSERT INTO login (user_name, user_username, user_email, user_tp, user_level, password) VALUES " +
                                                         "(@UserName, @UserUsername, @UserEmail, @UserTp, @UserLevel, @UserPassword" +
                                                         " )";
                        using (SqlCommand command = new SqlCommand(query, con))
                        {
                            command.Parameters.AddWithValue("@UserName", adminName);
                            command.Parameters.AddWithValue("@UserUsername", adminUserName);
                            command.Parameters.AddWithValue("@UserEmail", adminEmail);
                            command.Parameters.AddWithValue("@UserTp", adminTp);
                            command.Parameters.AddWithValue("@UserLevel", adminLevel);
                            command.Parameters.AddWithValue("@UserPassword", adminConfiramPassword);

                            try
                            {
                                command.ExecuteNonQuery();
                                MessageBox.Show("Successfully added the new user." + adminName);
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
                        MessageBox.Show("ReEnter Confamation Password");
                        admin_confiram_password.BackColor = System.Drawing.Color.LightPink;
                        return;
                    }
                }

                else
                {
                    MessageBox.Show("You Enterd Details Alredy Exist");
                    flag = false;
                }

                con.Close();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pt_clear_Click(object sender, EventArgs e)
        {
            admin_name.Text = "";

            admin_email.Text = "";
            admin_tp.Text = "";
            admin_level.Text = "";
            admin_username.Text = "";
            admin_password.Text = "";
            admin_confiram_password.Text = "";

        }

        private void FILLDGV()
        {
            con.Open();
            using (SqlDataAdapter da = new SqlDataAdapter("select *from login", con))
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
            dataGridView1.RowFilter = $"user_tp LIKE '%{search_text.Text}%'";


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Do you want delete this ?", row.Cells["user_tp"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    using (SqlCommand cmd = new SqlCommand("Delete from login where user_tp = @user_tp", con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@user_tp", row.Cells["user_tp"].Value);
                        cmd.ExecuteNonQuery();
                        RefreshDataGridView();
                        con.Close();
                    }

                }
            }
        }
        //Refresh Class.............
        private void LoadData()
        {

            con.Close();
            // Define a SQL query to retrieve data from the database
            string query = "SELECT * FROM login"; // Replace with your actual query

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to your DataGridView
                    dataGridView1.DataSource = dataTable;
                    admin form5 = new admin();
                    form5.Refresh();
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
            user_update form = new user_update();
            form.search = search_text.Text;
            form.ShowDialog();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            this.Close();
            admin form = new admin();
            form.Show();
        }
    }
}
