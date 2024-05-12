using System;
using System.Windows.Forms;


namespace Exam_Management_System.Designs
{
    public partial class LoadingScreen : Form
    {
        private Timer timer;
        private int progressBarMaxValue = 100;
        private int progressBarCurrentValue = 0;
        private int progressBarIncrement = 1; 

        public LoadingScreen()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 40;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progressBarCurrentValue += progressBarIncrement;
            if (progressBarCurrentValue >= progressBarMaxValue)
            {
                progressBarCurrentValue = progressBarMaxValue;
                timer.Stop(); 
                CloseLoadingScreen(); 
            }
            kryptonProgressBar1.Value = progressBarCurrentValue;
        }

        private void CloseLoadingScreen()
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
