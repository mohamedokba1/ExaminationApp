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
            this.cbx_exam_ids = new System.Windows.Forms.ComboBox();
            this.cbx_std_ids = new System.Windows.Forms.ComboBox();
            this.btn_correct = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.icon_exit = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // cbx_exam_ids
            // 
            this.cbx_exam_ids.FormattingEnabled = true;
            this.cbx_exam_ids.Location = new System.Drawing.Point(174, 152);
            this.cbx_exam_ids.Name = "cbx_exam_ids";
            this.cbx_exam_ids.Size = new System.Drawing.Size(320, 28);
            this.cbx_exam_ids.TabIndex = 7;
            // 
            // cbx_std_ids
            // 
            this.cbx_std_ids.FormattingEnabled = true;
            this.cbx_std_ids.Location = new System.Drawing.Point(174, 60);
            this.cbx_std_ids.Name = "cbx_std_ids";
            this.cbx_std_ids.Size = new System.Drawing.Size(320, 28);
            this.cbx_std_ids.TabIndex = 8;
            this.cbx_std_ids.SelectedValueChanged += new System.EventHandler(this.cbx_std_ids_SelectedValueChanged);
            // 
            // btn_correct
            // 
            this.btn_correct.BackColor = System.Drawing.Color.Transparent;
            this.btn_correct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_correct.FlatAppearance.BorderSize = 0;
            this.btn_correct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_correct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_correct.ForeColor = System.Drawing.Color.Green;
            this.btn_correct.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            this.btn_correct.IconColor = System.Drawing.Color.Green;
            this.btn_correct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_correct.IconSize = 90;
            this.btn_correct.Location = new System.Drawing.Point(281, 241);
            this.btn_correct.Name = "btn_correct";
            this.btn_correct.Size = new System.Drawing.Size(73, 68);
            this.btn_correct.TabIndex = 6;
            this.btn_correct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_correct.UseVisualStyleBackColor = false;
            this.btn_correct.Click += new System.EventHandler(this.btn_correct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(61, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Exam ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(61, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student";
            // 
            // icon_exit
            // 
            this.icon_exit.BackColor = System.Drawing.Color.Transparent;
            this.icon_exit.CausesValidation = false;
            this.icon_exit.FlatAppearance.BorderSize = 0;
            this.icon_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icon_exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.icon_exit.IconColor = System.Drawing.Color.Red;
            this.icon_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon_exit.IconSize = 35;
            this.icon_exit.Location = new System.Drawing.Point(521, 6);
            this.icon_exit.Name = "icon_exit";
            this.icon_exit.Size = new System.Drawing.Size(49, 40);
            this.icon_exit.TabIndex = 4;
            this.icon_exit.UseVisualStyleBackColor = true;
            this.icon_exit.Click += new System.EventHandler(this.icon_exit_Click);
            // 
            // Correct_Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(590, 366);
            this.Controls.Add(this.icon_exit);
            this.Controls.Add(this.cbx_exam_ids);
            this.Controls.Add(this.cbx_std_ids);
            this.Controls.Add(this.btn_correct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Correct_Exam";
            this.Text = "Correct_Exam";
            this.Load += new System.EventHandler(this.Correct_Exam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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