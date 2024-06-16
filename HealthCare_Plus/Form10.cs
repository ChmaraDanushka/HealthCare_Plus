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
    public partial class edit_hr : Form
    {
        public string search { get; set; }
        String getsearch;
        public edit_hr()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I6FK5GB\SQLEXPRESS;Initial Catalog=helth_care;Integrated Security=True");

        private void groupBox1_Enter(object sender, EventArgs e)
        {

            con.Open();
            hr_name.Text = search;
            getsearch = search;
            string query = "SELECT * FROM helth_resource WHERE hr_name= @search";

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
                        hr_name.Text = dataTable.Rows[0]["hr_name"].ToString();
                        hr_qt.Text = dataTable.Rows[0]["hr_qt"].ToString();



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

        private void pt_add_Click(object sender, EventArgs e)
        {
            if (hr_name.Text == "" || hr_qt.Text == "")
            {
                MessageBox.Show("please fill All Add Admin Details");
                return;
            }
            else
            {




                string hrName = search;
                string hr_Name = hr_name.Text;
                string qt = hr_qt.Text;

                //check equality of in and out time


                con.Open();
                // Use a parameterized query to prevent SQL injection
                string query = "UPDATE helth_resource SET " +
                                 "hr_name = @Hr_name, " +
                                 "hr_qt = @Hr_qt " +
                                 "WHERE hr_name = @searchdo_tp";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@searchdo_tp", hrName);
                    command.Parameters.AddWithValue("@Hr_name", hr_Name);
                    command.Parameters.AddWithValue("@Hr_qt", qt);


                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Successfully Updated." + hr_name.Text + "New Quantity is " + qt);
                     
                        this.Close();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }


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
