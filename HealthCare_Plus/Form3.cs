using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus
{
    public partial class Form3 : Form
    {

        DataTable dt = new DataTable("Patient");
        public Form3()
        {
            InitializeComponent();
            FILLDGV();
        }
        //database connection
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I6FK5GB\SQLEXPRESS;Initial Catalog=helth_care;Integrated Security=True");
        //gender variable........
        string gender;
        private void pt_add_Click(object sender, EventArgs e)
        {


            string pt_id;
            int lastPatientId;
            int gen_id;

            if (patient_name.Text == "" || gender == "" || patient_nic.Text == "" || patient_age.Text == "" || patient_birth.Text == "" || patient_address.Text == "" || patient_tp.Text == "")
            {
                MessageBox.Show("please fill All Patient Details");
                return;
            }
            else
            {

                //get last id of pt column
                pt_id = "SELECT TOP 1 pt_id FROM patient ORDER BY pt_id DESC";
                using (SqlCommand get_id = new SqlCommand(pt_id, con))
                {
                    lastPatientId = Convert.ToInt32(get_id.ExecuteScalar());
                    gen_id = lastPatientId + 1;
                }


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
                string query = "INSERT INTO patient (pt_id, p_name, p_gender, p_nic, p_age, p_birth, p_address, p_tp, p_g_name, p_g_age, p_g_address, p_g_tp) VALUES " +
                                                     "(@PatientId, @PatientName, @PatientGender,@patientNic, @PatientAge, @PatientBirth, @PatientAddress, @PatientTp, @PatientGNname, @PatientGAage, @PatientGAddress, @PatientGTp " +
                                                     " )";


                using (SqlCommand command = new SqlCommand(query, con))
                {

                    command.Parameters.AddWithValue("@PatientId", gen_id);
                    command.Parameters.AddWithValue("@PatientName", patientName);
                    command.Parameters.AddWithValue("@patientGender", patientGender);
                    command.Parameters.AddWithValue("@patientNic", patientNIC);
                    command.Parameters.AddWithValue("@patientAge", patientAge);
                    command.Parameters.AddWithValue("@PatientBirth", patientBirth);
                    command.Parameters.AddWithValue("@PatientAddress", patientAddress);
                    command.Parameters.AddWithValue("@PatientTp", patientTp);
                    command.Parameters.AddWithValue("@PatientGNname", patientGName);
                    command.Parameters.AddWithValue("@PatientGAage", patientGAge);
                    command.Parameters.AddWithValue("@PatientGAddress", patientGAddress);
                    command.Parameters.AddWithValue("@PatientGTp", patientGTp);



                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Successfully added the new patient." + gen_id);
                        RefreshDataGridView();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }

                }


            }


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
        //Clear all text box
        private void pt_clear_Click(object sender, EventArgs e)
        {
            patient_name.Text = "";

            patient_nic.Text = "";
            patient_age.Text = "";
            patient_birth.Text = "";
            patient_address.Text = "";
            patient_tp.Text = "";
            patient_g_name.Text = "";
            patient_g_age.Text = "";
            patient_g_address.Text = "";
            patient_g_tp.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
            form3.Closed += (s, args) => this.Close();
            form3.Close();

        }

        //show data Grid.................
        private void FILLDGV()
        {
            con.Open();
            using (SqlDataAdapter da = new SqlDataAdapter("select *from patient", con))
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

        }

        private void patient_id_TextChanged(object sender, EventArgs e)
        {
            DataView dataGridView1 = dt.DefaultView;
            dataGridView1.RowFilter = $"p_tp LIKE '%{patient_id.Text}%'";

        }

        private void update_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.patId = patient_id.Text;
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Do you want delete this ?", row.Cells["pt_no"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    using (SqlCommand cmd = new SqlCommand("Delete from patient where pt_no = @pt_no", con))
                    {
                        cmd.Parameters.AddWithValue("@pt_no", row.Cells["pt_no"].Value);
                        cmd.ExecuteNonQuery();
                        RefreshDataGridView();

                    }

                }

            }

        }
        //Refresh Class.............
        private void LoadData()
        {


            // Define a SQL query to retrieve data from the database
            string query = "SELECT * FROM patient"; // Replace with your actual query

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to your DataGridView
                    dataGridView1.DataSource = dataTable;
                    Form3 form3 = new Form3();
                    form3.Refresh();
                }
            }

        }
        private void RefreshDataGridView()
        {

            // Call that method to refresh the DataGridView
            LoadData();

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 form = new Form3();
            form.Show();
        }
    }
}
