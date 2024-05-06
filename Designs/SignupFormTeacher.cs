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

            // Check if password matches confirm password
            if (Password != ConfirmPassword)
            {
                MessageBox.Show("Password and Confirm Password do not match.");
                return;
            }

            // Check if the ID is already used
            if (IsIDAlreadyUsed(TeacherID))
            {
                MessageBox.Show("ID is already in use. Please choose another ID.");
                return;
            }
            else
            {
                MySqlCommand insertCommand = new MySqlCommand("INSERT INTO Users(ID, First_Name, Last_Name, Password, User_Type) VALUES(@TeacherID, @Fname, @Lname, @Password, 0)");
                
                insertCommand.Parameters.AddWithValue("@TeacherID", TeacherID);
                insertCommand.Parameters.AddWithValue("@Fname", Fname);
                insertCommand.Parameters.AddWithValue("@Lname", Lname);
                insertCommand.Parameters.AddWithValue("@Password", Password);


                int row = objDBAccess.executeQuery(insertCommand);

                if (row == 1)
                {
                    MessageBox.Show("Account Created Successfully");
                    this.Hide();
                    Designs.Homepage homePage = new Designs.Homepage();
                    homePage.Show();
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

    }
 }

