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
    {
        private string userID;
        private string totalPoints;
        private string overtotal;
        private StudentDashboard sdboard;

        public examSubmitSuccess(string userID, string totalPoints, string OverTotal)
        {
            this.userID = userID;
            this.totalPoints = totalPoints;
            //this.overtotal = OverTotal;

            InitializeComponent();

            // Set the points to the label
            pointlbl.Text = "Your Initial Score: " + totalPoints + "/";//+ overtotal;
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            sdboard = new StudentDashboard(userID); // Instantiate StudentDashboard
            sdboard.Show();
            this.Hide();
        }
    private void kryptonLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
