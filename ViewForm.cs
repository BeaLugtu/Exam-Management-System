using Exam_Management_System.Designs.Answer_Cards;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace Exam_Management_System.Designs
{
    public partial class ViewForm : Form
    {
        DBAccess objDABAccess = new DBAccess();
        DataTable dtloggedin_User = new DataTable(); 
        private DateTime examDeadline;
        private Timer countdownTimer;
        private string ExamCode;
        private DBAccess dbAccess;
        private string userID;
        private Size originalSize;
        private Size originalImageSize;
        private Image originalImage;

        private Size originalSizeNotificationBtn;
        private Size originalImageSizeNotificationBtn;
        private Image originalImageNotificationBtn;

        public ViewForm(string userID, string examCode)
        {
            InitializeComponent();
            this.ExamCode = examCode;
            this.userID = userID;
            this.dbAccess = new DBAccess();  // Instantiate DBAccess
            setLabels();
        }
        private void setLabels()
        {
            //string query = "Select * from examforms e join users u on e.teacherID = u.User_TypeID Where examcode = '" + ExamCode + "'";
            UniqueCodeLBL.Text = "Exam Code: " + ExamCode;
            string query = "Select * from studenthistory Where ((studentID = '" + userID + "')&&(Examcode = '"+ExamCode+"'))";
            objDABAccess.readDatathroughAdapter(query, dtloggedin_User);

            if (dtloggedin_User.Rows.Count > 0)
            {
                //timePH.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
                string prof = (dtloggedin_User.Rows[0]["prof_assigned"].ToString());
                string dateString = dtloggedin_User.Rows[0]["time_turnedin"].ToString();
                ProfessorPH.Text = "Prof. " + prof;
                titlePH.Text = (dtloggedin_User.Rows[0]["title"].ToString());
                timePH.Text = dateString;
            }
            else
            {
                MessageBox.Show("No exam found with the given code.");
            }
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            AddCard();
        }
        private void AddCard()
        {string tablename = ExamCode + "_answers"; 
            string useranswer = userID + "_answers"; 
            string userpoints = userID + "_points";
            string query2 = "SELECT * FROM examquestions as eq" +
                " join "+ tablename+ " as ea on eq.ID = ea.ID WHERE examcode = '" + ExamCode + "' order by eq.id";
            DataTable dtQuestionsCon = new DataTable();
            objDABAccess.readDatathroughAdapter(query2, dtQuestionsCon);
            foreach (DataRow row in dtQuestionsCon.Rows)
            {
                string questionType = row["question_type"].ToString();
                string questionText = row["question"].ToString();
                string pointlbl = row[userpoints].ToString();
                string pointtotal = row["point"].ToString();
                string answer = row[useranswer].ToString();
                string Cardcount = row["questionnumber"].ToString();
                string contextget = row["contextual_paragraph"].ToString();
                byte[] imageBytes = row["image"] as byte[];
                string QuestionID = row["ID"].ToString();
                string CorrectAnswer = row["identification"].ToString();
                string CorrectAnswer2 = row["multiplechoice_answer"].ToString();

                switch (questionType)
                {
                    case "Identification":
                        studentShortAnswer StudentShortAnswer = new studentShortAnswer
                        {
                            QuestionText = questionText,
                            AnswerText = answer,
                            CorrectAns = CorrectAnswer,
                            Point = pointlbl,
                            Qnum = Cardcount,
                            QuestionID = QuestionID,
                            Upoint = pointtotal
                        };
                        flowLayoutViewFormList.Controls.Add(StudentShortAnswer);
                        break;

                    case "Paragraph Form":
                        studentParagraph ParagraphCard = new studentParagraph
                        {
                            QuestionText = questionText,
                            AnswerText = answer,
                            point = pointlbl,
                            qnum = Cardcount,
                            QuestionID = QuestionID,
                            Upoint = pointtotal
                            // Add any other necessary properties for paragraph card
                        };
                        flowLayoutViewFormList.Controls.Add(ParagraphCard);
                        break;

                    case "Multiple Choice":
                        string[] choices = row["multiplechoice_choices"].ToString().Split(',');
                        studentMultipleChoice multipleChoiceCard = new studentMultipleChoice
                        {
                            QuestionText = questionText,
                            Options = choices,
                            point = pointlbl,
                            qnum = Cardcount,
                            QuestionID = QuestionID,
                            SelectedOption = answer,
                            CorrectAns= CorrectAnswer2,
                            Upoint = pointtotal

                        };
                        flowLayoutViewFormList.Controls.Add(multipleChoiceCard);
                        break;

                    case "Contextual Paragraph":
                        ContextualCard contextualParagraphCard = new ContextualCard
                        {
                            contextget = contextget
                            // Add any other necessary properties for contextual paragraph card
                        };
                        flowLayoutViewFormList.Controls.Add(contextualParagraphCard);
                        break;

                    case "Contextual Image":

                        ContextualImageCard contextualImageCard = new ContextualImageCard
                        {
                            ImageBytes = imageBytes
                        };
                        flowLayoutViewFormList.Controls.Add(contextualImageCard);
                        break;

                    case "Contextual Paragraph & Image":
                        ContextualImageParagraphCard contextualImageAndParagraphCard = new ContextualImageParagraphCard
                        {
                            ImageBytes = imageBytes,
                            contextget = contextget
                            // Add any other necessary properties for contextual image and paragraph card
                        };
                        flowLayoutViewFormList.Controls.Add(contextualImageAndParagraphCard);
                        break;

                    default:
                        // Handle unknown question types if needed
                        break;
                }
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
        private void BackBtn_Click(object sender, EventArgs e)
        {
            // Show the RecentForm with the userID
            RecentForm recentForm = new RecentForm(userID);
            recentForm.Show();

            // Close this form
            this.Close();
        }
    }
}