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
namespace Exam_Management_System.Designs
{
    public partial class IdentificationCard : UserControl, IQuestionCard
    {
        private string questionText;
        private string answerText;
        private string pointValue;
        private string questionNumber;

        public IdentificationCard()
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

        
        public string Point
        {
            get => pointValue;
            set
            {
                pointValue = value;
                PointPH.Values.Text = value; // Update the label if needed
            }
        }

        public string Qnum
        {
            get => questionNumber;
            set
            {
                questionNumber = value;
                QuestionPH.Values.Text = value; // Update the label if needed
            }
        }
        public string AnswerText
        {
            get => answerText;
            set
            {
                answerText = value;
            }
        }
        public bool iscorrect;
        private void AnswerTB_TextChanged(object sender, EventArgs e)
        {
            // Update the AnswerText property when the text in AnswerTB changes
            AnswerText = AnswerTB.Text;
            iscorrect = false;
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
        private string correctAnswer;
        public string CorrectAnswer
        {
            get => correctAnswer;
            set
            {
                correctAnswer = value;
            }
        }
        

        public (string QuestionID, string Answer, string CorrectAnswer, string Point, bool iscorrect) GetAnswerData()
        {
            return (questionID, AnswerText, CorrectAnswer, Point, iscorrect);
        }
    }

}
