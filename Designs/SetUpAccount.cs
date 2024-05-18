using System;
using System.Windows.Forms;

namespace Exam_Management_System.Designs
{
    public partial class SetUpAccount : Form
    {
        private string userID;
        private UserType userType;

        public SetUpAccount()
        {
            InitializeComponent();
        }

        public SetUpAccount(string userID, UserType userType)
        {
            InitializeComponent();
            this.userID = userID;
            this.userType = userType;

            if (userType == UserType.Student)
            {
                studentIDLbl.Text = "Student ID: " + userID;
            }
            else if (userType == UserType.Teacher)
            {
                studentIDLbl.Text = "Teacher ID: " + userID;
            }
        }

        private void skipBtn_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();
            // Pass user ID and user type to the homepage
            Designs.Homepage homePage = new Designs.Homepage(userID, userType);
            homePage.Show();
        }

        private void goToProfileBtn_Click(object sender, EventArgs e)
        {
            // Hide the current form
            // Pass user ID and user type to the homepage
            Designs.Profile profile = new Designs.Profile(userID, userType);
            profile.Show();
            this.Hide();
        }
    }

    public enum UserType
    {
        Student,
        Teacher
    }
}
