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
            this.icon_close = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_add_question = new System.Windows.Forms.Button();
            this.lbl_welcome_ins = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.icon_close.Location = new System.Drawing.Point(394, 21);
            this.icon_close.Name = "icon_close";
            this.icon_close.Size = new System.Drawing.Size(42, 36);
            this.icon_close.TabIndex = 4;
            this.icon_close.UseVisualStyleBackColor = true;
            this.icon_close.Click += new System.EventHandler(this.icon_close_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(72, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 103);
            this.button1.TabIndex = 2;
            this.button1.Text = "Manage Exam";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_add_question
            // 
            this.btn_add_question.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_add_question.FlatAppearance.BorderSize = 0;
            this.btn_add_question.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_question.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add_question.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add_question.Location = new System.Drawing.Point(72, 126);
            this.btn_add_question.Name = "btn_add_question";
            this.btn_add_question.Size = new System.Drawing.Size(275, 108);
            this.btn_add_question.TabIndex = 3;
            this.btn_add_question.Text = "Manage Question";
            this.btn_add_question.UseVisualStyleBackColor = false;
            this.btn_add_question.Click += new System.EventHandler(this.btn_add_question_Click);
            // 
            // lbl_welcome_ins
            // 
            this.lbl_welcome_ins.AutoSize = true;
            this.lbl_welcome_ins.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_welcome_ins.Location = new System.Drawing.Point(108, 75);
            this.lbl_welcome_ins.Name = "lbl_welcome_ins";
            this.lbl_welcome_ins.Size = new System.Drawing.Size(0, 20);
            this.lbl_welcome_ins.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(72, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(275, 103);
            this.button2.TabIndex = 10;
            this.button2.Text = "Manage Exam";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Instructor_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 610);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_welcome_ins);
            this.Controls.Add(this.icon_close);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_add_question);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Instructor_Dashboard";
            this.Text = "Instructor_Dashboard";
            this.Load += new System.EventHandler(this.Instructor_Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton icon_close;
        private Button button1;
        private Button btn_add_question;
        private Label lbl_welcome_ins;
        private Button button2;
    }
}