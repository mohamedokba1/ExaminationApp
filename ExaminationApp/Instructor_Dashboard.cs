//using ExaminationApp.Models;
using ExaminationApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationApp
{
    public partial class Instructor_Dashboard : Form
    {
        ExaminationDbContext DB = new ExaminationDbContext();
        private Home homePage;
        private string insEmail;
        private string insName;
        public Instructor_Dashboard(Home homePage, string insEmail)
        {
            InitializeComponent();
            this.homePage = homePage;
            this.insName = DB.Instructors.Where(i => i.InsEmail == insEmail).Select(i => i.InsName).FirstOrDefault();
        }
        private void icon_close_Click(object sender, EventArgs e)
        {
            this.Close();
            homePage.Show();
        }

        private void btn_add_question_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuestionForm Questions = new QuestionForm(this, insName);
            Questions.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Correct_Exam correct = new Correct_Exam(this);
            correct.ShowDialog();
        }

        private void Instructor_Dashboard_Load(object sender, EventArgs e)
        {
            lbl_welcome_ins.Text = $"Welcome, {insName}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudExamForm correct = new StudExamForm(this);
            correct.ShowDialog();
        }
    }
}
