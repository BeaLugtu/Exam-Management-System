using Krypton.Toolkit;
using System.Data;
using System.Windows.Forms;

namespace Exam_Management_System.Designs
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.profiletext = new Krypton.Toolkit.KryptonButton();
            this.Backbtn = new Krypton.Toolkit.KryptonButton();
            this.user_id = new Krypton.Toolkit.KryptonLabel();
            this.timelabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.account_type = new Krypton.Toolkit.KryptonLabel();
            this.kryptonContextMenuItem1 = new Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem2 = new Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem3 = new Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItems2 = new Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItems3 = new Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem4 = new Krypton.Toolkit.KryptonContextMenuItem();
            this.StudentIdLabel = new Krypton.Toolkit.KryptonLabel();
            this.FirstNameLabel = new Krypton.Toolkit.KryptonLabel();
            this.LastNameLabel = new Krypton.Toolkit.KryptonLabel();
            this.EmailLabel = new Krypton.Toolkit.KryptonLabel();
            this.ProgramLabel = new Krypton.Toolkit.KryptonLabel();
            this.ChangePasswordLabel = new Krypton.Toolkit.KryptonLabel();
            this.ChangePasswordButton = new Krypton.Toolkit.KryptonButton();
            this.RemovePfpBtn = new Krypton.Toolkit.KryptonButton();
            this.SaveBtn = new Krypton.Toolkit.KryptonButton();
            this.UploadPfpBtn = new Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.Program_Combo_Box = new Krypton.Toolkit.KryptonComboBox();
            this.Program_DropButtonPalette = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.invisiblePassBtn = new Krypton.Toolkit.KryptonButton();
            this.pfpbox = new Krypton.Toolkit.KryptonPictureBox();
            this.email = new Krypton.Toolkit.KryptonTextBox();
            this.last_name = new Krypton.Toolkit.KryptonTextBox();
            this.first_name = new Krypton.Toolkit.KryptonTextBox();
            this.ID = new Krypton.Toolkit.KryptonTextBox();
            this.newpassword2 = new Krypton.Toolkit.KryptonTextBox();
            this.newpassword = new Krypton.Toolkit.KryptonTextBox();
            this.password_cr = new Krypton.Toolkit.KryptonTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.kryptonPictureBox2 = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Program_Combo_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfpbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // profiletext
            // 
            this.profiletext.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom2;
            this.profiletext.Enabled = false;
            this.profiletext.Location = new System.Drawing.Point(120, 178);
            this.profiletext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.profiletext.Name = "profiletext";
            this.profiletext.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.profiletext.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.profiletext.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.profiletext.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.profiletext.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.profiletext.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.profiletext.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.profiletext.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.profiletext.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.profiletext.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.profiletext.Size = new System.Drawing.Size(213, 49);
            this.profiletext.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.profiletext.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.profiletext.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.profiletext.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.profiletext.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.profiletext.StateCommon.Border.Rounding = 10F;
            this.profiletext.StateCommon.Border.Width = 1;
            this.profiletext.StateCommon.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.profiletext.StateCommon.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.profiletext.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.profiletext.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.profiletext.StateDisabled.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.profiletext.StateDisabled.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.profiletext.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.profiletext.StateDisabled.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.profiletext.TabIndex = 4;
            this.profiletext.UseMnemonic = false;
            this.profiletext.Values.Text = "Profile";
            // 
            // Backbtn
            // 
            this.Backbtn.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom2;
            this.Backbtn.Location = new System.Drawing.Point(120, 240);
            this.Backbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.Backbtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.Backbtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Backbtn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Backbtn.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Backbtn.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Backbtn.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Backbtn.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Backbtn.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Backbtn.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Backbtn.Size = new System.Drawing.Size(213, 49);
            this.Backbtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.Backbtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.Backbtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Backbtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Backbtn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Backbtn.StateCommon.Border.Rounding = 10F;
            this.Backbtn.StateCommon.Border.Width = 1;
            this.Backbtn.StateCommon.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Backbtn.StateCommon.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Backbtn.StateCommon.Content.LongText.ColorAngle = 45F;
            this.Backbtn.StateCommon.Content.LongText.Font = new System.Drawing.Font("Inter SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Backbtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Backbtn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Backbtn.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Backbtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Backbtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Backbtn.TabIndex = 3;
            this.Backbtn.Values.Text = "Back";
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // user_id
            // 
            this.user_id.AutoSize = false;
            this.user_id.Enabled = false;
            this.user_id.Location = new System.Drawing.Point(453, 146);
            this.user_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.user_id.Name = "user_id";
            this.user_id.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.user_id.Size = new System.Drawing.Size(253, 31);
            this.user_id.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.user_id.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.user_id.TabIndex = 31;
            this.user_id.Values.Text = "User ID: ";
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Font = new System.Drawing.Font("Inter", 12F);
            this.timelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.timelabel.Location = new System.Drawing.Point(1240, 98);
            this.timelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timelabel.Name = "timelabel";
            this.timelabel.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.timelabel.Size = new System.Drawing.Size(274, 48);
            this.timelabel.TabIndex = 6;
            this.timelabel.Text = "hh:mm tt — ddd, MMM d";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // account_type
            // 
            this.account_type.AutoSize = false;
            this.account_type.Enabled = false;
            this.account_type.Location = new System.Drawing.Point(720, 146);
            this.account_type.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.account_type.Name = "account_type";
            this.account_type.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.account_type.Size = new System.Drawing.Size(253, 31);
            this.account_type.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.account_type.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.account_type.TabIndex = 32;
            this.account_type.Values.Text = "Account Type: ";
            // 
            // kryptonContextMenuItem1
            // 
            this.kryptonContextMenuItem1.Text = "Menu Item";
            // 
            // kryptonContextMenuItem2
            // 
            this.kryptonContextMenuItem2.Text = "Menu Item";
            // 
            // kryptonContextMenuItem3
            // 
            this.kryptonContextMenuItem3.Text = "Menu Item";
            // 
            // kryptonContextMenuItem4
            // 
            this.kryptonContextMenuItem4.Text = "Menu Item";
            // 
            // StudentIdLabel
            // 
            this.StudentIdLabel.AutoSize = false;
            this.StudentIdLabel.Location = new System.Drawing.Point(80, 215);
            this.StudentIdLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StudentIdLabel.Name = "StudentIdLabel";
            this.StudentIdLabel.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.StudentIdLabel.Size = new System.Drawing.Size(100, 31);
            this.StudentIdLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.StudentIdLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.StudentIdLabel.TabIndex = 8;
            this.StudentIdLabel.Values.Text = "Student ID";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = false;
            this.FirstNameLabel.Location = new System.Drawing.Point(467, 215);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.FirstNameLabel.Size = new System.Drawing.Size(99, 27);
            this.FirstNameLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.FirstNameLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.FirstNameLabel.TabIndex = 9;
            this.FirstNameLabel.Values.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = false;
            this.LastNameLabel.Location = new System.Drawing.Point(660, 215);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.LastNameLabel.Size = new System.Drawing.Size(99, 27);
            this.LastNameLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.LastNameLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.LastNameLabel.TabIndex = 10;
            this.LastNameLabel.Values.Text = "Last Name";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = false;
            this.EmailLabel.Location = new System.Drawing.Point(80, 300);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.EmailLabel.Size = new System.Drawing.Size(180, 27);
            this.EmailLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.EmailLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.EmailLabel.TabIndex = 11;
            this.EmailLabel.Values.Text = "School Email";
            // 
            // ProgramLabel
            // 
            this.ProgramLabel.AutoSize = false;
            this.ProgramLabel.Location = new System.Drawing.Point(467, 300);
            this.ProgramLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProgramLabel.Name = "ProgramLabel";
            this.ProgramLabel.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.ProgramLabel.Size = new System.Drawing.Size(99, 27);
            this.ProgramLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ProgramLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ProgramLabel.TabIndex = 12;
            this.ProgramLabel.Values.Text = "Program";
            // 
            // ChangePasswordLabel
            // 
            this.ChangePasswordLabel.AutoSize = false;
            this.ChangePasswordLabel.Location = new System.Drawing.Point(80, 428);
            this.ChangePasswordLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChangePasswordLabel.Name = "ChangePasswordLabel";
            this.ChangePasswordLabel.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.ChangePasswordLabel.Size = new System.Drawing.Size(159, 27);
            this.ChangePasswordLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ChangePasswordLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ChangePasswordLabel.TabIndex = 13;
            this.ChangePasswordLabel.Values.Text = "Change Password";
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Location = new System.Drawing.Point(680, 562);
            this.ChangePasswordButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ChangePasswordButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ChangePasswordButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ChangePasswordButton.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ChangePasswordButton.Size = new System.Drawing.Size(160, 37);
            this.ChangePasswordButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ChangePasswordButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ChangePasswordButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ChangePasswordButton.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ChangePasswordButton.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ChangePasswordButton.StateCommon.Border.Rounding = 10F;
            this.ChangePasswordButton.StateCommon.Border.Width = 1;
            this.ChangePasswordButton.StateCommon.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ChangePasswordButton.StateCommon.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ChangePasswordButton.StateCommon.Content.LongText.ColorAngle = 45F;
            this.ChangePasswordButton.StateCommon.Content.LongText.Font = new System.Drawing.Font("Inter SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ChangePasswordButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ChangePasswordButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Inter SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordButton.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ChangePasswordButton.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ChangePasswordButton.TabIndex = 15;
            this.ChangePasswordButton.Values.Text = "Confirm";
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // RemovePfpBtn
            // 
            this.RemovePfpBtn.Location = new System.Drawing.Point(267, 127);
            this.RemovePfpBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RemovePfpBtn.Name = "RemovePfpBtn";
            this.RemovePfpBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.RemovePfpBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.RemovePfpBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.RemovePfpBtn.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.RemovePfpBtn.Size = new System.Drawing.Size(160, 37);
            this.RemovePfpBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.RemovePfpBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.RemovePfpBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.RemovePfpBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.RemovePfpBtn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.RemovePfpBtn.StateCommon.Border.Rounding = 10F;
            this.RemovePfpBtn.StateCommon.Border.Width = 1;
            this.RemovePfpBtn.StateCommon.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.RemovePfpBtn.StateCommon.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.RemovePfpBtn.StateCommon.Content.LongText.ColorAngle = 45F;
            this.RemovePfpBtn.StateCommon.Content.LongText.Font = new System.Drawing.Font("Inter SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemovePfpBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.RemovePfpBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.RemovePfpBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Inter SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemovePfpBtn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.RemovePfpBtn.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.RemovePfpBtn.TabIndex = 28;
            this.RemovePfpBtn.Values.Text = "Remove";
            this.RemovePfpBtn.Click += new System.EventHandler(this.RemovePfpBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(680, 393);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.SaveBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.SaveBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SaveBtn.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SaveBtn.Size = new System.Drawing.Size(160, 37);
            this.SaveBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.SaveBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.SaveBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SaveBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SaveBtn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SaveBtn.StateCommon.Border.Rounding = 10F;
            this.SaveBtn.StateCommon.Border.Width = 1;
            this.SaveBtn.StateCommon.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SaveBtn.StateCommon.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SaveBtn.StateCommon.Content.LongText.ColorAngle = 45F;
            this.SaveBtn.StateCommon.Content.LongText.Font = new System.Drawing.Font("Inter SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SaveBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SaveBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Inter SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SaveBtn.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SaveBtn.TabIndex = 29;
            this.SaveBtn.Values.Text = "Save";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // UploadPfpBtn
            // 
            this.UploadPfpBtn.Location = new System.Drawing.Point(267, 82);
            this.UploadPfpBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UploadPfpBtn.Name = "UploadPfpBtn";
            this.UploadPfpBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.UploadPfpBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.UploadPfpBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.UploadPfpBtn.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.UploadPfpBtn.Size = new System.Drawing.Size(160, 37);
            this.UploadPfpBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.UploadPfpBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.UploadPfpBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.UploadPfpBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.UploadPfpBtn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.UploadPfpBtn.StateCommon.Border.Rounding = 10F;
            this.UploadPfpBtn.StateCommon.Border.Width = 1;
            this.UploadPfpBtn.StateCommon.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.UploadPfpBtn.StateCommon.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.UploadPfpBtn.StateCommon.Content.LongText.ColorAngle = 45F;
            this.UploadPfpBtn.StateCommon.Content.LongText.Font = new System.Drawing.Font("Inter SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadPfpBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.UploadPfpBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.UploadPfpBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Inter SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadPfpBtn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.UploadPfpBtn.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.UploadPfpBtn.TabIndex = 30;
            this.UploadPfpBtn.Values.Text = "Upload Image";
            this.UploadPfpBtn.Click += new System.EventHandler(this.UploadPfpBtn_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.Program_Combo_Box);
            this.kryptonPanel1.Controls.Add(this.UploadPfpBtn);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.SaveBtn);
            this.kryptonPanel1.Controls.Add(this.RemovePfpBtn);
            this.kryptonPanel1.Controls.Add(this.ChangePasswordButton);
            this.kryptonPanel1.Controls.Add(this.invisiblePassBtn);
            this.kryptonPanel1.Controls.Add(this.pfpbox);
            this.kryptonPanel1.Controls.Add(this.email);
            this.kryptonPanel1.Controls.Add(this.last_name);
            this.kryptonPanel1.Controls.Add(this.first_name);
            this.kryptonPanel1.Controls.Add(this.ID);
            this.kryptonPanel1.Controls.Add(this.ChangePasswordLabel);
            this.kryptonPanel1.Controls.Add(this.newpassword2);
            this.kryptonPanel1.Controls.Add(this.ProgramLabel);
            this.kryptonPanel1.Controls.Add(this.newpassword);
            this.kryptonPanel1.Controls.Add(this.EmailLabel);
            this.kryptonPanel1.Controls.Add(this.password_cr);
            this.kryptonPanel1.Controls.Add(this.LastNameLabel);
            this.kryptonPanel1.Controls.Add(this.FirstNameLabel);
            this.kryptonPanel1.Controls.Add(this.StudentIdLabel);
            this.kryptonPanel1.Location = new System.Drawing.Point(453, 178);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.FormCustom1;
            this.kryptonPanel1.Size = new System.Drawing.Size(911, 647);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.kryptonPanel1.StateCommon.Image = global::Exam_Management_System.Properties.Resources.profile_panel;
            this.kryptonPanel1.StateCommon.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.kryptonPanel1.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.kryptonPanel1.StateDisabled.Draw = Krypton.Toolkit.InheritBool.True;
            this.kryptonPanel1.TabIndex = 5;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.AutoSize = false;
            this.kryptonLabel5.Location = new System.Drawing.Point(600, 466);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel5.Size = new System.Drawing.Size(208, 27);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.kryptonLabel5.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.kryptonLabel5.TabIndex = 39;
            this.kryptonLabel5.Values.Text = "Re-enter new password";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.AutoSize = false;
            this.kryptonLabel4.Location = new System.Drawing.Point(340, 466);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel4.Size = new System.Drawing.Size(225, 27);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.kryptonLabel4.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.kryptonLabel4.TabIndex = 38;
            this.kryptonLabel4.Values.Text = "Enter new password";
            // 
            // Program_Combo_Box
            // 
            this.Program_Combo_Box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Program_Combo_Box.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Program_Combo_Box.CornerRoundingRadius = 10F;
            this.Program_Combo_Box.DropBackStyle = Krypton.Toolkit.PaletteBackStyle.ButtonCustom1;
            this.Program_Combo_Box.DropButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            this.Program_Combo_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Program_Combo_Box.DropDownWidth = 121;
            this.Program_Combo_Box.IntegralHeight = false;
            this.Program_Combo_Box.Location = new System.Drawing.Point(467, 331);
            this.Program_Combo_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Program_Combo_Box.Name = "Program_Combo_Box";
            this.Program_Combo_Box.Palette = this.Program_DropButtonPalette;
            this.Program_Combo_Box.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.Program_Combo_Box.Size = new System.Drawing.Size(373, 30);
            this.Program_Combo_Box.StateActive.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Program_Combo_Box.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Program_Combo_Box.StateActive.ComboBox.Content.Padding = new System.Windows.Forms.Padding(7, -1, -1, -1);
            this.Program_Combo_Box.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Program_Combo_Box.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Program_Combo_Box.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Program_Combo_Box.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Program_Combo_Box.StateCommon.ComboBox.Border.Rounding = 10F;
            this.Program_Combo_Box.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Program_Combo_Box.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Program_Combo_Box.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.Program_Combo_Box.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.Program_Combo_Box.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Program_Combo_Box.StateCommon.DropBack.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Program_Combo_Box.StateCommon.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.Program_Combo_Box.StateCommon.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.Program_Combo_Box.StateCommon.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Program_Combo_Box.StateCommon.Item.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Program_Combo_Box.StateCommon.Item.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Program_Combo_Box.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Program_Combo_Box.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Program_Combo_Box.StateNormal.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Program_Combo_Box.StateNormal.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Program_Combo_Box.StateNormal.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.Program_Combo_Box.StateNormal.Item.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.Program_Combo_Box.StateNormal.Item.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Program_Combo_Box.StateNormal.Item.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Program_Combo_Box.StateNormal.Item.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Program_Combo_Box.StateNormal.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Program_Combo_Box.StateNormal.Item.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Program_Combo_Box.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.Program_Combo_Box.StateTracking.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.Program_Combo_Box.StateTracking.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Program_Combo_Box.StateTracking.Item.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Program_Combo_Box.StateTracking.Item.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Program_Combo_Box.StateTracking.Item.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Program_Combo_Box.StateTracking.Item.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Program_Combo_Box.TabIndex = 35;
            this.Program_Combo_Box.SelectedIndexChanged += new System.EventHandler(this.Program_Combo_Box_SelectedIndexChanged);
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
            this.Program_DropButtonPalette.ThemeName = "";
            this.Program_DropButtonPalette.UseKryptonFileDialogs = true;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.AutoSize = false;
            this.kryptonLabel2.Location = new System.Drawing.Point(80, 463);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel2.Size = new System.Drawing.Size(195, 31);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.kryptonLabel2.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.kryptonLabel2.TabIndex = 36;
            this.kryptonLabel2.Values.Text = "Enter current password";
            // 
            // invisiblePassBtn
            // 
            this.invisiblePassBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.invisiblePassBtn.Location = new System.Drawing.Point(284, 507);
            this.invisiblePassBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.invisiblePassBtn.Name = "invisiblePassBtn";
            this.invisiblePassBtn.Size = new System.Drawing.Size(21, 20);
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
            this.invisiblePassBtn.TabIndex = 32;
            this.invisiblePassBtn.Values.Text = "";
            // 
            // pfpbox
            // 
            this.pfpbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pfpbox.Image = global::Exam_Management_System.Properties.Resources.profile_icon;
            this.pfpbox.Location = new System.Drawing.Point(80, 49);
            this.pfpbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pfpbox.Name = "pfpbox";
            this.pfpbox.Size = new System.Drawing.Size(160, 148);
            this.pfpbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pfpbox.TabIndex = 24;
            this.pfpbox.TabStop = false;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(80, 331);
            this.email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(373, 30);
            this.email.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.email.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.email.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.email.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.email.StateCommon.Border.Rounding = 8F;
            this.email.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.email.StateCommon.Content.Font = new System.Drawing.Font("Inter", 9F);
            this.email.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, 2, 2, 1);
            this.email.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.email.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.email.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.email.StateNormal.Border.Rounding = 10F;
            this.email.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.email.StateNormal.Content.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.TabIndex = 19;
            this.email.Text = "youremail@gmail.com";
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(660, 246);
            this.last_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(180, 30);
            this.last_name.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.last_name.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.last_name.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.last_name.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.last_name.StateCommon.Border.Rounding = 8F;
            this.last_name.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.last_name.StateCommon.Content.Font = new System.Drawing.Font("Inter", 9F);
            this.last_name.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, 2, 2, 1);
            this.last_name.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.last_name.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.last_name.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.last_name.StateNormal.Border.Rounding = 10F;
            this.last_name.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.last_name.StateNormal.Content.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_name.TabIndex = 18;
            this.last_name.Text = "Last_Name";
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(467, 246);
            this.first_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(180, 30);
            this.first_name.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.first_name.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.first_name.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.first_name.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.first_name.StateCommon.Border.Rounding = 8F;
            this.first_name.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.first_name.StateCommon.Content.Font = new System.Drawing.Font("Inter", 9F);
            this.first_name.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, 2, 2, 1);
            this.first_name.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.first_name.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.first_name.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.first_name.StateNormal.Border.Rounding = 10F;
            this.first_name.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.first_name.StateNormal.Content.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_name.TabIndex = 17;
            this.first_name.Text = "First_Name";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(80, 246);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(373, 30);
            this.ID.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ID.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ID.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ID.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ID.StateCommon.Border.Rounding = 8F;
            this.ID.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ID.StateCommon.Content.Font = new System.Drawing.Font("Inter", 9F);
            this.ID.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, 2, 2, 1);
            this.ID.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.ID.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.ID.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ID.StateNormal.Border.Rounding = 10F;
            this.ID.StateNormal.Content.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.TabIndex = 16;
            this.ID.Text = "Your ID";
            // 
            // newpassword2
            // 
            this.newpassword2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newpassword2.Location = new System.Drawing.Point(600, 501);
            this.newpassword2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newpassword2.Name = "newpassword2";
            this.newpassword2.PasswordChar = '●';
            this.newpassword2.Size = new System.Drawing.Size(240, 30);
            this.newpassword2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.newpassword2.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.newpassword2.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.newpassword2.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.newpassword2.StateCommon.Border.Rounding = 8F;
            this.newpassword2.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.newpassword2.StateCommon.Content.Font = new System.Drawing.Font("Inter", 9F);
            this.newpassword2.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, 2, 2, 1);
            this.newpassword2.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.newpassword2.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.newpassword2.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.newpassword2.StateNormal.Border.Rounding = 10F;
            this.newpassword2.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.newpassword2.StateNormal.Content.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpassword2.TabIndex = 23;
            this.newpassword2.UseSystemPasswordChar = true;
            this.newpassword2.TextChanged += new System.EventHandler(this.newpassword2_TextChanged);
            // 
            // newpassword
            // 
            this.newpassword.Location = new System.Drawing.Point(340, 501);
            this.newpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newpassword.Name = "newpassword";
            this.newpassword.PasswordChar = '●';
            this.newpassword.Size = new System.Drawing.Size(240, 30);
            this.newpassword.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.newpassword.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.newpassword.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.newpassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.newpassword.StateCommon.Border.Rounding = 8F;
            this.newpassword.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.newpassword.StateCommon.Content.Font = new System.Drawing.Font("Inter", 9F);
            this.newpassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, 2, 2, 1);
            this.newpassword.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.newpassword.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.newpassword.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.newpassword.StateNormal.Border.Rounding = 10F;
            this.newpassword.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.newpassword.StateNormal.Content.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpassword.TabIndex = 22;
            this.newpassword.UseSystemPasswordChar = true;
            this.newpassword.TextChanged += new System.EventHandler(this.newpassword_TextChanged);
            // 
            // password_cr
            // 
            this.password_cr.Location = new System.Drawing.Point(80, 501);
            this.password_cr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.password_cr.Name = "password_cr";
            this.password_cr.PasswordChar = '●';
            this.password_cr.Size = new System.Drawing.Size(240, 30);
            this.password_cr.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.password_cr.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.password_cr.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.password_cr.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.password_cr.StateCommon.Border.Rounding = 8F;
            this.password_cr.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.password_cr.StateCommon.Content.Font = new System.Drawing.Font("Inter", 9F);
            this.password_cr.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, 2, 2, 1);
            this.password_cr.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.password_cr.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.password_cr.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.password_cr.StateNormal.Border.Rounding = 10F;
            this.password_cr.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.password_cr.StateNormal.Content.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_cr.TabIndex = 21;
            this.password_cr.UseSystemPasswordChar = true;
            this.password_cr.TextChanged += new System.EventHandler(this.password_cr_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Exam_Management_System.Properties.Resources.profile_header;
            this.pictureBox2.Location = new System.Drawing.Point(120, 74);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // kryptonPictureBox2
            // 
            this.kryptonPictureBox2.Image = global::Exam_Management_System.Properties.Resources.profile_design;
            this.kryptonPictureBox2.Location = new System.Drawing.Point(1027, -1);
            this.kryptonPictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonPictureBox2.Name = "kryptonPictureBox2";
            this.kryptonPictureBox2.Size = new System.Drawing.Size(432, 750);
            this.kryptonPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.kryptonPictureBox2.TabIndex = 8;
            this.kryptonPictureBox2.TabStop = false;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1600, 923);
            this.ControlBox = false;
            this.Controls.Add(this.account_type);
            this.Controls.Add(this.user_id);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.profiletext);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.kryptonPictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7";
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Program_Combo_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfpbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private Krypton.Toolkit.KryptonButton profiletext;
        private Krypton.Toolkit.KryptonButton Backbtn;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Timer timer1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox2;
        private Krypton.Toolkit.KryptonLabel user_id;
        private Krypton.Toolkit.KryptonLabel account_type;
        private Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
        private Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem2;
        private Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem3;
        private Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems2;
        private Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems3;
        private Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem4;
        private Krypton.Toolkit.KryptonLabel StudentIdLabel;
        private Krypton.Toolkit.KryptonLabel FirstNameLabel;
        private Krypton.Toolkit.KryptonLabel LastNameLabel;
        private Krypton.Toolkit.KryptonLabel EmailLabel;
        private Krypton.Toolkit.KryptonLabel ProgramLabel;
        private Krypton.Toolkit.KryptonLabel ChangePasswordLabel;
        private Krypton.Toolkit.KryptonButton ChangePasswordButton;
        private KryptonPictureBox pfpbox;
        private Krypton.Toolkit.KryptonButton RemovePfpBtn;
        private Krypton.Toolkit.KryptonButton SaveBtn;
        private Krypton.Toolkit.KryptonButton UploadPfpBtn;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonTextBox newpassword2;
        private Krypton.Toolkit.KryptonTextBox newpassword;
        private Krypton.Toolkit.KryptonTextBox password_cr;
        private Krypton.Toolkit.KryptonTextBox email;
        private Krypton.Toolkit.KryptonTextBox last_name;
        private Krypton.Toolkit.KryptonTextBox first_name;
        private Krypton.Toolkit.KryptonTextBox ID;

        private KryptonComboBox Program_Combo_Box;
        private KryptonCustomPaletteBase Program_DropButtonPalette;
        private KryptonButton invisiblePassBtn;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
    }
}