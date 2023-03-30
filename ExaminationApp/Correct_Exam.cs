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
    public partial class Correct_Exam : Form
    {
        ExaminationDbContext DB = new ExaminationDbContext();
        private Instructor_Dashboard insPage;
        private int ExamId;
        private int St_Id;
        public Correct_Exam(Instructor_Dashboard insPage)
        {
            InitializeComponent();
            this.insPage = insPage;
        }

        private void icon_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            insPage.Show();
        }

        private void Correct_Exam_Load(object sender, EventArgs e)
        {
            var students = DB.Students.FromSql($"getAllStudents").ToList();
            var stds = DB.Students.Select(std => new
            {
                stdId = std.StdId,
                stdName = std.StdFname + " " + std.StdLname,
            }).ToList();
            cbx_std_ids.DataSource = stds;
            cbx_std_ids.ValueMember = "stdId";
            cbx_std_ids.DisplayMember = "stdName";

        }

        private void cbx_std_ids_SelectedValueChanged(object sender, EventArgs e)
        {
            St_Id = DB.Students.Where(s => (s.StdFname + " " + s.StdLname) == cbx_std_ids.Text.ToString()).Select(s => s.StdId).FirstOrDefault();
            cbx_exam_ids.DataSource = DB.StudExams.Where(s => s.StId == St_Id).ToList();
            cbx_exam_ids.ValueMember = "ExamId";
            cbx_exam_ids.DisplayMember = "ExamId";
        }

        private void btn_correct_Click(object sender, EventArgs e)
        {
            St_Id = DB.Students.Where(s => (s.StdFname + " " + s.StdLname) == cbx_std_ids.Text.ToString()).Select(s => s.StdId).FirstOrDefault();
            ExamId = DB.StudExams.Where(s => (s.StId) == St_Id).Select(s => s.ExamId).FirstOrDefault(); ;
            var rowAffected = DB.Database.ExecuteSql($"correctAnswer {ExamId}, {St_Id}");
            if (rowAffected > 0)
            {
                string stdScore = DB.StudExams.Where(std => std.StId == St_Id && std.ExamId == ExamId).Select(std => std.StScore).ToString();
                MessageBox.Show($"Result = {stdScore}%", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
