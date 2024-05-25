using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;

namespace Exam_Management_System.Designs
{
    public interface IQuestionCard
    {
        (string QuestionID, string Answer) GetAnswerData();
    }
    public partial class ExamForm : Krypton.Toolkit.KryptonForm
    {
        private int cardCount = 0;
        private string userID;
        private DateTime examDeadline;
        private Timer countdownTimer;
        private string ExamCode;
        DBAccess objDABAccess = new DBAccess();
        DataTable dtloggedin_User = new DataTable();
        private DataTable answersTable;

        public ExamForm(string userID, string examcode)
        {
            InitializeComponent();
            this.userID = userID.ToString();
            this.ExamCode = examcode.ToString();
            string query = "Select * from examquestions Where ID= '" + userID + "'";
            objDABAccess.readDatathroughAdapter(query, dtloggedin_User);
            UniqueCodeLBL.Text = ExamCode;
            this.Load += new EventHandler(ExamForm_Load);
            setLabels();
            InitializeAnswersTable();
        }
        private void InitializeAnswersTable()
        {
            answersTable = new DataTable();
            answersTable.Columns.Add("QuestionNumber", typeof(string));
            answersTable.Columns.Add("Answer", typeof(string));
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
                ProfessorPH.Text = "Prof. "+lname + " " + fname;
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
            }
            else
            {
                timePH.Text = "00:00:00";
                countdownTimer.Stop();
                MessageBox.Show("The exam deadline has been reached.");
            }
        }


        private FlowLayoutPanel cardplaceholderpanel;

