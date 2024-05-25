using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Exam_Management_System.Designs
{
    public partial class teacherPreviewCard : UserControl
    {

        DBAccess objDBAccess = new DBAccess();
        public teacherPreviewCard()
        {
            InitializeComponent();

            // Populate the combo box with options
            CquestionType_CB.Items.AddRange(new string[]
            {
            "Identification",
            "Paragraph Form",
            "Multiple Choice",
            "Contextual Paragraph",
            "Contextual Image",
            "Contextual Paragraph & Image"
            });

            CquestionType_CB.SelectedIndexChanged += CQuestionType_CB_SelectedIndexChanged;
            edit_BTN.Click += Edit_BTN_Click;

            save_BTN.Enabled = false;

            Cpoint_TB.Enabled = false;
            points_LBL.Enabled = false;
            Cquestion_TB.Enabled = false;
            CmanualC_CB.Enabled = false;
            CquestionType_CB.Enabled = false;
            Cquestion_TB.Enabled = false;
            CmanualC_CB.Enabled = false;
            CshortAnswer_TB.Enabled = false;
            ClongAnswer_TB.Enabled = false;
            Cmultiple1_TB.Enabled = false;
            Cmultiple2_TB.Enabled = false;
            Cmultiple3_TB.Enabled = false;
            Cmultiple4_TB.Enabled = false;
            Cmultiple1_RB.Enabled = false;
            Cmultiple2_RB.Enabled = false;
            Cmultiple3_RB.Enabled = false;
            Cmultiple4_RB.Enabled = false;

            CcontextualParaOnly_TB.Enabled = false;
            CcontextualPara_TB.Enabled = false;

            CattachmentBoth_BT.Enabled = false;
            CattachmentBoth_BT.Enabled = false;
            delete_BTN.Enabled = false;
        }

        private void CQuestionType_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedQuestionType = CquestionType_CB.SelectedItem?.ToString();

            switch (selectedQuestionType)
            {
                case "Identification":
                    Cquestion_TB.Visible = true;
                    CshortAnswer_TB.Visible = true;
                    ClongAnswer_TB.Visible = false;
                    Cmultiple1_RB.Visible = false;
                    Cmultiple2_RB.Visible = false;
                    Cmultiple3_RB.Visible = false;
                    Cmultiple4_RB.Visible = false;
                    Cmultiple1_TB.Visible = false;
                    Cmultiple2_TB.Visible = false;
                    Cmultiple3_TB.Visible = false;
                    Cmultiple4_TB.Visible = false;
                    Cattachment_BT.Visible = false;
                    CattachmentBoth_BT.Visible = false;
                    delete_BTN.Visible = false;
                    points_LBL.Visible = true;
                    Cpoint_TB.Visible = true;  

                    CcontextualParaOnly_TB.Visible = false;
                    CcontextualPicOnly_PB.Visible = false;
                    CcontextualPara_TB.Visible = false;
                    CcontextualPic_PB.Visible = false;
                    break;

                case "Paragraph Form":
                    Cquestion_TB.Visible = true;
                    CshortAnswer_TB.Visible = false;
                    ClongAnswer_TB.Visible = true;
                    Cmultiple1_RB.Visible = false;
                    Cmultiple2_RB.Visible = false;
                    Cmultiple3_RB.Visible = false;
                    Cmultiple4_RB.Visible = false;
                    Cmultiple1_TB.Visible = false;
                    Cmultiple2_TB.Visible = false;
                    Cmultiple3_TB.Visible = false;
                    Cmultiple4_TB.Visible = false;
                    Cattachment_BT.Visible = false;
                    CattachmentBoth_BT.Visible = false;
                    delete_BTN.Visible = false;
                    points_LBL.Visible = true;
                    Cpoint_TB.Visible = true;

                    CcontextualParaOnly_TB.Visible = false;
                    CcontextualPicOnly_PB.Visible = false;
                    CcontextualPara_TB.Visible = false;
                    CcontextualPic_PB.Visible = false;
                    break;

                case "Multiple Choice":
                    Cquestion_TB.Visible = true;
                    CshortAnswer_TB.Visible = false;
                    ClongAnswer_TB.Visible = false;
                    Cmultiple1_RB.Visible = true;
                    Cmultiple2_RB.Visible = true;
                    Cmultiple3_RB.Visible = true;
                    Cmultiple4_RB.Visible = true;
                    Cmultiple1_TB.Visible = true;
                    Cmultiple2_TB.Visible = true;
                    Cmultiple3_TB.Visible = true;
                    Cmultiple4_TB.Visible = true;
                    Cattachment_BT.Visible = false;
                    CattachmentBoth_BT.Visible = false;
                    delete_BTN.Visible = true;
                    points_LBL.Visible = true;
                    Cpoint_TB.Visible = true;

                    CcontextualParaOnly_TB.Visible = false;
                    CcontextualPicOnly_PB.Visible = false;
                    CcontextualPara_TB.Visible = false;
                    CcontextualPic_PB.Visible = false;
                    break;

                case "Contextual Paragraph":
                    Cquestion_TB.Visible = false;
                    CshortAnswer_TB.Visible = false;
                    ClongAnswer_TB.Visible = false;
                    Cmultiple1_RB.Visible = false;
                    Cmultiple2_RB.Visible = false;
                    Cmultiple3_RB.Visible = false;
                    Cmultiple4_RB.Visible = false;
                    Cmultiple1_TB.Visible = false;
                    Cmultiple2_TB.Visible = false;
                    Cmultiple3_TB.Visible = false;
                    Cmultiple4_TB.Visible = false;
                    Cattachment_BT.Visible = false;
                    CattachmentBoth_BT.Visible = false;
                    delete_BTN.Visible = false;
                    Cpoint_TB.Visible = false;
                    CmanualC_CB.Visible = false;
                    points_LBL.Visible = false;

                    CcontextualParaOnly_TB.Visible = true;
                    CcontextualPicOnly_PB.Visible = false;
                    CcontextualPara_TB.Visible = false;
                    CcontextualPic_PB.Visible = false;
                    break;

                case "Contextual Image":
                    Cquestion_TB.Visible = false;
                    CshortAnswer_TB.Visible = false;
                    ClongAnswer_TB.Visible = false;
                    Cmultiple1_RB.Visible = false;
                    Cmultiple2_RB.Visible = false;
                    Cmultiple3_RB.Visible = false;
                    Cmultiple4_RB.Visible = false;
                    Cmultiple1_TB.Visible = false;
                    Cmultiple2_TB.Visible = false;
                    Cmultiple3_TB.Visible = false;
                    Cmultiple4_TB.Visible = false;
                    Cattachment_BT.Visible = false;
                    CattachmentBoth_BT.Visible = true;
                    Cpoint_TB.Visible = false;
                    CmanualC_CB.Visible = false;
                    points_LBL.Visible = false;

                    CcontextualParaOnly_TB.Visible = false;
                    CcontextualPicOnly_PB.Visible = true;
                    CcontextualPara_TB.Visible = false;
                    CcontextualPic_PB.Visible = false;
                    break;

                case "Contextual Paragraph & Image":
                    Cquestion_TB.Visible = false;
                    CshortAnswer_TB.Visible = false;
                    ClongAnswer_TB.Visible = false;
                    Cmultiple1_RB.Visible = false;
                    Cmultiple2_RB.Visible = false;
                    Cmultiple3_RB.Visible = false;
                    Cmultiple4_RB.Visible = false;
                    Cmultiple1_TB.Visible = false;
                    Cmultiple2_TB.Visible = false;
                    Cmultiple3_TB.Visible = false;
                    Cmultiple4_TB.Visible = false;
                    Cattachment_BT.Visible = false;
                    CattachmentBoth_BT.Visible = true;
                    Cpoint_TB.Visible = false;
                    CmanualC_CB.Visible = false;
                    points_LBL.Visible = false;

                    CcontextualParaOnly_TB.Visible = false;
                    CcontextualPicOnly_PB.Visible = false;
                    CcontextualPara_TB.Visible = true;
                    CcontextualPic_PB.Visible = true;
                    break;
            }
        }

        private void Edit_BTN_Click(object sender, EventArgs e)
        {
            save_BTN.Enabled = true;
            Cpoint_TB.Enabled = true;
            Cquestion_TB.Enabled = true;
            CmanualC_CB.Enabled = true;
            CquestionType_CB.Enabled = true;
            Cquestion_TB.Enabled = true;
            CmanualC_CB.Enabled = true;
            CshortAnswer_TB.Enabled = true;
            ClongAnswer_TB.Enabled = true;
            Cmultiple1_TB.Enabled = true;
            Cmultiple2_TB.Enabled = true;
            Cmultiple3_TB.Enabled = true;
            Cmultiple4_TB.Enabled = true;
            Cmultiple1_RB.Enabled = true;
            Cmultiple2_RB.Enabled = true;
            Cmultiple3_RB.Enabled = true;
            Cmultiple4_RB.Enabled = true;

            CcontextualParaOnly_TB.Enabled = true;
            CcontextualPara_TB.Enabled = true;

            CattachmentBoth_BT.Enabled = true;
            CattachmentBoth_BT.Enabled = true;
            delete_BTN.Enabled = true;
        }

        public string Question
        {
            get { return Cquestion_TB.Text; }
            set { Cquestion_TB.Text = value; }
        }

        public string QuestionNumber
        {
            get { return questionNo_LBL.Text; }
            set { questionNo_LBL.Text = "Q No. " + value; }
        }

        public string QuestionType
        {                                   
            get { return CquestionType_CB.Text; }
            set { CquestionType_CB.Text = value; }
        }

        public string Points
        {
            get { return Cpoint_TB.Text; }
            set { Cpoint_TB.Text = value; }
        }

        public bool ManualCheckStatus
        {
            get { return CmanualC_CB.Checked; }
            set { CmanualC_CB.Checked = value; }
        }

        public string Identification
        {
            get { return CshortAnswer_TB.Text; }
            set { CshortAnswer_TB.Text = value; }
        }

        public string ParagraphType
        {
            get { return ClongAnswer_TB.Text; }
            set { ClongAnswer_TB.Text = value; }
        }

        public string MultipleChoiceChoices
        {
            get
            {
                return $"{Cmultiple1_TB.Text},{Cmultiple2_TB.Text},{Cmultiple3_TB.Text},{Cmultiple4_TB.Text}";
            }
            set
            {
                string[] choices = value.Split(',');
                if (choices.Length >= 4)
                {
                    Cmultiple1_TB.Text = choices[0];
                    Cmultiple2_TB.Text = choices[1];
                    Cmultiple3_TB.Text = choices[2];
                    Cmultiple4_TB.Text = choices[3];
                }
            }
        }

        public string MultipleChoiceAnswer
        {
            get
            {
                if (Cmultiple1_RB.Checked) return Cmultiple1_TB.Text;
                if (Cmultiple2_RB.Checked) return Cmultiple2_TB.Text;
                if (Cmultiple3_RB.Checked) return Cmultiple3_TB.Text;
                if (Cmultiple4_RB.Checked) return Cmultiple4_TB.Text;
                return null;
            }
            set
            {
                if (Cmultiple1_TB.Text == value) Cmultiple1_RB.Checked = true;
                if (Cmultiple2_TB.Text == value) Cmultiple2_RB.Checked = true;
                if (Cmultiple3_TB.Text == value) Cmultiple3_RB.Checked = true;
                if (Cmultiple4_TB.Text == value) Cmultiple4_RB.Checked = true;
            }
        }

        public string ContextualParagraph
        {
            get { return CcontextualPara_TB.Text; }
            set { CcontextualPara_TB.Text = value; }
        }

        public Image ImageData
        {
            get { return CcontextualPicOnly_PB.Image; }
            set { CcontextualPicOnly_PB.Image = value; }
        }

        public Tuple<Image, string> ContextualParagraphImage
        {
            set
            {
                if (value != null)
                {
                    CcontextualPic_PB.Image = value.Item1;
                    CcontextualPara_TB.Text = value.Item2;
                }
            }
        }

        private void save_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the exam code from PreviewForm
                PreviewForm previewForm = Application.OpenForms.OfType<PreviewForm>().FirstOrDefault();
                if (previewForm == null)
                {
                    MessageBox.Show("PreviewForm is not open.");
                    return;
                }

                string examCode = previewForm.GetExamCode();
                string questionNumber = this.QuestionNumber.Replace("Q No. ", "");

                // Get the data from the form using properties
                string question = this.Question;
                string questionType = this.QuestionType;
                byte[] fileData = null; // Add logic to retrieve file data if any
                int? points = int.TryParse(this.Points, out int parsedPoints) ? parsedPoints : (int?)null;
                bool manualCheck = this.ManualCheckStatus;
                string multipleChoiceOptions = this.MultipleChoiceChoices;
                string correctAnswer = this.MultipleChoiceAnswer;
                string shortAnswer = questionType == "Identification" ? this.Identification : null;
                string longAnswer = questionType == "Paragraph Form" ? this.ParagraphType : null;
                string contextualParagraph = questionType == "Contextual Paragraph" ? this.ContextualParagraph :
                                              (questionType == "Contextual Paragraph & Image" ? this.ContextualParagraph : null);

                // Check if the data already exists
                bool dataExists = CheckIfDataExists(examCode, questionNumber);

                // SQL query to update or insert values into the "examQuestions" table
                string query = "";
                if (dataExists)
                {
                    query = "UPDATE examQuestions SET " +
                            "question = @Question, " +
                            "question_type = @QuestionType, " +
                            "image = @Image, " +
                            "point = @Point, " +
                            "manual_check = @ManualCheck, " +
                            "multiplechoice_choices = @MultipleChoiceOptions, " +
                            "multiplechoice_answer = @MultipleChoiceAnswer, " +
                            "identification = @ShortAnswer, " +
                            "paragraph_type = @LongAnswer, " +
                            "contextual_paragraph = @ContextualParagraph " +
                            "WHERE examCode = @Code AND questionNumber = @QuestionNumber";
                }
                else
                {
                    query = "INSERT INTO examQuestions (questionNumber, question, examCode, question_type, image, point, manual_check, multiplechoice_choices, multiplechoice_answer, identification, paragraph_type, contextual_paragraph) " +
                            "VALUES (@QuestionNumber, @Question, @Code, @QuestionType, @Image, @Point, @ManualCheck, @MultipleChoiceOptions, @MultipleChoiceAnswer, @ShortAnswer, @LongAnswer, @ContextualParagraph)";
                }

                // Use MySqlCommand to insert or update data in the database
                using (MySqlCommand command = new MySqlCommand(query))
                {
                    command.Parameters.AddWithValue("@QuestionNumber", questionNumber);
                    command.Parameters.AddWithValue("@Question", question);
                    command.Parameters.AddWithValue("@Code", examCode);
                    command.Parameters.AddWithValue("@QuestionType", questionType);
                    command.Parameters.AddWithValue("@Image", fileData ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Point", points ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@ManualCheck", manualCheck);
                    command.Parameters.AddWithValue("@MultipleChoiceOptions", multipleChoiceOptions);
                    command.Parameters.AddWithValue("@MultipleChoiceAnswer", correctAnswer ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@ShortAnswer", shortAnswer ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@LongAnswer", longAnswer ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@ContextualParagraph", contextualParagraph ?? (object)DBNull.Value);

                    objDBAccess.createConn(); // Ensure connection is open
                    int rowsAffected = objDBAccess.executeQuery(command);
                    objDBAccess.closeConn(); // Close connection

                    if (rowsAffected > 0)
                    {
                        if (dataExists)
                            MessageBox.Show("Data updated successfully.");
                        else
                            MessageBox.Show("Data saved successfully.");

                        // Refresh the PreviewForm
                        previewForm.DisplayData();
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while saving data.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        // Function to check if data already exists
        private bool CheckIfDataExists(string examCode, string questionNumber)
        {
            string query = "SELECT COUNT(*) FROM examQuestions WHERE examCode = @Code AND questionNumber = @QuestionNumber";
            using (MySqlCommand command = new MySqlCommand(query))
            {
                command.Parameters.AddWithValue("@Code", examCode);
                command.Parameters.AddWithValue("@QuestionNumber", questionNumber);

                objDBAccess.createConn(); // Ensure connection is open
                int count = Convert.ToInt32(objDBAccess.executeScalar(command));
                objDBAccess.closeConn(); // Close connection

                return count > 0;
            }
        }

        private void deleteQ_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the exam code from PreviewForm
                PreviewForm previewForm = Application.OpenForms.OfType<PreviewForm>().FirstOrDefault();
                if (previewForm == null)
                {
                    MessageBox.Show("PreviewForm is not open.");
                    return;
                }

                string examCode = previewForm.GetExamCode();
                string questionNumber = this.QuestionNumber.Replace("Q No. ", "");

                // SQL query to delete the question from examQuestions and move to examQuestionsArchive
                string deleteQuery = "INSERT INTO examQuestionsArchive (questionNumber, question, examCode, question_type, image, point, manual_check, multiplechoice_choices, multiplechoice_answer, identification, paragraph_type, contextual_paragraph) " +
                                     "SELECT questionNumber, question, examCode, question_type, image, point, manual_check, multiplechoice_choices, multiplechoice_answer, identification, paragraph_type, contextual_paragraph " +
                                     "FROM examQuestions WHERE examCode = @Code AND questionNumber = @QuestionNumber; " +
                                     "DELETE FROM examQuestions WHERE examCode = @Code AND questionNumber = @QuestionNumber";

                using (MySqlCommand command = new MySqlCommand(deleteQuery))
                {
                    command.Parameters.AddWithValue("@Code", examCode);
                    command.Parameters.AddWithValue("@QuestionNumber", questionNumber);

                    objDBAccess.createConn(); // Ensure connection is open
                    int rowsAffected = objDBAccess.executeQuery(command);
                    objDBAccess.closeConn(); // Close connection

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Question deleted successfully.");

                        // Refresh the PreviewForm
                        previewForm.DisplayData();

                        // Update number of questions displayed
                        previewForm.DisplayNumberOfQuestions();
                    }
                    else
                    {
                        MessageBox.Show("No question found to delete.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



    }
}
