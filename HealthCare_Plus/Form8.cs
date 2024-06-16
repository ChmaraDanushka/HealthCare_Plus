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
    public partial class edit_doc : Form
    {
        bool flag = false;
        public string search { get; set; }
        String getsearch;
        public edit_doc()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I6FK5GB\SQLEXPRESS;Initial Catalog=helth_care;Integrated Security=True");

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            con.Open();
            do_tp.Text = search;
            getsearch = search;
            string query = "SELECT * FROM doctor WHERE do_tp= @search";

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
                        do_name.Text = dataTable.Rows[0]["do_name"].ToString();
                        do_tp.Text = dataTable.Rows[0]["do_tp"].ToString();
                        do_email.Text = dataTable.Rows[0]["do_email"].ToString();
                        do_hospital.Text = dataTable.Rows[0]["do_hospital"].ToString();
                        do_speciality.Text = dataTable.Rows[0]["do_speciality"].ToString();
                        do_rgno.Text = dataTable.Rows[0]["do_registration_no"].ToString();
                        do_in_time.Text = dataTable.Rows[0]["do_intime"].ToString();
                        do_out_time.Text = dataTable.Rows[0]["do_outtime"].ToString();


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
            if (do_name.Text == "" || do_email.Text == "" || do_tp.Text == "" || do_hospital.Text == "" || do_speciality.Text == "" || do_rgno.Text == "" || do_in_time.Text == "" || do_out_time.Text == "")
            {
                MessageBox.Show("please fill All Add Admin Details");
                return;
            }
            else
            {
                con.Open();
                SqlCommand check = new SqlCommand();
                check.CommandText = "select * from [doctor]";
                check.Connection = con;
                SqlDataReader check_data = check.ExecuteReader();

                while (check_data.Read())
                {
                    if (check_data["do_tp"].ToString() == do_tp.Text || check_data["do_email"].ToString() == do_email.Text || check_data["do_registration_no"].ToString() == do_rgno.Text)
                    {
                        flag = true;
                        break;
                    }
                }
                con.Close();
                check_data.Close();
                check.Dispose();

                if (flag == false)
                {

                    string update_tp = search;
                    string DoName = do_name.Text;
                    string DoTp = do_tp.Text;
                    string DoEmail = do_email.Text;
                    string DoHospital = do_hospital.Text;
                    string DoSpeciality = do_speciality.Text;
                    string DoRegistrationNo = do_rgno.Text;
                    string DoIntime = do_in_time.Text;
                    string DoOuttime = do_out_time.Text;
                    //check equality of in and out time
                    if (DoIntime != DoOuttime)
                    {

                        con.Open();
                        // Use a parameterized query to prevent SQL injection
                        string query = "UPDATE doctor SET " +
                                         "do_name = @Do_name, " +
                                         "do_tp = @Do_tp, " +
                                         "do_email = @Do_email, " +
                                         "do_hospital = @Do_hospital, " +
                                         "do_speciality = @Do_speciality, " +
                                         "do_registration_no = @Do_reg, " +
                                         "do_intime = @Do_intime, " +
                                         "do_outtime = @Do_outtime " +
                                         "WHERE do_tp = @searchdo_tp";
                        using (SqlCommand command = new SqlCommand(query, con))
                        {
                            command.Parameters.AddWithValue("@searchdo_tp", update_tp);
                            command.Parameters.AddWithValue("@Do_name", DoName);
                            command.Parameters.AddWithValue("@Do_tp", DoTp);
                            command.Parameters.AddWithValue("@Do_email", DoEmail);
                            command.Parameters.AddWithValue("@Do_hospital", DoHospital);
                            command.Parameters.AddWithValue("@Do_speciality", DoSpeciality);
                            command.Parameters.AddWithValue("@Do_reg", DoRegistrationNo);
                            command.Parameters.AddWithValue("@Do_intime", DoIntime);
                            command.Parameters.AddWithValue("@Do_outtime", DoOuttime);

                            try
                            {
                                command.ExecuteNonQuery();
                                MessageBox.Show("Successfully Updated." + DoName);
                                edit_doc form7 = new edit_doc();
                                form7.Refresh();


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
                        MessageBox.Show("ReEnter in time and out time ");
                        do_in_time.BackColor = System.Drawing.Color.LightPink;
                        do_out_time.BackColor = System.Drawing.Color.LightPink;
                        return;
                    }
                }

                else
                {
                    MessageBox.Show("You Enterd Details Alredy Exist");
                }

           
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
