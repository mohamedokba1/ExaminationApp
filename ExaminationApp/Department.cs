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
using Microsoft.EntityFrameworkCore;

namespace ExaminationApp
{

    public partial class DepartmentForm : Form
    {
        ExaminationDbContext DB = new ExaminationDbContext();
        private int Id = 0;
        private Admin_Dashboard adminPage;
        public DepartmentForm(Admin_Dashboard adminPage)
        {
            InitializeComponent();
            this.adminPage = adminPage;
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            var departments = DB.Departments.FromSql($"getAllDepartments").ToList();
            dgv_depts.DataSource = departments;

            txt_dept_name.Text = "";
        }

        private void btn_add_dept_Click(object sender, EventArgs e)
        {
            Id = DB.Departments.Max(x => x.DeptId);
            var affectedRows = DB.Database.ExecuteSql($"addDepartment {Id + 1},{txt_dept_name.Text}");
            if (affectedRows > 0)
            {
                MessageBox.Show("Department Inserted Successfully", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.SaveChanges();
            }
            else
            {
                MessageBox.Show("Department couldn't be Inserted Unfortunatly", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            dgv_depts.DataSource = DB.Departments.FromSql($"getAllDepartments").ToList();

            txt_dept_name.Text = "";
        }

        private void btn_update_dept_Click(object sender, EventArgs e)
        {
            var Id = (int)dgv_depts.SelectedRows[0].Cells[0].Value;

            var affectedRows = DB.Database.ExecuteSql($"updateDepartment {Id},{txt_dept_name.Text}");
            if (affectedRows > 0)
            {
                MessageBox.Show("Department Updated Successfully", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.SaveChanges();
            }
            else
            {
                MessageBox.Show("Department couldn't be Updated Unfortunatly", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            dgv_depts.DataSource = DB.Departments.FromSql($"getAllDepartments").ToList();

            txt_dept_name.Text = "";

        }

        private void dgv_depts_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = (int)dgv_depts.SelectedRows[0].Cells[0].Value;
            txt_dept_name.Text = dgv_depts.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btn_delete_dept_Click(object sender, EventArgs e)
        {
            var Id = (int)dgv_depts.SelectedRows[0].Cells[0].Value;

            var affectedRows = DB.Database.ExecuteSql($"deleteDepartment {Id}");
            if (affectedRows > 0)
            {
                MessageBox.Show("Department Deleted Successfully", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.SaveChanges();
            }
            else
            {
                MessageBox.Show("Department couldn't be Deleted Unfortunatly", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            dgv_depts.DataSource = DB.Departments.ToList();
            txt_dept_name.Text = "";

        }

        private void icon_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            adminPage.Show();   
        }
    }
}
