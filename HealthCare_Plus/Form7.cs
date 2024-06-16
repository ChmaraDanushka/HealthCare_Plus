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
    public partial class Form7 : Form
    {
        bool flag = true;
        DataTable dt = new DataTable("doctor");
        public Form7()
        {
            InitializeComponent();
            //data grid view display
            FILLDGV();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I6FK5GB\SQLEXPRESS;Initial Catalog=helth_care;Integrated Security=True");
        private void pt_add_Click(object sender, EventArgs e)
        {
            string do_id;
            int lastdoctortId;
            int gen_id;



            //input feld validity........ 
            if (do_name.Text == "" || do_email.Text == "" || do_tp.Text == "" || do_hospital.Text == "" || do_speciality.Text == "" || do_rgno.Text == "" || do_in_time.Text == "" || do_out_time.Text == "")
            {
                MessageBox.Show("please fill All Add Doctor Details");
                return;
            }
            else
            {
               
                SqlCommand check = new SqlCommand();
                check.CommandText = "select * from [doctor]";
                check.Connection = con;
                SqlDataReader check_data = check.ExecuteReader();

                while (check_data.Read())
                {
                    // Compare values from the database with your input values
                    if (check_data["do_tp"].ToString() == do_tp.Text || check_data["do_email"].ToString() == do_email.Text || check_data["do_registration_no"].ToString() == do_rgno.Text)
                    {
                        flag = false;
                        break;
                    }
                }
                con.Close();
                check_data.Close();
                check.Dispose();



                if (flag == true)
                {

                    con.Open();
                    //genarate doctor ID
                    do_id = "SELECT TOP 1 do_id FROM doctor ORDER BY do_id DESC";
                    using (SqlCommand get_id = new SqlCommand(do_id, con))
                    {
                        lastdoctortId = Convert.ToInt32(get_id.ExecuteScalar());
                        gen_id = lastdoctortId + 1;
                    }

                    int doId = gen_id;
                    string doUserName = do_name.Text;
                    string doEmail = do_email.Text;
                    string doTp = do_tp.Text;
                    string doHospital = do_hospital.Text;
                    string doSpeciality = do_speciality.Text;
                    string doRegisterNo = do_rgno.Text;
                    string doInTime = do_in_time.Text;
                    string doOutTime = do_out_time.Text;
                    //check equality of pasword and confirm password
                    if (doInTime != doOutTime)
                    {

                        // Use a parameterized query to prevent SQL injection
                        string query = "INSERT INTO doctor (do_id, do_name, do_tp, do_email, do_hospital, do_speciality, do_registration_no, do_intime, do_outtime) VALUES " +
                                                         "(@Doid, @Doname, @DoTp, @DoEmail, @DoHospital, @DoSpeciality, @doReg, @DoIntime, @DoOuttime" +
                                                         " )";
                        using (SqlCommand command = new SqlCommand(query, con))
                        {
                            command.Parameters.AddWithValue("@Doid", doId);
                            command.Parameters.AddWithValue("@Doname", doUserName);
                            command.Parameters.AddWithValue("@DoTp", doTp);
                            command.Parameters.AddWithValue("@DoEmail", doEmail);
                            command.Parameters.AddWithValue("@DoHospital", doHospital);
                            command.Parameters.AddWithValue("@DoSpeciality", doSpeciality);
                            command.Parameters.AddWithValue("@doReg", doRegisterNo);
                            command.Parameters.AddWithValue("@DoIntime", doInTime);
                            command.Parameters.AddWithValue("@DoOuttime", doOutTime);


                            try
                            {
                                command.ExecuteNonQuery();
                                MessageBox.Show("Successfully added the new user." + doUserName);
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
                        MessageBox.Show("ReEnter In and out time");
                        do_in_time.BackColor = System.Drawing.Color.LightPink;
                        do_out_time.BackColor = System.Drawing.Color.LightPink;
                        return;
                    }
                    con.Close();
                }

                else
                {
                    MessageBox.Show("You Enterd Details Alredy Exist");
                    flag = true;
                }


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pt_clear_Click(object sender, EventArgs e)
        {
            do_name.Text = "";
            do_email.Text = "";
            do_tp.Text = "";
            do_hospital.Text = "";
            do_speciality.Text = "";
            do_rgno.Text = "";
            do_in_time.Text = "";
            do_out_time.Text = "";
        }

        private void FILLDGV()
        {
            con.Open();
            using (SqlDataAdapter da = new SqlDataAdapter("select *from doctor", con))
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
            dataGridView1.RowFilter = $"do_tp LIKE '%{search_text.Text}%'";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (MessageBox.Show(string.Format("Do you want delete this ?", row.Cells["do_tp"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                using (SqlCommand cmd = new SqlCommand("Delete from doctor where do_tp = @do_tp", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@do_tp", row.Cells["do_tp"].Value);
                    cmd.ExecuteNonQuery();
                    RefreshDataGridView();
                    con.Close();
                }

            }
        }

        private void LoadData()
        {


            // Define a SQL query to retrieve data from the database
            string query = "SELECT * FROM doctor"; // Replace with your actual query

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to  DataGridView
                    dataGridView1.DataSource = dataTable;
                    Form7 form7 = new Form7();
                    form7.Refresh();
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
            edit_doc form = new edit_doc();
            form.search = search_text.Text;
            form.ShowDialog();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            this.Close();
            Form7 form = new Form7();
            form.Show();
        }
    }
}
