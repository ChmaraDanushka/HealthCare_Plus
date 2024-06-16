namespace HealthCare_Plus
{
    partial class docInterFace
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
            pictureBox1 = new PictureBox();
            do_search = new TextBox();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(158, 162);
            label1.Name = "label1";
            label1.Size = new Size(310, 28);
            label1.TabIndex = 1;
            label1.Text = "WELCOME TO DOCTOR PORTAL";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.health_care_plus_low_resolution_logo_color_on_transparent_background;
            pictureBox1.Location = new Point(263, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 104);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // do_search
            // 
            do_search.Location = new Point(212, 216);
            do_search.Name = "do_search";
            do_search.Size = new Size(199, 23);
            do_search.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(265, 242);
            label2.Name = "label2";
            label2.Size = new Size(85, 13);
            label2.TabIndex = 3;
            label2.Text = "Enter Doctor Id";
            // 
            // button1
            // 
            button1.Location = new Point(269, 270);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "ENTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // docInterFace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(do_search);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "docInterFace";
            Text = "docInterFace";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox do_search;
        private Label label2;
        private Button button1;
    }
}