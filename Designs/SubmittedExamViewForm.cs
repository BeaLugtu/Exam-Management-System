using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Exam_Management_System.Designs
{
    public interface IQuestionCard
    {
        (string QuestionID, string Answer, string CorrectAnswer, string Point, bool iscorrect) GetAnswerData();
    }
    public partial class SubmittedExamViewForm : Krypton.Toolkit.KryptonForm
    {
        private bool submit_Clicked = false;
        private int cardCount = 0;
        private string userID;
        private DateTime examDeadline;
        private Timer countdownTimer;
        private string ExamCode;
        DBAccess objDABAccess = new DBAccess();
        DataTable dtloggedin_User = new DataTable();
        private DataTable answersTable;
        private examSubmitSuccess sdboard;


        public SubmittedExamViewForm(string userID, string examcode)
        {
            this.userID = userID.ToString();
            this.ExamCode = examcode.ToString();
            string query = "Select * from examquestions Where ID= '" + userID + "'";
            objDABAccess.readDatathroughAdapter(query, dtloggedin_User);
            UniqueCodeLBL.Text = ExamCode;
            this.Load += new EventHandler(SubmittedExamViewForm_Load);
            setLabels();
        }
        private void setLabels()
        {
            //string query = "Select * from examforms e join users u on e.teacherID = u.User_TypeID Where examcode = '" + ExamCode + "'";
            string query = "Select * from examforms e join users u on e.teacherID = u.ID Where examcode = '" + ExamCode + "'";
            objDABAccess.readDatathroughAdapter(query, dtloggedin_User);

            if (dtloggedin_User.Rows.Count > 0)
            {
                DateTime examDeadlineDate = DateTime.Parse(dtloggedin_User.Rows[0]["examdeadlinedate"].ToString());
                TimeSpan examDeadlineTime = TimeSpan.Parse(dtloggedin_User.Rows[0]["examdeadlinetime"].ToString());
                examDeadline = examDeadlineDate.Date + examDeadlineTime;

                countdownTimer = new Timer();
                countdownTimer.Interval = 1000;
                countdownTimer.Tick += CountdownTimer_Tick;
                countdownTimer.Start();
                string lname = (dtloggedin_User.Rows[0]["Last_name"].ToString());
                string fname = (dtloggedin_User.Rows[0]["First_name"].ToString());
                ProfessorPH.Text = "Prof. " + lname + " " + fname;
                titlePH.Text = (dtloggedin_User.Rows[0]["examtitle"].ToString());

            }
            else
            {
                MessageBox.Show("No exam found with the given code.");
            }
        }
        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan remainingTime = examDeadline - DateTime.Now;

            if (remainingTime.TotalSeconds > 0)
            {
                int totalHours = (int)remainingTime.TotalHours; // Total hours including days
                int days = (int)remainingTime.TotalDays; // Extract days
                int hours = totalHours % 24; // Remaining hours after subtracting complete days
                int minutes = remainingTime.Minutes;
                int seconds = remainingTime.Seconds;

                // Convert remaining days to hours and add to the hour count
                hours += days * 24;

                // Display remaining time
                timePH.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
                timePH.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
            }
            else
            {
                timePH.Text = "00:00:00";
                countdownTimer.Stop();
                MessageBox.Show("The exam deadline has been reached.");
            }
        }


        private FlowLayoutPanel cardplaceholderpanel;

        private void SubmittedExamViewForm_Load(object sender, EventArgs e)
        {
            AddCard();
        }
        private void AddCard()
        {
            // Construct the table name dynamically
            string tableName = ExamCode + "_answers";

            // Construct the SQL query to retrieve data from the specified table
            string query = "SELECT * FROM " + tableName + " ea JOIN examquestions eq ON ea.ID = eq.ID";

            // Create a DataTable to hold the retrieved data
            DataTable dtQuestionsRand = new DataTable();

            // Execute the query and fill the DataTable
            objDABAccess.readDatathroughAdapter(query, dtQuestionsRand);

            // Iterate over the rows in the DataTable
            foreach (DataRow row in dtQuestionsRand.Rows)
            {
                cardCount++;
                string questionType = row["question_type"].ToString();
                string questionText = row["question"].ToString();
                string pointlbl = row["point"].ToString();
                string Cardcount = cardCount.ToString();
                string contextget = row["contextual_paragraph"].ToString();
                byte[] imageBytes = row["image"] as byte[];
                string questionID = row["ID"].ToString();

                // Retrieve the correct answer from the concatenated identification and multiple-choice answer
                string correctAnswer = row["CorrectAnswer"].ToString();

                switch (questionType)
                {
                    case "Identification":
                        IdentificationCard identificationCard = new IdentificationCard
                        {
                            QuestionText = questionText,
                            Point = pointlbl,
                            Qnum = Cardcount,
                            QuestionID = questionID,
                            CorrectAnswer = correctAnswer
                        };
                        cardplaceholder.Controls.Add(identificationCard);
                        break;

                    case "Paragraph Form":
                        ParagraphCard paragraphCard = new ParagraphCard
                        {
                            QuestionText = questionText,
                            Point = pointlbl,
                            qnum = Cardcount,
                            QuestionID = questionID,
                            // Add any other necessary properties for paragraph card
                        };
                        cardplaceholder.Controls.Add(paragraphCard);
                        break;

                    case "Multiple Choice":
                        string[] choices = row["multiplechoice_choices"].ToString().Split(',');
                        MultipleChoiceCard multipleChoiceCard = new MultipleChoiceCard
                        {
                            QuestionText = questionText,
                            Options = choices,
                            Point = pointlbl,
                            QuestionNumber = Cardcount,
                            QuestionID = questionID,
                            CorrectAnswer = correctAnswer
                        };
                        cardplaceholder.Controls.Add(multipleChoiceCard);
                        break;

                    case "Contextual Paragraph":
                        ContextualCard contextualParagraphCard = new ContextualCard
                        {
                            contextget = contextget
                            // Add any other necessary properties for contextual paragraph card
                        };
                        cardCount--;
                        cardplaceholder.Controls.Add(contextualParagraphCard);
                        break;

                    case "Contextual Image":
                        ContextualImageCard contextualImageCard = new ContextualImageCard
                        {
                            ImageBytes = imageBytes
                        };
                        cardCount--;
                        cardplaceholder.Controls.Add(contextualImageCard);
                        break;

                    case "Contextual Paragraph & Image":
                        ContextualImageParagraphCard contextualImageAndParagraphCard = new ContextualImageParagraphCard
                        {
                            ImageBytes = imageBytes,
                            contextget = contextget
                            // Add any other necessary properties for contextual image and paragraph card
                        };
                        cardCount--;
                        cardplaceholder.Controls.Add(contextualImageAndParagraphCard);
                        break;

                    default:
                        // Handle unknown question types if needed
                        break;
                }
            }
        }
    }
}

