using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Collections;
using AOEIII_Launcher.Culture;
using AOEIII_Launcher.Utils;

namespace AOEIII_Launcher
{
    public partial class fPrincipal : Form
    {
        private const String _command_nosound = "+nosound";
        private const String _command_novideo = "+noIntroCinematics";
        private const String _command_gameinwindow = "+Window";

        private const String _configuration_reg_path = "AOE3Launcher\\config";

        private String[] _av_languages = { "ENGLISH_GB", "SPANISH", "GALICIAN", "PORTUGUESE" };
        private G11N.Languages[] _av_languages_l = { G11N.Languages.EN, G11N.Languages.ES, G11N.Languages.GL, G11N.Languages.PT };
        private G11N.Countries[] _av_languages_c = { G11N.Countries.GB, G11N.Countries.ES, G11N.Countries.ES, G11N.Countries.PT };
        private const Int32 _av_languages_default = 0;

        private Int32 _av_languages_actual = _av_languages_default;
        private G11N languageManager = new G11N();

        private AOEInfo info = new AOEInfo();
        private Configuration config;

        private String[] _av_mods = { "DEFAULT_GAME", "MOD_POPMOD" };

        private Int32 _mod_height_default = 52;
        private Int32 _mod_height_popmod = 90;
        private Int32 _mod_wheight_default = 350;
        private Int32 _mod_wheight_popmod = 388;

        private Int32 _auxiliary_modslist_index = 0;

