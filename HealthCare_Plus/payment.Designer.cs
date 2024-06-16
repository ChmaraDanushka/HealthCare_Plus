namespace HealthCare_Plus
{
    partial class payment
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
            date = new DateTimePicker();
            time = new DateTimePicker();
            label2 = new Label();
            button2 = new Button();
            p_name = new TextBox();
            pt_add = new Button();
            label3 = new Label();
            p_tp = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label1 = new Label();
            label5 = new Label();
            price = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(price);
            groupBox1.Controls.Add(date);
            groupBox1.Controls.Add(time);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(p_name);
            groupBox1.Controls.Add(pt_add);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(p_tp);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(100, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(619, 183);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Details";
            // 
            // date
            // 
            date.Location = new Point(94, 85);
            date.Name = "date";
            date.Size = new Size(190, 23);
            date.TabIndex = 38;
            // 
            // time
            // 
            time.Format = DateTimePickerFormat.Time;
            time.Location = new Point(94, 116);
            time.Name = "time";
            time.Size = new Size(190, 23);
            time.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 21);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Patient Name";
            // 
            // button2
            // 
            button2.Location = new Point(336, 145);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 30;
            button2.Text = "CLOSE";
            button2.UseVisualStyleBackColor = true;
            // 
            // p_name
            // 
            p_name.Location = new Point(96, 18);
            p_name.Name = "p_name";
            p_name.Size = new Size(190, 23);
            p_name.TabIndex = 2;
            // 
            // pt_add
            // 
            pt_add.Location = new Point(253, 145);
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
            label3.Size = new Size(19, 15);
            label3.TabIndex = 3;
            label3.Text = "Tp";
            // 
            // p_tp
            // 
            p_tp.Location = new Point(95, 50);
            p_tp.Name = "p_tp";
            p_tp.Size = new Size(190, 23);
            p_tp.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 87);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 5;
            label4.Text = "DATE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 122);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 9;
            label6.Text = "TIME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 58);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 39;
            label1.Text = "PAYMENT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(367, 24);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 39;
            label5.Text = "Price";
            // 
            // price
            // 
            price.Location = new Point(406, 21);
            price.Name = "price";
            price.Size = new Size(190, 23);
            price.TabIndex = 40;
            // 
            // payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 317);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "payment";
            Text = "PAYMENT";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker date;
        private DateTimePicker time;
        private Label label2;
        private Button button2;
        private TextBox p_name;
        private Button pt_add;
        private Label label3;
        private TextBox p_tp;
        private Label label4;
        private Label label6;
        private Label label1;
        private Label label5;
        private TextBox price;
    }
}