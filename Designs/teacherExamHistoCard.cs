using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TeacherDashboard;

namespace Exam_Management_System.Designs
{
    public partial class teacherExamHistoCard : UserControl
    {
        private Action<string> deleteExamCardAction;
        private Action<string> editExamCardAction;
        private Action<string> viewExamCardAction;
        private Form teacherDashboard;

        string connectionString = "Server=26.96.197.206;Database=exam.io;Uid=admin;Pwd=admin;";


        public teacherExamHistoCard(Action<string> deleteExamCardAction, Action<string> editExamCardAction, Action<string> viewExamCardAction, Form teacherDashboard)
        {
            InitializeComponent();
            this.deleteExamCardAction = deleteExamCardAction;
            this.editExamCardAction = editExamCardAction; // Fix this line
            this.viewExamCardAction = viewExamCardAction; // Fix this line
            this.teacherDashboard = teacherDashboard;

            viewSubmissions_BTN.Click += viewSubmissions_BTN_Click;

            editForm_BTN.Click += editForm_BTN_Click;
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
            // Display a confirmation dialog
            DialogResult result = MessageBox.Show("Do you want to view this exam?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If user confirms deletion
            if (result == DialogResult.Yes)
            {
                // Remove the card from the flowLayoutPanel
                this.Parent.Controls.Remove(this);

                // Delete the corresponding record from the database
                // Invoke the view action when the "View Submissions" button is clicked
                string examCode = codeExamLbl.Text;
                viewExamCardAction?.Invoke(examCode);
            }
        }

        private void editForm_BTN_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to edit this exam?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If user confirms deletion
            if (result == DialogResult.Yes)
            {
                // Remove the card from the flowLayoutPanel
                this.Parent.Controls.Remove(this);

                // Delete the corresponding record from the database
                // Invoke the edit action when the "Edit Form" button is clicked
                string examCode = codeExamLbl.Text;
                editExamCardAction?.Invoke(examCode);
            }
        }

        // Add an event handler for viewForm_BTN if necessary

        // Method to format time input
        private string FormatTimeInput(TimeSpan input)
        {
            try
            {
                // Format the time as "HH:mm"
                return input.ToString(@"hh\:mm");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while formatting time: " + ex.Message);
                return null;
            }
        }
    }
}
