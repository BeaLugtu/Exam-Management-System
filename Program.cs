using Exam_Management_System.Designs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Management_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //LoadingScreen loadingScreen = new LoadingScreen();
            //Application.Run(loadingScreen);
            //TeacherDashBoard teacherDashBoard = new TeacherDashBoard();
            //Application.Run(teacherDashBoard);

            RecentForm recentForm = new RecentForm();
            Application.Run(recentForm);
        }
    }
}
