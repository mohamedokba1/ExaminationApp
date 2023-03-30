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
            btn_mng_students = new Button();
            btn_mng_instructors = new Button();
            btn_mng_departments = new Button();
            btn_mng_exam = new Button();
            btn_mng_topics = new Button();
            btn_mng_courses = new Button();
            label1 = new Label();
            icon_exit = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // btn_mng_students
            // 
            btn_mng_students.Anchor = AnchorStyles.None;
            btn_mng_students.BackColor = Color.Silver;
            btn_mng_students.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_mng_students.ForeColor = Color.Black;
            btn_mng_students.Location = new Point(557, 186);
            btn_mng_students.Name = "btn_mng_students";
            btn_mng_students.Size = new Size(469, 166);
            btn_mng_students.TabIndex = 0;
            btn_mng_students.Text = "Manage Students";
            btn_mng_students.UseVisualStyleBackColor = false;
            btn_mng_students.Click += btn_mng_students_Click;
            // 
            // btn_mng_instructors
            // 
            btn_mng_instructors.Anchor = AnchorStyles.None;
            btn_mng_instructors.BackColor = SystemColors.MenuHighlight;
            btn_mng_instructors.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_mng_instructors.ForeColor = Color.White;
            btn_mng_instructors.Location = new Point(23, 186);
            btn_mng_instructors.Name = "btn_mng_instructors";
            btn_mng_instructors.Size = new Size(469, 166);
            btn_mng_instructors.TabIndex = 0;
            btn_mng_instructors.Text = "Manage Instructors";
            btn_mng_instructors.UseVisualStyleBackColor = false;
            btn_mng_instructors.Click += btn_mng_instructors_Click;
            // 
            // btn_mng_departments
            // 
            btn_mng_departments.Anchor = AnchorStyles.None;
            btn_mng_departments.BackColor = Color.FromArgb(255, 192, 128);
            btn_mng_departments.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_mng_departments.ForeColor = Color.White;
            btn_mng_departments.Location = new Point(23, 419);
            btn_mng_departments.Name = "btn_mng_departments";
            btn_mng_departments.Size = new Size(469, 166);
            btn_mng_departments.TabIndex = 0;
            btn_mng_departments.Text = "Manage Departments";
            btn_mng_departments.UseVisualStyleBackColor = false;
            btn_mng_departments.Click += btn_mng_departments_Click;
            // 
            // btn_mng_exam
            // 
            btn_mng_exam.Anchor = AnchorStyles.None;
            btn_mng_exam.BackColor = Color.Yellow;
            btn_mng_exam.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_mng_exam.Location = new Point(557, 419);
            btn_mng_exam.Name = "btn_mng_exam";
            btn_mng_exam.Size = new Size(469, 166);
            btn_mng_exam.TabIndex = 0;
            btn_mng_exam.Text = "Manage Exam";
            btn_mng_exam.UseVisualStyleBackColor = false;
            btn_mng_exam.Click += btn_mng_exam_Click;
            // 
            // btn_mng_topics
            // 
            btn_mng_topics.Anchor = AnchorStyles.None;
            btn_mng_topics.BackColor = Color.RosyBrown;
            btn_mng_topics.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_mng_topics.ForeColor = Color.White;
            btn_mng_topics.Location = new Point(23, 651);
            btn_mng_topics.Name = "btn_mng_topics";
            btn_mng_topics.Size = new Size(469, 166);
            btn_mng_topics.TabIndex = 7;
            btn_mng_topics.Text = "Manage Topics";
            btn_mng_topics.UseVisualStyleBackColor = false;
            btn_mng_topics.Click += btn_mng_topics_Click;
            // 
            // btn_mng_courses
            // 
            btn_mng_courses.Anchor = AnchorStyles.None;
            btn_mng_courses.BackColor = Color.Coral;
            btn_mng_courses.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_mng_courses.ForeColor = Color.White;
            btn_mng_courses.Location = new Point(557, 651);
            btn_mng_courses.Name = "btn_mng_courses";
            btn_mng_courses.Size = new Size(469, 166);
            btn_mng_courses.TabIndex = 8;
            btn_mng_courses.Text = "Manage Courses";
            btn_mng_courses.UseVisualStyleBackColor = false;
            btn_mng_courses.Click += btn_mng_courses_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 55F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(337, 29);
            label1.Name = "label1";
            label1.Size = new Size(375, 123);
            label1.TabIndex = 9;
            label1.Text = "ADMIN";
            // 
            // icon_exit
            // 
            icon_exit.FlatAppearance.BorderSize = 0;
            icon_exit.FlatStyle = FlatStyle.Flat;
            icon_exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            icon_exit.IconColor = Color.Red;
            icon_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_exit.IconSize = 35;
            icon_exit.Location = new Point(1001, 12);
            icon_exit.Name = "icon_exit";
            icon_exit.Size = new Size(47, 39);
            icon_exit.TabIndex = 10;
            icon_exit.UseVisualStyleBackColor = true;
            icon_exit.Click += icon_exit_Click;
            // 
            // Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 881);
            Controls.Add(icon_exit);
            Controls.Add(label1);
            Controls.Add(btn_mng_topics);
            Controls.Add(btn_mng_courses);
            Controls.Add(btn_mng_exam);
            Controls.Add(btn_mng_departments);
            Controls.Add(btn_mng_instructors);
            Controls.Add(btn_mng_students);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin_Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_mng_students;
        private Button btn_mng_instructors;
        private Button btn_mng_departments;
        private Button btn_mng_exam;
        private Button btn_mng_topics;
        private Button btn_mng_courses;
        private Label label1;
        private FontAwesome.Sharp.IconButton icon_exit;
    }
}