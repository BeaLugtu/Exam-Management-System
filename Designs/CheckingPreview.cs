using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Exam_Management_System.Designs
{
    public partial class CheckingPreview : Form
    {
        string connectionString = "Server=26.96.197.206;Database=exam.io;Uid=admin;Pwd=admin;";

        public CheckingPreview()
        {
            InitializeComponent();
            PopulateListView();

            // Subscribe to the SelectedIndexChanged event
            respondents_LV.SelectedIndexChanged += Respondents_LV_SelectedIndexChanged;

        }

        public void SetExamCode(string code)
        {
            code_LBL.Text = code;
            string examTitle = GetExamTitle(code);
            if (!string.IsNullOrEmpty(examTitle))
            {
                examTitle_LBL.Text = examTitle;
            }

            // Call method to populate list view and load questions and answers
            PopulateListView();
            LoadQuestionsAndAnswers();
        }

        private string GetExamTitle(string examCode)
        {
            string title = string.Empty;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT title FROM studenthistory WHERE examCode = @ExamCode LIMIT 1";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ExamCode", examCode);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        title = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching the exam title: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return title;
        }


        private void PopulateListView()
        {
            string examCode = code_LBL.Text;
            // Clear existing items in list view
            respondents_LV.Items.Clear();

            // Initialize a DataTable to hold the results
            DataTable dt = new DataTable();

            try
            {
                // Open a connection
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Fetch student names from database based on exam code
                    string query = "SELECT studentName FROM studenthistory WHERE examCode = @ExamCode";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ExamCode", examCode);

                    // Execute the query
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dt);
                }

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        // Add student names to list view
                        respondents_LV.Items.Add(row["studentName"].ToString());
                    }

                    // Highlight the first student in the list view by default
                    respondents_LV.Items[0].Selected = true;
                }
                else
                {
                    // If no matching records found, display a message or handle it accordingly
                    MessageBox.Show("No students found for the specified exam code.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("An error occurred while fetching data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Respondents_LV_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load questions and answers for the selected student
            LoadQuestionsAndAnswers();
        }

        private void LoadQuestionsAndAnswers()
        {
            string examCode = code_LBL.Text;
            questions_FLP.Controls.Clear();

            if (respondents_LV.SelectedItems.Count == 0)
            {
                return;
            }

            string selectedStudentName = respondents_LV.SelectedItems[0].Text;
            string studentID = GetStudentID(selectedStudentName);

            if (string.IsNullOrEmpty(studentID))
            {
                MessageBox.Show("Unable to find the student ID for the selected student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string timeTurnedin = GetTimeTurnedin(examCode, studentID);
            timeTurnedin_LBL.Text = "Time Finished: " + timeTurnedin;

            DataTable questionsDt = new DataTable();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string questionsQuery = "SELECT questionNumber, question, question_type, contextual_paragraph, image, multiplechoice_choices, identification, multiplechoice_answer, point FROM examquestions WHERE examCode = @ExamCode";
                    MySqlCommand questionsCommand = new MySqlCommand(questionsQuery, connection);
                    questionsCommand.Parameters.AddWithValue("@ExamCode", examCode);

                    MySqlDataAdapter questionsAdapter = new MySqlDataAdapter(questionsCommand);
                    questionsAdapter.Fill(questionsDt);
                }

                foreach (DataRow questionRow in questionsDt.Rows)
                {
                    string questionType = questionRow["question_type"].ToString();
                    TeacherCheckingCard card = new TeacherCheckingCard();

                    // Fetch and set the point value with "/" character
                    string pointValue = questionRow["point"].ToString();
                    card.OverScoreText = pointValue; // Assigning point value

                    if (questionType == "Contextual Paragraph")
                    {
                        card.ContextualParaOnlyText = questionRow["contextual_paragraph"].ToString();
                        card.HideNonContextualParagraphControls();
                    }
                    else if (questionType == "Contextual Image")
                    {
                        byte[] imageBytes = (byte[])questionRow["image"];
                        using (var ms = new System.IO.MemoryStream(imageBytes))
                        {
                            card.ContextualPicOnlyImage = Image.FromStream(ms);
                        }
                        card.HideNonContextualImageControls();
                    }
                    else if (questionType == "Contextual Paragraph & Image")
                    {
                        card.ContextualParaText = questionRow["contextual_paragraph"].ToString();
                        byte[] imageBytes = (byte[])questionRow["image"];
                        using (var ms = new System.IO.MemoryStream(imageBytes))
                        {
                            card.ContextualPicImage = Image.FromStream(ms);
                        }
                        card.HideNonContextualImageAndParagraphControls();
                    }
                    else if (questionType == "Multiple Choice")
                    {
                        card.QuestionText = questionRow["question"].ToString(); // Ensure question text is set
                        string choices = questionRow["multiplechoice_choices"].ToString();
                        string[] options = choices.Split(',');

                        if (options.Length > 0) card.MultipleChoiceOption1 = options[0];
                        if (options.Length > 1) card.MultipleChoiceOption2 = options[1];
                        if (options.Length > 2) card.MultipleChoiceOption3 = options[2];
                        if (options.Length > 3) card.MultipleChoiceOption4 = options[3];

                        // Fetch and set the student answer
                        string questionID = questionRow["questionNumber"].ToString();
                        string answer = GetStudentAnswer(examCode, studentID, questionID);
                        if (!string.IsNullOrEmpty(answer))
                        {
                            SetMultipleChoiceAnswer(card, answer);
                        }

                        card.HideNonMultipleChoiceControls();
                    }
                    else
                    {
                        if (!questionRow.IsNull("question"))
                        {
                            card.QuestionText = questionRow["question"].ToString();
                            string questionID = questionRow["questionNumber"].ToString();
                            string answer = GetStudentAnswer(examCode, studentID, questionID);
                            if (!string.IsNullOrEmpty(answer))
                            {
                                card.AnswerText = answer;
                            }
                        }

                        string teacherAnswer = string.Empty;
                        if (questionRow["identification"] != DBNull.Value)
                        {
                            // Identification type question
                            teacherAnswer = questionRow["identification"].ToString().Trim(); // Trim any leading or trailing spaces
                        }
                        else if (questionRow["multiplechoice_answer"] != DBNull.Value)
                        {
                            // Multiple choice question
                            teacherAnswer = questionRow["multiplechoice_answer"].ToString().Trim(); // Trim any leading or trailing spaces
                        }
                        // Display teacher's answer key or "Manual Checking" message if answer is null
                        card.TeacherAnswerText = string.IsNullOrEmpty(teacherAnswer) ? "Manual Checking" : teacherAnswer;
                    }

                    // Fetch and set the student's score
                    string questionIDForScore = questionRow["questionNumber"].ToString();
                    string score = GetStudentScore(examCode, studentID, questionIDForScore);
                    card.ScorePointText = score;

                    questions_FLP.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching questions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetTimeTurnedin(string examCode, string studentID)
        {
            string timeTurnedin = string.Empty;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT time_turnedin FROM studenthistory WHERE examCode = @ExamCode AND studentID = @StudentID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ExamCode", examCode);
                    command.Parameters.AddWithValue("@StudentID", studentID);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        timeTurnedin = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching time turned-in: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return timeTurnedin;
        }


        private void SetMultipleChoiceAnswer(TeacherCheckingCard card, string answer)
        {
            switch (answer)
            {
                case "A":
                    card.Multiple1RBChecked = true;
                    break;
                case "B":
                    card.Multiple2RBChecked = true;
                    break;
                case "C":
                    card.Multiple3RBChecked = true;
                    break;
                case "D":
                    card.Multiple4RBChecked = true;
                    break;
                default:
                    // Handle unexpected answers if necessary
                    break;
            }
        }

        private string GetStudentAnswer(string examCode, string studentID, string questionID)
        {
            string answer = string.Empty;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = $"SELECT `{studentID}` FROM `{examCode}_Answers` WHERE questionID = @QuestionID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@QuestionID", questionID);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        answer = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching student answer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return answer;
        }

        private string GetStudentScore(string examCode, string studentID, string questionID)
        {
            string score = string.Empty;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = $"SELECT `{studentID}_points` FROM `{examCode}_Answers` WHERE questionID = @QuestionID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@QuestionID", questionID);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        score = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching student score: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return score;
        }



        private string GetStudentID(string studentName)
        {
            string studentID = string.Empty;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT studentID FROM studenthistory WHERE studentName = @StudentName";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StudentName", studentName);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        studentID = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching student ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return studentID;
        }

        private void CheckingPreview_Load(object sender, EventArgs e)
        {
            // You can perform additional initialization here if needed
        }
    }
}
