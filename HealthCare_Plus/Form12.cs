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
    public partial class mdedit : Form
    {
        bool flag = false;
        public string search { get; set; }
        String getsearch;
        public mdedit()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I6FK5GB\SQLEXPRESS;Initial Catalog=helth_care;Integrated Security=True");

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            con.Open();
            md_name.Text = search;
            getsearch = search;
            string query = "SELECT * FROM medicine WHERE md_name= @search";
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
                        // Assuming  table has columns named "Column1" and "Column2"
                        // Populate the text boxes with data from the selected row
                        md_name.Text = dataTable.Rows[0]["md_name"].ToString();
                        md_qt.Text = dataTable.Rows[0]["md_qt"].ToString();
                        md_price.Text = dataTable.Rows[0]["md_price"].ToString();
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

        private void md_add_Click(object sender, EventArgs e)
        {
            if (md_name.Text == "" || md_qt.Text == "" || md_price.Text == "")
            {
                MessageBox.Show("please fill All  Details");
                return;
            }
            else
            {

                string mdname = search;
                string md_Name = md_name.Text;
                string qt = md_qt.Text;
                string price = md_price.Text;

                //check equality of in and out time


                con.Open();
                // Use a parameterized query to prevent SQL injection
                string query = "UPDATE medicine SET " +
                                 "md_name = @md_name, " +
                                 "md_qt = @md_qt, " +
                                 "md_price = @md_price " +
                                 "WHERE md_name = @searchmd";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@searchmd", mdname);
                    command.Parameters.AddWithValue("@md_name", md_Name);
                    command.Parameters.AddWithValue("@md_qt", qt);
                    command.Parameters.AddWithValue("@md_price", price);


                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Successfully Updated. " + md_name.Text + " New Quantity is " + qt);
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

        private void md_clear_Click(object sender, EventArgs e)
        {
            md_name.Text = "";
            md_qt.Text = "";
            md_price.Text = "";
        }

        private void md_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
