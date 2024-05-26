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
    public partial class examSubmitSuccess : Form
    { private string UserID;
        private StudentDashboard sdboard;
        public examSubmitSuccess(string userID)
        {
            this.UserID = userID.ToString();

            InitializeComponent();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            sdboard = new StudentDashboard(UserID); // Instantiate StudentDashboard
            sdboard.Show();
            this.Hide();
        }
    }
}
