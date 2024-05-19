using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Management_System.Designs
{
    public partial class teacherPreviewCard : UserControl
    {
        public string Question
        {
            get => Cquestion_TB.Text;
            set => Cquestion_TB.Text = value;
        }

        public string QuestionType
        {
            get => CquestionType_LBL.Text;
            set => CquestionType_LBL.Text = value;
        }

        public string Points
        {
            get => Cpoint_LBL.Text;
            set => Cpoint_LBL.Text = value ?? "";
        }

        private Image _imageData;
        public Image ImageData
        {
            get => Cimage_PB.Image;
            set
            {
                _imageData = value;
                // Cimage_PB.Image = value ?? Properties.Resources.DefaultImage; // Use default image if value is null
            }
        }

        public bool ManualCheckStatus
        {
            get => CmanualC_CB.Checked;
            set => CmanualC_CB.Checked = value;
        }

        public teacherPreviewCard()
        {
            InitializeComponent();
        }
    }
}
