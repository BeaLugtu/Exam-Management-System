using System;
using System.Drawing;
using System.Windows.Forms;

namespace Exam_Management_System.Designs
{
    public partial class TeacherCheckingCard : UserControl
    {
        public TeacherCheckingCard()
        {
            InitializeComponent();

            question_LBL.Visible = true;
            scorePoint_TB.Visible = true;
            overScore_LBL.Visible = true;
            answer_LBL.Visible = true;
            multiple1_RB.Visible = false;
            multiple2_RB.Visible = false;
            multiple3_RB.Visible = false;
            multiple4_RB.Visible = false;
            multiple1_TB.Visible = false;
            multiple2_TB.Visible = false;
            multiple3_TB.Visible = false;
            multiple4_TB.Visible = false;
            contextualPicOnly_PB.Visible = false;
            contextualParaOnly_TB.Visible = false;
            contextualPic_PB.Visible = false;
            contextualPara_TB.Visible = false;
        }

        // Public property to access question_LBL text
        public string QuestionText
        {
            get { return question_LBL.Text; }
            set { question_LBL.Text = value; }
        }

        // Public property to access answer_LBL text
        public string AnswerText
        {
            get { return answer_LBL.Text; }
            set { answer_LBL.Text = value; }
        }

        // Property for contextual paragraph text
        public string ContextualParaOnlyText
        {
            get { return contextualParaOnly_TB.Text; }
            set { contextualParaOnly_TB.Text = value; }
        }

        // Property for contextual image
        public Image ContextualPicOnlyImage
        {
            get { return contextualPicOnly_PB.Image; }
            set { contextualPicOnly_PB.Image = value; }
        }

        // Property for contextual paragraph and image
        public string ContextualParaText
        {
            get { return contextualPara_TB.Text; }
            set { contextualPara_TB.Text = value; }
        }

        public Image ContextualPicImage
        {
            get { return contextualPic_PB.Image; }
            set { contextualPic_PB.Image = value; }
        }

        public string MultipleChoiceOption1
        {
            get { return multiple1_TB.Text; }
            set { multiple1_TB.Text = value; }
        }

        public string MultipleChoiceOption2
        {
            get { return multiple2_TB.Text; }
            set { multiple2_TB.Text = value; }
        }

        public string MultipleChoiceOption3
        {
            get { return multiple3_TB.Text; }
            set { multiple3_TB.Text = value; }
        }

        public string MultipleChoiceOption4
        {
            get { return multiple4_TB.Text; }
            set { multiple4_TB.Text = value; }
        }

        public bool Multiple1RBVisible
        {
            get { return multiple1_RB.Visible; }
            set { multiple1_RB.Visible = value; multiple1_TB.Visible = value; }
        }

        public bool Multiple2RBVisible
        {
            get { return multiple2_RB.Visible; }
            set { multiple2_RB.Visible = value; multiple2_TB.Visible = value; }
        }

        public bool Multiple3RBVisible
        {
            get { return multiple3_RB.Visible; }
            set { multiple3_RB.Visible = value; multiple3_TB.Visible = value; }
        }

        public bool Multiple4RBVisible
        {
            get { return multiple4_RB.Visible; }
            set { multiple4_RB.Visible = value; multiple4_TB.Visible = value; }
        }

        public string OverScoreText
        {
            get { return overScore_LBL.Text; }
            set { overScore_LBL.Text = "/" + value; }
        }

        public string ScorePointText
        {
            get { return scorePoint_TB.Text; }
            set { scorePoint_TB.Text = value; }
        }


        public bool Multiple1RBChecked
        {
            get { return multiple1_RB.Checked; }
            set { multiple1_RB.Checked = value; }
        }

        public bool Multiple2RBChecked
        {
            get { return multiple2_RB.Checked; }
            set { multiple2_RB.Checked = value; }
        }

        public bool Multiple3RBChecked
        {
            get { return multiple3_RB.Checked; }
            set { multiple3_RB.Checked = value; }
        }

