namespace ExaminationApp
{
    partial class DepartmentForm
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
            dgv_depts = new DataGridView();
            btn_add_dept = new Button();
            btn_update_dept = new Button();
            btn_delete_dept = new Button();
            txt_dept_name = new TextBox();
            label2 = new Label();
            icon_exit = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgv_depts).BeginInit();
            SuspendLayout();
            // 
            // dgv_depts
            // 
            dgv_depts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_depts.Location = new Point(100, 220);
            dgv_depts.Name = "dgv_depts";
            dgv_depts.RowHeadersWidth = 51;
            dgv_depts.RowTemplate.Height = 29;
            dgv_depts.Size = new Size(316, 197);
            dgv_depts.TabIndex = 0;
            dgv_depts.RowHeaderMouseDoubleClick += dgv_depts_RowHeaderMouseDoubleClick;
            // 
            // btn_add_dept
            // 
            btn_add_dept.BackColor = Color.YellowGreen;
            btn_add_dept.FlatAppearance.BorderSize = 0;
            btn_add_dept.FlatStyle = FlatStyle.Flat;
            btn_add_dept.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add_dept.ForeColor = SystemColors.ButtonHighlight;
            btn_add_dept.Location = new Point(53, 149);
            btn_add_dept.Name = "btn_add_dept";
            btn_add_dept.Size = new Size(106, 48);
            btn_add_dept.TabIndex = 1;
            btn_add_dept.Text = "Add";
            btn_add_dept.UseVisualStyleBackColor = false;
            btn_add_dept.Click += btn_add_dept_Click;
            // 
            // btn_update_dept
            // 
            btn_update_dept.BackColor = Color.Gold;
            btn_update_dept.FlatAppearance.BorderSize = 0;
            btn_update_dept.FlatStyle = FlatStyle.Flat;
            btn_update_dept.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update_dept.Location = new Point(191, 149);
            btn_update_dept.Name = "btn_update_dept";
            btn_update_dept.Size = new Size(106, 48);
            btn_update_dept.TabIndex = 1;
            btn_update_dept.Text = "Update";
            btn_update_dept.UseVisualStyleBackColor = false;
            btn_update_dept.Click += btn_update_dept_Click;
            // 
            // btn_delete_dept
            // 
            btn_delete_dept.BackColor = Color.Red;
            btn_delete_dept.FlatAppearance.BorderSize = 0;
            btn_delete_dept.FlatStyle = FlatStyle.Flat;
            btn_delete_dept.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete_dept.ForeColor = Color.White;
            btn_delete_dept.Location = new Point(330, 149);
            btn_delete_dept.Name = "btn_delete_dept";
            btn_delete_dept.Size = new Size(106, 48);
            btn_delete_dept.TabIndex = 1;
            btn_delete_dept.Text = "Delete";
            btn_delete_dept.UseVisualStyleBackColor = false;
            btn_delete_dept.Click += btn_delete_dept_Click;
            // 
            // txt_dept_name
            // 
            txt_dept_name.Location = new Point(140, 95);
            txt_dept_name.Name = "txt_dept_name";
            txt_dept_name.Size = new Size(225, 27);
            txt_dept_name.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(160, 47);
            label2.Name = "label2";
            label2.Size = new Size(189, 28);
            label2.TabIndex = 7;
            label2.Text = "Department Name";
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
            icon_exit.Location = new Point(463, 12);
            icon_exit.Name = "icon_exit";
            icon_exit.Size = new Size(44, 29);
            icon_exit.TabIndex = 9;
            icon_exit.UseVisualStyleBackColor = true;
            icon_exit.Click += icon_exit_Click;
            // 
            // DepartmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 464);
            Controls.Add(icon_exit);
            Controls.Add(label2);
            Controls.Add(txt_dept_name);
            Controls.Add(btn_delete_dept);
            Controls.Add(btn_update_dept);
            Controls.Add(btn_add_dept);
            Controls.Add(dgv_depts);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DepartmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Department";
            Load += DepartmentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_depts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_depts;
        private Button btn_add_dept;
        private Button btn_update_dept;
        private Button btn_delete_dept;
        private TextBox txt_dept_name;
        private Label label2;
        private FontAwesome.Sharp.IconButton icon_exit;
    }
}