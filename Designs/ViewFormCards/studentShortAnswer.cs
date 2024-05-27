using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Management_System.Designs.Answer_Cards
{
    public partial class studentShortAnswer : UserControl
    {
        private string questionText;
        private string answerText;
        private string pointValue;
        private string questionNumber;
        
        public studentShortAnswer()
        {
            InitializeComponent();
        }

        private void studentShortAnswer_Load(object sender, EventArgs e)
        {

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
        private string upoint;
        public string Upoint
        {
            get => upoint;
            set
            {
                upoint = value;
                PointPH.Values.Text = Point + "/" + upoint; // Update the label if needed
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
                AnswerTB.Text = value;
            }
        }
        private string correctans;
        public string CorrectAns
        {
            get => correctans;
            set
            {
                correctans = value;
                CorrectAnswer.Text = value;
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
    }
}
