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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_std_age = new System.Windows.Forms.TextBox();
            this.lbl_std_id = new System.Windows.Forms.Label();
            this.txt_std_id = new System.Windows.Forms.TextBox();
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
            this.btn_back_home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_instructors)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(399, -51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Age";
            // 
            // txt_std_age
            // 
            this.txt_std_age.Location = new System.Drawing.Point(499, -51);
            this.txt_std_age.Name = "txt_std_age";
            this.txt_std_age.Size = new System.Drawing.Size(207, 27);
            this.txt_std_age.TabIndex = 29;
            // 
            // lbl_std_id
            // 
            this.lbl_std_id.AutoSize = true;
            this.lbl_std_id.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_std_id.Location = new System.Drawing.Point(16, -55);
            this.lbl_std_id.Name = "lbl_std_id";
            this.lbl_std_id.Size = new System.Drawing.Size(25, 20);
            this.lbl_std_id.TabIndex = 24;
            this.lbl_std_id.Text = "ID";
            this.lbl_std_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_std_id
            // 
            this.txt_std_id.Location = new System.Drawing.Point(101, -58);
            this.txt_std_id.Name = "txt_std_id";
            this.txt_std_id.Size = new System.Drawing.Size(267, 27);
            this.txt_std_id.TabIndex = 21;
            // 
            // dgv_instructors
            // 
            this.dgv_instructors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_instructors.Location = new System.Drawing.Point(44, 259);
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
            this.btn_delete_ins.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delete_ins.ForeColor = System.Drawing.Color.White;
            this.btn_delete_ins.Location = new System.Drawing.Point(474, 193);
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
            this.btn_update_ins.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_update_ins.Location = new System.Drawing.Point(303, 193);
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
            this.btn_add_ins.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add_ins.ForeColor = System.Drawing.Color.White;
            this.btn_add_ins.Location = new System.Drawing.Point(149, 193);
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
            this.cb_depts.Location = new System.Drawing.Point(534, 36);
            this.cb_depts.Name = "cb_depts";
            this.cb_depts.Size = new System.Drawing.Size(207, 28);
            this.cb_depts.TabIndex = 37;
            // 
            // lbl_std_lname
            // 
            this.lbl_std_lname.AutoSize = true;
            this.lbl_std_lname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_std_lname.Location = new System.Drawing.Point(44, 40);
            this.lbl_std_lname.Name = "lbl_std_lname";
            this.lbl_std_lname.Size = new System.Drawing.Size(51, 20);
            this.lbl_std_lname.TabIndex = 26;
            this.lbl_std_lname.Text = "Name";
            this.lbl_std_lname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_insName
            // 
            this.txt_insName.Location = new System.Drawing.Point(136, 37);
            this.txt_insName.Name = "txt_insName";
            this.txt_insName.Size = new System.Drawing.Size(267, 27);
            this.txt_insName.TabIndex = 23;
            // 
            // txt_ins_email
            // 
            this.txt_ins_email.Location = new System.Drawing.Point(136, 89);
            this.txt_ins_email.Name = "txt_ins_email";
            this.txt_ins_email.Size = new System.Drawing.Size(605, 27);
            this.txt_ins_email.TabIndex = 27;
            // 
            // lbl_std_email
            // 
            this.lbl_std_email.AutoSize = true;
            this.lbl_std_email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_std_email.Location = new System.Drawing.Point(44, 96);
            this.lbl_std_email.Name = "lbl_std_email";
            this.lbl_std_email.Size = new System.Drawing.Size(47, 20);
            this.lbl_std_email.TabIndex = 30;
            this.lbl_std_email.Text = "Email";
            this.lbl_std_email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_ins_password
            // 
            this.txt_ins_password.Location = new System.Drawing.Point(136, 132);
            this.txt_ins_password.Name = "txt_ins_password";
            this.txt_ins_password.Size = new System.Drawing.Size(605, 27);
            this.txt_ins_password.TabIndex = 33;
            // 
            // lbl_std_password
            // 
            this.lbl_std_password.AutoSize = true;
            this.lbl_std_password.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_std_password.Location = new System.Drawing.Point(44, 139);
            this.lbl_std_password.Name = "lbl_std_password";
            this.lbl_std_password.Size = new System.Drawing.Size(76, 20);
            this.lbl_std_password.TabIndex = 34;
            this.lbl_std_password.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(434, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Department";
            // 
            // btn_back_home
            // 
            this.btn_back_home.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_back_home.FlatAppearance.BorderSize = 0;
            this.btn_back_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back_home.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_back_home.Location = new System.Drawing.Point(207, 545);
            this.btn_back_home.Name = "btn_back_home";
            this.btn_back_home.Size = new System.Drawing.Size(367, 47);
            this.btn_back_home.TabIndex = 38;
            this.btn_back_home.Text = "Back To Home";
            this.btn_back_home.UseVisualStyleBackColor = false;
            this.btn_back_home.Click += new System.EventHandler(this.btn_back_home_Click);
            // 
            // InstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 604);
            this.Controls.Add(this.btn_back_home);
            this.Controls.Add(this.cb_depts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_std_password);
            this.Controls.Add(this.txt_ins_password);
            this.Controls.Add(this.lbl_std_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ins_email);
            this.Controls.Add(this.txt_std_age);
            this.Controls.Add(this.lbl_std_lname);
            this.Controls.Add(this.lbl_std_id);
            this.Controls.Add(this.txt_insName);
            this.Controls.Add(this.txt_std_id);
            this.Controls.Add(this.dgv_instructors);
            this.Controls.Add(this.btn_delete_ins);
            this.Controls.Add(this.btn_update_ins);
            this.Controls.Add(this.btn_add_ins);
            this.Name = "InstructorForm";
            this.Text = "Instructor";
            this.Load += new System.EventHandler(this.Instructor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_instructors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private TextBox txt_std_age;
        private Label lbl_std_id;
        private TextBox txt_std_id;
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
        private Button btn_back_home;
    }
}