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
    public partial class Form1 : Form
    {
        string level;
        public Form1()
        {
            InitializeComponent();

        }
        //Data Connection
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I6FK5GB\SQLEXPRESS;Initial Catalog=helth_care;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

            string username, password;

            username = user_name.Text;
            password = user_password.Text;
            //check user level
            string query1 = "SELECT * FROM login WHERE user_username= @search";
            using (SqlCommand cmd1 = new SqlCommand(query1, con))
            {
                // Add the parameters
                cmd1.Parameters.AddWithValue("@search", username);
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd1))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    // Check if any rows were returned
                    if (dataTable.Rows.Count > 0)
                    {
                        // Populate the text boxes with data from the selected row
                        level = dataTable.Rows[0]["user_level"].ToString();

                        
                    }
                    else
                    {
                        // Handle the case when no row was found with the given ID
                        MessageBox.Show("No matching row found.");
                    }
                }
            }

            try
            {
                // Use parameterized queries to prevent SQL injection
                string query = "SELECT user_username, password FROM login WHERE user_username = @username AND password = @password";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@username", username);
                sda.SelectCommand.Parameters.AddWithValue("@password", password);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    if (level == "1")
                    {


                        //Successful login
                        MessageBox.Show(username);
                        Form2 f2 = new Form2();
                        f2.Show();
                        this.Hide();
                        var form1 = new Form1();
                        form1.Closed += (s, args) => this.Close();
                        form1.Close();
                    }

                    else
                    {
                        MessageBox.Show(username);
                        docInterFace f2 = new docInterFace();
                        f2.Show();
                        this.Hide();
                        var form1 = new Form1();
                        form1.Closed += (s, args) => this.Close();
                        form1.Close();
                    }
                }
                else
                {
                    // Invalid login
                    MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    user_name.Clear();
                    user_password.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
    }
}