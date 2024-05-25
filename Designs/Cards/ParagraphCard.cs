using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using Krypton.Toolkit;
namespace Exam_Management_System.Designs
{
    public partial class ParagraphCard : UserControl, IQuestionCard
    {
        private string questionText;
        public ParagraphCard()
        {
            InitializeComponent();
        }
        public string QuestionText
        {
            get => questionText;
            set
            {

                questionText = value;

                QuestionPHP.Text = value; // Update the label if needed
            }
        }
        private string answerText;
        public string AnswerText
        {
            get => answerText;
            set
            {
                answerText = value;
            }
        }
        private string questionID;
        public string QuestionID
        {
            get => questionID;
            set
            {
                questionID = value;

            }
        }

        public (string QuestionID, string Answer) GetAnswerData()
        {
            return (questionID, AnswerText);
        }
        private string pointValue;
        private string questionNumber;
        public string point
        {
            get => pointValue;
            set
            {
                pointValue = value;
                PointPH.Values.Text = value; // Update the label if needed
            }
        }

        public string qnum
        {
            get => questionNumber;
            set
            {
                questionNumber = value;
                QuestionPH.Values.Text = value; // Update the label if needed
            }
        }
        private void KryptonRichTextBox_TextChanged(object sender, EventArgs e)
        {
            // Measure the text size
            SizeF textSize = TextRenderer.MeasureText(AnswerTB.Text, AnswerTB.Font, AnswerTB.ClientSize, TextFormatFlags.WordBreak);

            // Add padding and border to the calculated size
            int newHeight = (int)Math.Ceiling(textSize.Height) + AnswerTB.Padding.Vertical + AnswerTB.Margin.Vertical + SystemInformation.BorderSize.Height * 4; // Adjust this value as needed

            // Set the minimum height to ensure visibility
            newHeight = Math.Max(newHeight, AnswerTB.MinimumSize.Height);

            // Set the new height for the control
            AnswerTB.Height = newHeight;
            AnswerText = AnswerTB.Text;
        }
    }
    
}
