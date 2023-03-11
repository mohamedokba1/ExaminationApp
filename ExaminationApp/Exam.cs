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
    public partial class ExamForm : Form
    {
        ExaminationDbContext DB=new ExaminationDbContext();
        private int Id = 0;
        public ExamForm()
        {
            InitializeComponent();
        }

        private void btn_back_home_Click(object sender, EventArgs e)
        {
            Admin_Dashboard admin_form = new Admin_Dashboard();
            admin_form.Show();
            this.Close();
        }

        private void ExamForm_Load(object sender, EventArgs e)
        {
            var exam=DB.Exams.ToList();
            dgv_Exam.DataSource = exam;

            cbx_courses.DataSource = DB.Courses.ToList();
            cbx_courses.ValueMember = "CrsId";
            cbx_courses.DisplayMember = "CrsName";

            txt_duration.Text = "";
            txt_pass_score.Text = "";
            cbx_courses.SelectedValue = "";
        }

        private void btn_add_dept_Click(object sender, EventArgs e)
        {
            var exam = new Exam();
            exam.PassScore=int.Parse(txt_pass_score.Text);
            exam.ExamDuration=int.Parse(txt_duration.Text);
            exam.CrsId =(int) cbx_courses.SelectedValue;

            DB.Exams.Add(exam); 
            DB.SaveChanges();
            dgv_Exam.DataSource = DB.Exams.ToList();

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
            var exam =DB.Exams.Where(e=>e.ExamId== Id).FirstOrDefault();

            exam.PassScore = int.Parse(txt_pass_score.Text);
            exam.ExamDuration = int.Parse(txt_duration.Text);
            exam.CrsId = (int)cbx_courses.SelectedValue;

            DB.Exams.Update(exam);
            DB.SaveChanges();
            dgv_Exam.DataSource = DB.Exams.ToList();

            txt_duration.Text = "";
            txt_pass_score.Text = "";
            cbx_courses.SelectedValue = "";
        }

        private void btn_delete_dept_Click(object sender, EventArgs e)
        {
            var exam = DB.Exams.FirstOrDefault(e => e.ExamId == Id);
            DB.Exams.Remove(exam);
            DB.SaveChanges();
            dgv_Exam.DataSource = DB.Exams.ToList();

            txt_duration.Text = "";
            txt_pass_score.Text = "";
            cbx_courses.SelectedValue = "";
        }
    }
}
