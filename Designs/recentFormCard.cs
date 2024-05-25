using System;
using System.Windows.Forms;

namespace Exam_Management_System.Designs
{
    public partial class recentFormCard : UserControl
    {
        public event EventHandler ViewFormClicked; // Event to handle view form button click
        private string examCode;
        public recentFormCard()
        {
            InitializeComponent();
        }

        private void recentFormCard_Load(object sender, EventArgs e)
        {
            // Any initialization logic if needed
        }

        public void SetTitle(string title)
        {
            titleExamLbl.Text = title;
        }

        public void SetProfessorAssigned(string professorAssigned)
        {
            profAssignedLbl.Text = professorAssigned;
        }

        public void SetTimeTurnedIn(DateTime timeTurnedIn)
        {
            timeTurnedInlbl.Text = timeTurnedIn.ToString("g"); // Customize the format as needed
        }

        public void SetTimeliness(string timeliness)
        {
            timelinessLbl.Text = timeliness;
        }

        public void SetStatus(string status)
        {
            statusExamLbl.Text = status;
        }

        public void SetScore(int score)
        {
            scorelbl.Text = score.ToString();
        }

        public void SetExamCode(string code) // Add this method to set exam code
        {
            examCode = code;
        }

        private void viewFormButton_Click(object sender, EventArgs e)
        {
            // Find the parent form (RecentForm)
            Form parentForm = this.FindForm();

            if (parentForm != null)
            {
                // Create and show ViewForm
                ViewForm viewForm = new ViewForm(examCode);
                viewForm.Show();

                // Hide or close the parent form
                parentForm.Hide(); // or parentForm.Close();
            }
        }


    }
}
