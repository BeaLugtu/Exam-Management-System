using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using TeacherDashboard;

namespace Exam_Management_System.Designs
{
    public partial class TeacherDashBoard : Form
    {
        private readonly DBAccess dbAccess = new DBAccess();
        private string userID;
        private UserType userType;

        // New constructor to accept userID and userType
        public TeacherDashBoard(string userID, UserType userType)
        {
            InitializeComponent();
            this.userID = userID;
            this.userType = userType;
            this.Load += teacherDashBoard_Load;

            // Start a timer to update the time label every second
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second interval
            timer.Tick += Timer_Tick;
            timer.Start();
        }

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
            DataTable examData = new DataTable();
            dbAccess.readDatathroughAdapter("SELECT * FROM examforms", examData);

            foreach (DataRow row in examData.Rows)
            {
                teacherExamHistoCard examCard = new teacherExamHistoCard(DeleteExamCard);
                examCard.SetTitle(row["examTitle"].ToString());
                examCard.SetCode(row["examCode"].ToString());
                examCard.SetTotalSubmittedStudents(Convert.ToInt32(row["examTotalStudents"]));
                examCard.SetCreatedDateTime(Convert.ToDateTime(row["examCreated"]));
                examCard.SetDeadlineDateTime(Convert.ToDateTime(row["examDeadlineDate"]));
                examCard.SetStatus(row["examStatus"].ToString());

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

        private void blankForm_BTN_Click(object sender, EventArgs e)
        {
            // Create a new instance of the NewBlankForm and pass the instance of Form1
            newBlankForm newForm = new newBlankForm();

            // Show the new form
            newForm.Show();

            this.Hide();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // Pass teacher ID and other stuff to the next form
            // then load specific form ( gawa ni peralta )
        }

        private void notificationBtn_Click(object sender, EventArgs e)
        {
            // Pass teacher ID and other stuff to the next form
            // then load specific form ( gawa ni monte )
        }

        private void DeleteExamCard(string examCode)
        {
            try
            {
                // Construct the SQL query to select the record to be archived
                string selectQuery = $"SELECT * FROM examforms WHERE examCode = '{examCode}'";

                // Read the data from the examforms table
                DataTable examData = new DataTable();
                dbAccess.readDatathroughAdapter(selectQuery, examData);

                // Construct the SQL query to insert the record into the examFormsArchive table
                string insertQuery = $"INSERT INTO examFormsArchive (examTitle, examCode, examTotalStudents, examCreated, examDeadlineDate, examStatus) " +
                                     $"VALUES ('{examData.Rows[0]["examTitle"]}', '{examData.Rows[0]["examCode"]}', " +
                                     $"'{examData.Rows[0]["examTotalStudents"]}', '{examData.Rows[0]["examCreated"]}', " +
                                     $"'{examData.Rows[0]["examDeadlineDate"]}', '{examData.Rows[0]["examStatus"]}')";

                // Execute the insert query to archive the record
                dbAccess.executeQuery(new MySqlCommand(insertQuery));

                // Construct the SQL query to delete the record from the examforms table
                string deleteQuery = $"DELETE FROM examforms WHERE examCode = '{examCode}'";

                // Execute the delete query
                dbAccess.executeQuery(new MySqlCommand(deleteQuery));
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the exam: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
