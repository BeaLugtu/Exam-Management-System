namespace Exam_Management_System.Designs.Answer_Cards
{
    partial class studentParagraph
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.QuestionPHP = new Krypton.Toolkit.KryptonRichTextBox();
            this.AnswerTB = new Krypton.Toolkit.KryptonRichTextBox();
            this.QuestionPH = new Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // QuestionPHP
            // 
            this.QuestionPHP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.QuestionPHP.CornerRoundingRadius = 10F;
            this.QuestionPHP.Location = new System.Drawing.Point(35, 53);
            this.QuestionPHP.Margin = new System.Windows.Forms.Padding(5);
            this.QuestionPHP.Name = "QuestionPHP";
            this.QuestionPHP.ReadOnly = true;
            this.QuestionPHP.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.QuestionPHP.Size = new System.Drawing.Size(660, 120);
            this.QuestionPHP.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.QuestionPHP.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.QuestionPHP.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.QuestionPHP.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.QuestionPHP.StateCommon.Border.Rounding = 10F;
            this.QuestionPHP.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.QuestionPHP.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.QuestionPHP.StateCommon.Content.Padding = new System.Windows.Forms.Padding(25, 18, 25, 18);
            this.QuestionPHP.TabIndex = 6;
            this.QuestionPHP.Text = "Question";
            // 
            // AnswerTB
            // 
            this.AnswerTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AnswerTB.CornerRoundingRadius = 10F;
            this.AnswerTB.Location = new System.Drawing.Point(35, 183);
            this.AnswerTB.Margin = new System.Windows.Forms.Padding(5);
            this.AnswerTB.MaxLength = 1000;
            this.AnswerTB.Name = "AnswerTB";
            this.AnswerTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.AnswerTB.Size = new System.Drawing.Size(660, 88);
            this.AnswerTB.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.AnswerTB.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.AnswerTB.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.AnswerTB.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AnswerTB.StateCommon.Border.Rounding = 10F;
            this.AnswerTB.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.AnswerTB.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.AnswerTB.StateCommon.Content.Padding = new System.Windows.Forms.Padding(25, 5, -1, -1);
            this.AnswerTB.TabIndex = 7;
            this.AnswerTB.Text = "Answer";
            // 
            // QuestionPH
            // 
            this.QuestionPH.LabelStyle = Krypton.Toolkit.LabelStyle.Custom1;
            this.QuestionPH.Location = new System.Drawing.Point(52, 23);
            this.QuestionPH.Name = "QuestionPH";
            this.QuestionPH.Size = new System.Drawing.Size(82, 20);
            this.QuestionPH.TabIndex = 10;
            this.QuestionPH.Values.Text = "Your Answer:";
            // 
            // studentParagraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Exam_Management_System.Properties.Resources.Rectangle_415;
            this.Controls.Add(this.QuestionPH);
            this.Controls.Add(this.AnswerTB);
            this.Controls.Add(this.QuestionPHP);
            this.Name = "studentParagraph";
            this.Size = new System.Drawing.Size(730, 300);
            this.Load += new System.EventHandler(this.studentParagraph_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonRichTextBox QuestionPHP;
        private Krypton.Toolkit.KryptonRichTextBox AnswerTB;
        private Krypton.Toolkit.KryptonLabel QuestionPH;
    }
}
