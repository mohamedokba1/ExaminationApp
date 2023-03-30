using ExaminationApp.Models;

namespace ExaminationApp
{
    public partial class Home : Form
    {
        ExaminationDbContext Context = new ExaminationDbContext();
        public Home()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want really to exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            e.Cancel = true;
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            string userEmail = txt_user_email.Text.Trim();
            string userPassword = txt_user_password.Text;
            var user = Context.Users.Where(user => user.UserEmail == userEmail && user.UserPassword == userPassword).FirstOrDefault();
            if (user != null)
            {
                if (user.UserRole.ToLower() == "admin")
                {
                    this.Hide();
                    Admin_Dashboard admin = new Admin_Dashboard(this);
                    admin.ShowDialog();
                }
                else if (user.UserRole.ToLower() == "student")
                {
                    this.Hide();
                    Student_Screen stdScreen = new Student_Screen(this, user.UserEmail);
                    stdScreen.ShowDialog();
                }
                else if (user.UserRole.ToLower() == "instructor")
                {
                    this.Hide();
                    Instructor_Dashboard instructorScreen = new Instructor_Dashboard(this, user.UserEmail);
                    instructorScreen.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Wrong Email or password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            txt_user_email.Text = "";
            txt_user_password.Text = "";
        }
    }
}