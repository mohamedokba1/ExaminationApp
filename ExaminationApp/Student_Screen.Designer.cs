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
            this.icon_exit = new FontAwesome.Sharp.IconButton();
            this.lbl_welcome_std = new System.Windows.Forms.Label();
            this.btn_start_exam = new System.Windows.Forms.Button();
            this.lbl_select_course = new System.Windows.Forms.Label();
            this.cbx_courses = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // icon_exit
            // 
            this.icon_exit.BackColor = System.Drawing.Color.Transparent;
            this.icon_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_exit.FlatAppearance.BorderSize = 0;
            this.icon_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icon_exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.icon_exit.IconColor = System.Drawing.Color.Red;
            this.icon_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon_exit.IconSize = 35;
            this.icon_exit.Location = new System.Drawing.Point(303, 15);
            this.icon_exit.Name = "icon_exit";
            this.icon_exit.Size = new System.Drawing.Size(44, 41);
            this.icon_exit.TabIndex = 9;
            this.icon_exit.UseVisualStyleBackColor = false;
            this.icon_exit.Click += new System.EventHandler(this.icon_exit_Click);
            // 
            // lbl_welcome_std
            // 
            this.lbl_welcome_std.AutoSize = true;
            this.lbl_welcome_std.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_welcome_std.Location = new System.Drawing.Point(104, 73);
            this.lbl_welcome_std.Name = "lbl_welcome_std";
            this.lbl_welcome_std.Size = new System.Drawing.Size(0, 20);
            this.lbl_welcome_std.TabIndex = 8;
            // 
            // btn_start_exam
            // 
            this.btn_start_exam.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_start_exam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start_exam.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_start_exam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_start_exam.Location = new System.Drawing.Point(44, 344);
            this.btn_start_exam.Name = "btn_start_exam";
            this.btn_start_exam.Size = new System.Drawing.Size(222, 57);
            this.btn_start_exam.TabIndex = 7;
            this.btn_start_exam.Text = "Start Exam";
            this.btn_start_exam.UseVisualStyleBackColor = false;
            this.btn_start_exam.Click += new System.EventHandler(this.btn_start_exam_Click);
            // 
            // lbl_select_course
            // 
            this.lbl_select_course.AutoSize = true;
            this.lbl_select_course.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_select_course.Location = new System.Drawing.Point(84, 168);
            this.lbl_select_course.Name = "lbl_select_course";
            this.lbl_select_course.Size = new System.Drawing.Size(131, 25);
            this.lbl_select_course.TabIndex = 6;
            this.lbl_select_course.Text = "Select Course";
            // 
            // cbx_courses
            // 
            this.cbx_courses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbx_courses.FormattingEnabled = true;
            this.cbx_courses.Location = new System.Drawing.Point(44, 221);
            this.cbx_courses.Name = "cbx_courses";
            this.cbx_courses.Size = new System.Drawing.Size(222, 28);
            this.cbx_courses.TabIndex = 5;
            // 
            // Student_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 442);
            this.Controls.Add(this.icon_exit);
            this.Controls.Add(this.lbl_welcome_std);
            this.Controls.Add(this.btn_start_exam);
            this.Controls.Add(this.lbl_select_course);
            this.Controls.Add(this.cbx_courses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student_Screen";
            this.Text = "Student_Screen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Student_Screen_FormClosed);
            this.Load += new System.EventHandler(this.Student_Screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton icon_exit;
        private Label lbl_welcome_std;
        private Button btn_start_exam;
        private Label lbl_select_course;
        private ComboBox cbx_courses;
    }
}