
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

        public StudentDashboard(string userID, UserType userType)
        {
            string query = "Select * from Users Where ID= '" + userID + "'";
            objDABAccess.readDatathroughAdapter(query, dtUsers);
            InitializeComponent();
            InitializeHoverEffects();
            this.userID = userID.ToString();
        }


        private void InitializeHoverEffects()
        {

            // Hover effect for kryptonButton5
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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        // Mouse leave event handler for kryptonButton5
        private void KryptonButton5_MouseLeave(object sender, EventArgs e)
        {

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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SubmitLbl_Click(object sender, EventArgs e)
        {

        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {

        }
        private void Exam_Click(object sender, EventArgs e)
        {
            string query = "Select * from Users Where ID= '" + userID + "'";
            objDABAccess.readDatathroughAdapter(query, dtUsers);
            userID = dtUsers.Rows[0]["ID"].ToString();
            string Examcode = examCodeTB.Text;
            objDABAccess.readDatathroughAdapter(query, dtUsers);
            examForm = new ExamForm(userID, Examcode);
            examForm.Show();
            this.Hide();
        }
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
    }
}