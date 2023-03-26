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
            this.dgv_instructors = new System.Windows.Forms.DataGridView();
            this.btn_delete_ins = new System.Windows.Forms.Button();
            this.btn_update_ins = new System.Windows.Forms.Button();
            this.btn_add_ins = new System.Windows.Forms.Button();
            this.cb_depts = new System.Windows.Forms.ComboBox();
            this.lbl_std_lname = new System.Windows.Forms.Label();
            this.txt_insName = new System.Windows.Forms.TextBox();
            this.txt_ins_email = new System.Windows.Forms.TextBox();
            this.lbl_std_email = new System.Windows.Forms.Label();
            this.txt_ins_password = new System.Windows.Forms.TextBox();
            this.lbl_std_password = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.icon_exit = new FontAwesome.Sharp.IconButton();
            this.chk_ins_user = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_instructors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_instructors
            // 
            this.dgv_instructors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_instructors.Location = new System.Drawing.Point(28, 302);
            this.dgv_instructors.Name = "dgv_instructors";
            this.dgv_instructors.RowHeadersWidth = 51;
            this.dgv_instructors.RowTemplate.Height = 29;
            this.dgv_instructors.Size = new System.Drawing.Size(704, 271);
            this.dgv_instructors.TabIndex = 20;
            this.dgv_instructors.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_instructors_RowHeaderMouseDoubleClick);
            // 
            // btn_delete_ins
            // 
            this.btn_delete_ins.BackColor = System.Drawing.Color.Red;
            this.btn_delete_ins.FlatAppearance.BorderSize = 0;
            this.btn_delete_ins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_ins.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delete_ins.ForeColor = System.Drawing.Color.White;
            this.btn_delete_ins.Location = new System.Drawing.Point(563, 236);
            this.btn_delete_ins.Name = "btn_delete_ins";
            this.btn_delete_ins.Size = new System.Drawing.Size(100, 46);
            this.btn_delete_ins.TabIndex = 18;
            this.btn_delete_ins.Text = "Delete";
            this.btn_delete_ins.UseVisualStyleBackColor = false;
            this.btn_delete_ins.Click += new System.EventHandler(this.btn_delete_ins_Click);
            // 
            // btn_update_ins
            // 
            this.btn_update_ins.BackColor = System.Drawing.Color.Yellow;
            this.btn_update_ins.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btn_update_ins.FlatAppearance.BorderSize = 0;
            this.btn_update_ins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_ins.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_update_ins.Location = new System.Drawing.Point(418, 236);
            this.btn_update_ins.Name = "btn_update_ins";
            this.btn_update_ins.Size = new System.Drawing.Size(100, 46);
            this.btn_update_ins.TabIndex = 19;
            this.btn_update_ins.Text = "Update";
            this.btn_update_ins.UseVisualStyleBackColor = false;
            this.btn_update_ins.Click += new System.EventHandler(this.btn_update_ins_Click);
            // 
            // btn_add_ins
            // 
            this.btn_add_ins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_add_ins.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_add_ins.FlatAppearance.BorderSize = 0;
            this.btn_add_ins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_ins.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add_ins.ForeColor = System.Drawing.Color.White;
            this.btn_add_ins.Location = new System.Drawing.Point(254, 236);
            this.btn_add_ins.Name = "btn_add_ins";
            this.btn_add_ins.Size = new System.Drawing.Size(100, 46);
            this.btn_add_ins.TabIndex = 17;
            this.btn_add_ins.Text = "Add ";
            this.btn_add_ins.UseVisualStyleBackColor = false;
            this.btn_add_ins.Click += new System.EventHandler(this.btn_add_ins_Click);
            // 
            // cb_depts
            // 
            this.cb_depts.FormattingEnabled = true;
            this.cb_depts.Location = new System.Drawing.Point(518, 79);
            this.cb_depts.Name = "cb_depts";
            this.cb_depts.Size = new System.Drawing.Size(207, 28);
            this.cb_depts.TabIndex = 37;
            // 
            // lbl_std_lname
            // 
            this.lbl_std_lname.AutoSize = true;
            this.lbl_std_lname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_std_lname.Location = new System.Drawing.Point(28, 83);
            this.lbl_std_lname.Name = "lbl_std_lname";
            this.lbl_std_lname.Size = new System.Drawing.Size(51, 20);
            this.lbl_std_lname.TabIndex = 26;
            this.lbl_std_lname.Text = "Name";
            this.lbl_std_lname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_insName
            // 
            this.txt_insName.Location = new System.Drawing.Point(120, 80);
            this.txt_insName.Name = "txt_insName";
            this.txt_insName.Size = new System.Drawing.Size(267, 27);
            this.txt_insName.TabIndex = 23;
            // 
            // txt_ins_email
            // 
            this.txt_ins_email.Location = new System.Drawing.Point(120, 132);
            this.txt_ins_email.Name = "txt_ins_email";
            this.txt_ins_email.Size = new System.Drawing.Size(605, 27);
            this.txt_ins_email.TabIndex = 27;
            // 
            // lbl_std_email
            // 
            this.lbl_std_email.AutoSize = true;
            this.lbl_std_email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_std_email.Location = new System.Drawing.Point(28, 139);
            this.lbl_std_email.Name = "lbl_std_email";
            this.lbl_std_email.Size = new System.Drawing.Size(47, 20);
            this.lbl_std_email.TabIndex = 30;
            this.lbl_std_email.Text = "Email";
            this.lbl_std_email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_ins_password
            // 
            this.txt_ins_password.Location = new System.Drawing.Point(120, 175);
            this.txt_ins_password.Name = "txt_ins_password";
            this.txt_ins_password.Size = new System.Drawing.Size(605, 27);
            this.txt_ins_password.TabIndex = 33;
            // 
            // lbl_std_password
            // 
            this.lbl_std_password.AutoSize = true;
            this.lbl_std_password.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_std_password.Location = new System.Drawing.Point(28, 182);
            this.lbl_std_password.Name = "lbl_std_password";
            this.lbl_std_password.Size = new System.Drawing.Size(76, 20);
            this.lbl_std_password.TabIndex = 34;
            this.lbl_std_password.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(418, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Department";
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
            this.icon_exit.Location = new System.Drawing.Point(697, 12);
            this.icon_exit.Name = "icon_exit";
            this.icon_exit.Size = new System.Drawing.Size(44, 32);
            this.icon_exit.TabIndex = 41;
            this.icon_exit.UseVisualStyleBackColor = true;
            this.icon_exit.Click += new System.EventHandler(this.icon_exit_Click);
            // 
            // chk_ins_user
            // 
            this.chk_ins_user.AutoSize = true;
            this.chk_ins_user.Location = new System.Drawing.Point(28, 249);
            this.chk_ins_user.Name = "chk_ins_user";
            this.chk_ins_user.Size = new System.Drawing.Size(194, 24);
            this.chk_ins_user.TabIndex = 42;
            this.chk_ins_user.Text = "Add as an instructor user";
            this.chk_ins_user.UseVisualStyleBackColor = true;
            // 
            // InstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 595);
            this.Controls.Add(this.chk_ins_user);
            this.Controls.Add(this.icon_exit);
            this.Controls.Add(this.cb_depts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_std_password);
            this.Controls.Add(this.txt_ins_password);
            this.Controls.Add(this.lbl_std_email);
            this.Controls.Add(this.txt_ins_email);
            this.Controls.Add(this.lbl_std_lname);
            this.Controls.Add(this.txt_insName);
            this.Controls.Add(this.dgv_instructors);
            this.Controls.Add(this.btn_delete_ins);
            this.Controls.Add(this.btn_update_ins);
            this.Controls.Add(this.btn_add_ins);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InstructorForm";
            this.Text = "Instructor";
            this.Load += new System.EventHandler(this.Instructor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_instructors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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