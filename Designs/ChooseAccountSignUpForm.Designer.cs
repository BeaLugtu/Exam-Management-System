namespace Exam_Management_System.Designs
{
    partial class ChooseAccountSignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseAccountSignUpForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.studentAccountOptionBtn = new System.Windows.Forms.Button();
            this.teacherAccountOptionBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(960, 671);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.confirmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmBtn.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.ForeColor = System.Drawing.Color.White;
            this.confirmBtn.Location = new System.Drawing.Point(220, 481);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(109, 45);
            this.confirmBtn.TabIndex = 13;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBtn.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelBtn.Location = new System.Drawing.Point(96, 481);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(115, 45);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // studentAccountOptionBtn
            // 
            this.studentAccountOptionBtn.BackColor = System.Drawing.Color.Transparent;
            this.studentAccountOptionBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.studentAccountOptionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentAccountOptionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.studentAccountOptionBtn.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentAccountOptionBtn.ForeColor = System.Drawing.Color.Transparent;
            this.studentAccountOptionBtn.Image = ((System.Drawing.Image)(resources.GetObject("studentAccountOptionBtn.Image")));
            this.studentAccountOptionBtn.Location = new System.Drawing.Point(95, 350);
            this.studentAccountOptionBtn.Margin = new System.Windows.Forms.Padding(0);
            this.studentAccountOptionBtn.Name = "studentAccountOptionBtn";
            this.studentAccountOptionBtn.Size = new System.Drawing.Size(343, 114);
            this.studentAccountOptionBtn.TabIndex = 14;
            this.studentAccountOptionBtn.UseVisualStyleBackColor = false;
            this.studentAccountOptionBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.studentAccountOptionBtn_MouseClick);
            // 
            // teacherAccountOptionBtn
            // 
            this.teacherAccountOptionBtn.BackColor = System.Drawing.Color.Transparent;
            this.teacherAccountOptionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teacherAccountOptionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.teacherAccountOptionBtn.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherAccountOptionBtn.ForeColor = System.Drawing.Color.Transparent;
            this.teacherAccountOptionBtn.Image = ((System.Drawing.Image)(resources.GetObject("teacherAccountOptionBtn.Image")));
            this.teacherAccountOptionBtn.Location = new System.Drawing.Point(95, 223);
            this.teacherAccountOptionBtn.Name = "teacherAccountOptionBtn";
            this.teacherAccountOptionBtn.Size = new System.Drawing.Size(342, 116);
            this.teacherAccountOptionBtn.TabIndex = 15;
            this.teacherAccountOptionBtn.UseVisualStyleBackColor = false;
            this.teacherAccountOptionBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.teacherAccountOptionBtn_MouseClick);
            // 
            // ChooseAccountSignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 595);
            this.Controls.Add(this.teacherAccountOptionBtn);
            this.Controls.Add(this.studentAccountOptionBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseAccountSignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseAccountSignUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button studentAccountOptionBtn;
        private System.Windows.Forms.Button teacherAccountOptionBtn;
    }
}