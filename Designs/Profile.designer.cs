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
            this.profilePanel = new Krypton.Toolkit.KryptonPanel();
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
            this.logoutBtn = new Krypton.Toolkit.KryptonButton();
            this.backToDashboardBtn = new Krypton.Toolkit.KryptonButton();
            this.kryptonPictureBox4 = new Krypton.Toolkit.KryptonPictureBox();
            this.kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            this.acrhiveTablePanel = new Krypton.Toolkit.KryptonPanel();
            this.flowLayoutTablelistExam = new System.Windows.Forms.FlowLayoutPanel();
            this.archivePanel = new Krypton.Toolkit.KryptonPanel();
            this.profileViewBtn = new System.Windows.Forms.Button();
            this.archiveViewBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePanel)).BeginInit();
            this.profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Program_Combo_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfpbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acrhiveTablePanel)).BeginInit();
            this.acrhiveTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archivePanel)).BeginInit();
            this.archivePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // user_id
            // 
            this.user_id.AutoSize = false;
            this.user_id.Enabled = false;
            this.user_id.Location = new System.Drawing.Point(278, 82);
            this.user_id.Margin = new System.Windows.Forms.Padding(2);
            this.user_id.Name = "user_id";
            this.user_id.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.user_id.Size = new System.Drawing.Size(190, 25);
            this.user_id.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.user_id.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.user_id.TabIndex = 31;
            this.user_id.Values.Text = "User ID: ";
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.timelabel.Location = new System.Drawing.Point(904, 82);
            this.timelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timelabel.Name = "timelabel";
            this.timelabel.Padding = new System.Windows.Forms.Padding(6);
            this.timelabel.Size = new System.Drawing.Size(157, 28);
            this.timelabel.TabIndex = 6;
            this.timelabel.Text = "11:44 pm - Tue, May 6";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // account_type
            // 
            this.account_type.AutoSize = false;
            this.account_type.Enabled = false;
            this.account_type.Location = new System.Drawing.Point(533, 82);
            this.account_type.Margin = new System.Windows.Forms.Padding(2);
            this.account_type.Name = "account_type";
            this.account_type.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.account_type.Size = new System.Drawing.Size(190, 25);
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
            this.StudentIdLabel.Location = new System.Drawing.Point(60, 175);
            this.StudentIdLabel.Name = "StudentIdLabel";
            this.StudentIdLabel.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.StudentIdLabel.Size = new System.Drawing.Size(75, 25);
            this.StudentIdLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.StudentIdLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.StudentIdLabel.TabIndex = 8;
            this.StudentIdLabel.Values.Text = "Student ID";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = false;
            this.FirstNameLabel.Location = new System.Drawing.Point(350, 175);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.FirstNameLabel.Size = new System.Drawing.Size(74, 22);
            this.FirstNameLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.FirstNameLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.FirstNameLabel.TabIndex = 9;
            this.FirstNameLabel.Values.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = false;
            this.LastNameLabel.Location = new System.Drawing.Point(495, 175);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.LastNameLabel.Size = new System.Drawing.Size(74, 22);
            this.LastNameLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.LastNameLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.LastNameLabel.TabIndex = 10;
            this.LastNameLabel.Values.Text = "Last Name";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = false;
            this.EmailLabel.Location = new System.Drawing.Point(60, 244);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.EmailLabel.Size = new System.Drawing.Size(135, 22);
            this.EmailLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.EmailLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.EmailLabel.TabIndex = 11;
            this.EmailLabel.Values.Text = "School Email";
            // 
            // ProgramLabel
            // 
            this.ProgramLabel.AutoSize = false;
            this.ProgramLabel.Location = new System.Drawing.Point(350, 244);
            this.ProgramLabel.Name = "ProgramLabel";
            this.ProgramLabel.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.ProgramLabel.Size = new System.Drawing.Size(74, 22);
            this.ProgramLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ProgramLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ProgramLabel.TabIndex = 12;
            this.ProgramLabel.Values.Text = "Program";
            // 
            // ChangePasswordLabel
            // 
            this.ChangePasswordLabel.AutoSize = false;
            this.ChangePasswordLabel.Location = new System.Drawing.Point(60, 348);
            this.ChangePasswordLabel.Name = "ChangePasswordLabel";
            this.ChangePasswordLabel.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.ChangePasswordLabel.Size = new System.Drawing.Size(119, 22);
            this.ChangePasswordLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ChangePasswordLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ChangePasswordLabel.TabIndex = 13;
            this.ChangePasswordLabel.Values.Text = "Change Password";
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Location = new System.Drawing.Point(510, 457);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ChangePasswordButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ChangePasswordButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ChangePasswordButton.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ChangePasswordButton.Size = new System.Drawing.Size(120, 30);
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
            this.RemovePfpBtn.Location = new System.Drawing.Point(160, 93);
            this.RemovePfpBtn.Name = "RemovePfpBtn";
            this.RemovePfpBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.RemovePfpBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.RemovePfpBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.RemovePfpBtn.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.RemovePfpBtn.Size = new System.Drawing.Size(120, 30);
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
            this.SaveBtn.Location = new System.Drawing.Point(510, 319);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.SaveBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.SaveBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SaveBtn.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SaveBtn.Size = new System.Drawing.Size(120, 30);
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
            this.UploadPfpBtn.Location = new System.Drawing.Point(160, 54);
            this.UploadPfpBtn.Name = "UploadPfpBtn";
            this.UploadPfpBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.UploadPfpBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.UploadPfpBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.UploadPfpBtn.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.UploadPfpBtn.Size = new System.Drawing.Size(120, 30);
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
            // profilePanel
            // 
            this.profilePanel.Controls.Add(this.kryptonLabel5);
            this.profilePanel.Controls.Add(this.kryptonLabel4);
            this.profilePanel.Controls.Add(this.Program_Combo_Box);
            this.profilePanel.Controls.Add(this.UploadPfpBtn);
            this.profilePanel.Controls.Add(this.kryptonLabel2);
            this.profilePanel.Controls.Add(this.SaveBtn);
            this.profilePanel.Controls.Add(this.RemovePfpBtn);
            this.profilePanel.Controls.Add(this.ChangePasswordButton);
            this.profilePanel.Controls.Add(this.invisiblePassBtn);
            this.profilePanel.Controls.Add(this.pfpbox);
            this.profilePanel.Controls.Add(this.email);
            this.profilePanel.Controls.Add(this.last_name);
            this.profilePanel.Controls.Add(this.first_name);
            this.profilePanel.Controls.Add(this.ID);
            this.profilePanel.Controls.Add(this.ChangePasswordLabel);
            this.profilePanel.Controls.Add(this.newpassword2);
            this.profilePanel.Controls.Add(this.ProgramLabel);
            this.profilePanel.Controls.Add(this.newpassword);
            this.profilePanel.Controls.Add(this.EmailLabel);
            this.profilePanel.Controls.Add(this.password_cr);
            this.profilePanel.Controls.Add(this.LastNameLabel);
            this.profilePanel.Controls.Add(this.FirstNameLabel);
            this.profilePanel.Controls.Add(this.StudentIdLabel);
            this.profilePanel.Location = new System.Drawing.Point(325, 140);
            this.profilePanel.Margin = new System.Windows.Forms.Padding(2);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.FormCustom1;
            this.profilePanel.Size = new System.Drawing.Size(702, 540);
            this.profilePanel.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.profilePanel.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.profilePanel.StateCommon.Image = global::Exam_Management_System.Properties.Resources.profile_panel;
            this.profilePanel.StateCommon.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.profilePanel.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.profilePanel.StateDisabled.Draw = Krypton.Toolkit.InheritBool.True;
            this.profilePanel.TabIndex = 5;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.AutoSize = false;
            this.kryptonLabel5.Location = new System.Drawing.Point(450, 379);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel5.Size = new System.Drawing.Size(156, 22);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.kryptonLabel5.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.kryptonLabel5.TabIndex = 39;
            this.kryptonLabel5.Values.Text = "Re-enter new password";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.AutoSize = false;
            this.kryptonLabel4.Location = new System.Drawing.Point(255, 379);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel4.Size = new System.Drawing.Size(169, 22);
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
            this.kryptonLabel2.Location = new System.Drawing.Point(60, 376);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel2.Size = new System.Drawing.Size(146, 25);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.kryptonLabel2.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
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
            this.pfpbox.Location = new System.Drawing.Point(48, 41);
            this.pfpbox.Margin = new System.Windows.Forms.Padding(2);
            this.pfpbox.Name = "pfpbox";
            this.pfpbox.Size = new System.Drawing.Size(88, 88);
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
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(495, 200);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(135, 26);
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
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(350, 200);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(135, 26);
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
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(60, 200);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(280, 26);
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
            // 
            // newpassword2
            // 
            this.newpassword2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newpassword2.Location = new System.Drawing.Point(450, 407);
            this.newpassword2.Margin = new System.Windows.Forms.Padding(2);
            this.newpassword2.Name = "newpassword2";
            this.newpassword2.PasswordChar = '●';
            this.newpassword2.Size = new System.Drawing.Size(180, 26);
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
            this.newpassword.Location = new System.Drawing.Point(255, 407);
            this.newpassword.Name = "newpassword";
            this.newpassword.PasswordChar = '●';
            this.newpassword.Size = new System.Drawing.Size(180, 26);
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
            this.password_cr.Location = new System.Drawing.Point(60, 407);
            this.password_cr.Name = "password_cr";
            this.password_cr.PasswordChar = '●';
            this.password_cr.Size = new System.Drawing.Size(180, 26);
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
            this.pictureBox2.Location = new System.Drawing.Point(77, 56);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.Location = new System.Drawing.Point(72, 640);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(153, 40);
            this.logoutBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.logoutBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.logoutBtn.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.StateCommon.Back.Image")));
            this.logoutBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.logoutBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.logoutBtn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.logoutBtn.StateCommon.Border.Rounding = 10F;
            this.logoutBtn.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.logoutBtn.StateCommon.Content.Padding = new System.Windows.Forms.Padding(7);
            this.logoutBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.logoutBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.logoutBtn.StateTracking.Back.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.StateTracking.Back.Image")));
            this.logoutBtn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.logoutBtn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.logoutBtn.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.logoutBtn.TabIndex = 40;
            this.logoutBtn.Values.Text = "";
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // backToDashboardBtn
            // 
            this.backToDashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToDashboardBtn.Location = new System.Drawing.Point(76, 140);
            this.backToDashboardBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backToDashboardBtn.Name = "backToDashboardBtn";
            this.backToDashboardBtn.Size = new System.Drawing.Size(134, 36);
            this.backToDashboardBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.backToDashboardBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.backToDashboardBtn.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("backToDashboardBtn.StateCommon.Back.Image")));
            this.backToDashboardBtn.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.backToDashboardBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.backToDashboardBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.backToDashboardBtn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.backToDashboardBtn.StateCommon.Border.Rounding = 10F;
            this.backToDashboardBtn.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.backToDashboardBtn.StateCommon.Content.Padding = new System.Windows.Forms.Padding(7);
            this.backToDashboardBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToDashboardBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.backToDashboardBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.backToDashboardBtn.StateTracking.Back.Image = ((System.Drawing.Image)(resources.GetObject("backToDashboardBtn.StateTracking.Back.Image")));
            this.backToDashboardBtn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.backToDashboardBtn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.backToDashboardBtn.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.backToDashboardBtn.TabIndex = 42;
            this.backToDashboardBtn.Values.Text = "";
            this.backToDashboardBtn.Click += new System.EventHandler(this.backToDashboardBtn_Click);
            // 
            // kryptonPictureBox4
            // 
            this.kryptonPictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPictureBox4.Image")));
            this.kryptonPictureBox4.Location = new System.Drawing.Point(193, 54);
            this.kryptonPictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPictureBox4.Name = "kryptonPictureBox4";
            this.kryptonPictureBox4.Size = new System.Drawing.Size(409, 53);
            this.kryptonPictureBox4.TabIndex = 48;
            this.kryptonPictureBox4.TabStop = false;
            // 
            // kryptonPictureBox1
            // 
            this.kryptonPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPictureBox1.Image")));
            this.kryptonPictureBox1.Location = new System.Drawing.Point(117, 132);
            this.kryptonPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPictureBox1.Name = "kryptonPictureBox1";
            this.kryptonPictureBox1.Size = new System.Drawing.Size(532, 388);
            this.kryptonPictureBox1.TabIndex = 49;
            this.kryptonPictureBox1.TabStop = false;
            // 
            // acrhiveTablePanel
            // 
            this.acrhiveTablePanel.Controls.Add(this.flowLayoutTablelistExam);
            this.acrhiveTablePanel.Location = new System.Drawing.Point(117, 132);
            this.acrhiveTablePanel.Margin = new System.Windows.Forms.Padding(2);
            this.acrhiveTablePanel.Name = "acrhiveTablePanel";
            this.acrhiveTablePanel.Size = new System.Drawing.Size(532, 388);
            this.acrhiveTablePanel.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.acrhiveTablePanel.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.acrhiveTablePanel.StateCommon.Image = ((System.Drawing.Image)(resources.GetObject("acrhiveTablePanel.StateCommon.Image")));
            this.acrhiveTablePanel.TabIndex = 50;
            // 
            // flowLayoutTablelistExam
            // 
            this.flowLayoutTablelistExam.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutTablelistExam.Location = new System.Drawing.Point(2, 1);
            this.flowLayoutTablelistExam.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutTablelistExam.Name = "flowLayoutTablelistExam";
            this.flowLayoutTablelistExam.Size = new System.Drawing.Size(530, 385);
            this.flowLayoutTablelistExam.TabIndex = 0;
            // 
            // archivePanel
            // 
            this.archivePanel.Controls.Add(this.acrhiveTablePanel);
            this.archivePanel.Controls.Add(this.kryptonPictureBox1);
            this.archivePanel.Controls.Add(this.kryptonPictureBox4);
            this.archivePanel.Location = new System.Drawing.Point(292, 140);
            this.archivePanel.Margin = new System.Windows.Forms.Padding(2);
            this.archivePanel.Name = "archivePanel";
            this.archivePanel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.FormCustom1;
            this.archivePanel.Size = new System.Drawing.Size(767, 564);
            this.archivePanel.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.archivePanel.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.archivePanel.StateCommon.Image = ((System.Drawing.Image)(resources.GetObject("archivePanel.StateCommon.Image")));
            this.archivePanel.StateCommon.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.archivePanel.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.archivePanel.StateDisabled.Draw = Krypton.Toolkit.InheritBool.True;
            this.archivePanel.TabIndex = 40;
            // 
            // profileViewBtn
            // 
            this.profileViewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileViewBtn.FlatAppearance.BorderSize = 0;
            this.profileViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileViewBtn.Image = ((System.Drawing.Image)(resources.GetObject("profileViewBtn.Image")));
            this.profileViewBtn.Location = new System.Drawing.Point(71, 185);
            this.profileViewBtn.Margin = new System.Windows.Forms.Padding(2);
            this.profileViewBtn.Name = "profileViewBtn";
            this.profileViewBtn.Size = new System.Drawing.Size(162, 44);
            this.profileViewBtn.TabIndex = 45;
            this.profileViewBtn.UseVisualStyleBackColor = true;
            this.profileViewBtn.Click += new System.EventHandler(this.profileViewBtn_Click);
            // 
            // archiveViewBtn
            // 
            this.archiveViewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.archiveViewBtn.FlatAppearance.BorderSize = 0;
            this.archiveViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.archiveViewBtn.Image = ((System.Drawing.Image)(resources.GetObject("archiveViewBtn.Image")));
            this.archiveViewBtn.Location = new System.Drawing.Point(72, 233);
            this.archiveViewBtn.Margin = new System.Windows.Forms.Padding(2);
            this.archiveViewBtn.Name = "archiveViewBtn";
            this.archiveViewBtn.Size = new System.Drawing.Size(161, 43);
            this.archiveViewBtn.TabIndex = 46;
            this.archiveViewBtn.UseVisualStyleBackColor = true;
            this.archiveViewBtn.Click += new System.EventHandler(this.archiveViewBtn_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1162, 733);
            this.Controls.Add(this.archiveViewBtn);
            this.Controls.Add(this.profileViewBtn);
            this.Controls.Add(this.archivePanel);
            this.Controls.Add(this.backToDashboardBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.account_type);
            this.Controls.Add(this.user_id);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.profilePanel);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePanel)).EndInit();
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Program_Combo_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfpbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acrhiveTablePanel)).EndInit();
            this.acrhiveTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.archivePanel)).EndInit();
            this.archivePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Timer timer1;
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
        private Krypton.Toolkit.KryptonPanel profilePanel;
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
        private KryptonButton logoutBtn;
        private KryptonButton backToDashboardBtn;
        private KryptonPictureBox kryptonPictureBox4;
        private KryptonPictureBox kryptonPictureBox1;
        private KryptonPanel acrhiveTablePanel;
        private FlowLayoutPanel flowLayoutTablelistExam;
        private KryptonPanel archivePanel;
        private Button profileViewBtn;
        private Button archiveViewBtn;
    }
}