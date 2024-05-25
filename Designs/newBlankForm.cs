using System;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using Exam_Management_System;
using Exam_Management_System.Designs;
using System.Drawing;

namespace TeacherDashboard
{
    public partial class newBlankForm : Form
    {
        DBAccess objDBAccess = new DBAccess();
        private bool isDeadlineSelected = false;
        private PreviewForm previewFormInstance;
        private string lastSelectedQuestionType;

        string selectedFilePath = "";
        public newBlankForm()
        {
            InitializeComponent();
            GenerateExamCode(); // Call the method to generate the exam code when the form is initialized
            questionType_DB.Items.AddRange(new object[] { "Identification", "Paragraph Form", "Multiple Choice", "Contextual Paragraph", "Contextual Image", "Contextual Paragraph & Image" });

            questionType_DB.DropDownStyle = ComboBoxStyle.DropDownList;

            // Set the default selection to "Short Answer"
            questionType_DB.SelectedIndex = 0;

            save_BTN.Click += save_BTN_Click;
            attachment_BT.Click += attachment_BT_Click;
            deleteA_BTN.Click += deleteAttachment_BTN_Click;
            manualC_CB.CheckedChanged += manualC_CB_CheckedChanged;
            view_BTN.Click += view_BTN_Click;

            longAnswer_TB.Visible = false;

            multiple1_RB.Visible = false;
            multiple2_RB.Visible = false;
            multiple3_RB.Visible = false;
            multiple4_RB.Visible = false;
            multiple1_TB.Visible = false;
            multiple2_TB.Visible = false;
            multiple3_TB.Visible = false;
            multiple4_TB.Visible = false;

            contextualParaOnly_TB.Visible = false;
            contextualPicOnly_PB.Visible = false;
            contextualPara_TB.Visible = false;
            contextualPic_PB.Visible = false;
            contextualFromQ_TB.Visible = false;
            contextualToQ_TB.Visible = false;

            deleteA_BTN.Visible = false;
            fileName_LBL.Visible = false;
            attachment_BT.Visible = false;

            questionType_DB.SelectedIndexChanged += QuestionType_DB_SelectedIndexChanged;

            contextualPicOnly_PB.Image = Exam_Management_System.Properties.Resources.Sample;

            // Hide the delete button initially

        }

        private void GenerateExamCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random rand = new Random();
            string examCode = new string(Enumerable.Repeat(chars, 6).Select(s => s[rand.Next(s.Length)]).ToArray());
            examCodeBox.Text = examCode;
            examCodeBox.ReadOnly = true; // Make the examCodeBox read-only
        }

        public string CodeValue
        {
            get { return examCodeBox.Text; }
        }

        public PreviewForm PreviewFormInstance
        {
            get { return previewFormInstance; }
            set { previewFormInstance = value; }
        }


        private void manualC_CB_CheckedChanged(object sender, EventArgs e)
        {
            bool manualCheckEnabled = manualC_CB.Checked;

            // Disable the components when manual checking is enabled
            identification_TB.Enabled = !manualCheckEnabled;
            longAnswer_TB.Enabled = !manualCheckEnabled;
            multiple1_RB.Enabled = !manualCheckEnabled;
            multiple2_RB.Enabled = !manualCheckEnabled;
            multiple3_RB.Enabled = !manualCheckEnabled;
            multiple4_RB.Enabled = !manualCheckEnabled;
        }

