namespace Exam_Management_System.Designs
{
    partial class ContextualCard
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
            this.components = new System.ComponentModel.Container();
            this.Program_DropButtonPalette = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
            this.ContextPanel = new Krypton.Toolkit.KryptonPanel();
            this.context = new Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ContextPanel)).BeginInit();
            this.ContextPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Program_DropButtonPalette
            // 
            this.Program_DropButtonPalette.BaseFont = new System.Drawing.Font("Segoe UI", 9F);
            this.Program_DropButtonPalette.BaseFontSize = 9F;
            this.Program_DropButtonPalette.BasePaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlackDarkMode;
            this.Program_DropButtonPalette.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            this.Program_DropButtonPalette.ButtonStyles.ButtonCustom1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Program_DropButtonPalette.ButtonStyles.ButtonCustom1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Program_DropButtonPalette.ButtonStyles.ButtonCustom1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Program_DropButtonPalette.ButtonStyles.ButtonCustom1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Program_DropButtonPalette.ButtonStyles.ButtonCustom1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Program_DropButtonPalette.ButtonStyles.ButtonCustom1.StateCommon.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Program_DropButtonPalette.ButtonStyles.ButtonCustom1.StateCommon.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Program_DropButtonPalette.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Program_DropButtonPalette.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Program_DropButtonPalette.LabelStyles.LabelCustom1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Program_DropButtonPalette.LabelStyles.LabelCustom1.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Program_DropButtonPalette.LabelStyles.LabelCustom1.StateCommon.ShortText.Font = new System.Drawing.Font("Inter", 8.75F);
            this.Program_DropButtonPalette.PanelStyles.PanelClient.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.Program_DropButtonPalette.PanelStyles.PanelClient.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.Program_DropButtonPalette.PanelStyles.PanelCustom2.StateCommon.Color1 = System.Drawing.Color.White;
            this.Program_DropButtonPalette.PanelStyles.PanelCustom2.StateCommon.Color2 = System.Drawing.Color.White;
            this.Program_DropButtonPalette.ThemeName = "";
            this.Program_DropButtonPalette.UseKryptonFileDialogs = true;
            // 
            // ContextPanel
            // 
            this.ContextPanel.Controls.Add(this.context);
            this.ContextPanel.Controls.Add(this.kryptonPictureBox1);
            this.ContextPanel.Location = new System.Drawing.Point(0, 0);
            this.ContextPanel.Name = "ContextPanel";
            this.ContextPanel.Palette = this.Program_DropButtonPalette;
            this.ContextPanel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.ContextPanel.Size = new System.Drawing.Size(730, 260);
            this.ContextPanel.TabIndex = 0;
            // 
            // context
            // 
            this.context.CornerRoundingRadius = 10F;
            this.context.Location = new System.Drawing.Point(30, 23);
            this.context.Name = "context";
            this.context.Palette = this.Program_DropButtonPalette;
            this.context.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
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
            this.context.StateCommon.Content.Font = new System.Drawing.Font("Inter", 10.5F);
            this.context.StateCommon.Content.Padding = new System.Windows.Forms.Padding(25, 18, 25, 18);
            this.context.TabIndex = 5;
            this.context.Text = "Question";
            // 
            // kryptonPictureBox1
            // 
            this.kryptonPictureBox1.Image = global::Exam_Management_System.Properties.Resources.Rectangle_413;
            this.kryptonPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPictureBox1.Name = "kryptonPictureBox1";
            this.kryptonPictureBox1.Size = new System.Drawing.Size(730, 260);
            this.kryptonPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.kryptonPictureBox1.TabIndex = 6;
            this.kryptonPictureBox1.TabStop = false;
            // 
            // ContextualCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.ContextPanel);
            this.Name = "ContextualCard";
            this.Size = new System.Drawing.Size(730, 260);
            ((System.ComponentModel.ISupportInitialize)(this.ContextPanel)).EndInit();
            this.ContextPanel.ResumeLayout(false);
            this.ContextPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonCustomPaletteBase Program_DropButtonPalette;
        private Krypton.Toolkit.KryptonPanel ContextPanel;
        private Krypton.Toolkit.KryptonRichTextBox context;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
    }
}
