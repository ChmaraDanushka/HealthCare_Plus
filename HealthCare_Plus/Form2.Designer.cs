namespace HealthCare_Plus
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            adminRegisterToolStripMenuItem = new ToolStripMenuItem();
            userLogToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            appoinmentToolStripMenuItem = new ToolStripMenuItem();
            addAppoinmentToolStripMenuItem = new ToolStripMenuItem();
            reschedulingToolStripMenuItem = new ToolStripMenuItem();
            historyToolStripMenuItem = new ToolStripMenuItem();
            patientToolStripMenuItem = new ToolStripMenuItem();
            medicalRecordsToolStripMenuItem = new ToolStripMenuItem();
            diagnosesToolStripMenuItem = new ToolStripMenuItem();
            prescriptionsToolStripMenuItem = new ToolStripMenuItem();
            labResultsToolStripMenuItem = new ToolStripMenuItem();
            medicleHistoryToolStripMenuItem = new ToolStripMenuItem();
            doctorsToolStripMenuItem = new ToolStripMenuItem();
            profilesToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            madicineToolStripMenuItem = new ToolStripMenuItem();
            medicineListToolStripMenuItem = new ToolStripMenuItem();
            resourcesToolStripMenuItem = new ToolStripMenuItem();
            roomsTheaterToolStripMenuItem = new ToolStripMenuItem();
            healthcareResouecesToolStripMenuItem = new ToolStripMenuItem();
            reportToolStripMenuItem = new ToolStripMenuItem();
            incomeToolStripMenuItem = new ToolStripMenuItem();
            patientReportToolStripMenuItem = new ToolStripMenuItem();
            resourceAllocationsToolStripMenuItem = new ToolStripMenuItem();
            doctorsToolStripMenuItem1 = new ToolStripMenuItem();
            billToolStripMenuItem = new ToolStripMenuItem();
            addBillToolStripMenuItem = new ToolStripMenuItem();
            btn_appoinment = new Button();
            btn_patient = new Button();
            btn_doctors = new Button();
            btn_resours = new Button();
            groupBox3 = new GroupBox();
            count1 = new TextBox();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            timer1 = new GroupBox();
            monthCalendar1 = new MonthCalendar();
            lbl_date = new Label();
            lbl_time = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            menuStrip1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            timer1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, appoinmentToolStripMenuItem, patientToolStripMenuItem, doctorsToolStripMenuItem, madicineToolStripMenuItem, resourcesToolStripMenuItem, reportToolStripMenuItem, billToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(695, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adminRegisterToolStripMenuItem, userLogToolStripMenuItem, logoutToolStripMenuItem });
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(55, 20);
            homeToolStripMenuItem.Text = "Home ";
            // 
            // adminRegisterToolStripMenuItem
            // 
            adminRegisterToolStripMenuItem.Name = "adminRegisterToolStripMenuItem";
            adminRegisterToolStripMenuItem.Size = new Size(120, 22);
            adminRegisterToolStripMenuItem.Text = "Admin";
            adminRegisterToolStripMenuItem.Click += adminRegisterToolStripMenuItem_Click;
            // 
            // userLogToolStripMenuItem
            // 
            userLogToolStripMenuItem.Name = "userLogToolStripMenuItem";
            userLogToolStripMenuItem.Size = new Size(120, 22);
            userLogToolStripMenuItem.Text = "User Log";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(120, 22);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // appoinmentToolStripMenuItem
            // 
            appoinmentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addAppoinmentToolStripMenuItem, reschedulingToolStripMenuItem, historyToolStripMenuItem });
            appoinmentToolStripMenuItem.Name = "appoinmentToolStripMenuItem";
            appoinmentToolStripMenuItem.Size = new Size(86, 20);
            appoinmentToolStripMenuItem.Text = "Appoinment";
            // 
            // addAppoinmentToolStripMenuItem
            // 
            addAppoinmentToolStripMenuItem.Name = "addAppoinmentToolStripMenuItem";
            addAppoinmentToolStripMenuItem.Size = new Size(166, 22);
            addAppoinmentToolStripMenuItem.Text = "Add Appoinment";
            // 
            // reschedulingToolStripMenuItem
            // 
            reschedulingToolStripMenuItem.Name = "reschedulingToolStripMenuItem";
            reschedulingToolStripMenuItem.Size = new Size(166, 22);
            reschedulingToolStripMenuItem.Text = "Rescheduling";
            // 
            // historyToolStripMenuItem
            // 
            historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            historyToolStripMenuItem.Size = new Size(166, 22);
            historyToolStripMenuItem.Text = "History";
            // 
            // patientToolStripMenuItem
            // 
            patientToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { medicalRecordsToolStripMenuItem, diagnosesToolStripMenuItem, prescriptionsToolStripMenuItem, labResultsToolStripMenuItem, medicleHistoryToolStripMenuItem });
            patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            patientToolStripMenuItem.Size = new Size(56, 20);
            patientToolStripMenuItem.Text = "Patient";
            // 
            // medicalRecordsToolStripMenuItem
            // 
            medicalRecordsToolStripMenuItem.Name = "medicalRecordsToolStripMenuItem";
            medicalRecordsToolStripMenuItem.Size = new Size(158, 22);
            medicalRecordsToolStripMenuItem.Text = "Medical records";
            // 
            // diagnosesToolStripMenuItem
            // 
            diagnosesToolStripMenuItem.Name = "diagnosesToolStripMenuItem";
            diagnosesToolStripMenuItem.Size = new Size(158, 22);
            diagnosesToolStripMenuItem.Text = "Diagnoses";
            // 
            // prescriptionsToolStripMenuItem
            // 
            prescriptionsToolStripMenuItem.Name = "prescriptionsToolStripMenuItem";
            prescriptionsToolStripMenuItem.Size = new Size(158, 22);
            prescriptionsToolStripMenuItem.Text = "Prescriptions ";
            // 
            // labResultsToolStripMenuItem
            // 
            labResultsToolStripMenuItem.Name = "labResultsToolStripMenuItem";
            labResultsToolStripMenuItem.Size = new Size(158, 22);
            labResultsToolStripMenuItem.Text = "Lab Results";
            // 
            // medicleHistoryToolStripMenuItem
            // 
            medicleHistoryToolStripMenuItem.Name = "medicleHistoryToolStripMenuItem";
            medicleHistoryToolStripMenuItem.Size = new Size(158, 22);
            medicleHistoryToolStripMenuItem.Text = "Medicle History";
            // 
            // doctorsToolStripMenuItem
            // 
            doctorsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { profilesToolStripMenuItem, addToolStripMenuItem });
            doctorsToolStripMenuItem.Name = "doctorsToolStripMenuItem";
            doctorsToolStripMenuItem.Size = new Size(60, 20);
            doctorsToolStripMenuItem.Text = "Doctors";
            // 
            // profilesToolStripMenuItem
            // 
            profilesToolStripMenuItem.Name = "profilesToolStripMenuItem";
            profilesToolStripMenuItem.Size = new Size(113, 22);
            profilesToolStripMenuItem.Text = "Profiles";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(113, 22);
            addToolStripMenuItem.Text = "Add";
            // 
            // madicineToolStripMenuItem
            // 
            madicineToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { medicineListToolStripMenuItem });
            madicineToolStripMenuItem.Name = "madicineToolStripMenuItem";
            madicineToolStripMenuItem.Size = new Size(68, 20);
            madicineToolStripMenuItem.Text = "Medicine";
            // 
            // medicineListToolStripMenuItem
            // 
            medicineListToolStripMenuItem.Name = "medicineListToolStripMenuItem";
            medicineListToolStripMenuItem.Size = new Size(144, 22);
            medicineListToolStripMenuItem.Text = "Medicine List";
            medicineListToolStripMenuItem.Click += medicineListToolStripMenuItem_Click;
            // 
            // resourcesToolStripMenuItem
            // 
            resourcesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { roomsTheaterToolStripMenuItem, healthcareResouecesToolStripMenuItem });
            resourcesToolStripMenuItem.Name = "resourcesToolStripMenuItem";
            resourcesToolStripMenuItem.Size = new Size(72, 20);
            resourcesToolStripMenuItem.Text = "Resources";
            // 
            // roomsTheaterToolStripMenuItem
            // 
            roomsTheaterToolStripMenuItem.Name = "roomsTheaterToolStripMenuItem";
            roomsTheaterToolStripMenuItem.Size = new Size(189, 22);
            roomsTheaterToolStripMenuItem.Text = "Rooms & Theater";
            // 
            // healthcareResouecesToolStripMenuItem
            // 
            healthcareResouecesToolStripMenuItem.Name = "healthcareResouecesToolStripMenuItem";
            healthcareResouecesToolStripMenuItem.Size = new Size(189, 22);
            healthcareResouecesToolStripMenuItem.Text = "Healthcare Resoueces";
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { incomeToolStripMenuItem, patientReportToolStripMenuItem, resourceAllocationsToolStripMenuItem, doctorsToolStripMenuItem1 });
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(54, 20);
            reportToolStripMenuItem.Text = "Report";
            // 
            // incomeToolStripMenuItem
            // 
            incomeToolStripMenuItem.Name = "incomeToolStripMenuItem";
            incomeToolStripMenuItem.Size = new Size(182, 22);
            incomeToolStripMenuItem.Text = "Income";
            incomeToolStripMenuItem.Click += incomeToolStripMenuItem_Click;
            // 
            // patientReportToolStripMenuItem
            // 
            patientReportToolStripMenuItem.Name = "patientReportToolStripMenuItem";
            patientReportToolStripMenuItem.Size = new Size(182, 22);
            patientReportToolStripMenuItem.Text = "Patient report";
            patientReportToolStripMenuItem.Click += patientReportToolStripMenuItem_Click;
            // 
            // resourceAllocationsToolStripMenuItem
            // 
            resourceAllocationsToolStripMenuItem.Name = "resourceAllocationsToolStripMenuItem";
            resourceAllocationsToolStripMenuItem.Size = new Size(182, 22);
            resourceAllocationsToolStripMenuItem.Text = "Resource allocations";
            // 
            // doctorsToolStripMenuItem1
            // 
            doctorsToolStripMenuItem1.Name = "doctorsToolStripMenuItem1";
            doctorsToolStripMenuItem1.Size = new Size(182, 22);
            doctorsToolStripMenuItem1.Text = "Doctors";
            doctorsToolStripMenuItem1.Click += doctorsToolStripMenuItem1_Click;
            // 
            // billToolStripMenuItem
            // 
            billToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addBillToolStripMenuItem });
            billToolStripMenuItem.Name = "billToolStripMenuItem";
            billToolStripMenuItem.Size = new Size(35, 20);
            billToolStripMenuItem.Text = "Bill";
            // 
            // addBillToolStripMenuItem
            // 
            addBillToolStripMenuItem.Name = "addBillToolStripMenuItem";
            addBillToolStripMenuItem.Size = new Size(115, 22);
            addBillToolStripMenuItem.Text = "Add Bill";
            addBillToolStripMenuItem.Click += addBillToolStripMenuItem_Click;
            // 
            // btn_appoinment
            // 
            btn_appoinment.BackColor = Color.Snow;
            btn_appoinment.Cursor = Cursors.Hand;
            btn_appoinment.FlatAppearance.BorderColor = Color.RosyBrown;
            btn_appoinment.FlatAppearance.BorderSize = 5;
            btn_appoinment.ForeColor = Color.Snow;
            btn_appoinment.Image = (Image)resources.GetObject("btn_appoinment.Image");
            btn_appoinment.Location = new Point(189, 45);
            btn_appoinment.Name = "btn_appoinment";
            btn_appoinment.Size = new Size(81, 79);
            btn_appoinment.TabIndex = 0;
            btn_appoinment.Tag = "Appoinments";
            btn_appoinment.UseVisualStyleBackColor = false;
            btn_appoinment.Click += btn_appoinment_Click;
            // 
            // btn_patient
            // 
            btn_patient.BackColor = Color.Snow;
            btn_patient.Cursor = Cursors.Hand;
            btn_patient.FlatAppearance.BorderSize = 0;
            btn_patient.ForeColor = Color.Snow;
            btn_patient.Image = (Image)resources.GetObject("btn_patient.Image");
            btn_patient.Location = new Point(320, 45);
            btn_patient.Name = "btn_patient";
            btn_patient.Size = new Size(81, 79);
            btn_patient.TabIndex = 2;
            btn_patient.UseVisualStyleBackColor = false;
            btn_patient.Click += btn_patient_Click;
            // 
            // btn_doctors
            // 
            btn_doctors.BackColor = Color.Snow;
            btn_doctors.Cursor = Cursors.Hand;
            btn_doctors.FlatAppearance.BorderSize = 0;
            btn_doctors.ForeColor = Color.RosyBrown;
            btn_doctors.Image = (Image)resources.GetObject("btn_doctors.Image");
            btn_doctors.Location = new Point(459, 45);
            btn_doctors.Name = "btn_doctors";
            btn_doctors.Size = new Size(81, 80);
            btn_doctors.TabIndex = 3;
            btn_doctors.UseVisualStyleBackColor = false;
            btn_doctors.Click += btn_doctors_Click;
            // 
            // btn_resours
            // 
            btn_resours.BackColor = Color.Snow;
            btn_resours.Cursor = Cursors.Hand;
            btn_resours.FlatAppearance.BorderSize = 0;
            btn_resours.ForeColor = Color.Snow;
            btn_resours.Image = (Image)resources.GetObject("btn_resours.Image");
            btn_resours.Location = new Point(594, 44);
            btn_resours.Name = "btn_resours";
            btn_resours.Size = new Size(81, 80);
            btn_resours.TabIndex = 4;
            btn_resours.UseVisualStyleBackColor = false;
            btn_resours.Click += btn_resours_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.DodgerBlue;
            groupBox3.Controls.Add(count1);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.ForeColor = SystemColors.ButtonHighlight;
            groupBox3.Location = new Point(12, 45);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(146, 80);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "APOINMENT";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // count1
            // 
            count1.BackColor = Color.DodgerBlue;
            count1.BorderStyle = BorderStyle.None;
            count1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            count1.ForeColor = SystemColors.Info;
            count1.Location = new Point(58, 26);
            count1.Name = "count1";
            count1.Size = new Size(30, 36);
            count1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Snow;
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(12, 143);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(359, 245);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.health_care_plus_low_resolution_logo_color_on_transparent_background;
            pictureBox1.Location = new Point(121, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 101);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.BackColor = SystemColors.HighlightText;
            timer1.Controls.Add(monthCalendar1);
            timer1.Controls.Add(lbl_date);
            timer1.Controls.Add(lbl_time);
            timer1.Location = new Point(376, 144);
            timer1.Name = "timer1";
            timer1.Size = new Size(299, 245);
            timer1.TabIndex = 10;
            timer1.TabStop = false;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.Gray;
            monthCalendar1.ForeColor = SystemColors.WindowFrame;
            monthCalendar1.Location = new Point(39, 47);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 2;
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Font = new Font("Adobe Heiti Std R", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_date.ForeColor = SystemColors.ControlDarkDark;
            lbl_date.Location = new Point(103, 19);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(35, 15);
            lbl_date.TabIndex = 1;
            lbl_date.Text = "Date";
            // 
            // lbl_time
            // 
            lbl_time.AutoSize = true;
            lbl_time.Font = new Font("Adobe Heiti Std R", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_time.ForeColor = SystemColors.ControlDarkDark;
            lbl_time.Location = new Point(25, 19);
            lbl_time.Name = "lbl_time";
            lbl_time.Size = new Size(36, 15);
            lbl_time.TabIndex = 0;
            lbl_time.Text = "Time";
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Tick += timer2_Tick_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.Snow;
            ClientSize = new Size(695, 404);
            Controls.Add(btn_resours);
            Controls.Add(btn_doctors);
            Controls.Add(groupBox3);
            Controls.Add(btn_patient);
            Controls.Add(btn_appoinment);
            Controls.Add(timer1);
            Controls.Add(groupBox2);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ActiveCaptionText;
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "HealthCare Plus";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            timer1.ResumeLayout(false);
            timer1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem adminRegisterToolStripMenuItem;
        private ToolStripMenuItem appoinmentToolStripMenuItem;
        private ToolStripMenuItem patientToolStripMenuItem;
        private ToolStripMenuItem doctorsToolStripMenuItem;
        private ToolStripMenuItem resourcesToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem userLogToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem addAppoinmentToolStripMenuItem;
        private ToolStripMenuItem reschedulingToolStripMenuItem;
        private ToolStripMenuItem historyToolStripMenuItem;
        private ToolStripMenuItem medicalRecordsToolStripMenuItem;
        private ToolStripMenuItem diagnosesToolStripMenuItem;
        private ToolStripMenuItem prescriptionsToolStripMenuItem;
        private ToolStripMenuItem labResultsToolStripMenuItem;
        private ToolStripMenuItem medicleHistoryToolStripMenuItem;
        private ToolStripMenuItem profilesToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem roomsTheaterToolStripMenuItem;
        private ToolStripMenuItem healthcareResouecesToolStripMenuItem;
        private ToolStripMenuItem incomeToolStripMenuItem;
        private ToolStripMenuItem patientReportToolStripMenuItem;
        private ToolStripMenuItem resourceAllocationsToolStripMenuItem;
        private ToolStripMenuItem doctorsToolStripMenuItem1;
        private Button btn_appoinment;
        private Button btn_patient;
        private Button btn_doctors;
        private Button btn_resours;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox timer1;
        private Label lbl_date;
        private Label lbl_time;
        private System.Windows.Forms.Timer timer2;
        private MonthCalendar monthCalendar1;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private ToolStripMenuItem madicineToolStripMenuItem;
        private ToolStripMenuItem medicineListToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox count1;
        private TextBox count2;
        private TextBox count4;
        private TextBox count3;
        private PictureBox pictureBox1;
        private ToolStripMenuItem billToolStripMenuItem;
        private ToolStripMenuItem addBillToolStripMenuItem;
    }
}