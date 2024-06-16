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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I6FK5GB\SQLEXPRESS;Initial Catalog=helth_care;Integrated Security=True");

        private void Form2_load(object sender, EventArgs e)
        {
            timer2.Start();

        }
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            lbl_date.Text = DateTime.Now.ToLongDateString();
        }

        private void adminRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin admin = new admin();
            admin.Show();
        }
        // Appoinment Button ...................
        private void btn_appoinment_Click(object sender, EventArgs e)
        {
            appoinment app = new appoinment();
            app.Show();

        }
        private void btn_appoinment_MouseHover(object sender, EventArgs e)
        {


        }
        // Patient Button ...................
        private void btn_patient_Click(object sender, EventArgs e)
        {
            Form3 patient_register = new Form3();
            patient_register.Show();
        }

        // Doctors Button ...................
        private void btn_doctors_Click(object sender, EventArgs e)
        {
            Form7 doctor = new Form7();
            doctor.Show();
        }

        // Resource Button ...................
        private void btn_resours_Click(object sender, EventArgs e)
        {
            helth_resouce hr = new helth_resouce();
            hr.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void medicineListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            medicine md = new medicine();
            md.Show();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from appoinment", con);

            var rowCount = cmd.ExecuteScalar();
            count1.Text = rowCount.ToString();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 admin = new Form1();
            admin.Show();
            this.Close();
        }

        private void addBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            payment payment = new payment();
            payment.Show();

        }

        private void patientReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p_report payment = new p_report();
            payment.Show();

        }

        private void doctorsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            boctor boctor = new boctor();
            boctor.Show();
        }

        private void incomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paymentr paymentr = new paymentr();
            paymentr.Show();
        }
    }
}
