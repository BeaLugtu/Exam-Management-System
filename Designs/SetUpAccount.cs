﻿using System;
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

            // Check the userType and open the appropriate form
            if (userType == UserType.Student)
            {
                // Open the homepage for students
                Designs.StudentDashboard studentDashboard = new Designs.StudentDashboard(userID, userType);
                studentDashboard.Show();
            }
            else if (userType == UserType.Teacher)
            {
                // Open the dashboard for teachers
                Designs.TeacherDashBoard teacherDashboard = new Designs.TeacherDashBoard(userID, userType);
                teacherDashboard.Show();
            }
            else
            {
                // If userType is neither student nor teacher, show an error message or handle appropriately
                MessageBox.Show("Invalid user type. Please contact support.");
            }
        }

        private void goToProfileBtn_Click(object sender, EventArgs e)
        {
            // Hide the current form
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
