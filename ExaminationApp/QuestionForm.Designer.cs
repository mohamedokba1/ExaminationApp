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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.dgv_ques = new System.Windows.Forms.DataGridView();
            this.cbx_correct_answer = new System.Windows.Forms.ComboBox();
            this.lbl_choice_c = new System.Windows.Forms.Label();
            this.lbl_choice_b = new System.Windows.Forms.Label();
            this.lbl_choice_a = new System.Windows.Forms.Label();
            this.txt_choice_c = new System.Windows.Forms.TextBox();
            this.txt_choice_b = new System.Windows.Forms.TextBox();
            this.txt_choice_a = new System.Windows.Forms.TextBox();
            this.icon_close = new FontAwesome.Sharp.IconButton();
            this.cb_courses = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_add_question = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_questype = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtx_question_body = new System.Windows.Forms.RichTextBox();
            this.txt_mark = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mark)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(839, 562);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 42);
            this.btn_delete.TabIndex = 38;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Gold;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_update.ForeColor = System.Drawing.Color.Black;
            this.btn_update.Location = new System.Drawing.Point(637, 562);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 42);
            this.btn_update.TabIndex = 37;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dgv_ques
            // 
            this.dgv_ques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ques.Location = new System.Drawing.Point(243, 323);
            this.dgv_ques.Name = "dgv_ques";
            this.dgv_ques.RowHeadersWidth = 51;
            this.dgv_ques.RowTemplate.Height = 29;
            this.dgv_ques.Size = new System.Drawing.Size(948, 211);
            this.dgv_ques.TabIndex = 36;
            this.dgv_ques.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_ques_RowHeaderMouseDoubleClick_1);
            // 
            // cbx_correct_answer
            // 
            this.cbx_correct_answer.FormattingEnabled = true;
            this.cbx_correct_answer.Location = new System.Drawing.Point(525, 256);
            this.cbx_correct_answer.Name = "cbx_correct_answer";
            this.cbx_correct_answer.Size = new System.Drawing.Size(167, 28);
            this.cbx_correct_answer.TabIndex = 35;
            // 
            // lbl_choice_c
            // 
            this.lbl_choice_c.AutoSize = true;
            this.lbl_choice_c.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_choice_c.Location = new System.Drawing.Point(744, 213);
            this.lbl_choice_c.Name = "lbl_choice_c";
            this.lbl_choice_c.Size = new System.Drawing.Size(18, 23);
            this.lbl_choice_c.TabIndex = 34;
            this.lbl_choice_c.Text = "c";
            // 
            // lbl_choice_b
            // 
            this.lbl_choice_b.AutoSize = true;
            this.lbl_choice_b.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_choice_b.Location = new System.Drawing.Point(741, 153);
            this.lbl_choice_b.Name = "lbl_choice_b";
            this.lbl_choice_b.Size = new System.Drawing.Size(21, 23);
            this.lbl_choice_b.TabIndex = 33;
            this.lbl_choice_b.Text = "b";
            // 
            // lbl_choice_a
            // 
            this.lbl_choice_a.AutoSize = true;
            this.lbl_choice_a.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_choice_a.Location = new System.Drawing.Point(744, 101);
            this.lbl_choice_a.Name = "lbl_choice_a";
            this.lbl_choice_a.Size = new System.Drawing.Size(19, 23);
            this.lbl_choice_a.TabIndex = 32;
            this.lbl_choice_a.Text = "a";
            // 
            // txt_choice_c
            // 
            this.txt_choice_c.Location = new System.Drawing.Point(769, 212);
            this.txt_choice_c.Name = "txt_choice_c";
            this.txt_choice_c.Size = new System.Drawing.Size(487, 27);
            this.txt_choice_c.TabIndex = 30;
            // 
            // txt_choice_b
            // 
            this.txt_choice_b.Location = new System.Drawing.Point(769, 153);
            this.txt_choice_b.Name = "txt_choice_b";
            this.txt_choice_b.Size = new System.Drawing.Size(487, 27);
            this.txt_choice_b.TabIndex = 29;
            // 
            // txt_choice_a
            // 
            this.txt_choice_a.Location = new System.Drawing.Point(769, 101);
            this.txt_choice_a.Name = "txt_choice_a";
            this.txt_choice_a.Size = new System.Drawing.Size(487, 27);
            this.txt_choice_a.TabIndex = 31;
            // 
            // icon_close
            // 
            this.icon_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_close.FlatAppearance.BorderSize = 0;
            this.icon_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icon_close.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.icon_close.IconColor = System.Drawing.Color.Red;
            this.icon_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon_close.IconSize = 35;
            this.icon_close.Location = new System.Drawing.Point(1284, 12);
            this.icon_close.Name = "icon_close";
            this.icon_close.Size = new System.Drawing.Size(35, 33);
            this.icon_close.TabIndex = 28;
            this.icon_close.UseVisualStyleBackColor = true;
            this.icon_close.Click += new System.EventHandler(this.icon_close_Click);
            // 
            // cb_courses
            // 
            this.cb_courses.FormattingEnabled = true;
            this.cb_courses.Location = new System.Drawing.Point(811, 256);
            this.cb_courses.Name = "cb_courses";
            this.cb_courses.Size = new System.Drawing.Size(169, 28);
            this.cb_courses.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(741, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Course";
            // 
            // btn_add_question
            // 
            this.btn_add_question.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add_question.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_add_question.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_question.FlatAppearance.BorderSize = 0;
            this.btn_add_question.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_question.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add_question.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_add_question.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btn_add_question.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btn_add_question.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_add_question.IconSize = 32;
            this.btn_add_question.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_add_question.Location = new System.Drawing.Point(413, 562);
            this.btn_add_question.Name = "btn_add_question";
            this.btn_add_question.Size = new System.Drawing.Size(100, 42);
            this.btn_add_question.TabIndex = 25;
            this.btn_add_question.Text = "Add";
            this.btn_add_question.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_add_question.UseVisualStyleBackColor = false;
            this.btn_add_question.Click += new System.EventHandler(this.btn_add_question_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(386, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Correct Answer";
            // 
            // cb_questype
            // 
            this.cb_questype.FormattingEnabled = true;
            this.cb_questype.Location = new System.Drawing.Point(174, 256);
            this.cb_questype.Name = "cb_questype";
            this.cb_questype.Size = new System.Drawing.Size(193, 28);
            this.cb_questype.TabIndex = 21;
            this.cb_questype.SelectedValueChanged += new System.EventHandler(this.cb_questype_SelectedValueChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Question Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Question Body";
            // 
            // rtx_question_body
            // 
            this.rtx_question_body.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtx_question_body.Location = new System.Drawing.Point(174, 101);
            this.rtx_question_body.Name = "rtx_question_body";
            this.rtx_question_body.Size = new System.Drawing.Size(503, 129);
            this.rtx_question_body.TabIndex = 18;
            this.rtx_question_body.Text = "";
            // 
            // txt_mark
            // 
            this.txt_mark.Location = new System.Drawing.Point(1106, 256);
            this.txt_mark.Name = "txt_mark";
            this.txt_mark.Size = new System.Drawing.Size(150, 27);
            this.txt_mark.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1036, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 23);
            this.label4.TabIndex = 40;
            this.label4.Text = "Mark";
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 669);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_mark);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.dgv_ques);
            this.Controls.Add(this.cbx_correct_answer);
            this.Controls.Add(this.lbl_choice_c);
            this.Controls.Add(this.lbl_choice_b);
            this.Controls.Add(this.lbl_choice_a);
            this.Controls.Add(this.txt_choice_c);
            this.Controls.Add(this.txt_choice_b);
            this.Controls.Add(this.txt_choice_a);
            this.Controls.Add(this.icon_close);
            this.Controls.Add(this.cb_courses);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_add_question);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_questype);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtx_question_body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuestionForm";
            this.Text = "QuestionForm";
            this.Load += new System.EventHandler(this.QuestionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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