        public fPrincipal()
        {
            this.Icon = Properties.Resources.age3x_arrow;

            // Cargamos la configuracion y si no existe la inicializamos
            this.config = new Configuration(_configuration_reg_path, Configuration.configLocation.APPDATA);
            if (!config.Load())
            {
                config.Set("game_wo_video", false);
                config.Set("game_wo_sound", false);
                config.Set("game_in_window", false);
                config.Set("selected_ip", "0.0.0.0");
                config.Set("selected_mod", 0);
                config.Set("mod_popmod_population", "320");
                config.Set("culture_language", "");
                config.Set("culture_country", "");
                if (!config.Save())
                {
                    MessageBox.Show("Critical Error.\nConfiguration couldn't be initializated.", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Cargamos el idioma de la configuración, si no el del sistema y en ultima instancia el definido por defecto
            if (config.Get("culture_language").ToString() == String.Empty)
            {
                if (!languageManager.setCulture())
                {
                    if (!languageManager.setCulture(_av_languages_l[_av_languages_default], _av_languages_c[_av_languages_default]))
                    {
                        MessageBox.Show("Critical Error.\nLanguages can´t be loaded.\nProgram will close.", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                }
            }
            else
            {
                Boolean loaded = false;
                if (config.Get("culture_country").ToString() == String.Empty)
                {
                    loaded = languageManager.setCulture(config.Get("culture_language").ToString().ToUpper());
                }
                else
                {
                    loaded = languageManager.setCulture(config.Get("culture_language").ToString().ToUpper(), config.Get("culture_country").ToString().ToUpper());
                }
                if (!loaded)
                {
                    if (!languageManager.setCulture())
                    {
                        if (!languageManager.setCulture(_av_languages_l[_av_languages_default], _av_languages_c[_av_languages_default]))
                        {
                            MessageBox.Show("Critical Error.\nLanguages can´t be loaded.\nProgram will close.", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                        }
                    }
                }
            }

            // Le indicamos al programa que idioma es el actualmente cargado
            for (int i = 0; i < _av_languages.Length; i++)
            {
                if (_av_languages_l[i] == languageManager.Culture.Language && _av_languages_c[i] == languageManager.Culture.Country)
                {
                    _av_languages_actual = i;
                    break;
                }
            }

            InitializeComponent();

            // Cargamos la información de los juegos
            info.Load();

            // Cargamos las IP's de los adaptadores conectados
            LoadIPs();

            // Establecemos todos los textos
            setText();

            // Comprobamos la disponibilidad de los VPN
            if (VPN.searchRemobo() == null)
            {
                this.remoboToolStripMenuItem.Enabled = false;
            }

            // Cargamos el valor de los checks desde la configuración
            this.cbOpVideo.Checked = (Boolean)config.Get("game_wo_video");
            this.cbOpSound.Checked = (Boolean)config.Get("game_wo_sound");
            this.cbOpGWindow.Checked = (Boolean)config.Get("game_in_window");

            // Seleccionamos el mod por defecto
            if (0 > (Int32)config.Get("selected_mod") && (Int32)config.Get("selected_mod") < _av_mods.Length)
            {
                _auxiliary_modslist_index = (Int32)config.Get("selected_mod");
            }
            else
            {
                _auxiliary_modslist_index = 0;
            }

            // Seleccionamos el valor por defecto del popmod
            for (int i = 0; i < this.cbPopModPopulation.Items.Count; i++)
            {
                if (config.Get("mod_popmod_population").ToString() == this.cbPopModPopulation.Items[i].ToString())
                {
                    this.cbPopModPopulation.SelectedIndex = i;
                    break;
                }

                this.cbPopModPopulation.SelectedIndex = 0;
            }
        }

        private void setText()
        {
            this.Text = "Age of Empires III - " + languageManager.getTranslateString("LAUNCHER");

            this.fILEToolStripMenuItem.Text = languageManager.getTranslateString("FILE");
            this.oPTIONSToolStripMenuItem.Text = languageManager.getTranslateString("OPTIONS");
            this.hELPToolStripMenuItem.Text = languageManager.getTranslateString("HELP");

            this.eXITToolStripMenuItem.Text = languageManager.getTranslateString("EXIT");
            this.vPNCLIENTSToolStripMenuItem.Text = languageManager.getTranslateString("VPN_CLIENTS");
            this.aBOUTToolStripMenuItem.Text = languageManager.getTranslateString("ABOUT");

            this.gbGameOptions.Text = languageManager.getTranslateString("GAME_OPTIONS");
            this.gbNetOptions.Text = languageManager.getTranslateString("NETWORK_OPTIONS");
            this.gbMods.Text = languageManager.getTranslateString("MODS_OPTIONS");

            this.lIPList.Text = languageManager.getTranslateString("NETWORK");
            this.lModList.Text = languageManager.getTranslateString("SELECT_MOD") + ":";
            this.lPopModPopulationLabel.Text = languageManager.getTranslateString("SELECT_POPULATION");

            this.cbOpSound.Text = languageManager.getTranslateString("START_WO_SONG");
            this.cbOpVideo.Text = languageManager.getTranslateString("START_WO_VIDEO");
            this.cbOpGWindow.Text = languageManager.getTranslateString("START_IN_WINDOW");

            this.lANGUAGEToolStripMenuItem.Text = languageManager.getTranslateString("LANGUAGE");

            this.toolTip.SetToolTip(this.lIPList, languageManager.getTranslateString("SELECT_NETWORK_ADAPTOR_HELP"));
            this.toolTip.SetToolTip(this.cbIPList, languageManager.getTranslateString("SELECT_NETWORK_ADAPTOR_HELP"));

            if (info.getAOEInfo().Installed)
            {
                this.bStartGameO.Enabled = true;
                this.toolTip.SetToolTip(this.bStartGameO, languageManager.getTranslateString("START") + " " + info.getAOEInfo().RealName + Environment.NewLine + languageManager.getTranslateString("VERSION") + ": " + info.getAOEInfo().Version);
            }
            else
            {
                this.bStartGameO.Enabled = false;
                this.toolTip.SetToolTip(this.bStartGameO, languageManager.getTranslateString("GAME_NOT_INSTALLED"));
            }

            if (info.getAOEXInfo().Installed)
            {
                this.bStartGameX.Enabled = true;
                this.toolTip.SetToolTip(this.bStartGameX, languageManager.getTranslateString("START") + " " + info.getAOEXInfo().RealName + Environment.NewLine + languageManager.getTranslateString("VERSION") + ": " + info.getAOEXInfo().Version);
            }
            else
            {
                this.bStartGameX.Enabled = false;
                this.toolTip.SetToolTip(this.bStartGameX, languageManager.getTranslateString("GAME_NOT_INSTALLED"));
            }

            if (info.getAOEYInfo().Installed)
            {
                this.bStartGameY.Enabled = true;
                this.toolTip.SetToolTip(this.bStartGameY, languageManager.getTranslateString("START") + " " + info.getAOEYInfo().RealName + Environment.NewLine + languageManager.getTranslateString("VERSION") + ": " + info.getAOEYInfo().Version);
            }
            else
            {
                this.bStartGameY.Enabled = false;
                this.toolTip.SetToolTip(this.bStartGameY, languageManager.getTranslateString("GAME_NOT_INSTALLED"));
            }

            this.lANGUAGEToolStripMenuItem.Items.Clear();
            for (int i = 0; i < _av_languages.Length; i++)
            {
                this.lANGUAGEToolStripMenuItem.Items.Add(languageManager.getTranslateString(_av_languages[i]));
            }
            this.lANGUAGEToolStripMenuItem.SelectedIndex = _av_languages_actual;

            // Cargamos los mods
            this.cbModsList.Items.Clear();
            for (int i = 0; i < this._av_mods.Length; i++)
            {
                this.cbModsList.Items.Add(languageManager.getTranslateString(this._av_mods[i]));
            }
            this.cbModsList.SelectedIndex = _auxiliary_modslist_index;
        }

        private void TestGameAvailablity()
        {
            String selectedMod = this._av_mods[this.cbModsList.SelectedIndex];
            switch (this.cbModsList.SelectedIndex)
            {
                case 0:
                    this.bStartGameO.Enabled = info.getAOEInfo().Installed;
                    this.bStartGameX.Enabled = info.getAOEXInfo().Installed;
                    this.bStartGameY.Enabled = info.getAOEYInfo().Installed;
                    this.SetBounds(this.Bounds.X, this.Bounds.Y, this.Bounds.Width, this._mod_wheight_default);
                    this.gbMods.SetBounds(this.gbMods.Bounds.X, this.gbMods.Bounds.Y, this.gbMods.Bounds.Width, this._mod_height_default);
                    this.pPopModOptions.Visible = false;
                    break;
                case 1:
                    this.bStartGameO.Enabled = false;
                    this.bStartGameX.Enabled = false;
                    if (info.getAOEYInfo().Version == "1.03")
                    {
                        this.bStartGameY.Enabled = info.getAOEYInfo().Installed;
                        this.SetBounds(this.Bounds.X, this.Bounds.Y, this.Bounds.Width, this._mod_wheight_popmod);
                        this.gbMods.SetBounds(this.gbMods.Bounds.X, this.gbMods.Bounds.Y, this.gbMods.Bounds.Width, this._mod_height_popmod);
                        this.pPopModOptions.Visible = true;
                    }
                    break;
                default:
                    this.bStartGameO.Enabled = false;
                    this.bStartGameX.Enabled = false;
                    this.bStartGameY.Enabled = false;
                    break;
            }
        }

        private void LoadIPs()
        {
            cbIPList.Items.Clear();
            foreach (String s in NetInfo.getIpAddresses())
            {
                this.cbIPList.Items.Add(s);
            }

            String configIP = config.Get("selected_ip").ToString();

            for (int i = 0; i < this.cbIPList.Items.Count; i++)
            {
                if (configIP == this.cbIPList.Items[i].ToString())
                {
                    this.cbIPList.SelectedIndex = i;
                    return;
                }
            }

            for (int i = 0; i < this.cbIPList.Items.Count; i++)
            {
                if (this.cbIPList.Items[i].ToString().StartsWith(configIP.Substring(0, configIP.IndexOf('.'))))
                {
                    this.cbIPList.SelectedIndex = i;
                    return;
                }
            }

            this.cbIPList.SelectedIndex = 0;
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveConfig();
            Application.Exit();
        }

        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new DialogAbout(this.languageManager).ShowDialog();
        }

        private void lANGUAGEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._av_languages_actual != this.lANGUAGEToolStripMenuItem.SelectedIndex)
            {
                this._av_languages_actual = this.lANGUAGEToolStripMenuItem.SelectedIndex;
                if (!languageManager.setCulture(_av_languages_l[_av_languages_actual], _av_languages_c[_av_languages_actual]))
                {
                    if (!languageManager.setCulture(_av_languages_l[_av_languages_default], _av_languages_c[_av_languages_default]))
                    {
                        MessageBox.Show("Critical Error.\nLanguages can´t be loaded.\nProgram will close.", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                }
                setText();
            }
        }

        private void bStartGameO_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();

            proc.StartInfo.FileName = info.getAOEInfo().SetupPath + "age3.exe";
            proc.StartInfo.Arguments = getArguments();

            proc.Start();
            FormWindowState st = this.WindowState;
            this.WindowState = FormWindowState.Minimized;
            proc.WaitForExit();
            this.WindowState = st;
        }

        private String getArguments()
        {
            String arg = String.Empty;

            if (this.cbIPList.Items.Count > 0)
            {
                arg += " OverrideAddress=\"" + this.cbIPList.Items[this.cbIPList.SelectedIndex].ToString() + "\"";
            }

            if (this.cbOpVideo.Checked)
            {
                arg += " " + _command_novideo;
            }

            if (this.cbOpSound.Checked)
            {
                arg += " " + _command_nosound;
            }

            if (this.cbOpGWindow.Checked)
            {
                arg += " " + _command_gameinwindow;
            }

            return arg;
        }

        private void bStartGameX_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();

            proc.StartInfo.FileName = info.getAOEXInfo().SetupPath + "age3x.exe";
            proc.StartInfo.Arguments = getArguments();

            proc.Start();
            FormWindowState st = this.WindowState;
            this.WindowState = FormWindowState.Minimized;
            proc.WaitForExit();
            this.WindowState = st;
        }

        private void bStartGameY_Click(object sender, EventArgs e)
        {
            if (this.cbModsList.SelectedIndex == 1)
            {
                String popmodpath = System.IO.Path.GetTempPath() + "\\AOE3Loader\\popmodtrainer.exe";
                String popuNumber = (String)this.cbPopModPopulation.SelectedItem;

                if (!AOEIII_Launcher.Mods.PopMod.createPatchPopModExecutable(popmodpath, popuNumber))
                {
                    if (MessageBox.Show(languageManager.getTranslateString("MOD_LOAD_FAIL"), languageManager.getTranslateString("FATAL_ERROR"), MessageBoxButtons.YesNo, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.No)
                    {
                        return;
                    }
                }
                else
                {
                    System.Diagnostics.Process procpm = new System.Diagnostics.Process();

                    procpm.StartInfo.FileName = popmodpath;

                    procpm.Start();
                    System.Threading.Thread.Sleep(400);

                    System.Diagnostics.Process proc = new System.Diagnostics.Process();

                    proc.StartInfo.FileName = info.getAOEYInfo().SetupPath + "age3y.exe";
                    proc.StartInfo.Arguments = getArguments();

                    proc.Start();
                    FormWindowState st = this.WindowState;
                    this.WindowState = FormWindowState.Minimized;
                    proc.WaitForExit();
                    try
                    {
                        procpm.Kill();
                    }
                    catch { }
                    this.WindowState = st;
                    return;
                }
            }

            System.Diagnostics.Process proco = new System.Diagnostics.Process();

            proco.StartInfo.FileName = info.getAOEYInfo().SetupPath + "age3y.exe";
            proco.StartInfo.Arguments = getArguments();

            proco.Start();
            FormWindowState st2 = this.WindowState;
            this.WindowState = FormWindowState.Minimized;
            proco.WaitForExit();
            this.WindowState = st2;
        }

        private void bReloadIP_Click(object sender, EventArgs e)
        {
            LoadIPs();
        }

        private void cbModsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            _auxiliary_modslist_index = this.cbModsList.SelectedIndex;
            TestGameAvailablity();
        }

        private void remoboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String remoboPath = VPN.searchRemobo();

            if (remoboPath != null)
            {
                try
                {
                    System.Diagnostics.Process.Start(remoboPath);
                }
                catch { }
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            SaveConfig();
            base.OnFormClosed(e);
        }

        private void SaveConfig()
        {
            config.Set("game_wo_video", this.cbOpVideo.Checked);
            config.Set("game_wo_sound", this.cbOpSound.Checked);
            config.Set("game_in_window", this.cbOpGWindow.Checked);
            config.Set("selected_ip", this.cbIPList.SelectedItem.ToString());
            config.Set("selected_mod", this.cbModsList.SelectedIndex);
            config.Set("mod_popmod_population", this.cbPopModPopulation.SelectedItem.ToString());
            config.Set("culture_language", Enum.GetName(typeof(AOEIII_Launcher.Culture.G11N.Languages), _av_languages_l[_av_languages_actual]));
            config.Set("culture_country", Enum.GetName(typeof(AOEIII_Launcher.Culture.G11N.Countries), _av_languages_c[_av_languages_actual]));
            config.Save();
        }
    }
}
