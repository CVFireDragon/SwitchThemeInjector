﻿namespace SwitchThemes
{
	partial class Form1
	{
		/// <summary>
		/// Variabile di progettazione necessaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Pulire le risorse in uso.
		/// </summary>
		/// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Codice generato da Progettazione Windows Form

		/// <summary>
		/// Metodo necessario per il supporto della finestra di progettazione. Non modificare
		/// il contenuto del metodo con l'editor di codice.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
			this.PatchListPage = new System.Windows.Forms.TabPage();
			this.tbPatches = new System.Windows.Forms.TextBox();
			this.InjectPage = new System.Windows.Forms.TabPage();
			this.tbBntxFile = new System.Windows.Forms.TextBox();
			this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.LayoutPatchList = new System.Windows.Forms.ComboBox();
			this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
			this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
			this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
			this.DdsConvPage = new System.Windows.Forms.TabPage();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
			this.ImageToDDSBtn = new MaterialSkin.Controls.MaterialRaisedButton();
			this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
			this.NCADumpPage = new System.Windows.Forms.TabPage();
			this.NCARunBtn = new MaterialSkin.Controls.MaterialRaisedButton();
			this.NCALogTb = new System.Windows.Forms.TextBox();
			this.OutputPathTb = new System.Windows.Forms.TextBox();
			this.OutputBtn = new MaterialSkin.Controls.MaterialFlatButton();
			this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
			this.mountPathTb = new System.Windows.Forms.TextBox();
			this.MountBtn = new MaterialSkin.Controls.MaterialFlatButton();
			this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
			this.linkLabel4 = new System.Windows.Forms.LinkLabel();
			this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
			this.AdvancedPage = new System.Windows.Forms.TabPage();
			this.AdvPanel = new System.Windows.Forms.Panel();
			this.materialRaisedButton7 = new MaterialSkin.Controls.MaterialRaisedButton();
			this.materialRaisedButton6 = new MaterialSkin.Controls.MaterialRaisedButton();
			this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
			this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
			this.SzsFileList = new System.Windows.Forms.ListBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.extractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
			this.materialRaisedButton5 = new MaterialSkin.Controls.MaterialRaisedButton();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
			this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
			this.label1 = new System.Windows.Forms.Label();
			this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
			this.lblDetected = new MaterialSkin.Controls.MaterialLabel();
			this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
			this.materialTabControl1.SuspendLayout();
			this.PatchListPage.SuspendLayout();
			this.InjectPage.SuspendLayout();
			this.DdsConvPage.SuspendLayout();
			this.NCADumpPage.SuspendLayout();
			this.AdvancedPage.SuspendLayout();
			this.AdvPanel.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// materialTabControl1
			// 
			this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.materialTabControl1.Controls.Add(this.PatchListPage);
			this.materialTabControl1.Controls.Add(this.InjectPage);
			this.materialTabControl1.Controls.Add(this.DdsConvPage);
			this.materialTabControl1.Controls.Add(this.NCADumpPage);
			this.materialTabControl1.Controls.Add(this.AdvancedPage);
			this.materialTabControl1.Depth = 0;
			this.materialTabControl1.Location = new System.Drawing.Point(-1, 150);
			this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialTabControl1.Name = "materialTabControl1";
			this.materialTabControl1.SelectedIndex = 0;
			this.materialTabControl1.Size = new System.Drawing.Size(646, 287);
			this.materialTabControl1.TabIndex = 4;
			// 
			// PatchListPage
			// 
			this.PatchListPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.PatchListPage.Controls.Add(this.tbPatches);
			this.PatchListPage.Location = new System.Drawing.Point(4, 22);
			this.PatchListPage.Name = "PatchListPage";
			this.PatchListPage.Size = new System.Drawing.Size(638, 261);
			this.PatchListPage.TabIndex = 2;
			this.PatchListPage.Text = "Patch list";
			// 
			// tbPatches
			// 
			this.tbPatches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbPatches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.tbPatches.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbPatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPatches.ForeColor = System.Drawing.Color.White;
			this.tbPatches.Location = new System.Drawing.Point(3, 3);
			this.tbPatches.Multiline = true;
			this.tbPatches.Name = "tbPatches";
			this.tbPatches.ReadOnly = true;
			this.tbPatches.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbPatches.Size = new System.Drawing.Size(635, 246);
			this.tbPatches.TabIndex = 12;
			// 
			// InjectPage
			// 
			this.InjectPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.InjectPage.Controls.Add(this.tbBntxFile);
			this.InjectPage.Controls.Add(this.materialLabel7);
			this.InjectPage.Controls.Add(this.linkLabel1);
			this.InjectPage.Controls.Add(this.LayoutPatchList);
			this.InjectPage.Controls.Add(this.materialLabel6);
			this.InjectPage.Controls.Add(this.materialLabel1);
			this.InjectPage.Controls.Add(this.materialFlatButton1);
			this.InjectPage.Controls.Add(this.materialLabel2);
			this.InjectPage.Controls.Add(this.materialRaisedButton2);
			this.InjectPage.Controls.Add(this.materialLabel3);
			this.InjectPage.Location = new System.Drawing.Point(4, 22);
			this.InjectPage.Name = "InjectPage";
			this.InjectPage.Padding = new System.Windows.Forms.Padding(3);
			this.InjectPage.Size = new System.Drawing.Size(638, 261);
			this.InjectPage.TabIndex = 1;
			this.InjectPage.Text = "Inject & patch";
			// 
			// tbBntxFile
			// 
			this.tbBntxFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbBntxFile.Location = new System.Drawing.Point(65, 38);
			this.tbBntxFile.Name = "tbBntxFile";
			this.tbBntxFile.Size = new System.Drawing.Size(530, 20);
			this.tbBntxFile.TabIndex = 1;
			// 
			// materialLabel7
			// 
			this.materialLabel7.Depth = 0;
			this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel7.Location = new System.Drawing.Point(6, 94);
			this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel7.Name = "materialLabel7";
			this.materialLabel7.Size = new System.Drawing.Size(620, 64);
			this.materialLabel7.TabIndex = 10;
			this.materialLabel7.Text = resources.GetString("materialLabel7.Text");
			// 
			// linkLabel1
			// 
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel1.LinkColor = System.Drawing.SystemColors.MenuHighlight;
			this.linkLabel1.Location = new System.Drawing.Point(547, 67);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(84, 21);
			this.linkLabel1.TabIndex = 9;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Preview layout";
			this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// LayoutPatchList
			// 
			this.LayoutPatchList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LayoutPatchList.BackColor = System.Drawing.Color.White;
			this.LayoutPatchList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.LayoutPatchList.FormattingEnabled = true;
			this.LayoutPatchList.Items.AddRange(new object[] {
            "Don\'t patch"});
			this.LayoutPatchList.Location = new System.Drawing.Point(108, 67);
			this.LayoutPatchList.Name = "LayoutPatchList";
			this.LayoutPatchList.Size = new System.Drawing.Size(433, 21);
			this.LayoutPatchList.TabIndex = 8;
			// 
			// materialLabel6
			// 
			this.materialLabel6.Depth = 0;
			this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel6.Location = new System.Drawing.Point(6, 67);
			this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel6.Name = "materialLabel6";
			this.materialLabel6.Size = new System.Drawing.Size(103, 19);
			this.materialLabel6.TabIndex = 7;
			this.materialLabel6.Text = "Layout patch: ";
			// 
			// materialLabel1
			// 
			this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel1.Location = new System.Drawing.Point(6, 8);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(628, 20);
			this.materialLabel1.TabIndex = 6;
			this.materialLabel1.Text = "Since version 3.2 you don\'t need a DDS anymore, just open any 720p image !";
			this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// materialFlatButton1
			// 
			this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.materialFlatButton1.AutoSize = true;
			this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialFlatButton1.Depth = 0;
			this.materialFlatButton1.ForeColor = System.Drawing.Color.White;
			this.materialFlatButton1.Icon = null;
			this.materialFlatButton1.Location = new System.Drawing.Point(602, 30);
			this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialFlatButton1.Name = "materialFlatButton1";
			this.materialFlatButton1.Primary = false;
			this.materialFlatButton1.Size = new System.Drawing.Size(32, 36);
			this.materialFlatButton1.TabIndex = 3;
			this.materialFlatButton1.Text = "...";
			this.materialFlatButton1.UseVisualStyleBackColor = true;
			this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
			// 
			// materialLabel2
			// 
			this.materialLabel2.Depth = 0;
			this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel2.Location = new System.Drawing.Point(6, 38);
			this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel2.Name = "materialLabel2";
			this.materialLabel2.Size = new System.Drawing.Size(63, 19);
			this.materialLabel2.TabIndex = 2;
			this.materialLabel2.Text = "Image: ";
			// 
			// materialRaisedButton2
			// 
			this.materialRaisedButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.materialRaisedButton2.AutoSize = true;
			this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialRaisedButton2.Depth = 0;
			this.materialRaisedButton2.Icon = null;
			this.materialRaisedButton2.Location = new System.Drawing.Point(499, 219);
			this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialRaisedButton2.Name = "materialRaisedButton2";
			this.materialRaisedButton2.Primary = true;
			this.materialRaisedButton2.Size = new System.Drawing.Size(135, 36);
			this.materialRaisedButton2.TabIndex = 0;
			this.materialRaisedButton2.Text = "Patch and save";
			this.materialRaisedButton2.UseVisualStyleBackColor = true;
			this.materialRaisedButton2.Click += new System.EventHandler(this.PatchButtonClick);
			// 
			// materialLabel3
			// 
			this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.materialLabel3.Depth = 0;
			this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel3.Location = new System.Drawing.Point(6, 158);
			this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel3.Name = "materialLabel3";
			this.materialLabel3.Size = new System.Drawing.Size(525, 101);
			this.materialLabel3.TabIndex = 5;
			this.materialLabel3.Text = resources.GetString("materialLabel3.Text");
			// 
			// DdsConvPage
			// 
			this.DdsConvPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.DdsConvPage.Controls.Add(this.linkLabel3);
			this.DdsConvPage.Controls.Add(this.linkLabel2);
			this.DdsConvPage.Controls.Add(this.materialLabel9);
			this.DdsConvPage.Controls.Add(this.ImageToDDSBtn);
			this.DdsConvPage.Controls.Add(this.materialLabel8);
			this.DdsConvPage.ForeColor = System.Drawing.Color.White;
			this.DdsConvPage.Location = new System.Drawing.Point(4, 22);
			this.DdsConvPage.Name = "DdsConvPage";
			this.DdsConvPage.Padding = new System.Windows.Forms.Padding(3);
			this.DdsConvPage.Size = new System.Drawing.Size(638, 261);
			this.DdsConvPage.TabIndex = 4;
			this.DdsConvPage.Text = "Image to DDS";
			// 
			// linkLabel3
			// 
			this.linkLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel3.LinkColor = System.Drawing.SystemColors.MenuHighlight;
			this.linkLabel3.Location = new System.Drawing.Point(0, 218);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(638, 16);
			this.linkLabel3.TabIndex = 11;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "Open the Auto-Theme page";
			this.linkLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
			// 
			// linkLabel2
			// 
			this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel2.LinkColor = System.Drawing.SystemColors.MenuHighlight;
			this.linkLabel2.Location = new System.Drawing.Point(0, 199);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(638, 16);
			this.linkLabel2.TabIndex = 10;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Open the web version of the injector";
			this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// materialLabel9
			// 
			this.materialLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.materialLabel9.Depth = 0;
			this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel9.Location = new System.Drawing.Point(6, 146);
			this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel9.Name = "materialLabel9";
			this.materialLabel9.Size = new System.Drawing.Size(629, 26);
			this.materialLabel9.TabIndex = 9;
			this.materialLabel9.Text = "The converted files will be saved in the same directory of the originals";
			this.materialLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ImageToDDSBtn
			// 
			this.ImageToDDSBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.ImageToDDSBtn.AutoSize = true;
			this.ImageToDDSBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ImageToDDSBtn.Depth = 0;
			this.ImageToDDSBtn.Icon = null;
			this.ImageToDDSBtn.Location = new System.Drawing.Point(265, 106);
			this.ImageToDDSBtn.MouseState = MaterialSkin.MouseState.HOVER;
			this.ImageToDDSBtn.Name = "ImageToDDSBtn";
			this.ImageToDDSBtn.Primary = true;
			this.ImageToDDSBtn.Size = new System.Drawing.Size(111, 36);
			this.ImageToDDSBtn.TabIndex = 8;
			this.ImageToDDSBtn.Text = "Open images";
			this.ImageToDDSBtn.UseVisualStyleBackColor = true;
			this.ImageToDDSBtn.Click += new System.EventHandler(this.ImageToDDSBtn_Click);
			// 
			// materialLabel8
			// 
			this.materialLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.materialLabel8.Depth = 0;
			this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel8.Location = new System.Drawing.Point(2, 3);
			this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel8.Name = "materialLabel8";
			this.materialLabel8.Size = new System.Drawing.Size(633, 101);
			this.materialLabel8.TabIndex = 7;
			this.materialLabel8.Text = resources.GetString("materialLabel8.Text");
			this.materialLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// NCADumpPage
			// 
			this.NCADumpPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.NCADumpPage.Controls.Add(this.NCARunBtn);
			this.NCADumpPage.Controls.Add(this.NCALogTb);
			this.NCADumpPage.Controls.Add(this.OutputPathTb);
			this.NCADumpPage.Controls.Add(this.OutputBtn);
			this.NCADumpPage.Controls.Add(this.materialLabel14);
			this.NCADumpPage.Controls.Add(this.mountPathTb);
			this.NCADumpPage.Controls.Add(this.MountBtn);
			this.NCADumpPage.Controls.Add(this.materialLabel13);
			this.NCADumpPage.Controls.Add(this.linkLabel4);
			this.NCADumpPage.Controls.Add(this.materialLabel10);
			this.NCADumpPage.Location = new System.Drawing.Point(4, 22);
			this.NCADumpPage.Name = "NCADumpPage";
			this.NCADumpPage.Padding = new System.Windows.Forms.Padding(3);
			this.NCADumpPage.Size = new System.Drawing.Size(638, 261);
			this.NCADumpPage.TabIndex = 5;
			this.NCADumpPage.Text = "Extract NCA";
			// 
			// NCARunBtn
			// 
			this.NCARunBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.NCARunBtn.AutoSize = true;
			this.NCARunBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.NCARunBtn.Depth = 0;
			this.NCARunBtn.Icon = null;
			this.NCARunBtn.Location = new System.Drawing.Point(584, 219);
			this.NCARunBtn.MouseState = MaterialSkin.MouseState.HOVER;
			this.NCARunBtn.Name = "NCARunBtn";
			this.NCARunBtn.Primary = true;
			this.NCARunBtn.Size = new System.Drawing.Size(48, 36);
			this.NCARunBtn.TabIndex = 28;
			this.NCARunBtn.Text = "RUN";
			this.NCARunBtn.UseVisualStyleBackColor = true;
			this.NCARunBtn.Click += new System.EventHandler(this.NCARunBtn_Click);
			// 
			// NCALogTb
			// 
			this.NCALogTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NCALogTb.BackColor = System.Drawing.Color.Black;
			this.NCALogTb.ForeColor = System.Drawing.Color.White;
			this.NCALogTb.Location = new System.Drawing.Point(6, 125);
			this.NCALogTb.Multiline = true;
			this.NCALogTb.Name = "NCALogTb";
			this.NCALogTb.ReadOnly = true;
			this.NCALogTb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.NCALogTb.Size = new System.Drawing.Size(572, 126);
			this.NCALogTb.TabIndex = 27;
			this.NCALogTb.Text = "Hactool LOG:";
			this.NCALogTb.Visible = false;
			// 
			// OutputPathTb
			// 
			this.OutputPathTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.OutputPathTb.Location = new System.Drawing.Point(99, 89);
			this.OutputPathTb.Name = "OutputPathTb";
			this.OutputPathTb.Size = new System.Drawing.Size(492, 20);
			this.OutputPathTb.TabIndex = 24;
			// 
			// OutputBtn
			// 
			this.OutputBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.OutputBtn.AutoSize = true;
			this.OutputBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.OutputBtn.Depth = 0;
			this.OutputBtn.ForeColor = System.Drawing.Color.White;
			this.OutputBtn.Icon = null;
			this.OutputBtn.Location = new System.Drawing.Point(598, 80);
			this.OutputBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.OutputBtn.MouseState = MaterialSkin.MouseState.HOVER;
			this.OutputBtn.Name = "OutputBtn";
			this.OutputBtn.Primary = false;
			this.OutputBtn.Size = new System.Drawing.Size(32, 36);
			this.OutputBtn.TabIndex = 26;
			this.OutputBtn.Text = "...";
			this.OutputBtn.UseVisualStyleBackColor = true;
			this.OutputBtn.Click += new System.EventHandler(this.OutputBtn_Click);
			// 
			// materialLabel14
			// 
			this.materialLabel14.Depth = 0;
			this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel14.Location = new System.Drawing.Point(9, 89);
			this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel14.Name = "materialLabel14";
			this.materialLabel14.Size = new System.Drawing.Size(145, 20);
			this.materialLabel14.TabIndex = 25;
			this.materialLabel14.Text = "Output path: ";
			// 
			// mountPathTb
			// 
			this.mountPathTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mountPathTb.Location = new System.Drawing.Point(145, 45);
			this.mountPathTb.Name = "mountPathTb";
			this.mountPathTb.Size = new System.Drawing.Size(446, 20);
			this.mountPathTb.TabIndex = 21;
			// 
			// MountBtn
			// 
			this.MountBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.MountBtn.AutoSize = true;
			this.MountBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.MountBtn.Depth = 0;
			this.MountBtn.ForeColor = System.Drawing.Color.White;
			this.MountBtn.Icon = null;
			this.MountBtn.Location = new System.Drawing.Point(598, 37);
			this.MountBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.MountBtn.MouseState = MaterialSkin.MouseState.HOVER;
			this.MountBtn.Name = "MountBtn";
			this.MountBtn.Primary = false;
			this.MountBtn.Size = new System.Drawing.Size(32, 36);
			this.MountBtn.TabIndex = 23;
			this.MountBtn.Text = "...";
			this.MountBtn.UseVisualStyleBackColor = true;
			this.MountBtn.Click += new System.EventHandler(this.MountBtn_Click);
			// 
			// materialLabel13
			// 
			this.materialLabel13.Depth = 0;
			this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel13.Location = new System.Drawing.Point(9, 45);
			this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel13.Name = "materialLabel13";
			this.materialLabel13.Size = new System.Drawing.Size(145, 20);
			this.materialLabel13.TabIndex = 22;
			this.materialLabel13.Text = "Switch mount path: ";
			// 
			// linkLabel4
			// 
			this.linkLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel4.LinkColor = System.Drawing.SystemColors.MenuHighlight;
			this.linkLabel4.Location = new System.Drawing.Point(0, 26);
			this.linkLabel4.Name = "linkLabel4";
			this.linkLabel4.Size = new System.Drawing.Size(631, 16);
			this.linkLabel4.TabIndex = 12;
			this.linkLabel4.TabStop = true;
			this.linkLabel4.Text = "Click to open the guide";
			this.linkLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
			// 
			// materialLabel10
			// 
			this.materialLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.materialLabel10.Depth = 0;
			this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel10.Location = new System.Drawing.Point(6, 3);
			this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel10.Name = "materialLabel10";
			this.materialLabel10.Size = new System.Drawing.Size(625, 23);
			this.materialLabel10.TabIndex = 8;
			this.materialLabel10.Text = "Use this page to extract the home menu files from your nand, FOLLOW THE ONLINE GU" +
    "IDE.";
			this.materialLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AdvancedPage
			// 
			this.AdvancedPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.AdvancedPage.Controls.Add(this.AdvPanel);
			this.AdvancedPage.Controls.Add(this.checkBox1);
			this.AdvancedPage.Controls.Add(this.materialLabel4);
			this.AdvancedPage.Location = new System.Drawing.Point(4, 22);
			this.AdvancedPage.Name = "AdvancedPage";
			this.AdvancedPage.Padding = new System.Windows.Forms.Padding(3);
			this.AdvancedPage.Size = new System.Drawing.Size(638, 261);
			this.AdvancedPage.TabIndex = 3;
			this.AdvancedPage.Text = "Advanced";
			// 
			// AdvPanel
			// 
			this.AdvPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AdvPanel.Controls.Add(this.materialRaisedButton7);
			this.AdvPanel.Controls.Add(this.materialRaisedButton6);
			this.AdvPanel.Controls.Add(this.materialRaisedButton4);
			this.AdvPanel.Controls.Add(this.materialLabel5);
			this.AdvPanel.Controls.Add(this.SzsFileList);
			this.AdvPanel.Controls.Add(this.materialRaisedButton1);
			this.AdvPanel.Controls.Add(this.materialRaisedButton5);
			this.AdvPanel.Enabled = false;
			this.AdvPanel.Location = new System.Drawing.Point(9, 52);
			this.AdvPanel.Name = "AdvPanel";
			this.AdvPanel.Size = new System.Drawing.Size(620, 206);
			this.AdvPanel.TabIndex = 7;
			this.AdvPanel.Visible = false;
			// 
			// materialRaisedButton7
			// 
			this.materialRaisedButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.materialRaisedButton7.AutoSize = true;
			this.materialRaisedButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialRaisedButton7.Depth = 0;
			this.materialRaisedButton7.Icon = null;
			this.materialRaisedButton7.Location = new System.Drawing.Point(401, 164);
			this.materialRaisedButton7.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialRaisedButton7.Name = "materialRaisedButton7";
			this.materialRaisedButton7.Primary = true;
			this.materialRaisedButton7.Size = new System.Drawing.Size(79, 36);
			this.materialRaisedButton7.TabIndex = 10;
			this.materialRaisedButton7.Text = "File diff";
			this.materialRaisedButton7.UseVisualStyleBackColor = true;
			this.materialRaisedButton7.Click += new System.EventHandler(this.materialRaisedButton7_Click);
			// 
			// materialRaisedButton6
			// 
			this.materialRaisedButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.materialRaisedButton6.AutoSize = true;
			this.materialRaisedButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialRaisedButton6.Depth = 0;
			this.materialRaisedButton6.Icon = null;
			this.materialRaisedButton6.Location = new System.Drawing.Point(294, 164);
			this.materialRaisedButton6.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialRaisedButton6.Name = "materialRaisedButton6";
			this.materialRaisedButton6.Primary = true;
			this.materialRaisedButton6.Size = new System.Drawing.Size(104, 36);
			this.materialRaisedButton6.TabIndex = 9;
			this.materialRaisedButton6.Text = "Layout diff";
			this.materialRaisedButton6.UseVisualStyleBackColor = true;
			this.materialRaisedButton6.Click += new System.EventHandler(this.materialRaisedButton6_Click);
			// 
			// materialRaisedButton4
			// 
			this.materialRaisedButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.materialRaisedButton4.AutoSize = true;
			this.materialRaisedButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialRaisedButton4.Depth = 0;
			this.materialRaisedButton4.Icon = null;
			this.materialRaisedButton4.Location = new System.Drawing.Point(181, 164);
			this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialRaisedButton4.Name = "materialRaisedButton4";
			this.materialRaisedButton4.Primary = true;
			this.materialRaisedButton4.Size = new System.Drawing.Size(110, 36);
			this.materialRaisedButton4.TabIndex = 8;
			this.materialRaisedButton4.Text = "Diff file list";
			this.materialRaisedButton4.UseVisualStyleBackColor = true;
			this.materialRaisedButton4.Click += new System.EventHandler(this.materialRaisedButton4_Click);
			// 
			// materialLabel5
			// 
			this.materialLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.materialLabel5.Depth = 0;
			this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel5.Location = new System.Drawing.Point(3, 0);
			this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel5.Name = "materialLabel5";
			this.materialLabel5.Size = new System.Drawing.Size(614, 23);
			this.materialLabel5.TabIndex = 7;
			this.materialLabel5.Text = "Files in the SZS : (left click to replace or extract)";
			// 
			// SzsFileList
			// 
			this.SzsFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SzsFileList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.SzsFileList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.SzsFileList.ContextMenuStrip = this.contextMenuStrip1;
			this.SzsFileList.ForeColor = System.Drawing.Color.White;
			this.SzsFileList.FormattingEnabled = true;
			this.SzsFileList.Location = new System.Drawing.Point(3, 26);
			this.SzsFileList.Name = "SzsFileList";
			this.SzsFileList.Size = new System.Drawing.Size(614, 117);
			this.SzsFileList.Sorted = true;
			this.SzsFileList.TabIndex = 5;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractToolStripMenuItem,
            this.replaceToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(116, 48);
			// 
			// extractToolStripMenuItem
			// 
			this.extractToolStripMenuItem.Name = "extractToolStripMenuItem";
			this.extractToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
			this.extractToolStripMenuItem.Text = "Extract";
			this.extractToolStripMenuItem.Click += new System.EventHandler(this.extractToolStripMenuItem_Click);
			// 
			// replaceToolStripMenuItem
			// 
			this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
			this.replaceToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
			this.replaceToolStripMenuItem.Text = "Replace";
			this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
			// 
			// materialRaisedButton1
			// 
			this.materialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.materialRaisedButton1.AutoSize = true;
			this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialRaisedButton1.Depth = 0;
			this.materialRaisedButton1.Icon = null;
			this.materialRaisedButton1.Location = new System.Drawing.Point(485, 164);
			this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialRaisedButton1.Name = "materialRaisedButton1";
			this.materialRaisedButton1.Primary = true;
			this.materialRaisedButton1.Size = new System.Drawing.Size(132, 36);
			this.materialRaisedButton1.TabIndex = 4;
			this.materialRaisedButton1.Text = "Save edited SZS";
			this.materialRaisedButton1.UseVisualStyleBackColor = true;
			this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
			// 
			// materialRaisedButton5
			// 
			this.materialRaisedButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.materialRaisedButton5.AutoSize = true;
			this.materialRaisedButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialRaisedButton5.Depth = 0;
			this.materialRaisedButton5.Icon = null;
			this.materialRaisedButton5.Location = new System.Drawing.Point(3, 164);
			this.materialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialRaisedButton5.Name = "materialRaisedButton5";
			this.materialRaisedButton5.Primary = true;
			this.materialRaisedButton5.Size = new System.Drawing.Size(175, 36);
			this.materialRaisedButton5.TabIndex = 3;
			this.materialRaisedButton5.Text = "Texture usage Count";
			this.materialRaisedButton5.UseVisualStyleBackColor = true;
			this.materialRaisedButton5.Click += new System.EventHandler(this.materialRaisedButton5_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBox1.AutoSize = true;
			this.checkBox1.ForeColor = System.Drawing.Color.White;
			this.checkBox1.Location = new System.Drawing.Point(494, 28);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(135, 17);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Enable advanced tools";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// materialLabel4
			// 
			this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.materialLabel4.Depth = 0;
			this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel4.Location = new System.Drawing.Point(0, 3);
			this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel4.Name = "materialLabel4";
			this.materialLabel4.Size = new System.Drawing.Size(638, 46);
			this.materialLabel4.TabIndex = 6;
			this.materialLabel4.Text = "Advanced tools allow you to manually edit the szs and more to create custom patch" +
    "es, enable them only if you know what you\'re doing";
			// 
			// materialRaisedButton3
			// 
			this.materialRaisedButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.materialRaisedButton3.AutoSize = true;
			this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialRaisedButton3.Depth = 0;
			this.materialRaisedButton3.Icon = null;
			this.materialRaisedButton3.Location = new System.Drawing.Point(279, 52);
			this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialRaisedButton3.Name = "materialRaisedButton3";
			this.materialRaisedButton3.Primary = true;
			this.materialRaisedButton3.Size = new System.Drawing.Size(85, 36);
			this.materialRaisedButton3.TabIndex = 11;
			this.materialRaisedButton3.Text = "Open szs";
			this.materialRaisedButton3.UseVisualStyleBackColor = true;
			this.materialRaisedButton3.Click += new System.EventHandler(this.OpenSzsButton);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(0, 426);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Exelix @ Team Qcean";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// materialTabSelector1
			// 
			this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
			this.materialTabSelector1.Depth = 0;
			this.materialTabSelector1.Location = new System.Drawing.Point(-1, 116);
			this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialTabSelector1.Name = "materialTabSelector1";
			this.materialTabSelector1.Size = new System.Drawing.Size(646, 30);
			this.materialTabSelector1.TabIndex = 5;
			this.materialTabSelector1.Text = "materialTabSelector1";
			// 
			// lblDetected
			// 
			this.lblDetected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDetected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.lblDetected.Depth = 0;
			this.lblDetected.Font = new System.Drawing.Font("Roboto", 11F);
			this.lblDetected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblDetected.Location = new System.Drawing.Point(-1, 91);
			this.lblDetected.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblDetected.Name = "lblDetected";
			this.lblDetected.Size = new System.Drawing.Size(646, 22);
			this.lblDetected.TabIndex = 13;
			this.lblDetected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblDetected.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseDown);
			// 
			// materialDivider1
			// 
			this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
			this.materialDivider1.Depth = 0;
			this.materialDivider1.Location = new System.Drawing.Point(-1, 63);
			this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialDivider1.Name = "materialDivider1";
			this.materialDivider1.Size = new System.Drawing.Size(646, 67);
			this.materialDivider1.TabIndex = 14;
			this.materialDivider1.Text = "materialDivider1";
			this.materialDivider1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseDown);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(645, 439);
			this.Controls.Add(this.lblDetected);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.materialRaisedButton3);
			this.Controls.Add(this.materialTabSelector1);
			this.Controls.Add(this.materialTabControl1);
			this.Controls.Add(this.materialDivider1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(645, 439);
			this.Name = "Form1";
			this.Text = "Qcean\'s Switch theme injector";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.materialTabControl1.ResumeLayout(false);
			this.PatchListPage.ResumeLayout(false);
			this.PatchListPage.PerformLayout();
			this.InjectPage.ResumeLayout(false);
			this.InjectPage.PerformLayout();
			this.DdsConvPage.ResumeLayout(false);
			this.DdsConvPage.PerformLayout();
			this.NCADumpPage.ResumeLayout(false);
			this.NCADumpPage.PerformLayout();
			this.AdvancedPage.ResumeLayout(false);
			this.AdvancedPage.PerformLayout();
			this.AdvPanel.ResumeLayout(false);
			this.AdvPanel.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
		private System.Windows.Forms.TabPage InjectPage;
		private MaterialSkin.Controls.MaterialLabel materialLabel3;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
		private System.Windows.Forms.TextBox tbBntxFile;
		private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
		private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
		private System.Windows.Forms.Label label1;
		private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
		private System.Windows.Forms.TabPage PatchListPage;
		private System.Windows.Forms.TextBox tbPatches;
		private MaterialSkin.Controls.MaterialLabel lblDetected;
		private MaterialSkin.Controls.MaterialDivider materialDivider1;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private System.Windows.Forms.TabPage AdvancedPage;
		private System.Windows.Forms.CheckBox checkBox1;
		private MaterialSkin.Controls.MaterialLabel materialLabel4;
		private System.Windows.Forms.Panel AdvPanel;
		private MaterialSkin.Controls.MaterialLabel materialLabel5;
		private System.Windows.Forms.ListBox SzsFileList;
		private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
		private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton5;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem extractToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
		private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton4;
		private System.Windows.Forms.ComboBox LayoutPatchList;
		private MaterialSkin.Controls.MaterialLabel materialLabel6;
		private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton6;
		private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton7;
		private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private MaterialSkin.Controls.MaterialLabel materialLabel7;
		private System.Windows.Forms.TabPage DdsConvPage;
		private MaterialSkin.Controls.MaterialLabel materialLabel8;
		private MaterialSkin.Controls.MaterialRaisedButton ImageToDDSBtn;
		private MaterialSkin.Controls.MaterialLabel materialLabel9;
		private System.Windows.Forms.LinkLabel linkLabel3;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.TabPage NCADumpPage;
		private System.Windows.Forms.TextBox OutputPathTb;
		private MaterialSkin.Controls.MaterialFlatButton OutputBtn;
		private MaterialSkin.Controls.MaterialLabel materialLabel14;
		private System.Windows.Forms.TextBox mountPathTb;
		private MaterialSkin.Controls.MaterialFlatButton MountBtn;
		private MaterialSkin.Controls.MaterialLabel materialLabel13;
		private System.Windows.Forms.LinkLabel linkLabel4;
		private MaterialSkin.Controls.MaterialLabel materialLabel10;
		private MaterialSkin.Controls.MaterialRaisedButton NCARunBtn;
		private System.Windows.Forms.TextBox NCALogTb;
	}
}

