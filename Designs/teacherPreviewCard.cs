using System;
using System.Drawing;
using System.Windows.Forms;

namespace Exam_Management_System.Designs
{
    public partial class teacherPreviewCard : UserControl
    {
        public teacherPreviewCard()
        {
            InitializeComponent();

            // Populate the combo box with options
            CquestionType_CB.Items.AddRange(new string[]
            {
            "Identification",
            "Paragraph Form",
            "Multiple Choice",
            "Contextual Paragraph",
            "Contextual Image",
            "Contextual Paragraph & Image"
            });

            CquestionType_CB.SelectedIndexChanged += CQuestionType_CB_SelectedIndexChanged;
            edit_BTN.Click += Edit_BTN_Click;

            save_BTN.Enabled = false;

            Cpoint_TB.Enabled = false;
            points_LBL.Enabled = false;
            Cquestion_TB.Enabled = false;
            CmanualC_CB.Enabled = false;
            CquestionType_CB.Enabled = false;
            Cquestion_TB.Enabled = false;
            CmanualC_CB.Enabled = false;
            CshortAnswer_TB.Enabled = false;
            ClongAnswer_TB.Enabled = false;
            Cmultiple1_TB.Enabled = false;
            Cmultiple2_TB.Enabled = false;
            Cmultiple3_TB.Enabled = false;
            Cmultiple4_TB.Enabled = false;
            Cmultiple1_RB.Enabled = false;
            Cmultiple2_RB.Enabled = false;
            Cmultiple3_RB.Enabled = false;
            Cmultiple4_RB.Enabled = false;

            CcontextualParaOnly_TB.Enabled = false;
            CcontextualPara_TB.Enabled = false;

            CattachmentBoth_BT.Enabled = false;
            CattachmentBoth_BT.Enabled = false;
            delete_BTN.Enabled = false;
        }

        private void CQuestionType_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedQuestionType = CquestionType_CB.SelectedItem?.ToString();

