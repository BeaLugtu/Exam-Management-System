using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Management_System.Designs
{
    public partial class ChooseAccountSignUpForm : Form
    {
        private bool isTeacherSelected = false;
        private bool isStudentSelected = false;

        // Declare variables to store original width and height
        private int originalWidth;
        private int originalHeight;

        public ChooseAccountSignUpForm()
        {
            InitializeComponent();
            this.Load += ChooseAccountSignUpForm_Load;
            this.KeyDown += ChooseAccountSignUpForm_KeyDown; // Subscribe to KeyDown event
                                                             // Set KeyPreview to true
            this.KeyPreview = true;

            originalWidth = cancelBtn.Width;
            originalHeight = cancelBtn.Height;
            // Set the teacher option as the default selection
            isTeacherSelected = false;
            isStudentSelected = true;

            // Start a timer to update the time label every second
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second interval
            timer.Tick += Timer_Tick;
            timer.Start();
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (isTeacherSelected)
            {
                // Hide the current form
                this.Hide();

                // Show the student signup form
                Designs.SignupFormTeacher signupFormTeacher = new Designs.SignupFormTeacher();
                signupFormTeacher.Show();
            }
            else if (isStudentSelected)
            {
                // Hide the current form
                this.Hide();

                // Show the teacher signup form
                Designs.SignupFormStudent signupFormStudent = new Designs.SignupFormStudent();
                signupFormStudent

                    .Show();
            }
            else
            {
                // Handle the case when neither button is selected
                MessageBox.Show("Please select an account type before confirming.");
            }

        }

        private void teacherAccountOptionBtn_Click(object sender, EventArgs e)
        {
            SelectTeacherOption();
        }

        private void studentAccountOptionBtn_Click(object sender, EventArgs e)
        {
            SelectStudentOption();
        }

        private void SelectTeacherOption()
        {
            isTeacherSelected = true;
            isStudentSelected = false;

            // Change the image of the button to the selected image
            teacherAccountOptionBtn.Image = Properties.Resources.darkTeacherOption;

            // Revert the studentAccountOptionBtn to its default image
            studentAccountOptionBtn.Image = Properties.Resources.lightStudentOption;

            // Set focus to the confirm button
            confirmBtn.Focus();
        }

        private void SelectStudentOption()
        {
            isTeacherSelected = false;
            isStudentSelected = true;

            // Change the image of the button to the selected image
            teacherAccountOptionBtn.Image = Properties.Resources.lightTeacherOption;

            // Revert the studentAccountOptionBtn to its default image
            studentAccountOptionBtn.Image = Properties.Resources.darkStudentOption;

            // Set focus to the confirm button
            confirmBtn.Focus();
        }


        private void teacherAccountOptionBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Check if the teacher option button is visually selected
                if (teacherAccountOptionBtn.Image == Properties.Resources.darkTeacherOption)
                {
                    // Call the corresponding method based on the selected option
                    SelectTeacherOption();

                    // Perform the confirmation button click action
                    confirmBtn.PerformClick();

                    // Prevent the Enter key from being processed further
                    e.Handled = true;
                }
            }
        }

        private void studentAccountOptionBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Check if the student option button is visually selected
                if (studentAccountOptionBtn.Image == Properties.Resources.darkStudentOption)
                {
                    // Call the corresponding method based on the selected option
                    SelectStudentOption();

                    // Perform the confirmation button click action
                    confirmBtn.PerformClick();

                    // Prevent the Enter key from being processed further
                    e.Handled = true;
                }
            }
        }




        // Update the time label with the current time
        private void UpdateTimeLabel()
        {
            // Get current date and time
            DateTime currentTime = DateTime.Now;

            // Format the date and time string
            string formattedDateTime = currentTime.ToString("h:mm tt - ddd, MMM d");

            // Update the label text
            timeDateLbl.Text = formattedDateTime;
        }

        // Timer tick event handler to update the time label
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the time label
            UpdateTimeLabel();
        }

        private void ChooseAccountSignUpForm_Load(object sender, EventArgs e)
        {
            // Get current date and time
            DateTime currentTime = DateTime.Now;
            // Display the current time
            UpdateTimeLabel();
            // Format the date and time string
            string formattedDateTime = currentTime.ToString("h:mm tt - ddd, MMM d");

            // Update the label text
            timeDateLbl.Text = formattedDateTime;


        }



        // Helper method to resize the image
        private Image ResizeImage(Image imgToResize, int newWidth, int newHeight)
        {
            Bitmap newImage = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(newImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(imgToResize, 0, 0, newWidth, newHeight);
            }
            return newImage;
        }

        private void cancelBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Escape
            if (e.KeyChar == (char)Keys.Escape)
            {
                // Perform the cancel button click action
                cancelBtn.PerformClick();

                // Prevent the Escape key from being processed further
                e.Handled = true;
            }

        }
        private void ChooseAccountSignUpForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the pressed key is Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Check which option is currently selected
                if (isTeacherSelected)
                {
                    // If Teacher option is selected, perform the confirmation action for Teacher
                    confirmBtn.PerformClick();
                }
                else if (isStudentSelected)
                {
                    // If Student option is selected, perform the confirmation action for Student
                    confirmBtn.PerformClick();
                }

                // Prevent the Enter key from being processed further
                e.Handled = true;
            }

            // Check if the pressed key is Esc
            if (e.KeyCode == Keys.Escape)
            {
                // Perform the cancel button click action
                cancelBtn.PerformClick();

                // Prevent the Esc key from being processed further
                e.Handled = true;
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}