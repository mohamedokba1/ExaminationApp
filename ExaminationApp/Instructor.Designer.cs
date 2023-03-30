namespace ExaminationApp
{
    partial class InstructorForm
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
            dgv_instructors = new DataGridView();
            btn_delete_ins = new Button();
            btn_update_ins = new Button();
            btn_add_ins = new Button();
            cb_depts = new ComboBox();
            lbl_std_lname = new Label();
            txt_insName = new TextBox();
            txt_ins_email = new TextBox();
            lbl_std_email = new Label();
            txt_ins_password = new TextBox();
            lbl_std_password = new Label();
            label1 = new Label();
            icon_exit = new FontAwesome.Sharp.IconButton();
            chk_ins_user = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgv_instructors).BeginInit();
            SuspendLayout();
            // 
            // dgv_instructors
            // 
            dgv_instructors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_instructors.Location = new Point(28, 302);
            dgv_instructors.Name = "dgv_instructors";
            dgv_instructors.RowHeadersWidth = 51;
            dgv_instructors.RowTemplate.Height = 29;
            dgv_instructors.Size = new Size(704, 271);
            dgv_instructors.TabIndex = 20;
            dgv_instructors.RowHeaderMouseDoubleClick += dgv_instructors_RowHeaderMouseDoubleClick;
            // 
            // btn_delete_ins
            // 
            btn_delete_ins.BackColor = Color.Red;
            btn_delete_ins.FlatAppearance.BorderSize = 0;
            btn_delete_ins.FlatStyle = FlatStyle.Flat;
            btn_delete_ins.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete_ins.ForeColor = Color.White;
            btn_delete_ins.Location = new Point(563, 236);
            btn_delete_ins.Name = "btn_delete_ins";
            btn_delete_ins.Size = new Size(100, 46);
            btn_delete_ins.TabIndex = 18;
            btn_delete_ins.Text = "Delete";
            btn_delete_ins.UseVisualStyleBackColor = false;
            btn_delete_ins.Click += btn_delete_ins_Click;
            // 
            // btn_update_ins
            // 
            btn_update_ins.BackColor = Color.Yellow;
            btn_update_ins.FlatAppearance.BorderColor = Color.Yellow;
            btn_update_ins.FlatAppearance.BorderSize = 0;
            btn_update_ins.FlatStyle = FlatStyle.Flat;
            btn_update_ins.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update_ins.Location = new Point(418, 236);
            btn_update_ins.Name = "btn_update_ins";
            btn_update_ins.Size = new Size(100, 46);
            btn_update_ins.TabIndex = 19;
            btn_update_ins.Text = "Update";
            btn_update_ins.UseVisualStyleBackColor = false;
            btn_update_ins.Click += btn_update_ins_Click;
            // 
            // btn_add_ins
            // 
            btn_add_ins.BackColor = Color.FromArgb(0, 192, 0);
            btn_add_ins.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btn_add_ins.FlatAppearance.BorderSize = 0;
            btn_add_ins.FlatStyle = FlatStyle.Flat;
            btn_add_ins.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add_ins.ForeColor = Color.White;
            btn_add_ins.Location = new Point(254, 236);
            btn_add_ins.Name = "btn_add_ins";
            btn_add_ins.Size = new Size(100, 46);
            btn_add_ins.TabIndex = 17;
            btn_add_ins.Text = "Add ";
            btn_add_ins.UseVisualStyleBackColor = false;
            btn_add_ins.Click += btn_add_ins_Click;
            // 
            // cb_depts
            // 
            cb_depts.FormattingEnabled = true;
            cb_depts.Location = new Point(518, 79);
            cb_depts.Name = "cb_depts";
            cb_depts.Size = new Size(207, 28);
            cb_depts.TabIndex = 37;
            // 
            // lbl_std_lname
            // 
            lbl_std_lname.AutoSize = true;
            lbl_std_lname.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_std_lname.Location = new Point(28, 83);
            lbl_std_lname.Name = "lbl_std_lname";
            lbl_std_lname.Size = new Size(51, 20);
            lbl_std_lname.TabIndex = 26;
            lbl_std_lname.Text = "Name";
            lbl_std_lname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_insName
            // 
            txt_insName.Location = new Point(120, 80);
            txt_insName.Name = "txt_insName";
            txt_insName.Size = new Size(267, 27);
            txt_insName.TabIndex = 23;
            // 
            // txt_ins_email
            // 
            txt_ins_email.Location = new Point(120, 132);
            txt_ins_email.Name = "txt_ins_email";
            txt_ins_email.Size = new Size(605, 27);
            txt_ins_email.TabIndex = 27;
            // 
            // lbl_std_email
            // 
            lbl_std_email.AutoSize = true;
            lbl_std_email.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_std_email.Location = new Point(28, 139);
            lbl_std_email.Name = "lbl_std_email";
            lbl_std_email.Size = new Size(47, 20);
            lbl_std_email.TabIndex = 30;
            lbl_std_email.Text = "Email";
            lbl_std_email.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_ins_password
            // 
            txt_ins_password.Location = new Point(120, 175);
            txt_ins_password.Name = "txt_ins_password";
            txt_ins_password.Size = new Size(605, 27);
            txt_ins_password.TabIndex = 33;
            // 
            // lbl_std_password
            // 
            lbl_std_password.AutoSize = true;
            lbl_std_password.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_std_password.Location = new Point(28, 182);
            lbl_std_password.Name = "lbl_std_password";
            lbl_std_password.Size = new Size(76, 20);
            lbl_std_password.TabIndex = 34;
            lbl_std_password.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(418, 82);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 36;
            label1.Text = "Department";
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
            icon_exit.Location = new Point(697, 12);
            icon_exit.Name = "icon_exit";
            icon_exit.Size = new Size(44, 32);
            icon_exit.TabIndex = 41;
            icon_exit.UseVisualStyleBackColor = true;
            icon_exit.Click += icon_exit_Click;
            // 
            // chk_ins_user
            // 
            chk_ins_user.AutoSize = true;
            chk_ins_user.Location = new Point(28, 249);
            chk_ins_user.Name = "chk_ins_user";
            chk_ins_user.Size = new Size(194, 24);
            chk_ins_user.TabIndex = 42;
            chk_ins_user.Text = "Add as an instructor user";
            chk_ins_user.UseVisualStyleBackColor = true;
            // 
            // InstructorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 595);
            Controls.Add(chk_ins_user);
            Controls.Add(icon_exit);
            Controls.Add(cb_depts);
            Controls.Add(label1);
            Controls.Add(lbl_std_password);
            Controls.Add(txt_ins_password);
            Controls.Add(lbl_std_email);
            Controls.Add(txt_ins_email);
            Controls.Add(lbl_std_lname);
            Controls.Add(txt_insName);
            Controls.Add(dgv_instructors);
            Controls.Add(btn_delete_ins);
            Controls.Add(btn_update_ins);
            Controls.Add(btn_add_ins);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InstructorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Instructor";
            Load += Instructor_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_instructors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgv_instructors;
        private Button btn_delete_ins;
        private Button btn_update_ins;
        private Button btn_add_ins;
        private ComboBox cb_depts;
        private Label lbl_std_lname;
        private TextBox txt_insName;
        private TextBox txt_ins_email;
        private Label lbl_std_email;
        private TextBox txt_ins_password;
        private Label lbl_std_password;
        private Label label1;
        private FontAwesome.Sharp.IconButton icon_exit;
        private CheckBox chk_ins_user;
    }
}