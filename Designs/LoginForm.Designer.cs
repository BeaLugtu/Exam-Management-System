﻿namespace Exam_Management_System
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.EmailTB = new Krypton.Toolkit.KryptonTextBox();
            this.PasswordTB = new Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timeDateLbl = new System.Windows.Forms.Label();
            this.kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            this.LoginBtn = new Krypton.Toolkit.KryptonButton();
            this.forgotPassBtn = new Krypton.Toolkit.KryptonLabel();
            this.SignupBtn = new Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.invisiblePassBtn = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmailTB
            // 
            this.EmailTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTB.Location = new System.Drawing.Point(117, 269);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(286, 39);
            this.EmailTB.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.EmailTB.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.EmailTB.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.EmailTB.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.EmailTB.StateCommon.Border.Rounding = 10F;
            this.EmailTB.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTB.StateCommon.Content.Padding = new System.Windows.Forms.Padding(7);
            this.EmailTB.TabIndex = 14;
            this.EmailTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailTB_KeyPress);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTB.Location = new System.Drawing.Point(117, 352);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(286, 39);
            this.PasswordTB.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.PasswordTB.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.PasswordTB.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.PasswordTB.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PasswordTB.StateCommon.Border.Rounding = 10F;
            this.PasswordTB.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB.StateCommon.Content.Padding = new System.Windows.Forms.Padding(7, 7, 34, 7);
            this.PasswordTB.TabIndex = 15;
            this.PasswordTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTB_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(774, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = " ";
            // 
            // timeDateLbl
            // 
            this.timeDateLbl.AutoSize = true;
            this.timeDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.timeDateLbl.Location = new System.Drawing.Point(774, 50);
            this.timeDateLbl.Name = "timeDateLbl";
            this.timeDateLbl.Size = new System.Drawing.Size(155, 18);
            this.timeDateLbl.TabIndex = 19;
            this.timeDateLbl.Text = "11:44 pm - Tue, May 6";
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(261, 14);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(50, 1);
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.Location = new System.Drawing.Point(117, 437);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(286, 39);
            this.LoginBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.LoginBtn.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("LoginBtn.StateCommon.Back.Image")));
            this.LoginBtn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.LoginBtn.StateCommon.Border.Rounding = 10F;
            this.LoginBtn.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.LoginBtn.StateCommon.Content.Padding = new System.Windows.Forms.Padding(7);
            this.LoginBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.LoginBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.LoginBtn.StateTracking.Back.Image = ((System.Drawing.Image)(resources.GetObject("LoginBtn.StateTracking.Back.Image")));
            this.LoginBtn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.LoginBtn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.LoginBtn.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.LoginBtn.TabIndex = 16;
            this.LoginBtn.Values.Text = "";
            this.LoginBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LoginBtn_MouseClick);
            // 
            // forgotPassBtn
            // 
            this.forgotPassBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotPassBtn.Location = new System.Drawing.Point(117, 403);
            this.forgotPassBtn.Name = "forgotPassBtn";
            this.forgotPassBtn.Size = new System.Drawing.Size(102, 16);
            this.forgotPassBtn.StateCommon.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.forgotPassBtn.StateCommon.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.forgotPassBtn.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.forgotPassBtn.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.forgotPassBtn.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.forgotPassBtn.TabIndex = 22;
            this.forgotPassBtn.ToolTipValues.Description = "Forgotttt???????";
            this.forgotPassBtn.UseMnemonic = false;
            this.forgotPassBtn.Values.Text = "Forgot Password?";
            this.forgotPassBtn.MouseLeave += new System.EventHandler(this.forgotPassBtn_MouseLeave);
            this.forgotPassBtn.MouseHover += new System.EventHandler(this.forgotPassBtn_MouseHover);
            // 
            // SignupBtn
            // 
            this.SignupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignupBtn.Location = new System.Drawing.Point(300, 483);
            this.SignupBtn.Name = "SignupBtn";
            this.SignupBtn.Size = new System.Drawing.Size(54, 18);
            this.SignupBtn.StateCommon.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignupBtn.StateCommon.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignupBtn.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignupBtn.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignupBtn.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupBtn.TabIndex = 24;
            this.SignupBtn.Values.Text = "Sign up";
            this.SignupBtn.Click += new System.EventHandler(this.SignupBtn_Click);
            this.SignupBtn.MouseLeave += new System.EventHandler(this.SignupBtn_MouseLeave);
            this.SignupBtn.MouseHover += new System.EventHandler(this.SignupBtn_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1002, 601);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // invisiblePassBtn
            // 
            this.invisiblePassBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.invisiblePassBtn.Location = new System.Drawing.Point(377, 365);
            this.invisiblePassBtn.Name = "invisiblePassBtn";
            this.invisiblePassBtn.Size = new System.Drawing.Size(16, 16);
            this.invisiblePassBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.invisiblePassBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.invisiblePassBtn.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("invisiblePassBtn.StateCommon.Back.Image")));
            this.invisiblePassBtn.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.invisiblePassBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.invisiblePassBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.invisiblePassBtn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.invisiblePassBtn.StatePressed.Back.Image = ((System.Drawing.Image)(resources.GetObject("invisiblePassBtn.StatePressed.Back.Image")));
            this.invisiblePassBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.invisiblePassBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.invisiblePassBtn.StateTracking.Back.Image = ((System.Drawing.Image)(resources.GetObject("invisiblePassBtn.StateTracking.Back.Image")));
            this.invisiblePassBtn.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.invisiblePassBtn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.invisiblePassBtn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.invisiblePassBtn.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.invisiblePassBtn.TabIndex = 21;
            this.invisiblePassBtn.Values.Text = "";
            this.invisiblePassBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.invisiblePassBtn_MouseClick);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.SignupBtn);
            this.Controls.Add(this.forgotPassBtn);
            this.Controls.Add(this.invisiblePassBtn);
            this.Controls.Add(this.kryptonBorderEdge1);
            this.Controls.Add(this.timeDateLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonTextBox EmailTB;
        private Krypton.Toolkit.KryptonTextBox PasswordTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeDateLbl;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Krypton.Toolkit.KryptonButton LoginBtn;
        private Krypton.Toolkit.KryptonLabel forgotPassBtn;
        private Krypton.Toolkit.KryptonLabel SignupBtn;
        private Krypton.Toolkit.KryptonButton invisiblePassBtn;
    }
}

