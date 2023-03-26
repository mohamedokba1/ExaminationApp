﻿namespace ExaminationApp
{
    partial class ExamForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_dept_id = new System.Windows.Forms.Label();
            this.cbx_courses = new System.Windows.Forms.ComboBox();
            this.txt_duration = new System.Windows.Forms.TextBox();
            this.txt_pass_score = new System.Windows.Forms.TextBox();
            this.btn_delete_dept = new System.Windows.Forms.Button();
            this.btn_update_dept = new System.Windows.Forms.Button();
            this.btn_add_dept = new System.Windows.Forms.Button();
            this.dgv_Exam = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.icon_exit = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Exam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(313, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Duration";
            // 
            // lbl_dept_id
            // 
            this.lbl_dept_id.AutoSize = true;
            this.lbl_dept_id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_dept_id.Location = new System.Drawing.Point(44, 60);
            this.lbl_dept_id.Name = "lbl_dept_id";
            this.lbl_dept_id.Size = new System.Drawing.Size(111, 28);
            this.lbl_dept_id.TabIndex = 13;
            this.lbl_dept_id.Text = "Pass Score";
            // 
            // cbx_courses
            // 
            this.cbx_courses.FormattingEnabled = true;
            this.cbx_courses.Location = new System.Drawing.Point(228, 112);
            this.cbx_courses.Name = "cbx_courses";
            this.cbx_courses.Size = new System.Drawing.Size(264, 28);
            this.cbx_courses.TabIndex = 12;
            // 
            // txt_duration
            // 
            this.txt_duration.Location = new System.Drawing.Point(416, 60);
            this.txt_duration.Name = "txt_duration";
            this.txt_duration.Size = new System.Drawing.Size(147, 27);
            this.txt_duration.TabIndex = 10;
            // 
            // txt_pass_score
            // 
            this.txt_pass_score.Location = new System.Drawing.Point(163, 59);
            this.txt_pass_score.Name = "txt_pass_score";
            this.txt_pass_score.Size = new System.Drawing.Size(125, 27);
            this.txt_pass_score.TabIndex = 11;
            // 
            // btn_delete_dept
            // 
            this.btn_delete_dept.BackColor = System.Drawing.Color.Red;
            this.btn_delete_dept.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delete_dept.ForeColor = System.Drawing.Color.White;
            this.btn_delete_dept.Location = new System.Drawing.Point(400, 178);
            this.btn_delete_dept.Name = "btn_delete_dept";
            this.btn_delete_dept.Size = new System.Drawing.Size(106, 48);
            this.btn_delete_dept.TabIndex = 7;
            this.btn_delete_dept.Text = "Delete";
            this.btn_delete_dept.UseVisualStyleBackColor = false;
            this.btn_delete_dept.Click += new System.EventHandler(this.btn_delete_dept_Click);
            // 
            // btn_update_dept
            // 
            this.btn_update_dept.BackColor = System.Drawing.Color.Gold;
            this.btn_update_dept.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_update_dept.Location = new System.Drawing.Point(268, 178);
            this.btn_update_dept.Name = "btn_update_dept";
            this.btn_update_dept.Size = new System.Drawing.Size(106, 48);
            this.btn_update_dept.TabIndex = 8;
            this.btn_update_dept.Text = "Update";
            this.btn_update_dept.UseVisualStyleBackColor = false;
            this.btn_update_dept.Click += new System.EventHandler(this.btn_update_dept_Click);
            // 
            // btn_add_dept
            // 
            this.btn_add_dept.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_add_dept.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add_dept.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add_dept.Location = new System.Drawing.Point(137, 178);
            this.btn_add_dept.Name = "btn_add_dept";
            this.btn_add_dept.Size = new System.Drawing.Size(106, 48);
            this.btn_add_dept.TabIndex = 9;
            this.btn_add_dept.Text = "Add";
            this.btn_add_dept.UseVisualStyleBackColor = false;
            this.btn_add_dept.Click += new System.EventHandler(this.btn_add_dept_Click);
            // 
            // dgv_Exam
            // 
            this.dgv_Exam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Exam.Location = new System.Drawing.Point(44, 269);
            this.dgv_Exam.Name = "dgv_Exam";
            this.dgv_Exam.RowHeadersWidth = 51;
            this.dgv_Exam.RowTemplate.Height = 29;
            this.dgv_Exam.Size = new System.Drawing.Size(543, 228);
            this.dgv_Exam.TabIndex = 6;
            this.dgv_Exam.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Exam_RowHeaderMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(137, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Course";
            // 
            // icon_exit
            // 
            this.icon_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_exit.FlatAppearance.BorderSize = 0;
            this.icon_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icon_exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.icon_exit.IconColor = System.Drawing.Color.Red;
            this.icon_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon_exit.IconSize = 35;
            this.icon_exit.Location = new System.Drawing.Point(581, 3);
            this.icon_exit.Name = "icon_exit";
            this.icon_exit.Size = new System.Drawing.Size(47, 41);
            this.icon_exit.TabIndex = 17;
            this.icon_exit.UseVisualStyleBackColor = true;
            this.icon_exit.Click += new System.EventHandler(this.icon_exit_Click);
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 520);
            this.Controls.Add(this.icon_exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_dept_id);
            this.Controls.Add(this.cbx_courses);
            this.Controls.Add(this.txt_duration);
            this.Controls.Add(this.txt_pass_score);
            this.Controls.Add(this.btn_delete_dept);
            this.Controls.Add(this.btn_update_dept);
            this.Controls.Add(this.btn_add_dept);
            this.Controls.Add(this.dgv_Exam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExamForm";
            this.Text = "Exam";
            this.Load += new System.EventHandler(this.ExamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Exam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lbl_dept_id;
        private ComboBox cbx_courses;
        private TextBox txt_duration;
        private TextBox txt_pass_score;
        private Button btn_delete_dept;
        private Button btn_update_dept;
        private Button btn_add_dept;
        private DataGridView dgv_Exam;
        private Label label2;
        private FontAwesome.Sharp.IconButton icon_exit;
    }
}