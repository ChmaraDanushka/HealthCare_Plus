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
    public partial class ap_rechedule : Form
    {
        public string search { get; set; }
        String getsearch;
        public ap_rechedule()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I6FK5GB\SQLEXPRESS;Initial Catalog=helth_care;Integrated Security=True");

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            con.Open();
            pa_name.Text = search;
            getsearch = search;
            string query = "SELECT * FROM appoinment WHERE p_tp = @search";

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
                        date.Text = dataTable.Rows[0]["ap_date"].ToString();
                        time.Text = dataTable.Rows[0]["ap_time"].ToString();



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

        private void add_Click(object sender, EventArgs e)
        {
            if (date.Text == "" || date.Text == "")
            {
                MessageBox.Show("please fill All Add Admin Details");
                return;
            }
            else
            {
                string ptp = search;
                string ap_date = date.Text;
                string ap_time = time.Text;

                //check equality of in and out time


                con.Open();
                // Use a parameterized query to prevent SQL injection
                string query = "UPDATE appoinment SET " +
                                 "ap_date = @ap_date, " +
                                 "ap_time = @ap_time " +
                                 "WHERE p_tp = @searchdo_tp";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@searchdo_tp", ptp);
                    command.Parameters.AddWithValue("@ap_date", ap_date);
                    command.Parameters.AddWithValue("@ap_time", ap_time);


                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Successfully Updated.");

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
    }
}
