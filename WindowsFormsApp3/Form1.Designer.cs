namespace WindowsFormsApp3
{
    partial class mainForm
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
			this.textureLst = new System.Windows.Forms.ListView();
			this.filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.dir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.bitDepth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.palette = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.intensity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.convertBtn = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.removeTextureBtn = new System.Windows.Forms.Button();
			this.changeImglstBtn = new System.Windows.Forms.Button();
			this.addTextureBtn = new System.Windows.Forms.Button();
			this.exitBtn = new System.Windows.Forms.Button();
			this.metadataLbl = new System.Windows.Forms.Label();
			this.filePathTxt = new System.Windows.Forms.TextBox();
			this.texturePic = new System.Windows.Forms.PictureBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.fileTab = new System.Windows.Forms.TabPage();
			this.ImageDataGrid = new System.Windows.Forms.DataGridView();
			this.localNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.directoriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.formatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numBitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.intensityKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paletteKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.imageFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.displayTab = new System.Windows.Forms.TabPage();
			this.imageFileBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.bitDepthCmb = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.texTypeCmb = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.paletteCmb = new System.Windows.Forms.ComboBox();
			this.paletteSelectionCmb = new System.Windows.Forms.Label();
			this.alphaRad = new System.Windows.Forms.RadioButton();
			this.intensitySelectorGroup = new System.Windows.Forms.GroupBox();
			this.blueRad = new System.Windows.Forms.RadioButton();
			this.greenRad = new System.Windows.Forms.RadioButton();
			this.redRad = new System.Windows.Forms.RadioButton();
			this.grayscaleRad = new System.Windows.Forms.RadioButton();
			this.ciPaletteGroup = new System.Windows.Forms.GroupBox();
			this.createPaletteBtn = new System.Windows.Forms.Button();
			this.modPaletteBtn = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.texturePic)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.fileTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ImageDataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imageFileBindingSource)).BeginInit();
			this.displayTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imageFileBindingSource1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.intensitySelectorGroup.SuspendLayout();
			this.ciPaletteGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// textureLst
			// 
			this.textureLst.AllowDrop = true;
			this.textureLst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textureLst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.filename,
            this.dir,
            this.type,
            this.bitDepth,
            this.palette,
            this.intensity});
			this.textureLst.GridLines = true;
			this.textureLst.HideSelection = false;
			this.textureLst.Location = new System.Drawing.Point(196, 85);
			this.textureLst.Name = "textureLst";
			this.textureLst.Size = new System.Drawing.Size(521, 513);
			this.textureLst.TabIndex = 0;
			this.textureLst.UseCompatibleStateImageBehavior = false;
			this.textureLst.View = System.Windows.Forms.View.List;
			// 
			// filename
			// 
			this.filename.Text = "Filename";
			// 
			// dir
			// 
			this.dir.DisplayIndex = 3;
			this.dir.Text = "Directory";
			// 
			// type
			// 
			this.type.DisplayIndex = 1;
			this.type.Text = "Type";
			// 
			// bitDepth
			// 
			this.bitDepth.DisplayIndex = 2;
			this.bitDepth.Text = "Bit Depth";
			// 
			// palette
			// 
			this.palette.Text = "Palette";
			// 
			// intensity
			// 
			this.intensity.Text = "Intensity";
			// 
			// convertBtn
			// 
			this.convertBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.convertBtn.Location = new System.Drawing.Point(572, 497);
			this.convertBtn.Name = "convertBtn";
			this.convertBtn.Size = new System.Drawing.Size(94, 23);
			this.convertBtn.TabIndex = 1;
			this.convertBtn.Text = "Convert";
			this.convertBtn.UseVisualStyleBackColor = true;
			this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.removeTextureBtn);
			this.groupBox1.Controls.Add(this.changeImglstBtn);
			this.groupBox1.Controls.Add(this.addTextureBtn);
			this.groupBox1.Location = new System.Drawing.Point(566, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(106, 136);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "File Settings";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 77);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(94, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "New Imglist";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// removeTextureBtn
			// 
			this.removeTextureBtn.Location = new System.Drawing.Point(6, 48);
			this.removeTextureBtn.Name = "removeTextureBtn";
			this.removeTextureBtn.Size = new System.Drawing.Size(94, 23);
			this.removeTextureBtn.TabIndex = 7;
			this.removeTextureBtn.Text = "Remove Texture";
			this.removeTextureBtn.UseVisualStyleBackColor = true;
			// 
			// changeImglstBtn
			// 
			this.changeImglstBtn.Location = new System.Drawing.Point(6, 106);
			this.changeImglstBtn.Name = "changeImglstBtn";
			this.changeImglstBtn.Size = new System.Drawing.Size(94, 23);
			this.changeImglstBtn.TabIndex = 7;
			this.changeImglstBtn.Text = "Change Imglist";
			this.changeImglstBtn.UseVisualStyleBackColor = true;
			// 
			// addTextureBtn
			// 
			this.addTextureBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.addTextureBtn.Location = new System.Drawing.Point(6, 19);
			this.addTextureBtn.Name = "addTextureBtn";
			this.addTextureBtn.Size = new System.Drawing.Size(94, 23);
			this.addTextureBtn.TabIndex = 6;
			this.addTextureBtn.Text = "Add Texture";
			this.addTextureBtn.UseVisualStyleBackColor = true;
			this.addTextureBtn.Click += new System.EventHandler(this.addTextureBtn_Click);
			// 
			// exitBtn
			// 
			this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.exitBtn.Location = new System.Drawing.Point(572, 526);
			this.exitBtn.Name = "exitBtn";
			this.exitBtn.Size = new System.Drawing.Size(94, 23);
			this.exitBtn.TabIndex = 3;
			this.exitBtn.Text = "Exit";
			this.exitBtn.UseVisualStyleBackColor = true;
			this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
			// 
			// metadataLbl
			// 
			this.metadataLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.metadataLbl.BackColor = System.Drawing.Color.Transparent;
			this.metadataLbl.Location = new System.Drawing.Point(8, 525);
			this.metadataLbl.Name = "metadataLbl";
			this.metadataLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.metadataLbl.Size = new System.Drawing.Size(519, 23);
			this.metadataLbl.TabIndex = 4;
			this.metadataLbl.Text = "metadata";
			this.metadataLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// filePathTxt
			// 
			this.filePathTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.filePathTxt.Location = new System.Drawing.Point(6, 8);
			this.filePathTxt.Name = "filePathTxt";
			this.filePathTxt.Size = new System.Drawing.Size(521, 20);
			this.filePathTxt.TabIndex = 5;
			// 
			// texturePic
			// 
			this.texturePic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.texturePic.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.texturePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.texturePic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.texturePic.Location = new System.Drawing.Point(6, 6);
			this.texturePic.Name = "texturePic";
			this.texturePic.Size = new System.Drawing.Size(521, 510);
			this.texturePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.texturePic.TabIndex = 8;
			this.texturePic.TabStop = false;
			// 
			// tabControl1
			// 
			this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.fileTab);
			this.tabControl1.Controls.Add(this.displayTab);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(560, 562);
			this.tabControl1.TabIndex = 9;
			// 
			// fileTab
			// 
			this.fileTab.Controls.Add(this.ImageDataGrid);
			this.fileTab.Controls.Add(this.textureLst);
			this.fileTab.Controls.Add(this.filePathTxt);
			this.fileTab.Location = new System.Drawing.Point(4, 4);
			this.fileTab.Name = "fileTab";
			this.fileTab.Padding = new System.Windows.Forms.Padding(3);
			this.fileTab.Size = new System.Drawing.Size(533, 554);
			this.fileTab.TabIndex = 0;
			this.fileTab.Text = "Textures";
			this.fileTab.UseVisualStyleBackColor = true;
			// 
			// ImageDataGrid
			// 
			this.ImageDataGrid.AllowUserToResizeRows = false;
			this.ImageDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ImageDataGrid.AutoGenerateColumns = false;
			this.ImageDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.ImageDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			this.ImageDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ImageDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.localNameDataGridViewTextBoxColumn,
            this.directoriesDataGridViewTextBoxColumn,
            this.formatDataGridViewTextBoxColumn,
            this.numBitsDataGridViewTextBoxColumn,
            this.intensityKeyDataGridViewTextBoxColumn,
            this.paletteKeyDataGridViewTextBoxColumn});
			this.ImageDataGrid.DataSource = this.imageFileBindingSource;
			this.ImageDataGrid.GridColor = System.Drawing.SystemColors.Control;
			this.ImageDataGrid.Location = new System.Drawing.Point(8, 34);
			this.ImageDataGrid.Name = "ImageDataGrid";
			this.ImageDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.ImageDataGrid.RowHeadersVisible = false;
			this.ImageDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.ImageDataGrid.Size = new System.Drawing.Size(519, 517);
			this.ImageDataGrid.TabIndex = 6;
			// 
			// localNameDataGridViewTextBoxColumn
			// 
			this.localNameDataGridViewTextBoxColumn.DataPropertyName = "localName";
			this.localNameDataGridViewTextBoxColumn.HeaderText = "localName";
			this.localNameDataGridViewTextBoxColumn.Name = "localNameDataGridViewTextBoxColumn";
			this.localNameDataGridViewTextBoxColumn.Width = 82;
			// 
			// directoriesDataGridViewTextBoxColumn
			// 
			this.directoriesDataGridViewTextBoxColumn.DataPropertyName = "directories";
			this.directoriesDataGridViewTextBoxColumn.HeaderText = "directories";
			this.directoriesDataGridViewTextBoxColumn.Name = "directoriesDataGridViewTextBoxColumn";
			this.directoriesDataGridViewTextBoxColumn.Width = 80;
			// 
			// formatDataGridViewTextBoxColumn
			// 
			this.formatDataGridViewTextBoxColumn.DataPropertyName = "format";
			this.formatDataGridViewTextBoxColumn.HeaderText = "format";
			this.formatDataGridViewTextBoxColumn.Name = "formatDataGridViewTextBoxColumn";
			this.formatDataGridViewTextBoxColumn.Width = 61;
			// 
			// numBitsDataGridViewTextBoxColumn
			// 
			this.numBitsDataGridViewTextBoxColumn.DataPropertyName = "numBits";
			this.numBitsDataGridViewTextBoxColumn.HeaderText = "numBits";
			this.numBitsDataGridViewTextBoxColumn.Name = "numBitsDataGridViewTextBoxColumn";
			this.numBitsDataGridViewTextBoxColumn.Width = 69;
			// 
			// intensityKeyDataGridViewTextBoxColumn
			// 
			this.intensityKeyDataGridViewTextBoxColumn.DataPropertyName = "intensityKey";
			this.intensityKeyDataGridViewTextBoxColumn.HeaderText = "intensityKey";
			this.intensityKeyDataGridViewTextBoxColumn.Name = "intensityKeyDataGridViewTextBoxColumn";
			this.intensityKeyDataGridViewTextBoxColumn.Width = 88;
			// 
			// paletteKeyDataGridViewTextBoxColumn
			// 
			this.paletteKeyDataGridViewTextBoxColumn.DataPropertyName = "paletteKey";
			this.paletteKeyDataGridViewTextBoxColumn.HeaderText = "paletteKey";
			this.paletteKeyDataGridViewTextBoxColumn.Name = "paletteKeyDataGridViewTextBoxColumn";
			this.paletteKeyDataGridViewTextBoxColumn.Width = 82;
			// 
			// imageFileBindingSource
			// 
			this.imageFileBindingSource.DataSource = typeof(WindowsFormsApp3.mainForm.imageFile);
			// 
			// displayTab
			// 
			this.displayTab.Controls.Add(this.texturePic);
			this.displayTab.Controls.Add(this.metadataLbl);
			this.displayTab.Location = new System.Drawing.Point(4, 4);
			this.displayTab.Name = "displayTab";
			this.displayTab.Padding = new System.Windows.Forms.Padding(3);
			this.displayTab.Size = new System.Drawing.Size(533, 554);
			this.displayTab.TabIndex = 1;
			this.displayTab.Text = "Image Preview";
			this.displayTab.UseVisualStyleBackColor = true;
			// 
			// imageFileBindingSource1
			// 
			this.imageFileBindingSource1.DataSource = typeof(WindowsFormsApp3.mainForm.imageFile);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.bitDepthCmb);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.texTypeCmb);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(566, 154);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(106, 100);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Texture Settings";
			// 
			// bitDepthCmb
			// 
			this.bitDepthCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.bitDepthCmb.FormattingEnabled = true;
			this.bitDepthCmb.Items.AddRange(new object[] {
            "32",
            "16",
            "8",
            "4"});
			this.bitDepthCmb.Location = new System.Drawing.Point(6, 72);
			this.bitDepthCmb.Name = "bitDepthCmb";
			this.bitDepthCmb.Size = new System.Drawing.Size(94, 21);
			this.bitDepthCmb.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Texture Type:";
			// 
			// texTypeCmb
			// 
			this.texTypeCmb.Cursor = System.Windows.Forms.Cursors.Default;
			this.texTypeCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.texTypeCmb.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.texTypeCmb.FormattingEnabled = true;
			this.texTypeCmb.Items.AddRange(new object[] {
            "I",
            "IA",
            "CI",
            "YUV",
            "RGB",
            "RGBA"});
			this.texTypeCmb.Location = new System.Drawing.Point(6, 32);
			this.texTypeCmb.Name = "texTypeCmb";
			this.texTypeCmb.Size = new System.Drawing.Size(94, 21);
			this.texTypeCmb.TabIndex = 0;
			this.texTypeCmb.SelectedIndexChanged += new System.EventHandler(this.texTypeCmb_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Bit Depth:";
			// 
			// paletteCmb
			// 
			this.paletteCmb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.paletteCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.paletteCmb.FormattingEnabled = true;
			this.paletteCmb.Location = new System.Drawing.Point(6, 32);
			this.paletteCmb.Name = "paletteCmb";
			this.paletteCmb.Size = new System.Drawing.Size(94, 21);
			this.paletteCmb.Sorted = true;
			this.paletteCmb.TabIndex = 4;
			// 
			// paletteSelectionCmb
			// 
			this.paletteSelectionCmb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.paletteSelectionCmb.AutoSize = true;
			this.paletteSelectionCmb.Location = new System.Drawing.Point(6, 16);
			this.paletteSelectionCmb.Name = "paletteSelectionCmb";
			this.paletteSelectionCmb.Size = new System.Drawing.Size(90, 13);
			this.paletteSelectionCmb.TabIndex = 13;
			this.paletteSelectionCmb.Text = "Palette Selection:";
			// 
			// alphaRad
			// 
			this.alphaRad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.alphaRad.AutoSize = true;
			this.alphaRad.Location = new System.Drawing.Point(6, 19);
			this.alphaRad.Name = "alphaRad";
			this.alphaRad.Size = new System.Drawing.Size(94, 17);
			this.alphaRad.TabIndex = 11;
			this.alphaRad.TabStop = true;
			this.alphaRad.Text = "Alpha Channel";
			this.alphaRad.UseVisualStyleBackColor = true;
			// 
			// intensitySelectorGroup
			// 
			this.intensitySelectorGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.intensitySelectorGroup.Controls.Add(this.blueRad);
			this.intensitySelectorGroup.Controls.Add(this.greenRad);
			this.intensitySelectorGroup.Controls.Add(this.redRad);
			this.intensitySelectorGroup.Controls.Add(this.grayscaleRad);
			this.intensitySelectorGroup.Controls.Add(this.alphaRad);
			this.intensitySelectorGroup.Location = new System.Drawing.Point(566, 260);
			this.intensitySelectorGroup.Name = "intensitySelectorGroup";
			this.intensitySelectorGroup.Size = new System.Drawing.Size(106, 134);
			this.intensitySelectorGroup.TabIndex = 12;
			this.intensitySelectorGroup.TabStop = false;
			this.intensitySelectorGroup.Text = "Intensity Key";
			// 
			// blueRad
			// 
			this.blueRad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.blueRad.AutoSize = true;
			this.blueRad.Location = new System.Drawing.Point(6, 88);
			this.blueRad.Name = "blueRad";
			this.blueRad.Size = new System.Drawing.Size(88, 17);
			this.blueRad.TabIndex = 15;
			this.blueRad.TabStop = true;
			this.blueRad.Text = "Blue Channel";
			this.blueRad.UseVisualStyleBackColor = true;
			// 
			// greenRad
			// 
			this.greenRad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.greenRad.AutoSize = true;
			this.greenRad.Location = new System.Drawing.Point(6, 65);
			this.greenRad.Name = "greenRad";
			this.greenRad.Size = new System.Drawing.Size(96, 17);
			this.greenRad.TabIndex = 14;
			this.greenRad.TabStop = true;
			this.greenRad.Text = "Green Channel";
			this.greenRad.UseVisualStyleBackColor = true;
			// 
			// redRad
			// 
			this.redRad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.redRad.AutoSize = true;
			this.redRad.Location = new System.Drawing.Point(6, 42);
			this.redRad.Name = "redRad";
			this.redRad.Size = new System.Drawing.Size(87, 17);
			this.redRad.TabIndex = 13;
			this.redRad.TabStop = true;
			this.redRad.Text = "Red Channel";
			this.redRad.UseVisualStyleBackColor = true;
			// 
			// grayscaleRad
			// 
			this.grayscaleRad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.grayscaleRad.AutoSize = true;
			this.grayscaleRad.Location = new System.Drawing.Point(6, 111);
			this.grayscaleRad.Name = "grayscaleRad";
			this.grayscaleRad.Size = new System.Drawing.Size(72, 17);
			this.grayscaleRad.TabIndex = 12;
			this.grayscaleRad.TabStop = true;
			this.grayscaleRad.Text = "Grayscale";
			this.grayscaleRad.UseVisualStyleBackColor = true;
			// 
			// ciPaletteGroup
			// 
			this.ciPaletteGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ciPaletteGroup.Controls.Add(this.modPaletteBtn);
			this.ciPaletteGroup.Controls.Add(this.createPaletteBtn);
			this.ciPaletteGroup.Controls.Add(this.paletteSelectionCmb);
			this.ciPaletteGroup.Controls.Add(this.paletteCmb);
			this.ciPaletteGroup.Location = new System.Drawing.Point(566, 260);
			this.ciPaletteGroup.Name = "ciPaletteGroup";
			this.ciPaletteGroup.Size = new System.Drawing.Size(106, 119);
			this.ciPaletteGroup.TabIndex = 14;
			this.ciPaletteGroup.TabStop = false;
			this.ciPaletteGroup.Text = "CI Palette";
			// 
			// createPaletteBtn
			// 
			this.createPaletteBtn.Location = new System.Drawing.Point(6, 60);
			this.createPaletteBtn.Name = "createPaletteBtn";
			this.createPaletteBtn.Size = new System.Drawing.Size(94, 23);
			this.createPaletteBtn.TabIndex = 14;
			this.createPaletteBtn.Text = "Create Palette";
			this.createPaletteBtn.UseVisualStyleBackColor = true;
			this.createPaletteBtn.Click += new System.EventHandler(this.createPaletteBtn_Click);
			// 
			// modPaletteBtn
			// 
			this.modPaletteBtn.Location = new System.Drawing.Point(7, 88);
			this.modPaletteBtn.Name = "modPaletteBtn";
			this.modPaletteBtn.Size = new System.Drawing.Size(93, 23);
			this.modPaletteBtn.TabIndex = 15;
			this.modPaletteBtn.Text = "Modify Palette";
			this.modPaletteBtn.UseVisualStyleBackColor = true;
			this.modPaletteBtn.Click += new System.EventHandler(this.modPaletteBtn_Click);
			// 
			// mainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 561);
			this.Controls.Add(this.ciPaletteGroup);
			this.Controls.Add(this.intensitySelectorGroup);
			this.Controls.Add(this.convertBtn);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.exitBtn);
			this.DoubleBuffered = true;
			this.MinimumSize = new System.Drawing.Size(350, 500);
			this.Name = "mainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Texture Convert";
			this.Load += new System.EventHandler(this.mainForm_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.texturePic)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.fileTab.ResumeLayout(false);
			this.fileTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ImageDataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imageFileBindingSource)).EndInit();
			this.displayTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.imageFileBindingSource1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.intensitySelectorGroup.ResumeLayout(false);
			this.intensitySelectorGroup.PerformLayout();
			this.ciPaletteGroup.ResumeLayout(false);
			this.ciPaletteGroup.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView textureLst;
        private System.Windows.Forms.ColumnHeader filename;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader bitDepth;
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label metadataLbl;
        private System.Windows.Forms.TextBox filePathTxt;
        private System.Windows.Forms.Button addTextureBtn;
        private System.Windows.Forms.PictureBox texturePic;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage fileTab;
        private System.Windows.Forms.TabPage displayTab;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox texTypeCmb;
        private System.Windows.Forms.ComboBox bitDepthCmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button removeTextureBtn;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button changeImglstBtn;
		private System.Windows.Forms.RadioButton alphaRad;
		private System.Windows.Forms.GroupBox intensitySelectorGroup;
		private System.Windows.Forms.RadioButton blueRad;
		private System.Windows.Forms.RadioButton greenRad;
		private System.Windows.Forms.RadioButton redRad;
		private System.Windows.Forms.RadioButton grayscaleRad;
		private System.Windows.Forms.ComboBox paletteCmb;
		private System.Windows.Forms.Label paletteSelectionCmb;
		private System.Windows.Forms.GroupBox ciPaletteGroup;
		private System.Windows.Forms.ColumnHeader dir;
		private System.Windows.Forms.ColumnHeader palette;
		private System.Windows.Forms.ColumnHeader intensity;
		private System.Windows.Forms.DataGridView ImageDataGrid;
		private System.Windows.Forms.BindingSource imageFileBindingSource;
		private System.Windows.Forms.BindingSource imageFileBindingSource1;
		private System.Windows.Forms.Button createPaletteBtn;
		private System.Windows.Forms.DataGridViewTextBoxColumn localNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn directoriesDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn formatDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn numBitsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn intensityKeyDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn paletteKeyDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button modPaletteBtn;
	}
}

