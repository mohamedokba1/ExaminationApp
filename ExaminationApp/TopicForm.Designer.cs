namespace ExaminationApp
{
    partial class TopicForm
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
            txt_top_name = new TextBox();
            btn_delete_dept = new Button();
            btn_update_dept = new Button();
            btn_add_dept = new Button();
            dgv_topics = new DataGridView();
            icon_exit = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgv_topics).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(126, 71);
            label2.Name = "label2";
            label2.Size = new Size(124, 28);
            label2.TabIndex = 46;
            label2.Text = "Topic Name";
            // 
            // txt_top_name
            // 
            txt_top_name.Location = new Point(74, 114);
            txt_top_name.Name = "txt_top_name";
            txt_top_name.Size = new Size(244, 27);
            txt_top_name.TabIndex = 45;
            // 
            // btn_delete_dept
            // 
            btn_delete_dept.BackColor = Color.Red;
            btn_delete_dept.FlatAppearance.BorderSize = 0;
            btn_delete_dept.FlatStyle = FlatStyle.Flat;
            btn_delete_dept.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete_dept.ForeColor = Color.White;
            btn_delete_dept.Location = new Point(269, 183);
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
            btn_update_dept.Location = new Point(144, 183);
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
            btn_add_dept.Location = new Point(23, 183);
            btn_add_dept.Name = "btn_add_dept";
            btn_add_dept.Size = new Size(106, 48);
            btn_add_dept.TabIndex = 44;
            btn_add_dept.Text = "Add";
            btn_add_dept.UseVisualStyleBackColor = false;
            btn_add_dept.Click += btn_add_dept_Click;
            // 
            // dgv_topics
            // 
            dgv_topics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_topics.Location = new Point(12, 250);
            dgv_topics.Name = "dgv_topics";
            dgv_topics.RowHeadersWidth = 51;
            dgv_topics.RowTemplate.Height = 29;
            dgv_topics.Size = new Size(376, 183);
            dgv_topics.TabIndex = 41;
            dgv_topics.RowHeaderMouseDoubleClick += dgv_topics_RowHeaderMouseDoubleClick;
            // 
            // icon_exit
            // 
            icon_exit.BackColor = Color.Transparent;
            icon_exit.Cursor = Cursors.Hand;
            icon_exit.FlatAppearance.BorderSize = 0;
            icon_exit.FlatStyle = FlatStyle.Flat;
            icon_exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            icon_exit.IconColor = Color.Red;
            icon_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_exit.IconSize = 35;
            icon_exit.Location = new Point(344, 12);
            icon_exit.Name = "icon_exit";
            icon_exit.Size = new Size(44, 41);
            icon_exit.TabIndex = 47;
            icon_exit.UseVisualStyleBackColor = false;
            icon_exit.Click += icon_exit_Click;
            // 
            // TopicForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 456);
            Controls.Add(icon_exit);
            Controls.Add(label2);
            Controls.Add(txt_top_name);
            Controls.Add(btn_delete_dept);
            Controls.Add(btn_update_dept);
            Controls.Add(btn_add_dept);
            Controls.Add(dgv_topics);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TopicForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TopicForm";
            Load += TopicForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_topics).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txt_top_name;
        private Button btn_delete_dept;
        private Button btn_update_dept;
        private Button btn_add_dept;
        private DataGridView dgv_topics;
        private FontAwesome.Sharp.IconButton icon_exit;
    }
}