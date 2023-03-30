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
    public partial class Admin_Dashboard : Form
    {
        private Home homePage;
        public Admin_Dashboard(Home homePage)
        {
            InitializeComponent();
            this.homePage = homePage;
        }

        private void btn_mng_students_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentForm std_form = new StudentForm(this);
            std_form.ShowDialog();

        }

        private void btn_mng_departments_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepartmentForm dept = new DepartmentForm(this);
            dept.ShowDialog();
        }

        private void btn_mng_instructors_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorForm instructor = new InstructorForm(this);
            instructor.ShowDialog();
        }

        private void btn_mng_exam_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamForm exam = new ExamForm(this);
            exam.ShowDialog();
        }

        private void btn_mng_courses_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseForm course = new CourseForm(this);
            course.ShowDialog();
        }

        private void btn_mng_topics_Click(object sender, EventArgs e)
        {
            this.Hide();
            TopicForm topic = new TopicForm(this);
            topic.ShowDialog();
        }

        private void icon_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            homePage.Show();
        }
    }
}
