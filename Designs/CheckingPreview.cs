using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Exam_Management_System.Designs
{
    public partial class CheckingPreview : Form
    {
        string connectionString = "Server=26.96.197.206;Database=exam.io;Uid=admin;Pwd=admin;";
        Timer timer;

        public CheckingPreview()
        {
            InitializeComponent();
            PopulateListView();

            // Subscribe to the SelectedIndexChanged event
            respondents_LV.SelectedIndexChanged += Respondents_LV_SelectedIndexChanged;

            timer = new Timer();
            timer.Interval = 1000; // Adjust the interval as needed (in milliseconds)
            timer.Tick += Timer_Tick;
            timer.Start();

            releaseScore_BTN.Click += releaseScore_BTN_Click;
            back_BTN.Click += back_BTN_Click;
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

        private string GetStudentIDFromName(string studentName)
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
                    //MessageBox.Show("No students found for the specified exam code.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    card.SetExamCodeAndStudentID(examCode, studentID);

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

                        // Clear all multiple choice options first
                        card.MultipleChoiceOption1 = string.Empty;
                        card.MultipleChoiceOption2 = string.Empty;
                        card.MultipleChoiceOption3 = string.Empty;
                        card.MultipleChoiceOption4 = string.Empty;

                        // Set the options dynamically
                        if (options.Length > 0) card.MultipleChoiceOption1 = options[0];
                        if (options.Length > 1) card.MultipleChoiceOption2 = options[1];
                        if (options.Length > 2) card.MultipleChoiceOption3 = options[2];
                        if (options.Length > 3) card.MultipleChoiceOption4 = options[3];

                        // Hide or show the options based on the number of available choices
                        card.Multiple1RBVisible = options.Length > 0;
                        card.Multiple2RBVisible = options.Length > 1;
                        card.Multiple3RBVisible = options.Length > 2;
                        card.Multiple4RBVisible = options.Length > 3;

                        // Fetch and set the student answer
                        string questionID1 = questionRow["questionNumber"].ToString();
                        string answer = GetStudentAnswer(examCode, studentID, questionID1);
                        if (!string.IsNullOrEmpty(answer))
                        {
                            SetMultipleChoiceAnswer(card, answer);
                        }

                        // Fetch and set the teacher's answer key
                        string teacherAnswer = string.Empty;
                        if (questionRow["multiplechoice_answer"] != DBNull.Value)
                        {
                            teacherAnswer = questionRow["multiplechoice_answer"].ToString().Trim();
                        }

                        // Log the fetched teacher's answer key
                        Console.WriteLine($"Question Type: {questionType}, Teacher's Answer: {teacherAnswer}");

                        // Display teacher's answer key or "Manual Checking" message if answer is null
                        card.TeacherAnswerText = string.IsNullOrEmpty(teacherAnswer) ? "Manual Checking" : teacherAnswer;

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

                    string query = $"SELECT `{studentID}_answers` FROM `{examCode}_Answers` WHERE questionID = @QuestionID";
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

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the overall score label
            UpdateOverallScore();
        }

        private void UpdateOverallScore()
        {
            string examCode = code_LBL.Text;
            string overallScore = GetOverallScore(examCode);
            overallScore_LBL.Text = "Overall Score: " + overallScore;
        }

        private string GetOverallScore(string examCode)
        {
            string overallScore = "0";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Fetch all student IDs for the given exam code
                    List<string> studentIDs = new List<string>();
                    string studentIDsQuery = "SELECT studentID FROM studenthistory WHERE examCode = @ExamCode";
                    MySqlCommand studentIDsCommand = new MySqlCommand(studentIDsQuery, connection);
                    studentIDsCommand.Parameters.AddWithValue("@ExamCode", examCode);
                    using (MySqlDataReader reader = studentIDsCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string studentID = reader["studentID"].ToString();
                            studentIDs.Add(studentID);
                        }
                    }

                    // Calculate the sum of scores for all student IDs
                    int sumOfScores = 0;
                    foreach (string studentID in studentIDs)
                    {
                        string scoreQuery = $"SELECT SUM({studentID}_points) FROM `{examCode}_answers`";
                        MySqlCommand scoreCommand = new MySqlCommand(scoreQuery, connection);
                        object result = scoreCommand.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            sumOfScores += Convert.ToInt32(result);
                        }
                    }

                    overallScore = sumOfScores.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching overall score: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return overallScore;
        }

        private void releaseScore_BTN_Click(object sender, EventArgs e)
        {
            // Ensure a student is selected in the list view
            if (respondents_LV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a student to release scores.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Get the selected student's name
            string studentName = respondents_LV.SelectedItems[0].Text;

            // Get the student's ID based on the name
            string studentID = GetStudentIDFromName(studentName);

            // Ensure a valid student ID is retrieved
            if (string.IsNullOrEmpty(studentID))
            {
                MessageBox.Show("Unable to find the student ID for the selected student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the exam code
            string examCode = code_LBL.Text;

            // Validate scores
            if (!ValidateStudentScores(examCode, studentID))
            {
                MessageBox.Show("One or more scores exceed the assigned points for the corresponding questions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate the sum of scores for the selected student
            string overallScore = GetStudentOverallScore(examCode, studentID);

            // Calculate the sum of points for the exam questions
            string overallTeacherScore = GetOverallTeacherScore(examCode);

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if a record already exists for the student and exam code in the releasescores table
                    string checkQuery = "SELECT COUNT(*) FROM releasescores WHERE examCode = @ExamCode AND studentID = @StudentID";
                    MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@ExamCode", examCode);
                    checkCommand.Parameters.AddWithValue("@StudentID", studentID);
                    int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (count > 0)
                    {
                        // If a record already exists, update it
                        string updateQuery = "UPDATE releasescores SET overallScore = @OverallScore, overallTeacherScore = @OverallTeacherScore WHERE examCode = @ExamCode AND studentID = @StudentID";
                        MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
                        updateCommand.Parameters.AddWithValue("@OverallScore", overallScore);
                        updateCommand.Parameters.AddWithValue("@OverallTeacherScore", overallTeacherScore);
                        updateCommand.Parameters.AddWithValue("@ExamCode", examCode);
                        updateCommand.Parameters.AddWithValue("@StudentID", studentID);
                        updateCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        // If no record exists, insert a new record
                        string insertQuery = "INSERT INTO releasescores (examCode, studentID, studentName, overallScore, overallTeacherScore) VALUES (@ExamCode, @StudentID, @StudentName, @OverallScore, @OverallTeacherScore)";
                        MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                        insertCommand.Parameters.AddWithValue("@ExamCode", examCode);
                        insertCommand.Parameters.AddWithValue("@StudentID", studentID);
                        insertCommand.Parameters.AddWithValue("@StudentName", studentName);
                        insertCommand.Parameters.AddWithValue("@OverallScore", overallScore);
                        insertCommand.Parameters.AddWithValue("@OverallTeacherScore", overallTeacherScore);
                        insertCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Overall score released successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while releasing scores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateStudentScores(string examCode, string studentID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = $"SELECT q.questionNumber, q.point, a.{studentID}_points FROM examquestions q JOIN {examCode}_answers a ON q.questionNumber = a.questionID WHERE q.examCode = @ExamCode";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ExamCode", examCode);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int assignedPoints = reader.GetInt32("point");
                            int studentPoints = reader.GetInt32($"{studentID}_points");

                            if (studentPoints > assignedPoints)
                            {
                                return false; // Found a score that exceeds the assigned points
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while validating student scores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; // All scores are valid
        }


        private string GetOverallTeacherScore(string examCode)
        {
            string overallTeacherScore = "0";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string scoreQuery = "SELECT SUM(point) FROM examquestions WHERE examCode = @ExamCode";
                    MySqlCommand scoreCommand = new MySqlCommand(scoreQuery, connection);
                    scoreCommand.Parameters.AddWithValue("@ExamCode", examCode);
                    object result = scoreCommand.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        overallTeacherScore = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching overall teacher score: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return overallTeacherScore;
        }


        private string GetStudentOverallScore(string examCode, string studentID)
        {
            string overallScore = "0";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string scoreQuery = $"SELECT SUM({studentID}_points) FROM `{examCode}_answers`";
                    MySqlCommand scoreCommand = new MySqlCommand(scoreQuery, connection);
                    object result = scoreCommand.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        overallScore = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching overall score: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return overallScore;
        }

        private void back_BTN_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();

            // Show the teacher dashboard form
            TeacherDashBoard teacherDashboard = new TeacherDashBoard();
            teacherDashboard.Show();
        }


    }

}