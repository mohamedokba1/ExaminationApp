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
            this.btn_mang_students = new System.Windows.Forms.Button();
            this.btn_mng_instructor = new System.Windows.Forms.Button();
            this.btn_mng_depts = new System.Windows.Forms.Button();
            this.btn_gen_exam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_mang_students
            // 
            this.btn_mang_students.Location = new System.Drawing.Point(46, 95);
            this.btn_mang_students.Name = "btn_mang_students";
            this.btn_mang_students.Size = new System.Drawing.Size(153, 80);
            this.btn_mang_students.TabIndex = 0;
            this.btn_mang_students.Text = "Manage Students";
            this.btn_mang_students.UseVisualStyleBackColor = true;
            // 
            // btn_mng_instructor
            // 
            this.btn_mng_instructor.Location = new System.Drawing.Point(229, 95);
            this.btn_mng_instructor.Name = "btn_mng_instructor";
            this.btn_mng_instructor.Size = new System.Drawing.Size(153, 83);
            this.btn_mng_instructor.TabIndex = 0;
            this.btn_mng_instructor.Text = "Manage Instructor";
            this.btn_mng_instructor.UseVisualStyleBackColor = true;
            // 
            // btn_mng_depts
            // 
            this.btn_mng_depts.Location = new System.Drawing.Point(408, 95);
            this.btn_mng_depts.Name = "btn_mng_depts";
            this.btn_mng_depts.Size = new System.Drawing.Size(153, 83);
            this.btn_mng_depts.TabIndex = 0;
            this.btn_mng_depts.Text = "Manage Departments";
            this.btn_mng_depts.UseVisualStyleBackColor = true;
            // 
            // btn_gen_exam
            // 
            this.btn_gen_exam.Location = new System.Drawing.Point(583, 95);
            this.btn_gen_exam.Name = "btn_gen_exam";
            this.btn_gen_exam.Size = new System.Drawing.Size(153, 80);
            this.btn_gen_exam.TabIndex = 0;
            this.btn_gen_exam.Text = "Generate Exam";
            this.btn_gen_exam.UseVisualStyleBackColor = true;
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_gen_exam);
            this.Controls.Add(this.btn_mng_depts);
            this.Controls.Add(this.btn_mng_instructor);
            this.Controls.Add(this.btn_mang_students);
            this.Name = "Admin_Dashboard";
            this.Text = "Admin_Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_mang_students;
        private Button btn_mng_instructor;
        private Button btn_mng_depts;
        private Button btn_gen_exam;
    }
}