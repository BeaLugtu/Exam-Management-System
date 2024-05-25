using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Exam_Management_System.Designs
{
    public partial class PreviewForm : Form
    {
        string connectionString = "Server=26.96.197.206;Database=exam.io;Uid=admin;Pwd=admin;";

        public PreviewForm()
        {
            InitializeComponent();
            DisplayData();
            DisplayNumberOfQuestions();

        }

        public string GetExamCode()
        {
            return codePreviewForm_LBL.Text;

        }

        public void SetCodeLabel(string code)
        {
            codePreviewForm_LBL.Text = code;
            Console.WriteLine($"SetCodeLabel called with code: {code}");
            DisplayData();
        }

        public void DisplayData()
        {
            string code = codePreviewForm_LBL.Text;

            if (string.IsNullOrWhiteSpace(code))
            {
                Console.WriteLine("Code is empty. Aborting data fetch.");
                return;
            }

            sh_FLP.Controls.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Database connection opened.");


                    string query = "SELECT question,questionNumber, question_type, point, manual_check, identification, paragraph_type, multiplechoice_choices, multiplechoice_answer, image, contextual_paragraph FROM examquestions WHERE examCode = @Code";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Code", code);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                Console.WriteLine($"No rows found for the provided code: {code}");
                            }

                            while (reader.Read())
                            {
                                string question = reader.GetString("question");
                                int questionNumber = reader.GetInt32("questionNumber");
                                string questionType = reader.GetString("question_type");
                                int? points = reader.IsDBNull(reader.GetOrdinal("point")) ? (int?)null : reader.GetInt32("point");
                                bool manualCheckStatus = reader.GetBoolean("manual_check");
                                string identification = reader.IsDBNull(reader.GetOrdinal("identification")) ? null : reader.GetString("identification");
                                string paragraphType = reader.IsDBNull(reader.GetOrdinal("paragraph_type")) ? null : reader.GetString("paragraph_type");
                                string multipleChoiceChoices = reader.IsDBNull(reader.GetOrdinal("multiplechoice_choices")) ? null : reader.GetString("multiplechoice_choices");
                                string multipleChoiceAnswer = reader.IsDBNull(reader.GetOrdinal("multiplechoice_answer")) ? null : reader.GetString("multiplechoice_answer");
                                byte[] imageBytes = reader.IsDBNull(reader.GetOrdinal("image")) ? null : (byte[])reader["image"];
                                string contextualParagraph = reader.IsDBNull(reader.GetOrdinal("contextual_paragraph")) ? null : reader.GetString("contextual_paragraph");

                                teacherPreviewCard card = new teacherPreviewCard
                                {
                                    Question = question,
                                    QuestionNumber = questionNumber.ToString(),
                                    QuestionType = questionType,
                                    Points = points?.ToString(),
                                    ManualCheckStatus = manualCheckStatus,
                                    Identification = identification,
                                    ParagraphType = paragraphType,
                                    MultipleChoiceChoices = multipleChoiceChoices,
                                    MultipleChoiceAnswer = multipleChoiceAnswer,
                                    ImageData = imageBytes != null ? ByteArrayToImage(imageBytes) : null,
                                    ContextualParagraph = contextualParagraph,
                                    ContextualParagraphImage = new Tuple<Image, string>(imageBytes != null ? ByteArrayToImage(imageBytes) : null, contextualParagraph)
                                };

                                sh_FLP.Controls.Add(card);
                                Console.WriteLine("Card added to FlowLayoutPanel.");

                                DisplayNumberOfQuestions();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving data: " + ex.Message);
                    Console.WriteLine($"Exception: {ex.Message}");
                }
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        // FOR REFERENCE
        public void DisplayNumberOfQuestions()
        {
            string code = codePreviewForm_LBL.Text;

            if (string.IsNullOrWhiteSpace(code))
            {
                Console.WriteLine("Code is empty. Aborting question count fetch.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Database connection opened.");

                    string query = "SELECT COUNT(*) FROM examquestions WHERE examCode = @Code";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Code", code);
                        int questionCount = Convert.ToInt32(command.ExecuteScalar());

                        noOfQuestions_LBL.Text = $"{questionCount} questions";
                        Console.WriteLine($"Number of questions: {questionCount}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving number of questions: " + ex.Message);
                    Console.WriteLine($"Exception: {ex.Message}");
                }
            }
        }

    }
}
