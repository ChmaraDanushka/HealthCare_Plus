using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
    public partial class Form4 : Form
    {
        public string patId { get; set; }
        String getId;
        public Form4()
        {
            InitializeComponent();

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I6FK5GB\SQLEXPRESS;Initial Catalog=helth_care;Integrated Security=True");
        //gender variable........
        string gender;
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            con.Open();
            patient_id.Text = patId;
            getId = patId;
            string query = "SELECT * FROM patient WHERE pt_id = @patId";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                // Add the parameter for the row ID
                cmd.Parameters.AddWithValue("@patId", patId);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Check if any rows were returned
                    if (dataTable.Rows.Count > 0)
                    {
                        // Assuming your table has columns named "Column1" and "Column2"
                        // Populate the text boxes with data from the selected row
                        patient_name.Text = dataTable.Rows[0]["p_name"].ToString();
                        patient_nic.Text = dataTable.Rows[0]["p_nic"].ToString();
                        patient_age.Text = dataTable.Rows[0]["p_age"].ToString();
                        patient_birth.Text = dataTable.Rows[0]["p_birth"].ToString();
                        patient_address.Text = dataTable.Rows[0]["p_address"].ToString();
                        patient_tp.Text = dataTable.Rows[0]["p_tp"].ToString();
                        patient_g_name.Text = dataTable.Rows[0]["p_g_name"].ToString();
                        patient_g_age.Text = dataTable.Rows[0]["p_g_age"].ToString();
                        patient_g_address.Text = dataTable.Rows[0]["p_g_address"].ToString();
                        patient_g_tp.Text = dataTable.Rows[0]["p_g_tp"].ToString();

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
            con.Open();
            if (patient_name.Text == "" || gender == "" || patient_nic.Text == "" || patient_age.Text == "" || patient_birth.Text == "" || patient_address.Text == "" || patient_tp.Text == "")
            {
                MessageBox.Show("please fill All Patient Details");
                return;
            }
            else
            {
                string patientid = getId;
                string patientName = patient_name.Text;
                string patientGender = gender;
                string patientNIC = patient_nic.Text;
                string patientAge = patient_age.Text;
                string patientBirth = patient_birth.Text;
                string patientAddress = patient_address.Text;
                string patientTp = patient_tp.Text;
                string patientGName = patient_g_name.Text;
                string patientGAge = patient_g_age.Text;
                string patientGAddress = patient_g_address.Text;
                string patientGTp = patient_g_tp.Text;





                // Use a parameterized query to prevent SQL injection
                string query = "UPDATE patient SET " +
                 "p_name = @PatientName, " +
                 "p_gender = @PatientGender, " +
                 "p_nic = @PatientNic, " +
                 "p_age = @PatientAge, " +
                 "p_birth = @PatientBirth, " +
                 "p_address = @PatientAddress, " +
                 "p_tp = @PatientTp, " +
                 "p_g_name = @PatientGName, " +
                 "p_g_age = @PatientGAge, " +
                 "p_g_address = @PatientGAddress, " +
                 "p_g_tp = @PatientGTp " +
                 "WHERE pt_id = @PatientId";


                using (SqlCommand command = new SqlCommand(query, con))
                {


                    command.Parameters.AddWithValue("@PatientName", patientName);
                    command.Parameters.AddWithValue("@patientGender", patientGender);
                    command.Parameters.AddWithValue("@patientNic", patientNIC);
                    command.Parameters.AddWithValue("@patientAge", patientAge);
                    command.Parameters.AddWithValue("@PatientBirth", patientBirth);
                    command.Parameters.AddWithValue("@PatientAddress", patientAddress);
                    command.Parameters.AddWithValue("@PatientTp", patientTp);
                    command.Parameters.AddWithValue("@PatientGName", patientGName);
                    command.Parameters.AddWithValue("@PatientGAge", patientGAge);
                    command.Parameters.AddWithValue("@PatientGAddress", patientGAddress);
                    command.Parameters.AddWithValue("@PatientGTp", patientGTp);
                    command.Parameters.AddWithValue("@PatientId", patientid);



                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Successfully added the new patient.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }


            }
            con.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "female";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            gender = "other";
        }
    }
}