        private void save_BTN_Click(object sender, EventArgs e)
        {
            // Retrieve values from text boxes
            string question = question_TB.Text;
            string examCode = examCodeBox.Text;
            string questionType = questionType_DB.SelectedItem?.ToString();
            int manualCheck = manualC_CB.Checked ? 1 : 0;
            int? points = null;
            int randomizer = 1; // Default value for randomizer
            int? contextualFromQ = null;
            int? contextualToQ = null;
            int? questionNumber = null; // Default to null

            // Handle point requirement based on question type
            if (questionType != "Contextual Paragraph" && questionType != "Contextual Paragraph & Image" && questionType != "Contextual Image")
            {
                if (string.IsNullOrWhiteSpace(point_TB.Text) || !int.TryParse(point_TB.Text, out int pointValue))
                {
                    MessageBox.Show("Please enter a valid point value.");
                    return;
                }
                points = pointValue;
            }

            // Handle contextual range inputs
            if (!string.IsNullOrWhiteSpace(contextualFromQ_TB.Text) && int.TryParse(contextualFromQ_TB.Text, out int fromQ))
            {
                contextualFromQ = fromQ;
            }
            if (!string.IsNullOrWhiteSpace(contextualToQ_TB.Text) && int.TryParse(contextualToQ_TB.Text, out int toQ))
            {
                contextualToQ = toQ;
            }

            // Determine if the current question is contextual
            if (questionType == "Contextual Paragraph" || questionType == "Contextual Paragraph & Image" || questionType == "Contextual Image")
            {
                questionNumber = 0; // Set question number  to null for contextual questions
                randomizer = 0; // Set randomizer to 0 for contextual questions
            }
            else
            {
                questionNumber = GetNextQuestionNumber(examCode);
                if (questionNumber.HasValue && contextualFromQ.HasValue && contextualToQ.HasValue)
                {
                    if (questionNumber.Value >= contextualFromQ.Value && questionNumber.Value <= contextualToQ.Value)
                    {
                        randomizer = 0; // Set randomizer to 0 if within contextual range
                    }
                }
            }

            // Other validations...

            byte[] fileData = null;
            if (!string.IsNullOrEmpty(selectedFilePath))
            {
                fileData = File.ReadAllBytes(selectedFilePath);
            }

            string multipleChoiceOptions = string.Join(",", new string[]
            {
        multiple1_TB.Text,
        multiple2_TB.Text,
        multiple3_TB.Text,
        multiple4_TB.Text
            }.Where(x => !string.IsNullOrWhiteSpace(x)));

            string correctAnswer = "";
            if (multiple1_RB.Checked) correctAnswer = "A";
            else if (multiple2_RB.Checked) correctAnswer = "B";
            else if (multiple3_RB.Checked) correctAnswer = "C";
            else if (multiple4_RB.Checked) correctAnswer = "D";

            try
            {
                // SQL query to insert values into the "examQuestions" table
                string query = "INSERT INTO examQuestions (questionNumber, question, examCode, question_type, image, point, manual_check, multiplechoice_choices, multiplechoice_answer, identification, paragraph_type, contextual_paragraph, randomizer, contextualFromQ, contextualToQ) " +
                               "VALUES (@QuestionNumber, @Question, @Code, @QuestionType, @Image, @Point, @ManualCheck, @MultipleChoiceOptions, @MultipleChoiceAnswer, @ShortAnswer, @LongAnswer, @ContextualParagraph, @Randomizer, @ContextualFromQ, @ContextualToQ)";

                MySqlCommand command = new MySqlCommand(query);
                command.Parameters.AddWithValue("@QuestionNumber", questionNumber ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Question", question);
                command.Parameters.AddWithValue("@Code", examCode);
                command.Parameters.AddWithValue("@QuestionType", questionType);
                command.Parameters.AddWithValue("@Image", fileData ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Point", points ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ManualCheck", manualCheck);
                command.Parameters.AddWithValue("@MultipleChoiceOptions", multipleChoiceOptions);
                command.Parameters.AddWithValue("@MultipleChoiceAnswer", correctAnswer);
                command.Parameters.AddWithValue("@ShortAnswer", questionType == "Identification" ? identification_TB.Text : (object)DBNull.Value);
                command.Parameters.AddWithValue("@LongAnswer", questionType == "Paragraph Form" ? longAnswer_TB.Text : (object)DBNull.Value);
                command.Parameters.AddWithValue("@ContextualParagraph", questionType == "Contextual Paragraph" ? contextualParaOnly_TB.Text : (questionType == "Contextual Paragraph & Image" ? contextualPara_TB.Text : (object)DBNull.Value));
                command.Parameters.AddWithValue("@Randomizer", randomizer);
                command.Parameters.AddWithValue("@ContextualFromQ", contextualFromQ ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ContextualToQ", contextualToQ ?? (object)DBNull.Value);

                // Execute the query using the database class
                objDBAccess.createConn(); // Ensure connection is open
                int rowsAffected = objDBAccess.executeQuery(command);
                objDBAccess.closeConn(); // Close connection

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data saved successfully.");
                    // Clear text boxes after successful insertion
                    question_TB.Clear();
                    point_TB.Clear();
                    identification_TB.Clear();
                    longAnswer_TB.Clear();
                    multiple1_TB.Clear();
                    multiple2_TB.Clear();
                    multiple3_TB.Clear();
                    multiple4_TB.Clear();
                    contextualParaOnly_TB.Clear();
                    contextualPara_TB.Clear();
                    manualC_CB.Checked = false;
                    multiple1_RB.Checked = false;
                    multiple2_RB.Checked = false;
                    multiple3_RB.Checked = false;
                    multiple4_RB.Checked = false;
                    selectedFilePath = "";
                    fileName_LBL.Text = "";
                    fileName_LBL.Visible = false;
                    deleteA_BTN.Visible = false;

                    contextualPicOnly_PB.Image = Exam_Management_System.Properties.Resources.Sample; // Replace "Sample" with the name of your initial image resource
                    contextualPic_PB.Image = Exam_Management_System.Properties.Resources.Sample;

                    if (questionType == "Contextual Image")
                    {
                        attachment_BT.Visible = true;
                    }

                    PreviewForm previewForm1 = Application.OpenForms.OfType<PreviewForm>().FirstOrDefault();

                    if (previewForm1 != null)
                    {
                        // If an instance exists, update its code label and refresh data
                        previewForm1.SetCodeLabel(examCode);

                        string code = CodeValue;

                        previewForm1.DisplayData();
                    }
                }
                else
                {
                    MessageBox.Show("An error occurred while saving data.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private int GetNextQuestionNumber(string examCode)
        {
            try
            {
                string query = "SELECT IFNULL(MAX(questionNumber), 0) + 1 FROM examQuestions WHERE examCode = @Code";
                MySqlCommand command = new MySqlCommand(query);
                command.Parameters.AddWithValue("@Code", examCode);

                objDBAccess.createConn();
                int nextQuestionNumber = Convert.ToInt32(objDBAccess.executeScalar(command));
                objDBAccess.closeConn();

                return nextQuestionNumber;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the next question number: " + ex.Message);
                return 1; // Default to 1 if there's an error
            }
        }



        private void attachment_BT_Click(object sender, EventArgs e)
        {
            string selectedQuestionType = questionType_DB.SelectedItem?.ToString();

            if (selectedQuestionType == "Contextual Image" || selectedQuestionType == "Contextual Paragraph & Image")
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                    openFileDialog.Title = "Select an Image";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        selectedFilePath = openFileDialog.FileName;
                        fileName_LBL.Text = Path.GetFileName(selectedFilePath);
                        fileName_LBL.Visible = true;
                        deleteA_BTN.Visible = true;
                        attachment_BT.Visible = true;

                        // Display the selected image in the appropriate picture box based on the selected question type
                        if (selectedQuestionType == "Contextual Image")
                        {
                            contextualPicOnly_PB.Image = Image.FromFile(selectedFilePath);
                            contextualPicOnly_PB.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                        else if (selectedQuestionType == "Contextual Paragraph & Image")
                        {
                            contextualPic_PB.Image = Image.FromFile(selectedFilePath);
                            contextualPic_PB.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                }
            }
        }


        // Method to check if a file is an image
        private bool IsImage(string filePath)
        {
            string extension = Path.GetExtension(filePath);
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".gif" };
            return imageExtensions.Contains(extension.ToLower());
        }

        private void deleteAttachment_BTN_Click(object sender, EventArgs e)
        {
            // Reset the image to its initial state
            contextualPicOnly_PB.Image = Exam_Management_System.Properties.Resources.Sample; // Replace "InitialImage" with the name of your initial image resource
            contextualPic_PB.Image = Exam_Management_System.Properties.Resources.Sample;

            // Clear the selected file path and hide the delete button
            selectedFilePath = "";
            deleteA_BTN.Visible = false;
            fileName_LBL.Visible = false;
            attachment_BT.Visible = true;
        }


        private void QuestionType_DB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if there is unsaved data in the current question type
            if (IsUnsavedData())
            {
                // Prompt the user if they want to proceed without saving
                var result = MessageBox.Show("There is unsaved data. Do you want to continue without saving?", "Unsaved Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    // Select the previously selected question type in the ComboBox
                    questionType_DB.SelectedItem = lastSelectedQuestionType;
                    return;
                }
            }

            // Save the currently selected question type as the last selected
            lastSelectedQuestionType = questionType_DB.SelectedItem?.ToString();

            // Handle question type selection change
            string selectedQuestionType = questionType_DB.SelectedItem?.ToString();

            switch (selectedQuestionType)
            {
                case "Identification":
                    // Show short answer text box and hide other controls
                    question_TB.Visible = true;
                    identification_TB.Visible = true;
                    longAnswer_TB.Visible = false;
                    multiple1_RB.Visible = false;
                    multiple2_RB.Visible = false;
                    multiple3_RB.Visible = false;
                    multiple4_RB.Visible = false;
                    multiple1_TB.Visible = false;
                    multiple2_TB.Visible = false;
                    multiple3_TB.Visible = false;
                    multiple4_TB.Visible = false;
                    attachment_BT.Visible = false;
                    manualC_CB.Visible = true;
                    point_TB.Visible = true;

                    contextualParaOnly_TB.Visible = false;
                    contextualPicOnly_PB.Visible = false;
                    contextualPara_TB.Visible = false;
                    contextualPic_PB.Visible = false;
                    contextualFromQ_TB.Visible = false;
                    contextualToQ_TB.Visible = false;
                    break;

                case "Paragraph Form":
                    // Show long answer text box and hide other controls
                    question_TB.Visible = true;
                    identification_TB.Visible = false;
                    longAnswer_TB.Visible = true;
                    multiple1_RB.Visible = false;
                    multiple2_RB.Visible = false;
                    multiple3_RB.Visible = false;
                    multiple4_RB.Visible = false;
                    multiple1_TB.Visible = false;
                    multiple2_TB.Visible = false;
                    multiple3_TB.Visible = false;
                    multiple4_TB.Visible = false;
                    attachment_BT.Visible = false;
                    manualC_CB.Visible = true;
                    point_TB.Visible = true;

                    contextualParaOnly_TB.Visible = false;
                    contextualPicOnly_PB.Visible = false;
                    contextualPara_TB.Visible = false;
                    contextualPic_PB.Visible = false;
                    contextualFromQ_TB.Visible = false;
                    contextualToQ_TB.Visible = false;
                    break;

                case "Multiple Choice":
                    // Show multiple choice radio buttons and text boxes
                    question_TB.Visible = true;
                    identification_TB.Visible = false;
                    longAnswer_TB.Visible = false;
                    multiple1_RB.Visible = true;
                    multiple2_RB.Visible = true;
                    multiple3_RB.Visible = true;
                    multiple4_RB.Visible = true;
                    multiple1_TB.Visible = true;
                    multiple2_TB.Visible = true;
                    multiple3_TB.Visible = true;
                    multiple4_TB.Visible = true;
                    attachment_BT.Visible = false;
                    manualC_CB.Visible = true;
                    point_TB.Visible = true;

                    contextualParaOnly_TB.Visible = false;
                    contextualPicOnly_PB.Visible = false;
                    contextualPara_TB.Visible = false;
                    contextualPic_PB.Visible = false;
                    contextualFromQ_TB.Visible = false;
                    contextualToQ_TB.Visible = false;
                    break;

                case "Contextual Paragraph":
                    question_TB.Visible = false;
                    identification_TB.Visible = false;
                    longAnswer_TB.Visible = false;
                    multiple1_RB.Visible = false;
                    multiple2_RB.Visible = false;
                    multiple3_RB.Visible = false;
                    multiple4_RB.Visible = false;
                    multiple1_TB.Visible = false;
                    multiple2_TB.Visible = false;
                    multiple3_TB.Visible = false;
                    multiple4_TB.Visible = false;
                    attachment_BT.Visible = false;
                    manualC_CB.Visible = false;
                    point_TB.Visible = false;

                    contextualParaOnly_TB.Visible = true;
                    contextualPicOnly_PB.Visible = false;
                    contextualPara_TB.Visible = false;
                    contextualPic_PB.Visible = false;
                    contextualFromQ_TB.Visible = true;
                    contextualToQ_TB.Visible = true;
                    break;

                case "Contextual Image":
                    question_TB.Visible = false;
                    identification_TB.Visible = false;
                    longAnswer_TB.Visible = false;
                    multiple1_RB.Visible = false;
                    multiple2_RB.Visible = false;
                    multiple3_RB.Visible = false;
                    multiple4_RB.Visible = false;
                    multiple1_TB.Visible = false;
                    multiple2_TB.Visible = false;
                    multiple3_TB.Visible = false;
                    multiple4_TB.Visible = false;
                    attachment_BT.Visible = true;
                    manualC_CB.Visible = false;
                    point_TB.Visible = false;

                    contextualParaOnly_TB.Visible = false;
                    contextualPicOnly_PB.Visible = true;
                    contextualPara_TB.Visible = false;
                    contextualPic_PB.Visible = false;
                    contextualFromQ_TB.Visible = true;
                    contextualToQ_TB.Visible = true;
                    break;

                case "Contextual Paragraph & Image":
                    question_TB.Visible = false;
                    identification_TB.Visible = false;
                    longAnswer_TB.Visible = false;
                    multiple1_RB.Visible = false;
                    multiple2_RB.Visible = false;
                    multiple3_RB.Visible = false;
                    multiple4_RB.Visible = false;
                    multiple1_TB.Visible = false;
                    multiple2_TB.Visible = false;
                    multiple3_TB.Visible = false;
                    multiple4_TB.Visible = false;
                    attachment_BT.Visible = true;
                    manualC_CB.Visible = false;
                    point_TB.Visible = false;

                    contextualParaOnly_TB.Visible = false;
                    contextualPicOnly_PB.Visible = false;
                    contextualPara_TB.Visible = true;
                    contextualPic_PB.Visible = true;
                    contextualFromQ_TB.Visible = true;
                    contextualToQ_TB.Visible = true;
                    break;
            }
        }

        private bool IsUnsavedData()
        {
            string selectedQuestionType = questionType_DB.SelectedItem?.ToString();

            switch (selectedQuestionType)
            {
                case "Identification":
                    return identification_TB.Visible && !string.IsNullOrEmpty(identification_TB.Text);

                case "Paragraph Form":
                    return longAnswer_TB.Visible && !string.IsNullOrEmpty(longAnswer_TB.Text);

                case "Multiple Choice":
                    return (multiple1_TB.Visible && !string.IsNullOrEmpty(multiple1_TB.Text)) ||
                           (multiple2_TB.Visible && !string.IsNullOrEmpty(multiple2_TB.Text)) ||
                           (multiple3_TB.Visible && !string.IsNullOrEmpty(multiple3_TB.Text)) ||
                           (multiple4_TB.Visible && !string.IsNullOrEmpty(multiple4_TB.Text));

                case "Contextual Paragraph":
                    return contextualParaOnly_TB.Visible && !string.IsNullOrEmpty(contextualParaOnly_TB.Text);

                case "Contextual Image":
                    return contextualPicOnly_PB.Visible && contextualPicOnly_PB.Image != Exam_Management_System.Properties.Resources.Sample;

                case "Contextual Paragraph & Image":
                    return (contextualPara_TB.Visible && !string.IsNullOrEmpty(contextualPara_TB.Text)) ||
                           (contextualPic_PB.Visible && contextualPic_PB.Image != Exam_Management_System.Properties.Resources.Sample);

                default:
                    return false;
            }
        }

        private string FormatTimeInput(string input)
        {
            try
            {
                // Trim any leading or trailing whitespace
                input = input.Trim();

                // Parse the time input
                int hours;
                int minutes;

                // Handle different formats: "HHmm", "HH:mm", "H:mm", "H", "HH", "Hm", etc.
                if (input.Length == 1)
                {
                    hours = int.Parse(input);
                    minutes = 0;
                }
                else if (input.Length == 2)
                {
                    hours = int.Parse(input);
                    minutes = 0;
                }
                else if (input.Length == 3)
                {
                    hours = int.Parse(input.Substring(0, 1));
                    minutes = int.Parse(input.Substring(1));
                }
                else if (input.Length == 4)
                {
                    hours = int.Parse(input.Substring(0, 2));
                    minutes = int.Parse(input.Substring(2));
                }
                else if (input.Length >= 5)
                {
                    // Try parsing using standard DateTime parsing
                    DateTime time;
                    if (DateTime.TryParse(input, out time))
                    {
                        // Extract hours and minutes from the DateTime
                        hours = time.Hour;
                        minutes = time.Minute;
                    }
                    else
                    {
                        // Handle invalid time format
                        MessageBox.Show("Please enter a valid time format (HH:mm).");
                        return null;
                    }
                }
                else
                {
                    // Handle invalid time format
                    MessageBox.Show("Please enter a valid time format (HH:mm).");
                    return null;
                }

                // Check if hours and minutes are within valid range
                if (hours < 0 || hours > 23 || minutes < 0 || minutes > 59)
                {
                    MessageBox.Show("Please enter a valid time format (HH:mm).");
                    return null;
                }

                // Format the time as "HH:mm"
                return $"{hours:D2}:{minutes:D2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while formatting time: " + ex.Message);
                return null;
            }
        }
        private void examConfirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string examCode = examCodeBox.Text;
                string examTitle = examTitleBox.Text;
                int examTotalStudents = 0;

                if (!int.TryParse(examEstimateBox.Text, out examTotalStudents))
                {
                    MessageBox.Show("Please enter a valid number for total students.");
                    return;
                }

                // Parse exam deadline date from DateTimePicker
                DateTime examDeadlineDate = examDateDeadline.Value.Date;

                // Parse exam deadline time from TextBox and format it
                string examTimeInput = examTimeDeadline.Text;
                string formattedTime = FormatTimeInput(examTimeInput);
                if (formattedTime == null)
                {
                    // Handle invalid time format
                    return;
                }

                // Combine date and time into a single DateTime object
                DateTime examDeadlineDateTime = examDeadlineDate.Date + TimeSpan.Parse(formattedTime);

                // Check if there are questions available for the current examCode
                string checkQuery = "SELECT COUNT(*) FROM examquestions WHERE examCode = @examCode";
                MySqlCommand checkCommand = new MySqlCommand(checkQuery);
                checkCommand.Parameters.AddWithValue("@examCode", examCode);

                int questionCount = Convert.ToInt32(objDBAccess.executeScalar(checkCommand));
                if (questionCount == 0)
                {
                    MessageBox.Show("No questions found for the current exam. Please create a question before submitting the exam form.");
                    return;
                }

                string examStatus = "On-going";
                DateTime examCreated = DateTime.Now;

                // Use parameterized query to insert data into the examforms table
                string query = "INSERT INTO examforms (examCode, examTitle, examCreated, examDeadlineDate, examDeadlineTime, examStatus, examTotalStudents) " +
                                "VALUES (@examCode, @examTitle, @examCreated, @examDeadlineDate, @examDeadlineTime, @examStatus, @examTotalStudents)";

                MySqlCommand command = new MySqlCommand(query);
                command.Parameters.AddWithValue("@examCode", examCode);
                command.Parameters.AddWithValue("@examTitle", examTitle);
                command.Parameters.AddWithValue("@examCreated", examCreated.ToString("yyyy-MM-dd HH:mm:ss"));
                command.Parameters.AddWithValue("@examDeadlineDate", examDeadlineDate.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@examDeadlineTime", formattedTime);
                command.Parameters.AddWithValue("@examStatus", examStatus);
                command.Parameters.AddWithValue("@examTotalStudents", examTotalStudents);

                // Execute the query
                int rowsAffected = objDBAccess.executeQuery(command);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Exam form submitted successfully.");
                    ClearFields();
                    GenerateExamCode(); // Regenerate a new exam code for the next form
                }
                else
                {
                    MessageBox.Show("Failed to submit exam form.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            question_TB.Clear();
            point_TB.Clear();
            identification_TB.Clear();
            longAnswer_TB.Clear();
            multiple1_TB.Clear();
            multiple2_TB.Clear();
            multiple3_TB.Clear();
            multiple4_TB.Clear();
            contextualParaOnly_TB.Clear();
            contextualPara_TB.Clear();
            contextualFromQ_TB.Clear();
            contextualToQ_TB.Clear();
            manualC_CB.Checked = false;
            multiple1_RB.Checked = false;
            multiple2_RB.Checked = false;
            multiple3_RB.Checked = false;
            multiple4_RB.Checked = false;
            selectedFilePath = "";
            fileName_LBL.Text = "";
            fileName_LBL.Visible = false;
            deleteA_BTN.Visible = false;
        }

        private void view_BTN_Click(object sender, EventArgs e)
        {
            // Access the CodeValue property to get the code
            string code = CodeValue;

            // Check if the instance is null or disposed
            if (previewFormInstance == null || previewFormInstance.IsDisposed)
            {
                // Create a new instance of PreviewForm
                previewFormInstance = new PreviewForm();

                // Handle the FormClosed event to set previewFormInstance to null when the form is closed
                previewFormInstance.FormClosed += (s, args) => previewFormInstance = null;
            }

            // Set the code in the label of PreviewForm
            previewFormInstance.SetCodeLabel(code);

            // Show PreviewForm
            previewFormInstance.Show();

            // Ensure DisplayData method is called to load the data
            previewFormInstance.DisplayData();
        }


        private void discardBTN_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the exam code
                string examCode = examCodeBox.Text;

                // Create a SQL delete statement to delete questions using the exam code
                string deleteQuestionsQuery = "DELETE FROM examQuestions WHERE examCode = @examCode";

                MySqlCommand deleteCommand = new MySqlCommand(deleteQuestionsQuery);
                deleteCommand.Parameters.AddWithValue("@examCode", examCode);

                // Execute the delete query
                objDBAccess.createConn(); // Ensure connection is open
                int rowsAffected = objDBAccess.executeQuery(deleteCommand);
                objDBAccess.closeConn(); // Close connection

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Questions deleted successfully.");
                }
                else
                {
                    MessageBox.Show("No questions found to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting questions: " + ex.Message);
            }

            // Create an instance of teacherDashboardForm
            TeacherDashBoard dashboardForm = new TeacherDashBoard();

            // Show the teacherDashboardForm
            dashboardForm.Show();

            // Close the current form (newBlankForm)
            this.Hide();

            dashboardForm.FormClosed += (s, args) =>
            {
                // Close the application when newBlankForm is closed
                Application.Exit();
            };
        }


    }
}
