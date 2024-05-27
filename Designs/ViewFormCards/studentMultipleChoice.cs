using Google.Protobuf.WellKnownTypes;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Exam_Management_System.Designs.Answer_Cards
{
    public partial class studentMultipleChoice : UserControl
    {
        private string questionText;
        private KryptonTextBox[] buttons;
        public studentMultipleChoice()

        {
            InitializeComponent();
            buttons = new KryptonTextBox[] { Item1, Item2, Item3, Item4 };
        }

        private void C_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void studentMultipleChoice_Load(object sender, EventArgs e)
        {

        }

        private void D_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Questionmultiple_TextChanged(object sender, EventArgs e)
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
        private string correctAns;
        public string CorrectAns
        {
            get => correctAns;
            set
            {
                correctAns = value;
                UpdateUI(); // Call UpdateUI whenever CorrectAns is set
            }
        }

        private string selectedOption;
        public string SelectedOption
        {
            get => selectedOption;
            set
            {
                selectedOption = value;

                // Enable all radio buttons before updating
                A.Enabled = true;
                B.Enabled = true;
                C.Enabled = true;
                D.Enabled = true;

                // Update the UI to select the radio button based on the fetched data
                switch (selectedOption)
                {
                    case "A":
                        A.Checked = true; // Select radio button A if option 'A' is fetched
                        B.Enabled = false;
                        C.Enabled = false;
                        D.Enabled = false;
                        break;
                    case "B":
                        C.Checked = true; // Select radio button B if option 'B' is fetched
                        A.Enabled = false;
                        B.Enabled = false;
                        D.Enabled = false;
                        break;
                    case "C":
                        B.Checked = true; // Select radio button C if option 'C' is fetched
                        A.Enabled = false;
                        C.Enabled = false;
                        D.Enabled = false;
                        break;
                    case "D":
                        D.Checked = true; // Select radio button D if option 'D' is fetched
                        A.Enabled = false;
                        B.Enabled = false;
                        C.Enabled = false;
                        break;
                    default:
                        // Clear the selection if the fetched data doesn't match any option
                        A.Checked = false;
                        B.Checked = false;
                        C.Checked = false;
                        D.Checked = false;
                        break;
                }

                // Update UI if needed
                UpdateUI();
            }
        }

        private void UpdateUI()
        {
            // Check if the selected option matches the correct answer
            if (selectedOption == correctAns)
            {
                // Add a check mark to the correct answer
                switch (SelectedOption)
                {
                    case "A":
                        Item1.Text = Item1.Text.TrimEnd('✗') + " ✓"; // Remove any existing X mark
                        break;
                    case "B":
                        Item3.Text = Item3.Text.TrimEnd('✗') + " ✓";
                        break;
                    case "C":
                        Item2.Text = Item2.Text.TrimEnd('✗') + " ✓";
                        break;
                    case "D":
                        Item4.Text = Item4.Text.TrimEnd('✗') + " ✓";
                        break;
                }
            }
            else if(selectedOption!=correctAns)
            {
                // Add a check mark to the user's answer and an X mark to the correct answer
                switch (CorrectAns)
                {
                    case "A":
                        Item1.Text = Item1.Text.TrimEnd('✓', '✗') + " ✓"; // Remove existing marks
                        break;
                    case "B":
                        Item3.Text = Item3.Text.TrimEnd('✓', '✗') + " ✓";
                        break;
                    case "C":
                        Item2.Text = Item2.Text.TrimEnd('✓', '✗') + " ✓";
                        break;
                    case "D":
                        Item4.Text = Item4.Text.TrimEnd('✓', '✗') + " ✓";
                        break;
                }

                switch (SelectedOption)
                {
                    case "A":
                        Item1.Text = Item1.Text.TrimEnd('✓', '✗') + " ✗"; // Remove existing marks
                        break;
                    case "B":
                        Item3.Text = Item3.Text.TrimEnd('✓', '✗') + " ✗";
                        break;
                    case "C":
                        Item2.Text = Item2.Text.TrimEnd('✓', '✗') + " ✗";
                        break;
                    case "D":
                        Item4.Text = Item4.Text.TrimEnd('✓', '✗') + " ✗";
                        break;
                }
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





    }
}
