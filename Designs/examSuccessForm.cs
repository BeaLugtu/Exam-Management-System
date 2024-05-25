using Exam_Management_System.Designs;
using System;
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
            TeacherDashBoard dashboardForm = new TeacherDashBoard();
            dashboardForm.Show();

            // Close the current form
            this.Close();
        }
    }
}
