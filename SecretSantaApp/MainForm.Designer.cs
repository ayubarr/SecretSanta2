namespace SecretSantaApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundPicture = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnKnowVictim = new System.Windows.Forms.Button();
            this.btnFindAll = new System.Windows.Forms.Button();
            this.btnShowAllPlayers = new System.Windows.Forms.Button();
            this.btnCredits = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.userContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.initBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userContextBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.btnDeleteEntity = new System.Windows.Forms.Button();
            this.btnRenameEntity = new System.Windows.Forms.Button();
            this.lblSelectedName = new System.Windows.Forms.Label();
            this.textBoxRenameUser = new System.Windows.Forms.TextBox();
            this.lblRenameTipNote = new System.Windows.Forms.Label();
            this.btnSaveRename = new System.Windows.Forms.Button();
            this.btnAddEntity = new System.Windows.Forms.Button();
            this.btnCreateEntity = new System.Windows.Forms.Button();
            this.lblExistingName = new System.Windows.Forms.Label();
            this.lblEmptyName = new System.Windows.Forms.Label();
            this.textBoxNameInput = new System.Windows.Forms.TextBox();
            this.lblNameInput = new System.Windows.Forms.Label();
            this.btnNameInput = new System.Windows.Forms.Button();
            this.lblVictimTitle = new System.Windows.Forms.Label();
            this.lblVictimName = new System.Windows.Forms.Label();
            this.btnGenerateList = new System.Windows.Forms.Button();
            this.listBoxFindAll = new System.Windows.Forms.ListBox();
            this.btnRefreshFindAll = new System.Windows.Forms.Button();
            this.btnExportInTxt = new System.Windows.Forms.Button();
            this.lblInfoSaved = new System.Windows.Forms.Label();
            this.lblInfoSavedTip = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.lblSettingsTitle = new System.Windows.Forms.Label();
            this.lblSettingsMadeBy = new System.Windows.Forms.Label();
            this.lblSettingsCredits = new System.Windows.Forms.Label();
            this.lblEmil = new System.Windows.Forms.Label();
            this.lblAyub = new System.Windows.Forms.Label();
            this.lblNameEmil = new System.Windows.Forms.Label();
            this.lblNameAyub = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userContextBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userContextBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundPicture
            // 
            this.backgroundPicture.BackColor = System.Drawing.Color.LightGray;
            this.backgroundPicture.Image = global::SecretSantaApp.Properties.Resources.MainPagePic;
            this.backgroundPicture.Location = new System.Drawing.Point(0, -1);
            this.backgroundPicture.Name = "backgroundPicture";
            this.backgroundPicture.Size = new System.Drawing.Size(1020, 662);
            this.backgroundPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.backgroundPicture.TabIndex = 0;
            this.backgroundPicture.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.BackColor = System.Drawing.Color.LightGray;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(352, 184);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(262, 107);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome to the Secret Santa";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKnowVictim
            // 
            this.btnKnowVictim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnKnowVictim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKnowVictim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKnowVictim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKnowVictim.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKnowVictim.Location = new System.Drawing.Point(121, 528);
            this.btnKnowVictim.Name = "btnKnowVictim";
            this.btnKnowVictim.Size = new System.Drawing.Size(166, 65);
            this.btnKnowVictim.TabIndex = 2;
            this.btnKnowVictim.Text = "Know your victim";
            this.btnKnowVictim.UseVisualStyleBackColor = false;
            this.btnKnowVictim.Click += new System.EventHandler(this.btnKnowVictim_Click);
            this.btnKnowVictim.MouseLeave += new System.EventHandler(this.btnKnowVictim_MouseLeave);
            this.btnKnowVictim.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnKnowVictim_MouseMove);
            // 
            // btnFindAll
            // 
            this.btnFindAll.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFindAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindAll.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFindAll.Location = new System.Drawing.Point(352, 528);
            this.btnFindAll.Name = "btnFindAll";
            this.btnFindAll.Size = new System.Drawing.Size(127, 66);
            this.btnFindAll.TabIndex = 3;
            this.btnFindAll.Text = "Canadian Orgy";
            this.btnFindAll.UseVisualStyleBackColor = false;
            this.btnFindAll.Click += new System.EventHandler(this.btnFindAll_Click);
            this.btnFindAll.MouseLeave += new System.EventHandler(this.btnFindAll_MouseLeave);
            this.btnFindAll.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnFindAll_MouseMove);
            // 
            // btnShowAllPlayers
            // 
            this.btnShowAllPlayers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowAllPlayers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowAllPlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAllPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllPlayers.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowAllPlayers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowAllPlayers.Location = new System.Drawing.Point(611, 528);
            this.btnShowAllPlayers.Name = "btnShowAllPlayers";
            this.btnShowAllPlayers.Size = new System.Drawing.Size(127, 66);
            this.btnShowAllPlayers.TabIndex = 4;
            this.btnShowAllPlayers.Text = "Show Cutie Pies";
            this.btnShowAllPlayers.UseVisualStyleBackColor = false;
            this.btnShowAllPlayers.Click += new System.EventHandler(this.btnShowAllPlayers_Click);
            this.btnShowAllPlayers.MouseLeave += new System.EventHandler(this.btnShowAllPlayers_MouseLeave);
            this.btnShowAllPlayers.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnShowAllPlayers_MouseMove);
            // 
            // btnCredits
            // 
            this.btnCredits.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCredits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCredits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCredits.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCredits.Location = new System.Drawing.Point(856, 528);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(112, 66);
            this.btnCredits.TabIndex = 5;
            this.btnCredits.Text = "CREDITS";
            this.btnCredits.UseVisualStyleBackColor = false;
            this.btnCredits.Click += new System.EventHandler(this.btnCredits_Click);
            this.btnCredits.MouseLeave += new System.EventHandler(this.btnCredits_MouseLeave);
            this.btnCredits.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCredits_MouseMove);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(0, 239);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 61);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Microsoft New Tai Lue", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(0, 172);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(136, 61);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(SecretSantaApp.User);
            // 
            // userContextBindingSource1
            // 
            this.userContextBindingSource1.DataSource = typeof(SecretSantaApp.UserContext);
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxUsers.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 38;
            this.listBoxUsers.Location = new System.Drawing.Point(245, 33);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(321, 536);
            this.listBoxUsers.TabIndex = 9;
            this.listBoxUsers.Visible = false;
            this.listBoxUsers.SelectedIndexChanged += new System.EventHandler(this.listBoxUsers_SelectedIndexChanged);
            // 
            // btnDeleteEntity
            // 
            this.btnDeleteEntity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEntity.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteEntity.Location = new System.Drawing.Point(839, 109);
            this.btnDeleteEntity.Name = "btnDeleteEntity";
            this.btnDeleteEntity.Size = new System.Drawing.Size(141, 34);
            this.btnDeleteEntity.TabIndex = 10;
            this.btnDeleteEntity.Text = "Delete Player";
            this.btnDeleteEntity.UseVisualStyleBackColor = true;
            this.btnDeleteEntity.Visible = false;
            this.btnDeleteEntity.Click += new System.EventHandler(this.btnDeleteEntity_Click);
            // 
            // btnRenameEntity
            // 
            this.btnRenameEntity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRenameEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenameEntity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRenameEntity.Location = new System.Drawing.Point(663, 110);
            this.btnRenameEntity.Name = "btnRenameEntity";
            this.btnRenameEntity.Size = new System.Drawing.Size(141, 34);
            this.btnRenameEntity.TabIndex = 11;
            this.btnRenameEntity.Text = "Rename Player";
            this.btnRenameEntity.UseVisualStyleBackColor = true;
            this.btnRenameEntity.Visible = false;
            this.btnRenameEntity.Click += new System.EventHandler(this.btnRenameEntity_Click);
            // 
            // lblSelectedName
            // 
            this.lblSelectedName.AutoSize = true;
            this.lblSelectedName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(150)))), ((int)(((byte)(13)))));
            this.lblSelectedName.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedName.Location = new System.Drawing.Point(663, 53);
            this.lblSelectedName.Name = "lblSelectedName";
            this.lblSelectedName.Size = new System.Drawing.Size(0, 38);
            this.lblSelectedName.TabIndex = 12;
            this.lblSelectedName.Visible = false;
            // 
            // textBoxRenameUser
            // 
            this.textBoxRenameUser.AcceptsReturn = true;
            this.textBoxRenameUser.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxRenameUser.Location = new System.Drawing.Point(663, 53);
            this.textBoxRenameUser.Name = "textBoxRenameUser";
            this.textBoxRenameUser.Size = new System.Drawing.Size(317, 47);
            this.textBoxRenameUser.TabIndex = 13;
            this.textBoxRenameUser.Visible = false;
            // 
            // lblRenameTipNote
            // 
            this.lblRenameTipNote.AutoSize = true;
            this.lblRenameTipNote.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblRenameTipNote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRenameTipNote.Location = new System.Drawing.Point(677, 103);
            this.lblRenameTipNote.Name = "lblRenameTipNote";
            this.lblRenameTipNote.Size = new System.Drawing.Size(291, 20);
            this.lblRenameTipNote.TabIndex = 14;
            this.lblRenameTipNote.Text = "Enter new name and press button below";
            this.lblRenameTipNote.Visible = false;
            // 
            // btnSaveRename
            // 
            this.btnSaveRename.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveRename.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveRename.Location = new System.Drawing.Point(744, 149);
            this.btnSaveRename.Name = "btnSaveRename";
            this.btnSaveRename.Size = new System.Drawing.Size(147, 72);
            this.btnSaveRename.TabIndex = 15;
            this.btnSaveRename.Text = "Save";
            this.btnSaveRename.UseVisualStyleBackColor = true;
            this.btnSaveRename.Visible = false;
            this.btnSaveRename.Click += new System.EventHandler(this.btnSaveRename_Click);
            // 
            // btnAddEntity
            // 
            this.btnAddEntity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEntity.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddEntity.Location = new System.Drawing.Point(663, 149);
            this.btnAddEntity.Name = "btnAddEntity";
            this.btnAddEntity.Size = new System.Drawing.Size(317, 35);
            this.btnAddEntity.TabIndex = 16;
            this.btnAddEntity.Text = "Add Player";
            this.btnAddEntity.UseVisualStyleBackColor = true;
            this.btnAddEntity.Visible = false;
            this.btnAddEntity.Click += new System.EventHandler(this.btnAddEntity_Click);
            // 
            // btnCreateEntity
            // 
            this.btnCreateEntity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateEntity.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateEntity.Location = new System.Drawing.Point(744, 129);
            this.btnCreateEntity.Name = "btnCreateEntity";
            this.btnCreateEntity.Size = new System.Drawing.Size(147, 55);
            this.btnCreateEntity.TabIndex = 17;
            this.btnCreateEntity.Text = "Create!";
            this.btnCreateEntity.UseVisualStyleBackColor = true;
            this.btnCreateEntity.Visible = false;
            this.btnCreateEntity.Click += new System.EventHandler(this.btnCreateEntity_Click);
            // 
            // lblExistingName
            // 
            this.lblExistingName.AutoSize = true;
            this.lblExistingName.BackColor = System.Drawing.Color.IndianRed;
            this.lblExistingName.Location = new System.Drawing.Point(663, 33);
            this.lblExistingName.Name = "lblExistingName";
            this.lblExistingName.Size = new System.Drawing.Size(183, 20);
            this.lblExistingName.TabIndex = 18;
            this.lblExistingName.Text = "This name is already exists";
            this.lblExistingName.Visible = false;
            // 
            // lblEmptyName
            // 
            this.lblEmptyName.AutoSize = true;
            this.lblEmptyName.BackColor = System.Drawing.Color.IndianRed;
            this.lblEmptyName.Location = new System.Drawing.Point(663, 33);
            this.lblEmptyName.Name = "lblEmptyName";
            this.lblEmptyName.Size = new System.Drawing.Size(165, 20);
            this.lblEmptyName.TabIndex = 19;
            this.lblEmptyName.Text = "Name cannot be empty";
            this.lblEmptyName.Visible = false;
            // 
            // textBoxNameInput
            // 
            this.textBoxNameInput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNameInput.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxNameInput.Location = new System.Drawing.Point(245, 66);
            this.textBoxNameInput.Name = "textBoxNameInput";
            this.textBoxNameInput.Size = new System.Drawing.Size(547, 38);
            this.textBoxNameInput.TabIndex = 20;
            this.textBoxNameInput.Visible = false;
            // 
            // lblNameInput
            // 
            this.lblNameInput.AutoSize = true;
            this.lblNameInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNameInput.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameInput.Location = new System.Drawing.Point(380, 16);
            this.lblNameInput.Name = "lblNameInput";
            this.lblNameInput.Size = new System.Drawing.Size(290, 43);
            this.lblNameInput.TabIndex = 21;
            this.lblNameInput.Text = "INPUT YOUR NAME";
            this.lblNameInput.Visible = false;
            // 
            // btnNameInput
            // 
            this.btnNameInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNameInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNameInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNameInput.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNameInput.Location = new System.Drawing.Point(798, 66);
            this.btnNameInput.Name = "btnNameInput";
            this.btnNameInput.Size = new System.Drawing.Size(75, 38);
            this.btnNameInput.TabIndex = 22;
            this.btnNameInput.Text = "DONE";
            this.btnNameInput.UseVisualStyleBackColor = false;
            this.btnNameInput.Visible = false;
            this.btnNameInput.Click += new System.EventHandler(this.btnNameInput_Click);
            // 
            // lblVictimTitle
            // 
            this.lblVictimTitle.AutoSize = true;
            this.lblVictimTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVictimTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVictimTitle.Location = new System.Drawing.Point(367, 33);
            this.lblVictimTitle.Name = "lblVictimTitle";
            this.lblVictimTitle.Size = new System.Drawing.Size(322, 52);
            this.lblVictimTitle.TabIndex = 23;
            this.lblVictimTitle.Text = "YOUR VICTIM IS...";
            this.lblVictimTitle.Visible = false;
            // 
            // lblVictimName
            // 
            this.lblVictimName.AutoSize = true;
            this.lblVictimName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblVictimName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVictimName.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVictimName.Location = new System.Drawing.Point(296, 528);
            this.lblVictimName.Name = "lblVictimName";
            this.lblVictimName.Size = new System.Drawing.Size(316, 64);
            this.lblVictimName.TabIndex = 24;
            this.lblVictimName.Text = "victim\'sName";
            this.lblVictimName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVictimName.Visible = false;
            // 
            // btnGenerateList
            // 
            this.btnGenerateList.BackColor = System.Drawing.Color.LightCoral;
            this.btnGenerateList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateList.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerateList.Location = new System.Drawing.Point(270, 135);
            this.btnGenerateList.Name = "btnGenerateList";
            this.btnGenerateList.Size = new System.Drawing.Size(507, 321);
            this.btnGenerateList.TabIndex = 25;
            this.btnGenerateList.Text = "GENERATE LIST";
            this.btnGenerateList.UseVisualStyleBackColor = false;
            this.btnGenerateList.Visible = false;
            this.btnGenerateList.Click += new System.EventHandler(this.btnGenerateList_Click);
            // 
            // listBoxFindAll
            // 
            this.listBoxFindAll.BackColor = System.Drawing.Color.Salmon;
            this.listBoxFindAll.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxFindAll.FormattingEnabled = true;
            this.listBoxFindAll.ItemHeight = 34;
            this.listBoxFindAll.Location = new System.Drawing.Point(212, 12);
            this.listBoxFindAll.Name = "listBoxFindAll";
            this.listBoxFindAll.Size = new System.Drawing.Size(538, 548);
            this.listBoxFindAll.TabIndex = 26;
            this.listBoxFindAll.Visible = false;
            // 
            // btnRefreshFindAll
            // 
            this.btnRefreshFindAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshFindAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshFindAll.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefreshFindAll.Location = new System.Drawing.Point(834, 24);
            this.btnRefreshFindAll.Name = "btnRefreshFindAll";
            this.btnRefreshFindAll.Size = new System.Drawing.Size(146, 80);
            this.btnRefreshFindAll.TabIndex = 27;
            this.btnRefreshFindAll.Text = "SHUFFLE";
            this.btnRefreshFindAll.UseVisualStyleBackColor = true;
            this.btnRefreshFindAll.Visible = false;
            this.btnRefreshFindAll.Click += new System.EventHandler(this.btnRefreshFindAll_Click);
            // 
            // btnExportInTxt
            // 
            this.btnExportInTxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExportInTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportInTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportInTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExportInTxt.Location = new System.Drawing.Point(834, 155);
            this.btnExportInTxt.Name = "btnExportInTxt";
            this.btnExportInTxt.Size = new System.Drawing.Size(146, 66);
            this.btnExportInTxt.TabIndex = 28;
            this.btnExportInTxt.Text = "EXPORT";
            this.btnExportInTxt.UseVisualStyleBackColor = false;
            this.btnExportInTxt.Visible = false;
            this.btnExportInTxt.Click += new System.EventHandler(this.btnExportInTxt_Click);
            // 
            // lblInfoSaved
            // 
            this.lblInfoSaved.AutoSize = true;
            this.lblInfoSaved.BackColor = System.Drawing.Color.PaleGreen;
            this.lblInfoSaved.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfoSaved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInfoSaved.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfoSaved.Location = new System.Drawing.Point(810, 234);
            this.lblInfoSaved.Name = "lblInfoSaved";
            this.lblInfoSaved.Size = new System.Drawing.Size(202, 22);
            this.lblInfoSaved.TabIndex = 29;
            this.lblInfoSaved.Text = "INFO SAVED SUCCESSFULLY";
            this.lblInfoSaved.Visible = false;
            // 
            // lblInfoSavedTip
            // 
            this.lblInfoSavedTip.AutoSize = true;
            this.lblInfoSavedTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfoSavedTip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInfoSavedTip.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfoSavedTip.Location = new System.Drawing.Point(756, 269);
            this.lblInfoSavedTip.Name = "lblInfoSavedTip";
            this.lblInfoSavedTip.Size = new System.Drawing.Size(264, 19);
            this.lblInfoSavedTip.TabIndex = 30;
            this.lblInfoSavedTip.Text = "The file has been created on your DESKTOP";
            this.lblInfoSavedTip.Visible = false;
            // 
            // btnSort
            // 
            this.btnSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSort.Location = new System.Drawing.Point(744, 380);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(147, 67);
            this.btnSort.TabIndex = 31;
            this.btnSort.Text = "SORT cuties";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Visible = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lblSettingsTitle
            // 
            this.lblSettingsTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(74)))));
            this.lblSettingsTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSettingsTitle.Location = new System.Drawing.Point(648, 16);
            this.lblSettingsTitle.Name = "lblSettingsTitle";
            this.lblSettingsTitle.Size = new System.Drawing.Size(261, 41);
            this.lblSettingsTitle.TabIndex = 32;
            this.lblSettingsTitle.Text = "Powered by WinForms";
            this.lblSettingsTitle.Visible = false;
            // 
            // lblSettingsMadeBy
            // 
            this.lblSettingsMadeBy.AutoSize = true;
            this.lblSettingsMadeBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(74)))));
            this.lblSettingsMadeBy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblSettingsMadeBy.Location = new System.Drawing.Point(648, 53);
            this.lblSettingsMadeBy.Name = "lblSettingsMadeBy";
            this.lblSettingsMadeBy.Size = new System.Drawing.Size(183, 23);
            this.lblSettingsMadeBy.TabIndex = 33;
            this.lblSettingsMadeBy.Text = "Made by Emil and Ayub";
            this.lblSettingsMadeBy.Visible = false;
            // 
            // lblSettingsCredits
            // 
            this.lblSettingsCredits.AutoSize = true;
            this.lblSettingsCredits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(74)))));
            this.lblSettingsCredits.Font = new System.Drawing.Font("Segoe UI Semibold", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSettingsCredits.Location = new System.Drawing.Point(245, 53);
            this.lblSettingsCredits.Name = "lblSettingsCredits";
            this.lblSettingsCredits.Size = new System.Drawing.Size(260, 30);
            this.lblSettingsCredits.TabIndex = 34;
            this.lblSettingsCredits.Text = "Главные Разработчики: ";
            this.lblSettingsCredits.Visible = false;
            // 
            // lblEmil
            // 
            this.lblEmil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(74)))));
            this.lblEmil.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmil.Location = new System.Drawing.Point(363, 167);
            this.lblEmil.Name = "lblEmil";
            this.lblEmil.Size = new System.Drawing.Size(142, 121);
            this.lblEmil.TabIndex = 35;
            this.lblEmil.Text = "Написание Бэка и основной логики, подключение и работа локальной базы данных на  " +
    "Entity Framework";
            this.lblEmil.Visible = false;
            // 
            // lblAyub
            // 
            this.lblAyub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(74)))));
            this.lblAyub.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAyub.Location = new System.Drawing.Point(523, 155);
            this.lblAyub.Name = "lblAyub";
            this.lblAyub.Size = new System.Drawing.Size(158, 153);
            this.lblAyub.TabIndex = 36;
            this.lblAyub.Text = "Написание Фронта и настройка элементов управления, Работа над Ресурсами программы" +
    " в Adobe Photoshop";
            this.lblAyub.Visible = false;
            // 
            // lblNameEmil
            // 
            this.lblNameEmil.AutoSize = true;
            this.lblNameEmil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(74)))));
            this.lblNameEmil.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameEmil.Location = new System.Drawing.Point(363, 144);
            this.lblNameEmil.Name = "lblNameEmil";
            this.lblNameEmil.Size = new System.Drawing.Size(154, 23);
            this.lblNameEmil.TabIndex = 37;
            this.lblNameEmil.Text = "Эмиль Абдуллаев";
            this.lblNameEmil.Visible = false;
            // 
            // lblNameAyub
            // 
            this.lblNameAyub.AutoSize = true;
            this.lblNameAyub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(74)))));
            this.lblNameAyub.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameAyub.Location = new System.Drawing.Point(523, 127);
            this.lblNameAyub.Name = "lblNameAyub";
            this.lblNameAyub.Size = new System.Drawing.Size(131, 28);
            this.lblNameAyub.TabIndex = 38;
            this.lblNameAyub.Text = "Аюб Арбиев";
            this.lblNameAyub.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 658);
            this.Controls.Add(this.lblNameAyub);
            this.Controls.Add(this.lblNameEmil);
            this.Controls.Add(this.lblAyub);
            this.Controls.Add(this.lblEmil);
            this.Controls.Add(this.lblSettingsCredits);
            this.Controls.Add(this.lblSettingsMadeBy);
            this.Controls.Add(this.lblSettingsTitle);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lblInfoSavedTip);
            this.Controls.Add(this.lblInfoSaved);
            this.Controls.Add(this.btnExportInTxt);
            this.Controls.Add(this.btnRefreshFindAll);
            this.Controls.Add(this.btnGenerateList);
            this.Controls.Add(this.btnCredits);
            this.Controls.Add(this.btnShowAllPlayers);
            this.Controls.Add(this.btnKnowVictim);
            this.Controls.Add(this.btnFindAll);
            this.Controls.Add(this.lblVictimName);
            this.Controls.Add(this.lblVictimTitle);
            this.Controls.Add(this.btnNameInput);
            this.Controls.Add(this.lblNameInput);
            this.Controls.Add(this.textBoxNameInput);
            this.Controls.Add(this.lblEmptyName);
            this.Controls.Add(this.lblExistingName);
            this.Controls.Add(this.btnCreateEntity);
            this.Controls.Add(this.btnAddEntity);
            this.Controls.Add(this.btnSaveRename);
            this.Controls.Add(this.lblSelectedName);
            this.Controls.Add(this.btnDeleteEntity);
            this.Controls.Add(this.btnRenameEntity);
            this.Controls.Add(this.lblRenameTipNote);
            this.Controls.Add(this.textBoxRenameUser);
            this.Controls.Add(this.listBoxUsers);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.listBoxFindAll);
            this.Controls.Add(this.backgroundPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Secret Santa 😊🎄";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userContextBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userContextBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox backgroundPicture;
        private Label lblTitle;
        private Button btnKnowVictim;
        private Button btnFindAll;
        private Button btnShowAllPlayers;
        private Button btnCredits;
        private Button btnExit;
        private Button btnBack;
        private BindingSource userContextBindingSource;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private BindingSource userBindingSource;
        private BindingSource initBindingSource;
        private BindingSource userContextBindingSource1;
        private ListBox listBoxUsers;
        private Button btnDeleteEntity;
        private Button btnRenameEntity;
        private Label lblSelectedName;
        private TextBox textBoxRenameUser;
        private Label lblRenameTipNote;
        private Button btnSaveRename;
        private Button btnAddEntity;
        private Button btnCreateEntity;
        private Label lblExistingName;
        private Label lblEmptyName;
        private TextBox textBoxNameInput;
        private Label lblNameInput;
        private Button btnNameInput;
        private Label lblVictimTitle;
        private Label lblVictimName;
        private Button btnGenerateList;
        private ListBox listBoxFindAll;
        private Button btnRefreshFindAll;
        private Button btnExportInTxt;
        private Label lblInfoSaved;
        private Label lblInfoSavedTip;
        private Button btnSort;
        private Label lblSettingsTitle;
        private Label lblSettingsMadeBy;
        private Label lblSettingsCredits;
        private Label lblEmil;
        private Label lblAyub;
        private Label lblNameEmil;
        private Label lblNameAyub;
    }
}