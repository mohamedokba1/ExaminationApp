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
        public Admin_Dashboard()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void btn_mng_students_Click(object sender, EventArgs e)
        {
            StudentForm std_form= new StudentForm();
            std_form.ShowDialog();
            this.Close();
        }

        private void btn_mng_departments_Click(object sender, EventArgs e)
        {
            DepartmentForm dept = new DepartmentForm();
            dept.ShowDialog();
        }

        private void btn_mng_instructors_Click(object sender, EventArgs e)
        {
            InstructorForm instructor = new InstructorForm();
            instructor.ShowDialog();
        }

        private void btn_mng_exam_Click(object sender, EventArgs e)
        {
            ExamForm exam=new ExamForm();
            exam.ShowDialog();
        }
    }
}
