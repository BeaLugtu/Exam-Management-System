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
            this.SuspendLayout();
            // 
            // codePreviewForm_LBL
            // 
            this.codePreviewForm_LBL.Location = new System.Drawing.Point(135, 37);
            this.codePreviewForm_LBL.Name = "codePreviewForm_LBL";
            this.codePreviewForm_LBL.Size = new System.Drawing.Size(109, 24);
            this.codePreviewForm_LBL.TabIndex = 0;
            this.codePreviewForm_LBL.Values.Text = "kryptonLabel1";
            // 
            // sh_FLP
            // 
            this.sh_FLP.AutoScroll = true;
            this.sh_FLP.Location = new System.Drawing.Point(38, 67);
            this.sh_FLP.Name = "sh_FLP";
            this.sh_FLP.Size = new System.Drawing.Size(632, 646);
            this.sh_FLP.TabIndex = 1;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(38, 37);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(91, 24);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Exam Code:";
            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 767);
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
    }
}