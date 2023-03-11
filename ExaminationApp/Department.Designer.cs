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
            this.dgv_depts = new System.Windows.Forms.DataGridView();
            this.btn_add_dept = new System.Windows.Forms.Button();
            this.btn_update_dept = new System.Windows.Forms.Button();
            this.btn_delete_dept = new System.Windows.Forms.Button();
            this.txt_dept_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_back_home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_depts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_depts
            // 
            this.dgv_depts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_depts.Location = new System.Drawing.Point(71, 217);
            this.dgv_depts.Name = "dgv_depts";
            this.dgv_depts.RowHeadersWidth = 51;
            this.dgv_depts.RowTemplate.Height = 29;
            this.dgv_depts.Size = new System.Drawing.Size(324, 183);
            this.dgv_depts.TabIndex = 0;
            this.dgv_depts.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_depts_RowHeaderMouseDoubleClick);
            // 
            // btn_add_dept
            // 
            this.btn_add_dept.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_add_dept.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add_dept.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add_dept.Location = new System.Drawing.Point(57, 151);
            this.btn_add_dept.Name = "btn_add_dept";
            this.btn_add_dept.Size = new System.Drawing.Size(106, 48);
            this.btn_add_dept.TabIndex = 1;
            this.btn_add_dept.Text = "Add";
            this.btn_add_dept.UseVisualStyleBackColor = false;
            this.btn_add_dept.Click += new System.EventHandler(this.btn_add_dept_Click);
            // 
            // btn_update_dept
            // 
            this.btn_update_dept.BackColor = System.Drawing.Color.Gold;
            this.btn_update_dept.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_update_dept.Location = new System.Drawing.Point(188, 151);
            this.btn_update_dept.Name = "btn_update_dept";
            this.btn_update_dept.Size = new System.Drawing.Size(106, 48);
            this.btn_update_dept.TabIndex = 1;
            this.btn_update_dept.Text = "Update";
            this.btn_update_dept.UseVisualStyleBackColor = false;
            this.btn_update_dept.Click += new System.EventHandler(this.btn_update_dept_Click);
            // 
            // btn_delete_dept
            // 
            this.btn_delete_dept.BackColor = System.Drawing.Color.Red;
            this.btn_delete_dept.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delete_dept.ForeColor = System.Drawing.Color.White;
            this.btn_delete_dept.Location = new System.Drawing.Point(326, 151);
            this.btn_delete_dept.Name = "btn_delete_dept";
            this.btn_delete_dept.Size = new System.Drawing.Size(106, 48);
            this.btn_delete_dept.TabIndex = 1;
            this.btn_delete_dept.Text = "Delete";
            this.btn_delete_dept.UseVisualStyleBackColor = false;
            this.btn_delete_dept.Click += new System.EventHandler(this.btn_delete_dept_Click);
            // 
            // txt_dept_name
            // 
            this.txt_dept_name.Location = new System.Drawing.Point(131, 88);
            this.txt_dept_name.Name = "txt_dept_name";
            this.txt_dept_name.Size = new System.Drawing.Size(191, 27);
            this.txt_dept_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(131, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Department Name";
            // 
            // btn_back_home
            // 
            this.btn_back_home.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_back_home.FlatAppearance.BorderSize = 0;
            this.btn_back_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back_home.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_back_home.Location = new System.Drawing.Point(71, 416);
            this.btn_back_home.Name = "btn_back_home";
            this.btn_back_home.Size = new System.Drawing.Size(324, 41);
            this.btn_back_home.TabIndex = 40;
            this.btn_back_home.Text = "Back To Home";
            this.btn_back_home.UseVisualStyleBackColor = false;
            this.btn_back_home.Click += new System.EventHandler(this.btn_back_home_Click);
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 469);
            this.Controls.Add(this.btn_back_home);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_dept_name);
            this.Controls.Add(this.btn_delete_dept);
            this.Controls.Add(this.btn_update_dept);
            this.Controls.Add(this.btn_add_dept);
            this.Controls.Add(this.dgv_depts);
            this.Name = "DepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_depts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_depts;
        private Button btn_add_dept;
        private Button btn_update_dept;
        private Button btn_delete_dept;
        private TextBox txt_dept_name;
        private Label label2;
        private Button btn_back_home;
    }
}