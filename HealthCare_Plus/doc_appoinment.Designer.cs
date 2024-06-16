namespace HealthCare_Plus
{
    partial class doc_appoinment
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
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            do_speciality = new TextBox();
            do_tp = new TextBox();
            do_name = new TextBox();
            do_id = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 25);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 53);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "NAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 82);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 2;
            label3.Text = "TP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 110);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "SPECIALITY";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(do_speciality);
            groupBox1.Controls.Add(do_tp);
            groupBox1.Controls.Add(do_name);
            groupBox1.Controls.Add(do_id);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 144);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "YOUR DETAILS";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // do_speciality
            // 
            do_speciality.Location = new Point(130, 108);
            do_speciality.Name = "do_speciality";
            do_speciality.Size = new Size(100, 23);
            do_speciality.TabIndex = 11;
            // 
            // do_tp
            // 
            do_tp.Location = new Point(130, 79);
            do_tp.Name = "do_tp";
            do_tp.Size = new Size(100, 23);
            do_tp.TabIndex = 10;
            // 
            // do_name
            // 
            do_name.Location = new Point(130, 50);
            do_name.Name = "do_name";
            do_name.Size = new Size(100, 23);
            do_name.TabIndex = 9;
            // 
            // do_id
            // 
            do_id.Location = new Point(130, 21);
            do_id.Name = "do_id";
            do_id.Size = new Size(100, 23);
            do_id.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 168);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 270);
            dataGridView1.TabIndex = 46;
            // 
            // button1
            // 
            button1.Location = new Point(686, 110);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "CLODE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // doc_appoinment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "doc_appoinment";
            Text = "doc_appoinment";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox do_speciality;
        private TextBox do_tp;
        private TextBox do_name;
        private TextBox do_id;
        private DataGridView dataGridView1;
        private Button button1;
    }
}