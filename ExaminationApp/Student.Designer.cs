namespace ExaminationApp
{
    partial class StudentForm
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
            this.btn_add_student = new System.Windows.Forms.Button();
            this.btn_update_student = new System.Windows.Forms.Button();
            this.btn_delete_student = new System.Windows.Forms.Button();
            this.dgv_students = new System.Windows.Forms.DataGridView();
            this.txt_std_fname = new System.Windows.Forms.TextBox();
            this.lbl_std_fname = new System.Windows.Forms.Label();
            this.txt_std_lname = new System.Windows.Forms.TextBox();
            this.lbl_std_lname = new System.Windows.Forms.Label();
            this.lbl_std_email = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_std_email = new System.Windows.Forms.TextBox();
            this.txt_std_address = new System.Windows.Forms.TextBox();
            this.txt_std_age = new System.Windows.Forms.TextBox();
            this.lbl_std_password = new System.Windows.Forms.Label();
            this.txt_std_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_depts = new System.Windows.Forms.ComboBox();
            this.chk_std_user = new System.Windows.Forms.CheckBox();
            this.icon_exit = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_students)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add_student
            // 
            this.btn_add_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_add_student.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_add_student.FlatAppearance.BorderSize = 0;
            this.btn_add_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_student.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add_student.ForeColor = System.Drawing.Color.White;
            this.btn_add_student.Location = new System.Drawing.Point(255, 311);
            this.btn_add_student.Name = "btn_add_student";
            this.btn_add_student.Size = new System.Drawing.Size(100, 46);
            this.btn_add_student.TabIndex = 0;
            this.btn_add_student.Text = "Add ";
            this.btn_add_student.UseVisualStyleBackColor = false;
            this.btn_add_student.Click += new System.EventHandler(this.btn_add_student_Click);
            // 
            // btn_update_student
            // 
            this.btn_update_student.BackColor = System.Drawing.Color.Yellow;
            this.btn_update_student.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btn_update_student.FlatAppearance.BorderSize = 0;
            this.btn_update_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_student.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_update_student.Location = new System.Drawing.Point(417, 311);
            this.btn_update_student.Name = "btn_update_student";
            this.btn_update_student.Size = new System.Drawing.Size(100, 46);
            this.btn_update_student.TabIndex = 0;
            this.btn_update_student.Text = "Update";
            this.btn_update_student.UseVisualStyleBackColor = false;
            this.btn_update_student.Click += new System.EventHandler(this.btn_update_student_Click);
            // 
            // btn_delete_student
            // 
            this.btn_delete_student.BackColor = System.Drawing.Color.Red;
            this.btn_delete_student.FlatAppearance.BorderSize = 0;
            this.btn_delete_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_student.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delete_student.ForeColor = System.Drawing.Color.White;
            this.btn_delete_student.Location = new System.Drawing.Point(571, 311);
            this.btn_delete_student.Name = "btn_delete_student";
            this.btn_delete_student.Size = new System.Drawing.Size(100, 46);
            this.btn_delete_student.TabIndex = 0;
            this.btn_delete_student.Text = "Delete";
            this.btn_delete_student.UseVisualStyleBackColor = false;
            this.btn_delete_student.Click += new System.EventHandler(this.btn_delete_student_Click);
            // 
            // dgv_students
            // 
            this.dgv_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_students.Location = new System.Drawing.Point(24, 376);
            this.dgv_students.Name = "dgv_students";
            this.dgv_students.RowHeadersWidth = 51;
            this.dgv_students.RowTemplate.Height = 29;
            this.dgv_students.Size = new System.Drawing.Size(699, 268);
            this.dgv_students.TabIndex = 1;
            this.dgv_students.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_students_RowHeaderMouseDoubleClick);
            // 
            // txt_std_fname
            // 
            this.txt_std_fname.Location = new System.Drawing.Point(116, 84);
            this.txt_std_fname.Name = "txt_std_fname";
            this.txt_std_fname.Size = new System.Drawing.Size(267, 27);
            this.txt_std_fname.TabIndex = 3;
            // 
            // lbl_std_fname
            // 
            this.lbl_std_fname.AutoSize = true;
            this.lbl_std_fname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_std_fname.Location = new System.Drawing.Point(24, 84);
            this.lbl_std_fname.Name = "lbl_std_fname";
            this.lbl_std_fname.Size = new System.Drawing.Size(86, 20);
            this.lbl_std_fname.TabIndex = 4;
            this.lbl_std_fname.Text = "First Name";
            // 
            // txt_std_lname
            // 
            this.txt_std_lname.Location = new System.Drawing.Point(116, 130);
            this.txt_std_lname.Name = "txt_std_lname";
            this.txt_std_lname.Size = new System.Drawing.Size(267, 27);
            this.txt_std_lname.TabIndex = 3;
            // 
            // lbl_std_lname
            // 
            this.lbl_std_lname.AutoSize = true;
            this.lbl_std_lname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_std_lname.Location = new System.Drawing.Point(24, 133);
            this.lbl_std_lname.Name = "lbl_std_lname";
            this.lbl_std_lname.Size = new System.Drawing.Size(84, 20);
            this.lbl_std_lname.TabIndex = 4;
            this.lbl_std_lname.Text = "Last Name";
            this.lbl_std_lname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_std_email
            // 
            this.lbl_std_email.AutoSize = true;
            this.lbl_std_email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_std_email.Location = new System.Drawing.Point(24, 229);
            this.lbl_std_email.Name = "lbl_std_email";
            this.lbl_std_email.Size = new System.Drawing.Size(47, 20);
            this.lbl_std_email.TabIndex = 8;
            this.lbl_std_email.Text = "Email";
            this.lbl_std_email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(416, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Age";
            // 
            // txt_std_email
            // 
            this.txt_std_email.Location = new System.Drawing.Point(109, 222);
            this.txt_std_email.Name = "txt_std_email";
            this.txt_std_email.Size = new System.Drawing.Size(605, 27);
            this.txt_std_email.TabIndex = 5;
            // 
            // txt_std_address
            // 
            this.txt_std_address.Location = new System.Drawing.Point(116, 172);
            this.txt_std_address.Name = "txt_std_address";
            this.txt_std_address.Size = new System.Drawing.Size(267, 27);
            this.txt_std_address.TabIndex = 6;
            // 
            // txt_std_age
            // 
            this.txt_std_age.Location = new System.Drawing.Point(507, 111);
            this.txt_std_age.Name = "txt_std_age";
            this.txt_std_age.Size = new System.Drawing.Size(207, 27);
            this.txt_std_age.TabIndex = 7;
            // 
            // lbl_std_password
            // 
            this.lbl_std_password.AutoSize = true;
            this.lbl_std_password.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_std_password.Location = new System.Drawing.Point(17, 272);
            this.lbl_std_password.Name = "lbl_std_password";
            this.lbl_std_password.Size = new System.Drawing.Size(76, 20);
            this.lbl_std_password.TabIndex = 12;
            this.lbl_std_password.Text = "Password";
            // 
            // txt_std_password
            // 
            this.txt_std_password.Location = new System.Drawing.Point(109, 265);
            this.txt_std_password.Name = "txt_std_password";
            this.txt_std_password.Size = new System.Drawing.Size(605, 27);
            this.txt_std_password.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(407, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Department";
            // 
            // cb_depts
            // 
            this.cb_depts.FormattingEnabled = true;
            this.cb_depts.Location = new System.Drawing.Point(507, 169);
            this.cb_depts.Name = "cb_depts";
            this.cb_depts.Size = new System.Drawing.Size(207, 28);
            this.cb_depts.TabIndex = 16;
            // 
            // chk_std_user
            // 
            this.chk_std_user.AutoSize = true;
            this.chk_std_user.Location = new System.Drawing.Point(27, 333);
            this.chk_std_user.Name = "chk_std_user";
            this.chk_std_user.Size = new System.Drawing.Size(173, 24);
            this.chk_std_user.TabIndex = 41;
            this.chk_std_user.Text = "Add as a student user";
            this.chk_std_user.UseVisualStyleBackColor = true;
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
            this.icon_exit.Location = new System.Drawing.Point(701, 12);
            this.icon_exit.Name = "icon_exit";
            this.icon_exit.Size = new System.Drawing.Size(44, 41);
            this.icon_exit.TabIndex = 48;
            this.icon_exit.UseVisualStyleBackColor = false;
            this.icon_exit.Click += new System.EventHandler(this.icon_exit_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 680);
            this.Controls.Add(this.icon_exit);
            this.Controls.Add(this.chk_std_user);
            this.Controls.Add(this.cb_depts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_std_password);
            this.Controls.Add(this.txt_std_password);
            this.Controls.Add(this.lbl_std_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_std_email);
            this.Controls.Add(this.txt_std_address);
            this.Controls.Add(this.txt_std_age);
            this.Controls.Add(this.lbl_std_lname);
            this.Controls.Add(this.lbl_std_fname);
            this.Controls.Add(this.txt_std_lname);
            this.Controls.Add(this.txt_std_fname);
            this.Controls.Add(this.dgv_students);
            this.Controls.Add(this.btn_delete_student);
            this.Controls.Add(this.btn_update_student);
            this.Controls.Add(this.btn_add_student);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_students)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_add_student;
        private Button btn_update_student;
        private Button btn_delete_student;
        private DataGridView dgv_students;
        private TextBox txt_std_fname;
        private Label lbl_std_fname;
        private TextBox txt_std_lname;
        private Label lbl_std_lname;
        private Label lbl_std_email;
        private Label label2;
        private Label label3;
        private TextBox txt_std_email;
        private TextBox txt_std_address;
        private TextBox txt_std_age;
        private Label lbl_std_password;
        private TextBox txt_std_password;
        private Label label1;
        private ComboBox cb_depts;
        private CheckBox chk_std_user;
        private FontAwesome.Sharp.IconButton icon_exit;
    }
}