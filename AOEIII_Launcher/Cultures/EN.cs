using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AOEIII_Launcher.Culture
{
    class EN : Culture
    {
        public EN()
        {
            this._STRING_NOT_FOUND_MESSAGE = "ERROR (Text String not found.)";
            this.language = G11N.Languages.EN;

            this.langValues.Add("", "");
            this.langValues.Add("LAUNCHER", "Launcher");
            this.langValues.Add("FILE", "File");
            this.langValues.Add("OPTIONS", "Options");
            this.langValues.Add("HELP", "Help");
            this.langValues.Add("EXIT", "Exit");
            this.langValues.Add("ABOUT", "About");
            this.langValues.Add("GAME_OPTIONS", "Game Options");
            this.langValues.Add("NETWORK_OPTIONS", "Network Options");
            this.langValues.Add("NETWORK", "Network");
            this.langValues.Add("START_WO_SONG", "Start game without song.");
            this.langValues.Add("START_WO_VIDEO", "Start game without video.");
            this.langValues.Add("START_IN_WINDOW", "Start game in a window.");
            this.langValues.Add("LANGUAGE", "Language");
            this.langValues.Add("SELECT_NETWORK_ADAPTOR_HELP", "Choose the network adapter you like to use in the multigamer mode.");
            this.langValues.Add("START", "Start");
            this.langValues.Add("GAME_NOT_INSTALLED", "The game is not installed.");
            this.langValues.Add("LAUNCHER_FOR_AOE3", "Launcher for Age of Empires III");
            this.langValues.Add("PROGRAM_WEBSITE", "Program Website");
            this.langValues.Add("WEBSITE", "Website");
            this.langValues.Add("VERSION", "Version");
            this.langValues.Add("DEFAULT_GAME", "(Default Game)");
            this.langValues.Add("SELECT_MOD", "Select a mod");
            this.langValues.Add("MODS_OPTIONS", "Mods Options");
            this.langValues.Add("MOD_LOAD_FAIL", "Fail when the program try to load the mod. Start game without mod?");
            this.langValues.Add("FATAL_ERROR", "Fatal Error");
            this.langValues.Add("AUTHOR", "Author");
            this.langValues.Add("CLOSE", "Close");
            this.langValues.Add("INFORMATION", "Information");
            this.langValues.Add("TRANSLATIONS", "Translations");
            this.langValues.Add("MODS", "Game Mods");
            this.langValues.Add("LICENSE", "License");
            this.langValues.Add("TRANSLATIONS_THANKS", "Special thanks to translators:");
            this.langValues.Add("AND", "and");
            this.langValues.Add("VPN_CLIENTS", "VPN Clients");
            this.langValues.Add("IS_A_REGISTERED_TRADEMAEK_OF", "is a registered trademark of");
            

            this.langValues.Add("MOD_POPMOD", "Population Mod");
            this.langValues.Add("SELECT_POPULATION", "Select the maximun population:");

            this.langValues.Add("ENGLISH_GB", "English(GB)");
            this.langValues.Add("SPANISH", "Spanish");
            this.langValues.Add("GALICIAN", "Galician");
            this.langValues.Add("PORTUGUESE", "Portuguese");
        }
    }
}
