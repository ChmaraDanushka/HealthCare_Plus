namespace HealthCare_Plus
{
    partial class edit_hr
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
            hr_qt = new NumericUpDown();
            label9 = new Label();
            label2 = new Label();
            button2 = new Button();
            hr_name = new TextBox();
            pt_add = new Button();
            pt_clear = new Button();
            helth_resource = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hr_qt).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(hr_qt);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(hr_name);
            groupBox1.Controls.Add(pt_add);
            groupBox1.Controls.Add(pt_clear);
            groupBox1.Location = new Point(82, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(680, 93);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Details";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // hr_qt
            // 
            hr_qt.Location = new Point(447, 25);
            hr_qt.Name = "hr_qt";
            hr_qt.Size = new Size(120, 23);
            hr_qt.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(372, 27);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 32;
            label9.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 25);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "Resource Name";
            // 
            // button2
            // 
            button2.Location = new Point(599, 64);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 30;
            button2.Text = "CLOSE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // hr_name
            // 
            hr_name.Location = new Point(165, 22);
            hr_name.Name = "hr_name";
            hr_name.Size = new Size(190, 23);
            hr_name.TabIndex = 2;
            // 
            // pt_add
            // 
            pt_add.Location = new Point(437, 64);
            pt_add.Name = "pt_add";
            pt_add.Size = new Size(75, 23);
            pt_add.TabIndex = 28;
            pt_add.Text = "ADD";
            pt_add.UseVisualStyleBackColor = true;
            pt_add.Click += pt_add_Click;
            // 
            // pt_clear
            // 
            pt_clear.Location = new Point(518, 64);
            pt_clear.Name = "pt_clear";
            pt_clear.Size = new Size(75, 23);
            pt_clear.TabIndex = 29;
            pt_clear.Text = "CLEAR";
            pt_clear.UseVisualStyleBackColor = true;
            // 
            // helth_resource
            // 
            helth_resource.AutoSize = true;
            helth_resource.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            helth_resource.Location = new Point(33, 14);
            helth_resource.Name = "helth_resource";
            helth_resource.Size = new Size(211, 25);
            helth_resource.TabIndex = 45;
            helth_resource.Text = "EDIT HELTH RESOURCE";
            // 
            // edit_hr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 165);
            Controls.Add(groupBox1);
            Controls.Add(helth_resource);
            Name = "edit_hr";
            Text = "EDIT HELTH RESOURCE";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hr_qt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown hr_qt;
        private Label label9;
        private Label label2;
        private Button button2;
        private TextBox hr_name;
        private Button pt_add;
        private Button pt_clear;
        private Label helth_resource;
    }
}