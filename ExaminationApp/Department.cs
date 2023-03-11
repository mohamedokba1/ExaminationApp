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

    public partial class DepartmentForm : Form
    {
        ExaminationDbContext DB = new ExaminationDbContext();
        private int Id = 0;
        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            var departments = DB.Departments.ToList();
            dgv_depts.DataSource = departments;

            txt_dept_name.Text = "";
        }

        private void btn_add_dept_Click(object sender, EventArgs e)
        {
            var department = new Department();
            Id = DB.Departments.Max(x => x.DeptId);
            department.DeptId = Id+1;
            department.DeptName = txt_dept_name.Text;

            DB.Departments.Add(department);
            DB.SaveChanges();
            dgv_depts.DataSource = DB.Departments.ToList();

            txt_dept_name.Text = "";
        }

        private void btn_update_dept_Click(object sender, EventArgs e)
        {
            var Id = (int)dgv_depts.SelectedRows[0].Cells[0].Value;

            var department = DB.Departments.Where(d=>d.DeptId==Id).FirstOrDefault();
            department.DeptName = txt_dept_name.Text;

            DB.Departments.Update(department);
            DB.SaveChanges();
            dgv_depts.DataSource = DB.Departments.ToList();

            txt_dept_name.Text = "";

        }

        private void dgv_depts_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id=  (int)dgv_depts.SelectedRows[0].Cells[0].Value;
            txt_dept_name.Text = dgv_depts.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btn_delete_dept_Click(object sender, EventArgs e)
        {
            var department = DB.Departments.FirstOrDefault(d => d.DeptId == Id);
            DB.Remove(department);
            DB.SaveChanges();
            dgv_depts.DataSource = DB.Departments.ToList();
            txt_dept_name.Text = "";

        }

        private void btn_back_home_Click(object sender, EventArgs e)
        {
            Admin_Dashboard admin_form = new Admin_Dashboard();
            admin_form.Show();
            this.Close();
        }
    }
}