        public bool Multiple4RBChecked
        {
            get { return multiple4_RB.Checked; }
            set { multiple4_RB.Checked = value; }
        }

        // Add this property in your TeacherCheckingCard class
        public string TeacherAnswerText
        {
            get { return teacherAnswer_LBL.Text; }
            set { teacherAnswer_LBL.Text = value; }
        }


        // Method to hide non-contextual paragraph controls
        public void HideNonContextualParagraphControls()
        {
            question_LBL.Visible = false;
            point_LBL.Visible = false;
            scorePoint_TB.Visible = false;
            overScore_LBL.Visible = false;
            answer_LBL.Visible = false;
            teacherAnswer_LBL.Visible = false;
            multiple1_RB.Visible = false;
            multiple2_RB.Visible = false;
            multiple3_RB.Visible = false;
            multiple4_RB.Visible = false;
            multiple1_TB.Visible = false;
            multiple2_TB.Visible = false;
            multiple3_TB.Visible = false;
            multiple4_TB.Visible = false;
            contextualPicOnly_PB.Visible = false;
            contextualParaOnly_TB.Visible = true;
            contextualPic_PB.Visible = false;
            contextualPara_TB.Visible = false;
        }

        public void HideNonContextualImageControls()
        {
            question_LBL.Visible = false;
            point_LBL.Visible = false;
            scorePoint_TB.Visible = false;
            overScore_LBL.Visible = false;
            answer_LBL.Visible = false;
            teacherAnswer_LBL.Visible = false;
            multiple1_RB.Visible = false;
            multiple2_RB.Visible = false;
            multiple3_RB.Visible = false;
            multiple4_RB.Visible = false;
            multiple1_TB.Visible = false;
            multiple2_TB.Visible = false;
            multiple3_TB.Visible = false;
            multiple4_TB.Visible = false;
            contextualPicOnly_PB.Visible = true;
            contextualParaOnly_TB.Visible = false;
            contextualPic_PB.Visible = false;
            contextualPara_TB.Visible = false;
        }

        public void HideNonContextualImageAndParagraphControls()
        {
            question_LBL.Visible = false;
            point_LBL.Visible = false;
            scorePoint_TB.Visible = false;
            overScore_LBL.Visible = false;
            answer_LBL.Visible = false;
            teacherAnswer_LBL.Visible = false;
            multiple1_RB.Visible = false;
            multiple2_RB.Visible = false;
            multiple3_RB.Visible = false;
            multiple4_RB.Visible = false;
            multiple1_TB.Visible = false;
            multiple2_TB.Visible = false;
            multiple3_TB.Visible = false;
            multiple4_TB.Visible = false;
            contextualPicOnly_PB.Visible = false;
            contextualParaOnly_TB.Visible = false;
            contextualPic_PB.Visible = true;
            contextualPara_TB.Visible = true;
        }

        // Method to hide non-multiple choice controls
        public void HideNonMultipleChoiceControls()
        {
            question_LBL.Visible = true;
            point_LBL.Visible = true;
            scorePoint_TB.Visible = true;
            overScore_LBL.Visible = true;
            answer_LBL.Visible = false;
            teacherAnswer_LBL.Visible = true;
            multiple1_RB.Visible = true;
            multiple2_RB.Visible = true;
            multiple3_RB.Visible = multiple3_TB.Visible && !string.IsNullOrEmpty(multiple3_TB.Text);
            multiple4_RB.Visible = multiple4_TB.Visible && !string.IsNullOrEmpty(multiple4_TB.Text);
            multiple1_TB.Visible = true;
            multiple2_TB.Visible = true;
            multiple3_TB.Visible = multiple3_TB.Visible && !string.IsNullOrEmpty(multiple3_TB.Text);
            multiple4_TB.Visible = multiple4_TB.Visible && !string.IsNullOrEmpty(multiple4_TB.Text);
            contextualPicOnly_PB.Visible = false;
            contextualParaOnly_TB.Visible = false;
            contextualPic_PB.Visible = false;
            contextualPara_TB.Visible = false;
        }
    }
}
