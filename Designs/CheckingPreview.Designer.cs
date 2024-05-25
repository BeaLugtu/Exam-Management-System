namespace Exam_Management_System.Designs
{
    partial class CheckingPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckingPreview));
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.questions_FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.examTitle_LBL = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            this.code_LBL = new Krypton.Toolkit.KryptonLabel();
            this.respondents_LV = new System.Windows.Forms.ListView();
            this.Students = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kryptonPictureBox4 = new Krypton.Toolkit.KryptonPictureBox();
            this.kryptonPictureBox3 = new Krypton.Toolkit.KryptonPictureBox();
            this.kryptonPictureBox2 = new Krypton.Toolkit.KryptonPictureBox();
            this.kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            this.timeTurnedin_LBL = new Krypton.Toolkit.KryptonWrapLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(52, 91);
            this.kryptonButton1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(14, 14);
            this.kryptonButton1.TabIndex = 3;
            this.kryptonButton1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonButton1.Values.Image")));
            this.kryptonButton1.Values.Text = "";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(700, 46);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(140, 19);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 6;
            this.kryptonLabel1.Values.Text = "11:44 pm - Tue, May 6";
            // 
            // questions_FLP
            // 
            this.questions_FLP.AutoScroll = true;
            this.questions_FLP.BackColor = System.Drawing.Color.Transparent;
            this.questions_FLP.Location = new System.Drawing.Point(264, 95);
            this.questions_FLP.Margin = new System.Windows.Forms.Padding(2);
            this.questions_FLP.Name = "questions_FLP";
            this.questions_FLP.Size = new System.Drawing.Size(576, 436);
            this.questions_FLP.TabIndex = 7;
            // 
            // examTitle_LBL
            // 
            this.examTitle_LBL.AutoSize = false;
            this.examTitle_LBL.Location = new System.Drawing.Point(52, 354);
            this.examTitle_LBL.Name = "examTitle_LBL";
            this.examTitle_LBL.Size = new System.Drawing.Size(195, 36);
            this.examTitle_LBL.TabIndex = 10;
            this.examTitle_LBL.Values.Text = "PR001 - Finals in Embedded\nProgramming";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(52, 475);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(116, 20);
            this.kryptonLabel4.TabIndex = 12;
            this.kryptonLabel4.Values.Text = "... points out of 100 ";
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(52, 506);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton2.TabIndex = 13;
            this.kryptonButton2.Values.Text = "Release Score";
            // 
            // code_LBL
            // 
            this.code_LBL.AutoSize = false;
            this.code_LBL.Location = new System.Drawing.Point(52, 392);
            this.code_LBL.Name = "code_LBL";
            this.code_LBL.Size = new System.Drawing.Size(90, 25);
            this.code_LBL.TabIndex = 14;
            this.code_LBL.Values.Text = "Code";
            // 
            // respondents_LV
            // 
            this.respondents_LV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.respondents_LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Students});
            this.respondents_LV.HideSelection = false;
            this.respondents_LV.Location = new System.Drawing.Point(52, 149);
            this.respondents_LV.Name = "respondents_LV";
            this.respondents_LV.Size = new System.Drawing.Size(180, 174);
            this.respondents_LV.TabIndex = 15;
            this.respondents_LV.TileSize = new System.Drawing.Size(195, 10);
            this.respondents_LV.UseCompatibleStateImageBehavior = false;
            this.respondents_LV.View = System.Windows.Forms.View.Details;
            // 
            // Students
            // 
            this.Students.Text = "Students";
            this.Students.Width = 180;
            // 
            // kryptonPictureBox4
            // 
            this.kryptonPictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPictureBox4.Image")));
            this.kryptonPictureBox4.Location = new System.Drawing.Point(52, 333);
            this.kryptonPictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPictureBox4.Name = "kryptonPictureBox4";
            this.kryptonPictureBox4.Size = new System.Drawing.Size(40, 14);
            this.kryptonPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kryptonPictureBox4.TabIndex = 9;
            this.kryptonPictureBox4.TabStop = false;
            // 
            // kryptonPictureBox3
            // 
            this.kryptonPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPictureBox3.Image")));
            this.kryptonPictureBox3.Location = new System.Drawing.Point(52, 131);
            this.kryptonPictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPictureBox3.Name = "kryptonPictureBox3";
            this.kryptonPictureBox3.Size = new System.Drawing.Size(72, 13);
            this.kryptonPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kryptonPictureBox3.TabIndex = 8;
            this.kryptonPictureBox3.TabStop = false;
            // 
            // kryptonPictureBox2
            // 
            this.kryptonPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPictureBox2.Image")));
            this.kryptonPictureBox2.Location = new System.Drawing.Point(74, 88);
            this.kryptonPictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPictureBox2.Name = "kryptonPictureBox2";
            this.kryptonPictureBox2.Size = new System.Drawing.Size(97, 21);
            this.kryptonPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kryptonPictureBox2.TabIndex = 5;
            this.kryptonPictureBox2.TabStop = false;
            // 
            // kryptonPictureBox1
            // 
            this.kryptonPictureBox1.Image = global::Exam_Management_System.Properties.Resources.profile_header;
            this.kryptonPictureBox1.Location = new System.Drawing.Point(42, 28);
            this.kryptonPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPictureBox1.Name = "kryptonPictureBox1";
            this.kryptonPictureBox1.Size = new System.Drawing.Size(83, 37);
            this.kryptonPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kryptonPictureBox1.TabIndex = 0;
            this.kryptonPictureBox1.TabStop = false;
            // 
            // timeTurnedin_LBL
            // 
            this.timeTurnedin_LBL.AutoSize = false;
            this.timeTurnedin_LBL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timeTurnedin_LBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.timeTurnedin_LBL.LabelStyle = Krypton.Toolkit.LabelStyle.AlternateControl;
            this.timeTurnedin_LBL.Location = new System.Drawing.Point(52, 420);
            this.timeTurnedin_LBL.Name = "timeTurnedin_LBL";
            this.timeTurnedin_LBL.Size = new System.Drawing.Size(180, 52);
            this.timeTurnedin_LBL.Text = "Time Turned In:";
            // 
            // CheckingPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(886, 571);
            this.Controls.Add(this.timeTurnedin_LBL);
            this.Controls.Add(this.respondents_LV);
            this.Controls.Add(this.code_LBL);
            this.Controls.Add(this.kryptonButton2);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.examTitle_LBL);
            this.Controls.Add(this.kryptonPictureBox4);
            this.Controls.Add(this.kryptonPictureBox3);
            this.Controls.Add(this.questions_FLP);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.kryptonPictureBox2);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.kryptonPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckingPreview";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.CheckingPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.FlowLayoutPanel questions_FLP;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox3;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox4;
        private Krypton.Toolkit.KryptonLabel examTitle_LBL;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonLabel code_LBL;
        private System.Windows.Forms.ListView respondents_LV;
        private System.Windows.Forms.ColumnHeader Students;
        private Krypton.Toolkit.KryptonWrapLabel timeTurnedin_LBL;
    }
}