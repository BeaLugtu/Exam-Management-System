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

namespace Exam_Management_System.Designs
{
    public partial class MultipleChoiceCard : UserControl, IQuestionCard
    {
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
        private void kryptonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            KryptonRadioButton radioButton = sender as KryptonRadioButton;

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
            get => questionNumber;
            set
            {
                questionID = value;
            }
        }
        public (string QuestionID, string Answer) GetAnswerData()
        {
            return (QuestionID, SelectedOption); // Assuming SelectedOption is the property holding the selected answer
        }
    }
}
