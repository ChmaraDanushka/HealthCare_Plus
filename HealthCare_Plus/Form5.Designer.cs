namespace HealthCare_Plus
{
    partial class admin
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
            label2 = new Label();
            admin_name = new TextBox();
            admin_email = new TextBox();
            label3 = new Label();
            admin_tp = new TextBox();
            label4 = new Label();
            admin_password = new TextBox();
            label7 = new Label();
            admin_confiram_password = new TextBox();
            label8 = new Label();
            update = new Button();
            button2 = new Button();
            pt_add = new Button();
            pt_clear = new Button();
            groupBox1 = new GroupBox();
            admin_level = new ComboBox();
            label9 = new Label();
            admin_username = new TextBox();
            label5 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            search_text = new TextBox();
            label10 = new Label();
            refresh = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 0;
            label1.Text = "ADD ADMIN";
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
            // admin_name
            // 
            admin_name.Location = new Point(61, 18);
            admin_name.Name = "admin_name";
            admin_name.Size = new Size(190, 23);
            admin_name.TabIndex = 2;
            // 
            // admin_email
            // 
            admin_email.Location = new Point(61, 57);
            admin_email.Name = "admin_email";
            admin_email.Size = new Size(190, 23);
            admin_email.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 60);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // admin_tp
            // 
            admin_tp.Location = new Point(61, 97);
            admin_tp.Name = "admin_tp";
            admin_tp.Size = new Size(190, 23);
            admin_tp.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 100);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 5;
            label4.Text = "TP";
            // 
            // admin_password
            // 
            admin_password.Location = new Point(477, 58);
            admin_password.Name = "admin_password";
            admin_password.Size = new Size(190, 23);
            admin_password.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(356, 61);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 10;
            label7.Text = "Password";
            // 
            // admin_confiram_password
            // 
            admin_confiram_password.Location = new Point(477, 94);
            admin_confiram_password.Name = "admin_confiram_password";
            admin_confiram_password.Size = new Size(190, 23);
            admin_confiram_password.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(356, 97);
            label8.Name = "label8";
            label8.Size = new Size(104, 15);
            label8.TabIndex = 12;
            label8.Text = "Confirm Password";
            // 
            // update
            // 
            update.Location = new Point(713, 230);
            update.Name = "update";
            update.Size = new Size(75, 23);
            update.TabIndex = 31;
            update.Text = "UPDATE";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // button2
            // 
            button2.Location = new Point(594, 147);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 30;
            button2.Text = "CLOSE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pt_add
            // 
            pt_add.Location = new Point(432, 147);
            pt_add.Name = "pt_add";
            pt_add.Size = new Size(75, 23);
            pt_add.TabIndex = 28;
            pt_add.Text = "ADD";
            pt_add.UseVisualStyleBackColor = true;
            pt_add.Click += pt_add_Click;
            // 
            // pt_clear
            // 
            pt_clear.Location = new Point(513, 147);
            pt_clear.Name = "pt_clear";
            pt_clear.Size = new Size(75, 23);
            pt_clear.TabIndex = 29;
            pt_clear.Text = "CLEAR";
            pt_clear.UseVisualStyleBackColor = true;
            pt_clear.Click += pt_clear_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(admin_level);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(admin_username);
            groupBox1.Controls.Add(admin_tp);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(admin_name);
            groupBox1.Controls.Add(pt_add);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(pt_clear);
            groupBox1.Controls.Add(admin_email);
            groupBox1.Controls.Add(admin_confiram_password);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(admin_password);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(61, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(717, 183);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Details";
            // 
            // admin_level
            // 
            admin_level.FormattingEnabled = true;
            admin_level.Items.AddRange(new object[] { "1", "2" });
            admin_level.Location = new Point(61, 137);
            admin_level.Name = "admin_level";
            admin_level.Size = new Size(190, 23);
            admin_level.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(356, 21);
            label9.Name = "label9";
            label9.Size = new Size(65, 15);
            label9.TabIndex = 32;
            label9.Text = "User Name";
            // 
            // admin_username
            // 
            admin_username.Location = new Point(477, 21);
            admin_username.Name = "admin_username";
            admin_username.Size = new Size(190, 23);
            admin_username.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.AppWorkspace;
            label5.Location = new Point(68, 162);
            label5.Name = "label5";
            label5.Size = new Size(171, 15);
            label5.TabIndex = 7;
            label5.Text = "Level ( 1 = Admin / 2 = Doctor)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 140);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 9;
            label6.Text = "Level";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 259);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 188);
            dataGridView1.TabIndex = 33;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // search_text
            // 
            search_text.ForeColor = SystemColors.WindowFrame;
            search_text.Location = new Point(469, 230);
            search_text.Name = "search_text";
            search_text.Size = new Size(239, 23);
            search_text.TabIndex = 35;
            search_text.TextChanged += search_text_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(446, 234);
            label10.Name = "label10";
            label10.Size = new Size(20, 15);
            label10.TabIndex = 35;
            label10.Text = "TP";
            // 
            // refresh
            // 
            refresh.Location = new Point(12, 230);
            refresh.Name = "refresh";
            refresh.Size = new Size(75, 23);
            refresh.TabIndex = 38;
            refresh.Text = "Refresh";
            refresh.UseVisualStyleBackColor = true;
            refresh.Click += refresh_Click;
            // 
            // admin
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
            Name = "admin";
            Text = " Admin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox admin_name;
        private TextBox admin_email;
        private Label label3;
        private TextBox admin_tp;
        private Label label4;
        private TextBox admin_password;
        private Label label7;
        private TextBox admin_confiram_password;
        private Label label8;
        private Button update;
        private Button button2;
        private Button pt_add;
        private Button pt_clear;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Label label9;
        private TextBox admin_username;
        private Label label5;
        private Label label6;
        private ComboBox admin_level;
        private TextBox search_text;
        private Label label10;
        private Button refresh;
    }
}