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
            this.profiletext = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Backbtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.user_id = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.timelabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.account_type = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonContextMenuItem1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem3 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItems2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItems3 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem4 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.StudentIdLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.FirstNameLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.LastNameLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.EmailLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ProgramLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ChangePasswordLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ChangePasswordButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.RemovePfpBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SaveBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.UploadPfpBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Program_Combo_Box = new Krypton.Toolkit.KryptonComboBox();
            this.Program_DropButtonPalette = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.invisiblePassBtn = new Krypton.Toolkit.KryptonButton();
            this.pfpbox = new Krypton.Toolkit.KryptonPictureBox();
            this.email = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.last_name = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.first_name = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.newpassword2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.newpassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.password_cr = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
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
            this.profiletext.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom2;
            this.profiletext.Enabled = false;
            this.profiletext.Location = new System.Drawing.Point(90, 145);
            this.profiletext.Name = "profiletext";
            this.profiletext.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.profiletext.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.profiletext.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.profiletext.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.profiletext.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.profiletext.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.profiletext.OverrideDefault.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.profiletext.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.profiletext.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.profiletext.OverrideFocus.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.profiletext.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.profiletext.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.profiletext.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.profiletext.OverrideFocus.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.profiletext.Size = new System.Drawing.Size(160, 40);
            this.profiletext.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.profiletext.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.profiletext.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.profiletext.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.profiletext.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.profiletext.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.profiletext.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.profiletext.StateCommon.Border.Rounding = 10;
            this.profiletext.StateCommon.Border.Width = 1;
            this.profiletext.StateCommon.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.profiletext.StateCommon.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.profiletext.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.profiletext.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.profiletext.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.profiletext.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.profiletext.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.profiletext.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.profiletext.StateDisabled.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.profiletext.StateDisabled.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.profiletext.StateDisabled.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.profiletext.StateDisabled.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.profiletext.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.profiletext.StateDisabled.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.profiletext.StateDisabled.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.profiletext.StateDisabled.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.profiletext.TabIndex = 4;
            this.profiletext.UseMnemonic = false;
            this.profiletext.Values.Text = "Profile";
            // 
            // Backbtn
            // 
            this.Backbtn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom2;
            this.Backbtn.Location = new System.Drawing.Point(90, 195);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.Backbtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.Backbtn.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Backbtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Backbtn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Backbtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Backbtn.OverrideDefault.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Backbtn.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Backbtn.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Backbtn.OverrideFocus.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Backbtn.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Backbtn.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Backbtn.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Backbtn.OverrideFocus.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Backbtn.Size = new System.Drawing.Size(160, 40);
            this.Backbtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.Backbtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.Backbtn.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Backbtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Backbtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Backbtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Backbtn.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Backbtn.StateCommon.Border.Rounding = 10;
            this.Backbtn.StateCommon.Border.Width = 1;
            this.Backbtn.StateCommon.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Backbtn.StateCommon.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Backbtn.StateCommon.Content.LongText.ColorAngle = 45F;
            this.Backbtn.StateCommon.Content.LongText.Font = new System.Drawing.Font("Inter SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Backbtn.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.Backbtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Backbtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Backbtn.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Backbtn.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.Backbtn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Backbtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Backbtn.StatePressed.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Backbtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Backbtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Backbtn.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Backbtn.TabIndex = 3;
            this.Backbtn.Values.Text = "Back";
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // user_id
            // 
            this.user_id.AutoSize = false;
            this.user_id.Enabled = false;
            this.user_id.Location = new System.Drawing.Point(340, 119);
            this.user_id.Name = "user_id";
            this.user_id.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.user_id.Size = new System.Drawing.Size(190, 25);
            this.user_id.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.user_id.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.user_id.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.user_id.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.user_id.TabIndex = 31;
            this.user_id.Values.Text = "User ID: ";
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Font = new System.Drawing.Font("Inter", 12F);
            this.timelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.timelabel.Location = new System.Drawing.Point(930, 80);
            this.timelabel.Name = "timelabel";
            this.timelabel.Padding = new System.Windows.Forms.Padding(10);
            this.timelabel.Size = new System.Drawing.Size(218, 39);
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
            this.account_type.Location = new System.Drawing.Point(540, 119);
            this.account_type.Name = "account_type";
            this.account_type.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.account_type.Size = new System.Drawing.Size(190, 25);
            this.account_type.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.account_type.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.account_type.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.account_type.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
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
            this.StudentIdLabel.Location = new System.Drawing.Point(60, 175);
            this.StudentIdLabel.Name = "StudentIdLabel";
            this.StudentIdLabel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.StudentIdLabel.Size = new System.Drawing.Size(75, 25);
            this.StudentIdLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.StudentIdLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.StudentIdLabel.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.StudentIdLabel.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.StudentIdLabel.TabIndex = 8;
            this.StudentIdLabel.Values.Text = "Student ID";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = false;
            this.FirstNameLabel.Location = new System.Drawing.Point(350, 175);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.FirstNameLabel.Size = new System.Drawing.Size(74, 22);
            this.FirstNameLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.FirstNameLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.FirstNameLabel.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.FirstNameLabel.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.FirstNameLabel.TabIndex = 9;
            this.FirstNameLabel.Values.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = false;
            this.LastNameLabel.Location = new System.Drawing.Point(495, 175);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.LastNameLabel.Size = new System.Drawing.Size(74, 22);
            this.LastNameLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.LastNameLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.LastNameLabel.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.LastNameLabel.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.LastNameLabel.TabIndex = 10;
            this.LastNameLabel.Values.Text = "Last Name";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = false;
            this.EmailLabel.Location = new System.Drawing.Point(60, 244);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.EmailLabel.Size = new System.Drawing.Size(135, 22);
            this.EmailLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.EmailLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.EmailLabel.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.EmailLabel.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.EmailLabel.TabIndex = 11;
            this.EmailLabel.Values.Text = "School Email";
            // 
            // ProgramLabel
            // 
            this.ProgramLabel.AutoSize = false;
            this.ProgramLabel.Location = new System.Drawing.Point(350, 244);
            this.ProgramLabel.Name = "ProgramLabel";
            this.ProgramLabel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.ProgramLabel.Size = new System.Drawing.Size(74, 22);
            this.ProgramLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ProgramLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ProgramLabel.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.ProgramLabel.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.ProgramLabel.TabIndex = 12;
            this.ProgramLabel.Values.Text = "Program";
            // 
            // ChangePasswordLabel
            // 
            this.ChangePasswordLabel.AutoSize = false;
            this.ChangePasswordLabel.Location = new System.Drawing.Point(60, 348);
            this.ChangePasswordLabel.Name = "ChangePasswordLabel";
            this.ChangePasswordLabel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.ChangePasswordLabel.Size = new System.Drawing.Size(119, 22);
            this.ChangePasswordLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ChangePasswordLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ChangePasswordLabel.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.ChangePasswordLabel.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.ChangePasswordLabel.TabIndex = 13;
            this.ChangePasswordLabel.Values.Text = "Change Password";
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Location = new System.Drawing.Point(510, 457);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ChangePasswordButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ChangePasswordButton.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.ChangePasswordButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ChangePasswordButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ChangePasswordButton.OverrideDefault.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.ChangePasswordButton.Size = new System.Drawing.Size(120, 30);
            this.ChangePasswordButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ChangePasswordButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ChangePasswordButton.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.ChangePasswordButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ChangePasswordButton.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ChangePasswordButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ChangePasswordButton.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.ChangePasswordButton.StateCommon.Border.Rounding = 10;
            this.ChangePasswordButton.StateCommon.Border.Width = 1;
            this.ChangePasswordButton.StateCommon.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ChangePasswordButton.StateCommon.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ChangePasswordButton.StateCommon.Content.LongText.ColorAngle = 45F;
            this.ChangePasswordButton.StateCommon.Content.LongText.Font = new System.Drawing.Font("Inter SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordButton.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.ChangePasswordButton.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.ChangePasswordButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ChangePasswordButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ChangePasswordButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Inter SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordButton.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.ChangePasswordButton.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.ChangePasswordButton.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ChangePasswordButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ChangePasswordButton.StatePressed.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.ChangePasswordButton.TabIndex = 15;
            this.ChangePasswordButton.Values.Text = "Confirm";
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // RemovePfpBtn
            // 
            this.RemovePfpBtn.Location = new System.Drawing.Point(200, 103);
            this.RemovePfpBtn.Name = "RemovePfpBtn";
            this.RemovePfpBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.RemovePfpBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.RemovePfpBtn.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.RemovePfpBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.RemovePfpBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.RemovePfpBtn.OverrideDefault.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.RemovePfpBtn.Size = new System.Drawing.Size(120, 30);
            this.RemovePfpBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.RemovePfpBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.RemovePfpBtn.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.RemovePfpBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.RemovePfpBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.RemovePfpBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.RemovePfpBtn.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.RemovePfpBtn.StateCommon.Border.Rounding = 10;
            this.RemovePfpBtn.StateCommon.Border.Width = 1;
            this.RemovePfpBtn.StateCommon.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.RemovePfpBtn.StateCommon.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.RemovePfpBtn.StateCommon.Content.LongText.ColorAngle = 45F;
            this.RemovePfpBtn.StateCommon.Content.LongText.Font = new System.Drawing.Font("Inter SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemovePfpBtn.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.RemovePfpBtn.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.RemovePfpBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.RemovePfpBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.RemovePfpBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Inter SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemovePfpBtn.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.RemovePfpBtn.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.RemovePfpBtn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.RemovePfpBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.RemovePfpBtn.StatePressed.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.RemovePfpBtn.TabIndex = 28;
            this.RemovePfpBtn.Values.Text = "Remove";
            this.RemovePfpBtn.Click += new System.EventHandler(this.RemovePfpBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(510, 319);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.SaveBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.SaveBtn.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.SaveBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SaveBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SaveBtn.OverrideDefault.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.SaveBtn.Size = new System.Drawing.Size(120, 30);
            this.SaveBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.SaveBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.SaveBtn.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.SaveBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SaveBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SaveBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SaveBtn.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.SaveBtn.StateCommon.Border.Rounding = 10;
            this.SaveBtn.StateCommon.Border.Width = 1;
            this.SaveBtn.StateCommon.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SaveBtn.StateCommon.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SaveBtn.StateCommon.Content.LongText.ColorAngle = 45F;
            this.SaveBtn.StateCommon.Content.LongText.Font = new System.Drawing.Font("Inter SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.SaveBtn.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.SaveBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SaveBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SaveBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Inter SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.SaveBtn.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.SaveBtn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SaveBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SaveBtn.StatePressed.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.SaveBtn.TabIndex = 29;
            this.SaveBtn.Values.Text = "Save";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // UploadPfpBtn
            // 
            this.UploadPfpBtn.Location = new System.Drawing.Point(200, 67);
            this.UploadPfpBtn.Name = "UploadPfpBtn";
            this.UploadPfpBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.UploadPfpBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.UploadPfpBtn.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.UploadPfpBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.UploadPfpBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.UploadPfpBtn.OverrideDefault.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.UploadPfpBtn.Size = new System.Drawing.Size(120, 30);
            this.UploadPfpBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.UploadPfpBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.UploadPfpBtn.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.UploadPfpBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.UploadPfpBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.UploadPfpBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.UploadPfpBtn.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.UploadPfpBtn.StateCommon.Border.Rounding = 10;
            this.UploadPfpBtn.StateCommon.Border.Width = 1;
            this.UploadPfpBtn.StateCommon.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.UploadPfpBtn.StateCommon.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.UploadPfpBtn.StateCommon.Content.LongText.ColorAngle = 45F;
            this.UploadPfpBtn.StateCommon.Content.LongText.Font = new System.Drawing.Font("Inter SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadPfpBtn.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.UploadPfpBtn.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.UploadPfpBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.UploadPfpBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.UploadPfpBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Inter SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadPfpBtn.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.UploadPfpBtn.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.UploadPfpBtn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.UploadPfpBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.UploadPfpBtn.StatePressed.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
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
            this.kryptonPanel1.Location = new System.Drawing.Point(340, 145);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.FormCustom1;
            this.kryptonPanel1.Size = new System.Drawing.Size(683, 526);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.kryptonPanel1.StateCommon.Image = global::Exam_Management_System.Properties.Resources.profile_panel;
            this.kryptonPanel1.StateCommon.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.kryptonPanel1.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.kryptonPanel1.StateDisabled.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonPanel1.StateDisabled.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPanel1.TabIndex = 5;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.AutoSize = false;
            this.kryptonLabel5.Location = new System.Drawing.Point(450, 379);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel5.Size = new System.Drawing.Size(156, 22);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.kryptonLabel5.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.kryptonLabel5.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel5.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel5.TabIndex = 39;
            this.kryptonLabel5.Values.Text = "Re-enter new password";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.AutoSize = false;
            this.kryptonLabel4.Location = new System.Drawing.Point(255, 379);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel4.Size = new System.Drawing.Size(169, 22);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.kryptonLabel4.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.kryptonLabel4.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel4.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
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
            this.Program_Combo_Box.Location = new System.Drawing.Point(350, 269);
            this.Program_Combo_Box.Name = "Program_Combo_Box";
            this.Program_Combo_Box.Palette = this.Program_DropButtonPalette;
            this.Program_Combo_Box.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.Program_Combo_Box.Size = new System.Drawing.Size(280, 26);
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
            this.Program_Combo_Box.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Program_Combo_Box.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
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
            this.kryptonLabel2.Location = new System.Drawing.Point(60, 376);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel2.Size = new System.Drawing.Size(146, 25);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.kryptonLabel2.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.kryptonLabel2.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel2.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel2.TabIndex = 36;
            this.kryptonLabel2.Values.Text = "Enter current password";
            // 
            // invisiblePassBtn
            // 
            this.invisiblePassBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.invisiblePassBtn.Location = new System.Drawing.Point(213, 412);
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
            this.invisiblePassBtn.TabIndex = 32;
            this.invisiblePassBtn.Values.Text = "";
            // 
            // pfpbox
            // 
            this.pfpbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pfpbox.Image = global::Exam_Management_System.Properties.Resources.profile_icon;
            this.pfpbox.Location = new System.Drawing.Point(60, 40);
            this.pfpbox.Name = "pfpbox";
            this.pfpbox.Size = new System.Drawing.Size(120, 120);
            this.pfpbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pfpbox.TabIndex = 24;
            this.pfpbox.TabStop = false;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(60, 269);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(280, 26);
            this.email.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.email.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.email.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.email.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.email.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.email.StateCommon.Border.Rounding = 8;
            this.email.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.email.StateCommon.Content.Font = new System.Drawing.Font("Inter", 9F);
            this.email.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, 2, 2, 1);
            this.email.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.email.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.email.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.email.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.email.StateNormal.Border.Rounding = 10;
            this.email.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.email.StateNormal.Content.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.TabIndex = 19;
            this.email.Text = "youremail@gmail.com";
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(495, 200);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(135, 26);
            this.last_name.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.last_name.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.last_name.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.last_name.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.last_name.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.last_name.StateCommon.Border.Rounding = 8;
            this.last_name.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.last_name.StateCommon.Content.Font = new System.Drawing.Font("Inter", 9F);
            this.last_name.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, 2, 2, 1);
            this.last_name.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.last_name.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.last_name.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.last_name.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.last_name.StateNormal.Border.Rounding = 10;
            this.last_name.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.last_name.StateNormal.Content.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_name.TabIndex = 18;
            this.last_name.Text = "Last_Name";
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(350, 200);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(135, 26);
            this.first_name.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.first_name.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.first_name.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.first_name.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.first_name.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.first_name.StateCommon.Border.Rounding = 8;
            this.first_name.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.first_name.StateCommon.Content.Font = new System.Drawing.Font("Inter", 9F);
            this.first_name.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, 2, 2, 1);
            this.first_name.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.first_name.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.first_name.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.first_name.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.first_name.StateNormal.Border.Rounding = 10;
            this.first_name.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.first_name.StateNormal.Content.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_name.TabIndex = 17;
            this.first_name.Text = "First_Name";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(60, 200);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(280, 26);
            this.ID.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ID.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ID.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ID.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ID.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.ID.StateCommon.Border.Rounding = 8;
            this.ID.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ID.StateCommon.Content.Font = new System.Drawing.Font("Inter", 9F);
            this.ID.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, 2, 2, 1);
            this.ID.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.ID.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.ID.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ID.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.ID.StateNormal.Border.Rounding = 10;
            this.ID.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ID.StateNormal.Content.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.TabIndex = 16;
            this.ID.Text = "Your ID";
            // 
            // newpassword2
            // 
            this.newpassword2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newpassword2.Location = new System.Drawing.Point(450, 407);
            this.newpassword2.Name = "newpassword2";
            this.newpassword2.PasswordChar = '●';
            this.newpassword2.Size = new System.Drawing.Size(180, 26);
            this.newpassword2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.newpassword2.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.newpassword2.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.newpassword2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.newpassword2.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.newpassword2.StateCommon.Border.Rounding = 8;
            this.newpassword2.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.newpassword2.StateCommon.Content.Font = new System.Drawing.Font("Inter", 9F);
            this.newpassword2.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, 2, 2, 1);
            this.newpassword2.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.newpassword2.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.newpassword2.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.newpassword2.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.newpassword2.StateNormal.Border.Rounding = 10;
            this.newpassword2.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.newpassword2.StateNormal.Content.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpassword2.TabIndex = 23;
            this.newpassword2.UseSystemPasswordChar = true;
            this.newpassword2.TextChanged += new System.EventHandler(this.newpassword2_TextChanged);
            // 
            // newpassword
            // 
            this.newpassword.Location = new System.Drawing.Point(255, 407);
            this.newpassword.Name = "newpassword";
            this.newpassword.PasswordChar = '●';
            this.newpassword.Size = new System.Drawing.Size(180, 26);
            this.newpassword.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.newpassword.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.newpassword.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.newpassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.newpassword.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.newpassword.StateCommon.Border.Rounding = 8;
            this.newpassword.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.newpassword.StateCommon.Content.Font = new System.Drawing.Font("Inter", 9F);
            this.newpassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, 2, 2, 1);
            this.newpassword.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.newpassword.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.newpassword.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.newpassword.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.newpassword.StateNormal.Border.Rounding = 10;
            this.newpassword.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.newpassword.StateNormal.Content.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpassword.TabIndex = 22;
            this.newpassword.UseSystemPasswordChar = true;
            this.newpassword.TextChanged += new System.EventHandler(this.newpassword_TextChanged);
            // 
            // password_cr
            // 
            this.password_cr.Location = new System.Drawing.Point(60, 407);
            this.password_cr.Name = "password_cr";
            this.password_cr.PasswordChar = '●';
            this.password_cr.Size = new System.Drawing.Size(180, 26);
            this.password_cr.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.password_cr.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.password_cr.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.password_cr.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.password_cr.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.password_cr.StateCommon.Border.Rounding = 8;
            this.password_cr.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.password_cr.StateCommon.Content.Font = new System.Drawing.Font("Inter", 9F);
            this.password_cr.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4, 2, 2, 1);
            this.password_cr.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.password_cr.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.password_cr.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.password_cr.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.password_cr.StateNormal.Border.Rounding = 10;
            this.password_cr.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.password_cr.StateNormal.Content.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_cr.TabIndex = 21;
            this.password_cr.UseSystemPasswordChar = true;
            this.password_cr.TextChanged += new System.EventHandler(this.password_cr_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Exam_Management_System.Properties.Resources.profile_header;
            this.pictureBox2.Location = new System.Drawing.Point(90, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // kryptonPictureBox2
            // 
            this.kryptonPictureBox2.Image = global::Exam_Management_System.Properties.Resources.profile_design;
            this.kryptonPictureBox2.Location = new System.Drawing.Point(770, -1);
            this.kryptonPictureBox2.Name = "kryptonPictureBox2";
            this.kryptonPictureBox2.Size = new System.Drawing.Size(432, 750);
            this.kryptonPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.kryptonPictureBox2.TabIndex = 8;
            this.kryptonPictureBox2.TabStop = false;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1200, 750);
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
        private ComponentFactory.Krypton.Toolkit.KryptonButton profiletext;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Backbtn;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Timer timer1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel user_id;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel account_type;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem3;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems3;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel StudentIdLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel FirstNameLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LastNameLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel EmailLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel ProgramLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel ChangePasswordLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ChangePasswordButton;
        private KryptonPictureBox pfpbox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton RemovePfpBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton SaveBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton UploadPfpBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox newpassword2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox newpassword;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox password_cr;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox email;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox last_name;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox first_name;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ID;

        private KryptonComboBox Program_Combo_Box;
        private KryptonCustomPaletteBase Program_DropButtonPalette;
        private KryptonButton invisiblePassBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
    }
}