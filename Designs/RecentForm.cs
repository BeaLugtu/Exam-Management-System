using System;
using MySql.Data.MySqlClient;
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
    public partial class RecentForm : Form
    {
        DBAccess objDABAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        private Profile profileForm;
        private readonly DBAccess dbAccess = new DBAccess();

        private string userID;

        private Size originalSize;
        private Size originalImageSize;
        private Image originalImage;

        private Size originalSizeNotificationBtn;
        private Size originalImageSizeNotificationBtn;
        private Image originalImageNotificationBtn;

        public RecentForm(string userID)
        {
            InitializeComponent();
            this.userID = userID;

            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second interval
            timer.Tick += Timer_Tick;
            timer.Start();

            // Hover thingy for kryptonButton5
            InitializeHoverEffects();
        }


        private void RecentForm_Load(object sender, EventArgs e)
        {
            UpdateTimeLabel();
            PopulateFlowLayoutPanel();
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

        private void PopulateFlowLayoutPanel()
        {
            DataTable studentHistoryData = new DataTable();
            // Modify the SQL query to include a WHERE clause to filter data by studentID
            string query = $"SELECT * FROM studenthistory WHERE studentID = '{userID}'";
            dbAccess.readDatathroughAdapter(query, studentHistoryData);

            foreach (DataRow row in studentHistoryData.Rows)
            {
                recentFormCard formCard = new recentFormCard();
                formCard.SetTitle(row["title"].ToString());
                formCard.SetProfessorAssigned(row["prof_assigned"].ToString());
                formCard.SetTimeTurnedIn(Convert.ToDateTime(row["time_turnedin"]));
                formCard.SetTimeliness(row["timeliness"].ToString());
                formCard.SetStatus(row["status"].ToString());
                formCard.SetScore(Convert.ToInt32(row["score"]));
                formCard.SetExamCode(row["examCode"].ToString()); // Set the exam code
                formCard.setUserID(row["studentID"].ToString());
                flowLayoutRecentFormList.Controls.Add(formCard);
            }
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

        private void recentformbackbtn_Click(object sender, EventArgs e)
        {
            StudentDashboard studentDashboardForm = new StudentDashboard(userID); // Pass the userID if required
            studentDashboardForm.Show();
            // Optionally, hide the current form
            this.Hide();
        }

    }
}
