using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        private string answerText;
        private string questionID;
        private string correctAnswer;
        public bool iscorrect;
        private string pointValue;
        private string questionNumber;

        public ParagraphCard()
        {
            InitializeComponent();
            QuestionPHP.ReadOnly = true; // Make the text box read-only
        }/*
        private Bitmap TextToImage(string text, Padding padding,  float roundingRadius, Color backColor, int width, int height)
        {Font font = new Font("Inter", (float)10.5);
            Color textColor = Color.FromArgb(255, 59, 59, 59);
            Bitmap bitmap = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(backColor);

                // Adjust the rectangle size to account for padding
                Rectangle textRectangle = new Rectangle(padding.Left, padding.Top, width - padding.Horizontal, height - padding.Vertical);

                // Create a rounded rectangle path
                GraphicsPath path = RoundedRectangle(new Rectangle(0, 0, width -0, height -0), roundingRadius);

                // Fill the path with the background color
                using (Brush backBrush = new SolidBrush(backColor))
                {
                    graphics.FillPath(backBrush, path);
                }

                // Draw the outline of the rounded rectangle
                using (Pen borderPen = new Pen(Color.FromArgb(255, 214, 214, 214), 10)) // Change thickness as needed
                {
                    graphics.DrawPath(borderPen, path);
                }

                // Draw the text with padding
                using (Brush textBrush = new SolidBrush(textColor))
                {
                    // Calculate the position for drawing the text with padding
                    float x = textRectangle.Left + padding.Left;
                    float y = textRectangle.Top + padding.Top;

                    // Draw the text
                    graphics.DrawString(text, font, textBrush, new PointF(x, y));
                }
            }
            return bitmap;
        }


        private GraphicsPath RoundedRectangle(Rectangle rectangle, float radius)
        {
            GraphicsPath path = new GraphicsPath();

            float diameter = radius * 2;
            SizeF sizeF = new SizeF(diameter, diameter);
            RectangleF arc = new RectangleF(rectangle.Location, sizeF);

            // Top left corner
            path.AddArc(arc, 180, 90);

            // Top right corner
            arc.X = rectangle.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Bottom right corner
            arc.Y = rectangle.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Bottom left corner
            arc.X = rectangle.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();

            return path;
        }
        private void SetQuestionPictureBoxImage(string text)
        {
            // Convert the text to an image
            
            Bitmap image = TextToImage(text, QuestionPHP.StateCommon.Content.Padding, QuestionPHP.StateCommon.Border.Rounding, QuestionPHP.StateCommon.Back.Color1, QuestionPHP.Width, QuestionPHP.Height);
            Font font = new Font("Inter", 9);
            // Set the image to the PictureBox
            Questionpic.Image = image;
        }

        private void HideQuestionTextBox()
        {
            QuestionPHP.Visible = false;
        }*/

        public string QuestionText
        {
            get => questionText;
            set
            {
                questionText = value;
                QuestionPHP.Text = value;
                /* SetQuestionPictureBoxImage(value);
                 HideQuestionTextBox();*/
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

        public string QuestionID
        {
            get => questionID;
            set
            {
                questionID = value;
            }
        }

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

        private int initialHeight; // Store the initial height of the AnswerTB control

        // Initialize the AnswerTB control
        private void InitializeAnswerTB()
        {
            initialHeight = AnswerTB.Height; // Store the initial height
        }

        // Handle the TextChanged event
        private void KryptonRichTextBox_TextChanged(object sender, EventArgs e)
        {
            // Measure the text size
            SizeF textSize = TextRenderer.MeasureText(AnswerTB.Text, AnswerTB.Font, AnswerTB.ClientSize, TextFormatFlags.WordBreak);

            // Add padding and border to the calculated size
            int newHeight = (int)Math.Ceiling(textSize.Height) + AnswerTB.Padding.Vertical + AnswerTB.Margin.Vertical + SystemInformation.BorderSize.Height * 4; // Adjust this value as needed

            // Set the minimum height to ensure visibility, using the initial height if needed
            newHeight = Math.Max(newHeight, initialHeight);

            // Set the new height for the control
            AnswerTB.Height = newHeight;
            AnswerText = AnswerTB.Text;
            iscorrect = false;
        }

    }
}
