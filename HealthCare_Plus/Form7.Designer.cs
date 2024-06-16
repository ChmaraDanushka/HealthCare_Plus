namespace HealthCare_Plus
{
    partial class Form7
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
            label10 = new Label();
            search_text = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            do_out_time = new DateTimePicker();
            do_in_time = new DateTimePicker();
            label11 = new Label();
            do_speciality = new ComboBox();
            label9 = new Label();
            do_hospital = new TextBox();
            do_email = new TextBox();
            label2 = new Label();
            button2 = new Button();
            do_name = new TextBox();
            pt_add = new Button();
            label3 = new Label();
            pt_clear = new Button();
            do_tp = new TextBox();
            label4 = new Label();
            label8 = new Label();
            label5 = new Label();
            do_rgno = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            update = new Button();
            refresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(446, 231);
            label10.Name = "label10";
            label10.Size = new Size(20, 15);
            label10.TabIndex = 40;
            label10.Text = "TP";
            // 
            // search_text
            // 
            search_text.ForeColor = SystemColors.WindowFrame;
            search_text.Location = new Point(469, 227);
            search_text.Name = "search_text";
            search_text.Size = new Size(239, 23);
            search_text.TabIndex = 41;
            search_text.TextChanged += search_text_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 256);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 188);
            dataGridView1.TabIndex = 39;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(do_out_time);
            groupBox1.Controls.Add(do_in_time);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(do_speciality);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(do_hospital);
            groupBox1.Controls.Add(do_email);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(do_name);
            groupBox1.Controls.Add(pt_add);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(pt_clear);
            groupBox1.Controls.Add(do_tp);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(do_rgno);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(61, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(680, 183);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Details";
            // 
            // do_out_time
            // 
            do_out_time.Format = DateTimePickerFormat.Time;
            do_out_time.Location = new Point(475, 118);
            do_out_time.Name = "do_out_time";
            do_out_time.Size = new Size(97, 23);
            do_out_time.TabIndex = 37;
            // 
            // do_in_time
            // 
            do_in_time.Format = DateTimePickerFormat.Time;
            do_in_time.Location = new Point(477, 85);
            do_in_time.Name = "do_in_time";
            do_in_time.Size = new Size(95, 23);
            do_in_time.TabIndex = 36;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(356, 115);
            label11.Name = "label11";
            label11.Size = new Size(56, 15);
            label11.TabIndex = 35;
            label11.Text = "Out Time";
            // 
            // do_speciality
            // 
            do_speciality.FormattingEnabled = true;
            do_speciality.Items.AddRange(new object[] { "Anatomical Pathology", "Anesthesiology", "Cardiology", "Cardiovascular & Thoracic Surgery", "Clinical Immunology/Allergy", "Critical Care Medicine", "Dermatology", "Diagnostic Radiology", "Emergency Medicine", "Endocrinology and Metabolism", "Family Medicine", "Gastroenterology", "General Internal Medicine", "General Surgery", "General/Clinical Pathology" });
            do_speciality.Location = new Point(477, 16);
            do_speciality.Name = "do_speciality";
            do_speciality.Size = new Size(190, 23);
            do_speciality.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(356, 19);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 32;
            label9.Text = "Speciality'";
            // 
            // do_hospital
            // 
            do_hospital.Location = new Point(61, 118);
            do_hospital.Name = "do_hospital";
            do_hospital.Size = new Size(190, 23);
            do_hospital.TabIndex = 33;
            // 
            // do_email
            // 
            do_email.Location = new Point(61, 84);
            do_email.Name = "do_email";
            do_email.Size = new Size(190, 23);
            do_email.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 21);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // button2
            // 
            button2.Location = new Point(594, 155);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 30;
            button2.Text = "CLOSE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // do_name
            // 
            do_name.Location = new Point(61, 18);
            do_name.Name = "do_name";
            do_name.Size = new Size(190, 23);
            do_name.TabIndex = 2;
            // 
            // pt_add
            // 
            pt_add.Location = new Point(432, 155);
            pt_add.Name = "pt_add";
            pt_add.Size = new Size(75, 23);
            pt_add.TabIndex = 28;
            pt_add.Text = "ADD";
            pt_add.UseVisualStyleBackColor = true;
            pt_add.Click += pt_add_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 53);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 3;
            label3.Text = "TP";
            // 
            // pt_clear
            // 
            pt_clear.Location = new Point(513, 155);
            pt_clear.Name = "pt_clear";
            pt_clear.Size = new Size(75, 23);
            pt_clear.TabIndex = 29;
            pt_clear.Text = "CLEAR";
            pt_clear.UseVisualStyleBackColor = true;
            pt_clear.Click += pt_clear_Click;
            // 
            // do_tp
            // 
            do_tp.Location = new Point(61, 50);
            do_tp.Name = "do_tp";
            do_tp.Size = new Size(190, 23);
            do_tp.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 87);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 5;
            label4.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(356, 82);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 12;
            label8.Text = "In Time ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.AppWorkspace;
            label5.Location = new Point(68, 144);
            label5.Name = "label5";
            label5.Size = new Size(171, 15);
            label5.TabIndex = 7;
            label5.Text = "Level ( 1 = Admin / 2 = Doctor)";
            // 
            // do_rgno
            // 
            do_rgno.Location = new Point(477, 51);
            do_rgno.Name = "do_rgno";
            do_rgno.Size = new Size(190, 23);
            do_rgno.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(356, 54);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 10;
            label7.Text = "Reg.No";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 122);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 9;
            label6.Text = "Hospital";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 36;
            label1.Text = "ADD DOCTOR";
            // 
            // update
            // 
            update.Location = new Point(713, 227);
            update.Name = "update";
            update.Size = new Size(75, 23);
            update.TabIndex = 37;
            update.Text = "UPDATE";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // refresh
            // 
            refresh.Location = new Point(26, 226);
            refresh.Name = "refresh";
            refresh.Size = new Size(75, 23);
            refresh.TabIndex = 42;
            refresh.Text = "Refresh";
            refresh.UseVisualStyleBackColor = true;
            refresh.Click += refresh_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(refresh);
            Controls.Add(label10);
            Controls.Add(search_text);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(update);
            Name = "Form7";
            Text = "Doctor";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private TextBox search_text;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private DateTimePicker do_out_time;
        private DateTimePicker do_in_time;
        private Label label11;
        private ComboBox do_speciality;
        private Label label9;
        private TextBox do_hospital;
        private TextBox do_email;
        private Label label2;
        private Button button2;
        private TextBox do_name;
        private Button pt_add;
        private Label label3;
        private Button pt_clear;
        private TextBox do_tp;
        private Label label4;
        private Label label8;
        private Label label5;
        private TextBox do_rgno;
        private Label label7;
        private Label label6;
        private Label label1;
        private Button update;
        private Button refresh;
    }
}