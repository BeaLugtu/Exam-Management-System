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

        private void teacherAccountOptionBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Designs.SignupFormTeacher signupFormTeacher = new Designs.SignupFormTeacher();
            signupFormTeacher.Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void studentAccountOptionBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Designs.SignupFormStudent signupFormStudent = new Designs.SignupFormStudent();
            signupFormStudent.Show();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
