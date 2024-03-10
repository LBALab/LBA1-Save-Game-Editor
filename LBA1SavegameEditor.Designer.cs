namespace LBA1_Save_Game_Editor
{
    partial class LBA1SavegameEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LBA1SavegameEditor));
            menuStrip1 = new MenuStrip();
            openToolStripMenuItem1 = new ToolStripMenuItem();
            reloadToolStripMenuItem = new ToolStripMenuItem();
            blackToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem1 = new ToolStripMenuItem();
            changeSaveDirectoryToolStripMenuItem = new ToolStripMenuItem();
            tcMain = new TabControl();
            tpMain = new TabPage();
            gbChapterJump = new GroupBox();
            btnChapterMin = new Button();
            btnChapterMax = new Button();
            cboSelectChapter = new ComboBox();
            gbMaxAll = new GroupBox();
            btnMaxQuest = new Button();
            btnMaxInvUsed = new Button();
            btnMaxInv = new Button();
            btnMaxBasic = new Button();
            gbQuestFlags = new GroupBox();
            txtQuestFilter = new TextBox();
            lblQuestFilter = new Label();
            clbQuestFlag = new CheckedListBox();
            gbInventory = new GroupBox();
            lblInventoryFilter = new Label();
            txtInventoryFilter = new TextBox();
            clbInventoryUsed = new CheckedListBox();
            clbInventory = new CheckedListBox();
            gbBasicStats = new GroupBox();
            lblGas = new Label();
            lblKashes = new Label();
            txtKashes = new TextBox();
            txtGas = new TextBox();
            lblHealth = new Label();
            lblMagicPoints = new Label();
            lblMagicLevel = new Label();
            lblClovers = new Label();
            lblCloverBoxes = new Label();
            txtHealth = new TextBox();
            txtMagicLevel = new TextBox();
            txtCloverBox = new TextBox();
            txtClovers = new TextBox();
            txtMagicPoints = new TextBox();
            gbFileProperties = new GroupBox();
            cboFileFormatVersion = new ComboBox();
            lblVersion = new Label();
            chkReadOnly = new CheckBox();
            lblReadOnly = new Label();
            txtInternalFileName = new TextBox();
            txtPhysicalFileName = new TextBox();
            lblInternalName = new Label();
            lblPhysicalFileName = new Label();
            tpOther = new TabPage();
            gbHolomap = new GroupBox();
            cboHolomap = new ComboBox();
            lblLocation = new Label();
            chkHoloBit8 = new CheckBox();
            chkHoloBit7 = new CheckBox();
            chkHoloBit6 = new CheckBox();
            chkHoloBit5 = new CheckBox();
            chkHoloBit4 = new CheckBox();
            chkHoloBit3 = new CheckBox();
            chkHoloBit2 = new CheckBox();
            chkHoloBit1 = new CheckBox();
            gbPosition = new GroupBox();
            lblHorizontalPos = new Label();
            lblHeight = new Label();
            lblVerticalPos = new Label();
            lblFacing = new Label();
            txtFacing = new TextBox();
            txtHeight = new TextBox();
            txtHorizontalPos = new TextBox();
            txtVerticalPos = new TextBox();
            gbMisc = new GroupBox();
            cboAreacode = new ComboBox();
            lblAreacode = new Label();
            lblChapter = new Label();
            cboChapter = new ComboBox();
            lblBehaviour = new Label();
            cboBehaviour = new ComboBox();
            lblOutfit = new Label();
            cboOutfit = new ComboBox();
            lblSelectedWeapon = new Label();
            cboSelectedWeapon = new ComboBox();
            gbMovies = new GroupBox();
            clbMovies = new CheckedListBox();
            lblInfo = new Label();
            lblInfoText = new Label();
            menuStrip1.SuspendLayout();
            tcMain.SuspendLayout();
            tpMain.SuspendLayout();
            gbChapterJump.SuspendLayout();
            gbMaxAll.SuspendLayout();
            gbQuestFlags.SuspendLayout();
            gbInventory.SuspendLayout();
            gbBasicStats.SuspendLayout();
            gbFileProperties.SuspendLayout();
            tpOther.SuspendLayout();
            gbHolomap.SuspendLayout();
            gbPosition.SuspendLayout();
            gbMisc.SuspendLayout();
            gbMovies.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { openToolStripMenuItem1, reloadToolStripMenuItem, blackToolStripMenuItem, saveToolStripMenuItem1, changeSaveDirectoryToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(905, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem1
            // 
            openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            openToolStripMenuItem1.Size = new Size(48, 20);
            openToolStripMenuItem1.Text = "&Open";
            openToolStripMenuItem1.Click += openToolStripMenuItem_Click;
            // 
            // reloadToolStripMenuItem
            // 
            reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            reloadToolStripMenuItem.Size = new Size(79, 20);
            reloadToolStripMenuItem.Text = "&Reload Last";
            reloadToolStripMenuItem.Click += reloadToolStripMenuItem_Click;
            // 
            // blackToolStripMenuItem
            // 
            blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            blackToolStripMenuItem.Size = new Size(80, 20);
            blackToolStripMenuItem.Text = "Create &New";
            blackToolStripMenuItem.Click += blackToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem1
            // 
            saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            saveToolStripMenuItem1.Size = new Size(43, 20);
            saveToolStripMenuItem1.Text = "&Save";
            saveToolStripMenuItem1.Click += saveToolStripMenuItem1_Click;
            // 
            // changeSaveDirectoryToolStripMenuItem
            // 
            changeSaveDirectoryToolStripMenuItem.Name = "changeSaveDirectoryToolStripMenuItem";
            changeSaveDirectoryToolStripMenuItem.Size = new Size(138, 20);
            changeSaveDirectoryToolStripMenuItem.Text = "&Change Save Directory";
            changeSaveDirectoryToolStripMenuItem.Click += changeSaveDirectoryToolStripMenuItem_Click;
            // 
            // tcMain
            // 
            tcMain.Controls.Add(tpMain);
            tcMain.Controls.Add(tpOther);
            tcMain.Location = new Point(5, 29);
            tcMain.Name = "tcMain";
            tcMain.SelectedIndex = 0;
            tcMain.Size = new Size(893, 432);
            tcMain.TabIndex = 0;
            // 
            // tpMain
            // 
            tpMain.BackColor = Color.LavenderBlush;
            tpMain.Controls.Add(gbChapterJump);
            tpMain.Controls.Add(gbMaxAll);
            tpMain.Controls.Add(gbQuestFlags);
            tpMain.Controls.Add(gbInventory);
            tpMain.Controls.Add(gbBasicStats);
            tpMain.Controls.Add(gbFileProperties);
            tpMain.Location = new Point(4, 24);
            tpMain.Name = "tpMain";
            tpMain.Padding = new Padding(3);
            tpMain.Size = new Size(885, 404);
            tpMain.TabIndex = 0;
            tpMain.Text = "Main";
            // 
            // gbChapterJump
            // 
            gbChapterJump.BackColor = Color.FloralWhite;
            gbChapterJump.Controls.Add(btnChapterMin);
            gbChapterJump.Controls.Add(btnChapterMax);
            gbChapterJump.Controls.Add(cboSelectChapter);
            gbChapterJump.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbChapterJump.Location = new Point(385, 347);
            gbChapterJump.Name = "gbChapterJump";
            gbChapterJump.Size = new Size(488, 49);
            gbChapterJump.TabIndex = 24;
            gbChapterJump.TabStop = false;
            gbChapterJump.Text = "Jump to Chapter with Items/Quests";
            // 
            // btnChapterMin
            // 
            btnChapterMin.Location = new Point(398, 18);
            btnChapterMin.Name = "btnChapterMin";
            btnChapterMin.Size = new Size(85, 25);
            btnChapterMin.TabIndex = 5;
            btnChapterMin.Text = "Min";
            btnChapterMin.UseVisualStyleBackColor = true;
            btnChapterMin.Click += btnChapterMin_Click;
            // 
            // btnChapterMax
            // 
            btnChapterMax.Location = new Point(307, 18);
            btnChapterMax.Name = "btnChapterMax";
            btnChapterMax.Size = new Size(85, 25);
            btnChapterMax.TabIndex = 4;
            btnChapterMax.Text = "Max";
            btnChapterMax.UseVisualStyleBackColor = true;
            btnChapterMax.Click += btnChapterMax_Click;
            // 
            // cboSelectChapter
            // 
            cboSelectChapter.FormattingEnabled = true;
            cboSelectChapter.Items.AddRange(new object[] { "00   Still inside Citadel", "01   Exited Citadel", "02   Zoe Captured\t", "03   Found Tunic", "04   Boarded Ferry at Citadel Port", "05   Spoke to Astronomer", "06   Picked up book of BU", "07   Read slate about Le Bourgne under Twinsen's House", "08   Stole Pirates Flag", "09   Picked up key from chest in museum.", "10", "11", "12", "13   Fortress island: Spoke to Rabbi-bunny.", "14   Stole FunFrocks sabre", "15   Took architechs pass" });
            cboSelectChapter.Location = new Point(6, 20);
            cboSelectChapter.Name = "cboSelectChapter";
            cboSelectChapter.Size = new Size(295, 23);
            cboSelectChapter.TabIndex = 3;
            // 
            // gbMaxAll
            // 
            gbMaxAll.BackColor = Color.FloralWhite;
            gbMaxAll.Controls.Add(btnMaxQuest);
            gbMaxAll.Controls.Add(btnMaxInvUsed);
            gbMaxAll.Controls.Add(btnMaxInv);
            gbMaxAll.Controls.Add(btnMaxBasic);
            gbMaxAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbMaxAll.Location = new Point(6, 305);
            gbMaxAll.Name = "gbMaxAll";
            gbMaxAll.Size = new Size(136, 91);
            gbMaxAll.TabIndex = 23;
            gbMaxAll.TabStop = false;
            gbMaxAll.Text = "Max All";
            // 
            // btnMaxQuest
            // 
            btnMaxQuest.Location = new Point(58, 31);
            btnMaxQuest.Name = "btnMaxQuest";
            btnMaxQuest.Size = new Size(68, 23);
            btnMaxQuest.TabIndex = 3;
            btnMaxQuest.Text = "Quest";
            btnMaxQuest.UseVisualStyleBackColor = true;
            btnMaxQuest.Click += btnMaxQuest_Click;
            // 
            // btnMaxInvUsed
            // 
            btnMaxInvUsed.Location = new Point(58, 60);
            btnMaxInvUsed.Name = "btnMaxInvUsed";
            btnMaxInvUsed.Size = new Size(68, 23);
            btnMaxInvUsed.TabIndex = 2;
            btnMaxInvUsed.Text = "Inv. Used";
            btnMaxInvUsed.UseVisualStyleBackColor = true;
            btnMaxInvUsed.Click += btnMaxInvUsed_Click;
            // 
            // btnMaxInv
            // 
            btnMaxInv.Location = new Point(6, 60);
            btnMaxInv.Name = "btnMaxInv";
            btnMaxInv.Size = new Size(46, 23);
            btnMaxInv.TabIndex = 1;
            btnMaxInv.Text = "Inv.";
            btnMaxInv.UseVisualStyleBackColor = true;
            btnMaxInv.Click += btnMaxInv_Click;
            // 
            // btnMaxBasic
            // 
            btnMaxBasic.Location = new Point(6, 31);
            btnMaxBasic.Name = "btnMaxBasic";
            btnMaxBasic.Size = new Size(46, 23);
            btnMaxBasic.TabIndex = 0;
            btnMaxBasic.Text = "Basic";
            btnMaxBasic.UseVisualStyleBackColor = true;
            btnMaxBasic.Click += btnMaxBasic_Click;
            // 
            // gbQuestFlags
            // 
            gbQuestFlags.BackColor = Color.FloralWhite;
            gbQuestFlags.Controls.Add(txtQuestFilter);
            gbQuestFlags.Controls.Add(lblQuestFilter);
            gbQuestFlags.Controls.Add(clbQuestFlag);
            gbQuestFlags.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbQuestFlags.Location = new Point(385, 71);
            gbQuestFlags.Name = "gbQuestFlags";
            gbQuestFlags.Size = new Size(494, 270);
            gbQuestFlags.TabIndex = 22;
            gbQuestFlags.TabStop = false;
            gbQuestFlags.Text = "Quest Flags";
            // 
            // txtQuestFilter
            // 
            txtQuestFilter.Location = new Point(48, 22);
            txtQuestFilter.Name = "txtQuestFilter";
            txtQuestFilter.Size = new Size(440, 23);
            txtQuestFilter.TabIndex = 15;
            txtQuestFilter.TextChanged += txtQuestFilter_TextChanged;
            // 
            // lblQuestFilter
            // 
            lblQuestFilter.AutoSize = true;
            lblQuestFilter.Location = new Point(6, 28);
            lblQuestFilter.Name = "lblQuestFilter";
            lblQuestFilter.Size = new Size(36, 15);
            lblQuestFilter.TabIndex = 23;
            lblQuestFilter.Text = "Filter";
            // 
            // clbQuestFlag
            // 
            clbQuestFlag.CheckOnClick = true;
            clbQuestFlag.FormattingEnabled = true;
            clbQuestFlag.IntegralHeight = false;
            clbQuestFlag.Location = new Point(6, 51);
            clbQuestFlag.Name = "clbQuestFlag";
            clbQuestFlag.Size = new Size(482, 210);
            clbQuestFlag.TabIndex = 16;
            clbQuestFlag.ItemCheck += clb_ItemCheck;
            // 
            // gbInventory
            // 
            gbInventory.BackColor = Color.FloralWhite;
            gbInventory.Controls.Add(lblInventoryFilter);
            gbInventory.Controls.Add(txtInventoryFilter);
            gbInventory.Controls.Add(clbInventoryUsed);
            gbInventory.Controls.Add(clbInventory);
            gbInventory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbInventory.Location = new Point(152, 71);
            gbInventory.Name = "gbInventory";
            gbInventory.Size = new Size(227, 325);
            gbInventory.TabIndex = 21;
            gbInventory.TabStop = false;
            gbInventory.Text = "Inventory";
            // 
            // lblInventoryFilter
            // 
            lblInventoryFilter.AutoSize = true;
            lblInventoryFilter.Location = new Point(11, 25);
            lblInventoryFilter.Name = "lblInventoryFilter";
            lblInventoryFilter.Size = new Size(36, 15);
            lblInventoryFilter.TabIndex = 24;
            lblInventoryFilter.Text = "Filter";
            // 
            // txtInventoryFilter
            // 
            txtInventoryFilter.Location = new Point(53, 22);
            txtInventoryFilter.Name = "txtInventoryFilter";
            txtInventoryFilter.Size = new Size(168, 23);
            txtInventoryFilter.TabIndex = 12;
            txtInventoryFilter.TextChanged += txtInventoryFilter_TextChanged;
            // 
            // clbInventoryUsed
            // 
            clbInventoryUsed.CheckOnClick = true;
            clbInventoryUsed.FormattingEnabled = true;
            clbInventoryUsed.IntegralHeight = false;
            clbInventoryUsed.Location = new Point(11, 187);
            clbInventoryUsed.Name = "clbInventoryUsed";
            clbInventoryUsed.Size = new Size(210, 130);
            clbInventoryUsed.TabIndex = 14;
            clbInventoryUsed.ItemCheck += clb_ItemCheck;
            // 
            // clbInventory
            // 
            clbInventory.CheckOnClick = true;
            clbInventory.FormattingEnabled = true;
            clbInventory.IntegralHeight = false;
            clbInventory.Location = new Point(11, 51);
            clbInventory.Name = "clbInventory";
            clbInventory.Size = new Size(210, 130);
            clbInventory.TabIndex = 13;
            clbInventory.ItemCheck += clb_ItemCheck;
            // 
            // gbBasicStats
            // 
            gbBasicStats.BackColor = Color.FloralWhite;
            gbBasicStats.Controls.Add(lblGas);
            gbBasicStats.Controls.Add(lblKashes);
            gbBasicStats.Controls.Add(txtKashes);
            gbBasicStats.Controls.Add(txtGas);
            gbBasicStats.Controls.Add(lblHealth);
            gbBasicStats.Controls.Add(lblMagicPoints);
            gbBasicStats.Controls.Add(lblMagicLevel);
            gbBasicStats.Controls.Add(lblClovers);
            gbBasicStats.Controls.Add(lblCloverBoxes);
            gbBasicStats.Controls.Add(txtHealth);
            gbBasicStats.Controls.Add(txtMagicLevel);
            gbBasicStats.Controls.Add(txtCloverBox);
            gbBasicStats.Controls.Add(txtClovers);
            gbBasicStats.Controls.Add(txtMagicPoints);
            gbBasicStats.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbBasicStats.Location = new Point(6, 71);
            gbBasicStats.Name = "gbBasicStats";
            gbBasicStats.Size = new Size(136, 228);
            gbBasicStats.TabIndex = 19;
            gbBasicStats.TabStop = false;
            gbBasicStats.Text = "Basic Stats";
            // 
            // lblGas
            // 
            lblGas.AutoSize = true;
            lblGas.Location = new Point(12, 200);
            lblGas.Name = "lblGas";
            lblGas.Size = new Size(27, 15);
            lblGas.TabIndex = 29;
            lblGas.Text = "Gas";
            // 
            // lblKashes
            // 
            lblKashes.AutoSize = true;
            lblKashes.Location = new Point(12, 171);
            lblKashes.Name = "lblKashes";
            lblKashes.Size = new Size(45, 15);
            lblKashes.TabIndex = 28;
            lblKashes.Text = "Kashes";
            // 
            // txtKashes
            // 
            txtKashes.Location = new Point(98, 168);
            txtKashes.Name = "txtKashes";
            txtKashes.Size = new Size(28, 23);
            txtKashes.TabIndex = 10;
            // 
            // txtGas
            // 
            txtGas.Location = new Point(98, 197);
            txtGas.Name = "txtGas";
            txtGas.Size = new Size(28, 23);
            txtGas.TabIndex = 11;
            // 
            // lblHealth
            // 
            lblHealth.AutoSize = true;
            lblHealth.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHealth.Location = new Point(12, 144);
            lblHealth.Name = "lblHealth";
            lblHealth.Size = new Size(44, 15);
            lblHealth.TabIndex = 27;
            lblHealth.Text = "Health";
            // 
            // lblMagicPoints
            // 
            lblMagicPoints.AutoSize = true;
            lblMagicPoints.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMagicPoints.Location = new Point(12, 115);
            lblMagicPoints.Name = "lblMagicPoints";
            lblMagicPoints.Size = new Size(77, 15);
            lblMagicPoints.TabIndex = 26;
            lblMagicPoints.Text = "Magic Points";
            // 
            // lblMagicLevel
            // 
            lblMagicLevel.AutoSize = true;
            lblMagicLevel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMagicLevel.Location = new Point(12, 86);
            lblMagicLevel.Name = "lblMagicLevel";
            lblMagicLevel.Size = new Size(73, 15);
            lblMagicLevel.TabIndex = 25;
            lblMagicLevel.Text = "Magic Level";
            // 
            // lblClovers
            // 
            lblClovers.AutoSize = true;
            lblClovers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblClovers.Location = new Point(12, 57);
            lblClovers.Name = "lblClovers";
            lblClovers.Size = new Size(48, 15);
            lblClovers.TabIndex = 24;
            lblClovers.Text = "Clovers";
            // 
            // lblCloverBoxes
            // 
            lblCloverBoxes.AutoSize = true;
            lblCloverBoxes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCloverBoxes.Location = new Point(12, 28);
            lblCloverBoxes.Name = "lblCloverBoxes";
            lblCloverBoxes.Size = new Size(80, 15);
            lblCloverBoxes.TabIndex = 23;
            lblCloverBoxes.Text = "Clover Boxes";
            // 
            // txtHealth
            // 
            txtHealth.Location = new Point(98, 139);
            txtHealth.Name = "txtHealth";
            txtHealth.Size = new Size(28, 23);
            txtHealth.TabIndex = 9;
            // 
            // txtMagicLevel
            // 
            txtMagicLevel.Location = new Point(98, 83);
            txtMagicLevel.Name = "txtMagicLevel";
            txtMagicLevel.Size = new Size(28, 23);
            txtMagicLevel.TabIndex = 7;
            // 
            // txtCloverBox
            // 
            txtCloverBox.Location = new Point(98, 25);
            txtCloverBox.Name = "txtCloverBox";
            txtCloverBox.Size = new Size(28, 23);
            txtCloverBox.TabIndex = 5;
            // 
            // txtClovers
            // 
            txtClovers.Location = new Point(98, 54);
            txtClovers.Name = "txtClovers";
            txtClovers.Size = new Size(28, 23);
            txtClovers.TabIndex = 6;
            // 
            // txtMagicPoints
            // 
            txtMagicPoints.Location = new Point(98, 112);
            txtMagicPoints.Name = "txtMagicPoints";
            txtMagicPoints.Size = new Size(28, 23);
            txtMagicPoints.TabIndex = 8;
            // 
            // gbFileProperties
            // 
            gbFileProperties.BackColor = Color.FloralWhite;
            gbFileProperties.Controls.Add(cboFileFormatVersion);
            gbFileProperties.Controls.Add(lblVersion);
            gbFileProperties.Controls.Add(chkReadOnly);
            gbFileProperties.Controls.Add(lblReadOnly);
            gbFileProperties.Controls.Add(txtInternalFileName);
            gbFileProperties.Controls.Add(txtPhysicalFileName);
            gbFileProperties.Controls.Add(lblInternalName);
            gbFileProperties.Controls.Add(lblPhysicalFileName);
            gbFileProperties.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbFileProperties.Location = new Point(6, 6);
            gbFileProperties.Name = "gbFileProperties";
            gbFileProperties.Size = new Size(873, 59);
            gbFileProperties.TabIndex = 12;
            gbFileProperties.TabStop = false;
            gbFileProperties.Text = "File Properties";
            // 
            // cboFileFormatVersion
            // 
            cboFileFormatVersion.FormattingEnabled = true;
            cboFileFormatVersion.Items.AddRange(new object[] { "00", "01", "02", "03", "04", "05" });
            cboFileFormatVersion.Location = new Point(634, 25);
            cboFileFormatVersion.Name = "cboFileFormatVersion";
            cboFileFormatVersion.Size = new Size(46, 23);
            cboFileFormatVersion.TabIndex = 3;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(580, 26);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(48, 15);
            lblVersion.TabIndex = 9;
            lblVersion.Text = "Version";
            // 
            // chkReadOnly
            // 
            chkReadOnly.AutoSize = true;
            chkReadOnly.Location = new Point(764, 29);
            chkReadOnly.Name = "chkReadOnly";
            chkReadOnly.Size = new Size(15, 14);
            chkReadOnly.TabIndex = 4;
            chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // lblReadOnly
            // 
            lblReadOnly.AutoSize = true;
            lblReadOnly.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblReadOnly.Location = new Point(695, 28);
            lblReadOnly.Name = "lblReadOnly";
            lblReadOnly.Size = new Size(63, 15);
            lblReadOnly.TabIndex = 8;
            lblReadOnly.Text = "Read Only";
            // 
            // txtInternalFileName
            // 
            txtInternalFileName.Location = new Point(379, 22);
            txtInternalFileName.Name = "txtInternalFileName";
            txtInternalFileName.Size = new Size(195, 23);
            txtInternalFileName.TabIndex = 2;
            // 
            // txtPhysicalFileName
            // 
            txtPhysicalFileName.Location = new Point(80, 22);
            txtPhysicalFileName.Name = "txtPhysicalFileName";
            txtPhysicalFileName.Size = new Size(195, 23);
            txtPhysicalFileName.TabIndex = 1;
            txtPhysicalFileName.TextChanged += txtPhysicalFileName_TextChanged;
            // 
            // lblInternalName
            // 
            lblInternalName.AutoSize = true;
            lblInternalName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblInternalName.Location = new Point(286, 25);
            lblInternalName.Name = "lblInternalName";
            lblInternalName.Size = new Size(87, 15);
            lblInternalName.TabIndex = 5;
            lblInternalName.Text = "Internal Name";
            // 
            // lblPhysicalFileName
            // 
            lblPhysicalFileName.AutoSize = true;
            lblPhysicalFileName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhysicalFileName.Location = new Point(12, 25);
            lblPhysicalFileName.Name = "lblPhysicalFileName";
            lblPhysicalFileName.Size = new Size(62, 15);
            lblPhysicalFileName.TabIndex = 4;
            lblPhysicalFileName.Text = "File Name";
            // 
            // tpOther
            // 
            tpOther.BackColor = Color.LavenderBlush;
            tpOther.Controls.Add(gbHolomap);
            tpOther.Controls.Add(gbPosition);
            tpOther.Controls.Add(gbMisc);
            tpOther.Controls.Add(gbMovies);
            tpOther.Location = new Point(4, 24);
            tpOther.Name = "tpOther";
            tpOther.Padding = new Padding(3);
            tpOther.Size = new Size(885, 404);
            tpOther.TabIndex = 1;
            tpOther.Text = "Other";
            // 
            // gbHolomap
            // 
            gbHolomap.BackColor = Color.FloralWhite;
            gbHolomap.Controls.Add(cboHolomap);
            gbHolomap.Controls.Add(lblLocation);
            gbHolomap.Controls.Add(chkHoloBit8);
            gbHolomap.Controls.Add(chkHoloBit7);
            gbHolomap.Controls.Add(chkHoloBit6);
            gbHolomap.Controls.Add(chkHoloBit5);
            gbHolomap.Controls.Add(chkHoloBit4);
            gbHolomap.Controls.Add(chkHoloBit3);
            gbHolomap.Controls.Add(chkHoloBit2);
            gbHolomap.Controls.Add(chkHoloBit1);
            gbHolomap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbHolomap.Location = new Point(351, 259);
            gbHolomap.Name = "gbHolomap";
            gbHolomap.Size = new Size(522, 139);
            gbHolomap.TabIndex = 3;
            gbHolomap.TabStop = false;
            gbHolomap.Text = "Holomap";
            // 
            // cboHolomap
            // 
            cboHolomap.FormattingEnabled = true;
            cboHolomap.Location = new Point(86, 22);
            cboHolomap.Name = "cboHolomap";
            cboHolomap.Size = new Size(430, 23);
            cboHolomap.TabIndex = 11;
            cboHolomap.SelectedIndexChanged += cboHolomap_SelectedIndexChanged;
            cboHolomap.TextChanged += filterComboBox;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(16, 25);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(54, 15);
            lblLocation.TabIndex = 1;
            lblLocation.Text = "Location";
            // 
            // chkHoloBit8
            // 
            chkHoloBit8.AutoSize = true;
            chkHoloBit8.Location = new Point(16, 67);
            chkHoloBit8.Name = "chkHoloBit8";
            chkHoloBit8.Size = new Size(84, 19);
            chkHoloBit8.TabIndex = 12;
            chkHoloBit8.Text = "Has Arrow";
            chkHoloBit8.UseVisualStyleBackColor = true;
            // 
            // chkHoloBit7
            // 
            chkHoloBit7.AutoSize = true;
            chkHoloBit7.Location = new Point(158, 67);
            chkHoloBit7.Name = "chkHoloBit7";
            chkHoloBit7.Size = new Size(69, 19);
            chkHoloBit7.TabIndex = 13;
            chkHoloBit7.Text = "Visited?";
            chkHoloBit7.UseVisualStyleBackColor = true;
            // 
            // chkHoloBit6
            // 
            chkHoloBit6.AutoSize = true;
            chkHoloBit6.Location = new Point(281, 67);
            chkHoloBit6.Name = "chkHoloBit6";
            chkHoloBit6.Size = new Size(109, 19);
            chkHoloBit6.TabIndex = 14;
            chkHoloBit6.Text = "Unknown Bit 6";
            chkHoloBit6.UseVisualStyleBackColor = true;
            // 
            // chkHoloBit5
            // 
            chkHoloBit5.AutoSize = true;
            chkHoloBit5.Location = new Point(406, 67);
            chkHoloBit5.Name = "chkHoloBit5";
            chkHoloBit5.Size = new Size(109, 19);
            chkHoloBit5.TabIndex = 15;
            chkHoloBit5.Text = "Unknown Bit 5";
            chkHoloBit5.UseVisualStyleBackColor = true;
            // 
            // chkHoloBit4
            // 
            chkHoloBit4.AutoSize = true;
            chkHoloBit4.Location = new Point(16, 92);
            chkHoloBit4.Name = "chkHoloBit4";
            chkHoloBit4.Size = new Size(109, 19);
            chkHoloBit4.TabIndex = 16;
            chkHoloBit4.Text = "Unknown Bit 4";
            chkHoloBit4.UseVisualStyleBackColor = true;
            // 
            // chkHoloBit3
            // 
            chkHoloBit3.AutoSize = true;
            chkHoloBit3.Location = new Point(158, 92);
            chkHoloBit3.Name = "chkHoloBit3";
            chkHoloBit3.Size = new Size(109, 19);
            chkHoloBit3.TabIndex = 17;
            chkHoloBit3.Text = "Unknown Bit 3";
            chkHoloBit3.UseVisualStyleBackColor = true;
            // 
            // chkHoloBit2
            // 
            chkHoloBit2.AutoSize = true;
            chkHoloBit2.Location = new Point(281, 92);
            chkHoloBit2.Name = "chkHoloBit2";
            chkHoloBit2.Size = new Size(109, 19);
            chkHoloBit2.TabIndex = 18;
            chkHoloBit2.Text = "Unknown Bit 2";
            chkHoloBit2.UseVisualStyleBackColor = true;
            // 
            // chkHoloBit1
            // 
            chkHoloBit1.AutoSize = true;
            chkHoloBit1.Location = new Point(406, 92);
            chkHoloBit1.Name = "chkHoloBit1";
            chkHoloBit1.Size = new Size(80, 19);
            chkHoloBit1.TabIndex = 19;
            chkHoloBit1.Text = "Can Focus";
            chkHoloBit1.UseVisualStyleBackColor = true;
            // 
            // gbPosition
            // 
            gbPosition.BackColor = Color.FloralWhite;
            gbPosition.Controls.Add(lblHorizontalPos);
            gbPosition.Controls.Add(lblHeight);
            gbPosition.Controls.Add(lblVerticalPos);
            gbPosition.Controls.Add(lblFacing);
            gbPosition.Controls.Add(txtFacing);
            gbPosition.Controls.Add(txtHeight);
            gbPosition.Controls.Add(txtHorizontalPos);
            gbPosition.Controls.Add(txtVerticalPos);
            gbPosition.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbPosition.Location = new Point(351, 190);
            gbPosition.Name = "gbPosition";
            gbPosition.Size = new Size(522, 63);
            gbPosition.TabIndex = 2;
            gbPosition.TabStop = false;
            gbPosition.Text = "Position";
            // 
            // lblHorizontalPos
            // 
            lblHorizontalPos.AutoSize = true;
            lblHorizontalPos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHorizontalPos.Location = new Point(16, 30);
            lblHorizontalPos.Name = "lblHorizontalPos";
            lblHorizontalPos.Size = new Size(65, 15);
            lblHorizontalPos.TabIndex = 39;
            lblHorizontalPos.Text = "Horizontal";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeight.Location = new Point(158, 30);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(45, 15);
            lblHeight.TabIndex = 40;
            lblHeight.Text = "Height";
            // 
            // lblVerticalPos
            // 
            lblVerticalPos.AutoSize = true;
            lblVerticalPos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblVerticalPos.Location = new Point(281, 30);
            lblVerticalPos.Name = "lblVerticalPos";
            lblVerticalPos.Size = new Size(49, 15);
            lblVerticalPos.TabIndex = 41;
            lblVerticalPos.Text = "Vertical";
            // 
            // lblFacing
            // 
            lblFacing.AutoSize = true;
            lblFacing.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFacing.Location = new Point(406, 30);
            lblFacing.Name = "lblFacing";
            lblFacing.Size = new Size(42, 15);
            lblFacing.TabIndex = 42;
            lblFacing.Text = "Facing";
            // 
            // txtFacing
            // 
            txtFacing.Location = new Point(450, 27);
            txtFacing.Name = "txtFacing";
            txtFacing.Size = new Size(66, 23);
            txtFacing.TabIndex = 10;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(209, 27);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(66, 23);
            txtHeight.TabIndex = 8;
            // 
            // txtHorizontalPos
            // 
            txtHorizontalPos.Location = new Point(86, 27);
            txtHorizontalPos.Name = "txtHorizontalPos";
            txtHorizontalPos.Size = new Size(66, 23);
            txtHorizontalPos.TabIndex = 7;
            // 
            // txtVerticalPos
            // 
            txtVerticalPos.Location = new Point(336, 27);
            txtVerticalPos.Name = "txtVerticalPos";
            txtVerticalPos.Size = new Size(66, 23);
            txtVerticalPos.TabIndex = 9;
            // 
            // gbMisc
            // 
            gbMisc.BackColor = Color.FloralWhite;
            gbMisc.Controls.Add(cboAreacode);
            gbMisc.Controls.Add(lblAreacode);
            gbMisc.Controls.Add(lblChapter);
            gbMisc.Controls.Add(cboChapter);
            gbMisc.Controls.Add(lblBehaviour);
            gbMisc.Controls.Add(cboBehaviour);
            gbMisc.Controls.Add(lblOutfit);
            gbMisc.Controls.Add(cboOutfit);
            gbMisc.Controls.Add(lblSelectedWeapon);
            gbMisc.Controls.Add(cboSelectedWeapon);
            gbMisc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbMisc.Location = new Point(351, 6);
            gbMisc.Name = "gbMisc";
            gbMisc.Size = new Size(528, 178);
            gbMisc.TabIndex = 1;
            gbMisc.TabStop = false;
            gbMisc.Text = "Misc";
            // 
            // cboAreacode
            // 
            cboAreacode.FormattingEnabled = true;
            cboAreacode.Location = new Point(86, 28);
            cboAreacode.Name = "cboAreacode";
            cboAreacode.Size = new Size(436, 23);
            cboAreacode.TabIndex = 2;
            cboAreacode.SelectedIndexChanged += cboAreacode_SelectedIndexChanged;
            cboAreacode.TextChanged += filterComboBox;
            // 
            // lblAreacode
            // 
            lblAreacode.AutoSize = true;
            lblAreacode.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAreacode.Location = new Point(16, 31);
            lblAreacode.Name = "lblAreacode";
            lblAreacode.Size = new Size(60, 15);
            lblAreacode.TabIndex = 8;
            lblAreacode.Text = "Areacode";
            // 
            // lblChapter
            // 
            lblChapter.AutoSize = true;
            lblChapter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblChapter.Location = new Point(16, 60);
            lblChapter.Name = "lblChapter";
            lblChapter.Size = new Size(51, 15);
            lblChapter.TabIndex = 6;
            lblChapter.Text = "Chapter";
            // 
            // cboChapter
            // 
            cboChapter.FormattingEnabled = true;
            cboChapter.Items.AddRange(new object[] { "00   Still inside Citadel", "01   Exited Citadel", "02   Zoe Captured\t", "03   Found Tunic", "04   Boarded Ferry at Citadel Port", "05   Spoke to Astronomer", "06   Picked up book of BU", "07   Read slate about Le Bourgne under Twinsen's House", "08   Stole Pirates Flag", "09   Picked up key from chest in museum.", "10", "11", "12", "13   Fortress island: Spoke to Rabbi-bunny.", "14   Stole FunFrocks sabre", "15   Took architechs pass" });
            cboChapter.Location = new Point(86, 57);
            cboChapter.Name = "cboChapter";
            cboChapter.Size = new Size(436, 23);
            cboChapter.TabIndex = 3;
            // 
            // lblBehaviour
            // 
            lblBehaviour.AutoSize = true;
            lblBehaviour.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBehaviour.Location = new Point(16, 89);
            lblBehaviour.Name = "lblBehaviour";
            lblBehaviour.Size = new Size(64, 15);
            lblBehaviour.TabIndex = 10;
            lblBehaviour.Text = "Behaviour";
            // 
            // cboBehaviour
            // 
            cboBehaviour.FormattingEnabled = true;
            cboBehaviour.Items.AddRange(new object[] { "Normal", "Athletic", "Aggressive", "Discreet" });
            cboBehaviour.Location = new Point(86, 86);
            cboBehaviour.Name = "cboBehaviour";
            cboBehaviour.Size = new Size(436, 23);
            cboBehaviour.TabIndex = 4;
            // 
            // lblOutfit
            // 
            lblOutfit.AutoSize = true;
            lblOutfit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOutfit.Location = new Point(16, 117);
            lblOutfit.Name = "lblOutfit";
            lblOutfit.Size = new Size(41, 15);
            lblOutfit.TabIndex = 12;
            lblOutfit.Text = "Outfit";
            // 
            // cboOutfit
            // 
            cboOutfit.FormattingEnabled = true;
            cboOutfit.Items.AddRange(new object[] { "Tunic + medallion", "Tunic", "Tunic, medallion + sword", "Prison", "Nurse", "Tunic +Horn", "Snowboard (May Crash)" });
            cboOutfit.Location = new Point(86, 114);
            cboOutfit.Name = "cboOutfit";
            cboOutfit.Size = new Size(436, 23);
            cboOutfit.TabIndex = 5;
            // 
            // lblSelectedWeapon
            // 
            lblSelectedWeapon.AutoSize = true;
            lblSelectedWeapon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSelectedWeapon.Location = new Point(16, 146);
            lblSelectedWeapon.Name = "lblSelectedWeapon";
            lblSelectedWeapon.Size = new Size(53, 15);
            lblSelectedWeapon.TabIndex = 14;
            lblSelectedWeapon.Text = "Weapon";
            // 
            // cboSelectedWeapon
            // 
            cboSelectedWeapon.FormattingEnabled = true;
            cboSelectedWeapon.Items.AddRange(new object[] { "Magic Ball", "Sabre" });
            cboSelectedWeapon.Location = new Point(86, 143);
            cboSelectedWeapon.Name = "cboSelectedWeapon";
            cboSelectedWeapon.Size = new Size(436, 23);
            cboSelectedWeapon.TabIndex = 6;
            // 
            // gbMovies
            // 
            gbMovies.BackColor = Color.FloralWhite;
            gbMovies.Controls.Add(clbMovies);
            gbMovies.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbMovies.Location = new Point(6, 6);
            gbMovies.Name = "gbMovies";
            gbMovies.Size = new Size(339, 395);
            gbMovies.TabIndex = 0;
            gbMovies.TabStop = false;
            gbMovies.Text = "Movies";
            // 
            // clbMovies
            // 
            clbMovies.CheckOnClick = true;
            clbMovies.FormattingEnabled = true;
            clbMovies.IntegralHeight = false;
            clbMovies.Location = new Point(6, 22);
            clbMovies.Name = "clbMovies";
            clbMovies.Size = new Size(327, 364);
            clbMovies.TabIndex = 1;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblInfo.Location = new Point(12, 466);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(30, 15);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Info";
            // 
            // lblInfoText
            // 
            lblInfoText.AutoSize = true;
            lblInfoText.Location = new Point(48, 466);
            lblInfoText.Name = "lblInfoText";
            lblInfoText.Size = new Size(0, 15);
            lblInfoText.TabIndex = 2;
            // 
            // LBA1SavegameEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(905, 490);
            Controls.Add(lblInfoText);
            Controls.Add(lblInfo);
            Controls.Add(tcMain);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "LBA1SavegameEditor";
            Text = "LBA1 Savegame Editor by Phreak";
            Activated += LBA1SavegameEditor_Activated;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tcMain.ResumeLayout(false);
            tpMain.ResumeLayout(false);
            gbChapterJump.ResumeLayout(false);
            gbMaxAll.ResumeLayout(false);
            gbQuestFlags.ResumeLayout(false);
            gbQuestFlags.PerformLayout();
            gbInventory.ResumeLayout(false);
            gbInventory.PerformLayout();
            gbBasicStats.ResumeLayout(false);
            gbBasicStats.PerformLayout();
            gbFileProperties.ResumeLayout(false);
            gbFileProperties.PerformLayout();
            tpOther.ResumeLayout(false);
            gbHolomap.ResumeLayout(false);
            gbHolomap.PerformLayout();
            gbPosition.ResumeLayout(false);
            gbPosition.PerformLayout();
            gbMisc.ResumeLayout(false);
            gbMisc.PerformLayout();
            gbMovies.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private TabControl tcMain;
        private TabPage tpMain;
        private GroupBox gbFileProperties;
        private TextBox txtInternalFileName;
        private TextBox txtPhysicalFileName;
        private Label lblInternalName;
        private Label lblPhysicalFileName;
        private TextBox txtGas;
        private Label lblReadOnly;
        private CheckBox chkReadOnly;
        private GroupBox gbBasicStats;
        private Label lblHealth;
        private Label lblMagicPoints;
        private Label lblMagicLevel;
        private Label lblClovers;
        private Label lblCloverBoxes;
        private TextBox txtHealth;
        private TextBox txtMagicLevel;
        private TextBox txtCloverBox;
        private TextBox txtClovers;
        private TextBox txtMagicPoints;
        private TextBox txtKashes;
        private Label lblKashes;
        private Label lblGas;
        private ComboBox cboFileFormatVersion;
        private Label lblVersion;
        private GroupBox gbQuestFlags;
        private CheckedListBox clbQuestFlag;
        private GroupBox gbInventory;
        private CheckedListBox clbInventory;
        private Label lblInventoryFilter;
        private TextBox txtInventoryFilter;
        private CheckedListBox clbInventoryUsed;
        private Label lblQuestFilter;
        private TextBox txtQuestFilter;
        private ToolStripMenuItem openToolStripMenuItem1;
        private ToolStripMenuItem saveToolStripMenuItem1;
        private ToolStripMenuItem blackToolStripMenuItem;
        private ToolStripMenuItem changeSaveDirectoryToolStripMenuItem;
        private GroupBox gbMaxAll;
        private Button btnMaxInv;
        private Button btnMaxBasic;
        private Button btnMaxQuest;
        private Button btnMaxInvUsed;
        private TabPage tpOther;
        private GroupBox gbHolomap;
        private GroupBox gbPosition;
        private GroupBox gbMisc;
        private GroupBox gbMovies;
        private GroupBox gbChapterJump;
        private Label lblChapterJumpExplanation;
        private CheckedListBox clbMovies;
        private ComboBox cboAreacode;
        private Label lblAreacode;
        private Label lblChapter;
        private ComboBox cboChapter;
        private Label lblBehaviour;
        private ComboBox cboBehaviour;
        private Label lblOutfit;
        private ComboBox cboOutfit;
        private Label lblSelectedWeapon;
        private ComboBox cboSelectedWeapon;
        private TextBox txtFacing;
        private TextBox txtHeight;
        private TextBox txtHorizontalPos;
        private TextBox txtVerticalPos;
        private Label lblHorizontalPos;
        private Label lblHeight;
        private Label lblVerticalPos;
        private Label lblFacing;
        private ComboBox cboHolomap;
        private Label lblLocation;
        private CheckBox chkHoloBit8;
        private CheckBox chkHoloBit7;
        private CheckBox chkHoloBit6;
        private CheckBox chkHoloBit5;
        private CheckBox chkHoloBit4;
        private CheckBox chkHoloBit3;
        private CheckBox chkHoloBit2;
        private CheckBox chkHoloBit1;
        private Label lblInfo;
        private Label lblInfoText;
        private ToolStripMenuItem reloadToolStripMenuItem;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnChapterMin;
        private Button btnChapterMax;
        private ComboBox cboSelectChapter;
    }
}