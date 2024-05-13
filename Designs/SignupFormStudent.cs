using MySql.Data.MySqlClient;
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
    public partial class SignupFormStudent : Form
    {
        DBAccess objDBAccess = new DBAccess();


            public SignupFormStudent()
            {
                InitializeComponent();
                // Set focus to the studentIDTB textbox when the form loads
                this.Load += SignupFormStudent_Load;
                studentIDTB.Focus();
        }

            private void SignupFormStudent_Load(object sender, EventArgs e)
            {
                // Set focus to the studentIDTB textbox when the form loads
                studentIDTB.Focus();
            }


        private void confirmBtn_Click(object sender, EventArgs e)
        {
            string StudentID = studentIDTB.Text;
            string Fname = fnameTB.Text;
            string Lname = lnameTB.Text;
            string Password = passwordTB.Text;
            string ConfirmPassword = confirmPassTB.Text;


            // Check if any field is empty
            if (string.IsNullOrWhiteSpace(StudentID) || string.IsNullOrWhiteSpace(Fname) || string.IsNullOrWhiteSpace(Lname) || string.IsNullOrWhiteSpace(Password) || string.IsNullOrWhiteSpace(ConfirmPassword))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            // Check if password matches confirm password
            if (Password != ConfirmPassword)
            {
                MessageBox.Show("Password and Confirm Password do not match.");
                return;
            }

            // Check if the ID is already used
            if (IsIDAlreadyUsed(StudentID))
            {
                MessageBox.Show("ID is already in use. Please choose another ID.");
                return;
            }
            else
            {
                MySqlCommand insertCommand = new MySqlCommand("INSERT INTO Users(ID, First_Name, Last_Name, Password, User_Type) VALUES(@StudentID, @Fname, @Lname, @Password, 1)");

                insertCommand.Parameters.AddWithValue("@StudentID", StudentID);
                insertCommand.Parameters.AddWithValue("@Fname", Fname);
                insertCommand.Parameters.AddWithValue("@Lname", Lname);
                insertCommand.Parameters.AddWithValue("@Password", Password);

                int row = objDBAccess.executeQuery(insertCommand);

                if (row == 1)
                {
                    // Pass student ID to the next form
                    // For student signup
                    SetUpAccount setupAccountForm = new SetUpAccount(StudentID, UserType.Student);
                    MessageBox.Show("Account Created Successfully");
                    this.Hide();
                    setupAccountForm.Show();
                }
                else
                {
                    MessageBox.Show("Error Occurred. Try again");
                }
            }
        }

        // Method to check if the ID is already used
        private bool IsIDAlreadyUsed(string teacherID)
        {
            // Assuming there is a table named 'Users' with 'ID' column
            string query = "SELECT COUNT(*) FROM Users WHERE ID = @TeacherID";
            MySqlCommand command = new MySqlCommand(query);
            command.Parameters.AddWithValue("@TeacherID", teacherID);
            int count = Convert.ToInt32(objDBAccess.executeScalar(command));
            return count > 0;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Designs.ChooseAccountSignUpForm chooseAccountSignUp = new Designs.ChooseAccountSignUpForm();
            chooseAccountSignUp.Show();
        }

        private void studentIDTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter and studentIDTB is empty
            if (e.KeyChar == (char)Keys.Enter && string.IsNullOrEmpty(studentIDTB.Text))
            {
                // Display a message to enter info in studentIDTB
                MessageBox.Show("Please enter your student ID before proceeding.");

                // Prevent the Enter key from being processed further
                e.Handled = true;
            }
            // Check if the pressed key is Enter and studentIDTB is not empty
            else if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(studentIDTB.Text))
            {
                // Move focus to fnameTB
                fnameTB.Focus();

                // Prevent the Enter key from being processed further
                e.Handled = true;
            }
        }

        private void fnameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter and fnameTB is empty
            if (e.KeyChar == (char)Keys.Enter && string.IsNullOrEmpty(fnameTB.Text))
            {
                // Display a message to enter info in fnameTB
                MessageBox.Show("Please enter your first name before proceeding.");

                // Prevent the Enter key from being processed further
                e.Handled = true;
            }
            // Check if the pressed key is Enter and fnameTB is not empty
            else if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(fnameTB.Text))
            {
                // Move focus to lnameTB
                lnameTB.Focus();

                // Prevent the Enter key from being processed further
                e.Handled = true;
            }
        }

        private void lnameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter and lnameTB is empty
            if (e.KeyChar == (char)Keys.Enter && string.IsNullOrEmpty(lnameTB.Text))
            {
                // Display a message to enter info in lnameTB
                MessageBox.Show("Please enter your last name before proceeding.");

                // Prevent the Enter key from being processed further
                e.Handled = true;
            }
            // Check if the pressed key is Enter and lnameTB is not empty
            else if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(lnameTB.Text))
            {
                // Move focus to passwordTB
                passwordTB.Focus();

                // Prevent the Enter key from being processed further
                e.Handled = true;
            }
        }

        private void passwordTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter and passwordTB is empty
            if (e.KeyChar == (char)Keys.Enter && string.IsNullOrEmpty(passwordTB.Text))
            {
                // Display a message to enter info in passwordTB
                MessageBox.Show("Please enter your password before proceeding.");

                // Prevent the Enter key from being processed further
                e.Handled = true;
            }
            // Check if the pressed key is Enter and passwordTB is not empty
            else if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(passwordTB.Text))
            {
                // Move focus to confirmPassTB
                confirmPassTB.Focus();

                // Prevent the Enter key from being processed further
                e.Handled = true;
            }
        }

        private void confirmPassTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter and confirmPassTB is empty
            if (e.KeyChar == (char)Keys.Enter && string.IsNullOrEmpty(confirmPassTB.Text))
            {
                // Display a message to enter info in confirmPassTB
                MessageBox.Show("Please confirm your password before proceeding.");

                // Prevent the Enter key from being processed further
                e.Handled = true;
            }
            // Check if the pressed key is Enter and confirmPassTB is not empty
            else if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(confirmPassTB.Text))
            {
                // Perform the desired action here (e.g., activating a button)
                confirmBtn.PerformClick();

                // Prevent the Enter key from being processed further
                e.Handled = true;
            }
        }

    }
}