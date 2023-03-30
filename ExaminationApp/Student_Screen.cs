using ExaminationApp.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class Student_Screen : Form
    {
        ExaminationDbContext DB = new ExaminationDbContext();
        private Home homePage;
        private string stdEmail;
        private string studentFirstName;
        public Student_Screen(Home homePage, string stdEmail)
        {
            InitializeComponent();
            this.homePage = homePage;
            this.studentFirstName = DB.Students.Where(std => std.StdEmail == stdEmail).Select(std => std.StdFname).FirstOrDefault();
        }

        private void Student_Screen_Load(object sender, EventArgs e)
        {
            lbl_welcome_std.Text = $"Welcome, {studentFirstName}";
            List<Course> courses = DB.Courses.FromSql($"getAllCourses").ToList();
            cbx_courses.DataSource = courses;
            cbx_courses.DisplayMember = "CrsName";
            cbx_courses.ValueMember = "CrsId";
        }

        private void btn_start_exam_Click(object sender, EventArgs e)
        {
            Exam_Screen exam_Screen = new Exam_Screen(studentFirstName, cbx_courses.Text.ToString());
            exam_Screen.ShowDialog();
            this.Close();
        }

        private void icon_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Student_Screen_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            homePage.Show();
        }
    }
}
