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
    public partial class ContextualCard : UserControl
    {
        
        public ContextualCard()
        {
            InitializeComponent();
        }
        private string contextplace;
        public string contextget
        {
            get => contextplace;
            set
            {
                
                contextplace = value;
                
                context.Text = value; // Update the label if needed
            }
        }
    }
}
