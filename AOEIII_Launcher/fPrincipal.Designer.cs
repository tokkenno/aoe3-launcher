namespace AOEIII_Launcher
{
    partial class fPrincipal
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
            this.cbIPList = new System.Windows.Forms.ComboBox();
            this.lIPList = new System.Windows.Forms.Label();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPTIONSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lANGUAGEToolStripMenuItem = new System.Windows.Forms.ToolStripComboBox();
            this.hELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbNetOptions = new System.Windows.Forms.GroupBox();
            this.bReloadIP = new System.Windows.Forms.Button();
            this.cbOpVideo = new System.Windows.Forms.CheckBox();
            this.gbGameOptions = new System.Windows.Forms.GroupBox();
            this.cbOpGWindow = new System.Windows.Forms.CheckBox();
            this.cbOpSound = new System.Windows.Forms.CheckBox();
            this.bStartGameO = new System.Windows.Forms.Button();
            this.flButtonGame = new System.Windows.Forms.FlowLayoutPanel();
            this.bStartGameY = new System.Windows.Forms.Button();
            this.bStartGameX = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gbMods = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lModList = new System.Windows.Forms.Label();
            this.cbModsList = new System.Windows.Forms.ComboBox();
            this.pPopModOptions = new System.Windows.Forms.Panel();
            this.lPopModPopulationLabel = new System.Windows.Forms.Label();
            this.cbPopModPopulation = new System.Windows.Forms.ComboBox();
            this.vPNCLIENTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbNetOptions.SuspendLayout();
            this.gbGameOptions.SuspendLayout();
            this.flButtonGame.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.gbMods.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pPopModOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbIPList
            // 
            this.cbIPList.FormattingEnabled = true;
            this.cbIPList.Location = new System.Drawing.Point(129, 23);
            this.cbIPList.Name = "cbIPList";
            this.cbIPList.Size = new System.Drawing.Size(101, 21);
            this.cbIPList.TabIndex = 1;
            // 
            // lIPList
            // 
            this.lIPList.AutoSize = true;
            this.lIPList.Location = new System.Drawing.Point(17, 26);
            this.lIPList.Name = "lIPList";
            this.lIPList.Size = new System.Drawing.Size(40, 13);
            this.lIPList.TabIndex = 2;
            this.lIPList.Text = "IPLIST";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXITToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // oPTIONSToolStripMenuItem
            // 
            this.oPTIONSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lANGUAGEToolStripMenuItem});
            this.oPTIONSToolStripMenuItem.Name = "oPTIONSToolStripMenuItem";
            this.oPTIONSToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.oPTIONSToolStripMenuItem.Text = "OPTIONS";
            // 
            // lANGUAGEToolStripMenuItem
            // 
            this.lANGUAGEToolStripMenuItem.Name = "lANGUAGEToolStripMenuItem";
            this.lANGUAGEToolStripMenuItem.Size = new System.Drawing.Size(152, 23);
            this.lANGUAGEToolStripMenuItem.Text = "LANGUAGE";
            this.lANGUAGEToolStripMenuItem.SelectedIndexChanged += new System.EventHandler(this.lANGUAGEToolStripMenuItem_Click);
            this.lANGUAGEToolStripMenuItem.Click += new System.EventHandler(this.lANGUAGEToolStripMenuItem_Click);
            // 
            // hELPToolStripMenuItem
            // 
            this.hELPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBOUTToolStripMenuItem});
            this.hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            this.hELPToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.hELPToolStripMenuItem.Text = "HELP";
            // 
            // aBOUTToolStripMenuItem
            // 
            this.aBOUTToolStripMenuItem.Name = "aBOUTToolStripMenuItem";
            this.aBOUTToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.aBOUTToolStripMenuItem.Text = "ABOUT";
            this.aBOUTToolStripMenuItem.Click += new System.EventHandler(this.aBOUTToolStripMenuItem_Click);
            // 
            // gbNetOptions
            // 
            this.gbNetOptions.Controls.Add(this.bReloadIP);
            this.gbNetOptions.Controls.Add(this.lIPList);
            this.gbNetOptions.Controls.Add(this.cbIPList);
            this.gbNetOptions.Location = new System.Drawing.Point(8, 8);
            this.gbNetOptions.Name = "gbNetOptions";
            this.gbNetOptions.Size = new System.Drawing.Size(269, 55);
            this.gbNetOptions.TabIndex = 4;
            this.gbNetOptions.TabStop = false;
            this.gbNetOptions.Text = "NET OPTIONS";
            // 
            // bReloadIP
            // 
            this.bReloadIP.Image = global::AOEIII_Launcher.Properties.Resources.reload;
            this.bReloadIP.Location = new System.Drawing.Point(235, 22);
            this.bReloadIP.Name = "bReloadIP";
            this.bReloadIP.Size = new System.Drawing.Size(23, 23);
            this.bReloadIP.TabIndex = 3;
            this.bReloadIP.UseVisualStyleBackColor = true;
            this.bReloadIP.Click += new System.EventHandler(this.bReloadIP_Click);
            // 
            // cbOpVideo
            // 
            this.cbOpVideo.AutoSize = true;
            this.cbOpVideo.Location = new System.Drawing.Point(20, 28);
            this.cbOpVideo.Name = "cbOpVideo";
            this.cbOpVideo.Size = new System.Drawing.Size(114, 17);
            this.cbOpVideo.TabIndex = 3;
            this.cbOpVideo.Text = "WITHOUT VIDEO";
            this.cbOpVideo.UseVisualStyleBackColor = true;
            // 
            // gbGameOptions
            // 
            this.gbGameOptions.Controls.Add(this.cbOpGWindow);
            this.gbGameOptions.Controls.Add(this.cbOpSound);
            this.gbGameOptions.Controls.Add(this.cbOpVideo);
            this.gbGameOptions.Location = new System.Drawing.Point(8, 69);
            this.gbGameOptions.Name = "gbGameOptions";
            this.gbGameOptions.Size = new System.Drawing.Size(269, 98);
            this.gbGameOptions.TabIndex = 5;
            this.gbGameOptions.TabStop = false;
            this.gbGameOptions.Text = "GAME OPTIONS";
            // 
            // cbOpGWindow
            // 
            this.cbOpGWindow.AutoSize = true;
            this.cbOpGWindow.Location = new System.Drawing.Point(20, 74);
            this.cbOpGWindow.Name = "cbOpGWindow";
            this.cbOpGWindow.Size = new System.Drawing.Size(123, 17);
            this.cbOpGWindow.TabIndex = 5;
            this.cbOpGWindow.Text = "GAME IN WINDOW";
            this.cbOpGWindow.UseVisualStyleBackColor = true;
            // 
            // cbOpSound
            // 
            this.cbOpSound.AutoSize = true;
            this.cbOpSound.Location = new System.Drawing.Point(20, 51);
            this.cbOpSound.Name = "cbOpSound";
            this.cbOpSound.Size = new System.Drawing.Size(112, 17);
            this.cbOpSound.TabIndex = 4;
            this.cbOpSound.Text = "WITHOUT SONG";
            this.cbOpSound.UseVisualStyleBackColor = true;
            // 
            // bStartGameO
            // 
            this.bStartGameO.Image = global::AOEIII_Launcher.Properties.Resources.logo_aoe3;
            this.bStartGameO.Location = new System.Drawing.Point(95, 3);
            this.bStartGameO.Name = "bStartGameO";
            this.bStartGameO.Size = new System.Drawing.Size(56, 56);
            this.bStartGameO.TabIndex = 6;
            this.bStartGameO.UseVisualStyleBackColor = true;
            this.bStartGameO.Click += new System.EventHandler(this.bStartGameO_Click);
            // 
            // flButtonGame
            // 
            this.flButtonGame.Controls.Add(this.bStartGameY);
            this.flButtonGame.Controls.Add(this.bStartGameX);
            this.flButtonGame.Controls.Add(this.bStartGameO);
            this.flButtonGame.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flButtonGame.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flButtonGame.Location = new System.Drawing.Point(0, 256);
            this.flButtonGame.Name = "flButtonGame";
            this.flButtonGame.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.flButtonGame.Size = new System.Drawing.Size(286, 67);
            this.flButtonGame.TabIndex = 7;
            // 
            // bStartGameY
            // 
            this.bStartGameY.Image = global::AOEIII_Launcher.Properties.Resources.logo_aoe3y;
            this.bStartGameY.Location = new System.Drawing.Point(219, 3);
            this.bStartGameY.Name = "bStartGameY";
            this.bStartGameY.Size = new System.Drawing.Size(56, 56);
            this.bStartGameY.TabIndex = 8;
            this.bStartGameY.UseVisualStyleBackColor = true;
            this.bStartGameY.Click += new System.EventHandler(this.bStartGameY_Click);
            // 
            // bStartGameX
            // 
            this.bStartGameX.Image = global::AOEIII_Launcher.Properties.Resources.logo_aoe3x;
            this.bStartGameX.Location = new System.Drawing.Point(157, 3);
            this.bStartGameX.Name = "bStartGameX";
            this.bStartGameX.Size = new System.Drawing.Size(56, 56);
            this.bStartGameX.TabIndex = 7;
            this.bStartGameX.UseVisualStyleBackColor = true;
            this.bStartGameX.Click += new System.EventHandler(this.bStartGameX_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.vPNCLIENTSToolStripMenuItem,
            this.oPTIONSToolStripMenuItem,
            this.hELPToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(286, 24);
            this.menuStrip.TabIndex = 10;
            this.menuStrip.Text = "menuStrip";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.gbNetOptions);
            this.flowLayoutPanel1.Controls.Add(this.gbGameOptions);
            this.flowLayoutPanel1.Controls.Add(this.gbMods);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(286, 232);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // gbMods
            // 
            this.gbMods.Controls.Add(this.flowLayoutPanel2);
            this.gbMods.Location = new System.Drawing.Point(8, 173);
            this.gbMods.Name = "gbMods";
            this.gbMods.Size = new System.Drawing.Size(269, 52);
            this.gbMods.TabIndex = 6;
            this.gbMods.TabStop = false;
            this.gbMods.Text = "MODS OPTIONS";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Controls.Add(this.pPopModOptions);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(263, 33);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lModList);
            this.panel1.Controls.Add(this.cbModsList);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 27);
            this.panel1.TabIndex = 2;
            // 
            // lModList
            // 
            this.lModList.AutoSize = true;
            this.lModList.Location = new System.Drawing.Point(11, 6);
            this.lModList.Name = "lModList";
            this.lModList.Size = new System.Drawing.Size(76, 13);
            this.lModList.TabIndex = 1;
            this.lModList.Text = "SELECT MOD";
            // 
            // cbModsList
            // 
            this.cbModsList.FormattingEnabled = true;
            this.cbModsList.Location = new System.Drawing.Point(123, 3);
            this.cbModsList.Name = "cbModsList";
            this.cbModsList.Size = new System.Drawing.Size(128, 21);
            this.cbModsList.TabIndex = 0;
            this.cbModsList.SelectedIndexChanged += new System.EventHandler(this.cbModsList_SelectedIndexChanged);
            // 
            // pPopModOptions
            // 
            this.pPopModOptions.Controls.Add(this.lPopModPopulationLabel);
            this.pPopModOptions.Controls.Add(this.cbPopModPopulation);
            this.pPopModOptions.Location = new System.Drawing.Point(3, 36);
            this.pPopModOptions.Name = "pPopModOptions";
            this.pPopModOptions.Size = new System.Drawing.Size(257, 30);
            this.pPopModOptions.TabIndex = 3;
            // 
            // lPopModPopulationLabel
            // 
            this.lPopModPopulationLabel.AutoSize = true;
            this.lPopModPopulationLabel.Location = new System.Drawing.Point(11, 6);
            this.lPopModPopulationLabel.Name = "lPopModPopulationLabel";
            this.lPopModPopulationLabel.Size = new System.Drawing.Size(120, 13);
            this.lPopModPopulationLabel.TabIndex = 2;
            this.lPopModPopulationLabel.Text = "SELECT POPULATION";
            // 
            // cbPopModPopulation
            // 
            this.cbPopModPopulation.FormattingEnabled = true;
            this.cbPopModPopulation.Items.AddRange(new object[] {
            "260",
            "280",
            "300",
            "320",
            "340",
            "360",
            "380",
            "400",
            "420",
            "440",
            "460",
            "480",
            "500",
            "530",
            "560",
            "600",
            "650",
            "700",
            "750",
            "800",
            "900",
            "999"});
            this.cbPopModPopulation.Location = new System.Drawing.Point(180, 3);
            this.cbPopModPopulation.Name = "cbPopModPopulation";
            this.cbPopModPopulation.Size = new System.Drawing.Size(71, 21);
            this.cbPopModPopulation.TabIndex = 0;
            // 
            // vPNCLIENTSToolStripMenuItem
            // 
            this.vPNCLIENTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remoboToolStripMenuItem});
            this.vPNCLIENTSToolStripMenuItem.Name = "vPNCLIENTSToolStripMenuItem";
            this.vPNCLIENTSToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.vPNCLIENTSToolStripMenuItem.Text = "VPN_CLIENTS";
            // 
            // remoboToolStripMenuItem
            // 
            this.remoboToolStripMenuItem.Name = "remoboToolStripMenuItem";
            this.remoboToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.remoboToolStripMenuItem.Text = "Remobo";
            this.remoboToolStripMenuItem.Click += new System.EventHandler(this.remoboToolStripMenuItem_Click);
            // 
            // fPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 323);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flButtonGame);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fPrincipal";
            this.Text = "TITLE";
            this.gbNetOptions.ResumeLayout(false);
            this.gbNetOptions.PerformLayout();
            this.gbGameOptions.ResumeLayout(false);
            this.gbGameOptions.PerformLayout();
            this.flButtonGame.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gbMods.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pPopModOptions.ResumeLayout(false);
            this.pPopModOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbIPList;
        private System.Windows.Forms.Label lIPList;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPTIONSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox lANGUAGEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBOUTToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbNetOptions;
        private System.Windows.Forms.CheckBox cbOpVideo;
        private System.Windows.Forms.GroupBox gbGameOptions;
        private System.Windows.Forms.CheckBox cbOpGWindow;
        private System.Windows.Forms.CheckBox cbOpSound;
        private System.Windows.Forms.Button bStartGameO;
        private System.Windows.Forms.FlowLayoutPanel flButtonGame;
        private System.Windows.Forms.Button bStartGameY;
        private System.Windows.Forms.Button bStartGameX;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bReloadIP;
        private System.Windows.Forms.GroupBox gbMods;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lModList;
        private System.Windows.Forms.ComboBox cbModsList;
        private System.Windows.Forms.Panel pPopModOptions;
        private System.Windows.Forms.Label lPopModPopulationLabel;
        private System.Windows.Forms.ComboBox cbPopModPopulation;
        private System.Windows.Forms.ToolStripMenuItem vPNCLIENTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoboToolStripMenuItem;
    }
}