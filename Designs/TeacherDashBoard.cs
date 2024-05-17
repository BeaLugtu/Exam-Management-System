
﻿
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

﻿using MySql.Data.MySqlClient;

using System.Data;

using System.Windows.Forms;
using Krypton.Toolkit;

namespace Exam_Management_System.Designs
{
    public partial class TeacherDashBoard : Form
    {

        private Size originalSize;
        private Size originalImageSize;
        private Image originalImage;
        private Size originalSizePictureBox6;


        private readonly DBAccess dbAccess = new DBAccess();


        public TeacherDashBoard()
        {
            InitializeComponent();
            this.Load += TeacherDashBoard_Load;

            // Start a timer to update the time label every second
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second interval
            timer.Tick += Timer_Tick;
            timer.Start();


            originalSize = kryptonButton5.Size;
            // Save the original size of the image
            originalImageSize = kryptonButton5.Values.Image.Size;
            // Save the original image
            originalImage = kryptonButton5.Values.Image;
            kryptonButton5.MouseEnter += KryptonButton5_MouseEnter;
            kryptonButton5.MouseLeave += KryptonButton5_MouseLeave;

            originalSizePictureBox6 = kryptonPictureBox6.Size;

            // Handle mouse enter and mouse leave events for the picture box
            kryptonPictureBox6.MouseEnter += KryptonBox6_MouseEnter;
            kryptonPictureBox6.MouseLeave += KryptonBox6_MouseLeave;


        }

        private void TeacherDashBoard_Load(object sender, EventArgs e)
        {
            UpdateTimeLabel();
            PopulateFlowLayoutPanel();
        }

        private void KryptonBox6_MouseEnter(object sender, EventArgs e)
        {
            // Enlarge the picture box slightly on hover
            kryptonPictureBox6.Size = new Size(originalSizePictureBox6.Width + 3, originalSizePictureBox6.Height + 3);
        }

        private void KryptonBox6_MouseLeave(object sender, EventArgs e)
        {
            // Restore the original size when the mouse leaves
            kryptonPictureBox6.Size = originalSizePictureBox6;
        }

        // Method to populate the flowLayoutTablelistExam with teacherExamHistoCard controls
        private void PopulateFlowLayoutPanel()
        {
            DataTable examData = new DataTable();
            dbAccess.readDatathroughAdapter("SELECT * FROM examforms", examData);

            foreach (DataRow row in examData.Rows)
            {
                teacherExamHistoCard examCard = new teacherExamHistoCard(DeleteExamCard);
                examCard.SetTitle(row["examTitle"].ToString());
                examCard.SetCode(row["examCode"].ToString());
                examCard.SetTotalSubmittedStudents(Convert.ToInt32(row["examTotalStudents"]));
                examCard.SetCreatedDateTime(Convert.ToDateTime(row["examCreated"]));
                examCard.SetDeadlineDateTime(Convert.ToDateTime(row["examDeadlineDate"]));
                examCard.SetStatus(row["examStatus"].ToString());

                flowLayoutTablelistExam.Controls.Add(examCard);
            }
        }

        // Update the time label with the current time
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


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {

        }

        private void KryptonButton5_MouseEnter(object sender, EventArgs e)
        {
            // Enlarge the button slightly on hover
            kryptonButton5.Size = new Size(originalSize.Width + 3, originalSize.Height + 3);
            // Enlarge the image slightly on hover
            kryptonButton5.Values.Image = new Bitmap(originalImage, new Size(originalImageSize.Width + 3, originalImageSize.Height + 3));
        }

        // Mouse leave event handler for the button
        private void KryptonButton5_MouseLeave(object sender, EventArgs e)
        {
            // Restore the original size when the mouse leaves
            kryptonButton5.Size = originalSize;
            // Restore the original image when the mouse leaves
            kryptonButton5.Values.Image = originalImage;
        }


        private void DeleteExamCard(string examCode)
        {
            try
            {
                // Construct the SQL query to select the record to be archived
                string selectQuery = $"SELECT * FROM examforms WHERE examCode = '{examCode}'";

                // Read the data from the examforms table
                DataTable examData = new DataTable();
                dbAccess.readDatathroughAdapter(selectQuery, examData);

                // Construct the SQL query to insert the record into the examFormsArchive table
                string insertQuery = $"INSERT INTO examFormsArchive (examTitle, examCode, examTotalStudents, examCreated, examDeadlineDate, examStatus) " +
                                     $"VALUES ('{examData.Rows[0]["examTitle"]}', '{examData.Rows[0]["examCode"]}', " +
                                     $"'{examData.Rows[0]["examTotalStudents"]}', '{examData.Rows[0]["examCreated"]}', " +
                                     $"'{examData.Rows[0]["examDeadlineDate"]}', '{examData.Rows[0]["examStatus"]}')";

                // Execute the insert query to archive the record
                dbAccess.executeQuery(new MySqlCommand(insertQuery));

                // Construct the SQL query to delete the record from the examforms table
                string deleteQuery = $"DELETE FROM examforms WHERE examCode = '{examCode}'";

                // Execute the delete query
                dbAccess.executeQuery(new MySqlCommand(deleteQuery));
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the exam: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