            switch (selectedQuestionType)
            {
                case "Identification":
                    Cquestion_TB.Visible = true;
                    CshortAnswer_TB.Visible = true;
                    ClongAnswer_TB.Visible = false;
                    Cmultiple1_RB.Visible = false;
                    Cmultiple2_RB.Visible = false;
                    Cmultiple3_RB.Visible = false;
                    Cmultiple4_RB.Visible = false;
                    Cmultiple1_TB.Visible = false;
                    Cmultiple2_TB.Visible = false;
                    Cmultiple3_TB.Visible = false;
                    Cmultiple4_TB.Visible = false;
                    Cattachment_BT.Visible = false;
                    CattachmentBoth_BT.Visible = false;
                    delete_BTN.Visible = false;
                    points_LBL.Visible = true;
                    Cpoint_TB.Visible = true;  

                    CcontextualParaOnly_TB.Visible = false;
                    CcontextualPicOnly_PB.Visible = false;
                    CcontextualPara_TB.Visible = false;
                    CcontextualPic_PB.Visible = false;
                    break;

                case "Paragraph Form":
                    Cquestion_TB.Visible = true;
                    CshortAnswer_TB.Visible = false;
                    ClongAnswer_TB.Visible = true;
                    Cmultiple1_RB.Visible = false;
                    Cmultiple2_RB.Visible = false;
                    Cmultiple3_RB.Visible = false;
                    Cmultiple4_RB.Visible = false;
                    Cmultiple1_TB.Visible = false;
                    Cmultiple2_TB.Visible = false;
                    Cmultiple3_TB.Visible = false;
                    Cmultiple4_TB.Visible = false;
                    Cattachment_BT.Visible = false;
                    CattachmentBoth_BT.Visible = false;
                    delete_BTN.Visible = false;
                    points_LBL.Visible = true;
                    Cpoint_TB.Visible = true;

                    CcontextualParaOnly_TB.Visible = false;
                    CcontextualPicOnly_PB.Visible = false;
                    CcontextualPara_TB.Visible = false;
                    CcontextualPic_PB.Visible = false;
                    break;

                case "Multiple Choice":
                    Cquestion_TB.Visible = true;
                    CshortAnswer_TB.Visible = false;
                    ClongAnswer_TB.Visible = false;
                    Cmultiple1_RB.Visible = true;
                    Cmultiple2_RB.Visible = true;
                    Cmultiple3_RB.Visible = true;
                    Cmultiple4_RB.Visible = true;
                    Cmultiple1_TB.Visible = true;
                    Cmultiple2_TB.Visible = true;
                    Cmultiple3_TB.Visible = true;
                    Cmultiple4_TB.Visible = true;
                    Cattachment_BT.Visible = false;
                    CattachmentBoth_BT.Visible = false;
                    delete_BTN.Visible = false;
                    points_LBL.Visible = true;
                    Cpoint_TB.Visible = true;

                    CcontextualParaOnly_TB.Visible = false;
                    CcontextualPicOnly_PB.Visible = false;
                    CcontextualPara_TB.Visible = false;
                    CcontextualPic_PB.Visible = false;
                    break;

                case "Contextual Paragraph":
                    Cquestion_TB.Visible = false;
                    CshortAnswer_TB.Visible = false;
                    ClongAnswer_TB.Visible = false;
                    Cmultiple1_RB.Visible = false;
                    Cmultiple2_RB.Visible = false;
                    Cmultiple3_RB.Visible = false;
                    Cmultiple4_RB.Visible = false;
                    Cmultiple1_TB.Visible = false;
                    Cmultiple2_TB.Visible = false;
                    Cmultiple3_TB.Visible = false;
                    Cmultiple4_TB.Visible = false;
                    Cattachment_BT.Visible = false;
                    CattachmentBoth_BT.Visible = false;
                    delete_BTN.Visible = false;
                    Cpoint_TB.Visible = false;
                    CmanualC_CB.Visible = false;
                    points_LBL.Visible = false;

                    CcontextualParaOnly_TB.Visible = true;
                    CcontextualPicOnly_PB.Visible = false;
                    CcontextualPara_TB.Visible = false;
                    CcontextualPic_PB.Visible = false;
                    break;

                case "Contextual Image":
                    Cquestion_TB.Visible = false;
                    CshortAnswer_TB.Visible = false;
                    ClongAnswer_TB.Visible = false;
                    Cmultiple1_RB.Visible = false;
                    Cmultiple2_RB.Visible = false;
                    Cmultiple3_RB.Visible = false;
                    Cmultiple4_RB.Visible = false;
                    Cmultiple1_TB.Visible = false;
                    Cmultiple2_TB.Visible = false;
                    Cmultiple3_TB.Visible = false;
                    Cmultiple4_TB.Visible = false;
                    Cattachment_BT.Visible = false;
                    CattachmentBoth_BT.Visible = true;
                    Cpoint_TB.Visible = false;
                    CmanualC_CB.Visible = false;
                    points_LBL.Visible = false;

                    CcontextualParaOnly_TB.Visible = false;
                    CcontextualPicOnly_PB.Visible = true;
                    CcontextualPara_TB.Visible = false;
                    CcontextualPic_PB.Visible = false;
                    break;

                case "Contextual Paragraph & Image":
                    Cquestion_TB.Visible = false;
                    CshortAnswer_TB.Visible = false;
                    ClongAnswer_TB.Visible = false;
                    Cmultiple1_RB.Visible = false;
                    Cmultiple2_RB.Visible = false;
                    Cmultiple3_RB.Visible = false;
                    Cmultiple4_RB.Visible = false;
                    Cmultiple1_TB.Visible = false;
                    Cmultiple2_TB.Visible = false;
                    Cmultiple3_TB.Visible = false;
                    Cmultiple4_TB.Visible = false;
                    Cattachment_BT.Visible = false;
                    CattachmentBoth_BT.Visible = true;
                    Cpoint_TB.Visible = false;
                    CmanualC_CB.Visible = false;
                    points_LBL.Visible = false;

                    CcontextualParaOnly_TB.Visible = false;
                    CcontextualPicOnly_PB.Visible = false;
                    CcontextualPara_TB.Visible = true;
                    CcontextualPic_PB.Visible = true;
                    break;
            }
        }

