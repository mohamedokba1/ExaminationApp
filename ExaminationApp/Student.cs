using ExaminationApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.EntityFrameworkCore;

namespace ExaminationApp
{
    public partial class StudentForm : Form
    {
        ExaminationDbContext DB = new ExaminationDbContext();
        private int Id = 0;
        public StudentForm()
        {
            InitializeComponent();
        }
        public static List<Student>? AddStudentsFromSql(ExaminationDbContext context, string fname,string lname,int age, string address, string email, string password , int deptid)
        {
            return context?.Students?.FromSql($"addStudent {fname},{lname},{age},{address},{email},{password},{deptid}").ToList();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            var departments = DB.Departments.ToList();
            var Students = DB.Students.ToList();
            dgv_students.DataSource = Students;

            cb_depts.DataSource = departments;
            cb_depts.ValueMember = "DeptId";
            cb_depts.DisplayMember = "DeptName";

            txt_std_lname.Text = "";
            txt_std_fname.Text = "";
            txt_std_age.Text = "";
            txt_std_address.Text = "";
            txt_std_email.Text = "";
            txt_std_password.Text = "";
        }

        private void btn_add_student_Click(object sender, EventArgs e)
        {
            var x = DB.Students
                      .FromSql($"AddStudent {txt_std_fname.Text},{txt_std_lname.Text}, {int.Parse(txt_std_age.Text)}, {txt_std_address.Text},{ txt_std_email.Text},{ txt_std_password.Text}, {(int)cb_depts.SelectedValue}")
                                             .ToList();
            //    var student = new Student();
            //student.StdFname = txt_std_fname.Text;
            //student.StdLname = txt_std_lname.Text;
            //student.StdAge = int.Parse(txt_std_age.Text);
            //student.StdAddress = txt_std_address.Text;
            //student.StdEmail = txt_std_email.Text;
            //student.StdPassword = txt_std_password.Text;
            //student.DeptId=(int)cb_depts.SelectedValue;
            //DB.Students.Add(student);
            DB.SaveChanges();
            dgv_students.DataSource = DB.Students.ToList();
            cb_depts.DataSource = DB.Departments.ToList();

            txt_std_lname.Text = "";
            txt_std_fname.Text = "";
            txt_std_age.Text = "";
            txt_std_address.Text = "";
            txt_std_email.Text = "";
            txt_std_password.Text = "";
        }

        private void btn_update_student_Click(object sender, EventArgs e)
        {
            var Id = (int)dgv_students.SelectedRows[0].Cells[0].Value;

            var student = DB.Students.Where(s => s.StdId == Id).FirstOrDefault();
            student.StdFname = txt_std_fname.Text;
            student.StdLname = txt_std_lname.Text;
            student.StdAge = int.Parse(txt_std_age.Text);
            student.StdAddress = txt_std_address.Text;
            student.StdEmail = txt_std_email.Text;
            student.StdPassword = txt_std_password.Text;
            student.DeptId = (int)cb_depts.SelectedValue;

            DB.Students.Update(student);
            DB.SaveChanges();
            dgv_students.DataSource = DB.Students.ToList();

            txt_std_lname.Text = "";
            txt_std_fname.Text = "";
            txt_std_age.Text = "";
            txt_std_address.Text = "";
            txt_std_email.Text = "";
            txt_std_password.Text = "";
        }

        private void dgv_students_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = (int)dgv_students.SelectedRows[0].Cells[0].Value;
            txt_std_fname.Text = dgv_students.SelectedRows[0].Cells[1].Value.ToString();
            txt_std_lname.Text = dgv_students.SelectedRows[0].Cells[2].Value.ToString();
            txt_std_age.Text = dgv_students.SelectedRows[0].Cells[3].Value.ToString();
            txt_std_address.Text = dgv_students.SelectedRows[0].Cells[4].Value.ToString();
            txt_std_email.Text = dgv_students.SelectedRows[0].Cells[5].Value.ToString();
            txt_std_password.Text = dgv_students.SelectedRows[0].Cells[6].Value.ToString();
            cb_depts.SelectedValue = dgv_students.SelectedRows[0].Cells[7].Value ;
        }

        private void btn_delete_student_Click(object sender, EventArgs e)
        {
            var student = DB.Students.FirstOrDefault(s => s.StdId == Id);
            DB.Remove(student);
            DB.SaveChanges();
            dgv_students.DataSource = DB.Students.ToList();

            txt_std_lname.Text = "";
            txt_std_fname.Text = "";
            txt_std_age.Text = "";
            txt_std_address.Text = "";
            txt_std_email.Text = "";
            txt_std_password.Text = "";
        }

        private void btn_back_home_Click(object sender, EventArgs e)
        {
            Admin_Dashboard admin_form = new Admin_Dashboard();
            admin_form.Show();
            this.Close();
        }
    }
}
