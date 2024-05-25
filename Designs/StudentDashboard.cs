
﻿
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
using System.IO;

namespace Exam_Management_System.Designs
{
    public partial class StudentDashboard : Form
    {
        private string userID;
        private UserType userType;

        DBAccess objDABAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        private ExamForm examForm;
        private Profile profileForm;
        private Size originalSize;
        private Size originalImageSize;
        private Image originalImage;

        private Size originalSizeNotificationBtn;
        private Size originalImageSizeNotificationBtn;
        private Image originalImageNotificationBtn;

        public StudentDashboard(string userID)
        {
            InitializeComponent();
            InitializeHoverEffects();
            this.userID = userID;
            this.userType = userType;

            // Load user profile picture
            LoadUserProfilePicture();

            // Start a timer to update the time label every second
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second interval
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void InitializeHoverEffects()
        {
            // Hover effect for ProfileView button
            originalSize = ProfileView.Size;
            originalImage = ProfileView.Values.Image;
            if (originalImage != null)
            {
                originalImageSize = originalImage.Size;
            }
            ProfileView.MouseEnter += KryptonButton5_MouseEnter;
            ProfileView.MouseLeave += KryptonButton5_MouseLeave;

            // Hover effect for notificationBtn
            originalSizeNotificationBtn = notificationBtn.Size;
            originalImageNotificationBtn = notificationBtn.Values.Image;
            if (originalImageNotificationBtn != null)
            {
                originalImageSizeNotificationBtn = originalImageNotificationBtn.Size;
            }
            notificationBtn.MouseEnter += NotificationBtn_MouseEnter;
            notificationBtn.MouseLeave += NotificationBtn_MouseLeave;
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void KryptonButton5_MouseEnter(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                // Enlarge the button slightly on hover
                ProfileView.Size = new Size(originalSize.Width + 3, originalSize.Height + 3);
                // Enlarge the image slightly on hover
                ProfileView.Values.Image = new Bitmap(originalImage, new Size(originalImageSize.Width + 3, originalImageSize.Height + 3));
            }
        }

        private void KryptonButton5_MouseLeave(object sender, EventArgs e)
        {
            // Restore the original size and image when the mouse leaves
            ProfileView.Size = originalSize;
            ProfileView.Values.Image = originalImage;
        }

        private void NotificationBtn_MouseEnter(object sender, EventArgs e)
        {
            if (originalImageNotificationBtn != null)
            {
                // Enlarge the button slightly on hover
                notificationBtn.Size = new Size(originalSizeNotificationBtn.Width + 3, originalSizeNotificationBtn.Height + 3);
                // Enlarge the image slightly on hover
                notificationBtn.Values.Image = new Bitmap(originalImageNotificationBtn, new Size(originalImageSizeNotificationBtn.Width + 3, originalImageSizeNotificationBtn.Height + 3));
            }
        }

        private void NotificationBtn_MouseLeave(object sender, EventArgs e)
        {
            if (originalImageNotificationBtn != null)
            {
                // Restore the original size and image when the mouse leaves
                notificationBtn.Size = originalSizeNotificationBtn;
                notificationBtn.Values.Image = originalImageNotificationBtn;
            }
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void SubmitLbl_Click(object sender, EventArgs e) { }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {

            UpdateTimeLabel();

            // Load user profile picture
            LoadUserProfilePicture();

        }

        private void Exam_Click(object sender, EventArgs e)
        {

            string userID = dtUsers.Rows[0]["ID"].ToString();
            string examCode = examCodeTB.Text;

            // Check if the user has already answered the exam
            string query = "SELECT COUNT(`"+userID+ "_answers`) FROM `" + examCode + "_answers`";

            // Create a DataTable to store the result
            DataTable dtCount = new DataTable();

            try
            {
                // Execute the query to fetch the count of answered questions
                objDABAccess.readDatathroughAdapter(query, dtCount);

                // Get the count of answered questions from the DataTable
                int answeredCount = Convert.ToInt32(dtCount.Rows[0][0]);

                // Determine if the exam has been answered
                bool answered = answeredCount > 0;

                // If the exam has been answered, display a message and do not open the exam form
                if (answered)
                {
                    MessageBox.Show("Exam has already been answered.", "Exam Answered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Open the exam form
                    ExamForm examForm = new ExamForm(userID, examCode);
                    examForm.Show();
                    this.Hide();
                }
            }
            catch (MySqlException ex)
            {
                // If the table does not exist, set answered to false and proceed
                bool answered = false;

                // Display an error message if needed
                MessageBox.Show("Proceed Answering");

                // Proceed to open the exam form
                ExamForm examForm = new ExamForm(userID, examCode);
                examForm.Show();
                this.Hide();
            }
        }



        private void ProfileBtn_Click(object sender, EventArgs e)

            string query = $"Select * from Users Where ID= '{userID}'";
            objDABAccess.readDatathroughAdapter(query, dtUsers);
            userID = dtUsers.Rows[0]["ID"].ToString();
            string Examcode = examCodeTB.Text;
            objDABAccess.readDatathroughAdapter(query, dtUsers);
            examForm = new ExamForm(userID, Examcode);
            examForm.Show();
            this.Hide();
        }


        private void ProfileView_Click(object sender, EventArgs e)

        {
            // Hide the current form
            Designs.Profile profile = new Designs.Profile(userID, userType);
            profile.Show();
            this.Hide();
        }

        // Update the time label with the current time
        private void UpdateTimeLabel()
        {
            DateTime currentTime = DateTime.Now;
            string formattedDateTime = currentTime.ToString("h:mm tt - ddd, MMM d");
            timeLbl.Text = formattedDateTime;
        }

        // Timer tick event handler to update the time label
        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateTimeLabel();
        }

        // Load user profile picture from database
        private void LoadUserProfilePicture()
        {
            string query = $"Select profile_pic from Users Where ID= '{userID}'";
            objDABAccess.readDatathroughAdapter(query, dtUsers);

            if (dtUsers.Rows.Count > 0 && dtUsers.Rows[0]["profile_pic"] != DBNull.Value)
            {
                byte[] imageData = (byte[])dtUsers.Rows[0]["profile_pic"];
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    ProfileView.Values.Image = Image.FromStream(ms);
                    originalImage = ProfileView.Values.Image;
                    originalImageSize = originalImage.Size;
                }
            }
        }
    }
}
