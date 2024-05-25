using System;
using System.Windows.Forms;

namespace Exam_Management_System.Designs
{
    public partial class teacherExamHistoCard : UserControl
    {
        private Action<string> deleteExamCardAction;
        private Form teacherDashboard;

        public teacherExamHistoCard(Action<string> deleteExamCardAction, Form teacherDashboard)
        {
            InitializeComponent();
            this.deleteExamCardAction = deleteExamCardAction;
            this.teacherDashboard = teacherDashboard;

            viewSubmissions_BTN.Click += viewSubmissions_BTN_Click;


        }

        public void SetTitle(string title)
        {
            titleExamLbl.Text = title;
        }

        public void SetCode(string code)
        {
            codeExamLbl.Text = code;
        }

        public void SetTotalSubmittedStudents(int total)
        {
            totalSubmittedStudLbl.Text = total.ToString();
        }

        public void SetCreatedDateTime(DateTime createdDateTime)
        {
            createdExamDateTimeLbl.Text = createdDateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public void SetDeadlineDateTime(DateTime deadlineDateTime)
        {
            deadlineExamDateTimeLbl.Text = deadlineDateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public void SetStatus(string status)
        {
            statusExamLbl.Text = status;
        }

        private void deleteExamBtn_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to delete this exam?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If user confirms deletion
            if (result == DialogResult.Yes)
            {
                // Remove the card from the flowLayoutPanel
                this.Parent.Controls.Remove(this);

                // Delete the corresponding record from the database
                string examCode = codeExamLbl.Text;
                deleteExamCardAction?.Invoke(examCode);
            }
        }

        private void viewSubmissions_BTN_Click(object sender, EventArgs e)
        {
            // Instantiate the CheckingPreview form
            CheckingPreview checkingPreview = new CheckingPreview();

            // Pass the exam code to the CheckingPreview form
            checkingPreview.SetExamCode(codeExamLbl.Text);

            TeacherDashBoard teacherDashboard = new TeacherDashBoard();
            // Hide the TeacherDashBoard form
            teacherDashboard.Hide();

            // Show the CheckingPreview form
            checkingPreview.Show();

            // Optionally, handle the CheckingPreview form closing event to show the TeacherDashboard form again
            checkingPreview.FormClosed += (s, args) => teacherDashboard.Show();
        }

    }
}
