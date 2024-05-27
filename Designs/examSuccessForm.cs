using Exam_Management_System.Designs;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace TeacherDashboard
{
    public partial class examSuccessForm : Form
    {
        private string examCode;

        public examSuccessForm(string examCode)
        {
            InitializeComponent();
            this.examCode = examCode;
            examCode_TB.Text = "Exam code is: " + examCode; // Display the exam code
            examCode_TB.MouseDown += ExamCode_TB_MouseDown; // Attach mouse down event handler
        }

        private void ExamCode_TB_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Copy exam code to clipboard
                Clipboard.SetText("Exam code is " + examCode);

                // Notify user
                MessageBox.Show("Exam code copied to clipboard.", "Exam Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void backToDB_BTN_Click(object sender, EventArgs e)
        {
            // Fetch teacherID from examforms table based on examCode
            string teacherID = GetTeacherIDFromDatabase(examCode);
            if (teacherID == null)
            {
                MessageBox.Show("Teacher ID not found for the given exam code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Set userType to 1
            UserType userType = UserType.Teacher;

            this.Close();
            TeacherDashBoard teacherDashBoard = new TeacherDashBoard(teacherID, userType);
            teacherDashBoard.Show();
        }

        // Method to fetch teacherID from examforms table based on examCode
        private string GetTeacherIDFromDatabase(string examCode)
        {
            string connectionString = "Server=26.96.197.206;Database=exam.io;Uid=admin;Pwd=admin;";
            string query = "SELECT teacherID FROM examforms WHERE examCode = @ExamCode";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ExamCode", examCode);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            return result.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error accessing database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return null; // Return null if teacherID is not found
        }
    }
}
