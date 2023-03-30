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
    public partial class InstructorForm : Form
    {
        ExaminationDbContext DB = new ExaminationDbContext();
        private int Id = 0;
        private Admin_Dashboard adminPage;
        public InstructorForm(Admin_Dashboard adminPage)
        {
            InitializeComponent();
            this.adminPage = adminPage;
        }

        private void Instructor_Load(object sender, EventArgs e)
        {
            var instructor = DB.Instructors.FromSql($"getAllInstructors").ToList();
            dgv_instructors.DataSource = instructor;

            dgv_instructors.Columns[0].Visible = false;
            dgv_instructors.Columns[5].Visible = false;
            dgv_instructors.Columns[6].Visible = false;

            cb_depts.DataSource = DB.Departments.FromSql($"getAllDepartments").ToList();
            cb_depts.ValueMember = "DeptId";
            cb_depts.DisplayMember = "DeptName";

            txt_insName.Text = "";
            txt_ins_email.Text = "";
            txt_ins_password.Text = "";
            cb_depts.SelectedValue = "";

            chk_ins_user.Checked = false;
        }

        private void btn_add_ins_Click(object sender, EventArgs e)
        {
            var affectedRows = DB.Database.ExecuteSql($"addInstructor {txt_insName.Text},{txt_ins_email.Text}, {txt_ins_password.Text}, {(int)cb_depts.SelectedValue}");
            if (affectedRows > 0)
            {
                if (chk_ins_user.Checked == true)
                {
                    DB.Database.ExecuteSql($"addUser {txt_ins_email.Text}, {txt_ins_password.Text}, {"instructor"}");
                }
                MessageBox.Show("Instructor Inserted Successfully", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.SaveChanges();
            }
            else
            {
                MessageBox.Show("Instructor couldn't be Inserted Unfortunatly", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            dgv_instructors.DataSource = DB.Instructors.FromSql($"getAllInstructors").ToList();
            cb_depts.DataSource = DB.Departments.FromSql($"getAllDepartments").ToList();

            txt_insName.Text = "";
            txt_ins_email.Text = "";
            txt_ins_password.Text = "";
            cb_depts.SelectedValue = "";
            chk_ins_user.Checked = false;

        }

        private void dgv_instructors_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = (int)dgv_instructors.SelectedRows[0].Cells[0].Value;
            txt_insName.Text = dgv_instructors.SelectedRows[0].Cells[1].Value.ToString();
            txt_ins_email.Text = dgv_instructors.SelectedRows[0].Cells[2].Value.ToString();
            txt_ins_password.Text = dgv_instructors.SelectedRows[0].Cells[3].Value.ToString();
            cb_depts.SelectedValue = (int)dgv_instructors.SelectedRows[0].Cells[4].Value;
            var userEmail = DB.Users.Where(user => user.UserEmail == txt_ins_email.Text).FirstOrDefault();
            if (userEmail != null)
            {
                chk_ins_user.Checked = true;
            }
        }

        private void btn_update_ins_Click(object sender, EventArgs e)
        {
            Id = (int)dgv_instructors.SelectedRows[0].Cells[0].Value;
            var affectedRows = DB.Database.ExecuteSql($"updateInstructor {Id},{txt_insName.Text},{txt_ins_email.Text}, {txt_ins_password.Text}, {(int)cb_depts.SelectedValue}");
            if (affectedRows > 0)
            {
                if (chk_ins_user.Checked == true)
                {
                    DB.Database.ExecuteSql($"addUser {txt_ins_email.Text}, {txt_ins_password.Text}, {"instructor"}");
                }
                MessageBox.Show("Instructor Updated Successfully", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.SaveChanges();
            }
            else
            {
                MessageBox.Show("Instructor couldn't be Updated Unfortunatly", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            dgv_instructors.DataSource = DB.Instructors.FromSql($"getAllInstructors").ToList();
            cb_depts.DataSource = DB.Departments.FromSql($"getAllDepartments").ToList();
            txt_insName.Text = "";
            txt_ins_email.Text = "";
            txt_ins_password.Text = "";
            cb_depts.SelectedValue = "";
            chk_ins_user.Checked = false;
        }

        private void btn_delete_ins_Click(object sender, EventArgs e)
        {
            var affectedRows = DB.Database.ExecuteSql($"deleteInstructor {Id}");
            int deletedrow = DB.Database.ExecuteSql($"deleteUser {txt_ins_email}");
            if (affectedRows > 0 && deletedrow > 0)
            {
                MessageBox.Show("Instructor Deleted Successfully", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.SaveChanges();
            }
            else
            {
                MessageBox.Show("Instructor couldn't be Deleted Unfortunatly", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            dgv_instructors.DataSource = DB.Instructors.FromSql($"getAllInstructors").ToList();
            cb_depts.DataSource = DB.Departments.FromSql($"getAllDepartments").ToList();

            txt_insName.Text = "";
            txt_ins_email.Text = "";
            txt_ins_password.Text = "";
            cb_depts.SelectedValue = "";
            chk_ins_user.Checked = false;

        }

        private void icon_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            adminPage.Show();
        }
    }
}
