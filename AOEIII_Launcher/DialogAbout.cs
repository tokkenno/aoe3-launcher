using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AOEIII_Launcher.Culture;

namespace AOEIII_Launcher
{
    public partial class DialogAbout : Form
    {
        private const String _version_ = "0.2.r0063";

        private G11N cultureManager;

        public DialogAbout(G11N cultureManager)
        {
            InitializeComponent();

            this.cultureManager = cultureManager;

            this.Text = cultureManager.getTranslateString("ABOUT") + " - Age of Empires III Launcher";
            this.lTitle.Text = "Age of Empires III Launcher";

            this.lWebPage.Text = cultureManager.getTranslateString("PROGRAM_WEBSITE");
            this.bClose.Text = cultureManager.getTranslateString("CLOSE");

            this.tabInfo.Text = cultureManager.getTranslateString("INFORMATION");
            this.tabTranslations.Text = cultureManager.getTranslateString("TRANSLATIONS");
            this.tabMods.Text = cultureManager.getTranslateString("MODS");
            this.tabPopMod.Text = cultureManager.getTranslateString("MOD_POPMOD");

            this.lAuthor.Text = cultureManager.getTranslateString("AUTHOR") + ":";
            this.lAuthorWebPage.Text = cultureManager.getTranslateString("WEBSITE") + ":";

            this.lPopModAuthor.Text = cultureManager.getTranslateString("AUTHOR") + ":";
            this.lPopModLicense.Text = cultureManager.getTranslateString("LICENSE") + ":";

            this.lVersion.Text = _version_;
            this.lCopyright.Text = "© Jlebnikov 2012";
            this.lCopyrightAoe.Text = "Age of Empires III " + cultureManager.getTranslateString("IS_A_REGISTERED_TRADEMAEK_OF") + " Microsoft " + cultureManager.getTranslateString("AND") + " Ensemble Studios";

            this.tbTranslation.Text = cultureManager.getTranslateString("TRANSLATIONS_THANKS") + Environment.NewLine + Environment.NewLine +
                cultureManager.getTranslateString("ENGLISH_GB") + "\t->\t Victor Cartelle Álvarez" + Environment.NewLine +
                cultureManager.getTranslateString("SPANISH") + "\t\t->\t Jlebnikov" + Environment.NewLine +
                cultureManager.getTranslateString("PORTUGUESE") + "\t->\t Erica Taboada Carvalho" + Environment.NewLine +
                cultureManager.getTranslateString("GALICIAN") + "\t\t->\t Jlebnikov";
        }

        private void lWebPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Uri link = new Uri("http://proyectsource.blogspot.com");
            System.Diagnostics.Process.Start(link.ToString());
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Uri link = new Uri("https://plus.google.com/118374382501991934283");
            System.Diagnostics.Process.Start(link.ToString());
        }

        private void linkAuthorWebPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Uri link = new Uri("http://proyectsource.blogspot.com");
            System.Diagnostics.Process.Start(link.ToString());
        }
    }
}
