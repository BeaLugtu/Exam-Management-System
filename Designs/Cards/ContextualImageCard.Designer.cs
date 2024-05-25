namespace Exam_Management_System.Designs
{
    partial class ContextualImageCard
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
            this.ContextualImagePanel = new Krypton.Toolkit.KryptonPanel();
            this.imagecard = new Krypton.Toolkit.KryptonPictureBox();
            this.kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ContextualImagePanel)).BeginInit();
            this.ContextualImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagecard)).BeginInit();
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
            // ContextualImagePanel
            // 
            this.ContextualImagePanel.Controls.Add(this.imagecard);
            this.ContextualImagePanel.Controls.Add(this.kryptonPictureBox1);
            this.ContextualImagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContextualImagePanel.Location = new System.Drawing.Point(0, 0);
            this.ContextualImagePanel.Name = "ContextualImagePanel";
            this.ContextualImagePanel.Palette = this.Program_DropButtonPalette;
            this.ContextualImagePanel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.ContextualImagePanel.Size = new System.Drawing.Size(730, 260);
            this.ContextualImagePanel.TabIndex = 0;
            // 
            // imagecard
            // 
            this.imagecard.Image = global::Exam_Management_System.Properties.Resources.profile_icon;
            this.imagecard.Location = new System.Drawing.Point(43, 22);
            this.imagecard.Name = "imagecard";
            this.imagecard.Size = new System.Drawing.Size(645, 216);
            this.imagecard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagecard.TabIndex = 6;
            this.imagecard.TabStop = false;
            // 
            // kryptonPictureBox1
            // 
            this.kryptonPictureBox1.Image = global::Exam_Management_System.Properties.Resources.Rectangle_413;
            this.kryptonPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPictureBox1.Name = "kryptonPictureBox1";
            this.kryptonPictureBox1.Size = new System.Drawing.Size(730, 260);
            this.kryptonPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.kryptonPictureBox1.TabIndex = 7;
            this.kryptonPictureBox1.TabStop = false;
            // 
            // ContextualImageCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.ContextualImagePanel);
            this.Name = "ContextualImageCard";
            this.Size = new System.Drawing.Size(730, 260);
            ((System.ComponentModel.ISupportInitialize)(this.ContextualImagePanel)).EndInit();
            this.ContextualImagePanel.ResumeLayout(false);
            this.ContextualImagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagecard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonCustomPaletteBase Program_DropButtonPalette;
        private Krypton.Toolkit.KryptonPanel ContextualImagePanel;
        private Krypton.Toolkit.KryptonPictureBox imagecard;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
    }
}
