namespace HealthCare_Plus
{
    partial class mdedit
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
            md_price = new TextBox();
            md_qt = new NumericUpDown();
            label9 = new Label();
            label2 = new Label();
            md_close = new Button();
            md_name = new TextBox();
            md_add = new Button();
            label3 = new Label();
            md_clear = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)md_qt).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(md_price);
            groupBox1.Controls.Add(md_qt);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(md_close);
            groupBox1.Controls.Add(md_name);
            groupBox1.Controls.Add(md_add);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(md_clear);
            groupBox1.Location = new Point(12, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(617, 127);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // md_price
            // 
            md_price.Location = new Point(417, 16);
            md_price.Name = "md_price";
            md_price.Size = new Size(190, 23);
            md_price.TabIndex = 36;
            // 
            // md_qt
            // 
            md_qt.Location = new Point(61, 51);
            md_qt.Name = "md_qt";
            md_qt.Size = new Size(190, 23);
            md_qt.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(356, 19);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 32;
            label9.Text = "Price";
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
            // md_close
            // 
            md_close.Location = new Point(532, 91);
            md_close.Name = "md_close";
            md_close.Size = new Size(75, 23);
            md_close.TabIndex = 30;
            md_close.Text = "CLOSE";
            md_close.UseVisualStyleBackColor = true;
            md_close.Click += md_close_Click;
            // 
            // md_name
            // 
            md_name.Location = new Point(61, 18);
            md_name.Name = "md_name";
            md_name.Size = new Size(190, 23);
            md_name.TabIndex = 2;
            // 
            // md_add
            // 
            md_add.Location = new Point(370, 91);
            md_add.Name = "md_add";
            md_add.Size = new Size(75, 23);
            md_add.TabIndex = 28;
            md_add.Text = "ADD";
            md_add.UseVisualStyleBackColor = true;
            md_add.Click += md_add_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 53);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 3;
            label3.Text = "QT";
            // 
            // md_clear
            // 
            md_clear.Location = new Point(451, 91);
            md_clear.Name = "md_clear";
            md_clear.Size = new Size(75, 23);
            md_clear.TabIndex = 29;
            md_clear.Text = "CLEAR";
            md_clear.UseVisualStyleBackColor = true;
            md_clear.Click += md_clear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(4, 6);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 45;
            label1.Text = "ADD MEDICINE";
            // 
            // mdedit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 168);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "mdedit";
            Text = "EDIT MEDICINE";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)md_qt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox md_price;
        private NumericUpDown md_qt;
        private Label label9;
        private Label label2;
        private Button md_close;
        private TextBox md_name;
        private Button md_add;
        private Label label3;
        private Button md_clear;
        private Label label1;
    }
}