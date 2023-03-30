namespace ExaminationApp
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label1 = new Label();
            panel1 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            txt_user_password = new TextBox();
            txt_user_email = new TextBox();
            btn_login = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.BackColor = Color.SteelBlue;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(1, -2);
            label1.Name = "label1";
            label1.Padding = new Padding(57, 67, 57, 67);
            label1.Size = new Size(847, 646);
            label1.TabIndex = 2;
            label1.Text = "ITI Examination System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(txt_user_password);
            panel1.Controls.Add(txt_user_email);
            panel1.Controls.Add(btn_login);
            panel1.Location = new Point(342, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1191, 531);
            panel1.TabIndex = 3;
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.None;
            iconButton2.BackColor = Color.Transparent;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.User;
            iconButton2.IconColor = Color.DarkTurquoise;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 52;
            iconButton2.Location = new Point(345, 215);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(114, 74);
            iconButton2.TabIndex = 3;
            iconButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.None;
            iconButton1.BackColor = Color.Transparent;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconButton1.IconColor = Color.DarkTurquoise;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(337, 305);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(122, 74);
            iconButton1.TabIndex = 2;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // txt_user_password
            // 
            txt_user_password.Anchor = AnchorStyles.None;
            txt_user_password.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txt_user_password.Location = new Point(464, 315);
            txt_user_password.Multiline = true;
            txt_user_password.Name = "txt_user_password";
            txt_user_password.PasswordChar = '*';
            txt_user_password.PlaceholderText = "Password";
            txt_user_password.Size = new Size(429, 54);
            txt_user_password.TabIndex = 1;
            txt_user_password.WordWrap = false;
            // 
            // txt_user_email
            // 
            txt_user_email.Anchor = AnchorStyles.None;
            txt_user_email.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txt_user_email.Location = new Point(464, 225);
            txt_user_email.Multiline = true;
            txt_user_email.Name = "txt_user_email";
            txt_user_email.PlaceholderText = "Email";
            txt_user_email.Size = new Size(429, 52);
            txt_user_email.TabIndex = 1;
            // 
            // btn_login
            // 
            btn_login.Anchor = AnchorStyles.None;
            btn_login.BackColor = Color.DarkTurquoise;
            btn_login.Cursor = Cursors.Hand;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = SystemColors.ButtonHighlight;
            btn_login.Location = new Point(522, 442);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(282, 60);
            btn_login.TabIndex = 0;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click_1;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1534, 528);
            Controls.Add(label1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home";
            Text = "Examination System";
            FormClosing += Form1_FormClosing;
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Button btn_login;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox txt_user_email;
        private TextBox txt_user_password;
    }
}