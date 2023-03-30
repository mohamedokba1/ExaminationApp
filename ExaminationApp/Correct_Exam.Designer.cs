namespace ExaminationApp
{
    partial class Correct_Exam
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
            cbx_exam_ids = new ComboBox();
            cbx_std_ids = new ComboBox();
            btn_correct = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            label1 = new Label();
            icon_exit = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // cbx_exam_ids
            // 
            cbx_exam_ids.FormattingEnabled = true;
            cbx_exam_ids.Location = new Point(141, 157);
            cbx_exam_ids.Name = "cbx_exam_ids";
            cbx_exam_ids.Size = new Size(266, 28);
            cbx_exam_ids.TabIndex = 7;
            // 
            // cbx_std_ids
            // 
            cbx_std_ids.FormattingEnabled = true;
            cbx_std_ids.Location = new Point(141, 62);
            cbx_std_ids.Name = "cbx_std_ids";
            cbx_std_ids.Size = new Size(266, 28);
            cbx_std_ids.TabIndex = 8;
            cbx_std_ids.SelectedValueChanged += cbx_std_ids_SelectedValueChanged;
            // 
            // btn_correct
            // 
            btn_correct.BackColor = Color.Transparent;
            btn_correct.Cursor = Cursors.Hand;
            btn_correct.FlatAppearance.BorderSize = 0;
            btn_correct.FlatStyle = FlatStyle.Flat;
            btn_correct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_correct.ForeColor = Color.Green;
            btn_correct.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            btn_correct.IconColor = Color.Green;
            btn_correct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_correct.IconSize = 90;
            btn_correct.Location = new Point(200, 258);
            btn_correct.Name = "btn_correct";
            btn_correct.Size = new Size(73, 68);
            btn_correct.TabIndex = 6;
            btn_correct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_correct.UseVisualStyleBackColor = false;
            btn_correct.Click += btn_correct_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 152);
            label2.Name = "label2";
            label2.Size = new Size(98, 30);
            label2.TabIndex = 4;
            label2.Text = "Exam ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 60);
            label1.Name = "label1";
            label1.Size = new Size(94, 30);
            label1.TabIndex = 5;
            label1.Text = "Student";
            // 
            // icon_exit
            // 
            icon_exit.BackColor = Color.Transparent;
            icon_exit.CausesValidation = false;
            icon_exit.FlatAppearance.BorderSize = 0;
            icon_exit.FlatStyle = FlatStyle.Flat;
            icon_exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            icon_exit.IconColor = Color.Red;
            icon_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_exit.IconSize = 35;
            icon_exit.Location = new Point(408, 12);
            icon_exit.Name = "icon_exit";
            icon_exit.Size = new Size(49, 40);
            icon_exit.TabIndex = 4;
            icon_exit.UseVisualStyleBackColor = true;
            icon_exit.Click += icon_exit_Click;
            // 
            // Correct_Exam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(469, 345);
            Controls.Add(icon_exit);
            Controls.Add(cbx_exam_ids);
            Controls.Add(cbx_std_ids);
            Controls.Add(btn_correct);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Correct_Exam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Correct_Exam";
            Load += Correct_Exam_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbx_exam_ids;
        private ComboBox cbx_std_ids;
        private FontAwesome.Sharp.IconButton btn_correct;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton icon_exit;
    }
}