        private void ExamForm_Load(object sender, EventArgs e)
        {
            AddCard();
        }
        private void AddCard()
        {

            { //random
                string query = "SELECT id, questionNumber, examCode, question_type, question, point, manual_check, identification, paragraph_type, multiplechoice_answer, contextual_paragraph, multiplechoice_choices, image FROM examquestions WHERE (( randomizer = 1) && (examcode = '" + ExamCode + "')) ORDER BY rand()";
                //not random
                //string query = "SELECT questionNumber, examCode, question_type, question, point, manual_check, identification, paragraph_type, multiplechoice_answer, contextual_paragraph, multiplechoice_choices, image FROM examquestions WHERE examcode = '" + ExamCode + "' ORDER BY questionnumber";
                DataTable dtQuestionsRand = new DataTable();
                objDABAccess.readDatathroughAdapter(query, dtQuestionsRand);

                foreach (DataRow row in dtQuestionsRand.Rows)
                {
                    cardCount++;
                    string questionType = row["question_type"].ToString();
                    string questionText = row["question"].ToString();
                    string pointlbl = row["point"].ToString();
                    string Cardcount = cardCount.ToString();
                    string contextget = row["contextual_paragraph"].ToString();
                    byte[] imageBytes = row["image"] as byte[];
                    string QuestionID = row["ID"].ToString();

                    switch (questionType)
                    {
                        case "Identification":
                            IdentificationCard identificationCard = new IdentificationCard
                            {
                                QuestionText = questionText,
                                AnswerText = "",
                                Point = pointlbl,
                                Qnum = Cardcount,
                                QuestionID = QuestionID
                            };
                            cardplaceholder.Controls.Add(identificationCard);
                            break;

                        case "Paragraph Form":
                            ParagraphCard ParagraphCard = new ParagraphCard
                            {
                                QuestionText = questionText,
                                point = pointlbl,
                                qnum = Cardcount,
                                QuestionID = QuestionID

                                // Add any other necessary properties for paragraph card
                            };
                            cardplaceholder.Controls.Add(ParagraphCard);
                            break;

                        case "Multiple Choice":
                            string[] choices = row["multiplechoice_choices"].ToString().Split(',');
                            MultipleChoiceCard multipleChoiceCard = new MultipleChoiceCard
                            {
                                QuestionText = questionText,
                                Options = choices,
                                point = pointlbl,
                                qnum = Cardcount,
                                QuestionID = QuestionID
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
                //string query = "SELECT id, questionNumber, examCode, question_type, question, point, manual_check, identification, paragraph_type, multiplechoice_answer, contextual_paragraph, multiplechoice_choices, image FROM examquestions WHERE (( randomizer = 1) && (examcode = '" + ExamCode + "')) ORDER BY rand()";
                //not random
            }
            { 
            string query2 = "SELECT id, questionNumber, examCode, question_type, question, point, manual_check, identification, paragraph_type, multiplechoice_answer, contextual_paragraph, multiplechoice_choices, image FROM examquestions WHERE ((randomizer = 0) && (examcode = '" + ExamCode + "'))";
            DataTable dtQuestionsCon = new DataTable();
            objDABAccess.readDatathroughAdapter(query2, dtQuestionsCon);
            foreach (DataRow row in dtQuestionsCon.Rows)
            {
                cardCount++;
                string questionType = row["question_type"].ToString();
                string questionText = row["question"].ToString();
                string pointlbl = row["point"].ToString();
                string Cardcount = cardCount.ToString();
                string contextget = row["contextual_paragraph"].ToString();
                byte[] imageBytes = row["image"] as byte[];
                string QuestionID = row["ID"].ToString();

                switch (questionType)
                {
                    case "Identification":
                        IdentificationCard identificationCard = new IdentificationCard
                        {
                            QuestionText = questionText,
                            AnswerText = "",
                            Point = pointlbl,
                            Qnum = Cardcount,
                            QuestionID = QuestionID
                        };
                        cardplaceholder.Controls.Add(identificationCard);
                        break;

                    case "Paragraph Form":
                        ParagraphCard ParagraphCard = new ParagraphCard
                        {
                            QuestionText = questionText,
                            point = pointlbl,
                            qnum = Cardcount,
                            QuestionID = QuestionID

                            // Add any other necessary properties for paragraph card
                        };
                        cardplaceholder.Controls.Add(ParagraphCard);
                        break;

                    case "Multiple Choice":
                        string[] choices = row["multiplechoice_choices"].ToString().Split(',');
                        MultipleChoiceCard multipleChoiceCard = new MultipleChoiceCard
                        {
                            QuestionText = questionText,
                            Options = choices,
                            point = pointlbl,
                            qnum = Cardcount,
                            QuestionID = QuestionID
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
        private void SubmitExam()
        {
            dataGridView1.DataSource = answersTable;
            answersTable.Clear(); // Clear any existing data

            foreach (Control control in cardplaceholder.Controls)
            {
                if (control is IQuestionCard questionCard)
                {
                    var answerData = questionCard.GetAnswerData();
                    DataRow row = answersTable.NewRow();
                    row["QuestionID"] = answerData.QuestionID;
                    row["Answer"] = answerData.Answer;
                    answersTable.Rows.Add(row);
                }
            }

            // Optionally, display or debug the DataTable
            foreach (DataRow row in answersTable.Rows)
            {
                Console.WriteLine($"{row["QuestionNumber"]} === {row["Answer"]}");
            }
            

        }
        
        private void UpdateAnswersInDatabase()
        {
            string tableName = ExamCode + "_answers";
            string userAnswersColumn = userID + "_answers";

            foreach (DataRow row in answersTable.Rows)
            {
                string questionNumber = row["QuestionNumber"].ToString();
                string answer = row["Answer"].ToString();

                string updateQuery = $"UPDATE {tableName} SET {userAnswersColumn} = @Answer WHERE QuestionID = @QuestionNumber";
                MySqlCommand updateCommand = new MySqlCommand(updateQuery);
                updateCommand.Parameters.AddWithValue("@Answer", answer);
                updateCommand.Parameters.AddWithValue("@QuestionNumber", questionNumber);

                try
                {
                    objDABAccess.executeQuery(updateCommand);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                    MessageBox.Show($"Error updating answers: {ex.Message}");
                }
            }
        }
        private void AlterAnswersTable()
        {
            string tableName = ExamCode + "_answers";
            string userAnswersColumn = userID + "_answers";
            string userPointsColumn = userID + "_points";

            string alterTableQuery = $"ALTER TABLE {tableName} ADD COLUMN IF NOT EXISTS {userAnswersColumn} TEXT, ADD COLUMN IF NOT EXISTS {userPointsColumn} TEXT";
            MySqlCommand alterCommand = new MySqlCommand(alterTableQuery);

            try
            {
                objDABAccess.executeQuery(alterCommand);
            }
            catch (Exception ex)
            {
                // Handle the exception, maybe the column already exists
                MessageBox.Show($"Error altering table: {ex.Message}");
            }
        }
        private void AutoCheckAnswers()
        {
            string tableName = ExamCode + "_answers";
            string userAnswersColumn = userID + "_answers";
            string userPointsColumn = userID + "_points";

            string selectQuery = $"SELECT eq.questionNumber, eq.question_type, eq.manual_check, eq.identification, eq.paragraph_type, eq.multiplechoice_answer, ea.{userAnswersColumn}, ea.{userPointsColumn} " +
                                 $"FROM examquestions eq " +
                                 $"JOIN {tableName} ea ON eq.questionNumber = ea.QuestionID " +
                                 $"WHERE eq.examcode = '@ExamCode'";

            DataTable dtAnswers = new DataTable();
            MySqlCommand selectCommand = new MySqlCommand(selectQuery);
            selectCommand.Parameters.AddWithValue("@ExamCode", ExamCode);
            objDABAccess.readDatathroughAdapter(selectQuery, dtAnswers);

            foreach (DataRow row in dtAnswers.Rows)
            {
                string questionID = row["questionNumber"].ToString();
                string questionType = row["question_type"].ToString();
                bool manualChecking = Convert.ToBoolean(row["manual_check"]);
                string correctAnswer = row["identification"].ToString();
                string studentAnswer = row[userAnswersColumn].ToString();
                int points = 0;

                if (manualChecking)
                {
                    // Update the table with 'wow'
                    string updateQueryWow = $"UPDATE {tableName} SET {userPointsColumn} = 'wow' WHERE QuestionID = @QuestionID";
                    MySqlCommand updateCommandWow = new MySqlCommand(updateQueryWow);
                    updateCommandWow.Parameters.AddWithValue("@QuestionID", questionID);

                    try
                    {
                        objDABAccess.executeQuery(updateCommandWow);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating points: {ex.Message}");
                    }

                    // Skip automatic checking
                    continue;
                }

                // Your existing logic for automatic checking goes here
                // ...
                if (!manualChecking)
                {
                    continue;
                }

                switch (questionType)
                {
                    case "Identification":
                        // Check if student answer matches correct answer
                        if (studentAnswer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
                        {
                            // Set points to the points obtained by the student
                            points = Convert.ToInt32(row[userPointsColumn]);
                        }
                        break;

                    case "Paragraph Form":
                        if (studentAnswer.IndexOf(row["paragraph_type"].ToString(), StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            points = 1;
                        }
                        break;


                    case "Multiple Choice":
                        // Check if student answer matches correct multiple choice answer
                        if (studentAnswer.Equals(row["multiplechoice_answer"].ToString(), StringComparison.OrdinalIgnoreCase))
                        {
                            // Set points to the points obtained by the student
                            points = Convert.ToInt32(row[userPointsColumn]);
                        }
                        break;

                    default:
                        // Handle other question types or unknown types
                        break;
                }

                // Update the points in the database
                string updateQuery = $"UPDATE {tableName} SET {userPointsColumn} = @Points WHERE QuestionID = @QuestionID";
                MySqlCommand updateCommand = new MySqlCommand(updateQuery);
                updateCommand.Parameters.AddWithValue("@Points", points);
                updateCommand.Parameters.AddWithValue("@QuestionID", questionID);

                try
                {
                    objDABAccess.executeQuery(updateCommand);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating points: {ex.Message}");
                }
            }
        }

        private void Submit(object sender, EventArgs e)
        {
            AlterAnswersTable();
            SubmitExam();
            UpdateAnswersInDatabase();
            AutoCheckAnswers();
        }

    }

}

