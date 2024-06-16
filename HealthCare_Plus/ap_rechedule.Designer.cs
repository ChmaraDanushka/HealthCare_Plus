namespace HealthCare_Plus
{
    partial class ap_rechedule
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
            groupBox2 = new GroupBox();
            pa_name = new Label();
            label2 = new Label();
            time = new DateTimePicker();
            md_close = new Button();
            label6 = new Label();
            date = new DateTimePicker();
            add = new Button();
            label11 = new Label();
            label1 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pa_name);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(time);
            groupBox2.Controls.Add(md_close);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(date);
            groupBox2.Controls.Add(add);
            groupBox2.Controls.Add(label11);
            groupBox2.Location = new Point(12, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(615, 125);
            groupBox2.TabIndex = 56;
            groupBox2.TabStop = false;
            groupBox2.Text = "Appoinment Details";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // pa_name
            // 
            pa_name.AutoSize = true;
            pa_name.Location = new Point(98, 31);
            pa_name.Name = "pa_name";
            pa_name.Size = new Size(0, 15);
            pa_name.TabIndex = 71;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 31);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 70;
            label2.Text = "TP";
            // 
            // time
            // 
            time.Format = DateTimePickerFormat.Time;
            time.Location = new Point(401, 61);
            time.Name = "time";
            time.Size = new Size(190, 23);
            time.TabIndex = 69;
            // 
            // md_close
            // 
            md_close.Location = new Point(516, 90);
            md_close.Name = "md_close";
            md_close.Size = new Size(75, 23);
            md_close.TabIndex = 30;
            md_close.Text = "CLOSE";
            md_close.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(335, 64);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 68;
            label6.Text = "Time";
            // 
            // date
            // 
            date.Location = new Point(98, 58);
            date.Name = "date";
            date.Size = new Size(190, 23);
            date.TabIndex = 67;
            // 
            // add
            // 
            add.Location = new Point(430, 90);
            add.Name = "add";
            add.Size = new Size(75, 23);
            add.TabIndex = 50;
            add.Text = "SET";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(32, 61);
            label11.Name = "label11";
            label11.Size = new Size(31, 15);
            label11.TabIndex = 65;
            label11.Text = "Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(165, 25);
            label1.TabIndex = 57;
            label1.Text = "RESET Apoinment";
            // 
            // ap_rechedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 183);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Name = "ap_rechedule";
            Text = "ap_rechedule";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private DateTimePicker time;
        private Button md_close;
        private Label label6;
        private DateTimePicker date;
        private Button add;
        private Label label11;
        private Label label1;
        private Label pa_name;
        private Label label2;
    }
}