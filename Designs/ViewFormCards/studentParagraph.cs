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
    public partial class studentParagraph : UserControl
    {
        
        public studentParagraph()
        {
            InitializeComponent();
        }

        private void studentParagraph_Load(object sender, EventArgs e)
        {

        }

        private string questionText;
        public string QuestionText
        {
            get => questionText;
            set
            {

                questionText = value;
                Remarks.Visible = false;
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
                AnswerTB.Text = value;
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


        private string pointValue;
        private string questionNumber;
        public string point
        {
            get => pointValue;
            set
            {
                pointValue = value;
               
            }
        }
        private string upoint;
        public string Upoint
        {
            get => upoint;
            set
            {
                upoint = value;
                PointPH.Values.Text = point + "/" + upoint; // Update the label if needed
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
        private bool isLightOn = false;

        private void ToggleButton_Click(object sender, EventArgs e)
        {
            // Toggle the state of the light

            // Update the UI based on the state
            if (isLightOn == true)
            {
                isLightOn = false;
                // Light is on
                // Perform actions to turn the light on
                // For example, change the button text or image to indicate the light is on
                AnswerTB.Visible = true;
                Remarks.Visible = false;
                Remark.Values.Text = "Remarks";
                // Other actions...
            }
            else if(isLightOn == false)
            {
                isLightOn = true;
                // Light is off
                // Perform actions to turn the light off
                // For example, change the button text or image to indicate the light is off
                Remark.Values.Text = "Answer";
                AnswerTB.Visible = false;
                Remarks.Visible = true;
                // Other actions...
            }
        }

        private void AnswerTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
