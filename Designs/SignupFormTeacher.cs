using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Management_System.Designs
{
    public partial class SignupFormTeacher : Form
    {
        DBAccess objDBAccess = new DBAccess();

        public SignupFormTeacher()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Designs.ChooseAccountSignUpForm chooseAccountSignUp = new Designs.ChooseAccountSignUpForm();
            chooseAccountSignUp.Show();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            string TeacherID = teacherIDTB.Text;
            string Fname = fnameTB.Text;
            string Lname = lnameTB.Text;
            string Password = passwordTB.Text;
            string ConfirmPassword = confirmPassTB.Text;


            // Check if any field is empty
            if (string.IsNullOrWhiteSpace(TeacherID) || string.IsNullOrWhiteSpace(Fname) || string.IsNullOrWhiteSpace(Lname) || string.IsNullOrWhiteSpace(Password) || string.IsNullOrWhiteSpace(ConfirmPassword))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            if (string.IsNullOrWhiteSpace(Password) || Password.Length < 8)
            {
                MessageBox.Show("New password must be at least 8 characters long.");
                return;
            }

            if (!Regex.IsMatch(Password, @"[A-Z]"))
            {
                MessageBox.Show("New password must contain at least one uppercase letter.");
                return;
            }

            if (!Regex.IsMatch(Password, @"[a-z]"))
            {
                MessageBox.Show("New password must contain at least one lowercase letter.");
                return;
            }

            if (!Regex.IsMatch(Password, @"[0-9]"))
            {
                MessageBox.Show("New password must contain at least one number.");
                return;
            }

            if (!Regex.IsMatch(Password, @"[\W_]"))
            {
                MessageBox.Show("New password must contain at least one special character.");
                return;
            }

            if (Password != ConfirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match.");
                return;
            }
            // Check if the Student ID exists in adminaccountrecords
            if (!IsIDInAdminRecords(TeacherID))
            {
                MessageBox.Show("The Student ID does not exist in admin account records. Please provide a valid ID.");
                return;
            }

            // Check if the Student ID is already used
            if (IsIDAlreadyUsed(TeacherID))
            {
                MessageBox.Show("The Student ID is already used. Please choose a different ID.");
                return;
            }

            MySqlCommand insertCommand = new MySqlCommand("INSERT INTO Users(ID, First_Name, Last_Name, Password, User_Type) VALUES(@TeacherID, @Fname, @Lname, @Password, 0)");
            insertCommand.Parameters.AddWithValue("@TeacherID", TeacherID);
            insertCommand.Parameters.AddWithValue("@Fname", Fname);
            insertCommand.Parameters.AddWithValue("@Lname", Lname);
            insertCommand.Parameters.AddWithValue("@Password", Password);

            int row = objDBAccess.executeQuery(insertCommand);

            if (row == 1)
            {
                // Pass student ID to the next form
                // For student signup
                SetUpAccount setupAccountForm = new SetUpAccount(TeacherID, UserType.Student);
                MessageBox.Show("Account Created Successfully");
                this.Hide();
                setupAccountForm.Show();
            }
            else
            {
                MessageBox.Show("Error Occurred. Try again");
            }
        }

        // Method to check if the Student ID exists in admin account records
        private bool IsIDInAdminRecords(string TeacherID)
        {
            MySqlCommand checkCommand = new MySqlCommand("SELECT COUNT(*) FROM adminaccountrecords WHERE ID = @TeacherID AND User_type = 1");
            checkCommand.Parameters.AddWithValue("@TeacherID", TeacherID);

            int count = Convert.ToInt32(objDBAccess.executeScalar(checkCommand));
            return count > 0;
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

        private void teacherIDTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter and teacherIDTB is empty
            if (e.KeyChar == (char)Keys.Enter && string.IsNullOrEmpty(teacherIDTB.Text))
            {
                // Display a message to enter info in teacherIDTB
                MessageBox.Show("Please enter your teacher ID before proceeding.");

                // Prevent the Enter key from being processed further
                e.Handled = true;
            }
            // Check if the pressed key is Enter and teacherIDTB is not empty
            else if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(teacherIDTB.Text))
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

