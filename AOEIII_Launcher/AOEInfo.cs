using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace AOEIII_Launcher
{
    public class AOEInfo
    {
        private Boolean inited = false;

        private const String _AOE_GAMENAME = "Age of Empires 3";
        private const String _AOE_X_GAMENAME = "Age of Empires 3 Expansion Pack";
        private const String _AOE_Y_GAMENAME = "Age of Empires 3 Expansion Pack 2";
        private const String _AOE_REALGAMENAME = "Age of Empires 3";
        private const String _AOE_X_REALGAMENAME = "Age of Empires 3 - The WarChiefs";
        private const String _AOE_Y_REALGAMENAME = "Age of Empires 3 - Asian Dynasties";

        private AOEGameInfo _AOE;
        private AOEGameInfo _AOE_X;
        private AOEGameInfo _AOE_Y;

        public AOEInfo()
        {
            this._AOE = new AOEGameInfo(_AOE_GAMENAME);
            this._AOE.RealName = _AOE_REALGAMENAME;
            this._AOE_X = new AOEGameInfo(_AOE_X_GAMENAME);
            this._AOE_X.RealName = _AOE_X_REALGAMENAME;
            this._AOE_Y = new AOEGameInfo(_AOE_Y_GAMENAME);
            this._AOE_Y.RealName = _AOE_Y_REALGAMENAME;
        }

        public Boolean Load()
        {
            // Comprobamos si están instalados
            String[] installedGames = null;
            RegistryKey installedGamesReg = null;

            try
            {
                RegistryKey rk1 = Registry.LocalMachine;
                rk1 = rk1.OpenSubKey(@"SOFTWARE");

                foreach (String s in rk1.GetSubKeyNames())
                {
                    RegistryKey aux = rk1.OpenSubKey(s);

                    if (aux.Name.EndsWith("Microsoft"))
                    {
                        installedGamesReg = aux.OpenSubKey("Microsoft Games");
                        installedGames = installedGamesReg.GetSubKeyNames();
                    }
                }
            }
            catch 
            {
                return false;
            }

            if (installedGames.Length > 0)
            {
                foreach (String game in installedGames)
                {
                    switch (game)
                    {
                        case _AOE_GAMENAME:
                            try
                            {
                                RegistryKey aux = installedGamesReg.OpenSubKey(game).OpenSubKey("1.0");
                                _AOE.SetupPath = (String)aux.GetValue("SetupPath");
                                if (_AOE.SetupPath.Length > 0)
                                {
                                    _AOE.Installed = true;
                                }
                                _AOE.Version = (String)aux.GetValue("Version");
                                _AOE.Language = (Int32)aux.GetValue("LangID", 0);
                                _AOE.Installed = true;
                            }
                            catch { }
                            break;
                        case _AOE_X_GAMENAME:
                            try
                            {
                                RegistryKey aux = installedGamesReg.OpenSubKey(game).OpenSubKey("1.0");
                                _AOE_X.SetupPath = (String)aux.GetValue("SetupPath");
                                if (_AOE_X.SetupPath.Length > 0)
                                {
                                    _AOE_X.Installed = true;
                                }
                                _AOE_X.Version = (String)aux.GetValue("Version");
                                _AOE_X.Language = (Int32)aux.GetValue("LangID", 0);
                                _AOE_X.Installed = true;
                            }
                            catch { }
                            break;
                        case _AOE_Y_GAMENAME:
                            try
                            {
                                RegistryKey aux = installedGamesReg.OpenSubKey(game).OpenSubKey("1.0");
                                _AOE_Y.SetupPath = (String)aux.GetValue("SetupPath");
                                if (_AOE_Y.SetupPath.Length > 0)
                                {
                                    _AOE_Y.Installed = true;
                                }
                                _AOE_Y.Version = (String)aux.GetValue("Version");
                                _AOE_Y.Language = (Int32)aux.GetValue("LangID", 0);
                                _AOE_Y.Installed = true;
                            }
                            catch { }
                            break;
                    }
                }
            }

            inited = true;
            return inited;
        }

        public AOEGameInfo getAOEInfo()
        {
            return this._AOE;
        }

        public AOEGameInfo getAOEXInfo()
        {
            return this._AOE_X;
        }

        public AOEGameInfo getAOEYInfo()
        {
            return this._AOE_Y;
        }
    }
}
