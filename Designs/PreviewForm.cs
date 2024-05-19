using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Exam_Management_System.Designs
{
    public partial class PreviewForm : Form
    {
        string connectionString = "Server=26.96.197.206;Database=exam.io;Uid=admin;Pwd=admin;";

        public PreviewForm()
        {
            InitializeComponent();
            DisplayData();
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

                    string query = "SELECT question, question_type, point, manual_check FROM examquestions WHERE examCode = @Code";
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
                                string questionType = reader.GetString("question_type");
                                int? points = reader.IsDBNull(reader.GetOrdinal("point")) ? (int?)null : reader.GetInt32("point");
                                bool manualCheckStatus = reader.GetBoolean("manual_check");

                                teacherPreviewCard card = new teacherPreviewCard
                                {
                                    Question = question,
                                    QuestionType = questionType,
                                    Points = points?.ToString() + " pt(s)",
                                    ManualCheckStatus = manualCheckStatus
                                };

                                sh_FLP.Controls.Add(card);
                                Console.WriteLine("Card added to FlowLayoutPanel.");
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
    }
}
