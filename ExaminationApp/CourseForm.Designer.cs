namespace ExaminationApp
{
    partial class CourseForm
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
            cbx_topics = new ComboBox();
            txt_duration = new TextBox();
            txt_crs_name = new TextBox();
            btn_delete_dept = new Button();
            btn_update_dept = new Button();
            btn_add_dept = new Button();
            dgv_course = new DataGridView();
            icon_exit = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgv_course).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(130, 120);
            label2.Name = "label2";
            label2.Size = new Size(62, 28);
            label2.TabIndex = 50;
            label2.Text = "Topic";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(307, 72);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 49;
            label1.Text = "Duration";
            // 
            // lbl_dept_id
            // 
            lbl_dept_id.AutoSize = true;
            lbl_dept_id.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_dept_id.Location = new Point(36, 68);
            lbl_dept_id.Name = "lbl_dept_id";
            lbl_dept_id.Size = new Size(68, 28);
            lbl_dept_id.TabIndex = 48;
            lbl_dept_id.Text = "Name";
            // 
            // cbx_topics
            // 
            cbx_topics.FormattingEnabled = true;
            cbx_topics.Location = new Point(210, 124);
            cbx_topics.Name = "cbx_topics";
            cbx_topics.Size = new Size(264, 28);
            cbx_topics.TabIndex = 47;
            // 
            // txt_duration
            // 
            txt_duration.Location = new Point(409, 72);
            txt_duration.Name = "txt_duration";
            txt_duration.Size = new Size(173, 27);
            txt_duration.TabIndex = 45;
            // 
            // txt_crs_name
            // 
            txt_crs_name.Location = new Point(110, 73);
            txt_crs_name.Name = "txt_crs_name";
            txt_crs_name.Size = new Size(180, 27);
            txt_crs_name.TabIndex = 46;
            // 
            // btn_delete_dept
            // 
            btn_delete_dept.BackColor = Color.Red;
            btn_delete_dept.FlatAppearance.BorderSize = 0;
            btn_delete_dept.FlatStyle = FlatStyle.Flat;
            btn_delete_dept.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete_dept.ForeColor = Color.White;
            btn_delete_dept.Location = new Point(396, 193);
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
            btn_update_dept.Location = new Point(258, 193);
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
            btn_add_dept.Location = new Point(121, 193);
            btn_add_dept.Name = "btn_add_dept";
            btn_add_dept.Size = new Size(106, 48);
            btn_add_dept.TabIndex = 44;
            btn_add_dept.Text = "Add";
            btn_add_dept.UseVisualStyleBackColor = false;
            btn_add_dept.Click += btn_add_dept_Click;
            // 
            // dgv_course
            // 
            dgv_course.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_course.Location = new Point(51, 268);
            dgv_course.Name = "dgv_course";
            dgv_course.RowHeadersWidth = 51;
            dgv_course.RowTemplate.Height = 29;
            dgv_course.Size = new Size(550, 241);
            dgv_course.TabIndex = 41;
            dgv_course.RowHeaderMouseDoubleClick += dgv_course_RowHeaderMouseDoubleClick;
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
            icon_exit.Location = new Point(605, 12);
            icon_exit.Name = "icon_exit";
            icon_exit.Size = new Size(38, 39);
            icon_exit.TabIndex = 51;
            icon_exit.UseVisualStyleBackColor = true;
            icon_exit.Click += icon_exit_Click;
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 521);
            Controls.Add(icon_exit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl_dept_id);
            Controls.Add(cbx_topics);
            Controls.Add(txt_duration);
            Controls.Add(txt_crs_name);
            Controls.Add(btn_delete_dept);
            Controls.Add(btn_update_dept);
            Controls.Add(btn_add_dept);
            Controls.Add(dgv_course);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CourseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CourseForm";
            Load += CourseForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_course).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Label lbl_dept_id;
        private ComboBox cbx_topics;
        private TextBox txt_duration;
        private TextBox txt_crs_name;
        private Button btn_delete_dept;
        private Button btn_update_dept;
        private Button btn_add_dept;
        private DataGridView dgv_course;
        private FontAwesome.Sharp.IconButton icon_exit;
    }
}