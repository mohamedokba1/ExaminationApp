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
    public partial class ExamForm : Form
    {
        ExaminationDbContext DB = new ExaminationDbContext();
        private int Id = 0;
        private Admin_Dashboard adminPage;
        public ExamForm(Admin_Dashboard adminPage)
        {
            InitializeComponent();
            this.adminPage = adminPage;
        }
        private void ExamForm_Load(object sender, EventArgs e)
        {
            var exam = DB.Exams.FromSql($"getAllExams").ToList();
            dgv_Exam.DataSource = exam;

            cbx_courses.DataSource = DB.Courses.FromSql($"getAllCourses").ToList();
            cbx_courses.ValueMember = "CrsId";
            cbx_courses.DisplayMember = "CrsName";

            txt_duration.Text = "";
            txt_pass_score.Text = "";
            cbx_courses.SelectedValue = "";
        }

        private void btn_add_dept_Click(object sender, EventArgs e)
        {
            Id = DB.Exams.Max(e => e.ExamId);
            var affectedRows = DB.Database.ExecuteSql($"addExam {Id + 100},{int.Parse(txt_pass_score.Text)},{int.Parse(txt_duration.Text)}, {(int)cbx_courses.SelectedValue}");
            if (affectedRows > 0)
            {
                MessageBox.Show("Exam Inserted Successfully", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.SaveChanges();
            }
            else
            {
                MessageBox.Show("Exam couldn't be Inserted Unfortunatly", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            dgv_Exam.DataSource = DB.Exams.FromSql($"getAllExams").ToList();

            txt_duration.Text = "";
            txt_pass_score.Text = "";
            cbx_courses.SelectedValue = "";
        }

        private void dgv_Exam_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = (int)dgv_Exam.SelectedRows[0].Cells[0].Value;
            txt_pass_score.Text = dgv_Exam.SelectedRows[0].Cells[1].Value.ToString();
            txt_duration.Text = dgv_Exam.SelectedRows[0].Cells[2].Value.ToString();
            cbx_courses.SelectedValue = dgv_Exam.SelectedRows[0].Cells[3].Value;
        }

        private void btn_update_dept_Click(object sender, EventArgs e)
        {
            Id = (int)dgv_Exam.SelectedRows[0].Cells[0].Value;
            var affectedRows = DB.Database.ExecuteSql($"updateExam {Id},{int.Parse(txt_pass_score.Text)},{int.Parse(txt_duration.Text)}, {(int)cbx_courses.SelectedValue}");
            if (affectedRows > 0)
            {
                MessageBox.Show("Exam Updated Successfully", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.SaveChanges();
            }
            else
            {
                MessageBox.Show("Exam couldn't be Updated Unfortunatly", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            dgv_Exam.DataSource = DB.Exams.FromSql($"getAllExams").ToList();

            txt_duration.Text = "";
            txt_pass_score.Text = "";
            cbx_courses.SelectedValue = "";
        }

        private void btn_delete_dept_Click(object sender, EventArgs e)
        {
            Id = (int)dgv_Exam.SelectedRows[0].Cells[0].Value;
            var affectedRows = DB.Database.ExecuteSql($"deleteExam {Id}");
            if (affectedRows > 0)
            {
                MessageBox.Show("Exam Deleted Successfully", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.SaveChanges();
            }
            else
            {
                MessageBox.Show("Exam couldn't be Deleted Unfortunatly", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            dgv_Exam.DataSource = DB.Exams.FromSql($"getAllExams").ToList();

            txt_duration.Text = "";
            txt_pass_score.Text = "";
            cbx_courses.SelectedValue = "";
        }

        private void icon_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            adminPage.Show();
        }
    }
}
