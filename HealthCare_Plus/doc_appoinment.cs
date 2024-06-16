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
    public partial class doc_appoinment : Form
    {
        public string search { get; set; }
        String getsearch = "1";
        String getname = "1";
        String ddname = "Chamara";
        DataTable dt = new DataTable("appoinment");
        public doc_appoinment()
        {
            InitializeComponent();

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I6FK5GB\SQLEXPRESS;Initial Catalog=helth_care;Integrated Security=True");

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            con.Open();
            do_id.Text = search;
            getsearch = search;
            //string getname;
            string query = "SELECT * FROM doctor WHERE do_id= @search";
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
                        do_name.Text = dataTable.Rows[0]["do_name"].ToString();
                        getname = dataTable.Rows[0]["do_name"].ToString();
                        do_tp.Text = dataTable.Rows[0]["do_tp"].ToString();
                        do_speciality.Text = dataTable.Rows[0]["do_speciality"].ToString();
                        // Add more text boxes as needed
                        FILLDGV();
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
        private void FILLDGV()
        {
            
            using (SqlDataAdapter da = new SqlDataAdapter("select *from appoinment", con))
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
        private void LoadData()
        {


            // Define a SQL query to retrieve data from the database
            string query = "SELECT * FROM appoinment"; // Replace with your actual query

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to your DataGridView
                    dataGridView1.DataSource = dataTable;
                    doc_appoinment form = new doc_appoinment();
                    form.Refresh();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
               
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Do you want delete this ?", row.Cells["do_name"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    using (SqlCommand cmd = new SqlCommand("Delete from appoinment where do_name= @do_name", con))
                    {
                        
                        cmd.Parameters.AddWithValue("@do_name", row.Cells["do_name"].Value);
                        cmd.ExecuteNonQuery();
                        RefreshDataGridView();
                     
                    }

                }
            }
        }

        private void RefreshDataGridView()
        {
            // Assuming you have a method to re-populate the DataGridView (e.g., LoadData())
            // Call that method to refresh the DataGridView
            LoadData();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 form = new Form1();
            //form.Show();
            doc_appoinment end1 = new doc_appoinment();
            end1.Close();
            docInterFace end = new docInterFace();
            end.Close();
            
        }
    }
}
