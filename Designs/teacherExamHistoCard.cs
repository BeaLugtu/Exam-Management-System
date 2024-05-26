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
        private Form teacherDashboard;

        string connectionString = "Server=26.96.197.206;Database=exam.io;Uid=admin;Pwd=admin;";

        public teacherExamHistoCard(Action<string> deleteExamCardAction, Form teacherDashboard)
        {
            InitializeComponent();
            this.deleteExamCardAction = deleteExamCardAction;
            this.teacherDashboard = teacherDashboard;

            viewSubmissions_BTN.Click += viewSubmissions_BTN_Click;

            editForm_BTN.Click += editForm_BTN_Click; // Add this line
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
            TeacherDashBoard teacherDashboard = new TeacherDashBoard();

            teacherDashboard.Hide();

            // Instantiate the CheckingPreview form
            CheckingPreview checkingPreview = new CheckingPreview();

            // Pass the exam code to the CheckingPreview form
            checkingPreview.SetExamCode(codeExamLbl.Text);

            // Show the CheckingPreview form
            checkingPreview.Show();

            // Optionally, handle the CheckingPreview form closing event to show the TeacherDashboard form again
            checkingPreview.FormClosed += (s, args) => teacherDashboard.Show();
        }

        private void editForm_BTN_Click(object sender, EventArgs e)
        {
            // Exam code to be passed
            string examCode = codeExamLbl.Text;

            // Query the database to check if the exam code exists and fetch the relevant details
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT examTitle, examTotalStudents, examDeadlineDate, examDeadlineTime, examStudentsTurnedIn FROM examforms WHERE examCode = @examCode";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@examCode", examCode);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Check if students have already turned in the exam
                                int studentsTurnedIn = reader.GetInt32(reader.GetOrdinal("examStudentsTurnedIn"));
                                if (studentsTurnedIn != 0)
                                {
                                    MessageBox.Show("You cannot edit the form as students have already turned in the exam.", "Edit Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                // Hide the TeacherDashBoard form
                                //teacherDashboard.Hide();

                                // Instantiate the newBlankForm
                                newBlankForm blankForm = new newBlankForm();

                                // Set the exam code
                                blankForm.SetExamCode(examCode);

                                // Fetch and set the exam details
                                string examTitle = reader.GetString(reader.GetOrdinal("examTitle"));
                                int examTotalStudents = reader.GetInt32(reader.GetOrdinal("examTotalStudents"));
                                DateTime examDeadlineDate = reader.GetDateTime(reader.GetOrdinal("examDeadlineDate"));
                                TimeSpan examDeadlineTime = reader.GetTimeSpan(reader.GetOrdinal("examDeadlineTime"));

                                blankForm.SetExamTitle(examTitle);
                                blankForm.SetExamTotalStudents(examTotalStudents);
                                blankForm.SetExamDeadlineDate(examDeadlineDate);
                                blankForm.SetExamDeadlineTime(FormatTimeInput(examDeadlineTime));

                                // Show the newBlankForm
                                blankForm.Show();

                                // Optionally, handle the newBlankForm form closing event to show the TeacherDashboard form again
                                blankForm.FormClosed += (s, args) => teacherDashboard.Show();
                            }
                            else
                            {
                                MessageBox.Show("Exam code not found.", "Edit Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



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
