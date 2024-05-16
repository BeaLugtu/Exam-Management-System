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
    public partial class Homepage : Form
    {
        public Homepage(string userID, UserType userType)
        {
            InitializeComponent();
            SetIDLblText(userID, userType);
        }

        private void SetIDLblText(string userID, UserType userType)
        {
            if (userType == UserType.Student)
            {
                IDLbl.Text = "Student ID: " + userID;
            }
            else if (userType == UserType.Teacher)
            {
                IDLbl.Text = "Teacher ID: " + userID;
            }
        }
    }
}
