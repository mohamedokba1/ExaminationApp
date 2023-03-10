namespace ExaminationApp
{
    partial class Department
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_add_dept = new System.Windows.Forms.Button();
            this.btn_update_dept = new System.Windows.Forms.Button();
            this.btn_delete_dept = new System.Windows.Forms.Button();
            this.txt_dept_id = new System.Windows.Forms.TextBox();
            this.txt_dept_name = new System.Windows.Forms.TextBox();
            this.cbx_departments = new System.Windows.Forms.ComboBox();
            this.lbl_dept_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(444, 178);
            this.dataGridView1.TabIndex = 0;
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
            // 
            // txt_dept_id
            // 
            this.txt_dept_id.Location = new System.Drawing.Point(38, 32);
            this.txt_dept_id.Name = "txt_dept_id";
            this.txt_dept_id.Size = new System.Drawing.Size(96, 27);
            this.txt_dept_id.TabIndex = 2;
            // 
            // txt_dept_name
            // 
            this.txt_dept_name.Location = new System.Drawing.Point(291, 33);
            this.txt_dept_name.Name = "txt_dept_name";
            this.txt_dept_name.Size = new System.Drawing.Size(143, 27);
            this.txt_dept_name.TabIndex = 2;
            // 
            // cbx_departments
            // 
            this.cbx_departments.FormattingEnabled = true;
            this.cbx_departments.Location = new System.Drawing.Point(103, 85);
            this.cbx_departments.Name = "cbx_departments";
            this.cbx_departments.Size = new System.Drawing.Size(264, 28);
            this.cbx_departments.TabIndex = 3;
            // 
            // lbl_dept_id
            // 
            this.lbl_dept_id.AutoSize = true;
            this.lbl_dept_id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_dept_id.Location = new System.Drawing.Point(-1, 29);
            this.lbl_dept_id.Name = "lbl_dept_id";
            this.lbl_dept_id.Size = new System.Drawing.Size(33, 28);
            this.lbl_dept_id.TabIndex = 4;
            this.lbl_dept_id.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(158, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Department";
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_dept_id);
            this.Controls.Add(this.cbx_departments);
            this.Controls.Add(this.txt_dept_name);
            this.Controls.Add(this.txt_dept_id);
            this.Controls.Add(this.btn_delete_dept);
            this.Controls.Add(this.btn_update_dept);
            this.Controls.Add(this.btn_add_dept);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Department";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_add_dept;
        private Button btn_update_dept;
        private Button btn_delete_dept;
        private TextBox txt_dept_id;
        private TextBox txt_dept_name;
        private ComboBox cbx_departments;
        private Label lbl_dept_id;
        private Label label1;
    }
}