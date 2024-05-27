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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Runtime.InteropServices;

namespace Exam_Management_System.Designs
{
    public partial class MultipleChoiceCard : UserControl, IQuestionCard
    {
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
        private string answerText;
        private string pointValue;
        private string questionNumber;
        private string questionText;
        private KryptonTextBox[] buttons;

        public MultipleChoiceCard()
        {
            InitializeComponent();
            buttons = new KryptonTextBox[] { Item1, Item2, Item3, Item4 };
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

        public string QuestionNumber
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
        private string selectedOption;
        private void kryptonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            KryptonRadioButton radioButton = sender as KryptonRadioButton;
            iscorrect = false;
            if (radioButton == null || !radioButton.Checked)
            {
                // Exit if the sender is not a KryptonRadioButton or if it's not checked
                return;
            }

            // Logic to assign selected option based on which radio button is checked
            if (radioButton == A)
            {
                selectedOption = "A";
            }
            else if (radioButton == B)
            {
                selectedOption = "C"; // Assuming you want to use Text2 property of Item2
            }
            else if (radioButton == C)
            {
                selectedOption = "B";
            }
            else if (radioButton == D)
            {
                selectedOption = "D";
            }
            else
            {
                // Handle other cases if necessary
            }
        }
        public string SelectedOption
        {
            get => selectedOption;
            set
            {
                selectedOption = value;
                // Update UI if needed
            }
        }

        public string[] Options
        {
            set
            {
                for (int i = 0; i < buttons.Length; i++)
                {
                    if (i < value.Length)
                    {
                        buttons[i].Text = value[i];
                        buttons[i].Visible = true;
                    }
                    else
                    {
                        buttons[i].Visible = false;
                    }
                }
            }
        }


        public (string QuestionID, string Answer, string CorrectAnswer, string Point, bool iscorrect) GetAnswerData()
        {
            return (QuestionID, SelectedOption, CorrectAnswer, Point, iscorrect);
        }
        private void QuestionPHP_Enter(object sender, EventArgs e)
        {
            HideCaret(QuestionPHP.Handle);
        }

        private void QuestionPHP_GotFocus(object sender, EventArgs e)
        {
            HideCaret(QuestionPHP.Handle);
        }


        /*
        private string questionText;
        private KryptonTextBox[] buttons;

        public MultipleChoiceCard()
        {
            InitializeComponent();
            buttons = new KryptonTextBox[] { Item1, Item2, Item3, Item4 };
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
        public bool iscorrect;
        private void kryptonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            KryptonRadioButton radioButton = sender as KryptonRadioButton;
            iscorrect = false;
            if (radioButton == null || !radioButton.Checked)
            {
                // Exit if the sender is not a KryptonRadioButton or if it's not checked
                return;
            }

            // Logic to assign selected option based on which radio button is checked
            if (radioButton == A)
            {
                selectedOption = "A";
            }
            else if (radioButton == B)
            {
                selectedOption = "C"; // Assuming you want to use Text2 property of Item2
            }
            else if (radioButton == C)
            {
                selectedOption = "B";
            }
            else if (radioButton == D)
            {
                selectedOption = "D";
            }
            else
            {
                // Handle other cases if necessary
            }
        }

        public string[] Options
        {
            set
            {
                for (int i = 0; i < buttons.Length; i++)
                {
                    if (i < value.Length)
                    {
                        buttons[i].Text = value[i];
                        buttons[i].Visible = true;
                    }
                    else
                    {
                        buttons[i].Visible = false;
                    }
                }
            }
        }
        private string pointValue;
        private string questionNumber;
        public string Point
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
        private string selectedOption;
        public string SelectedOption
        {
            get => selectedOption;
            set
            {
                selectedOption = value;
                // Update UI if needed
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
            return (QuestionID, SelectedOption, CorrectAnswer, Point, iscorrect);
        }*/
    }
    }
