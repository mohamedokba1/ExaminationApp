﻿using ExaminationApp.Models;
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
    public partial class StudExamForm : Form
    {
        ExaminationDbContext DB = new ExaminationDbContext();
        private int StdId = 0;
        private int ExamId = 0;

        public StudExamForm()
        {
            InitializeComponent();
        }

        private void btn_back_home_Click(object sender, EventArgs e)
        {
            InstructorForm ins_Form = new InstructorForm();
            ins_Form.Show();
            this.Close();
        }

        private void StudExamForm_Load(object sender, EventArgs e)
        {
            var stdExam = DB.StudExams.FromSql($"getAllStudExam").ToList();
            dgv_StdExam.DataSource = stdExam;

            cb_exams.DataSource = DB.Exams.FromSql($"getAllExams").ToList();
            cb_exams.ValueMember = "ExamId";
            cb_exams.DisplayMember = "ExamId";

            cb_stds.DataSource = DB.Students.FromSql($"getAllStudents").ToList();
            cb_stds.ValueMember = "StdId";
            cb_stds.DisplayMember = "StdFname";

            txt_exam_date.Text = "";
            txt_status.Text = "";
            txt_st_score.Text = "";
            cb_exams.SelectedValue = "";
            cb_stds.SelectedValue = "";
        }

        private void btn_add_dept_Click(object sender, EventArgs e)
        {
            StdId = (int)cb_stds.SelectedValue;
            ExamId = (int)cb_exams.SelectedValue;

            var affectedRows = DB.Database.ExecuteSql($"addStudExam {StdId},{ExamId},{int.Parse(txt_st_score.Text)},{DateTime.Parse(txt_exam_date.Text)},{txt_status.Text}");
            if (affectedRows > 0)
            {
                MessageBox.Show("Student Exam Inserted Successfully", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.SaveChanges();
            }
            else
            {
                MessageBox.Show("Student Exam couldn't be Inserted Unfortunatly", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            dgv_StdExam.DataSource = DB.StudExams.FromSql($"getAllStudExam").ToList();

            txt_exam_date.Text = "";
            txt_status.Text = "";
            txt_st_score.Text = "";
            cb_exams.SelectedValue = "";
            cb_stds.SelectedValue = "";
        }

        private void dgv_StdExam_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            StdId = (int)dgv_StdExam.SelectedRows[0].Cells[0].Value;
            ExamId = (int)dgv_StdExam.SelectedRows[0].Cells[1].Value;
            txt_st_score.Text = dgv_StdExam.SelectedRows[0].Cells[2].Value.ToString();
            txt_exam_date.Text = dgv_StdExam.SelectedRows[0].Cells[3].Value.ToString();
            txt_status.Text = dgv_StdExam.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btn_update_dept_Click(object sender, EventArgs e)
        {
            StdId = (int)dgv_StdExam.SelectedRows[0].Cells[0].Value;
            ExamId = (int)dgv_StdExam.SelectedRows[0].Cells[1].Value;
            var affectedRows = DB.Database.ExecuteSql($"updateStudExam {StdId},{ExamId},{int.Parse(txt_st_score.Text)},{DateTime.Parse(txt_exam_date.Text)},{txt_status.Text}");
            if (affectedRows > 0)
            {
                MessageBox.Show("Student Exam Updated Successfully", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.SaveChanges();
            }
            else
            {
                MessageBox.Show("Student Exam couldn't be Updated Unfortunatly", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            dgv_StdExam.DataSource = DB.StudExams.FromSql($"getAllStudExam").ToList();

            txt_exam_date.Text = "";
            txt_status.Text = "";
            txt_st_score.Text = "";
            cb_exams.SelectedValue = "";
            cb_stds.SelectedValue = "";
        }

        private void btn_delete_dept_Click(object sender, EventArgs e)
        {
            StdId = (int)dgv_StdExam.SelectedRows[0].Cells[0].Value;
            ExamId = (int)dgv_StdExam.SelectedRows[0].Cells[1].Value;
            var affectedRows = DB.Database.ExecuteSql($"deleteStudExam {StdId},{ExamId}");
            if (affectedRows > 0)
            {
                MessageBox.Show("Student Exam Deleted Successfully", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.SaveChanges();
            }
            else
            {
                MessageBox.Show("Student Exam couldn't be Deleted Unfortunatly", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            dgv_StdExam.DataSource = DB.StudExams.ToList();

            txt_exam_date.Text = "";
            txt_status.Text = "";
            txt_st_score.Text = "";
            cb_exams.SelectedValue = "";
            cb_stds.SelectedValue = "";
        }

        private void icon_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
