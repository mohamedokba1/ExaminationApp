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
    public partial class Exam_Screen : Form
    {
        ExaminationDbContext DB = new ExaminationDbContext();
        List<Question> questions;
        private string StdFname;
        private string Crs_Name;
        private int currentQuestionIndex = 0;
        private DateTime examDate;
        private int Id = 0;

        public Exam_Screen(string stdFname, string crs_Name)
        {
            InitializeComponent();
            StdFname = stdFname;
            Crs_Name = crs_Name;
            var student = DB.Students.Where(s => s.StdFname == StdFname).Select(s => s.StdId).FirstOrDefault();
        }
        private void DisplayQuestion(Question question)
        {
            var course = DB.Courses.Where(c => c.CrsName == Crs_Name).Select(c => c.CrsId).FirstOrDefault();
            var duration = DB.Exams.Where(c => c.CrsId == course).Select(e => e.ExamDuration).FirstOrDefault();

            lbl_question.Text = question.QuesBody;
            lbl_ex_date.Text = DateTime.Now.ToString();
            lbl_course_name.Text = Crs_Name;
            lbl_duration.Text = duration.ToString();

            cb_choice1.Text = question.ChoiceA;
            cb_choice2.Text = question.ChoiceB;
            if (question.QuesType == "TorF")
            {
                cb_choice3.Visible = false;
            }
            else
            {
                cb_choice3.Text = question.ChoiceC;
            }
            cb_choice1.Checked = false;
            cb_choice2.Checked = false;
            cb_choice3.Checked = false;
        }

        private void Exam_Screen_Load(object sender, EventArgs e)
        {
            lbl_ex_date.Text = DateTime.Now.ToString();
            var course = DB.Courses.Where(c => c.CrsName == Crs_Name).Select(c => c.CrsId).FirstOrDefault();
            var Exam = DB.Exams.Where(e => e.CrsId == course).Select(e => e.ExamId).FirstOrDefault();
            questions = DB.Questions.Where(q => q.CrsId == course).ToList();

            if (questions.Count > 0 && currentQuestionIndex >= 0 && currentQuestionIndex < questions.Count)
            {
                DisplayQuestion(questions[currentQuestionIndex]);
            }
            icon_back.Visible = false;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Id = DB.StdAnswers.Max(s => s.AnsId) + 10;
            var student = DB.Students.Where(s => s.StdFname == StdFname).Select(s => s.StdId).FirstOrDefault();
            var course = DB.Courses.Where(c => c.CrsName == Crs_Name).Select(c => c.CrsId).FirstOrDefault();
            var Exam = DB.Exams.Where(e => e.CrsId == course).Select(e => e.ExamId).FirstOrDefault();
            var Ques = DB.Questions.Where(q => q.CrsId == course).Select(q => q.QuesId).FirstOrDefault();
            var ExamInfo = DB.Questions.Where(q => q.CrsId == course).ToList();

            var Answer = "";
            if (cb_choice1.Checked)
            {
                Answer = cb_choice1.Text;
            }
            else if (cb_choice2.Checked)
            {
                Answer = cb_choice2.Text;
            }
            else if (cb_choice3.Checked)
            {
                Answer = cb_choice3.Text;
            }

            var affectedRows = DB.Database.ExecuteSql($"addStudAnswer {Id},{(int)student},{(int)Ques},{(int)Exam},{Answer.ToString()}");
            if (affectedRows > 0)
            {
                MessageBox.Show("Answer Inserted Successfully", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.SaveChanges();

                currentQuestionIndex++;
                if (questions.Count > 0 && currentQuestionIndex >= 0 && currentQuestionIndex < questions.Count)
                {
                    DisplayQuestion(questions[currentQuestionIndex]);
                }
                else
                {
                    lbl_exam_date.Visible = false;
                    lbl_course_name.Visible = false;
                    lbl_duration.Visible = false;
                    cb_choice1.Visible = false;
                    cb_choice2.Visible = false;
                    cb_choice3.Visible = false;
                    btn_next.Visible = false;
                    icon_back.Visible = true;
                    lbl_question.Text = "Exam Ended... \n \t\t\t\t\t Best Wishes :)";

                }
            }
            else
            {
                MessageBox.Show("Answer couldn't be Inserted Unfortunatly", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void icon_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
