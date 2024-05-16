using System;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace TeacherDashboard
{
    public partial class newBlankForm : Form
    {
        private readonly database db = new database();
        private bool isDeadlineSelected = false;

        string selectedFilePath = "";
        public newBlankForm()
        {
            InitializeComponent();
            GenerateExamCode(); // Call the method to generate the exam code when the form is initialized
            questionType_DB.Items.AddRange(new object[] { "Identification", "Paragraph Form", "Multiple Choice", "Contextual Question" });

            // Set the default selection to "Short Answer"
            questionType_DB.SelectedIndex = 0;

            save_BTN.Click += save_BTN_Click;
            attachment_BT.Click += attachment_BT_Click;
            deleteA_BTN.Click += deleteAttachment_BTN_Click;
            manualC_CB.CheckedChanged += manualC_CB_CheckedChanged;

            longAnswer_TB.Visible = false;
            multiple1_RB.Visible = false;
            multiple2_RB.Visible = false;
            multiple3_RB.Visible = false;
            multiple4_RB.Visible = false;
            multiple1_TB.Visible = false;
            multiple2_TB.Visible = false;
            multiple3_TB.Visible = false;
            multiple4_TB.Visible = false;

            questionType_DB.SelectedIndexChanged += QuestionType_DB_SelectedIndexChanged;

            // Hide the delete button initially
            fileName_LBL.Visible = false;
            deleteA_BTN.Visible = false;
        }

        private void GenerateExamCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random rand = new Random();
            string examCode = new string(Enumerable.Repeat(chars, 6).Select(s => s[rand.Next(s.Length)]).ToArray());
            examCodeBox.Text = examCode;
            examCodeBox.ReadOnly = true; // Make the examCodeBox read-only
        }

        private void manualC_CB_CheckedChanged(object sender, EventArgs e)
        {
            bool manualCheckEnabled = manualC_CB.Checked;

            // Disable the components when manual checking is enabled
            point_TB.Enabled = !manualCheckEnabled;
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
            int? points = null;
            string questionType = questionType_DB.SelectedItem?.ToString();
            int manualCheck = manualC_CB.Checked ? 1 : 0;

            // Check if manual checking checkbox is not checked
            if (!manualC_CB.Checked)
            {
                switch (questionType)
                {
                    case "Identification":
                        if (string.IsNullOrWhiteSpace(identification_TB.Text))
                        {
                            MessageBox.Show("Please enter a short answer.");
                            return;
                        }
                        break;
                    case "Paragraph Form":
                        if (string.IsNullOrWhiteSpace(longAnswer_TB.Text))
                        {
                            MessageBox.Show("Please enter a long answer.");
                            return;
                        }
                        break;
                    case "Multiple Choice":
                        if (string.IsNullOrWhiteSpace(multiple1_TB.Text) ||
                            string.IsNullOrWhiteSpace(multiple2_TB.Text))
                        {
                            MessageBox.Show("Please enter at least two options for the multiple choice question.");
                            return;
                        }
                        if (!multiple1_RB.Checked && !multiple2_RB.Checked &&
                            !multiple3_RB.Checked && !multiple4_RB.Checked)
                        {
                            MessageBox.Show("Please select an answer for the multiple choice question.");
                            return;
                        }
                        break;
                }

                if (string.IsNullOrWhiteSpace(point_TB.Text))
                {
                    MessageBox.Show("Please enter points for the question.");
                    return;
                }
                else
                {
                    if (int.TryParse(point_TB.Text, out int parsedPoints))
                    {
                        points = parsedPoints;
                    }
                    else
                    {
                        MessageBox.Show("Invalid points value. Please enter a valid integer.");
                        return;
                    }
                }
            }
            else
            {
                points = null;
                identification_TB.Text = null;
                longAnswer_TB.Text = null;
                multiple1_TB.Text = null;
                multiple2_TB.Text = null;
                multiple3_TB.Text = null;
                multiple4_TB.Text = null;
            }

            if (questionType == "Multiple Choice" && manualC_CB.Checked)
            {
                if (string.IsNullOrWhiteSpace(multiple1_TB.Text) ||
                    string.IsNullOrWhiteSpace(multiple2_TB.Text))
                {
                    MessageBox.Show("Please enter at least two options for the multiple choice question.");
                    return;
                }
            }

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
                string query = "INSERT INTO examQuestions (question, examCode, question_type, image, point, manual_check, multiplechoice_choices, multiplechoice_answer,  identification, paragraph_type) " +
                               "VALUES (@Question, @Code, @QuestionType, @Image, @Point, @ManualCheck, @MultipleChoiceOptions, @MultipleChoiceAnswer, @ShortAnswer, @LongAnswer)";

                MySqlCommand command = new MySqlCommand(query);
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

                // Execute the query using the database class
                db.createConn(); // Ensure connection is open
                int rowsAffected = db.executeQuery(command);
                db.closeConn(); // Close connection

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
                    multiple1_RB.Checked = false;
                    multiple2_RB.Checked = false;
                    multiple3_RB.Checked = false;
                    multiple4_RB.Checked = false;
                    manualC_CB.Checked = false;
                    fileName_LBL.Visible = false;

                    deleteAttachment_BTN_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Failed to save data.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void attachment_BT_Click(object sender, EventArgs e)
        {
            // Open file dialog to select a file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif|Video files (*.mp4, *.avi, *.mov)|*.mp4;*.avi;*.mov|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                selectedFilePath = openFileDialog.FileName;

                // Set the file name to the label
                fileName_LBL.Text = Path.GetFileName(selectedFilePath);

                // Show the delete button
                deleteA_BTN.Visible = true;
                fileName_LBL.Visible = true;

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
            // Clear the selected file path and hide the delete button
            selectedFilePath = "";
            deleteA_BTN.Visible = false;
        }

        private void QuestionType_DB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle question type selection change
            string selectedQuestionType = questionType_DB.SelectedItem?.ToString();

            switch (selectedQuestionType)
            {
                case "Identification":
                    // Show short answer text box and hide other controls
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
                    break;

                case "Paragraph Form":
                    // Show long answer text box and hide other controls
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
                    break;

                case "Multiple Choice":
                    // Show multiple choice radio buttons and text boxes
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
                    break;
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

                int questionCount = Convert.ToInt32(db.executeScalar(checkCommand));
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
                int rowsAffected = db.executeQuery(command);

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
            examTitleBox.Text = "";
            examEstimateBox.Text = "";
            // Reset the deadline selected flag
            isDeadlineSelected = false;
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
                db.createConn(); // Ensure connection is open
                int rowsAffected = db.executeQuery(deleteCommand);
                db.closeConn(); // Close connection

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
            teacherDashboardForm dashboardForm = new teacherDashboardForm();

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
