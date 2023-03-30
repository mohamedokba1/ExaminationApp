namespace ExaminationApp
{
    partial class Instructor_Dashboard
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
            icon_close = new FontAwesome.Sharp.IconButton();
            button1 = new Button();
            btn_add_question = new Button();
            lbl_welcome_ins = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // icon_close
            // 
            icon_close.Cursor = Cursors.Hand;
            icon_close.FlatAppearance.BorderSize = 0;
            icon_close.FlatStyle = FlatStyle.Flat;
            icon_close.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            icon_close.IconColor = Color.Red;
            icon_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_close.IconSize = 35;
            icon_close.Location = new Point(479, 12);
            icon_close.Name = "icon_close";
            icon_close.Size = new Size(42, 36);
            icon_close.TabIndex = 4;
            icon_close.UseVisualStyleBackColor = true;
            icon_close.Click += icon_close_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(72, 275);
            button1.Name = "button1";
            button1.Size = new Size(387, 107);
            button1.TabIndex = 2;
            button1.Text = "Correct Exam";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_add_question
            // 
            btn_add_question.BackColor = Color.LightSalmon;
            btn_add_question.FlatAppearance.BorderSize = 0;
            btn_add_question.FlatStyle = FlatStyle.Flat;
            btn_add_question.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add_question.ForeColor = SystemColors.ButtonHighlight;
            btn_add_question.Location = new Point(72, 126);
            btn_add_question.Name = "btn_add_question";
            btn_add_question.Size = new Size(387, 116);
            btn_add_question.TabIndex = 3;
            btn_add_question.Text = "Manage Question";
            btn_add_question.UseVisualStyleBackColor = false;
            btn_add_question.Click += btn_add_question_Click;
            // 
            // lbl_welcome_ins
            // 
            lbl_welcome_ins.AutoSize = true;
            lbl_welcome_ins.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_welcome_ins.Location = new Point(140, 58);
            lbl_welcome_ins.Name = "lbl_welcome_ins";
            lbl_welcome_ins.Size = new Size(0, 25);
            lbl_welcome_ins.TabIndex = 9;
            lbl_welcome_ins.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.SlateBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(72, 426);
            button2.Name = "button2";
            button2.Size = new Size(387, 115);
            button2.TabIndex = 10;
            button2.Text = "Manage Exam";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Instructor_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 610);
            Controls.Add(button2);
            Controls.Add(lbl_welcome_ins);
            Controls.Add(icon_close);
            Controls.Add(button1);
            Controls.Add(btn_add_question);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Instructor_Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Instructor_Dashboard";
            Load += Instructor_Dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton icon_close;
        private Button button1;
        private Button btn_add_question;
        private Label lbl_welcome_ins;
        private Button button2;
    }
}