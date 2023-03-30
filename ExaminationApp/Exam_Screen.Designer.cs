namespace ExaminationApp
{
    partial class Exam_Screen
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
            btn_next = new Button();
            cb_choice3 = new RadioButton();
            cb_choice2 = new RadioButton();
            cb_choice1 = new RadioButton();
            lbl_ex_date = new Label();
            lbl_exam_date = new Label();
            lbl_course_name = new Label();
            lbl_course = new Label();
            lbl_duration = new Label();
            lbl_dur = new Label();
            lbl = new Label();
            lbl_question = new Label();
            icon_back = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // btn_next
            // 
            btn_next.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_next.BackColor = Color.DarkSlateGray;
            btn_next.Cursor = Cursors.Hand;
            btn_next.FlatAppearance.BorderSize = 0;
            btn_next.FlatStyle = FlatStyle.Flat;
            btn_next.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_next.ForeColor = Color.White;
            btn_next.Location = new Point(622, 537);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(89, 47);
            btn_next.TabIndex = 21;
            btn_next.Text = "Next";
            btn_next.UseVisualStyleBackColor = false;
            btn_next.Click += btn_next_Click;
            // 
            // cb_choice3
            // 
            cb_choice3.AutoSize = true;
            cb_choice3.Cursor = Cursors.Hand;
            cb_choice3.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            cb_choice3.Location = new Point(149, 492);
            cb_choice3.Name = "cb_choice3";
            cb_choice3.Size = new Size(172, 34);
            cb_choice3.TabIndex = 19;
            cb_choice3.TabStop = true;
            cb_choice3.Text = "radioButton3";
            cb_choice3.UseVisualStyleBackColor = true;
            // 
            // cb_choice2
            // 
            cb_choice2.AutoSize = true;
            cb_choice2.Cursor = Cursors.Hand;
            cb_choice2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            cb_choice2.Location = new Point(149, 441);
            cb_choice2.Name = "cb_choice2";
            cb_choice2.Size = new Size(172, 34);
            cb_choice2.TabIndex = 18;
            cb_choice2.TabStop = true;
            cb_choice2.Text = "radioButton2";
            cb_choice2.UseVisualStyleBackColor = true;
            // 
            // cb_choice1
            // 
            cb_choice1.Cursor = Cursors.Hand;
            cb_choice1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            cb_choice1.Location = new Point(149, 387);
            cb_choice1.Name = "cb_choice1";
            cb_choice1.Size = new Size(173, 33);
            cb_choice1.TabIndex = 17;
            cb_choice1.TabStop = true;
            cb_choice1.Text = "cb_choice1";
            cb_choice1.UseVisualStyleBackColor = true;
            // 
            // lbl_ex_date
            // 
            lbl_ex_date.Anchor = AnchorStyles.Top;
            lbl_ex_date.BackColor = Color.SteelBlue;
            lbl_ex_date.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ex_date.ForeColor = Color.White;
            lbl_ex_date.Location = new Point(592, 29);
            lbl_ex_date.Name = "lbl_ex_date";
            lbl_ex_date.Size = new Size(171, 35);
            lbl_ex_date.TabIndex = 9;
            lbl_ex_date.Text = "dummy";
            lbl_ex_date.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_exam_date
            // 
            lbl_exam_date.Anchor = AnchorStyles.Top;
            lbl_exam_date.BackColor = Color.SteelBlue;
            lbl_exam_date.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_exam_date.ForeColor = Color.White;
            lbl_exam_date.Location = new Point(531, 22);
            lbl_exam_date.Name = "lbl_exam_date";
            lbl_exam_date.Size = new Size(70, 44);
            lbl_exam_date.TabIndex = 10;
            lbl_exam_date.Text = "Date";
            lbl_exam_date.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_course_name
            // 
            lbl_course_name.Anchor = AnchorStyles.Top;
            lbl_course_name.BackColor = Color.SteelBlue;
            lbl_course_name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_course_name.ForeColor = Color.White;
            lbl_course_name.Location = new Point(371, 24);
            lbl_course_name.Name = "lbl_course_name";
            lbl_course_name.Size = new Size(52, 40);
            lbl_course_name.TabIndex = 11;
            lbl_course_name.Text = "txt";
            lbl_course_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_course
            // 
            lbl_course.Anchor = AnchorStyles.Top;
            lbl_course.AutoSize = true;
            lbl_course.BackColor = Color.SteelBlue;
            lbl_course.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_course.ForeColor = Color.White;
            lbl_course.Location = new Point(289, 30);
            lbl_course.Name = "lbl_course";
            lbl_course.Size = new Size(76, 28);
            lbl_course.TabIndex = 12;
            lbl_course.Text = "Course";
            // 
            // lbl_duration
            // 
            lbl_duration.Anchor = AnchorStyles.Top;
            lbl_duration.BackColor = Color.SteelBlue;
            lbl_duration.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_duration.ForeColor = Color.White;
            lbl_duration.Location = new Point(139, 24);
            lbl_duration.Name = "lbl_duration";
            lbl_duration.Size = new Size(42, 44);
            lbl_duration.TabIndex = 13;
            lbl_duration.Text = "txt";
            lbl_duration.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_dur
            // 
            lbl_dur.Anchor = AnchorStyles.Top;
            lbl_dur.BackColor = Color.SteelBlue;
            lbl_dur.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_dur.ForeColor = Color.White;
            lbl_dur.Location = new Point(35, 22);
            lbl_dur.Name = "lbl_dur";
            lbl_dur.Size = new Size(98, 44);
            lbl_dur.TabIndex = 14;
            lbl_dur.Text = "Duration";
            lbl_dur.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl
            // 
            lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl.BackColor = Color.SteelBlue;
            lbl.FlatStyle = FlatStyle.Popup;
            lbl.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.ForeColor = SystemColors.ButtonHighlight;
            lbl.Location = new Point(2, -2);
            lbl.Name = "lbl";
            lbl.Padding = new Padding(57, 67, 57, 67);
            lbl.Size = new Size(771, 93);
            lbl.TabIndex = 16;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_question
            // 
            lbl_question.AutoSize = true;
            lbl_question.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_question.Location = new Point(66, 232);
            lbl_question.Name = "lbl_question";
            lbl_question.Size = new Size(90, 37);
            lbl_question.TabIndex = 22;
            lbl_question.Text = "label1";
            // 
            // icon_back
            // 
            icon_back.BackColor = Color.Transparent;
            icon_back.Cursor = Cursors.Hand;
            icon_back.FlatAppearance.BorderSize = 0;
            icon_back.FlatStyle = FlatStyle.Flat;
            icon_back.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            icon_back.IconColor = Color.Brown;
            icon_back.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_back.IconSize = 35;
            icon_back.Location = new Point(622, 472);
            icon_back.Name = "icon_back";
            icon_back.Size = new Size(89, 41);
            icon_back.TabIndex = 23;
            icon_back.UseVisualStyleBackColor = false;
            icon_back.Click += icon_back_Click;
            // 
            // Exam_Screen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 596);
            Controls.Add(icon_back);
            Controls.Add(lbl_question);
            Controls.Add(btn_next);
            Controls.Add(cb_choice3);
            Controls.Add(cb_choice2);
            Controls.Add(cb_choice1);
            Controls.Add(lbl_ex_date);
            Controls.Add(lbl_exam_date);
            Controls.Add(lbl_course_name);
            Controls.Add(lbl_course);
            Controls.Add(lbl_duration);
            Controls.Add(lbl_dur);
            Controls.Add(lbl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Exam_Screen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exam_Screen";
            Load += Exam_Screen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_next;
        private RadioButton cb_choice3;
        private RadioButton cb_choice2;
        private RadioButton cb_choice1;
        private Label lbl_ex_date;
        private Label lbl_exam_date;
        private Label lbl_course_name;
        private Label lbl_course;
        private Label lbl_duration;
        private Label lbl_dur;
        private Label lbl;
        private Label lbl_question;
        private FontAwesome.Sharp.IconButton icon_back;
    }
}