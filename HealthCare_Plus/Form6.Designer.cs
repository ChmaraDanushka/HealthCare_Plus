namespace HealthCare_Plus
{
    partial class user_update
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
            groupBox1 = new GroupBox();
            admin_level = new ComboBox();
            update = new Button();
            label9 = new Label();
            button2 = new Button();
            admin_username = new TextBox();
            label8 = new Label();
            admin_tp = new TextBox();
            label6 = new Label();
            label2 = new Label();
            label7 = new Label();
            admin_name = new TextBox();
            admin_password = new TextBox();
            label3 = new Label();
            label5 = new Label();
            admin_email = new TextBox();
            label4 = new Label();
            admin_confiram_password = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(admin_level);
            groupBox1.Controls.Add(update);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(admin_username);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(admin_tp);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(admin_name);
            groupBox1.Controls.Add(admin_password);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(admin_email);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(admin_confiram_password);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(709, 201);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "REGISTRATION DETAILS";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // admin_level
            // 
            admin_level.FormattingEnabled = true;
            admin_level.Items.AddRange(new object[] { "1", "2" });
            admin_level.Location = new Point(71, 148);
            admin_level.Name = "admin_level";
            admin_level.Size = new Size(190, 23);
            admin_level.TabIndex = 49;
            // 
            // update
            // 
            update.Location = new Point(511, 151);
            update.Name = "update";
            update.Size = new Size(75, 23);
            update.TabIndex = 27;
            update.Text = "UPDATE";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(366, 32);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 47;
            label9.Text = "User Name";
            // 
            // button2
            // 
            button2.Location = new Point(601, 152);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 26;
            button2.Text = "CLOSE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // admin_username
            // 
            admin_username.Location = new Point(487, 32);
            admin_username.Name = "admin_username";
            admin_username.Size = new Size(190, 23);
            admin_username.TabIndex = 48;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(366, 108);
            label8.Name = "label8";
            label8.Size = new Size(107, 15);
            label8.TabIndex = 45;
            label8.Text = "Confirm Password";
            // 
            // admin_tp
            // 
            admin_tp.Location = new Point(71, 108);
            admin_tp.Name = "admin_tp";
            admin_tp.Size = new Size(190, 23);
            admin_tp.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 151);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 42;
            label6.Text = "Level";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 32);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 35;
            label2.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(366, 72);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 43;
            label7.Text = "Password";
            // 
            // admin_name
            // 
            admin_name.Location = new Point(71, 29);
            admin_name.Name = "admin_name";
            admin_name.Size = new Size(190, 23);
            admin_name.TabIndex = 36;
            // 
            // admin_password
            // 
            admin_password.Location = new Point(487, 69);
            admin_password.Name = "admin_password";
            admin_password.Size = new Size(190, 23);
            admin_password.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 71);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 37;
            label3.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.AppWorkspace;
            label5.Location = new Point(78, 173);
            label5.Name = "label5";
            label5.Size = new Size(179, 15);
            label5.TabIndex = 41;
            label5.Text = "Level ( 1 = Admin / 2 = Doctor)";
            // 
            // admin_email
            // 
            admin_email.Location = new Point(71, 68);
            admin_email.Name = "admin_email";
            admin_email.Size = new Size(190, 23);
            admin_email.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 111);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 39;
            label4.Text = "TP";
            // 
            // admin_confiram_password
            // 
            admin_confiram_password.Location = new Point(487, 105);
            admin_confiram_password.Name = "admin_confiram_password";
            admin_confiram_password.Size = new Size(190, 23);
            admin_confiram_password.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(237, 25);
            label1.TabIndex = 5;
            label1.Text = "UPDATE PATIENT DETAILS";
            // 
            // user_update
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 251);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "user_update";
            Text = "USER UPDATE";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button update;
        private Button button2;
        private Label label1;
        private ComboBox admin_level;
        private Label label9;
        private TextBox admin_username;
        private Label label8;
        private TextBox admin_tp;
        private Label label6;
        private Label label2;
        private Label label7;
        private TextBox admin_name;
        private TextBox admin_password;
        private Label label3;
        private Label label5;
        private TextBox admin_email;
        private Label label4;
        private TextBox admin_confiram_password;
    }
}