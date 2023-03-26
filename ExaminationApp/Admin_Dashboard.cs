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
            WindowState = FormWindowState.Maximized;
            this.homePage = homePage;
        }

        private void btn_mng_students_Click(object sender, EventArgs e)
        {
            StudentForm std_form = new StudentForm();
            std_form.ShowDialog();
            this.Close();
        }

        private void btn_mng_departments_Click(object sender, EventArgs e)
        {
            DepartmentForm dept = new DepartmentForm();
            dept.ShowDialog();
            this.Close();

        }

        private void btn_mng_instructors_Click(object sender, EventArgs e)
        {
            InstructorForm instructor = new InstructorForm();
            instructor.ShowDialog();
            this.Close();

        }

        private void btn_mng_exam_Click(object sender, EventArgs e)
        {
            ExamForm exam = new ExamForm();
            exam.ShowDialog();
            this.Close();

        }

        private void btn_mng_courses_Click(object sender, EventArgs e)
        {
            CourseForm course = new CourseForm();
            course.ShowDialog();
            this.Close();
        }

        private void btn_mng_topics_Click(object sender, EventArgs e)
        {
            TopicForm topic = new TopicForm();
            topic.ShowDialog();
            this.Close();
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
