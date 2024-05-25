namespace Exam_Management_System.Designs
{
    partial class ViewForm
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
            this.BackBtn = new Krypton.Toolkit.KryptonButton();
            this.flowLayoutRecentFormList = new System.Windows.Forms.FlowLayoutPanel();
            this.kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            this.notificationBtn = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton5 = new Krypton.Toolkit.KryptonButton();
            this.timeDateLbl = new System.Windows.Forms.Label();
            this.ExamDetailsLBL = new System.Windows.Forms.Label();
            this.titlePH = new System.Windows.Forms.RichTextBox();
            this.ProfessorPH = new System.Windows.Forms.RichTextBox();
            this.UniqueCodeLBL = new Krypton.Toolkit.KryptonLabel();
            this.TimeRemainingLBL = new Krypton.Toolkit.KryptonLabel();
            this.timePH = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(45, 403);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(118, 26);
            this.BackBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.BackBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.BackBtn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BackBtn.StateCommon.Border.Rounding = 8F;
            this.BackBtn.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.BackBtn.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.BackBtn.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.StateTracking.Back.Color1 = System.Drawing.Color.Gray;
            this.BackBtn.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.BackBtn.TabIndex = 65;
            this.BackBtn.Values.Text = "Back";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // flowLayoutRecentFormList
            // 
            this.flowLayoutRecentFormList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.flowLayoutRecentFormList.Location = new System.Drawing.Point(211, 136);
            this.flowLayoutRecentFormList.Name = "flowLayoutRecentFormList";
            this.flowLayoutRecentFormList.Size = new System.Drawing.Size(910, 438);
            this.flowLayoutRecentFormList.TabIndex = 64;
            // 
            // kryptonPictureBox1
            // 
            this.kryptonPictureBox1.Image = global::Exam_Management_System.Properties.Resources.profile_header;
            this.kryptonPictureBox1.Location = new System.Drawing.Point(45, 54);
            this.kryptonPictureBox1.Name = "kryptonPictureBox1";
            this.kryptonPictureBox1.Size = new System.Drawing.Size(127, 50);
            this.kryptonPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kryptonPictureBox1.TabIndex = 63;
            this.kryptonPictureBox1.TabStop = false;
            // 
            // notificationBtn
            // 
            this.notificationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notificationBtn.Location = new System.Drawing.Point(826, 54);
            this.notificationBtn.Name = "notificationBtn";
            this.notificationBtn.Size = new System.Drawing.Size(51, 50);
            this.notificationBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.notificationBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.notificationBtn.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.notificationBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.notificationBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.notificationBtn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.notificationBtn.StateCommon.Border.Rounding = 10F;
            this.notificationBtn.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.notificationBtn.StateCommon.Content.Padding = new System.Windows.Forms.Padding(7);
            this.notificationBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationBtn.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.notificationBtn.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.notificationBtn.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.False;
            this.notificationBtn.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.notificationBtn.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.notificationBtn.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.notificationBtn.TabIndex = 68;
            this.notificationBtn.Values.Image = global::Exam_Management_System.Properties.Resources.notification_icon;
            this.notificationBtn.Values.Text = "";
            this.notificationBtn.MouseEnter += new System.EventHandler(this.NotificationBtn_MouseEnter);
            this.notificationBtn.MouseLeave += new System.EventHandler(this.NotificationBtn_MouseLeave);
            // 
            // kryptonButton5
            // 
            this.kryptonButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton5.Location = new System.Drawing.Point(883, 59);
            this.kryptonButton5.Name = "kryptonButton5";
            this.kryptonButton5.Size = new System.Drawing.Size(39, 39);
            this.kryptonButton5.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.kryptonButton5.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.kryptonButton5.StateCommon.Back.Image = global::Exam_Management_System.Properties.Resources.profile_pic;
            this.kryptonButton5.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonButton5.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.kryptonButton5.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.kryptonButton5.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton5.StateCommon.Border.Rounding = 100F;
            this.kryptonButton5.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton5.StateCommon.Content.Padding = new System.Windows.Forms.Padding(7);
            this.kryptonButton5.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton5.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.kryptonButton5.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.kryptonButton5.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton5.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.kryptonButton5.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.kryptonButton5.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.kryptonButton5.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.kryptonButton5.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton5.TabIndex = 67;
            this.kryptonButton5.Values.Image = global::Exam_Management_System.Properties.Resources.profile_pic;
            this.kryptonButton5.Values.Text = "";
            this.kryptonButton5.MouseEnter += new System.EventHandler(this.KryptonButton5_MouseEnter);
            this.kryptonButton5.MouseLeave += new System.EventHandler(this.KryptonButton5_MouseLeave);
            // 
            // timeDateLbl
            // 
            this.timeDateLbl.AutoSize = true;
            this.timeDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.timeDateLbl.Location = new System.Drawing.Point(935, 69);
            this.timeDateLbl.Name = "timeDateLbl";
            this.timeDateLbl.Size = new System.Drawing.Size(165, 20);
            this.timeDateLbl.TabIndex = 66;
            this.timeDateLbl.Text = "11:44 pm - Tue, May 6";
            // 
            // ExamDetailsLBL
            // 
            this.ExamDetailsLBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ExamDetailsLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F);
            this.ExamDetailsLBL.ForeColor = System.Drawing.Color.Black;
            this.ExamDetailsLBL.Location = new System.Drawing.Point(40, 152);
            this.ExamDetailsLBL.Name = "ExamDetailsLBL";
            this.ExamDetailsLBL.Size = new System.Drawing.Size(139, 30);
            this.ExamDetailsLBL.TabIndex = 69;
            this.ExamDetailsLBL.Text = "Exam Details";
            // 
            // titlePH
            // 
            this.titlePH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.titlePH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titlePH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.titlePH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titlePH.Location = new System.Drawing.Point(45, 194);
            this.titlePH.Name = "titlePH";
            this.titlePH.Size = new System.Drawing.Size(148, 36);
            this.titlePH.TabIndex = 70;
            this.titlePH.Text = "PR001";
            // 
            // ProfessorPH
            // 
            this.ProfessorPH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ProfessorPH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProfessorPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.ProfessorPH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProfessorPH.Location = new System.Drawing.Point(45, 236);
            this.ProfessorPH.Name = "ProfessorPH";
            this.ProfessorPH.Size = new System.Drawing.Size(160, 36);
            this.ProfessorPH.TabIndex = 71;
            this.ProfessorPH.Text = "Prof";
            // 
            // UniqueCodeLBL
            // 
            this.UniqueCodeLBL.LabelStyle = Krypton.Toolkit.LabelStyle.Custom1;
            this.UniqueCodeLBL.Location = new System.Drawing.Point(41, 276);
            this.UniqueCodeLBL.Name = "UniqueCodeLBL";
            this.UniqueCodeLBL.Size = new System.Drawing.Size(42, 20);
            this.UniqueCodeLBL.TabIndex = 72;
            this.UniqueCodeLBL.Values.Text = "Code: ";
            // 
            // TimeRemainingLBL
            // 
            this.TimeRemainingLBL.LabelStyle = Krypton.Toolkit.LabelStyle.Custom1;
            this.TimeRemainingLBL.Location = new System.Drawing.Point(41, 324);
            this.TimeRemainingLBL.Name = "TimeRemainingLBL";
            this.TimeRemainingLBL.Size = new System.Drawing.Size(101, 20);
            this.TimeRemainingLBL.TabIndex = 73;
            this.TimeRemainingLBL.Values.Text = "Time Remaining:";
            // 
            // timePH
            // 
            this.timePH.LabelStyle = Krypton.Toolkit.LabelStyle.Custom1;
            this.timePH.Location = new System.Drawing.Point(42, 350);
            this.timePH.Name = "timePH";
            this.timePH.Size = new System.Drawing.Size(90, 27);
            this.timePH.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.timePH.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.timePH.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F);
            this.timePH.TabIndex = 74;
            this.timePH.Values.Text = "00:00:00";
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.timePH);
            this.Controls.Add(this.TimeRemainingLBL);
            this.Controls.Add(this.UniqueCodeLBL);
            this.Controls.Add(this.ProfessorPH);
            this.Controls.Add(this.titlePH);
            this.Controls.Add(this.ExamDetailsLBL);
            this.Controls.Add(this.notificationBtn);
            this.Controls.Add(this.kryptonButton5);
            this.Controls.Add(this.timeDateLbl);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.flowLayoutRecentFormList);
            this.Controls.Add(this.kryptonPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewForm";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton BackBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutRecentFormList;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonButton notificationBtn;
        private Krypton.Toolkit.KryptonButton kryptonButton5;
        private System.Windows.Forms.Label timeDateLbl;
        private System.Windows.Forms.Label ExamDetailsLBL;
        private System.Windows.Forms.RichTextBox titlePH;
        private System.Windows.Forms.RichTextBox ProfessorPH;
        private Krypton.Toolkit.KryptonLabel UniqueCodeLBL;
        private Krypton.Toolkit.KryptonLabel TimeRemainingLBL;
        private Krypton.Toolkit.KryptonLabel timePH;
    }
}