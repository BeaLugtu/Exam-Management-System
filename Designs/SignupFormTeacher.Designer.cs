namespace Exam_Management_System.Designs
{
    partial class SignupFormTeacher
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupFormTeacher));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.confirmPassTB = new Krypton.Toolkit.KryptonTextBox();
            this.passwordTB = new Krypton.Toolkit.KryptonTextBox();
            this.lnameTB = new Krypton.Toolkit.KryptonTextBox();
            this.fnameTB = new Krypton.Toolkit.KryptonTextBox();
            this.teacherIDTB = new Krypton.Toolkit.KryptonTextBox();
            this.cancelBtn = new Krypton.Toolkit.KryptonButton();
            this.confirmBtn = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 605);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // confirmPassTB
            // 
            this.confirmPassTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmPassTB.Location = new System.Drawing.Point(258, 439);
            this.confirmPassTB.Name = "confirmPassTB";
            this.confirmPassTB.Size = new System.Drawing.Size(128, 36);
            this.confirmPassTB.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.confirmPassTB.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.confirmPassTB.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.confirmPassTB.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.confirmPassTB.StateCommon.Border.Rounding = 10F;
            this.confirmPassTB.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.confirmPassTB.StateCommon.Content.Padding = new System.Windows.Forms.Padding(7);
            this.confirmPassTB.TabIndex = 38;
            this.confirmPassTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.confirmPassTB_KeyPress);
            // 
            // passwordTB
            // 
            this.passwordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTB.Location = new System.Drawing.Point(120, 439);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(128, 36);
            this.passwordTB.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.passwordTB.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.passwordTB.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.passwordTB.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.passwordTB.StateCommon.Border.Rounding = 10F;
            this.passwordTB.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.passwordTB.StateCommon.Content.Padding = new System.Windows.Forms.Padding(7);
            this.passwordTB.TabIndex = 37;
            this.passwordTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTB_KeyPress);
            // 
            // lnameTB
            // 
            this.lnameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lnameTB.Location = new System.Drawing.Point(258, 372);
            this.lnameTB.Name = "lnameTB";
            this.lnameTB.Size = new System.Drawing.Size(128, 36);
            this.lnameTB.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.lnameTB.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.lnameTB.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.lnameTB.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lnameTB.StateCommon.Border.Rounding = 10F;
            this.lnameTB.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lnameTB.StateCommon.Content.Padding = new System.Windows.Forms.Padding(7);
            this.lnameTB.TabIndex = 36;
            this.lnameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lnameTB_KeyPress);
            // 
            // fnameTB
            // 
            this.fnameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fnameTB.Location = new System.Drawing.Point(120, 372);
            this.fnameTB.Name = "fnameTB";
            this.fnameTB.Size = new System.Drawing.Size(128, 36);
            this.fnameTB.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.fnameTB.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.fnameTB.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.fnameTB.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.fnameTB.StateCommon.Border.Rounding = 10F;
            this.fnameTB.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.fnameTB.StateCommon.Content.Padding = new System.Windows.Forms.Padding(7);
            this.fnameTB.TabIndex = 35;
            this.fnameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fnameTB_KeyPress);
            // 
            // teacherIDTB
            // 
            this.teacherIDTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.teacherIDTB.Location = new System.Drawing.Point(120, 303);
            this.teacherIDTB.Name = "teacherIDTB";
            this.teacherIDTB.Size = new System.Drawing.Size(266, 36);
            this.teacherIDTB.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.teacherIDTB.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.teacherIDTB.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.teacherIDTB.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.teacherIDTB.StateCommon.Border.Rounding = 10F;
            this.teacherIDTB.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.teacherIDTB.StateCommon.Content.Padding = new System.Windows.Forms.Padding(7);
            this.teacherIDTB.TabIndex = 0;
            this.teacherIDTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.teacherIDTB_KeyPress);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.Location = new System.Drawing.Point(120, 511);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(103, 29);
            this.cancelBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.cancelBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.cancelBtn.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("cancelBtn.StateCommon.Back.Image")));
            this.cancelBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.cancelBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.cancelBtn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cancelBtn.StateCommon.Border.Rounding = 10F;
            this.cancelBtn.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.cancelBtn.StateCommon.Content.Padding = new System.Windows.Forms.Padding(7);
            this.cancelBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.cancelBtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.cancelBtn.StatePressed.Back.Image = ((System.Drawing.Image)(resources.GetObject("cancelBtn.StatePressed.Back.Image")));
            this.cancelBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.cancelBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.cancelBtn.StateTracking.Back.Image = ((System.Drawing.Image)(resources.GetObject("cancelBtn.StateTracking.Back.Image")));
            this.cancelBtn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.cancelBtn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.cancelBtn.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cancelBtn.TabIndex = 33;
            this.cancelBtn.Values.Text = "";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmBtn.Location = new System.Drawing.Point(229, 511);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(103, 29);
            this.confirmBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.confirmBtn.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("confirmBtn.StateCommon.Back.Image")));
            this.confirmBtn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.confirmBtn.StateCommon.Border.Rounding = 10F;
            this.confirmBtn.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.confirmBtn.StateCommon.Content.Padding = new System.Windows.Forms.Padding(7);
            this.confirmBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.confirmBtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.confirmBtn.StatePressed.Back.Image = ((System.Drawing.Image)(resources.GetObject("confirmBtn.StatePressed.Back.Image")));
            this.confirmBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.confirmBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.confirmBtn.StateTracking.Back.Image = ((System.Drawing.Image)(resources.GetObject("confirmBtn.StateTracking.Back.Image")));
            this.confirmBtn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.confirmBtn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.confirmBtn.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.confirmBtn.TabIndex = 32;
            this.confirmBtn.Values.Text = "";
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // SignupFormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.confirmPassTB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.lnameTB);
            this.Controls.Add(this.fnameTB);
            this.Controls.Add(this.teacherIDTB);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignupFormTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignupForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private Krypton.Toolkit.KryptonTextBox confirmPassTB;
        private Krypton.Toolkit.KryptonTextBox passwordTB;
        private Krypton.Toolkit.KryptonTextBox lnameTB;
        private Krypton.Toolkit.KryptonTextBox fnameTB;
        private Krypton.Toolkit.KryptonTextBox teacherIDTB;
        private Krypton.Toolkit.KryptonButton cancelBtn;
        private Krypton.Toolkit.KryptonButton confirmBtn;
    }
}