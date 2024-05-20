namespace Exam_Management_System.Designs
{
    partial class PreviewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.codePreviewForm_LBL = new Krypton.Toolkit.KryptonLabel();
            this.sh_FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.noOfQuestions_LBL = new Krypton.Toolkit.KryptonLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // codePreviewForm_LBL
            // 
            this.codePreviewForm_LBL.Location = new System.Drawing.Point(561, 37);
            this.codePreviewForm_LBL.Name = "codePreviewForm_LBL";
            this.codePreviewForm_LBL.Size = new System.Drawing.Size(109, 24);
            this.codePreviewForm_LBL.TabIndex = 0;
            this.codePreviewForm_LBL.Values.Text = "kryptonLabel1";
            // 
            // sh_FLP
            // 
            this.sh_FLP.AutoScroll = true;
            this.sh_FLP.Location = new System.Drawing.Point(38, 104);
            this.sh_FLP.Name = "sh_FLP";
            this.sh_FLP.Size = new System.Drawing.Size(632, 609);
            this.sh_FLP.TabIndex = 1;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(464, 37);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(91, 24);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Exam Code:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(38, 37);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(130, 24);
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Values.Text = "Question Preview";
            // 
            // noOfQuestions_LBL
            // 
            this.noOfQuestions_LBL.Location = new System.Drawing.Point(38, 63);
            this.noOfQuestions_LBL.Name = "noOfQuestions_LBL";
            this.noOfQuestions_LBL.Size = new System.Drawing.Size(109, 24);
            this.noOfQuestions_LBL.TabIndex = 4;
            this.noOfQuestions_LBL.Values.Text = "kryptonLabel3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 767);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noOfQuestions_LBL);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.sh_FLP);
            this.Controls.Add(this.codePreviewForm_LBL);
            this.Name = "PreviewForm";
            this.Text = "PreviewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel codePreviewForm_LBL;
        private System.Windows.Forms.FlowLayoutPanel sh_FLP;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel noOfQuestions_LBL;
        private System.Windows.Forms.Label label1;
    }
}