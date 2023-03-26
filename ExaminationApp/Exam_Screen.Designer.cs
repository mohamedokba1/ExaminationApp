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
            this.btn_next = new System.Windows.Forms.Button();
            this.cb_choice3 = new System.Windows.Forms.RadioButton();
            this.cb_choice2 = new System.Windows.Forms.RadioButton();
            this.cb_choice1 = new System.Windows.Forms.RadioButton();
            this.lbl_ex_date = new System.Windows.Forms.Label();
            this.lbl_exam_date = new System.Windows.Forms.Label();
            this.lbl_course_name = new System.Windows.Forms.Label();
            this.lbl_course = new System.Windows.Forms.Label();
            this.lbl_duration = new System.Windows.Forms.Label();
            this.lbl_dur = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lbl_question = new System.Windows.Forms.Label();
            this.icon_back = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btn_next
            // 
            this.btn_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_next.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_next.ForeColor = System.Drawing.Color.White;
            this.btn_next.Location = new System.Drawing.Point(622, 537);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(89, 47);
            this.btn_next.TabIndex = 21;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // cb_choice3
            // 
            this.cb_choice3.AutoSize = true;
            this.cb_choice3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_choice3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_choice3.Location = new System.Drawing.Point(149, 492);
            this.cb_choice3.Name = "cb_choice3";
            this.cb_choice3.Size = new System.Drawing.Size(172, 34);
            this.cb_choice3.TabIndex = 19;
            this.cb_choice3.TabStop = true;
            this.cb_choice3.Text = "radioButton3";
            this.cb_choice3.UseVisualStyleBackColor = true;
            // 
            // cb_choice2
            // 
            this.cb_choice2.AutoSize = true;
            this.cb_choice2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_choice2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_choice2.Location = new System.Drawing.Point(149, 441);
            this.cb_choice2.Name = "cb_choice2";
            this.cb_choice2.Size = new System.Drawing.Size(172, 34);
            this.cb_choice2.TabIndex = 18;
            this.cb_choice2.TabStop = true;
            this.cb_choice2.Text = "radioButton2";
            this.cb_choice2.UseVisualStyleBackColor = true;
            // 
            // cb_choice1
            // 
            this.cb_choice1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_choice1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_choice1.Location = new System.Drawing.Point(149, 387);
            this.cb_choice1.Name = "cb_choice1";
            this.cb_choice1.Size = new System.Drawing.Size(173, 33);
            this.cb_choice1.TabIndex = 17;
            this.cb_choice1.TabStop = true;
            this.cb_choice1.Text = "cb_choice1";
            this.cb_choice1.UseVisualStyleBackColor = true;
            // 
            // lbl_ex_date
            // 
            this.lbl_ex_date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ex_date.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_ex_date.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ex_date.ForeColor = System.Drawing.Color.White;
            this.lbl_ex_date.Location = new System.Drawing.Point(607, 23);
            this.lbl_ex_date.Name = "lbl_ex_date";
            this.lbl_ex_date.Size = new System.Drawing.Size(156, 42);
            this.lbl_ex_date.TabIndex = 9;
            this.lbl_ex_date.Text = "dummy";
            this.lbl_ex_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_exam_date
            // 
            this.lbl_exam_date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_exam_date.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_exam_date.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_exam_date.ForeColor = System.Drawing.Color.White;
            this.lbl_exam_date.Location = new System.Drawing.Point(531, 22);
            this.lbl_exam_date.Name = "lbl_exam_date";
            this.lbl_exam_date.Size = new System.Drawing.Size(70, 44);
            this.lbl_exam_date.TabIndex = 10;
            this.lbl_exam_date.Text = "Date";
            this.lbl_exam_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_course_name
            // 
            this.lbl_course_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_course_name.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_course_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_course_name.ForeColor = System.Drawing.Color.White;
            this.lbl_course_name.Location = new System.Drawing.Point(371, 24);
            this.lbl_course_name.Name = "lbl_course_name";
            this.lbl_course_name.Size = new System.Drawing.Size(117, 40);
            this.lbl_course_name.TabIndex = 11;
            this.lbl_course_name.Text = "txt";
            this.lbl_course_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_course
            // 
            this.lbl_course.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_course.AutoSize = true;
            this.lbl_course.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_course.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_course.ForeColor = System.Drawing.Color.White;
            this.lbl_course.Location = new System.Drawing.Point(289, 30);
            this.lbl_course.Name = "lbl_course";
            this.lbl_course.Size = new System.Drawing.Size(76, 28);
            this.lbl_course.TabIndex = 12;
            this.lbl_course.Text = "Course";
            // 
            // lbl_duration
            // 
            this.lbl_duration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_duration.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_duration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_duration.ForeColor = System.Drawing.Color.White;
            this.lbl_duration.Location = new System.Drawing.Point(139, 22);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(99, 44);
            this.lbl_duration.TabIndex = 13;
            this.lbl_duration.Text = "txt";
            this.lbl_duration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_dur
            // 
            this.lbl_dur.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_dur.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_dur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_dur.ForeColor = System.Drawing.Color.White;
            this.lbl_dur.Location = new System.Drawing.Point(35, 22);
            this.lbl_dur.Name = "lbl_dur";
            this.lbl_dur.Size = new System.Drawing.Size(98, 44);
            this.lbl_dur.TabIndex = 14;
            this.lbl_dur.Text = "Duration";
            this.lbl_dur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl
            // 
            this.lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl.Location = new System.Drawing.Point(12, 9);
            this.lbl.Name = "lbl";
            this.lbl.Padding = new System.Windows.Forms.Padding(57, 67, 57, 67);
            this.lbl.Size = new System.Drawing.Size(751, 113);
            this.lbl.TabIndex = 16;
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_question.Location = new System.Drawing.Point(66, 232);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(90, 37);
            this.lbl_question.TabIndex = 22;
            this.lbl_question.Text = "label1";
            // 
            // icon_back
            // 
            this.icon_back.BackColor = System.Drawing.Color.Transparent;
            this.icon_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_back.FlatAppearance.BorderSize = 0;
            this.icon_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icon_back.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.icon_back.IconColor = System.Drawing.Color.Brown;
            this.icon_back.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon_back.IconSize = 35;
            this.icon_back.Location = new System.Drawing.Point(622, 472);
            this.icon_back.Name = "icon_back";
            this.icon_back.Size = new System.Drawing.Size(89, 41);
            this.icon_back.TabIndex = 23;
            this.icon_back.UseVisualStyleBackColor = false;
            this.icon_back.Click += new System.EventHandler(this.icon_back_Click);
            // 
            // Exam_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 596);
            this.Controls.Add(this.icon_back);
            this.Controls.Add(this.lbl_question);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.cb_choice3);
            this.Controls.Add(this.cb_choice2);
            this.Controls.Add(this.cb_choice1);
            this.Controls.Add(this.lbl_ex_date);
            this.Controls.Add(this.lbl_exam_date);
            this.Controls.Add(this.lbl_course_name);
            this.Controls.Add(this.lbl_course);
            this.Controls.Add(this.lbl_duration);
            this.Controls.Add(this.lbl_dur);
            this.Controls.Add(this.lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Exam_Screen";
            this.Text = "Exam_Screen";
            this.Load += new System.EventHandler(this.Exam_Screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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