using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Management_System
{
    public partial class LoginForm : Form
    {

        DBAccess objDABAccess = new DBAccess();
        DataTable dtUsers = new DataTable();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string UserEmail = EmailTB.Text;
            string Password = PasswordTB.Text;

            if (UserEmail.Equals(""))
            {
                MessageBox.Show("Please Enter Your Email");
            }

            else if (Password.Equals(""))
            {
                MessageBox.Show("Please Enter Your Password");
            }
            else
            {
                string query = "Select * from Users Where Email= '" + UserEmail + "' AND Password = '" + Password + "'";

                objDABAccess.readDatathroughAdapter(query, dtUsers);

                if (dtUsers.Rows.Count > 0)
                {
                    MessageBox.Show("Successfully Log in.");
                    objDABAccess.closeConn();
                    this.Hide();

                    Designs.Homepage homePage = new Designs.Homepage();
                    homePage.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Input. Please Try Again.");
                }
            }

        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Designs.ChooseAccountSignUpForm chooseAccountSignUpForm = new Designs.ChooseAccountSignUpForm();
            chooseAccountSignUpForm.Show();
        }
    }
}
