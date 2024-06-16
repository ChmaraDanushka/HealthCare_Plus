using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HealthCare_Plus
{
    public partial class docInterFace : Form
    {
        bool enter = false;
        public docInterFace()
        {
            InitializeComponent();
        }
 SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I6FK5GB\SQLEXPRESS;Initial Catalog=helth_care;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            string searchid = do_search.Text;
            try
            {
                // Use parameterized queries to prevent SQL injection
                string query = "SELECT do_id FROM doctor WHERE do_id = @do_id";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@do_id", searchid);
               

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    enter = true;
                
                    
                }
                else
                {
                    // Invalid login
                    MessageBox.Show("Invalid  Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   // user_name.Clear();
                    
                }

                if(enter == true)
                {
                    doc_appoinment form = new doc_appoinment();
                    form.search = searchid;
                    form.ShowDialog();
                    //Successful login
                    //MessageBox.Show(searchid);
                    doc_appoinment f2 = new doc_appoinment();
                    f2.Show();
                    this.Close();
                    enter = false;
                }
                else
                {
                    MessageBox.Show("re enter");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
