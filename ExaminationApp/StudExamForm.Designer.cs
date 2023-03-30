namespace ExaminationApp
{
    partial class StudExamForm
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
            label2 = new Label();
            label1 = new Label();
            lbl_dept_id = new Label();
            btn_delete_dept = new Button();
            btn_update_dept = new Button();
            btn_add_dept = new Button();
            dgv_StdExam = new DataGridView();
            label3 = new Label();
            cb_stds = new ComboBox();
            label4 = new Label();
            cb_exams = new ComboBox();
            icon_exit = new FontAwesome.Sharp.IconButton();
            cb_status = new ComboBox();
            txt_st_score = new NumericUpDown();
            dtp_date = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgv_StdExam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt_st_score).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(52, 203);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 50;
            label2.Text = "Score";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(140, 33);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 49;
            label1.Text = "Exam";
            // 
            // lbl_dept_id
            // 
            lbl_dept_id.AutoSize = true;
            lbl_dept_id.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_dept_id.Location = new Point(117, 87);
            lbl_dept_id.Name = "lbl_dept_id";
            lbl_dept_id.Size = new Size(86, 28);
            lbl_dept_id.TabIndex = 48;
            lbl_dept_id.Text = "Student";
            // 
            // btn_delete_dept
            // 
            btn_delete_dept.BackColor = Color.Red;
            btn_delete_dept.FlatAppearance.BorderSize = 0;
            btn_delete_dept.FlatStyle = FlatStyle.Flat;
            btn_delete_dept.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete_dept.ForeColor = Color.White;
            btn_delete_dept.Location = new Point(394, 275);
            btn_delete_dept.Name = "btn_delete_dept";
            btn_delete_dept.Size = new Size(106, 48);
            btn_delete_dept.TabIndex = 42;
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
            btn_update_dept.Location = new Point(246, 275);
            btn_update_dept.Name = "btn_update_dept";
            btn_update_dept.Size = new Size(106, 48);
            btn_update_dept.TabIndex = 43;
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
            btn_add_dept.Location = new Point(102, 275);
            btn_add_dept.Name = "btn_add_dept";
            btn_add_dept.Size = new Size(106, 48);
            btn_add_dept.TabIndex = 44;
            btn_add_dept.Text = "Add";
            btn_add_dept.UseVisualStyleBackColor = false;
            btn_add_dept.Click += btn_add_dept_Click;
            // 
            // dgv_StdExam
            // 
            dgv_StdExam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_StdExam.Location = new Point(12, 342);
            dgv_StdExam.Name = "dgv_StdExam";
            dgv_StdExam.RowHeadersWidth = 51;
            dgv_StdExam.RowTemplate.Height = 29;
            dgv_StdExam.Size = new Size(579, 192);
            dgv_StdExam.TabIndex = 41;
            dgv_StdExam.RowHeaderMouseDoubleClick += dgv_StdExam_RowHeaderMouseDoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(132, 141);
            label3.Name = "label3";
            label3.Size = new Size(71, 28);
            label3.TabIndex = 53;
            label3.Text = "Status";
            // 
            // cb_stds
            // 
            cb_stds.FormattingEnabled = true;
            cb_stds.Location = new Point(246, 91);
            cb_stds.Name = "cb_stds";
            cb_stds.Size = new Size(225, 28);
            cb_stds.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(217, 206);
            label4.Name = "label4";
            label4.Size = new Size(114, 28);
            label4.TabIndex = 55;
            label4.Text = "Exam Date";
            // 
            // cb_exams
            // 
            cb_exams.FormattingEnabled = true;
            cb_exams.Location = new Point(246, 37);
            cb_exams.Name = "cb_exams";
            cb_exams.Size = new Size(225, 28);
            cb_exams.TabIndex = 54;
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
            icon_exit.Location = new Point(547, 12);
            icon_exit.Name = "icon_exit";
            icon_exit.Size = new Size(44, 41);
            icon_exit.TabIndex = 57;
            icon_exit.UseVisualStyleBackColor = false;
            icon_exit.Click += icon_exit_Click;
            // 
            // cb_status
            // 
            cb_status.FormattingEnabled = true;
            cb_status.Location = new Point(246, 141);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(225, 28);
            cb_status.TabIndex = 58;
            // 
            // txt_st_score
            // 
            txt_st_score.Location = new Point(122, 207);
            txt_st_score.Name = "txt_st_score";
            txt_st_score.Size = new Size(63, 27);
            txt_st_score.TabIndex = 59;
            // 
            // dtp_date
            // 
            dtp_date.Location = new Point(337, 208);
            dtp_date.Name = "dtp_date";
            dtp_date.Size = new Size(238, 27);
            dtp_date.TabIndex = 60;
            // 
            // StudExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 557);
            Controls.Add(dtp_date);
            Controls.Add(txt_st_score);
            Controls.Add(cb_status);
            Controls.Add(icon_exit);
            Controls.Add(label4);
            Controls.Add(cb_exams);
            Controls.Add(label3);
            Controls.Add(cb_stds);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl_dept_id);
            Controls.Add(btn_delete_dept);
            Controls.Add(btn_update_dept);
            Controls.Add(btn_add_dept);
            Controls.Add(dgv_StdExam);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudExamForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudExamForm";
            Load += StudExamForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_StdExam).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt_st_score).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Label lbl_dept_id;
        private Button btn_delete_dept;
        private Button btn_update_dept;
        private Button btn_add_dept;
        private DataGridView dgv_StdExam;
        private Label label3;
        private ComboBox cb_stds;
        private Label label4;
        private ComboBox cb_exams;
        private FontAwesome.Sharp.IconButton icon_exit;
        private ComboBox cb_status;
        private NumericUpDown txt_st_score;
        private DateTimePicker dtp_date;
    }
}