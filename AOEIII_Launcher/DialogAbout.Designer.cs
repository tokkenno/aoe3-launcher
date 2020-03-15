namespace AOEIII_Launcher
{
    partial class DialogAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogAbout));
            this.pTitle = new System.Windows.Forms.Panel();
            this.lVersion = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.lWebPage = new System.Windows.Forms.LinkLabel();
            this.lTitle = new System.Windows.Forms.Label();
            this.pInfo = new System.Windows.Forms.Panel();
            this.tbAbout = new System.Windows.Forms.TabControl();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.lCopyrightAoe = new System.Windows.Forms.Label();
            this.linkAuthorWebPage = new System.Windows.Forms.LinkLabel();
            this.lCopyright = new System.Windows.Forms.Label();
            this.lAuthorWebPage = new System.Windows.Forms.Label();
            this.linkAuthor = new System.Windows.Forms.LinkLabel();
            this.lAuthor = new System.Windows.Forms.Label();
            this.pbLogotipo = new System.Windows.Forms.PictureBox();
            this.tabTranslations = new System.Windows.Forms.TabPage();
            this.tbTranslation = new System.Windows.Forms.TextBox();
            this.tabMods = new System.Windows.Forms.TabPage();
            this.tbMods = new System.Windows.Forms.TabControl();
            this.tabPopMod = new System.Windows.Forms.TabPage();
            this.tbPopModLicense = new System.Windows.Forms.TextBox();
            this.lPopModLicense = new System.Windows.Forms.Label();
            this.lPopModAuthorName = new System.Windows.Forms.Label();
            this.lPopModAuthor = new System.Windows.Forms.Label();
            this.pTitle.SuspendLayout();
            this.pInfo.SuspendLayout();
            this.tbAbout.SuspendLayout();
            this.tabInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogotipo)).BeginInit();
            this.tabTranslations.SuspendLayout();
            this.tabMods.SuspendLayout();
            this.tbMods.SuspendLayout();
            this.tabPopMod.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitle
            // 
            this.pTitle.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pTitle.Controls.Add(this.lVersion);
            this.pTitle.Controls.Add(this.bClose);
            this.pTitle.Controls.Add(this.lWebPage);
            this.pTitle.Controls.Add(this.lTitle);
            this.pTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitle.Location = new System.Drawing.Point(0, 0);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(529, 66);
            this.pTitle.TabIndex = 0;
            // 
            // lVersion
            // 
            this.lVersion.AutoSize = true;
            this.lVersion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lVersion.Location = new System.Drawing.Point(441, 9);
            this.lVersion.Name = "lVersion";
            this.lVersion.Size = new System.Drawing.Size(55, 13);
            this.lVersion.TabIndex = 5;
            this.lVersion.Text = "VERSION";
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(430, 37);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(89, 23);
            this.bClose.TabIndex = 0;
            this.bClose.Text = "CLOSE";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // lWebPage
            // 
            this.lWebPage.AutoSize = true;
            this.lWebPage.Location = new System.Drawing.Point(6, 50);
            this.lWebPage.Name = "lWebPage";
            this.lWebPage.Size = new System.Drawing.Size(64, 13);
            this.lWebPage.TabIndex = 1;
            this.lWebPage.TabStop = true;
            this.lWebPage.Text = "WEB PAGE";
            this.lWebPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lWebPage_LinkClicked);
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(3, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(90, 35);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "TITLE";
            // 
            // pInfo
            // 
            this.pInfo.BackgroundImage = global::AOEIII_Launcher.Properties.Resources.about_bg_degree;
            this.pInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pInfo.Controls.Add(this.tbAbout);
            this.pInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pInfo.Location = new System.Drawing.Point(0, 66);
            this.pInfo.Name = "pInfo";
            this.pInfo.Padding = new System.Windows.Forms.Padding(10);
            this.pInfo.Size = new System.Drawing.Size(529, 240);
            this.pInfo.TabIndex = 1;
            // 
            // tbAbout
            // 
            this.tbAbout.Controls.Add(this.tabInfo);
            this.tbAbout.Controls.Add(this.tabTranslations);
            this.tbAbout.Controls.Add(this.tabMods);
            this.tbAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAbout.Location = new System.Drawing.Point(10, 10);
            this.tbAbout.Name = "tbAbout";
            this.tbAbout.SelectedIndex = 0;
            this.tbAbout.Size = new System.Drawing.Size(509, 220);
            this.tbAbout.TabIndex = 0;
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.lCopyrightAoe);
            this.tabInfo.Controls.Add(this.linkAuthorWebPage);
            this.tabInfo.Controls.Add(this.lCopyright);
            this.tabInfo.Controls.Add(this.lAuthorWebPage);
            this.tabInfo.Controls.Add(this.linkAuthor);
            this.tabInfo.Controls.Add(this.lAuthor);
            this.tabInfo.Controls.Add(this.pbLogotipo);
            this.tabInfo.Location = new System.Drawing.Point(4, 22);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(501, 194);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.Text = "INFORMATION";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // lCopyrightAoe
            // 
            this.lCopyrightAoe.AutoSize = true;
            this.lCopyrightAoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCopyrightAoe.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lCopyrightAoe.Location = new System.Drawing.Point(6, 174);
            this.lCopyrightAoe.Name = "lCopyrightAoe";
            this.lCopyrightAoe.Size = new System.Drawing.Size(97, 13);
            this.lCopyrightAoe.TabIndex = 6;
            this.lCopyrightAoe.Text = "COPYRIGHT AOE3";
            // 
            // linkAuthorWebPage
            // 
            this.linkAuthorWebPage.AutoSize = true;
            this.linkAuthorWebPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAuthorWebPage.LinkColor = System.Drawing.Color.DarkSlateBlue;
            this.linkAuthorWebPage.Location = new System.Drawing.Point(309, 70);
            this.linkAuthorWebPage.Name = "linkAuthorWebPage";
            this.linkAuthorWebPage.Size = new System.Drawing.Size(103, 15);
            this.linkAuthorWebPage.TabIndex = 5;
            this.linkAuthorWebPage.TabStop = true;
            this.linkAuthorWebPage.Text = "Proyect Source";
            this.linkAuthorWebPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAuthorWebPage_LinkClicked);
            // 
            // lCopyright
            // 
            this.lCopyright.AutoSize = true;
            this.lCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCopyright.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lCopyright.Location = new System.Drawing.Point(204, 125);
            this.lCopyright.Name = "lCopyright";
            this.lCopyright.Size = new System.Drawing.Size(66, 13);
            this.lCopyright.TabIndex = 4;
            this.lCopyright.Text = "COPYRIGHT";
            // 
            // lAuthorWebPage
            // 
            this.lAuthorWebPage.AutoSize = true;
            this.lAuthorWebPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAuthorWebPage.Location = new System.Drawing.Point(204, 70);
            this.lAuthorWebPage.Name = "lAuthorWebPage";
            this.lAuthorWebPage.Size = new System.Drawing.Size(66, 15);
            this.lAuthorWebPage.TabIndex = 3;
            this.lAuthorWebPage.Text = "WEBPAGE";
            // 
            // linkAuthor
            // 
            this.linkAuthor.AutoSize = true;
            this.linkAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAuthor.LinkColor = System.Drawing.Color.DarkSlateBlue;
            this.linkAuthor.Location = new System.Drawing.Point(309, 43);
            this.linkAuthor.Name = "linkAuthor";
            this.linkAuthor.Size = new System.Drawing.Size(67, 15);
            this.linkAuthor.TabIndex = 2;
            this.linkAuthor.TabStop = true;
            this.linkAuthor.Text = "Jlebnikov";
            this.linkAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAuthor_LinkClicked);
            // 
            // lAuthor
            // 
            this.lAuthor.AutoSize = true;
            this.lAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAuthor.Location = new System.Drawing.Point(204, 43);
            this.lAuthor.Name = "lAuthor";
            this.lAuthor.Size = new System.Drawing.Size(57, 15);
            this.lAuthor.TabIndex = 1;
            this.lAuthor.Text = "AUTHOR";
            // 
            // pbLogotipo
            // 
            this.pbLogotipo.BackgroundImage = global::AOEIII_Launcher.Properties.Resources.about_image;
            this.pbLogotipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogotipo.Location = new System.Drawing.Point(6, 7);
            this.pbLogotipo.Name = "pbLogotipo";
            this.pbLogotipo.Size = new System.Drawing.Size(164, 164);
            this.pbLogotipo.TabIndex = 0;
            this.pbLogotipo.TabStop = false;
            // 
            // tabTranslations
            // 
            this.tabTranslations.Controls.Add(this.tbTranslation);
            this.tabTranslations.Location = new System.Drawing.Point(4, 22);
            this.tabTranslations.Name = "tabTranslations";
            this.tabTranslations.Padding = new System.Windows.Forms.Padding(8);
            this.tabTranslations.Size = new System.Drawing.Size(501, 194);
            this.tabTranslations.TabIndex = 1;
            this.tabTranslations.Text = "TRANSLATIONS";
            this.tabTranslations.UseVisualStyleBackColor = true;
            // 
            // tbTranslation
            // 
            this.tbTranslation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTranslation.Location = new System.Drawing.Point(8, 8);
            this.tbTranslation.Multiline = true;
            this.tbTranslation.Name = "tbTranslation";
            this.tbTranslation.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbTranslation.Size = new System.Drawing.Size(485, 178);
            this.tbTranslation.TabIndex = 0;
            // 
            // tabMods
            // 
            this.tabMods.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tabMods.Controls.Add(this.tbMods);
            this.tabMods.Location = new System.Drawing.Point(4, 22);
            this.tabMods.Name = "tabMods";
            this.tabMods.Padding = new System.Windows.Forms.Padding(3);
            this.tabMods.Size = new System.Drawing.Size(501, 194);
            this.tabMods.TabIndex = 2;
            this.tabMods.Text = "MODS";
            // 
            // tbMods
            // 
            this.tbMods.Controls.Add(this.tabPopMod);
            this.tbMods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMods.Location = new System.Drawing.Point(3, 3);
            this.tbMods.Name = "tbMods";
            this.tbMods.SelectedIndex = 0;
            this.tbMods.Size = new System.Drawing.Size(495, 188);
            this.tbMods.TabIndex = 0;
            // 
            // tabPopMod
            // 
            this.tabPopMod.Controls.Add(this.tbPopModLicense);
            this.tabPopMod.Controls.Add(this.lPopModLicense);
            this.tabPopMod.Controls.Add(this.lPopModAuthorName);
            this.tabPopMod.Controls.Add(this.lPopModAuthor);
            this.tabPopMod.Location = new System.Drawing.Point(4, 22);
            this.tabPopMod.Name = "tabPopMod";
            this.tabPopMod.Padding = new System.Windows.Forms.Padding(3);
            this.tabPopMod.Size = new System.Drawing.Size(487, 162);
            this.tabPopMod.TabIndex = 0;
            this.tabPopMod.Text = "POPMOD";
            this.tabPopMod.UseVisualStyleBackColor = true;
            // 
            // tbPopModLicense
            // 
            this.tbPopModLicense.Location = new System.Drawing.Point(103, 36);
            this.tbPopModLicense.Multiline = true;
            this.tbPopModLicense.Name = "tbPopModLicense";
            this.tbPopModLicense.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbPopModLicense.Size = new System.Drawing.Size(378, 120);
            this.tbPopModLicense.TabIndex = 3;
            this.tbPopModLicense.Text = resources.GetString("tbPopModLicense.Text");
            // 
            // lPopModLicense
            // 
            this.lPopModLicense.AutoSize = true;
            this.lPopModLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPopModLicense.Location = new System.Drawing.Point(7, 37);
            this.lPopModLicense.Name = "lPopModLicense";
            this.lPopModLicense.Size = new System.Drawing.Size(58, 15);
            this.lPopModLicense.TabIndex = 2;
            this.lPopModLicense.Text = "LICENSE";
            // 
            // lPopModAuthorName
            // 
            this.lPopModAuthorName.AutoSize = true;
            this.lPopModAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPopModAuthorName.Location = new System.Drawing.Point(100, 12);
            this.lPopModAuthorName.Name = "lPopModAuthorName";
            this.lPopModAuthorName.Size = new System.Drawing.Size(49, 15);
            this.lPopModAuthorName.TabIndex = 1;
            this.lPopModAuthorName.Text = "Nicifer";
            // 
            // lPopModAuthor
            // 
            this.lPopModAuthor.AutoSize = true;
            this.lPopModAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPopModAuthor.Location = new System.Drawing.Point(7, 12);
            this.lPopModAuthor.Name = "lPopModAuthor";
            this.lPopModAuthor.Size = new System.Drawing.Size(57, 15);
            this.lPopModAuthor.TabIndex = 0;
            this.lPopModAuthor.Text = "AUTHOR";
            // 
            // DialogAbout
            // 
            this.AcceptButton = this.bClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(529, 306);
            this.Controls.Add(this.pInfo);
            this.Controls.Add(this.pTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "AboutDialog";
            this.pTitle.ResumeLayout(false);
            this.pTitle.PerformLayout();
            this.pInfo.ResumeLayout(false);
            this.tbAbout.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogotipo)).EndInit();
            this.tabTranslations.ResumeLayout(false);
            this.tabTranslations.PerformLayout();
            this.tabMods.ResumeLayout(false);
            this.tbMods.ResumeLayout(false);
            this.tabPopMod.ResumeLayout(false);
            this.tabPopMod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTitle;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Panel pInfo;
        private System.Windows.Forms.LinkLabel lWebPage;
        private System.Windows.Forms.TabControl tbAbout;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.TabPage tabTranslations;
        private System.Windows.Forms.TextBox tbTranslation;
        private System.Windows.Forms.TabPage tabMods;
        private System.Windows.Forms.TabControl tbMods;
        private System.Windows.Forms.TabPage tabPopMod;
        private System.Windows.Forms.TextBox tbPopModLicense;
        private System.Windows.Forms.Label lPopModLicense;
        private System.Windows.Forms.Label lPopModAuthorName;
        private System.Windows.Forms.Label lPopModAuthor;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Label lVersion;
        private System.Windows.Forms.Label lCopyrightAoe;
        private System.Windows.Forms.LinkLabel linkAuthorWebPage;
        private System.Windows.Forms.Label lCopyright;
        private System.Windows.Forms.Label lAuthorWebPage;
        private System.Windows.Forms.LinkLabel linkAuthor;
        private System.Windows.Forms.Label lAuthor;
        private System.Windows.Forms.PictureBox pbLogotipo;
    }
}