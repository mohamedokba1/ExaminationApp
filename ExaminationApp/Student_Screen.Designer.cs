namespace ExaminationApp
{
    partial class Student_Screen
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
            icon_exit = new FontAwesome.Sharp.IconButton();
            lbl_welcome_std = new Label();
            btn_start_exam = new Button();
            lbl_select_course = new Label();
            cbx_courses = new ComboBox();
            SuspendLayout();
            // 
            // icon_exit
            // 
            icon_exit.BackColor = Color.Transparent;
            icon_exit.Cursor = Cursors.Hand;
            icon_exit.FlatAppearance.BorderSize = 0;
            icon_exit.FlatStyle = FlatStyle.Flat;
            icon_exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            icon_exit.IconColor = Color.Red;
            icon_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_exit.IconSize = 35;
            icon_exit.Location = new Point(303, 15);
            icon_exit.Name = "icon_exit";
            icon_exit.Size = new Size(44, 41);
            icon_exit.TabIndex = 9;
            icon_exit.UseVisualStyleBackColor = false;
            icon_exit.Click += icon_exit_Click;
            // 
            // lbl_welcome_std
            // 
            lbl_welcome_std.AutoSize = true;
            lbl_welcome_std.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_welcome_std.Location = new Point(104, 73);
            lbl_welcome_std.Name = "lbl_welcome_std";
            lbl_welcome_std.Size = new Size(0, 20);
            lbl_welcome_std.TabIndex = 8;
            // 
            // btn_start_exam
            // 
            btn_start_exam.BackColor = Color.SandyBrown;
            btn_start_exam.Cursor = Cursors.Hand;
            btn_start_exam.FlatStyle = FlatStyle.Flat;
            btn_start_exam.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btn_start_exam.ForeColor = SystemColors.ButtonHighlight;
            btn_start_exam.Location = new Point(55, 344);
            btn_start_exam.Name = "btn_start_exam";
            btn_start_exam.Size = new Size(222, 57);
            btn_start_exam.TabIndex = 7;
            btn_start_exam.Text = "Start Exam";
            btn_start_exam.UseVisualStyleBackColor = false;
            btn_start_exam.Click += btn_start_exam_Click;
            // 
            // lbl_select_course
            // 
            lbl_select_course.AutoSize = true;
            lbl_select_course.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_select_course.Location = new Point(92, 156);
            lbl_select_course.Name = "lbl_select_course";
            lbl_select_course.Size = new Size(131, 25);
            lbl_select_course.TabIndex = 6;
            lbl_select_course.Text = "Select Course";
            // 
            // cbx_courses
            // 
            cbx_courses.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbx_courses.FormattingEnabled = true;
            cbx_courses.Location = new Point(55, 205);
            cbx_courses.Name = "cbx_courses";
            cbx_courses.Size = new Size(222, 28);
            cbx_courses.TabIndex = 5;
            // 
            // Student_Screen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 442);
            Controls.Add(icon_exit);
            Controls.Add(lbl_welcome_std);
            Controls.Add(btn_start_exam);
            Controls.Add(lbl_select_course);
            Controls.Add(cbx_courses);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Student_Screen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student_Screen";
            FormClosed += Student_Screen_FormClosed;
            Load += Student_Screen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton icon_exit;
        private Label lbl_welcome_std;
        private Button btn_start_exam;
        private Label lbl_select_course;
        private ComboBox cbx_courses;
    }
}