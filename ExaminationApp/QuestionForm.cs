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
    public partial class QuestionForm : Form
    {
        ExaminationDbContext DB = new ExaminationDbContext();
        private int Id = 0;
        private Instructor_Dashboard insScreen;
        private string insName;
        public QuestionForm(Instructor_Dashboard insScreen, string insName)
        {
            InitializeComponent();
            this.insScreen = insScreen;
            this.insName = insName;
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {
            dgv_ques.DataSource = DB.Questions.FromSql($"getAllQuestions").ToList();

            cb_courses.DataSource = DB.Courses.FromSql($"getAllCourses").ToList();
            cb_courses.ValueMember = "CrsId";
            cb_courses.DisplayMember = "CrsName";

            cb_questype.DataSource = DB.Questions.Select(q => q.QuesType).Distinct().ToList();

            cbx_correct_answer.SelectedText = "-- Select Correct Answer --";
            cbx_correct_answer.Items.Add("a");
            cbx_correct_answer.Items.Add("b");
            cbx_correct_answer.Items.Add("c");
        }

        private void icon_close_Click(object sender, EventArgs e)
        {
            this.Close();
            insScreen.Show();
        }

        private void dgv_ques_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = (int)dgv_ques.SelectedRows[0].Cells[0].Value;
            rtx_question_body.Text = dgv_ques.SelectedRows[0].Cells[1].Value.ToString();
            cb_questype.SelectedItem = dgv_ques.SelectedRows[0].Cells[2].Value.ToString();
            cbx_correct_answer.SelectedItem = dgv_ques.SelectedRows[0].Cells[3].Value.ToString();
            txt_mark.Text = dgv_ques.SelectedRows[0].Cells[4].Value.ToString();
            cb_courses.SelectedItem = dgv_ques.SelectedRows[0].Cells[5].Value.ToString();
            txt_choice_a.Text = dgv_ques.SelectedRows[0].Cells[6].Value.ToString();
            txt_choice_b.Text = dgv_ques.SelectedRows[0].Cells[7].Value.ToString();
            txt_choice_c.Text = dgv_ques.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void btn_add_question_Click(object sender, EventArgs e)
        {
            Id = DB.Questions.Max(q => q.QuesId);
            var correctAnswer = "";
            if (cbx_correct_answer.SelectedItem.ToString() == "a")
            {
                correctAnswer = txt_choice_a.Text;
            }
            else if (cbx_correct_answer.SelectedItem.ToString() == "b")
            {
                correctAnswer = txt_choice_b.Text;
            }
            else
            {
                correctAnswer = txt_choice_c.Text;
            }
            var affectedRows = DB.Database.ExecuteSql($"addQuestion {Id + 10},{rtx_question_body.Text},{cb_questype.SelectedValue.ToString()}, {correctAnswer},{int.Parse(txt_mark.Text)},{(int)cb_courses.SelectedValue},{txt_choice_a.Text},{txt_choice_b.Text},{txt_choice_c.Text}");
            if (affectedRows > 0)
            {
                MessageBox.Show("Question Inserted Successfully", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.SaveChanges();
            }
            else
            {
                MessageBox.Show("Question couldn't be Inserted Unfortunatly", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            dgv_ques.DataSource = DB.Questions.FromSql($"getAllQuestions").ToList();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Id = (int)dgv_ques.SelectedRows[0].Cells[0].Value;
            var correctAnswer = "";
            if (cbx_correct_answer.SelectedItem.ToString() == "a")
            {
                correctAnswer = txt_choice_a.Text;
            }
            else if (cbx_correct_answer.SelectedItem.ToString() == "b")
            {
                correctAnswer = txt_choice_b.Text;
            }
            else
            {
                correctAnswer = txt_choice_c.Text;
            }

            var affectedRows = DB.Database.ExecuteSql($"updateQuestion {Id},{rtx_question_body.Text},{cb_questype.SelectedValue.ToString()}, {correctAnswer},{int.Parse(txt_mark.Text)},{(int)cb_courses.SelectedValue},{txt_choice_a.Text},{txt_choice_b.Text},{txt_choice_c.Text}");
            if (affectedRows > 0)
            {
                MessageBox.Show("Question Updated Successfully", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.SaveChanges();
            }
            else
            {
                MessageBox.Show("Question couldn't be Updated Unfortunatly", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            dgv_ques.DataSource = DB.Questions.FromSql($"getAllQuestions").ToList();


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Id = (int)dgv_ques.SelectedRows[0].Cells[0].Value;

            var affectedRows = DB.Database.ExecuteSql($"deleteQuestion {Id}");
            if (affectedRows > 0)
            {
                MessageBox.Show("Question Deleted Successfully", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.SaveChanges();
            }
            else
            {
                MessageBox.Show("Question couldn't be Deleted Unfortunatly", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            dgv_ques.DataSource = DB.Questions.FromSql($"getAllQuestions").ToList();

        }

        private void cb_questype_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (cb_questype.SelectedItem.ToString() == "MCQ")
            {
                lbl_choice_c.Visible = true;
                txt_choice_c.Visible = true;
            }
            else if (cb_questype.SelectedItem.ToString() == "TorF")
            {
                lbl_choice_c.Visible = false;
                txt_choice_c.Visible = false;
                cbx_correct_answer.Items.Remove("c");
            }
        }
    }
}
