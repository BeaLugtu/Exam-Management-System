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
    public partial class archiveCard : UserControl
    {
        private Action<string> deleteExamCardAction;
        private Action<string> restoreExamCardAction; // Define action for restoring exam

        public archiveCard(Action<string> deleteExamCardAction, Action<string> restoreExamCardAction)
        {
            InitializeComponent();
            this.deleteExamCardAction = deleteExamCardAction;
            this.restoreExamCardAction = restoreExamCardAction; // Assign action for restoring exam
        }

        public void SetTitle(string title)
        {
            titleExamLbl.Text = title;
        }

        public void SetCode(string code)
        {
            codeExamLbl.Text = code;
        }

        private void deleteExamBtn_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to delete this exam?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If user confirms deletion
            if (result == DialogResult.Yes)
            {
                // Remove the card from the flowLayoutPanel
                this.Parent.Controls.Remove(this);

                // Delete the corresponding record from the database
                string examCode = codeExamLbl.Text;
                deleteExamCardAction?.Invoke(examCode);
            }
        }

        private void restoreExamBtn_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to restore this exam?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If user confirms restoration
            if (result == DialogResult.Yes)
            {
                // Restore the exam
                string examCode = codeExamLbl.Text;
                restoreExamCardAction?.Invoke(examCode);
            }
        }

    }
}

