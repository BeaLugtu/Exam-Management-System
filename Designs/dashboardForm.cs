using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherDashboard
{
    public partial class teacherDashboardForm : Form
    {
        public teacherDashboardForm()
        {
            InitializeComponent();
            DisplayCurrentDateTime();
        }

        private void DisplayCurrentDateTime()
        {
            // Get current date and time
            DateTime now = DateTime.Now;

            // Format the date and time
            string formattedDateTime = now.ToString("h:mm tt — ddd, MMM d");

            // Set the formatted date and time to your label
            timeDateLbl.Text = formattedDateTime;
        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {
            // Get current date and time
            DateTime now = DateTime.Now;

            // Format the date and time
            string formattedDateTime = now.ToString("h:mm tt — ddd, MMM d");

            // Set the formatted date and time to your label
            timeDateLbl.Text = formattedDateTime;
        }

        private void btnAddForm_Click(object sender, EventArgs e)
        {
            newBlankForm newBlankForm = new newBlankForm();

            // Hide the teacherDashboardForm
            this.Hide();

            // Show the newBlankForm
            newBlankForm.Show();

            // Subscribe to the newBlankForm's FormClosed event
            newBlankForm.FormClosed += (s, args) =>
            {
                // Close the application when newBlankForm is closed
                Application.Exit();
            };
        }
    }
}

