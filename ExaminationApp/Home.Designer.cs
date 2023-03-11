namespace ExaminationApp
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_student = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Instructor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_admin
            // 
            this.btn_admin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_admin.BackColor = System.Drawing.Color.Tomato;
            this.btn_admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_admin.FlatAppearance.BorderSize = 0;
            this.btn_admin.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_admin.ForeColor = System.Drawing.Color.White;
            this.btn_admin.Location = new System.Drawing.Point(1053, 235);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(469, 265);
            this.btn_admin.TabIndex = 1;
            this.btn_admin.Text = "Admin";
            this.btn_admin.UseVisualStyleBackColor = false;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            this.btn_admin.MouseEnter += new System.EventHandler(this.btn_admin_MouseEnter);
            this.btn_admin.MouseLeave += new System.EventHandler(this.btn_admin_MouseLeave);
            // 
            // btn_student
            // 
            this.btn_student.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_student.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_student.FlatAppearance.BorderSize = 0;
            this.btn_student.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_student.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_student.Location = new System.Drawing.Point(106, 235);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(470, 265);
            this.btn_student.TabIndex = 1;
            this.btn_student.Text = "Student";
            this.btn_student.UseVisualStyleBackColor = false;
            this.btn_student.Click += new System.EventHandler(this.btn_student_Click);
            this.btn_student.MouseEnter += new System.EventHandler(this.btn_student_MouseEnter);
            this.btn_student.MouseLeave += new System.EventHandler(this.btn_student_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-2, -1);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(57, 67, 57, 67);
            this.label1.Size = new System.Drawing.Size(1536, 215);
            this.label1.TabIndex = 2;
            this.label1.Text = "ITI Examination System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Instructor
            // 
            this.btn_Instructor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Instructor.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Instructor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Instructor.FlatAppearance.BorderSize = 0;
            this.btn_Instructor.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Instructor.ForeColor = System.Drawing.Color.White;
            this.btn_Instructor.Location = new System.Drawing.Point(582, 235);
            this.btn_Instructor.Name = "btn_Instructor";
            this.btn_Instructor.Size = new System.Drawing.Size(469, 265);
            this.btn_Instructor.TabIndex = 1;
            this.btn_Instructor.Text = "Instructor";
            this.btn_Instructor.UseVisualStyleBackColor = false;
            this.btn_Instructor.Click += new System.EventHandler(this.btn_Instructor_Click);
            this.btn_Instructor.MouseEnter += new System.EventHandler(this.btn_Instructor_MouseEnter);
            this.btn_Instructor.MouseLeave += new System.EventHandler(this.btn_Instructor_MouseLeave);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1534, 528);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_student);
            this.Controls.Add(this.btn_Instructor);
            this.Controls.Add(this.btn_admin);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Examination System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_admin;
        private Button btn_student;
        private Label label1;
        private Button btn_Instructor;
    }
}