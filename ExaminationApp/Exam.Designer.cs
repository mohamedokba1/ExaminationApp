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
            this.btn_back_home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Exam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(307, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Duration";
            // 
            // lbl_dept_id
            // 
            this.lbl_dept_id.AutoSize = true;
            this.lbl_dept_id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_dept_id.Location = new System.Drawing.Point(38, 41);
            this.lbl_dept_id.Name = "lbl_dept_id";
            this.lbl_dept_id.Size = new System.Drawing.Size(113, 28);
            this.lbl_dept_id.TabIndex = 13;
            this.lbl_dept_id.Text = "Pass_Score";
            // 
            // cbx_courses
            // 
            this.cbx_courses.FormattingEnabled = true;
            this.cbx_courses.Location = new System.Drawing.Point(222, 97);
            this.cbx_courses.Name = "cbx_courses";
            this.cbx_courses.Size = new System.Drawing.Size(264, 28);
            this.cbx_courses.TabIndex = 12;
            // 
            // txt_duration
            // 
            this.txt_duration.Location = new System.Drawing.Point(410, 45);
            this.txt_duration.Name = "txt_duration";
            this.txt_duration.Size = new System.Drawing.Size(143, 27);
            this.txt_duration.TabIndex = 10;
            // 
            // txt_pass_score
            // 
            this.txt_pass_score.Location = new System.Drawing.Point(157, 44);
            this.txt_pass_score.Name = "txt_pass_score";
            this.txt_pass_score.Size = new System.Drawing.Size(96, 27);
            this.txt_pass_score.TabIndex = 11;
            // 
            // btn_delete_dept
            // 
            this.btn_delete_dept.BackColor = System.Drawing.Color.Red;
            this.btn_delete_dept.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delete_dept.ForeColor = System.Drawing.Color.White;
            this.btn_delete_dept.Location = new System.Drawing.Point(394, 163);
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
            this.btn_update_dept.Location = new System.Drawing.Point(262, 163);
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
            this.btn_add_dept.Location = new System.Drawing.Point(131, 163);
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
            this.dgv_Exam.Location = new System.Drawing.Point(51, 240);
            this.dgv_Exam.Name = "dgv_Exam";
            this.dgv_Exam.RowHeadersWidth = 51;
            this.dgv_Exam.RowTemplate.Height = 29;
            this.dgv_Exam.Size = new System.Drawing.Size(517, 191);
            this.dgv_Exam.TabIndex = 6;
            this.dgv_Exam.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Exam_RowHeaderMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(131, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Course";
            // 
            // btn_back_home
            // 
            this.btn_back_home.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_back_home.FlatAppearance.BorderSize = 0;
            this.btn_back_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back_home.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_back_home.Location = new System.Drawing.Point(131, 454);
            this.btn_back_home.Name = "btn_back_home";
            this.btn_back_home.Size = new System.Drawing.Size(367, 47);
            this.btn_back_home.TabIndex = 40;
            this.btn_back_home.Text = "Back To Home";
            this.btn_back_home.UseVisualStyleBackColor = false;
            this.btn_back_home.Click += new System.EventHandler(this.btn_back_home_Click);
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 525);
            this.Controls.Add(this.btn_back_home);
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
        private Button btn_back_home;
    }
}