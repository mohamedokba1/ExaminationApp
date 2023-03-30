using ExaminationApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationApp
{
    public partial class CourseForm : Form
    {
        ExaminationDbContext DB = new ExaminationDbContext();
        private int Id = 0;
        private Admin_Dashboard adminPage;
        public CourseForm(Admin_Dashboard adminPage)
        {
            InitializeComponent();
            this.adminPage = adminPage;
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            var course = DB.Courses.FromSql($"getAllCourses").ToList();
            dgv_course.DataSource = course;

            cbx_topics.DataSource = DB.Topics.FromSql($"getAllTopics").ToList();
            cbx_topics.ValueMember = "TopicId";
            cbx_topics.DisplayMember = "TopicName";

            txt_duration.Text = "";
            txt_crs_name.Text = "";
            cbx_topics.SelectedValue = "";
        }

        private void btn_add_dept_Click(object sender, EventArgs e)
        {

            Id = DB.Courses.Max(c => c.CrsId);
            var affectedRows = DB.Database.ExecuteSql($"addCourse {Id + 100},{txt_crs_name.Text},{int.Parse(txt_duration.Text)}, {(int)cbx_topics.SelectedValue}");
            if (affectedRows > 0)
            {
                MessageBox.Show("Course Inserted Successfully", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.SaveChanges();
            }
            else
            {
                MessageBox.Show("Course couldn't be Inserted Unfortunatly", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            dgv_course.DataSource = DB.Courses.FromSql($"getAllCourses").ToList();

            txt_duration.Text = "";
            txt_crs_name.Text = "";
            cbx_topics.SelectedValue = "";
        }

        private void dgv_course_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = (int)dgv_course.SelectedRows[0].Cells[0].Value;
            txt_crs_name.Text = dgv_course.SelectedRows[0].Cells[1].Value.ToString();
            txt_duration.Text = dgv_course.SelectedRows[0].Cells[2].Value.ToString();
            cbx_topics.SelectedValue = dgv_course.SelectedRows[0].Cells[3].Value;
        }

        private void btn_update_dept_Click(object sender, EventArgs e)
        {
            Id = (int)dgv_course.SelectedRows[0].Cells[0].Value;

            var affectedRows = DB.Database.ExecuteSql($"updateCourse {Id},{txt_crs_name.Text},{int.Parse(txt_duration.Text)}, {(int)cbx_topics.SelectedValue}");
            if (affectedRows > 0)
            {
                MessageBox.Show("Course Updated Successfully", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.SaveChanges();
            }
            else
            {
                MessageBox.Show("Course couldn't be Updated Unfortunatly", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            dgv_course.DataSource = DB.Courses.FromSql($"getAllCourses").ToList();

            txt_duration.Text = "";
            txt_crs_name.Text = "";
            cbx_topics.SelectedValue = "";
        }

        private void btn_delete_dept_Click(object sender, EventArgs e)
        {
            Id = (int)dgv_course.SelectedRows[0].Cells[0].Value;

            var affectedRows = DB.Database.ExecuteSql($"deleteCourse {Id}");
            if (affectedRows > 0)
            {
                MessageBox.Show("Course Deleted Successfully", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.SaveChanges();
            }
            else
            {
                MessageBox.Show("Course couldn't be Deleted Unfortunatly", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            dgv_course.DataSource = DB.Courses.FromSql($"getAllCourses").ToList();

            txt_duration.Text = "";
            txt_crs_name.Text = "";
            cbx_topics.SelectedValue = "";
        }

        private void icon_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            adminPage.Show();
        }
    }
}
