using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus
{
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I6FK5GB\SQLEXPRESS;Initial Catalog=helth_care;Integrated Security=True");

        private void pt_add_Click(object sender, EventArgs e)
        {
            //CheckBox empty
            if (p_name.Text == "" || p_tp.Text == "" || date.Text == "" || time.Text == "")
            {
                MessageBox.Show("please fill All Add Doctor Details");
                return;
            }
            else
            {

                con.Open();
               

                string bname = p_name.Text;
                string btp = p_tp.Text;
                string bdate = date.Text;
                string btime = time.Text;
                string bprice = price.Text;

                //check equality of pasword and confirm password
                // Use a parameterized query to prevent SQL injection
                string query = "INSERT INTO bill (p_name, p_tp, bi_date, bi_time, price) VALUES " +
                                                 "(@b1name, @b1tp, @b1date, @b1time, @b1price" +
                                                 " )";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@b1name", bname);
                    command.Parameters.AddWithValue("@b1tp", btp);
                    command.Parameters.AddWithValue("@b1date", bdate);
                    command.Parameters.AddWithValue("@b1time", btime);
                    command.Parameters.AddWithValue("@b1price", bprice);



                    try
                    {
                        //when add successfull
                        command.ExecuteNonQuery();
                        MessageBox.Show("Successfully added bill to ." + bname);
                        
                    }

                    catch (Exception ex)
                    {
                        //when add unseccessfull
                        MessageBox.Show("Error: " + ex.Message);
                    }

                }

                con.Close();
            }





        }
    }
}
