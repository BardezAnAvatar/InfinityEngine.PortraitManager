namespace IE_Portrait_Manager
{
    partial class PortraitManager
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
            this.folderBrowserDialogPortraits = new System.Windows.Forms.FolderBrowserDialog();
            this.panelPortraitListContainer = new System.Windows.Forms.Panel();
            this.listBoxPortraits = new System.Windows.Forms.ListBox();
            this.panelProcess = new System.Windows.Forms.Panel();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.buttonReadDir = new System.Windows.Forms.Button();
            this.panelPortraits = new System.Windows.Forms.Panel();
            this.textBoxIntendedPrefix = new System.Windows.Forms.TextBox();
            this.labelCommonName = new System.Windows.Forms.Label();
            this.labelIntendedPrefix = new System.Windows.Forms.Label();
            this.labelCommonNamePrompt = new System.Windows.Forms.Label();
            this.buttonUpdatePortraits = new System.Windows.Forms.Button();
            this.panelSmall = new System.Windows.Forms.Panel();
            this.buttonSmallFromSource = new System.Windows.Forms.Button();
            this.labelSmallHeight = new System.Windows.Forms.Label();
            this.labelSmallWidth = new System.Windows.Forms.Label();
            this.labelSmallWidthPrompt = new System.Windows.Forms.Label();
            this.labelSmallHeightPrompt = new System.Windows.Forms.Label();
            this.pictureBoxSmall = new System.Windows.Forms.PictureBox();
            this.labelSmall = new System.Windows.Forms.Label();
            this.panelLarge = new System.Windows.Forms.Panel();
            this.buttonLargeFromSource = new System.Windows.Forms.Button();
            this.labelLargeHeight = new System.Windows.Forms.Label();
            this.labelLargeWidth = new System.Windows.Forms.Label();
            this.labelLargeWidthPrompt = new System.Windows.Forms.Label();
            this.labelLargeHeightPrompt = new System.Windows.Forms.Label();
            this.pictureBoxLarge = new System.Windows.Forms.PictureBox();
            this.labelLarge = new System.Windows.Forms.Label();
            this.panelGiant = new System.Windows.Forms.Panel();
            this.buttonGiantFromSource = new System.Windows.Forms.Button();
            this.labelGiantHeight = new System.Windows.Forms.Label();
            this.labelGiantWidth = new System.Windows.Forms.Label();
            this.labelGiantWidthPrompt = new System.Windows.Forms.Label();
            this.labelGiantHeightPrompt = new System.Windows.Forms.Label();
            this.pictureBoxGiant = new System.Windows.Forms.PictureBox();
            this.labelGiant = new System.Windows.Forms.Label();
            this.panelSource = new System.Windows.Forms.Panel();
            this.labelSourceHeight = new System.Windows.Forms.Label();
            this.labelSourceWidth = new System.Windows.Forms.Label();
            this.labelSourceWidthPrompt = new System.Windows.Forms.Label();
            this.labelSourceHeightPrompt = new System.Windows.Forms.Label();
            this.pictureBoxSource = new System.Windows.Forms.PictureBox();
            this.labelSource = new System.Windows.Forms.Label();
            this.panelInputDir = new System.Windows.Forms.Panel();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonSetInputDir = new System.Windows.Forms.Button();
            this.panelOutputDir = new System.Windows.Forms.Panel();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonSetOutputDir = new System.Windows.Forms.Button();
            this.groupBoxGame = new System.Windows.Forms.GroupBox();
            this.radioButtonNeverwinterNights = new System.Windows.Forms.RadioButton();
            this.radioButtonPlanescapeTorment = new System.Windows.Forms.RadioButton();
            this.radioButtonIcewindDale2 = new System.Windows.Forms.RadioButton();
            this.radioButtonBaldursGate2 = new System.Windows.Forms.RadioButton();
            this.radioButtonIcewindDale = new System.Windows.Forms.RadioButton();
            this.radioButtonBaldursGate = new System.Windows.Forms.RadioButton();
            this.panelPortraitListContainer.SuspendLayout();
            this.panelProcess.SuspendLayout();
            this.panelPortraits.SuspendLayout();
            this.panelSmall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmall)).BeginInit();
            this.panelLarge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLarge)).BeginInit();
            this.panelGiant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGiant)).BeginInit();
            this.panelSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).BeginInit();
            this.panelInputDir.SuspendLayout();
            this.panelOutputDir.SuspendLayout();
            this.groupBoxGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPortraitListContainer
            // 
            this.panelPortraitListContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPortraitListContainer.Controls.Add(this.listBoxPortraits);
            this.panelPortraitListContainer.Controls.Add(this.panelProcess);
            this.panelPortraitListContainer.Location = new System.Drawing.Point(908, 145);
            this.panelPortraitListContainer.Name = "panelPortraitListContainer";
            this.panelPortraitListContainer.Size = new System.Drawing.Size(235, 560);
            this.panelPortraitListContainer.TabIndex = 4;
            // 
            // listBoxPortraits
            // 
            this.listBoxPortraits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPortraits.FormattingEnabled = true;
            this.listBoxPortraits.Location = new System.Drawing.Point(3, 39);
            this.listBoxPortraits.Name = "listBoxPortraits";
            this.listBoxPortraits.Size = new System.Drawing.Size(229, 511);
            this.listBoxPortraits.TabIndex = 2;
            this.listBoxPortraits.SelectedIndexChanged += new System.EventHandler(this.listBoxPortraits_SelectedIndexChanged);
            // 
            // panelProcess
            // 
            this.panelProcess.Controls.Add(this.buttonProcess);
            this.panelProcess.Controls.Add(this.buttonReadDir);
            this.panelProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProcess.Location = new System.Drawing.Point(0, 0);
            this.panelProcess.Name = "panelProcess";
            this.panelProcess.Size = new System.Drawing.Size(235, 28);
            this.panelProcess.TabIndex = 1;
            // 
            // buttonProcess
            // 
            this.buttonProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProcess.Location = new System.Drawing.Point(119, 3);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(113, 23);
            this.buttonProcess.TabIndex = 2;
            this.buttonProcess.Text = "Process to Output";
            this.buttonProcess.UseVisualStyleBackColor = true;
            // 
            // buttonReadDir
            // 
            this.buttonReadDir.Location = new System.Drawing.Point(3, 3);
            this.buttonReadDir.Name = "buttonReadDir";
            this.buttonReadDir.Size = new System.Drawing.Size(113, 23);
            this.buttonReadDir.TabIndex = 0;
            this.buttonReadDir.Text = "Read Input Dir";
            this.buttonReadDir.UseVisualStyleBackColor = true;
            this.buttonReadDir.Click += new System.EventHandler(this.buttonReadDir_Click);
            // 
            // panelPortraits
            // 
            this.panelPortraits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPortraits.AutoScroll = true;
            this.panelPortraits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPortraits.Controls.Add(this.textBoxIntendedPrefix);
            this.panelPortraits.Controls.Add(this.labelCommonName);
            this.panelPortraits.Controls.Add(this.labelIntendedPrefix);
            this.panelPortraits.Controls.Add(this.labelCommonNamePrompt);
            this.panelPortraits.Controls.Add(this.buttonUpdatePortraits);
            this.panelPortraits.Controls.Add(this.panelSmall);
            this.panelPortraits.Controls.Add(this.panelLarge);
            this.panelPortraits.Controls.Add(this.panelGiant);
            this.panelPortraits.Controls.Add(this.panelSource);
            this.panelPortraits.Location = new System.Drawing.Point(12, 145);
            this.panelPortraits.Name = "panelPortraits";
            this.panelPortraits.Size = new System.Drawing.Size(890, 560);
            this.panelPortraits.TabIndex = 3;
            this.panelPortraits.Visible = false;
            // 
            // textBoxIntendedPrefix
            // 
            this.textBoxIntendedPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIntendedPrefix.Location = new System.Drawing.Point(95, 535);
            this.textBoxIntendedPrefix.Name = "textBoxIntendedPrefix";
            this.textBoxIntendedPrefix.Size = new System.Drawing.Size(710, 20);
            this.textBoxIntendedPrefix.TabIndex = 7;
            // 
            // labelCommonName
            // 
            this.labelCommonName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCommonName.AutoSize = true;
            this.labelCommonName.Location = new System.Drawing.Point(93, 519);
            this.labelCommonName.Name = "labelCommonName";
            this.labelCommonName.Size = new System.Drawing.Size(40, 13);
            this.labelCommonName.TabIndex = 5;
            this.labelCommonName.Text = "[Blank]";
            // 
            // labelIntendedPrefix
            // 
            this.labelIntendedPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIntendedPrefix.AutoSize = true;
            this.labelIntendedPrefix.Location = new System.Drawing.Point(5, 538);
            this.labelIntendedPrefix.Name = "labelIntendedPrefix";
            this.labelIntendedPrefix.Size = new System.Drawing.Size(84, 13);
            this.labelIntendedPrefix.TabIndex = 6;
            this.labelIntendedPrefix.Text = "Indended Prefix:";
            // 
            // labelCommonNamePrompt
            // 
            this.labelCommonNamePrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCommonNamePrompt.AutoSize = true;
            this.labelCommonNamePrompt.Location = new System.Drawing.Point(5, 519);
            this.labelCommonNamePrompt.Name = "labelCommonNamePrompt";
            this.labelCommonNamePrompt.Size = new System.Drawing.Size(82, 13);
            this.labelCommonNamePrompt.TabIndex = 4;
            this.labelCommonNamePrompt.Text = "Common Name:";
            // 
            // buttonUpdatePortraits
            // 
            this.buttonUpdatePortraits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdatePortraits.Location = new System.Drawing.Point(810, 532);
            this.buttonUpdatePortraits.Name = "buttonUpdatePortraits";
            this.buttonUpdatePortraits.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdatePortraits.TabIndex = 8;
            this.buttonUpdatePortraits.Text = "Update";
            this.buttonUpdatePortraits.UseVisualStyleBackColor = true;
            // 
            // panelSmall
            // 
            this.panelSmall.AutoSize = true;
            this.panelSmall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSmall.Controls.Add(this.buttonSmallFromSource);
            this.panelSmall.Controls.Add(this.labelSmallHeight);
            this.panelSmall.Controls.Add(this.labelSmallWidth);
            this.panelSmall.Controls.Add(this.labelSmallWidthPrompt);
            this.panelSmall.Controls.Add(this.labelSmallHeightPrompt);
            this.panelSmall.Controls.Add(this.pictureBoxSmall);
            this.panelSmall.Controls.Add(this.labelSmall);
            this.panelSmall.Location = new System.Drawing.Point(626, 3);
            this.panelSmall.Name = "panelSmall";
            this.panelSmall.Size = new System.Drawing.Size(179, 159);
            this.panelSmall.TabIndex = 3;
            // 
            // buttonSmallFromSource
            // 
            this.buttonSmallFromSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSmallFromSource.Location = new System.Drawing.Point(99, 124);
            this.buttonSmallFromSource.Name = "buttonSmallFromSource";
            this.buttonSmallFromSource.Size = new System.Drawing.Size(75, 30);
            this.buttonSmallFromSource.TabIndex = 14;
            this.buttonSmallFromSource.Text = "From Source";
            this.buttonSmallFromSource.UseVisualStyleBackColor = true;
            this.buttonSmallFromSource.Click += new System.EventHandler(this.buttonSmallFromSource_Click);
            // 
            // labelSmallHeight
            // 
            this.labelSmallHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSmallHeight.AutoSize = true;
            this.labelSmallHeight.Location = new System.Drawing.Point(47, 124);
            this.labelSmallHeight.Name = "labelSmallHeight";
            this.labelSmallHeight.Size = new System.Drawing.Size(44, 13);
            this.labelSmallHeight.TabIndex = 13;
            this.labelSmallHeight.Text = "[Height]";
            // 
            // labelSmallWidth
            // 
            this.labelSmallWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSmallWidth.AutoSize = true;
            this.labelSmallWidth.Location = new System.Drawing.Point(47, 141);
            this.labelSmallWidth.Name = "labelSmallWidth";
            this.labelSmallWidth.Size = new System.Drawing.Size(41, 13);
            this.labelSmallWidth.TabIndex = 12;
            this.labelSmallWidth.Text = "[Width]";
            // 
            // labelSmallWidthPrompt
            // 
            this.labelSmallWidthPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSmallWidthPrompt.AutoSize = true;
            this.labelSmallWidthPrompt.Location = new System.Drawing.Point(3, 141);
            this.labelSmallWidthPrompt.Name = "labelSmallWidthPrompt";
            this.labelSmallWidthPrompt.Size = new System.Drawing.Size(38, 13);
            this.labelSmallWidthPrompt.TabIndex = 11;
            this.labelSmallWidthPrompt.Text = "Width:";
            // 
            // labelSmallHeightPrompt
            // 
            this.labelSmallHeightPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSmallHeightPrompt.AutoSize = true;
            this.labelSmallHeightPrompt.Location = new System.Drawing.Point(3, 124);
            this.labelSmallHeightPrompt.Name = "labelSmallHeightPrompt";
            this.labelSmallHeightPrompt.Size = new System.Drawing.Size(41, 13);
            this.labelSmallHeightPrompt.TabIndex = 10;
            this.labelSmallHeightPrompt.Text = "Height:";
            // 
            // pictureBoxSmall
            // 
            this.pictureBoxSmall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSmall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSmall.Location = new System.Drawing.Point(3, 21);
            this.pictureBoxSmall.Name = "pictureBoxSmall";
            this.pictureBoxSmall.Size = new System.Drawing.Size(171, 100);
            this.pictureBoxSmall.TabIndex = 1;
            this.pictureBoxSmall.TabStop = false;
            this.pictureBoxSmall.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSmall_MouseDown);
            this.pictureBoxSmall.MouseEnter += new System.EventHandler(this.PortraitManager_MouseEnter);
            this.pictureBoxSmall.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSmall_MouseMove);
            this.pictureBoxSmall.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSmall_MouseUp);
            this.pictureBoxSmall.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSmall_MouseWheel);
            // 
            // labelSmall
            // 
            this.labelSmall.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSmall.AutoSize = true;
            this.labelSmall.Location = new System.Drawing.Point(56, 4);
            this.labelSmall.Name = "labelSmall";
            this.labelSmall.Size = new System.Drawing.Size(64, 13);
            this.labelSmall.TabIndex = 0;
            this.labelSmall.Text = "Small Image";
            // 
            // panelLarge
            // 
            this.panelLarge.AutoSize = true;
            this.panelLarge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLarge.Controls.Add(this.buttonLargeFromSource);
            this.panelLarge.Controls.Add(this.labelLargeHeight);
            this.panelLarge.Controls.Add(this.labelLargeWidth);
            this.panelLarge.Controls.Add(this.labelLargeWidthPrompt);
            this.panelLarge.Controls.Add(this.labelLargeHeightPrompt);
            this.panelLarge.Controls.Add(this.pictureBoxLarge);
            this.panelLarge.Controls.Add(this.labelLarge);
            this.panelLarge.Location = new System.Drawing.Point(441, 3);
            this.panelLarge.Name = "panelLarge";
            this.panelLarge.Size = new System.Drawing.Size(179, 230);
            this.panelLarge.TabIndex = 2;
            // 
            // buttonLargeFromSource
            // 
            this.buttonLargeFromSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLargeFromSource.Location = new System.Drawing.Point(99, 195);
            this.buttonLargeFromSource.Name = "buttonLargeFromSource";
            this.buttonLargeFromSource.Size = new System.Drawing.Size(75, 30);
            this.buttonLargeFromSource.TabIndex = 11;
            this.buttonLargeFromSource.Text = "From Source";
            this.buttonLargeFromSource.UseVisualStyleBackColor = true;
            this.buttonLargeFromSource.Click += new System.EventHandler(this.buttonLargeFromSource_Click);
            // 
            // labelLargeHeight
            // 
            this.labelLargeHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLargeHeight.AutoSize = true;
            this.labelLargeHeight.Location = new System.Drawing.Point(47, 195);
            this.labelLargeHeight.Name = "labelLargeHeight";
            this.labelLargeHeight.Size = new System.Drawing.Size(44, 13);
            this.labelLargeHeight.TabIndex = 9;
            this.labelLargeHeight.Text = "[Height]";
            // 
            // labelLargeWidth
            // 
            this.labelLargeWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLargeWidth.AutoSize = true;
            this.labelLargeWidth.Location = new System.Drawing.Point(47, 212);
            this.labelLargeWidth.Name = "labelLargeWidth";
            this.labelLargeWidth.Size = new System.Drawing.Size(41, 13);
            this.labelLargeWidth.TabIndex = 8;
            this.labelLargeWidth.Text = "[Width]";
            // 
            // labelLargeWidthPrompt
            // 
            this.labelLargeWidthPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLargeWidthPrompt.AutoSize = true;
            this.labelLargeWidthPrompt.Location = new System.Drawing.Point(3, 212);
            this.labelLargeWidthPrompt.Name = "labelLargeWidthPrompt";
            this.labelLargeWidthPrompt.Size = new System.Drawing.Size(38, 13);
            this.labelLargeWidthPrompt.TabIndex = 7;
            this.labelLargeWidthPrompt.Text = "Width:";
            // 
            // labelLargeHeightPrompt
            // 
            this.labelLargeHeightPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLargeHeightPrompt.AutoSize = true;
            this.labelLargeHeightPrompt.Location = new System.Drawing.Point(3, 195);
            this.labelLargeHeightPrompt.Name = "labelLargeHeightPrompt";
            this.labelLargeHeightPrompt.Size = new System.Drawing.Size(41, 13);
            this.labelLargeHeightPrompt.TabIndex = 6;
            this.labelLargeHeightPrompt.Text = "Height:";
            // 
            // pictureBoxLarge
            // 
            this.pictureBoxLarge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLarge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLarge.Location = new System.Drawing.Point(3, 21);
            this.pictureBoxLarge.Name = "pictureBoxLarge";
            this.pictureBoxLarge.Size = new System.Drawing.Size(171, 171);
            this.pictureBoxLarge.TabIndex = 1;
            this.pictureBoxLarge.TabStop = false;
            this.pictureBoxLarge.MouseEnter += new System.EventHandler(this.pictureBoxLarge_MouseEnter);
            this.pictureBoxLarge.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pictureBoxLarge_MouseWheel);
            // 
            // labelLarge
            // 
            this.labelLarge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLarge.AutoSize = true;
            this.labelLarge.Location = new System.Drawing.Point(55, 4);
            this.labelLarge.Name = "labelLarge";
            this.labelLarge.Size = new System.Drawing.Size(66, 13);
            this.labelLarge.TabIndex = 0;
            this.labelLarge.Text = "Large Image";
            // 
            // panelGiant
            // 
            this.panelGiant.AutoSize = true;
            this.panelGiant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGiant.Controls.Add(this.buttonGiantFromSource);
            this.panelGiant.Controls.Add(this.labelGiantHeight);
            this.panelGiant.Controls.Add(this.labelGiantWidth);
            this.panelGiant.Controls.Add(this.labelGiantWidthPrompt);
            this.panelGiant.Controls.Add(this.labelGiantHeightPrompt);
            this.panelGiant.Controls.Add(this.pictureBoxGiant);
            this.panelGiant.Controls.Add(this.labelGiant);
            this.panelGiant.Location = new System.Drawing.Point(254, 4);
            this.panelGiant.Name = "panelGiant";
            this.panelGiant.Size = new System.Drawing.Size(181, 284);
            this.panelGiant.TabIndex = 1;
            // 
            // buttonGiantFromSource
            // 
            this.buttonGiantFromSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGiantFromSource.Location = new System.Drawing.Point(100, 248);
            this.buttonGiantFromSource.Name = "buttonGiantFromSource";
            this.buttonGiantFromSource.Size = new System.Drawing.Size(75, 30);
            this.buttonGiantFromSource.TabIndex = 10;
            this.buttonGiantFromSource.Text = "From Source";
            this.buttonGiantFromSource.UseVisualStyleBackColor = true;
            this.buttonGiantFromSource.Click += new System.EventHandler(this.buttonGiantFromSource_Click);
            // 
            // labelGiantHeight
            // 
            this.labelGiantHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelGiantHeight.AutoSize = true;
            this.labelGiantHeight.Location = new System.Drawing.Point(47, 248);
            this.labelGiantHeight.Name = "labelGiantHeight";
            this.labelGiantHeight.Size = new System.Drawing.Size(44, 13);
            this.labelGiantHeight.TabIndex = 9;
            this.labelGiantHeight.Text = "[Height]";
            // 
            // labelGiantWidth
            // 
            this.labelGiantWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelGiantWidth.AutoSize = true;
            this.labelGiantWidth.Location = new System.Drawing.Point(47, 265);
            this.labelGiantWidth.Name = "labelGiantWidth";
            this.labelGiantWidth.Size = new System.Drawing.Size(41, 13);
            this.labelGiantWidth.TabIndex = 8;
            this.labelGiantWidth.Text = "[Width]";
            // 
            // labelGiantWidthPrompt
            // 
            this.labelGiantWidthPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelGiantWidthPrompt.AutoSize = true;
            this.labelGiantWidthPrompt.Location = new System.Drawing.Point(3, 265);
            this.labelGiantWidthPrompt.Name = "labelGiantWidthPrompt";
            this.labelGiantWidthPrompt.Size = new System.Drawing.Size(38, 13);
            this.labelGiantWidthPrompt.TabIndex = 7;
            this.labelGiantWidthPrompt.Text = "Width:";
            // 
            // labelGiantHeightPrompt
            // 
            this.labelGiantHeightPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelGiantHeightPrompt.AutoSize = true;
            this.labelGiantHeightPrompt.Location = new System.Drawing.Point(3, 248);
            this.labelGiantHeightPrompt.Name = "labelGiantHeightPrompt";
            this.labelGiantHeightPrompt.Size = new System.Drawing.Size(41, 13);
            this.labelGiantHeightPrompt.TabIndex = 6;
            this.labelGiantHeightPrompt.Text = "Height:";
            // 
            // pictureBoxGiant
            // 
            this.pictureBoxGiant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxGiant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxGiant.Location = new System.Drawing.Point(3, 21);
            this.pictureBoxGiant.Name = "pictureBoxGiant";
            this.pictureBoxGiant.Size = new System.Drawing.Size(173, 224);
            this.pictureBoxGiant.TabIndex = 1;
            this.pictureBoxGiant.TabStop = false;
            this.pictureBoxGiant.MouseEnter += new System.EventHandler(this.pictureBoxGiant_MouseEnter);
            this.pictureBoxGiant.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pictureBoxGiant_MouseWheel);
            // 
            // labelGiant
            // 
            this.labelGiant.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelGiant.AutoSize = true;
            this.labelGiant.Location = new System.Drawing.Point(57, 4);
            this.labelGiant.Name = "labelGiant";
            this.labelGiant.Size = new System.Drawing.Size(64, 13);
            this.labelGiant.TabIndex = 0;
            this.labelGiant.Text = "Giant Image";
            // 
            // panelSource
            // 
            this.panelSource.AutoSize = true;
            this.panelSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSource.Controls.Add(this.labelSourceHeight);
            this.panelSource.Controls.Add(this.labelSourceWidth);
            this.panelSource.Controls.Add(this.labelSourceWidthPrompt);
            this.panelSource.Controls.Add(this.labelSourceHeightPrompt);
            this.panelSource.Controls.Add(this.pictureBoxSource);
            this.panelSource.Controls.Add(this.labelSource);
            this.panelSource.Location = new System.Drawing.Point(4, 4);
            this.panelSource.Name = "panelSource";
            this.panelSource.Size = new System.Drawing.Size(243, 383);
            this.panelSource.TabIndex = 0;
            // 
            // labelSourceHeight
            // 
            this.labelSourceHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSourceHeight.AutoSize = true;
            this.labelSourceHeight.Location = new System.Drawing.Point(47, 347);
            this.labelSourceHeight.Name = "labelSourceHeight";
            this.labelSourceHeight.Size = new System.Drawing.Size(44, 13);
            this.labelSourceHeight.TabIndex = 5;
            this.labelSourceHeight.Text = "[Height]";
            // 
            // labelSourceWidth
            // 
            this.labelSourceWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSourceWidth.AutoSize = true;
            this.labelSourceWidth.Location = new System.Drawing.Point(47, 364);
            this.labelSourceWidth.Name = "labelSourceWidth";
            this.labelSourceWidth.Size = new System.Drawing.Size(41, 13);
            this.labelSourceWidth.TabIndex = 4;
            this.labelSourceWidth.Text = "[Width]";
            // 
            // labelSourceWidthPrompt
            // 
            this.labelSourceWidthPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSourceWidthPrompt.AutoSize = true;
            this.labelSourceWidthPrompt.Location = new System.Drawing.Point(3, 364);
            this.labelSourceWidthPrompt.Name = "labelSourceWidthPrompt";
            this.labelSourceWidthPrompt.Size = new System.Drawing.Size(38, 13);
            this.labelSourceWidthPrompt.TabIndex = 3;
            this.labelSourceWidthPrompt.Text = "Width:";
            // 
            // labelSourceHeightPrompt
            // 
            this.labelSourceHeightPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSourceHeightPrompt.AutoSize = true;
            this.labelSourceHeightPrompt.Location = new System.Drawing.Point(3, 347);
            this.labelSourceHeightPrompt.Name = "labelSourceHeightPrompt";
            this.labelSourceHeightPrompt.Size = new System.Drawing.Size(41, 13);
            this.labelSourceHeightPrompt.TabIndex = 2;
            this.labelSourceHeightPrompt.Text = "Height:";
            // 
            // pictureBoxSource
            // 
            this.pictureBoxSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSource.Location = new System.Drawing.Point(3, 20);
            this.pictureBoxSource.Name = "pictureBoxSource";
            this.pictureBoxSource.Size = new System.Drawing.Size(235, 324);
            this.pictureBoxSource.TabIndex = 1;
            this.pictureBoxSource.TabStop = false;
            // 
            // labelSource
            // 
            this.labelSource.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(72, 3);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(97, 13);
            this.labelSource.TabIndex = 0;
            this.labelSource.Text = "Best Source Image";
            // 
            // panelInputDir
            // 
            this.panelInputDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInputDir.Controls.Add(this.textBoxInput);
            this.panelInputDir.Controls.Add(this.buttonSetInputDir);
            this.panelInputDir.Location = new System.Drawing.Point(12, 12);
            this.panelInputDir.Name = "panelInputDir";
            this.panelInputDir.Size = new System.Drawing.Size(1131, 33);
            this.panelInputDir.TabIndex = 1;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInput.Location = new System.Drawing.Point(3, 8);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(982, 20);
            this.textBoxInput.TabIndex = 1;
            // 
            // buttonSetInputDir
            // 
            this.buttonSetInputDir.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSetInputDir.Location = new System.Drawing.Point(991, 0);
            this.buttonSetInputDir.Name = "buttonSetInputDir";
            this.buttonSetInputDir.Size = new System.Drawing.Size(140, 33);
            this.buttonSetInputDir.TabIndex = 2;
            this.buttonSetInputDir.Text = "Set Input Directory";
            this.buttonSetInputDir.UseVisualStyleBackColor = true;
            this.buttonSetInputDir.Click += new System.EventHandler(this.buttonSetInputDir_Click);
            // 
            // panelOutputDir
            // 
            this.panelOutputDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOutputDir.Controls.Add(this.textBoxOutput);
            this.panelOutputDir.Controls.Add(this.buttonSetOutputDir);
            this.panelOutputDir.Location = new System.Drawing.Point(12, 51);
            this.panelOutputDir.Name = "panelOutputDir";
            this.panelOutputDir.Size = new System.Drawing.Size(1131, 33);
            this.panelOutputDir.TabIndex = 2;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput.Location = new System.Drawing.Point(3, 8);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(982, 20);
            this.textBoxOutput.TabIndex = 1;
            // 
            // buttonSetOutputDir
            // 
            this.buttonSetOutputDir.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSetOutputDir.Location = new System.Drawing.Point(991, 0);
            this.buttonSetOutputDir.Name = "buttonSetOutputDir";
            this.buttonSetOutputDir.Size = new System.Drawing.Size(140, 33);
            this.buttonSetOutputDir.TabIndex = 2;
            this.buttonSetOutputDir.Text = "Set Output Directory";
            this.buttonSetOutputDir.UseVisualStyleBackColor = true;
            this.buttonSetOutputDir.Click += new System.EventHandler(this.buttonSetOutputDir_Click);
            // 
            // groupBoxGame
            // 
            this.groupBoxGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGame.Controls.Add(this.radioButtonNeverwinterNights);
            this.groupBoxGame.Controls.Add(this.radioButtonPlanescapeTorment);
            this.groupBoxGame.Controls.Add(this.radioButtonIcewindDale2);
            this.groupBoxGame.Controls.Add(this.radioButtonBaldursGate2);
            this.groupBoxGame.Controls.Add(this.radioButtonIcewindDale);
            this.groupBoxGame.Controls.Add(this.radioButtonBaldursGate);
            this.groupBoxGame.Location = new System.Drawing.Point(12, 91);
            this.groupBoxGame.Name = "groupBoxGame";
            this.groupBoxGame.Size = new System.Drawing.Size(1131, 48);
            this.groupBoxGame.TabIndex = 5;
            this.groupBoxGame.TabStop = false;
            this.groupBoxGame.Text = "Targeted Game Platform";
            // 
            // radioButtonNeverwinterNights
            // 
            this.radioButtonNeverwinterNights.AutoSize = true;
            this.radioButtonNeverwinterNights.Enabled = false;
            this.radioButtonNeverwinterNights.Location = new System.Drawing.Point(534, 20);
            this.radioButtonNeverwinterNights.Name = "radioButtonNeverwinterNights";
            this.radioButtonNeverwinterNights.Size = new System.Drawing.Size(115, 17);
            this.radioButtonNeverwinterNights.TabIndex = 5;
            this.radioButtonNeverwinterNights.TabStop = true;
            this.radioButtonNeverwinterNights.Text = "Neverwinter Nights";
            this.radioButtonNeverwinterNights.UseVisualStyleBackColor = true;
            // 
            // radioButtonPlanescapeTorment
            // 
            this.radioButtonPlanescapeTorment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonPlanescapeTorment.AutoSize = true;
            this.radioButtonPlanescapeTorment.Enabled = false;
            this.radioButtonPlanescapeTorment.Location = new System.Drawing.Point(401, 20);
            this.radioButtonPlanescapeTorment.Name = "radioButtonPlanescapeTorment";
            this.radioButtonPlanescapeTorment.Size = new System.Drawing.Size(126, 17);
            this.radioButtonPlanescapeTorment.TabIndex = 4;
            this.radioButtonPlanescapeTorment.Text = "Planescape: Torment";
            this.radioButtonPlanescapeTorment.UseVisualStyleBackColor = true;
            // 
            // radioButtonIcewindDale2
            // 
            this.radioButtonIcewindDale2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonIcewindDale2.AutoSize = true;
            this.radioButtonIcewindDale2.Location = new System.Drawing.Point(298, 20);
            this.radioButtonIcewindDale2.Name = "radioButtonIcewindDale2";
            this.radioButtonIcewindDale2.Size = new System.Drawing.Size(96, 17);
            this.radioButtonIcewindDale2.TabIndex = 3;
            this.radioButtonIcewindDale2.Text = "Icewind Dale II";
            this.radioButtonIcewindDale2.UseVisualStyleBackColor = true;
            // 
            // radioButtonBaldursGate2
            // 
            this.radioButtonBaldursGate2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonBaldursGate2.AutoSize = true;
            this.radioButtonBaldursGate2.Checked = true;
            this.radioButtonBaldursGate2.Location = new System.Drawing.Point(196, 20);
            this.radioButtonBaldursGate2.Name = "radioButtonBaldursGate2";
            this.radioButtonBaldursGate2.Size = new System.Drawing.Size(95, 17);
            this.radioButtonBaldursGate2.TabIndex = 2;
            this.radioButtonBaldursGate2.TabStop = true;
            this.radioButtonBaldursGate2.Text = "Baldurs Gate II";
            this.radioButtonBaldursGate2.UseVisualStyleBackColor = true;
            // 
            // radioButtonIcewindDale
            // 
            this.radioButtonIcewindDale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonIcewindDale.AutoSize = true;
            this.radioButtonIcewindDale.Location = new System.Drawing.Point(102, 20);
            this.radioButtonIcewindDale.Name = "radioButtonIcewindDale";
            this.radioButtonIcewindDale.Size = new System.Drawing.Size(87, 17);
            this.radioButtonIcewindDale.TabIndex = 1;
            this.radioButtonIcewindDale.Text = "Icewind Dale";
            this.radioButtonIcewindDale.UseVisualStyleBackColor = true;
            // 
            // radioButtonBaldursGate
            // 
            this.radioButtonBaldursGate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonBaldursGate.AutoSize = true;
            this.radioButtonBaldursGate.Location = new System.Drawing.Point(7, 20);
            this.radioButtonBaldursGate.Name = "radioButtonBaldursGate";
            this.radioButtonBaldursGate.Size = new System.Drawing.Size(88, 17);
            this.radioButtonBaldursGate.TabIndex = 0;
            this.radioButtonBaldursGate.Text = "Baldur\'s Gate";
            this.radioButtonBaldursGate.UseVisualStyleBackColor = true;
            // 
            // PortraitManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 717);
            this.Controls.Add(this.groupBoxGame);
            this.Controls.Add(this.panelOutputDir);
            this.Controls.Add(this.panelInputDir);
            this.Controls.Add(this.panelPortraits);
            this.Controls.Add(this.panelPortraitListContainer);
            this.Name = "PortraitManager";
            this.Text = "Portrait Manager";
            this.panelPortraitListContainer.ResumeLayout(false);
            this.panelProcess.ResumeLayout(false);
            this.panelPortraits.ResumeLayout(false);
            this.panelPortraits.PerformLayout();
            this.panelSmall.ResumeLayout(false);
            this.panelSmall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmall)).EndInit();
            this.panelLarge.ResumeLayout(false);
            this.panelLarge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLarge)).EndInit();
            this.panelGiant.ResumeLayout(false);
            this.panelGiant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGiant)).EndInit();
            this.panelSource.ResumeLayout(false);
            this.panelSource.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).EndInit();
            this.panelInputDir.ResumeLayout(false);
            this.panelInputDir.PerformLayout();
            this.panelOutputDir.ResumeLayout(false);
            this.panelOutputDir.PerformLayout();
            this.groupBoxGame.ResumeLayout(false);
            this.groupBoxGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogPortraits;
        private System.Windows.Forms.Panel panelPortraitListContainer;
        private System.Windows.Forms.ListBox listBoxPortraits;
        private System.Windows.Forms.Panel panelProcess;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.Button buttonReadDir;
        private System.Windows.Forms.Panel panelPortraits;
        private System.Windows.Forms.Panel panelSource;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Panel panelGiant;
        private System.Windows.Forms.Panel panelLarge;
        private System.Windows.Forms.Label labelGiant;
        private System.Windows.Forms.Panel panelSmall;
        private System.Windows.Forms.Label labelSmall;
        private System.Windows.Forms.Label labelLarge;
        private System.Windows.Forms.Panel panelInputDir;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonSetInputDir;
        private System.Windows.Forms.Panel panelOutputDir;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonSetOutputDir;
        private System.Windows.Forms.PictureBox pictureBoxSource;
        private System.Windows.Forms.PictureBox pictureBoxSmall;
        private System.Windows.Forms.PictureBox pictureBoxLarge;
        private System.Windows.Forms.PictureBox pictureBoxGiant;
        private System.Windows.Forms.TextBox textBoxIntendedPrefix;
        private System.Windows.Forms.Label labelCommonName;
        private System.Windows.Forms.Label labelIntendedPrefix;
        private System.Windows.Forms.Label labelCommonNamePrompt;
        private System.Windows.Forms.Button buttonUpdatePortraits;
        private System.Windows.Forms.Label labelSourceHeight;
        private System.Windows.Forms.Label labelSourceWidth;
        private System.Windows.Forms.Label labelSourceWidthPrompt;
        private System.Windows.Forms.Label labelSourceHeightPrompt;
        private System.Windows.Forms.Label labelSmallHeight;
        private System.Windows.Forms.Label labelSmallWidth;
        private System.Windows.Forms.Label labelSmallWidthPrompt;
        private System.Windows.Forms.Label labelSmallHeightPrompt;
        private System.Windows.Forms.Label labelLargeHeight;
        private System.Windows.Forms.Label labelLargeWidth;
        private System.Windows.Forms.Label labelLargeWidthPrompt;
        private System.Windows.Forms.Label labelLargeHeightPrompt;
        private System.Windows.Forms.Label labelGiantHeight;
        private System.Windows.Forms.Label labelGiantWidth;
        private System.Windows.Forms.Label labelGiantWidthPrompt;
        private System.Windows.Forms.Label labelGiantHeightPrompt;
        private System.Windows.Forms.GroupBox groupBoxGame;
        private System.Windows.Forms.RadioButton radioButtonPlanescapeTorment;
        private System.Windows.Forms.RadioButton radioButtonIcewindDale2;
        private System.Windows.Forms.RadioButton radioButtonBaldursGate2;
        private System.Windows.Forms.RadioButton radioButtonIcewindDale;
        private System.Windows.Forms.RadioButton radioButtonBaldursGate;
        private System.Windows.Forms.RadioButton radioButtonNeverwinterNights;
        private System.Windows.Forms.Button buttonSmallFromSource;
        private System.Windows.Forms.Button buttonLargeFromSource;
        private System.Windows.Forms.Button buttonGiantFromSource;
    }
}

