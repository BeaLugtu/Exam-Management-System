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
using Mysqlx.Crud;
using Org.BouncyCastle.Asn1.Crmf;
using Org.BouncyCastle.Bcpg;

namespace Exam_Management_System.Designs
{
    public interface IQuestionCard
    {
        (string QuestionID, string Answer, string CorrectAnswer, string Point, bool iscorrect) GetAnswerData();
    }
    public partial class ExamForm : Krypton.Toolkit.KryptonForm
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
            answersTable.Columns.Add("ID", typeof(string));
            answersTable.Columns.Add("Answer", typeof(string));
            answersTable.Columns.Add("CorrectAnswer", typeof(string));
            answersTable.Columns.Add("iscorrect", typeof(bool));
            answersTable.Columns.Add("Point", typeof(int));
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
                //string query = "Select * from examquestions where (( question_Type = 'multiple choice') && (examcode = '" + ExamCode + "'))";
            {   //random
                string query = "SELECT id, questionNumber, examCode, question_type, question, point, manual_check, identification, paragraph_type," +
                    " multiplechoice_answer, contextual_paragraph, multiplechoice_choices, image FROM examquestions eq WHERE (( randomizer = 1) && " +
                    "(examcode = '" + ExamCode + "')) ORDER BY rand()";
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
                    string CorrectAnswer = row["identification"].ToString();
                    string CorrectAnswer2 = row["multiplechoice_answer"].ToString();
                    switch (questionType)
                    {
                        case "Identification":

                            IdentificationCard identificationCard = new IdentificationCard
                            {
                                QuestionText = questionText,
                                Point = pointlbl,
                                Qnum = Cardcount,
                                QuestionID = QuestionID,
                                CorrectAnswer = CorrectAnswer
                            };
                            cardplaceholder.Controls.Add(identificationCard);
                            break;

                        case "Paragraph Form":
                            ParagraphCard ParagraphCard = new ParagraphCard
                            {
                                QuestionText = questionText,
                                Point = pointlbl,
                                qnum = Cardcount,
                                QuestionID = QuestionID,
                                
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
                                Point = pointlbl,
                                QuestionNumber = Cardcount,
                                QuestionID = QuestionID,
                                CorrectAnswer = CorrectAnswer2
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
            string query2 = "SELECT id, questionNumber, examCode, question_type, question, point, manual_check, identification, paragraph_type, multiplechoice_answer," +
                    " contextual_paragraph, multiplechoice_choices, image FROM examquestions WHERE ((randomizer = 0) && (examcode = '" + ExamCode + "'))";
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
                    string CorrectAnswer = row["identification"].ToString();
                    string CorrectAnswer2 = row["multiplechoice_answer"].ToString();
                    switch (questionType)
                    {
                        case "Identification":

                            IdentificationCard identificationCard = new IdentificationCard
                            {
                                QuestionText = questionText,
                                Point = pointlbl,
                                Qnum = Cardcount,
                                QuestionID = QuestionID,
                                CorrectAnswer = CorrectAnswer
                            };
                            cardplaceholder.Controls.Add(identificationCard);
                            break;

                        case "Paragraph Form":
                            ParagraphCard ParagraphCard = new ParagraphCard
                            {
                                QuestionText = questionText,
                                Point = pointlbl,
                                qnum = Cardcount,
                                QuestionID = QuestionID,

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
                                Point = pointlbl,
                                QuestionNumber = Cardcount,
                                QuestionID = QuestionID,
                                CorrectAnswer = CorrectAnswer2
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
    //dataGridView1.DataSource = answersTable;
    answersTable.Clear(); // Clear any existing data

    foreach (Control control in cardplaceholder.Controls)
    {
        if (control is IQuestionCard questionCard)
        {
            var answerData = questionCard.GetAnswerData();
            DataRow row = answersTable.NewRow();
            row["ID"] = answerData.QuestionID;
            row["Answer"] = answerData.Answer;
            row["CorrectAnswer"] = answerData.CorrectAnswer;
            row["Point"] = answerData.Point;

            // Compare answer to correctAnswer disregarding case, period, and comma
            string normalizedAnswer = answerData.Answer?.ToLowerInvariant().Replace(".", "").Replace(",", "");
            string normalizedCorrectAnswer = answerData.CorrectAnswer?.ToLowerInvariant().Replace(".", "").Replace(",", "");

            if (normalizedAnswer == normalizedCorrectAnswer)
            {
                row["iscorrect"] = true;
                row["Point"] = row["Point"].ToString();
            }
            else
            {
                row["iscorrect"] = false;
                row["Point"] = "0";
            }

            // If answer is null, set point to null
            if (string.IsNullOrEmpty(answerData.Answer))
            {
                row["Point"] = DBNull.Value;
            }

            answersTable.Rows.Add(row);
        }
    }


            


            // Optionally, display or debug the DataTable
            foreach (DataRow row in answersTable.Rows)
            {
                Console.WriteLine($"{row["ID"]} === {row["Answer"]} === {row["iscorrect"]}");
            }
            string updateTotalStudentsQuery = "UPDATE examforms SET examstudentsturnedin = examstudentsturnedin + 1 WHERE examcode = @ExamCode";
            MySqlCommand updateTotalStudentsCommand = new MySqlCommand(updateTotalStudentsQuery);
            updateTotalStudentsCommand.Parameters.AddWithValue("@ExamCode", ExamCode);

            try
            {
                objDABAccess.executeQuery(updateTotalStudentsCommand);
                MessageBox.Show("Total students count updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating total students count: {ex.Message}");
            }
        }



            private void UpdateAnswersInDatabase()
        {
            string tableName = ExamCode + "_answers";
            string userAnswersColumn = userID + "_answers";
            string userPointsColumn = userID + "_points"; // Corrected column name for points

            // Order the rows in answersTable by ID
            var orderedRows = answersTable.AsEnumerable()
                                           .OrderBy(row => row.Field<string>("ID"));

            foreach (DataRow row in orderedRows)
            {
                string questionNumber = row["ID"].ToString();
                string answer = row["Answer"].ToString();
                string point = row["Point"].ToString();

                // Update the answers in the database where ID matches QuestionID
                string updateQuery = $"UPDATE {tableName} SET `{userAnswersColumn}` = @Answer WHERE ID = @ID; " +
                                     $"UPDATE {tableName} SET `{userPointsColumn}` = @Point WHERE ID = @ID"; // Corrected parameter name to @Point
                MySqlCommand updateCommand = new MySqlCommand(updateQuery);
                updateCommand.Parameters.AddWithValue("@Answer", answer);
                updateCommand.Parameters.AddWithValue("@ID", questionNumber);
                updateCommand.Parameters.AddWithValue("@Point", point); // Corrected parameter name to @Point

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

            string alterTableQuery = $"ALTER TABLE {tableName} ADD COLUMN IF NOT EXISTS `{userAnswersColumn}` TEXT, ADD COLUMN IF NOT EXISTS `{userPointsColumn}` TEXT";

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
        // private bool corrext = false;
        /*private void AutoCheckAnswers()
        {
            DataTable dtanswer = new DataTable();
            string tableName = ExamCode + "_answers";
            string columnAnswer = userID + "_answers";
            string columnPoints = userID + "_points";

            string query = $"SELECT eq.id, eq.point, eq.identification, eq.multiplechoice_answer, ea.`{columnAnswer}`, ea.`{columnPoints}` FROM examquestions AS eq " +
                $"JOIN `{tableName}` AS ea ON eq.ID = ea.ID WHERE eq.examCode = '@ExamCode'";

            MySqlCommand selectCommand = new MySqlCommand(query);
            selectCommand.Parameters.AddWithValue("@ExamCode", ExamCode);

            objDABAccess.readDatathroughAdapter(query, dtanswer);

            foreach (DataRow row in dtanswer.Rows)
            {
                string questionID = row["id"].ToString();
                string identificationAnswer = row["identification"].ToString();
                string multipleChoiceAnswer = row["multiplechoice_answer"].ToString();
                string userAnswer = row[columnAnswer].ToString();

                // Check identification answer
                if (!string.IsNullOrEmpty(identificationAnswer) && identificationAnswer.Equals(userAnswer, StringComparison.OrdinalIgnoreCase))
                {
                    corrext= true;
                    if (corrext == true)
                    {
                        string pointed = "1"; // Assigning 1 for correct multiple choice answer
                        string updateQuery = $"UPDATE `{tableName}` SET `{columnPoints}` = '"+pointed+"' WHERE id = '"+questionID+"'";
                        objDABAccess.readDatathroughAdapter(query, dtanswer);
                    }
                }

                // Check multiple choice answer
                if (!string.IsNullOrEmpty(multipleChoiceAnswer) && multipleChoiceAnswer.Equals(userAnswer, StringComparison.OrdinalIgnoreCase))
                {
                    corrext = true;
                    if (corrext == true)
                    {
                        string pointed = "1"; // Assigning 1 for correct multiple choice answer
                        string updateQuery = $"UPDATE `{tableName}` SET `{columnPoints}` = '" + pointed + "' WHERE id = '" + questionID + "'";
                        objDABAccess.readDatathroughAdapter(query, dtanswer);
                    }
                }
            }
        }*/
        private void DisableAllControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                // Recursively disable child controls if the control has child controls
                if (control.HasChildren)
                {
                    DisableAllControls(control.Controls);
                }

                // Disable the control
                control.Enabled = false;
            }
        }

        // Call the method passing the form's Controls collection

        private void Submit(object sender, EventArgs e)
        {
            // Alter answers table
            AlterAnswersTable();

            // Submit the exam
            SubmitExam();

            // Update answers in the database
            UpdateAnswersInDatabase();

            // Set submit_Clicked to true
            submit_Clicked = true;

            // Disable the submit button after it has been clicked
            SubmitBtn.Enabled = false;
            DisableAllControls(this.Controls);
            // Optionally, you can add other functionality here

            // For example, if you want to execute another method like AutoCheckAnswers(),
            // you can uncomment the line below:
            // AutoCheckAnswers();
        }


    }

}

/*private void SubmitExam()
        {
            dataGridView1.DataSource = answersTable;
            answersTable.Clear(); // Clear any existing data

            foreach (Control control in cardplaceholder.Controls)
            {
                if (control is IQuestionCard questionCard)
                {
                    var answerData = questionCard.GetAnswerData();
                    DataRow row = answersTable.NewRow();
                    row["ID"] = answerData.QuestionID;
                    row["Answer"] = answerData.Answer;
                    answersTable.Rows.Add(row);
                }
            }

            // Optionally, display or debug the DataTable
            foreach (DataRow row in answersTable.Rows)
            {
                Console.WriteLine($"{row["ID"]} === {row["Answer"]}");
            }
            

        }

        private void UpdateAnswersInDatabase()
        {
            string tableName = ExamCode + "_answers";
            string userAnswersColumn = userID + "_answers";

            // Order the rows in answersTable by ID
            var orderedRows = answersTable.AsEnumerable()
                                           .OrderBy(row => row.Field<string>("ID"));

            foreach (DataRow row in orderedRows)
            {
                string questionNumber = row["ID"].ToString();
                string answer = row["Answer"].ToString();

                // Update the answers in the database where ID matches QuestionID
                string updateQuery = $"UPDATE {tableName} SET `{userAnswersColumn}` = @Answer WHERE ID = @ID";
                MySqlCommand updateCommand = new MySqlCommand(updateQuery);
                updateCommand.Parameters.AddWithValue("@Answer", answer);
                updateCommand.Parameters.AddWithValue("@ID", questionNumber);

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

            string alterTableQuery = $"ALTER TABLE {tableName} ADD COLUMN IF NOT EXISTS `{userAnswersColumn}` TEXT, ADD COLUMN IF NOT EXISTS `{userPointsColumn}` TEXT";

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
        private bool corrext = false;
        private void AutoCheckAnswers()
        {
            DataTable dtanswer = new DataTable();
            string tableName = ExamCode + "_answers";
            string columnAnswer = userID + "_answers";
            string columnPoints = userID + "_points";

            string query = $"SELECT eq.id, eq.point, eq.identification, eq.multiplechoice_answer, ea.`{columnAnswer}`, ea.`{columnPoints}` FROM examquestions AS eq " +
                $"JOIN `{tableName}` AS ea ON eq.ID = ea.ID WHERE eq.examCode = '@ExamCode'";

            MySqlCommand selectCommand = new MySqlCommand(query);
            selectCommand.Parameters.AddWithValue("@ExamCode", ExamCode);

            objDABAccess.readDatathroughAdapter(query, dtanswer);

            foreach (DataRow row in dtanswer.Rows)
            {
                string questionID = row["id"].ToString();
                string identificationAnswer = row["identification"].ToString();
                string multipleChoiceAnswer = row["multiplechoice_answer"].ToString();
                string userAnswer = row[columnAnswer].ToString();

                // Check identification answer
                if (!string.IsNullOrEmpty(identificationAnswer) && identificationAnswer.Equals(userAnswer, StringComparison.OrdinalIgnoreCase))
                {
                    corrext= true;
                    if (corrext == true)
                    {
                        string pointed = "1"; // Assigning 1 for correct multiple choice answer
                        string updateQuery = $"UPDATE `{tableName}` SET `{columnPoints}` = '"+pointed+"' WHERE id = '"+questionID+"'";
                        objDABAccess.readDatathroughAdapter(query, dtanswer);
                    }
                }

                // Check multiple choice answer
                if (!string.IsNullOrEmpty(multipleChoiceAnswer) && multipleChoiceAnswer.Equals(userAnswer, StringComparison.OrdinalIgnoreCase))
                {
                    corrext = true;
                    if (corrext == true)
                    {
                        string pointed = "1"; // Assigning 1 for correct multiple choice answer
                        string updateQuery = $"UPDATE `{tableName}` SET `{columnPoints}` = '" + pointed + "' WHERE id = '" + questionID + "'";
                        objDABAccess.readDatathroughAdapter(query, dtanswer);
                    }
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

}*/

/*private void ExamForm_Load(object sender, EventArgs e)
        {
            AddCard();
        }
        private void AddCard()
        {
                //string query = "Select * from examquestions where (( question_Type = 'multiple choice') && (examcode = '" + ExamCode + "'))";
            {   //random
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
                }*/