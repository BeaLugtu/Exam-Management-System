using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


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

            // Apply border to simulate a drop shadow effect
            kryptonProgressBar1.StateCommon.Border.Color1 = Color.DarkGray;
            kryptonProgressBar1.StateCommon.Border.Rounding = 5;

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

        private void kryptonProgressBar1_Paint(object sender, PaintEventArgs e)
        {
            // Create a linear gradient brush for the background
            Rectangle rect = new Rectangle(0, 0, kryptonProgressBar1.Width, kryptonProgressBar1.Height);
            Color color1 = Color.LightGray; 
            Color color2 = Color.DarkGray;  

            LinearGradientBrush gradientBrush = new LinearGradientBrush(rect, color1, color2, LinearGradientMode.Vertical);

            e.Graphics.FillRectangle(gradientBrush, rect);
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
