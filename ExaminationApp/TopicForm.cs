using ExaminationApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ExaminationApp
{
    public partial class TopicForm : Form
    {
        ExaminationDbContext DB = new ExaminationDbContext();
        private int Id = 0;
        private Admin_Dashboard adminPage;
        public TopicForm(Admin_Dashboard adminPage)
        {
            InitializeComponent();
            this.adminPage = adminPage;
        }

        private void TopicForm_Load(object sender, EventArgs e)
        {

            var topics = DB.Topics.FromSql($"getAllTopics").ToList();
            dgv_topics.DataSource = topics;

            txt_top_name.Text = "";
        }

        private void btn_add_dept_Click(object sender, EventArgs e)
        {
            Id = DB.Topics.Max(x => x.TopicId);

            var affectedRows = DB.Database.ExecuteSql($"addTopic {Id + 1},{txt_top_name.Text}");
            if (affectedRows > 0)
            {
                MessageBox.Show("Topic Inserted Successfully", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.SaveChanges();
            }
            else
            {
                MessageBox.Show("Topic couldn't be Inserted Unfortunatly", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            dgv_topics.DataSource = DB.Topics.FromSql($"getAllTopics").ToList();

            txt_top_name.Text = "";
        }

        private void dgv_topics_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = (int)dgv_topics.SelectedRows[0].Cells[0].Value;
            txt_top_name.Text = dgv_topics.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btn_update_dept_Click(object sender, EventArgs e)
        {
            Id = (int)dgv_topics.SelectedRows[0].Cells[0].Value;
            var affectedRows = DB.Database.ExecuteSql($"updateTopic {Id},{txt_top_name.Text}");
            if (affectedRows > 0)
            {
                MessageBox.Show("Topic Updated Successfully", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.SaveChanges();
            }
            else
            {
                MessageBox.Show("Topic couldn't be Updated Unfortunatly", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            dgv_topics.DataSource = DB.Topics.ToList();

            txt_top_name.Text = "";
        }

        private void btn_delete_dept_Click(object sender, EventArgs e)
        {
            Id = (int)dgv_topics.SelectedRows[0].Cells[0].Value;
            var affectedRows = DB.Database.ExecuteSql($"deleteTopic {Id}");
            if (affectedRows > 0)
            {
                MessageBox.Show("Topic Deleted Successfully", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.SaveChanges();
            }
            else
            {
                MessageBox.Show("Topic couldn't be Deleted Unfortunatly", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            dgv_topics.DataSource = DB.Topics.ToList();
            txt_top_name.Text = "";
        }

        private void icon_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            adminPage.Show();
        }
    }
}
