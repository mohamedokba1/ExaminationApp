namespace ExaminationApp
{
    partial class QuestionForm
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
            btn_delete = new Button();
            btn_update = new Button();
            dgv_ques = new DataGridView();
            cbx_correct_answer = new ComboBox();
            lbl_choice_c = new Label();
            lbl_choice_b = new Label();
            lbl_choice_a = new Label();
            txt_choice_c = new TextBox();
            txt_choice_b = new TextBox();
            txt_choice_a = new TextBox();
            icon_close = new FontAwesome.Sharp.IconButton();
            cb_courses = new ComboBox();
            label5 = new Label();
            btn_add_question = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            cb_questype = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            rtx_question_body = new RichTextBox();
            txt_mark = new NumericUpDown();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_ques).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt_mark).BeginInit();
            SuspendLayout();
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Red;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(839, 562);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(100, 42);
            btn_delete.TabIndex = 38;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.Gold;
            btn_update.Cursor = Cursors.Hand;
            btn_update.FlatAppearance.BorderSize = 0;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update.ForeColor = Color.Black;
            btn_update.Location = new Point(637, 562);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(100, 42);
            btn_update.TabIndex = 37;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // dgv_ques
            // 
            dgv_ques.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ques.Location = new Point(243, 323);
            dgv_ques.Name = "dgv_ques";
            dgv_ques.RowHeadersWidth = 51;
            dgv_ques.RowTemplate.Height = 29;
            dgv_ques.Size = new Size(948, 211);
            dgv_ques.TabIndex = 36;
            dgv_ques.RowHeaderMouseDoubleClick += dgv_ques_RowHeaderMouseDoubleClick_1;
            // 
            // cbx_correct_answer
            // 
            cbx_correct_answer.FormattingEnabled = true;
            cbx_correct_answer.Location = new Point(525, 256);
            cbx_correct_answer.Name = "cbx_correct_answer";
            cbx_correct_answer.Size = new Size(167, 28);
            cbx_correct_answer.TabIndex = 35;
            // 
            // lbl_choice_c
            // 
            lbl_choice_c.AutoSize = true;
            lbl_choice_c.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_choice_c.Location = new Point(744, 213);
            lbl_choice_c.Name = "lbl_choice_c";
            lbl_choice_c.Size = new Size(18, 23);
            lbl_choice_c.TabIndex = 34;
            lbl_choice_c.Text = "c";
            // 
            // lbl_choice_b
            // 
            lbl_choice_b.AutoSize = true;
            lbl_choice_b.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_choice_b.Location = new Point(741, 153);
            lbl_choice_b.Name = "lbl_choice_b";
            lbl_choice_b.Size = new Size(21, 23);
            lbl_choice_b.TabIndex = 33;
            lbl_choice_b.Text = "b";
            // 
            // lbl_choice_a
            // 
            lbl_choice_a.AutoSize = true;
            lbl_choice_a.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_choice_a.Location = new Point(744, 101);
            lbl_choice_a.Name = "lbl_choice_a";
            lbl_choice_a.Size = new Size(19, 23);
            lbl_choice_a.TabIndex = 32;
            lbl_choice_a.Text = "a";
            // 
            // txt_choice_c
            // 
            txt_choice_c.Location = new Point(769, 212);
            txt_choice_c.Name = "txt_choice_c";
            txt_choice_c.Size = new Size(487, 27);
            txt_choice_c.TabIndex = 30;
            // 
            // txt_choice_b
            // 
            txt_choice_b.Location = new Point(769, 153);
            txt_choice_b.Name = "txt_choice_b";
            txt_choice_b.Size = new Size(487, 27);
            txt_choice_b.TabIndex = 29;
            // 
            // txt_choice_a
            // 
            txt_choice_a.Location = new Point(769, 101);
            txt_choice_a.Name = "txt_choice_a";
            txt_choice_a.Size = new Size(487, 27);
            txt_choice_a.TabIndex = 31;
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
            icon_close.Location = new Point(1284, 12);
            icon_close.Name = "icon_close";
            icon_close.Size = new Size(35, 33);
            icon_close.TabIndex = 28;
            icon_close.UseVisualStyleBackColor = true;
            icon_close.Click += icon_close_Click;
            // 
            // cb_courses
            // 
            cb_courses.FormattingEnabled = true;
            cb_courses.Location = new Point(811, 256);
            cb_courses.Name = "cb_courses";
            cb_courses.Size = new Size(169, 28);
            cb_courses.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(741, 261);
            label5.Name = "label5";
            label5.Size = new Size(64, 23);
            label5.TabIndex = 26;
            label5.Text = "Course";
            // 
            // btn_add_question
            // 
            btn_add_question.Anchor = AnchorStyles.None;
            btn_add_question.BackColor = Color.LimeGreen;
            btn_add_question.Cursor = Cursors.Hand;
            btn_add_question.FlatAppearance.BorderSize = 0;
            btn_add_question.FlatStyle = FlatStyle.Flat;
            btn_add_question.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add_question.ForeColor = SystemColors.ButtonFace;
            btn_add_question.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btn_add_question.IconColor = Color.WhiteSmoke;
            btn_add_question.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_add_question.IconSize = 32;
            btn_add_question.ImageAlign = ContentAlignment.BottomLeft;
            btn_add_question.Location = new Point(413, 562);
            btn_add_question.Name = "btn_add_question";
            btn_add_question.Size = new Size(100, 42);
            btn_add_question.TabIndex = 25;
            btn_add_question.Text = "Add";
            btn_add_question.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_add_question.UseVisualStyleBackColor = false;
            btn_add_question.Click += btn_add_question_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(386, 261);
            label3.Name = "label3";
            label3.Size = new Size(133, 23);
            label3.TabIndex = 22;
            label3.Text = "Correct Answer";
            // 
            // cb_questype
            // 
            cb_questype.FormattingEnabled = true;
            cb_questype.Location = new Point(174, 256);
            cb_questype.Name = "cb_questype";
            cb_questype.Size = new Size(193, 28);
            cb_questype.TabIndex = 21;
            cb_questype.SelectedValueChanged += cb_questype_SelectedValueChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 261);
            label2.Name = "label2";
            label2.Size = new Size(124, 23);
            label2.TabIndex = 20;
            label2.Text = "Question Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 105);
            label1.Name = "label1";
            label1.Size = new Size(127, 23);
            label1.TabIndex = 19;
            label1.Text = "Question Body";
            // 
            // rtx_question_body
            // 
            rtx_question_body.BorderStyle = BorderStyle.None;
            rtx_question_body.Location = new Point(174, 101);
            rtx_question_body.Name = "rtx_question_body";
            rtx_question_body.Size = new Size(503, 129);
            rtx_question_body.TabIndex = 18;
            rtx_question_body.Text = "";
            // 
            // txt_mark
            // 
            txt_mark.Location = new Point(1106, 256);
            txt_mark.Name = "txt_mark";
            txt_mark.Size = new Size(150, 27);
            txt_mark.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1036, 261);
            label4.Name = "label4";
            label4.Size = new Size(52, 23);
            label4.TabIndex = 40;
            label4.Text = "Mark";
            // 
            // QuestionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 669);
            Controls.Add(label4);
            Controls.Add(txt_mark);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(dgv_ques);
            Controls.Add(cbx_correct_answer);
            Controls.Add(lbl_choice_c);
            Controls.Add(lbl_choice_b);
            Controls.Add(lbl_choice_a);
            Controls.Add(txt_choice_c);
            Controls.Add(txt_choice_b);
            Controls.Add(txt_choice_a);
            Controls.Add(icon_close);
            Controls.Add(cb_courses);
            Controls.Add(label5);
            Controls.Add(btn_add_question);
            Controls.Add(label3);
            Controls.Add(cb_questype);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtx_question_body);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QuestionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuestionForm";
            Load += QuestionForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_ques).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt_mark).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_delete;
        private Button btn_update;
        private DataGridView dgv_ques;
        private ComboBox cbx_correct_answer;
        private Label lbl_choice_c;
        private Label lbl_choice_b;
        private Label lbl_choice_a;
        private TextBox txt_choice_c;
        private TextBox txt_choice_b;
        private TextBox txt_choice_a;
        private FontAwesome.Sharp.IconButton icon_close;
        private ComboBox cb_courses;
        private Label label5;
        private FontAwesome.Sharp.IconButton btn_add_question;
        private Label label3;
        private ComboBox cb_questype;
        private Label label2;
        private Label label1;
        private RichTextBox rtx_question_body;
        private NumericUpDown txt_mark;
        private Label label4;
    }
}