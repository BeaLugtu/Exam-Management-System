using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Exam_Management_System.Designs
{
    public partial class TeacherCheckingCard : UserControl
    {

        string connectionString = "Server=26.96.197.206;Database=exam.io;Uid=admin;Pwd=admin;";

        private string examCode;
        private string studentID;
        private string questionNumber;
        public string QuestionID { get; set; } // Add this property for QuestionID

        // Public property to set the question number
        public string QuestionNumber
        {
            get { return questionNumber; }
            set { questionNumber = value; }
        }

        public TeacherCheckingCard()
        {
            InitializeComponent();

            question_LBL.Visible = true;
            scorePoint_TB.Visible = true;
            overScore_LBL.Visible = true;
            answer_LBL.Visible = true;
            multiple1_RB.Visible = false;
            multiple2_RB.Visible = false;
            multiple3_RB.Visible = false;
            multiple4_RB.Visible = false;
            multiple1_TB.Visible = false;
            multiple2_TB.Visible = false;
            multiple3_TB.Visible = false;
            multiple4_TB.Visible = false;
            contextualPicOnly_PB.Visible = false;
            contextualParaOnly_TB.Visible = false;
            contextualPic_PB.Visible = false;
            contextualPara_TB.Visible = false;

            // Subscribe to TextChanged event of scorePoint_TB
            scorePoint_TB.TextChanged += ScorePoint_TB_TextChanged;
        }

        // Event handler for TextChanged event of scorePoint_TB
        private void ScorePoint_TB_TextChanged(object sender, EventArgs e)
        {
            // Call the SaveScore method when the text changes in scorePoint_TB
            SaveScore();
        }

        // Public property to access question_LBL text
        public string QuestionText
        {
            get { return question_LBL.Text; }
            set { question_LBL.Text = value; }
        }

        // Public property to access answer_LBL text
        public string AnswerText
        {
            get { return answer_LBL.Text; }
            set { answer_LBL.Text = value; }
        }

        // Property for contextual paragraph text
        public string ContextualParaOnlyText
        {
            get { return contextualParaOnly_TB.Text; }
            set { contextualParaOnly_TB.Text = value; }
        }

        // Property for contextual image
        public Image ContextualPicOnlyImage
        {
            get { return contextualPicOnly_PB.Image; }
            set { contextualPicOnly_PB.Image = value; }
        }

        // Property for contextual paragraph and image
        public string ContextualParaText
        {
            get { return contextualPara_TB.Text; }
            set { contextualPara_TB.Text = value; }
        }

        public Image ContextualPicImage
        {
            get { return contextualPic_PB.Image; }
            set { contextualPic_PB.Image = value; }
        }

        public string MultipleChoiceOption1
        {
            get { return multiple1_TB.Text; }
            set { multiple1_TB.Text = value; }
        }

        public string MultipleChoiceOption2
        {
            get { return multiple2_TB.Text; }
            set { multiple2_TB.Text = value; }
        }

        public string MultipleChoiceOption3
        {
            get { return multiple3_TB.Text; }
            set { multiple3_TB.Text = value; }
        }

        public string MultipleChoiceOption4
        {
            get { return multiple4_TB.Text; }
            set { multiple4_TB.Text = value; }
        }

        public bool Multiple1RBVisible
        {
            get { return multiple1_RB.Visible; }
            set { multiple1_RB.Visible = value; multiple1_TB.Visible = value; }
        }

        public bool Multiple2RBVisible
        {
            get { return multiple2_RB.Visible; }
            set { multiple2_RB.Visible = value; multiple2_TB.Visible = value; }
        }

        public bool Multiple3RBVisible
        {
            get { return multiple3_RB.Visible; }
            set { multiple3_RB.Visible = value; multiple3_TB.Visible = value; }
        }

        public bool Multiple4RBVisible
        {
            get { return multiple4_RB.Visible; }
            set { multiple4_RB.Visible = value; multiple4_TB.Visible = value; }
        }

        public string OverScoreText
        {
            get { return overScore_LBL.Text; }
            set { overScore_LBL.Text = "/" + value; }
        }

        public string ScorePointText
        {
            get { return scorePoint_TB.Text; }
            set { scorePoint_TB.Text = value; }
        }


        public bool Multiple1RBChecked
        {
            get { return multiple1_RB.Checked; }
            set { multiple1_RB.Checked = value; }
        }

        public bool Multiple2RBChecked
        {
            get { return multiple2_RB.Checked; }
            set { multiple2_RB.Checked = value; }
        }

        public bool Multiple3RBChecked
        {
            get { return multiple3_RB.Checked; }
            set { multiple3_RB.Checked = value; }
        }

        public bool Multiple4RBChecked
        {
            get { return multiple4_RB.Checked; }
            set { multiple4_RB.Checked = value; }
        }

        // Add this property in your TeacherCheckingCard class
        public string TeacherAnswerText
        {
            get { return teacherAnswer_LBL.Text; }
            set { teacherAnswer_LBL.Text = value; }
        }

        // Method to hide non-contextual paragraph controls
        public void HideNonContextualParagraphControls()
        {
            question_LBL.Visible = false;
            point_LBL.Visible = false;
            scorePoint_TB.Visible = false;
            overScore_LBL.Visible = false;
            answer_LBL.Visible = false;
            teacherAnswer_LBL.Visible = false;
            multiple1_RB.Visible = false;
            multiple2_RB.Visible = false;
            multiple3_RB.Visible = false;
            multiple4_RB.Visible = false;
            multiple1_TB.Visible = false;
            multiple2_TB.Visible = false;
            multiple3_TB.Visible = false;
            multiple4_TB.Visible = false;
            contextualPicOnly_PB.Visible = false;
            contextualParaOnly_TB.Visible = true;
            contextualPic_PB.Visible = false;
            contextualPara_TB.Visible = false;
            answerKey_LBL.Visible = false;
        }

        public void HideNonContextualImageControls()
        {
            question_LBL.Visible = false;
            point_LBL.Visible = false;
            scorePoint_TB.Visible = false;
            overScore_LBL.Visible = false;
            answer_LBL.Visible = false;
            teacherAnswer_LBL.Visible = false;
            multiple1_RB.Visible = false;
            multiple2_RB.Visible = false;
            multiple3_RB.Visible = false;
            multiple4_RB.Visible = false;
            multiple1_TB.Visible = false;
            multiple2_TB.Visible = false;
            multiple3_TB.Visible = false;
            multiple4_TB.Visible = false;
            contextualPicOnly_PB.Visible = true;
            contextualParaOnly_TB.Visible = false;
            contextualPic_PB.Visible = false;
            contextualPara_TB.Visible = false;
            answerKey_LBL.Visible = false;
        }

        public void HideNonContextualImageAndParagraphControls()
        {
            question_LBL.Visible = false;
            point_LBL.Visible = false;
            scorePoint_TB.Visible = false;
            overScore_LBL.Visible = false;
            answer_LBL.Visible = false;
            teacherAnswer_LBL.Visible = false;
            multiple1_RB.Visible = false;
            multiple2_RB.Visible = false;
            multiple3_RB.Visible = false;
            multiple4_RB.Visible = false;
            multiple1_TB.Visible = false;
            multiple2_TB.Visible = false;
            multiple3_TB.Visible = false;
            multiple4_TB.Visible = false;
            contextualPicOnly_PB.Visible = false;
            contextualParaOnly_TB.Visible = false;
            contextualPic_PB.Visible = true;
            contextualPara_TB.Visible = true;
            answerKey_LBL.Visible = false;
        }

        // Method to hide non-multiple choice controls
        public void HideNonMultipleChoiceControls()
        {
            question_LBL.Visible = true;
            point_LBL.Visible = true;
            scorePoint_TB.Visible = true;
            overScore_LBL.Visible = true;
            answer_LBL.Visible = false;
            teacherAnswer_LBL.Visible = true;
            multiple1_RB.Visible = true;
            multiple2_RB.Visible = true;
            multiple3_RB.Visible = multiple3_TB.Visible && !string.IsNullOrEmpty(multiple3_TB.Text);
            multiple4_RB.Visible = multiple4_TB.Visible && !string.IsNullOrEmpty(multiple4_TB.Text);
            multiple1_TB.Visible = true;
            multiple2_TB.Visible = true;
            multiple3_TB.Visible = multiple3_TB.Visible && !string.IsNullOrEmpty(multiple3_TB.Text);
            multiple4_TB.Visible = multiple4_TB.Visible && !string.IsNullOrEmpty(multiple4_TB.Text);
            contextualPicOnly_PB.Visible = false;
            contextualParaOnly_TB.Visible = false;
            contextualPic_PB.Visible = false;
            contextualPara_TB.Visible = false;
        }

        public void SetExamCodeAndStudentID(string examCode, string studentID)
        {
            // Store the exam code and student ID in the private fields
            this.examCode = examCode;
            this.studentID = studentID;
        }

        public void SaveScore()
        {
            // Fetch the value inserted in the scorePoint_TB
            string score = ScorePointText;

            // Fetch the question text displayed in question_LBL
            string questionText = QuestionText;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Update the [examcode]_answers table
                    string query = $"UPDATE `{examCode}_answers` SET `{studentID}_points` = @Score WHERE questions = @QuestionText";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Score", score);
                    command.Parameters.AddWithValue("@QuestionText", questionText);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Failed to save score.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving score: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