        private void Edit_BTN_Click(object sender, EventArgs e)
        {
            save_BTN.Enabled = true;
            Cpoint_TB.Enabled = true;
            Cquestion_TB.Enabled = true;
            CmanualC_CB.Enabled = true;
            CquestionType_CB.Enabled = true;
            Cquestion_TB.Enabled = true;
            CmanualC_CB.Enabled = true;
            CshortAnswer_TB.Enabled = true;
            ClongAnswer_TB.Enabled = true;
            Cmultiple1_TB.Enabled = true;
            Cmultiple2_TB.Enabled = true;
            Cmultiple3_TB.Enabled = true;
            Cmultiple4_TB.Enabled = true;
            Cmultiple1_RB.Enabled = true;
            Cmultiple2_RB.Enabled = true;
            Cmultiple3_RB.Enabled = true;
            Cmultiple4_RB.Enabled = true;

            CcontextualParaOnly_TB.Enabled = true;
            CcontextualPara_TB.Enabled = true;

            CattachmentBoth_BT.Enabled = true;
            CattachmentBoth_BT.Enabled = true;
            delete_BTN.Enabled = true;
        }

        public string Question
        {
            get { return Cquestion_TB.Text; }
            set { Cquestion_TB.Text = value; }
        }

        public string QuestionType
        {
            get { return CquestionType_CB.Text; }
            set { CquestionType_CB.Text = value; }
        }

        public string Points
        {
            get { return Cpoint_TB.Text; }
            set { Cpoint_TB.Text = value; }
        }

        public bool ManualCheckStatus
        {
            get { return CmanualC_CB.Checked; }
            set { CmanualC_CB.Checked = value; }
        }

        public string Identification
        {
            get { return CshortAnswer_TB.Text; }
            set { CshortAnswer_TB.Text = value; }
        }

        public string ParagraphType
        {
            get { return ClongAnswer_TB.Text; }
            set { ClongAnswer_TB.Text = value; }
        }

        public string MultipleChoiceChoices
        {
            get
            {
                return $"{Cmultiple1_TB.Text},{Cmultiple2_TB.Text},{Cmultiple3_TB.Text},{Cmultiple4_TB.Text}";
            }
            set
            {
                string[] choices = value.Split(',');
                if (choices.Length >= 4)
                {
                    Cmultiple1_TB.Text = choices[0];
                    Cmultiple2_TB.Text = choices[1];
                    Cmultiple3_TB.Text = choices[2];
                    Cmultiple4_TB.Text = choices[3];
                }
            }
        }

        public string MultipleChoiceAnswer
        {
            get
            {
                if (Cmultiple1_RB.Checked) return Cmultiple1_TB.Text;
                if (Cmultiple2_RB.Checked) return Cmultiple2_TB.Text;
                if (Cmultiple3_RB.Checked) return Cmultiple3_TB.Text;
                if (Cmultiple4_RB.Checked) return Cmultiple4_TB.Text;
                return null;
            }
            set
            {
                if (Cmultiple1_TB.Text == value) Cmultiple1_RB.Checked = true;
                if (Cmultiple2_TB.Text == value) Cmultiple2_RB.Checked = true;
                if (Cmultiple3_TB.Text == value) Cmultiple3_RB.Checked = true;
                if (Cmultiple4_TB.Text == value) Cmultiple4_RB.Checked = true;
            }
        }

        public string ContextualParagraph
        {
            get { return CcontextualPara_TB.Text; }
            set { CcontextualPara_TB.Text = value; }
        }

        public Image ImageData
        {
            get { return CcontextualPicOnly_PB.Image; }
            set { CcontextualPicOnly_PB.Image = value; }
        }

        public Tuple<Image, string> ContextualParagraphImage
        {
            set
            {
                if (value != null)
                {
                    CcontextualPic_PB.Image = value.Item1;
                    CcontextualPara_TB.Text = value.Item2;
                }
            }
        }
    }
}
