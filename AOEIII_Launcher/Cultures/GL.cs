using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AOEIII_Launcher.Culture
{
    public class GL : Culture
    {
        public GL()
        {
            this._STRING_NOT_FOUND_MESSAGE = "ERROR (Non se atopou a cadea de texto.)";
            this.language = G11N.Languages.GL;

            this.langValues.Add("", "");
            this.langValues.Add("LAUNCHER", "Lanzador");
            this.langValues.Add("FILE", "Arquivo");
            this.langValues.Add("OPTIONS", "Opcións");
            this.langValues.Add("HELP", "Axuda");
            this.langValues.Add("EXIT", "Sair");
            this.langValues.Add("ABOUT", "Acerca de");
            this.langValues.Add("GAME_OPTIONS", "Opcions do Xogo");
            this.langValues.Add("NETWORK_OPTIONS", "Opcions de Rede");
            this.langValues.Add("NETWORK", "Rede");
            this.langValues.Add("START_WO_SONG", "Iniciar o xogo sen sonido.");
            this.langValues.Add("START_WO_VIDEO", "Iniciar o xogo sen videos.");
            this.langValues.Add("START_IN_WINDOW", "Iniciar o xogo nunha ventá.");
            this.langValues.Add("LANGUAGE", "Lenguaxe");
            this.langValues.Add("SELECT_NETWORK_ADAPTOR_HELP", "Elixe o adaptador de rede que queiras usar no modo multixogador.");
            this.langValues.Add("START", "Iniciar");
            this.langValues.Add("GAME_NOT_INSTALLED", "O xogo non está instalado.");
            this.langValues.Add("LAUNCHER_FOR_AOE3", "Lanzador para Age of Empires III");
            this.langValues.Add("PROGRAM_WEBSITE", "Web do Programa");
            this.langValues.Add("VERSION", "Versión");
            this.langValues.Add("DEFAULT_GAME", "(Xogo Orixinal)");
            this.langValues.Add("SELECT_MOD", "Escolle un Mod");
            this.langValues.Add("MODS_OPTIONS", "Opcions dos Mod");
            this.langValues.Add("MOD_LOAD_FAIL", "Ocurriu un erro cando o programa tentaba cargar o Mod. ¿Queres iniciar o xogo sen o Mod?");
            this.langValues.Add("FATAL_ERROR", "Erro Fatal");
            this.langValues.Add("AUTHOR", "Autor");
            this.langValues.Add("CLOSE", "Pechar");
            this.langValues.Add("INFORMATION", "Información");
            this.langValues.Add("TRANSLATIONS", "Traduccións");
            this.langValues.Add("MODS", "Mods do Xogo");
            this.langValues.Add("LICENSE", "Licenza");
            this.langValues.Add("TRANSLATIONS_THANKS", "Un agradecimiento aos traductores:");
            this.langValues.Add("AND", "e");
            this.langValues.Add("VPN_CLIENTS", "Clientes VPN");
            this.langValues.Add("IS_A_REGISTERED_TRADEMAEK_OF", "e unha marca rexistrada de");
            this.langValues.Add("WEBSITE", "Paxina Web");


            this.langValues.Add("MOD_POPMOD", "Mod de Poboación");
            this.langValues.Add("SELECT_POPULATION", "Escolle a poboación máxima:");

            this.langValues.Add("ENGLISH_GB", "Inglés (GB)");
            this.langValues.Add("SPANISH", "Español");
            this.langValues.Add("GALICIAN", "Galego");
            this.langValues.Add("PORTUGUESE", "Portugués");
        }
    }
}
