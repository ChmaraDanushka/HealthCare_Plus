namespace HealthCare_Plus
{
    partial class Form4
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            update = new Button();
            button2 = new Button();
            patient_nic = new TextBox();
            ID = new Label();
            groupBox2 = new GroupBox();
            patient_g_tp = new TextBox();
            label13 = new Label();
            patient_g_address = new TextBox();
            label12 = new Label();
            label9 = new Label();
            patient_g_name = new TextBox();
            patient_g_age = new TextBox();
            label10 = new Label();
            patient_tp = new TextBox();
            label8 = new Label();
            patient_address = new TextBox();
            label7 = new Label();
            label6 = new Label();
            patient_age = new TextBox();
            label5 = new Label();
            label4 = new Label();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            patient_name = new TextBox();
            label3 = new Label();
            patient_id = new TextBox();
            label2 = new Label();
            patient_birth = new DateTimePicker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(237, 25);
            label1.TabIndex = 0;
            label1.Text = "UPDATE PATIENT DETAILS";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(patient_birth);
            groupBox1.Controls.Add(update);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(patient_nic);
            groupBox1.Controls.Add(ID);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(patient_tp);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(patient_address);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(patient_age);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(patient_name);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(patient_id);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 264);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "REGISTRATION DETAILS";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // update
            // 
            update.Location = new Point(565, 217);
            update.Name = "update";
            update.Size = new Size(75, 23);
            update.TabIndex = 27;
            update.Text = "UPDATE";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // button2
            // 
            button2.Location = new Point(652, 218);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 26;
            button2.Text = "CLOSE";
            button2.UseVisualStyleBackColor = true;
            // 
            // patient_nic
            // 
            patient_nic.Location = new Point(94, 99);
            patient_nic.Name = "patient_nic";
            patient_nic.Size = new Size(187, 23);
            patient_nic.TabIndex = 25;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ID.Location = new Point(30, 101);
            ID.Name = "ID";
            ID.Size = new Size(27, 15);
            ID.TabIndex = 24;
            ID.Text = "NIC";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(patient_g_tp);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(patient_g_address);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(patient_g_name);
            groupBox2.Controls.Add(patient_g_age);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(322, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(408, 131);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "PATIENT'S GUARDIAN DETAILS ";
            // 
            // patient_g_tp
            // 
            patient_g_tp.Location = new Point(150, 103);
            patient_g_tp.Name = "patient_g_tp";
            patient_g_tp.Size = new Size(187, 23);
            patient_g_tp.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(15, 105);
            label13.Name = "label13";
            label13.Size = new Size(20, 15);
            label13.TabIndex = 23;
            label13.Text = "TP";
            // 
            // patient_g_address
            // 
            patient_g_address.Location = new Point(150, 76);
            patient_g_address.Name = "patient_g_address";
            patient_g_address.Size = new Size(187, 23);
            patient_g_address.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(15, 78);
            label12.Name = "label12";
            label12.Size = new Size(56, 15);
            label12.TabIndex = 21;
            label12.Text = "ADDRESS";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(15, 25);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 17;
            label9.Text = "NAME";
            // 
            // patient_g_name
            // 
            patient_g_name.Location = new Point(150, 23);
            patient_g_name.Name = "patient_g_name";
            patient_g_name.Size = new Size(187, 23);
            patient_g_name.TabIndex = 18;
            // 
            // patient_g_age
            // 
            patient_g_age.Location = new Point(150, 50);
            patient_g_age.Name = "patient_g_age";
            patient_g_age.Size = new Size(187, 23);
            patient_g_age.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(15, 52);
            label10.Name = "label10";
            label10.Size = new Size(29, 15);
            label10.TabIndex = 19;
            label10.Text = "AGE";
            // 
            // patient_tp
            // 
            patient_tp.Location = new Point(94, 214);
            patient_tp.Name = "patient_tp";
            patient_tp.Size = new Size(187, 23);
            patient_tp.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(30, 217);
            label8.Name = "label8";
            label8.Size = new Size(20, 15);
            label8.TabIndex = 15;
            label8.Text = "TP";
            // 
            // patient_address
            // 
            patient_address.Location = new Point(94, 185);
            patient_address.Name = "patient_address";
            patient_address.Size = new Size(187, 23);
            patient_address.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(30, 187);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 13;
            label7.Text = "ADDRESS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(30, 159);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 11;
            label6.Text = "BIRTH";
            // 
            // patient_age
            // 
            patient_age.Location = new Point(94, 128);
            patient_age.Name = "patient_age";
            patient_age.Size = new Size(187, 23);
            patient_age.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(30, 130);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 9;
            label5.Text = "AGE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(30, 75);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 8;
            label4.Text = "GENDER";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(223, 75);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(58, 19);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "Other";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(152, 75);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(65, 19);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(93, 75);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(52, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // patient_name
            // 
            patient_name.Location = new Point(94, 49);
            patient_name.Name = "patient_name";
            patient_name.Size = new Size(187, 23);
            patient_name.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 51);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 3;
            label3.Text = "NAME";
            // 
            // patient_id
            // 
            patient_id.Location = new Point(94, 21);
            patient_id.Name = "patient_id";
            patient_id.Size = new Size(187, 23);
            patient_id.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 23);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // patient_birth
            // 
            patient_birth.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            patient_birth.Location = new Point(93, 156);
            patient_birth.Name = "patient_birth";
            patient_birth.Size = new Size(188, 22);
            patient_birth.TabIndex = 28;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button update;
        private Button button2;
        private TextBox patient_nic;
        private Label ID;
        private GroupBox groupBox2;
        private TextBox patient_g_tp;
        private Label label13;
        private TextBox patient_g_address;
        private Label label12;
        private Label label9;
        private TextBox patient_g_name;
        private TextBox patient_g_age;
        private Label label10;
        private TextBox patient_tp;
        private Label label8;
        private TextBox patient_address;
        private Label label7;
        private Label label6;
        private TextBox patient_age;
        private Label label5;
        private Label label4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox patient_name;
        private Label label3;
        private TextBox patient_id;
        private Label label2;
        private DateTimePicker patient_birth;
    }
}