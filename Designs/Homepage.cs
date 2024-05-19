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
        DBAccess objDABAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        //Passing User ID and usertype as Parameters to Profile
        private string userID;
        private Profile profileForm;

        public Homepage(string userID, UserType userType)
        {
            this.userID = userID.ToString();
            InitializeComponent();
            kryptonLabel1.Text = userID.ToString();
            kryptonLabel2.Text = userType.ToString();
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
        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            string query = "Select * from Users Where ID= '" + userID + "'";

            objDABAccess.readDatathroughAdapter(query, dtUsers);

            if (dtUsers.Rows.Count > 0)
            {
                // Get the user ID and user type from the database
                userID = dtUsers.Rows[0]["ID"].ToString();
                UserType userType = (UserType)Enum.Parse(typeof(UserType), dtUsers.Rows[0]["User_Type"].ToString());

                objDABAccess.closeConn();
                this.Hide();

                // Pass user ID and user type to the homepage
                //Designs.Homepage homePage = new Designs.Homepage(userID, userType);
                //homePage.Show();
                profileForm = new Profile(userID, userType);
                profileForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Input. Please Try Again.");
            }
        }
    }
}
