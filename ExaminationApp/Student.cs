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
        private Admin_Dashboard adminPage;
        public StudentForm(Admin_Dashboard adminPage)
        {
            InitializeComponent();
            this.adminPage = adminPage;
        }


        private void Student_Load(object sender, EventArgs e)
        {
            var Students = DB.Students.FromSql($"getAllStudents").ToList();
            dgv_students.DataSource = Students;

            var departments = DB.Departments.FromSql($"getAllDepartments").ToList();
            cb_depts.DataSource = departments;
            cb_depts.ValueMember = "DeptId";
            cb_depts.DisplayMember = "DeptName";

            dgv_students.Columns[0].Visible = false;
            dgv_students.Columns[7].Visible = false;
            dgv_students.Columns[8].Visible = false;

            txt_std_lname.Text = "";
            txt_std_fname.Text = "";
            txt_std_age.Text = "";
            txt_std_address.Text = "";
            txt_std_email.Text = "";
            txt_std_password.Text = "";
            chk_std_user.Checked = false;
        }

        private void btn_add_student_Click(object sender, EventArgs e)
         {

            var affectedRows = DB.Database.ExecuteSql($"addStudent {txt_std_fname.Text},{txt_std_lname.Text}, {int.Parse(txt_std_age.Text)}, {txt_std_address.Text},{txt_std_email.Text},{txt_std_password.Text}, {(int)cb_depts.SelectedValue}");
            if (affectedRows > 0)
            {
                if (chk_std_user.Checked == true)
                {
                    DB.Database.ExecuteSql($"addUser {txt_std_email.Text}, {txt_std_password.Text}, {"student"}");
                }
                MessageBox.Show("Student Inserted Successfully", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.SaveChanges();
            }
            else
            {
                MessageBox.Show("Student couldn't be Inserted Unfortunatly", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            dgv_students.DataSource = DB.Students.FromSql($"getAllStudents").ToList(); ;
            cb_depts.DataSource = DB.Departments.FromSql($"getAllDepartments").ToList();
            txt_std_lname.Text = "";
            txt_std_fname.Text = "";
            txt_std_age.Text = "";
            txt_std_address.Text = "";
            txt_std_email.Text = "";
            txt_std_password.Text = "";
            chk_std_user.Checked = false;
        }

        private void btn_update_student_Click(object sender, EventArgs e)
        {
            var Id = (int)dgv_students.SelectedRows[0].Cells[0].Value;
            var affectedRows = DB.Database.ExecuteSql($"updateStudent {Id},{txt_std_fname.Text},{txt_std_lname.Text}, {int.Parse(txt_std_age.Text)}, {txt_std_address.Text},{txt_std_email.Text},{txt_std_password.Text}, {(int)cb_depts.SelectedValue}");
            if (affectedRows > 0)
            {
                if (chk_std_user.Checked == true)
                {
                    DB.Database.ExecuteSql($"addUser {txt_std_email.Text}, {txt_std_password.Text}, {"student"}");
                }
                MessageBox.Show("Student Updated Successfully", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.SaveChanges();
            }
            else
            {
                MessageBox.Show("Student couldn't be Updated Unfortunatly", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            dgv_students.DataSource = DB.Students.FromSql($"getAllStudents").ToList(); ;
            cb_depts.DataSource = DB.Departments.FromSql($"getAllDepartments").ToList();
            txt_std_lname.Text = "";
            txt_std_fname.Text = "";
            txt_std_age.Text = "";
            txt_std_address.Text = "";
            txt_std_email.Text = "";
            txt_std_password.Text = "";
            chk_std_user.Checked = false;

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
            cb_depts.SelectedValue = dgv_students.SelectedRows[0].Cells[7].Value;
            var userEmail = DB.Users.Where(user => user.UserEmail == txt_std_email.Text).FirstOrDefault();
            if (userEmail != null)
            {
                chk_std_user.Checked = true;
            }
        }

        private void btn_delete_student_Click(object sender, EventArgs e)
        {
            var Id = (int)dgv_students.SelectedRows[0].Cells[0].Value;
            var affectedRows = DB.Database.ExecuteSql($"deleteStudentByID {Id}");
            int deletedrow = DB.Database.ExecuteSql($"deleteUser {txt_std_email.Text}");
            if (affectedRows > 0)
            {
                MessageBox.Show("Student Deleted Successfully", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.SaveChanges();
            }
            else
            {
                MessageBox.Show("Student couldn't be Deleted Unfortunatly", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            dgv_students.DataSource = DB.Students.FromSql($"getAllStudents").ToList(); ;
            cb_depts.DataSource = DB.Departments.FromSql($"getAllDepartments").ToList();

            txt_std_lname.Text = "";
            txt_std_fname.Text = "";
            txt_std_age.Text = "";
            txt_std_address.Text = "";
            txt_std_email.Text = "";
            txt_std_password.Text = "";
            chk_std_user.Checked = false;

        }
        private void icon_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            adminPage.Show();
        }
    }
}
