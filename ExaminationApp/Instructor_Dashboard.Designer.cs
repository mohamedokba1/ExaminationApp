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
            this.lbl_admin_dashboard = new System.Windows.Forms.Label();
            this.btn_mng_ques = new System.Windows.Forms.Button();
            this.btn_mng_topics = new System.Windows.Forms.Button();
            this.btn_mng_courses = new System.Windows.Forms.Button();
            this.btn_mng_stdexm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_admin_dashboard
            // 
            this.lbl_admin_dashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_admin_dashboard.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lbl_admin_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_admin_dashboard.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_admin_dashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_admin_dashboard.Location = new System.Drawing.Point(-287, -17);
            this.lbl_admin_dashboard.Name = "lbl_admin_dashboard";
            this.lbl_admin_dashboard.Padding = new System.Windows.Forms.Padding(57, 67, 57, 67);
            this.lbl_admin_dashboard.Size = new System.Drawing.Size(1892, 215);
            this.lbl_admin_dashboard.TabIndex = 8;
            this.lbl_admin_dashboard.Text = "Instructor Dashboard";
            this.lbl_admin_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_mng_ques
            // 
            this.btn_mng_ques.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mng_ques.BackColor = System.Drawing.Color.Gold;
            this.btn_mng_ques.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_mng_ques.Location = new System.Drawing.Point(997, 278);
            this.btn_mng_ques.Name = "btn_mng_ques";
            this.btn_mng_ques.Size = new System.Drawing.Size(287, 199);
            this.btn_mng_ques.TabIndex = 4;
            this.btn_mng_ques.Text = "Manage Questions";
            this.btn_mng_ques.UseVisualStyleBackColor = false;
            // 
            // btn_mng_topics
            // 
            this.btn_mng_topics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mng_topics.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_mng_topics.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_mng_topics.ForeColor = System.Drawing.Color.White;
            this.btn_mng_topics.Location = new System.Drawing.Point(675, 278);
            this.btn_mng_topics.Name = "btn_mng_topics";
            this.btn_mng_topics.Size = new System.Drawing.Size(287, 199);
            this.btn_mng_topics.TabIndex = 5;
            this.btn_mng_topics.Text = "Manage Topics";
            this.btn_mng_topics.UseVisualStyleBackColor = false;
            // 
            // btn_mng_courses
            // 
            this.btn_mng_courses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mng_courses.BackColor = System.Drawing.Color.Coral;
            this.btn_mng_courses.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_mng_courses.ForeColor = System.Drawing.Color.White;
            this.btn_mng_courses.Location = new System.Drawing.Point(360, 278);
            this.btn_mng_courses.Name = "btn_mng_courses";
            this.btn_mng_courses.Size = new System.Drawing.Size(287, 199);
            this.btn_mng_courses.TabIndex = 6;
            this.btn_mng_courses.Text = "Manage Courses";
            this.btn_mng_courses.UseVisualStyleBackColor = false;
            // 
            // btn_mng_stdexm
            // 
            this.btn_mng_stdexm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mng_stdexm.BackColor = System.Drawing.Color.Chocolate;
            this.btn_mng_stdexm.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_mng_stdexm.ForeColor = System.Drawing.Color.Black;
            this.btn_mng_stdexm.Location = new System.Drawing.Point(28, 278);
            this.btn_mng_stdexm.Name = "btn_mng_stdexm";
            this.btn_mng_stdexm.Size = new System.Drawing.Size(287, 199);
            this.btn_mng_stdexm.TabIndex = 7;
            this.btn_mng_stdexm.Text = "Manage Student Exam";
            this.btn_mng_stdexm.UseVisualStyleBackColor = false;
            // 
            // Instructor_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 489);
            this.Controls.Add(this.lbl_admin_dashboard);
            this.Controls.Add(this.btn_mng_ques);
            this.Controls.Add(this.btn_mng_topics);
            this.Controls.Add(this.btn_mng_courses);
            this.Controls.Add(this.btn_mng_stdexm);
            this.Name = "Instructor_Dashboard";
            this.Text = "Instructor_Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbl_admin_dashboard;
        private Button btn_mng_ques;
        private Button btn_mng_topics;
        private Button btn_mng_courses;
        private Button btn_mng_stdexm;
    }
}