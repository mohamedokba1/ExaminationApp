namespace ExaminationApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void showLoginform()
        {
            Login_Form log = new Login_Form();
            log.ShowDialog();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want really to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            e.Cancel = true;
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            showLoginform();
        }

        private void btn_Instructor_Click(object sender, EventArgs e)
        {
            showLoginform();
        }
        private void btn_admin_Click(object sender, EventArgs e)
        {
            showLoginform();
        }

        private void btn_student_MouseEnter(object sender, EventArgs e)
        {
            btn_student.BackColor = Color.White;
            btn_student.ForeColor = Color.DeepSkyBlue;
        }

        private void btn_student_MouseLeave(object sender, EventArgs e)
        {
            btn_student.BackColor = Color.DeepSkyBlue;
            btn_student.ForeColor = Color.White;
        }

        private void btn_admin_MouseEnter(object sender, EventArgs e)
        {
            btn_admin.BackColor = Color.White;
            btn_admin.ForeColor = Color.Tomato;
        }

        private void btn_admin_MouseLeave(object sender, EventArgs e)
        {
            btn_admin.BackColor = Color.Tomato;
            btn_admin.ForeColor = Color.White;
        }

        private void btn_Instructor_MouseEnter(object sender, EventArgs e)
        {
            btn_Instructor.BackColor = Color.White;
            btn_Instructor.ForeColor = Color.Turquoise;
        }

        private void btn_Instructor_MouseLeave(object sender, EventArgs e)
        {
            btn_Instructor.BackColor = Color.Turquoise;
            btn_Instructor.ForeColor = Color.White;
        }

        
    }
}