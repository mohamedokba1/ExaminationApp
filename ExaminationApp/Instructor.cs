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
    public partial class InstructorForm : Form
    {
        ExaminationDbContext DB=new ExaminationDbContext();
        private int Id = 0;
        public InstructorForm()
        {
            InitializeComponent();
        }

        private void Instructor_Load(object sender, EventArgs e)
        {
            var instructor=DB.Instructors.ToList();
            dgv_instructors.DataSource = instructor;

            cb_depts.DataSource = DB.Departments.ToList();
            cb_depts.ValueMember = "DeptId";
            cb_depts.DisplayMember = "DeptName";

            txt_insName.Text = "";
            txt_ins_email.Text = "";
            txt_ins_password.Text = "";
            cb_depts.SelectedValue = "";
        }

        private void btn_add_ins_Click(object sender, EventArgs e)
        {
            var instructor = new Instructor();
            instructor.InsName = txt_insName.Text;
            instructor.InsEmail=txt_ins_email.Text;
            instructor.InsPassword=txt_ins_password.Text;
            instructor.DeptId = (int)cb_depts.SelectedValue;

            DB.Instructors.Add(instructor);
            DB.SaveChanges();
            dgv_instructors.DataSource = DB.Instructors.ToList();
            cb_depts.DataSource = DB.Departments.ToList();

            txt_insName.Text = "";
            txt_ins_email.Text = "";
            txt_ins_password.Text = "";
            cb_depts.SelectedValue = "";

        }

        private void dgv_instructors_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = (int)dgv_instructors.SelectedRows[0].Cells[0].Value;
            txt_insName.Text = dgv_instructors.SelectedRows[0].Cells[1].Value.ToString();
            txt_ins_email.Text = dgv_instructors.SelectedRows[0].Cells[2].Value.ToString();
            txt_ins_password.Text = dgv_instructors.SelectedRows[0].Cells[3].Value.ToString();
            cb_depts.SelectedValue = (int)dgv_instructors.SelectedRows[0].Cells[4].Value;
        }

        private void btn_update_ins_Click(object sender, EventArgs e)
        {
            Id = (int)dgv_instructors.SelectedRows[0].Cells[0].Value;

            var instructor = DB.Instructors.Where(i=>i.InsId == Id).FirstOrDefault();
            instructor.InsName = txt_insName.Text;
            instructor.InsEmail = txt_ins_email.Text;
            instructor.InsPassword = txt_ins_password.Text;
            instructor.DeptId = (int)cb_depts.SelectedValue;

            DB.Instructors.Update(instructor);
            DB.SaveChanges();
            dgv_instructors.DataSource = DB.Instructors.ToList();

            txt_insName.Text = "";
            txt_ins_email.Text = "";
            txt_ins_password.Text = "";
            cb_depts.SelectedValue = "";
        }

        private void btn_delete_ins_Click(object sender, EventArgs e)
        {
            var instructor = DB.Instructors.FirstOrDefault(i => i.InsId == Id);
            DB.Remove(instructor);
            DB.SaveChanges();
            dgv_instructors.DataSource = DB.Instructors.ToList();

            txt_insName.Text = "";
            txt_ins_email.Text = "";
            txt_ins_password.Text = "";
            cb_depts.SelectedValue = "";
        }

        private void btn_back_home_Click(object sender, EventArgs e)
        {
            Admin_Dashboard admin_form = new Admin_Dashboard();
            admin_form.Show();
            this.Close();
        }
    }
}
