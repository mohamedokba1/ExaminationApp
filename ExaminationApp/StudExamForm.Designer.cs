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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_dept_id = new System.Windows.Forms.Label();
            this.btn_delete_dept = new System.Windows.Forms.Button();
            this.btn_update_dept = new System.Windows.Forms.Button();
            this.btn_add_dept = new System.Windows.Forms.Button();
            this.dgv_StdExam = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_stds = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_exams = new System.Windows.Forms.ComboBox();
            this.icon_exit = new FontAwesome.Sharp.IconButton();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.txt_st_score = new System.Windows.Forms.NumericUpDown();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StdExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_st_score)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(52, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 50;
            this.label2.Text = "Score";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(140, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 28);
            this.label1.TabIndex = 49;
            this.label1.Text = "Exam";
            // 
            // lbl_dept_id
            // 
            this.lbl_dept_id.AutoSize = true;
            this.lbl_dept_id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_dept_id.Location = new System.Drawing.Point(117, 87);
            this.lbl_dept_id.Name = "lbl_dept_id";
            this.lbl_dept_id.Size = new System.Drawing.Size(86, 28);
            this.lbl_dept_id.TabIndex = 48;
            this.lbl_dept_id.Text = "Student";
            // 
            // btn_delete_dept
            // 
            this.btn_delete_dept.BackColor = System.Drawing.Color.Red;
            this.btn_delete_dept.FlatAppearance.BorderSize = 0;
            this.btn_delete_dept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_dept.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delete_dept.ForeColor = System.Drawing.Color.White;
            this.btn_delete_dept.Location = new System.Drawing.Point(353, 275);
            this.btn_delete_dept.Name = "btn_delete_dept";
            this.btn_delete_dept.Size = new System.Drawing.Size(106, 48);
            this.btn_delete_dept.TabIndex = 42;
            this.btn_delete_dept.Text = "Delete";
            this.btn_delete_dept.UseVisualStyleBackColor = false;
            this.btn_delete_dept.Click += new System.EventHandler(this.btn_delete_dept_Click);
            // 
            // btn_update_dept
            // 
            this.btn_update_dept.BackColor = System.Drawing.Color.Gold;
            this.btn_update_dept.FlatAppearance.BorderSize = 0;
            this.btn_update_dept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_dept.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_update_dept.Location = new System.Drawing.Point(225, 275);
            this.btn_update_dept.Name = "btn_update_dept";
            this.btn_update_dept.Size = new System.Drawing.Size(106, 48);
            this.btn_update_dept.TabIndex = 43;
            this.btn_update_dept.Text = "Update";
            this.btn_update_dept.UseVisualStyleBackColor = false;
            this.btn_update_dept.Click += new System.EventHandler(this.btn_update_dept_Click);
            // 
            // btn_add_dept
            // 
            this.btn_add_dept.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_add_dept.FlatAppearance.BorderSize = 0;
            this.btn_add_dept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_dept.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add_dept.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add_dept.Location = new System.Drawing.Point(102, 275);
            this.btn_add_dept.Name = "btn_add_dept";
            this.btn_add_dept.Size = new System.Drawing.Size(106, 48);
            this.btn_add_dept.TabIndex = 44;
            this.btn_add_dept.Text = "Add";
            this.btn_add_dept.UseVisualStyleBackColor = false;
            this.btn_add_dept.Click += new System.EventHandler(this.btn_add_dept_Click);
            // 
            // dgv_StdExam
            // 
            this.dgv_StdExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StdExam.Location = new System.Drawing.Point(12, 342);
            this.dgv_StdExam.Name = "dgv_StdExam";
            this.dgv_StdExam.RowHeadersWidth = 51;
            this.dgv_StdExam.RowTemplate.Height = 29;
            this.dgv_StdExam.Size = new System.Drawing.Size(579, 192);
            this.dgv_StdExam.TabIndex = 41;
            this.dgv_StdExam.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_StdExam_RowHeaderMouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(132, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 28);
            this.label3.TabIndex = 53;
            this.label3.Text = "Status";
            // 
            // cb_stds
            // 
            this.cb_stds.FormattingEnabled = true;
            this.cb_stds.Location = new System.Drawing.Point(246, 91);
            this.cb_stds.Name = "cb_stds";
            this.cb_stds.Size = new System.Drawing.Size(225, 28);
            this.cb_stds.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(217, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 28);
            this.label4.TabIndex = 55;
            this.label4.Text = "Exam Date";
            // 
            // cb_exams
            // 
            this.cb_exams.FormattingEnabled = true;
            this.cb_exams.Location = new System.Drawing.Point(246, 37);
            this.cb_exams.Name = "cb_exams";
            this.cb_exams.Size = new System.Drawing.Size(225, 28);
            this.cb_exams.TabIndex = 54;
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
            this.icon_exit.Location = new System.Drawing.Point(547, 12);
            this.icon_exit.Name = "icon_exit";
            this.icon_exit.Size = new System.Drawing.Size(44, 41);
            this.icon_exit.TabIndex = 57;
            this.icon_exit.UseVisualStyleBackColor = false;
            this.icon_exit.Click += new System.EventHandler(this.icon_exit_Click);
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(246, 141);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(225, 28);
            this.cb_status.TabIndex = 58;
            // 
            // txt_st_score
            // 
            this.txt_st_score.Location = new System.Drawing.Point(122, 207);
            this.txt_st_score.Name = "txt_st_score";
            this.txt_st_score.Size = new System.Drawing.Size(63, 27);
            this.txt_st_score.TabIndex = 59;
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(337, 205);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(238, 27);
            this.dtp_date.TabIndex = 60;
            // 
            // StudExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 557);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.txt_st_score);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.icon_exit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_exams);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_stds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_dept_id);
            this.Controls.Add(this.btn_delete_dept);
            this.Controls.Add(this.btn_update_dept);
            this.Controls.Add(this.btn_add_dept);
            this.Controls.Add(this.dgv_StdExam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudExamForm";
            this.Text = "StudExamForm";
            this.Load += new System.EventHandler(this.StudExamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StdExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_st_score)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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