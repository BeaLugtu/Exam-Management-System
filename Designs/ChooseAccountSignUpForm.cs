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
    public partial class ChooseAccountSignUpForm : Form
    {
        public ChooseAccountSignUpForm()
        {
            InitializeComponent();
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {

        }

        private void teacherAccountOptionBtn_MouseClick(object sender, MouseEventArgs e)
        {
            // Change the image of the button to the selected image
            teacherAccountOptionBtn.Image = Properties.Resources.StudentAccountOption;

            // Revert the studentAccountOptionBtn to its default image
            studentAccountOptionBtn.Image = Properties.Resources.TeacherAccountOption;
        }

        private void studentAccountOptionBtn_MouseClick(object sender, MouseEventArgs e)
        {
            // Change the image of the button to the selected image
            studentAccountOptionBtn.Image = Properties.Resources.StudentAccountOption;

            // Revert the studentAccountOptionBtn to its default image
            teacherAccountOptionBtn.Image = Properties.Resources.TeacherAccountOption;
        }
    }
}
