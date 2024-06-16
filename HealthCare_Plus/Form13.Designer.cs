namespace HealthCare_Plus
{
    partial class appoinment
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
            p_name = new TextBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            p_tp = new TextBox();
            p_find = new Button();
            md_close = new Button();
            label1 = new Label();
            add = new Button();
            groupBox2 = new GroupBox();
            time = new DateTimePicker();
            label6 = new Label();
            date = new DateTimePicker();
            do_combo = new ComboBox();
            label11 = new Label();
            room = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            p_age = new TextBox();
            label5 = new Label();
            pa_tp = new TextBox();
            label4 = new Label();
            label3 = new Label();
            search_text = new TextBox();
            dataGridView1 = new DataGridView();
            update = new Button();
            refresh = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 25);
            label10.Name = "label10";
            label10.Size = new Size(79, 15);
            label10.TabIndex = 53;
            label10.Text = "Patient Name";
            // 
            // p_name
            // 
            p_name.ForeColor = SystemColors.WindowFrame;
            p_name.Location = new Point(105, 22);
            p_name.Name = "p_name";
            p_name.Size = new Size(179, 23);
            p_name.TabIndex = 54;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(p_tp);
            groupBox1.Controls.Add(p_find);
            groupBox1.Location = new Point(14, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(617, 46);
            groupBox1.TabIndex = 51;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 18);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Patient Tp";
            // 
            // p_tp
            // 
            p_tp.Location = new Point(77, 14);
            p_tp.Name = "p_tp";
            p_tp.Size = new Size(190, 23);
            p_tp.TabIndex = 2;
            // 
            // p_find
            // 
            p_find.Location = new Point(273, 14);
            p_find.Name = "p_find";
            p_find.Size = new Size(75, 23);
            p_find.TabIndex = 28;
            p_find.Text = "ADD";
            p_find.UseVisualStyleBackColor = true;
            p_find.Click += p_find_Click;
            // 
            // md_close
            // 
            md_close.Location = new Point(525, 143);
            md_close.Name = "md_close";
            md_close.Size = new Size(75, 23);
            md_close.TabIndex = 30;
            md_close.Text = "CLOSE";
            md_close.UseVisualStyleBackColor = true;
            md_close.Click += md_close_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 4);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 49;
            label1.Text = "Add Apoinment";
            // 
            // add
            // 
            add.Location = new Point(439, 143);
            add.Name = "add";
            add.Size = new Size(75, 23);
            add.TabIndex = 50;
            add.Text = "ADD";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(time);
            groupBox2.Controls.Add(md_close);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(date);
            groupBox2.Controls.Add(add);
            groupBox2.Controls.Add(do_combo);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(room);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(p_age);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(pa_tp);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(p_name);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(16, 74);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(615, 174);
            groupBox2.TabIndex = 55;
            groupBox2.TabStop = false;
            groupBox2.Text = "Appoinment Details";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // time
            // 
            time.Format = DateTimePickerFormat.Time;
            time.Location = new Point(411, 114);
            time.Name = "time";
            time.Size = new Size(190, 23);
            time.TabIndex = 69;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(345, 117);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 68;
            label6.Text = "Time";
            // 
            // date
            // 
            date.Location = new Point(411, 85);
            date.Name = "date";
            date.Size = new Size(190, 23);
            date.TabIndex = 67;
            // 
            // do_combo
            // 
            do_combo.FormattingEnabled = true;
            do_combo.Location = new Point(411, 25);
            do_combo.Name = "do_combo";
            do_combo.Size = new Size(190, 23);
            do_combo.TabIndex = 66;
            do_combo.SelectedIndexChanged += do_combo_SelectedIndexChanged_1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(345, 88);
            label11.Name = "label11";
            label11.Size = new Size(31, 15);
            label11.TabIndex = 65;
            label11.Text = "Date";
            // 
            // room
            // 
            room.FormattingEnabled = true;
            room.Items.AddRange(new object[] { "OPD Room 101", "OPD Room 102", "ICU  Room 103", "ICU  Room 104", "Operation Theatre 1", "Operation Theatre 2", "Operation Theatre 3" });
            room.Location = new Point(411, 54);
            room.Name = "room";
            room.Size = new Size(190, 23);
            room.TabIndex = 64;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(345, 57);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 63;
            label8.Text = "Room";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(345, 28);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 61;
            label7.Text = "Doctor";
            // 
            // p_age
            // 
            p_age.ForeColor = SystemColors.WindowFrame;
            p_age.Location = new Point(105, 80);
            p_age.Name = "p_age";
            p_age.Size = new Size(179, 23);
            p_age.TabIndex = 58;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 83);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 57;
            label5.Text = "Patient Age";
            // 
            // pa_tp
            // 
            pa_tp.ForeColor = SystemColors.WindowFrame;
            pa_tp.Location = new Point(105, 51);
            pa_tp.Name = "pa_tp";
            pa_tp.Size = new Size(179, 23);
            pa_tp.TabIndex = 56;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 54);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 55;
            label4.Text = "Patient TP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(369, 259);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 58;
            label3.Text = "TP";
            // 
            // search_text
            // 
            search_text.ForeColor = SystemColors.WindowFrame;
            search_text.Location = new Point(392, 255);
            search_text.Name = "search_text";
            search_text.Size = new Size(154, 23);
            search_text.TabIndex = 59;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 282);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(866, 121);
            dataGridView1.TabIndex = 57;
            // 
            // update
            // 
            update.Location = new Point(552, 254);
            update.Name = "update";
            update.Size = new Size(75, 23);
            update.TabIndex = 56;
            update.Text = "RESCHEDULE";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // refresh
            // 
            refresh.Location = new Point(22, 255);
            refresh.Name = "refresh";
            refresh.Size = new Size(75, 23);
            refresh.TabIndex = 70;
            refresh.Text = "REFRESH";
            refresh.UseVisualStyleBackColor = true;
            refresh.Click += refresh_Click;
            // 
            // appoinment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 403);
            Controls.Add(refresh);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(search_text);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(update);
            Name = "appoinment";
            Text = "APPOINMENT";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button refresh;
        private Label label10;
        private TextBox p_name;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox p_tp;
        private Button p_find;
        private Button md_close;
        private Button md_clear;
        private Label label1;
        private Button add;
        private GroupBox groupBox2;
        private TextBox p_age;
        private Label label5;
        private TextBox pa_tp;
        private Label label4;
        private Label label11;
        private ComboBox room;
        private Label label8;
        private Label label7;
        private ComboBox do_combo;
        private DateTimePicker time;
        private Label label6;
        private DateTimePicker date;
        private Label label3;
        private TextBox search_text;
        private DataGridView dataGridView1;
        private Button update;
    }
}