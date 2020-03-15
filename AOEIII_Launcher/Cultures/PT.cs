using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AOEIII_Launcher.Culture
{
    public class PT : Culture
    {
        public PT()
        {
            this._STRING_NOT_FOUND_MESSAGE = "ERROR (Non se atopou a cadea de texto.)";
            this.language = G11N.Languages.PT;

            this.langValues.Add("", "");
            this.langValues.Add("LAUNCHER", "Lançador");
            this.langValues.Add("FILE", "Arquivo");
            this.langValues.Add("OPTIONS", "Opções");
            this.langValues.Add("HELP", "Ajuda");
            this.langValues.Add("EXIT", "Saír");
            this.langValues.Add("ABOUT", "Sobre");
            this.langValues.Add("GAME_OPTIONS", "Opções de Jogo");
            this.langValues.Add("NETWORK_OPTIONS", "Opções de Rede");
            this.langValues.Add("NETWORK", "Rede");
            this.langValues.Add("START_WO_SONG", "Começar jogo sem som.");
            this.langValues.Add("START_WO_VIDEO", "Começar jogo sem video.");
            this.langValues.Add("START_IN_WINDOW", "Começar jogo en janela.");
            this.langValues.Add("LANGUAGE", "Idioma");
            this.langValues.Add("SELECT_NETWORK_ADAPTOR_HELP", "Escolha o adaptador de rede que vocé gostaria de usar no modo multijogador.");
            this.langValues.Add("START", "Começar");
            this.langValues.Add("GAME_NOT_INSTALLED", "O jogo nao foi instalado");
            this.langValues.Add("LAUNCHER_FOR_AOE3", "Lançador para Age of Empires III");
            this.langValues.Add("PROGRAM_WEBSITE", "Site do programa");
            this.langValues.Add("VERSION", "Versão");
            this.langValues.Add("DEFAULT_GAME", "(Jogo Original)");
            this.langValues.Add("SELECT_MOD", "Selecione um mod");
            this.langValues.Add("MODS_OPTIONS", "Opções dos Mods");
            this.langValues.Add("MOD_LOAD_FAIL", "Erro quando o programa tentaba carregar o mod. ¿Começar jogo sem mod?");
            this.langValues.Add("FATAL_ERROR", "Erro Fatal");
            this.langValues.Add("AUTHOR", "Autor");
            this.langValues.Add("CLOSE", "Fechar");
            this.langValues.Add("INFORMATION", "Informação");
            this.langValues.Add("TRANSLATIONS", "Traduções");
            this.langValues.Add("MODS", "Mods do Jogo");
            this.langValues.Add("LICENSE", "Licença");
            this.langValues.Add("TRANSLATIONS_THANKS", "Um agradecimento especial aos tradutores:");
            this.langValues.Add("AND", "e");
            this.langValues.Add("VPN_CLIENTS", "Clientes VPN");
            this.langValues.Add("IS_A_REGISTERED_TRADEMAEK_OF", "é uma marca registada de");


            this.langValues.Add("MOD_POPMOD", "Mod de população");
            this.langValues.Add("SELECT_POPULATION", "Selecione a população máxima:");

            this.langValues.Add("ENGLISH_GB", "Inglês(GB)");
            this.langValues.Add("SPANISH", "Espanhol");
            this.langValues.Add("GALICIAN", "Galego");
            this.langValues.Add("PORTUGUESE", "Português");
        }
    }
}
