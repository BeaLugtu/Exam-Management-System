using System;
using System.Windows.Forms;

namespace Exam_Management_System.Designs
{
    public partial class TeacherDashBoard : Form
    {
        public TeacherDashBoard()
        {
            InitializeComponent();
            this.Load += teacherDashBoard_Load;

            // Start a timer to update the time label every second
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second interval
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void teacherDashBoard_Load(object sender, EventArgs e)
        {
            UpdateTimeLabel();
            PopulateFlowLayoutPanel();
        }

        // Method to populate the flowLayoutTablelistExam with teacherExamHistoCard controls
        private void PopulateFlowLayoutPanel()
        {
            for (int i = 0; i < 10; i++) // For example, add 10 user controls
            {
                teacherExamHistoCard examCard = new teacherExamHistoCard();
                flowLayoutTablelistExam.Controls.Add(examCard);
            }
        }

        // Update the time label with the current time
        private void UpdateTimeLabel()
        {
            DateTime currentTime = DateTime.Now;
            string formattedDateTime = currentTime.ToString("h:mm tt - ddd, MMM d");
            timeDateLbl.Text = formattedDateTime;
        }

        // Timer tick event handler to update the time label
        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateTimeLabel();
        }
    }
}
