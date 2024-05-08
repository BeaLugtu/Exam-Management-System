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

        public ChooseAccountSignUpForm()
        {
            InitializeComponent();
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

        private void teacherAccountOptionBtn_MouseClick(object sender, MouseEventArgs e)
        {
            isTeacherSelected = true;
            isStudentSelected = false;

            // Change the image of the button to the selected image
            teacherAccountOptionBtn.Image = Properties.Resources.Group_21;

            // Revert the studentAccountOptionBtn to its default image
            studentAccountOptionBtn.Image = Properties.Resources.Group_22;
        }

        private void studentAccountOptionBtn_MouseClick(object sender, MouseEventArgs e)
        {
            isTeacherSelected = false;
            isStudentSelected = true;

            // Change the image of the button to the selected image
            teacherAccountOptionBtn.Image = Properties.Resources.TeacherAccountOption;

            // Revert the studentAccountOptionBtn to its default image
            studentAccountOptionBtn.Image = Properties.Resources.StudentAccountOption;
        }

    }

}
