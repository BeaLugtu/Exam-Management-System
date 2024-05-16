using Exam_Management_System.Designs;
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

namespace Exam_Management_System
{
    public partial class LoginForm : Form
    {
        DBAccess objDABAccess = new DBAccess();
        DataTable dtUsers = new DataTable();


        // Declare variables to store original width and height
        private int originalWidth;
        private int originalHeight;

        public LoginForm()
        {
            InitializeComponent();

            // Attach the Load event handler
            this.Load += LoginForm_Load;

            PasswordTB.UseSystemPasswordChar = true;
            // Start a timer to update the time label every second
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second interval
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        // Load event handler for the form
        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Get current date and time
            DateTime currentTime = DateTime.Now;
            // Display the current time
            UpdateTimeLabel();
            // Format the date and time string
            string formattedDateTime = currentTime.ToString("h:mm tt — ddd, MMM d");

            // Update the label text
            timeDateLbl.Text = formattedDateTime;
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

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Designs.ChooseAccountSignUpForm chooseAccountSignUpForm = new Designs.ChooseAccountSignUpForm();
            chooseAccountSignUpForm.Show();
        }

        private void LoginBtn_MouseClick(object sender, MouseEventArgs e)
        {
            string UserEmail = EmailTB.Text;
            string Password = PasswordTB.Text;

            if (UserEmail.Equals(""))
            {
                MessageBox.Show("Please Enter Your Email");
            }
            else if (Password.Equals(""))
            {
                MessageBox.Show("Please Enter Your Password");
            }
            else
            {
                string query = "Select * from Users Where ID= '" + UserEmail + "' AND Password = '" + Password + "'";

                objDABAccess.readDatathroughAdapter(query, dtUsers);

                if (dtUsers.Rows.Count > 0)
                {
                    // Get the user ID and user type from the database
                    string userID = dtUsers.Rows[0]["ID"].ToString();
                    UserType userType = (UserType)Enum.Parse(typeof(UserType), dtUsers.Rows[0]["User_Type"].ToString());

                    MessageBox.Show("Successfully Log in.");
                    objDABAccess.closeConn();
                    this.Hide();

                    // Pass user ID and user type to the homepage
                    Designs.Homepage homePage = new Designs.Homepage(userID, userType);
                    homePage.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Input. Please Try Again.");
                }
            }
        }



        private void EmailTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter and EmailTB is empty
            if (e.KeyChar == (char)Keys.Enter && string.IsNullOrEmpty(EmailTB.Text))
            {
                // Display a message to enter info in EmailTB
                MessageBox.Show("Please enter your email before proceeding.");

                // Prevent the Enter key from being processed further
                e.Handled = true;
            }
            // Check if the pressed key is Enter and EmailTB is not empty
            else if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(EmailTB.Text))
            {
                // Move focus to PasswordTB
                PasswordTB.Focus();

                // Prevent the Enter key from being processed further
                e.Handled = true;
            }
        }


        private void PasswordTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter and PasswordTB is empty
            if (e.KeyChar == (char)Keys.Enter && string.IsNullOrEmpty(PasswordTB.Text))
            {
                // Display a message to enter info in PasswordTB
                MessageBox.Show("Please enter your password before proceeding.");

                // Prevent the Enter key from being processed further
                e.Handled = true;
            }
            // Check if the pressed key is Enter
            else if (e.KeyChar == (char)Keys.Enter)
            {
                // Activate the login button
                LoginBtn.PerformClick();

                // Prevent the Enter key from being processed further
                e.Handled = true;
            }
        }


        private void forgotPassBtn_MouseHover(object sender, EventArgs e)
        {
            forgotPassBtn.StateCommon.ShortText.Font = new Font(forgotPassBtn.StateCommon.ShortText.Font.FontFamily, 8.7f, forgotPassBtn.StateCommon.ShortText.Font.Style); // Set font size to 8.3pt on hover
        }

        private void forgotPassBtn_MouseLeave(object sender, EventArgs e)
        {
            forgotPassBtn.StateCommon.ShortText.Font = new Font(forgotPassBtn.StateCommon.ShortText.Font.FontFamily, 8.25f, forgotPassBtn.StateCommon.ShortText.Font.Style); // Set font size to 8.3pt on hover

        }

        private bool isDefaultImage = true;

        private void invisiblePassBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (isDefaultImage)
            {
                // Change the image to the alternate image
                invisiblePassBtn.StateCommon.Back.Image = Properties.Resources.icons8_eye_15; // Change NewImage to your desired alternate image
                                                                                              // Change the border color to RGB(205, 205, 205)
                invisiblePassBtn.StateCommon.Border.Color1 = Color.FromArgb(205, 205, 205);
                invisiblePassBtn.StateCommon.Border.Color2 = Color.FromArgb(205, 205, 205);
                // Change the backcolor to RGB(205, 205, 205)
                invisiblePassBtn.StateCommon.Back.Color1 = Color.FromArgb(205, 205, 205);
                invisiblePassBtn.StateCommon.Back.Color2 = Color.FromArgb(205, 205, 205);
            }
            else
            {
                // Change the image back to the default image
                invisiblePassBtn.StateCommon.Back.Image = Properties.Resources.icons8_invisible_15; // Change DefaultImage to your default image
                                                                                                    // Change the border color to RGB(205, 205, 205)
                invisiblePassBtn.StateCommon.Border.Color1 = Color.FromArgb(205, 205, 205);
                invisiblePassBtn.StateCommon.Border.Color2 = Color.FromArgb(205, 205, 205);
                // Change the backcolor to RGB(205, 205, 205)
                invisiblePassBtn.StateCommon.Back.Color1 = Color.FromArgb(205, 205, 205);
                invisiblePassBtn.StateCommon.Back.Color2 = Color.FromArgb(205, 205, 205);
            }

            // Toggle the flag
            isDefaultImage = !isDefaultImage;
            if (invisiblePassBtn != null)
            {
                // Check if Tag is not null before accessing its ToString() method
                if (invisiblePassBtn.Tag != null && invisiblePassBtn.Tag.ToString() == "DefaultImage")
                {
                    // Always hide the password when the button is in default image state
                    PasswordTB.UseSystemPasswordChar = true;
                }
                else
                {
                    // Toggle visibility of the password
                    PasswordTB.UseSystemPasswordChar = !PasswordTB.UseSystemPasswordChar;
                }
            }

        }

        private void SignupBtn_MouseHover(object sender, EventArgs e)
        {
            SignupBtn.StateCommon.ShortText.Font = new Font(SignupBtn.StateCommon.ShortText.Font.FontFamily, 9.4f, SignupBtn.StateCommon.ShortText.Font.Style); // Set font size to 9.4pt on hover

        }

        private void SignupBtn_MouseLeave(object sender, EventArgs e)
        {
            SignupBtn.StateCommon.ShortText.Font = new Font(SignupBtn.StateCommon.ShortText.Font.FontFamily, 9f, SignupBtn.StateCommon.ShortText.Font.Style); // Set font size to 9.4pt on hover

        }

    }
}
