
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
    
    public partial class StudentDashboard : Form
    {
        private string userID;
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
        private LoginForm loginform;
        private Size originalSizeRecentFormBtn;
        private Size originalImageSizeRecentFormBtn;
        private Image originalImageRecentFormBtn;
        public StudentDashboard(string userID)
        {
            string query = "Select * from Users Where ID= '" + userID + "'";
            objDABAccess.readDatathroughAdapter(query, dtUsers);
            InitializeComponent();
            InitializeHoverEffects();
            this.userID = userID.ToString(); Timer timer = new Timer();
            timer.Interval = 1000; // 1 second interval
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            examCodeTB.Focus(); 
            UpdateTimeLabel();
        }
        private void UpdateTimeLabel()
        {
            DateTime currentTime = DateTime.Now;
            string formattedDateTime = currentTime.ToString("h:mm tt - ddd, MMM d");
            timeDateLbl.Text = formattedDateTime;
        }

        // Timer tick event handler to update the time label
        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateTimeLabel();
        }


        private void InitializeHoverEffects()
        {   // Hover effect for kryptonButton5
            originalSize = kryptonButton5.Size;
            originalImage = kryptonButton5.Values.Image;
            if (originalImage != null)
            {
                originalImageSize = originalImage.Size;
            }
            kryptonButton5.MouseEnter += KryptonButton5_MouseEnter;
            kryptonButton5.MouseLeave += KryptonButton5_MouseLeave;
            // Hover effect for notificationBtn
            originalSizeNotificationBtn = notificationBtn.Size;
            originalImageNotificationBtn = notificationBtn.Values.Image;
            if (originalImageNotificationBtn != null)
            {
                originalImageSizeNotificationBtn = originalImageNotificationBtn.Size;
            }
            notificationBtn.MouseEnter += NotificationBtn_MouseEnter;
            notificationBtn.MouseLeave += NotificationBtn_MouseLeave;
            // Hover effect for recentformbtn
            originalSizeRecentFormBtn = recentformbtn.Size;
            originalImageRecentFormBtn = recentformbtn.Image;
            if (originalImageRecentFormBtn != null)
            {
                originalImageSizeRecentFormBtn = originalImageRecentFormBtn.Size;
            }
            recentformbtn.MouseEnter += Recentformbtn_MouseEnter;
            recentformbtn.MouseLeave += Recentformbtn_MouseLeave;
        }
        private void KryptonButton5_MouseEnter(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                // Enlarge the button slightly on hover
                kryptonButton5.Size = new Size(originalSize.Width + 3, originalSize.Height + 3);
                // Enlarge the image slightly on hover
                kryptonButton5.Values.Image = new Bitmap(originalImage, new Size(originalImageSize.Width + 3, originalImageSize.Height + 3));
            }
        }

        // Mouse leave event handler for kryptonButton5
        private void KryptonButton5_MouseLeave(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                // Restore the original size when the mouse leaves
                kryptonButton5.Size = originalSize;
                // Restore the original image when the mouse leaves
                kryptonButton5.Values.Image = originalImage;
            }
        }
        // Hover effect for notificationBtn
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

        // Mouse leave event handler for notificationBtn
        private void NotificationBtn_MouseLeave(object sender, EventArgs e)
        {
            if (originalImageNotificationBtn != null)
            {
                // Restore the original size when the mouse leaves
                notificationBtn.Size = originalSizeNotificationBtn;
                // Restore the original image when the mouse leaves
                notificationBtn.Values.Image = originalImageNotificationBtn;
            }
        }//hover effect for Recent Form Button
        private void Recentformbtn_MouseEnter(object sender, EventArgs e)
        {
            if (originalImageRecentFormBtn != null)
            {
                // Enlarge the image slightly on hover
                recentformbtn.Size = new Size(originalSizeRecentFormBtn.Width + 3, originalSizeRecentFormBtn.Height + 3);
                recentformbtn.Image = new Bitmap(originalImageRecentFormBtn, new Size(originalImageSizeRecentFormBtn.Width + 3, originalImageSizeRecentFormBtn.Height + 3));
            }
        }
        private void Recentformbtn_MouseLeave(object sender, EventArgs e)
        {
            if (originalImageRecentFormBtn != null)
            {
                // Restore the original size when the mouse leaves
                recentformbtn.Size = originalSizeRecentFormBtn;
                // Restore the original image when the mouse leaves
                recentformbtn.Image = originalImageRecentFormBtn;
            }
        }
        private void Exam_Click(object sender, EventArgs e)
        {
            ValidateAndOpenExam();
        }

        private void ValidateAndOpenExam()
        {
            if (string.IsNullOrEmpty(examCodeTB.Text))
            {
                MessageBox.Show("Please enter an Exam Code before proceeding.");
            }
            else
            {
                examCodeTB.Focus();

                // Proceed to open the exam
                string examCode = examCodeTB.Text;

                // Check if exam code exists
                string examQuery = "SELECT * FROM examforms WHERE examcode = '" + examCode + "'";
                DataTable dtExam = new DataTable();
                objDABAccess.readDatathroughAdapter(examQuery, dtExam);

                if (dtExam.Rows.Count > 0)
                {// Fetch deadline date and time from the database
                    string deadlineQuery = "SELECT examdeadlinedate, examdeadlinetime FROM examforms WHERE examcode = '" + examCode + "'";
                    DataTable dtDeadline = new DataTable();
                    objDABAccess.readDatathroughAdapter(deadlineQuery, dtDeadline);

                    if (dtDeadline.Rows.Count == 0)
                    {
                        MessageBox.Show("No deadline found for the given exam code.");
                        return;
                    }

                    // Parse deadline date and time
                    DateTime examDeadlineDate = DateTime.Parse(dtDeadline.Rows[0]["examdeadlinedate"].ToString());
                    TimeSpan examDeadlineTime = TimeSpan.Parse(dtDeadline.Rows[0]["examdeadlinetime"].ToString());
                    DateTime examDeadline = examDeadlineDate.Date + examDeadlineTime;

                    // Check if the current datetime is past the deadline
                    if (DateTime.Now > examDeadline)
                    {
                        MessageBox.Show("The deadline for this exam has passed.", "Deadline Passed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    } 
                    // Exam code exists, check if the user has already answered the exam
                    string query = "SELECT COUNT(`" + userID + "_answers`) FROM `" + examCode + "_answers`";
                    DataTable dtCount = new DataTable();
                    try
                    {
                        objDABAccess.readDatathroughAdapter(query, dtCount);
                        int answeredCount = Convert.ToInt32(dtCount.Rows[0][0]);
                        bool answered = answeredCount > 0;
                        if (answered)
                        {
                            MessageBox.Show("Exam has already been answered.", "Exam Answered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    catch (MySqlException ex)
                    {
                        // Table does not exist, proceed with answering
                        MessageBox.Show("Proceed Answering");
                        ExamForm examForm = new ExamForm(userID, examCode);
                        examForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("No exam found with the given code.");
                }
            }
        }





       /* private void LogoutBtn_Click(object sender, EventArgs e)
        {
            // Show the main form (login form)
            loginform = new LoginForm(); // Instantiate StudentDashboard
            loginform.Show();
            this.Hide();

            // Close this form (logout form)
            this.Close();
        }*/

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            string query = "Select * from Users Where ID= '" + userID + "'";

            objDABAccess.readDatathroughAdapter(query, dtUsers);

            if (dtUsers.Rows.Count > 0)
            {
                // Get the user ID and user type from the database
                userID = dtUsers.Rows[0]["ID"].ToString();
                UserType userType = (UserType)Enum.Parse(typeof(UserType), dtUsers.Rows[0]["User_Type"].ToString());
                objDABAccess.closeConn();
                profileForm = new Profile(userID, userType);
                profileForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Input. Please Try Again.");
            }
        }
        //add this for the recentformbtn event handler

        private void recentformbtn_Click(object sender, EventArgs e)
        {
            RecentForm recentForm = new RecentForm(userID);
            recentForm.Show();
            this.Hide();
        }

        private void questionMarkButton_Click(object sender, EventArgs e)
        {
            // Assuming you already have the userID available
            Profile profileForm = new Profile(userID, UserType.Student); // Assuming you pass the user type as well
            profileForm.Show();
            // Optionally, hide the current form
            this.Hide();
        }
    }
}