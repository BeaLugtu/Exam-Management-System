namespace Exam_Management_System.Designs.Answer_Cards
{
    partial class studentMultipleChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentMultipleChoice));
            this.QuestionPHP = new Krypton.Toolkit.KryptonRichTextBox();
            this.Item4 = new Krypton.Toolkit.KryptonTextBox();
            this.D = new Krypton.Toolkit.KryptonRadioButton();
            this.Item2 = new Krypton.Toolkit.KryptonTextBox();
            this.Item3 = new Krypton.Toolkit.KryptonTextBox();
            this.Item1 = new Krypton.Toolkit.KryptonTextBox();
            this.C = new Krypton.Toolkit.KryptonRadioButton();
            this.A = new Krypton.Toolkit.KryptonRadioButton();
            this.PointPH = new Krypton.Toolkit.KryptonLabel();
            this.Program_DropButtonPalette = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
            this.QuestionPH = new Krypton.Toolkit.KryptonLabel();
            this.B = new Krypton.Toolkit.KryptonRadioButton();
            this.SuspendLayout();
            // 
            // QuestionPHP
            // 
            this.QuestionPHP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.QuestionPHP.CornerRoundingRadius = 10F;
            this.QuestionPHP.Location = new System.Drawing.Point(37, 55);
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
            this.QuestionPHP.TextChanged += new System.EventHandler(this.Questionmultiple_TextChanged);
            // 
            // Item4
            // 
            this.Item4.Enabled = false;
            this.Item4.Location = new System.Drawing.Point(430, 241);
            this.Item4.Name = "Item4";
            this.Item4.ReadOnly = true;
            this.Item4.Size = new System.Drawing.Size(248, 22);
            this.Item4.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Item4.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.Item4.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.Item4.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Item4.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Item4.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.Item4.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.Item4.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Item4.TabIndex = 67;
            this.Item4.Text = "kryptonTextBox1";
            // 
            // D
            // 
            this.D.Images.CheckedNormal = global::Exam_Management_System.Properties.Resources.Radio_Button_Selected__1_;
            this.D.Images.CheckedPressed = global::Exam_Management_System.Properties.Resources.Radio_Button_Selected__1_;
            this.D.Images.CheckedTracking = global::Exam_Management_System.Properties.Resources.Radio_Button_Selected__1_;
            this.D.Images.Common = global::Exam_Management_System.Properties.Resources.Radio_Button_UnSelected__1_;
            this.D.LabelStyle = Krypton.Toolkit.LabelStyle.Custom1;
            this.D.Location = new System.Drawing.Point(393, 233);
            this.D.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(302, 38);
            this.D.TabIndex = 66;
            this.D.Values.Image = ((System.Drawing.Image)(resources.GetObject("D.Values.Image")));
            this.D.Values.Text = "";
            this.D.CheckedChanged += new System.EventHandler(this.D_CheckedChanged);
            // 
            // Item2
            // 
            this.Item2.Enabled = false;
            this.Item2.Location = new System.Drawing.Point(430, 194);
            this.Item2.Name = "Item2";
            this.Item2.ReadOnly = true;
            this.Item2.Size = new System.Drawing.Size(248, 20);
            this.Item2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Item2.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.Item2.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.Item2.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Item2.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Item2.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Item2.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.Item2.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Item2.TabIndex = 65;
            this.Item2.Text = "kryptonTextBox1";
            // 
            // Item3
            // 
            this.Item3.Enabled = false;
            this.Item3.Location = new System.Drawing.Point(72, 241);
            this.Item3.Name = "Item3";
            this.Item3.ReadOnly = true;
            this.Item3.Size = new System.Drawing.Size(249, 20);
            this.Item3.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Item3.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.Item3.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.Item3.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Item3.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Item3.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Item3.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.Item3.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Item3.TabIndex = 63;
            this.Item3.Text = "kryptonTextBox1";
            // 
            // Item1
            // 
            this.Item1.Enabled = false;
            this.Item1.Location = new System.Drawing.Point(72, 194);
            this.Item1.Name = "Item1";
            this.Item1.ReadOnly = true;
            this.Item1.Size = new System.Drawing.Size(249, 20);
            this.Item1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Item1.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.Item1.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.Item1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Item1.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Item1.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item1.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.Item1.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Item1.TabIndex = 62;
            this.Item1.Text = "kryptonTextBox1";
            // 
            // C
            // 
            this.C.Images.CheckedNormal = global::Exam_Management_System.Properties.Resources.Radio_Button_Selected__1_;
            this.C.Images.CheckedPressed = global::Exam_Management_System.Properties.Resources.Radio_Button_Selected__1_;
            this.C.Images.CheckedTracking = global::Exam_Management_System.Properties.Resources.Radio_Button_Selected__1_;
            this.C.Images.Common = global::Exam_Management_System.Properties.Resources.Radio_Button_UnSelected__1_;
            this.C.LabelStyle = Krypton.Toolkit.LabelStyle.Custom1;
            this.C.Location = new System.Drawing.Point(35, 233);
            this.C.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(302, 38);
            this.C.TabIndex = 61;
            this.C.Values.Image = ((System.Drawing.Image)(resources.GetObject("C.Values.Image")));
            this.C.Values.Text = "";
            this.C.CheckedChanged += new System.EventHandler(this.C_CheckedChanged);
            // 
            // A
            // 
            this.A.Images.CheckedNormal = global::Exam_Management_System.Properties.Resources.Radio_Button_Selected__1_;
            this.A.Images.CheckedPressed = global::Exam_Management_System.Properties.Resources.Radio_Button_Selected__1_;
            this.A.Images.CheckedTracking = global::Exam_Management_System.Properties.Resources.Radio_Button_Selected__1_;
            this.A.Images.Common = global::Exam_Management_System.Properties.Resources.Radio_Button_UnSelected__1_;
            this.A.LabelStyle = Krypton.Toolkit.LabelStyle.Custom1;
            this.A.Location = new System.Drawing.Point(35, 185);
            this.A.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(302, 38);
            this.A.TabIndex = 60;
            this.A.Values.Image = ((System.Drawing.Image)(resources.GetObject("A.Values.Image")));
            this.A.Values.Text = "";
            // 
            // PointPH
            // 
            this.PointPH.LabelStyle = Krypton.Toolkit.LabelStyle.Custom1;
            this.PointPH.Location = new System.Drawing.Point(657, 26);
            this.PointPH.Name = "PointPH";
            this.PointPH.Palette = this.Program_DropButtonPalette;
            this.PointPH.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.PointPH.Size = new System.Drawing.Size(44, 20);
            this.PointPH.TabIndex = 70;
            this.PointPH.Values.Text = "Point";
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
            this.Program_DropButtonPalette.LabelStyles.LabelCustom1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Program_DropButtonPalette.LabelStyles.LabelCustom1.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Program_DropButtonPalette.LabelStyles.LabelCustom1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.Program_DropButtonPalette.PanelStyles.PanelClient.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.Program_DropButtonPalette.PanelStyles.PanelClient.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.Program_DropButtonPalette.PanelStyles.PanelCustom2.StateCommon.Color1 = System.Drawing.Color.White;
            this.Program_DropButtonPalette.PanelStyles.PanelCustom2.StateCommon.Color2 = System.Drawing.Color.White;
            this.Program_DropButtonPalette.ThemeName = "";
            this.Program_DropButtonPalette.UseKryptonFileDialogs = true;
            // 
            // QuestionPH
            // 
            this.QuestionPH.LabelStyle = Krypton.Toolkit.LabelStyle.Custom1;
            this.QuestionPH.Location = new System.Drawing.Point(26, 26);
            this.QuestionPH.Name = "QuestionPH";
            this.QuestionPH.Palette = this.Program_DropButtonPalette;
            this.QuestionPH.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.QuestionPH.Size = new System.Drawing.Size(69, 20);
            this.QuestionPH.TabIndex = 69;
            this.QuestionPH.Values.Text = "Question";
            // 
            // B
            // 
            this.B.Images.CheckedNormal = global::Exam_Management_System.Properties.Resources.Radio_Button_Selected__1_;
            this.B.Images.CheckedPressed = global::Exam_Management_System.Properties.Resources.Radio_Button_Selected__1_;
            this.B.Images.CheckedTracking = global::Exam_Management_System.Properties.Resources.Radio_Button_Selected__1_;
            this.B.Images.Common = global::Exam_Management_System.Properties.Resources.Radio_Button_UnSelected__1_;
            this.B.LabelStyle = Krypton.Toolkit.LabelStyle.Custom1;
            this.B.Location = new System.Drawing.Point(393, 185);
            this.B.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(302, 38);
            this.B.TabIndex = 71;
            this.B.Values.Image = ((System.Drawing.Image)(resources.GetObject("B.Values.Image")));
            this.B.Values.Text = "";
            // 
            // studentMultipleChoice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Exam_Management_System.Properties.Resources.Rectangle_415;
            this.Controls.Add(this.PointPH);
            this.Controls.Add(this.QuestionPH);
            this.Controls.Add(this.QuestionPHP);
            this.Controls.Add(this.Item4);
            this.Controls.Add(this.D);
            this.Controls.Add(this.Item2);
            this.Controls.Add(this.Item3);
            this.Controls.Add(this.Item1);
            this.Controls.Add(this.C);
            this.Controls.Add(this.A);
            this.Controls.Add(this.B);
            this.Name = "studentMultipleChoice";
            this.Size = new System.Drawing.Size(730, 300);
            this.Load += new System.EventHandler(this.studentMultipleChoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonTextBox Item4;
        private Krypton.Toolkit.KryptonTextBox Item2;
        private Krypton.Toolkit.KryptonTextBox Item3;
        private Krypton.Toolkit.KryptonTextBox Item1;
        public Krypton.Toolkit.KryptonRichTextBox QuestionPHP;
        public Krypton.Toolkit.KryptonRadioButton D;
        public Krypton.Toolkit.KryptonRadioButton C;
        public Krypton.Toolkit.KryptonRadioButton A;
        private Krypton.Toolkit.KryptonLabel PointPH;
        private Krypton.Toolkit.KryptonLabel QuestionPH;
        public Krypton.Toolkit.KryptonRadioButton B;
        private Krypton.Toolkit.KryptonCustomPaletteBase Program_DropButtonPalette;
    }
}
