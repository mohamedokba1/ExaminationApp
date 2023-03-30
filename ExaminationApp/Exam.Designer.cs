namespace ExaminationApp
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
            label1 = new Label();
            lbl_dept_id = new Label();
            cbx_courses = new ComboBox();
            txt_duration = new TextBox();
            txt_pass_score = new TextBox();
            btn_delete_dept = new Button();
            btn_update_dept = new Button();
            btn_add_dept = new Button();
            dgv_Exam = new DataGridView();
            label2 = new Label();
            icon_exit = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgv_Exam).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(313, 59);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 14;
            label1.Text = "Duration";
            // 
            // lbl_dept_id
            // 
            lbl_dept_id.AutoSize = true;
            lbl_dept_id.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_dept_id.Location = new Point(44, 60);
            lbl_dept_id.Name = "lbl_dept_id";
            lbl_dept_id.Size = new Size(111, 28);
            lbl_dept_id.TabIndex = 13;
            lbl_dept_id.Text = "Pass Score";
            // 
            // cbx_courses
            // 
            cbx_courses.FormattingEnabled = true;
            cbx_courses.Location = new Point(228, 112);
            cbx_courses.Name = "cbx_courses";
            cbx_courses.Size = new Size(264, 28);
            cbx_courses.TabIndex = 12;
            // 
            // txt_duration
            // 
            txt_duration.Location = new Point(416, 60);
            txt_duration.Name = "txt_duration";
            txt_duration.Size = new Size(147, 27);
            txt_duration.TabIndex = 10;
            // 
            // txt_pass_score
            // 
            txt_pass_score.Location = new Point(163, 59);
            txt_pass_score.Name = "txt_pass_score";
            txt_pass_score.Size = new Size(125, 27);
            txt_pass_score.TabIndex = 11;
            // 
            // btn_delete_dept
            // 
            btn_delete_dept.BackColor = Color.Red;
            btn_delete_dept.FlatAppearance.BorderSize = 0;
            btn_delete_dept.FlatStyle = FlatStyle.Flat;
            btn_delete_dept.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete_dept.ForeColor = Color.White;
            btn_delete_dept.Location = new Point(400, 178);
            btn_delete_dept.Name = "btn_delete_dept";
            btn_delete_dept.Size = new Size(106, 48);
            btn_delete_dept.TabIndex = 7;
            btn_delete_dept.Text = "Delete";
            btn_delete_dept.UseVisualStyleBackColor = false;
            btn_delete_dept.Click += btn_delete_dept_Click;
            // 
            // btn_update_dept
            // 
            btn_update_dept.BackColor = Color.Gold;
            btn_update_dept.FlatAppearance.BorderSize = 0;
            btn_update_dept.FlatStyle = FlatStyle.Flat;
            btn_update_dept.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update_dept.Location = new Point(268, 178);
            btn_update_dept.Name = "btn_update_dept";
            btn_update_dept.Size = new Size(106, 48);
            btn_update_dept.TabIndex = 8;
            btn_update_dept.Text = "Update";
            btn_update_dept.UseVisualStyleBackColor = false;
            btn_update_dept.Click += btn_update_dept_Click;
            // 
            // btn_add_dept
            // 
            btn_add_dept.BackColor = Color.YellowGreen;
            btn_add_dept.FlatAppearance.BorderSize = 0;
            btn_add_dept.FlatStyle = FlatStyle.Flat;
            btn_add_dept.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add_dept.ForeColor = SystemColors.ButtonHighlight;
            btn_add_dept.Location = new Point(137, 178);
            btn_add_dept.Name = "btn_add_dept";
            btn_add_dept.Size = new Size(106, 48);
            btn_add_dept.TabIndex = 9;
            btn_add_dept.Text = "Add";
            btn_add_dept.UseVisualStyleBackColor = false;
            btn_add_dept.Click += btn_add_dept_Click;
            // 
            // dgv_Exam
            // 
            dgv_Exam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Exam.Location = new Point(44, 269);
            dgv_Exam.Name = "dgv_Exam";
            dgv_Exam.RowHeadersWidth = 51;
            dgv_Exam.RowTemplate.Height = 29;
            dgv_Exam.Size = new Size(543, 228);
            dgv_Exam.TabIndex = 6;
            dgv_Exam.RowHeaderMouseDoubleClick += dgv_Exam_RowHeaderMouseDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(137, 112);
            label2.Name = "label2";
            label2.Size = new Size(76, 28);
            label2.TabIndex = 15;
            label2.Text = "Course";
            // 
            // icon_exit
            // 
            icon_exit.Cursor = Cursors.Hand;
            icon_exit.FlatAppearance.BorderSize = 0;
            icon_exit.FlatStyle = FlatStyle.Flat;
            icon_exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            icon_exit.IconColor = Color.Red;
            icon_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_exit.IconSize = 35;
            icon_exit.Location = new Point(581, 3);
            icon_exit.Name = "icon_exit";
            icon_exit.Size = new Size(47, 41);
            icon_exit.TabIndex = 17;
            icon_exit.UseVisualStyleBackColor = true;
            icon_exit.Click += icon_exit_Click;
            // 
            // ExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 520);
            Controls.Add(icon_exit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl_dept_id);
            Controls.Add(cbx_courses);
            Controls.Add(txt_duration);
            Controls.Add(txt_pass_score);
            Controls.Add(btn_delete_dept);
            Controls.Add(btn_update_dept);
            Controls.Add(btn_add_dept);
            Controls.Add(dgv_Exam);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ExamForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exam";
            Load += ExamForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Exam).EndInit();
            ResumeLayout(false);
            PerformLayout();
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