namespace ExaminationApp
{
    partial class Admin_Dashboard
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
            this.btn_mng_students = new System.Windows.Forms.Button();
            this.btn_mng_instructors = new System.Windows.Forms.Button();
            this.btn_mng_departments = new System.Windows.Forms.Button();
            this.btn_mng_exam = new System.Windows.Forms.Button();
            this.lbl_admin_dashboard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_mng_students
            // 
            this.btn_mng_students.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mng_students.BackColor = System.Drawing.Color.Silver;
            this.btn_mng_students.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_mng_students.ForeColor = System.Drawing.Color.Black;
            this.btn_mng_students.Location = new System.Drawing.Point(1, 271);
            this.btn_mng_students.Name = "btn_mng_students";
            this.btn_mng_students.Size = new System.Drawing.Size(287, 199);
            this.btn_mng_students.TabIndex = 0;
            this.btn_mng_students.Text = "Manage Students";
            this.btn_mng_students.UseVisualStyleBackColor = false;
            this.btn_mng_students.Click += new System.EventHandler(this.btn_mng_students_Click);
            // 
            // btn_mng_instructors
            // 
            this.btn_mng_instructors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mng_instructors.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_mng_instructors.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_mng_instructors.ForeColor = System.Drawing.Color.White;
            this.btn_mng_instructors.Location = new System.Drawing.Point(303, 271);
            this.btn_mng_instructors.Name = "btn_mng_instructors";
            this.btn_mng_instructors.Size = new System.Drawing.Size(287, 199);
            this.btn_mng_instructors.TabIndex = 0;
            this.btn_mng_instructors.Text = "Manage Instructors";
            this.btn_mng_instructors.UseVisualStyleBackColor = false;
            // 
            // btn_mng_departments
            // 
            this.btn_mng_departments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mng_departments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_mng_departments.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_mng_departments.ForeColor = System.Drawing.Color.White;
            this.btn_mng_departments.Location = new System.Drawing.Point(609, 271);
            this.btn_mng_departments.Name = "btn_mng_departments";
            this.btn_mng_departments.Size = new System.Drawing.Size(287, 199);
            this.btn_mng_departments.TabIndex = 0;
            this.btn_mng_departments.Text = "Manage Departments";
            this.btn_mng_departments.UseVisualStyleBackColor = false;
            this.btn_mng_departments.Click += new System.EventHandler(this.btn_mng_departments_Click);
            // 
            // btn_mng_exam
            // 
            this.btn_mng_exam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mng_exam.BackColor = System.Drawing.Color.Yellow;
            this.btn_mng_exam.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_mng_exam.Location = new System.Drawing.Point(912, 271);
            this.btn_mng_exam.Name = "btn_mng_exam";
            this.btn_mng_exam.Size = new System.Drawing.Size(287, 199);
            this.btn_mng_exam.TabIndex = 0;
            this.btn_mng_exam.Text = "Manage Exam";
            this.btn_mng_exam.UseVisualStyleBackColor = false;
            // 
            // lbl_admin_dashboard
            // 
            this.lbl_admin_dashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_admin_dashboard.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_admin_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_admin_dashboard.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_admin_dashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_admin_dashboard.Location = new System.Drawing.Point(-9, -29);
            this.lbl_admin_dashboard.Name = "lbl_admin_dashboard";
            this.lbl_admin_dashboard.Padding = new System.Windows.Forms.Padding(57, 67, 57, 67);
            this.lbl_admin_dashboard.Size = new System.Drawing.Size(1375, 215);
            this.lbl_admin_dashboard.TabIndex = 3;
            this.lbl_admin_dashboard.Text = "Admin Dashboard";
            this.lbl_admin_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 482);
            this.Controls.Add(this.lbl_admin_dashboard);
            this.Controls.Add(this.btn_mng_exam);
            this.Controls.Add(this.btn_mng_departments);
            this.Controls.Add(this.btn_mng_instructors);
            this.Controls.Add(this.btn_mng_students);
            this.Name = "Admin_Dashboard";
            this.Text = "Admin Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_mng_students;
        private Button btn_mng_instructors;
        private Button btn_mng_departments;
        private Button btn_mng_exam;
        private Label lbl_admin_dashboard;
    }
}