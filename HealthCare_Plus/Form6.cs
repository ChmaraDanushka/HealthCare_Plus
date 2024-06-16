using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HealthCare_Plus
{
    public partial class user_update : Form
    {
        bool flag = false;
        public string search { get; set; }
        String getsearch;
        public user_update()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I6FK5GB\SQLEXPRESS;Initial Catalog=helth_care;Integrated Security=True");
        //gender variable........
        string gender;

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            con.Open();
            admin_tp.Text = search;
            getsearch = search;
            string query = "SELECT * FROM login WHERE user_tp= @search";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                // Add the parameter for the row ID
                cmd.Parameters.AddWithValue("@search", getsearch);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Check if any rows were returned
                    if (dataTable.Rows.Count > 0)
                    {
                        // Assuming your table has columns named "Column1" and "Column2"
                        // Populate the text boxes with data from the selected row
                        admin_name.Text = dataTable.Rows[0]["user_name"].ToString();
                        admin_username.Text = dataTable.Rows[0]["user_username"].ToString();
                        admin_email.Text = dataTable.Rows[0]["user_email"].ToString();
                        admin_tp.Text = dataTable.Rows[0]["user_tp"].ToString();
                        admin_level.Text = dataTable.Rows[0]["user_level"].ToString();
                        admin_password.Text = dataTable.Rows[0]["password"].ToString();


                        // Add more text boxes as needed
                    }
                    else
                    {
                        // Handle the case when no row was found with the given ID
                        MessageBox.Show("No matching row found.");
                    }
                }

            }
            con.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {


            //input feld validity........ 
            if (admin_name.Text == "" || admin_email.Text == "" || admin_tp.Text == "" || admin_level.Text == "")
            {
                MessageBox.Show("please fill All Add Admin Details");
                return;
            }
            else
            {
                con.Open();
                SqlCommand check = new SqlCommand();
                check.CommandText = "select * from [login]";
                check.Connection = con;
                SqlDataReader check_data = check.ExecuteReader();

                while (check_data.Read())
                {
                    if (check_data[1].ToString() == admin_confiram_password.Text)
                    {
                        flag = false;
                        break;
                    }
                }
                check_data.Close();
                check.Dispose();

                if (flag == false)
                {

                    string update_tp = search;
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
                        string query = "UPDATE login SET " +
                                         "user_name = @user_name, " +
                                         "user_username = @user_username, " +
                                         "user_email = @user_email, " +
                                         "user_tp = @user_tp, " +
                                         "user_level = @user_level, " +
                                         "password = @password " +
                                         "WHERE user_tp = @searchuser_tp";
                        using (SqlCommand command = new SqlCommand(query, con))
                        {
                            command.Parameters.AddWithValue("@searchuser_tp", update_tp);
                            command.Parameters.AddWithValue("@user_name", adminName);
                            command.Parameters.AddWithValue("@user_username", adminName);
                            command.Parameters.AddWithValue("@user_email", adminEmail);
                            command.Parameters.AddWithValue("@user_tp", adminTp);
                            command.Parameters.AddWithValue("@user_level", adminLevel);
                            command.Parameters.AddWithValue("@password", adminConfiramPassword);

                            try
                            {
                                command.ExecuteNonQuery();
                                MessageBox.Show("Successfully added the new user." + adminName);

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
                }

                con.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
