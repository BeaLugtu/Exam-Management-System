namespace Exam_Management_System.Designs.AnswerKey_Cards
{
    partial class contextual
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
            this.context = new Krypton.Toolkit.KryptonRichTextBox();
            this.AnswerTB = new Krypton.Toolkit.KryptonRichTextBox();
            this.SuspendLayout();
            // 
            // context
            // 
            this.context.CornerRoundingRadius = 10F;
            this.context.Location = new System.Drawing.Point(30, 23);
            this.context.Name = "context";
            this.context.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.context.Size = new System.Drawing.Size(670, 215);
            this.context.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.context.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.context.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.context.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.context.StateCommon.Border.Rounding = 10F;
            this.context.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.context.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.context.StateCommon.Content.Padding = new System.Windows.Forms.Padding(25, 18, 25, 18);
            this.context.TabIndex = 6;
            this.context.Text = "Question";
            // 
            // AnswerTB
            // 
            this.AnswerTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AnswerTB.CornerRoundingRadius = 10F;
            this.AnswerTB.Location = new System.Drawing.Point(30, 282);
            this.AnswerTB.Margin = new System.Windows.Forms.Padding(5);
            this.AnswerTB.MaxLength = 1000;
            this.AnswerTB.Name = "AnswerTB";
            this.AnswerTB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AnswerTB.Size = new System.Drawing.Size(670, 216);
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
            // contextual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Exam_Management_System.Properties.Resources.Rectangle_413;
            this.Controls.Add(this.AnswerTB);
            this.Controls.Add(this.context);
            this.Name = "contextual";
            this.Size = new System.Drawing.Size(730, 520);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonRichTextBox context;
        private Krypton.Toolkit.KryptonRichTextBox AnswerTB;
    }
}
