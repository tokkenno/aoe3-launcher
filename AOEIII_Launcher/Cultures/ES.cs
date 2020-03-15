using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AOEIII_Launcher.Culture
{
    public class ES : Culture
    {
        public ES()
        {
            this._STRING_NOT_FOUND_MESSAGE = "ERROR (Cadena de texto no encontrada.)";
            this.language = G11N.Languages.ES;

            this.langValues.Add("", "");
            this.langValues.Add("LAUNCHER", "Lanzador");
            this.langValues.Add("FILE", "Archivo");
            this.langValues.Add("OPTIONS", "Opciones");
            this.langValues.Add("HELP", "Ayuda");
            this.langValues.Add("EXIT", "Salir");
            this.langValues.Add("ABOUT", "Acerca de");
            this.langValues.Add("GAME_OPTIONS", "Opciones del Juego");
            this.langValues.Add("NETWORK_OPTIONS", "Opciones de Red");
            this.langValues.Add("NETWORK", "Red");
            this.langValues.Add("START_WO_SONG", "Iniciar el juego sin sonido.");
            this.langValues.Add("START_WO_VIDEO", "Iniciar el juego sin video.");
            this.langValues.Add("START_IN_WINDOW", "Iniciar el juego en una ventana.");
            this.langValues.Add("LANGUAGE", "Idioma");
            this.langValues.Add("SELECT_NETWORK_ADAPTOR_HELP", "Elije el adaptador de red que quieras usar en el juego multijugador.");
            this.langValues.Add("START", "Iniciar");
            this.langValues.Add("GAME_NOT_INSTALLED", "El juego no está instalado.");
            this.langValues.Add("LAUNCHER_FOR_AOE3", "Lanzador para Age of Empires III");
            this.langValues.Add("PROGRAM_WEBSITE", "Web del Programa");
            this.langValues.Add("VERSION", "Versión");
            this.langValues.Add("DEFAULT_GAME", "(Juego Original)");
            this.langValues.Add("SELECT_MOD", "Selecciona un Mod");
            this.langValues.Add("MODS_OPTIONS", "Opciones de los Mod");
            this.langValues.Add("MOD_LOAD_FAIL", "Ha ocurrido un error cuando el programa intentaba cargar el Mod. ¿Quieres iniciar el juego sin el Mod?");
            this.langValues.Add("FATAL_ERROR", "Error Fatal");
            this.langValues.Add("AUTHOR", "Autor");
            this.langValues.Add("CLOSE", "Cerrar");
            this.langValues.Add("INFORMATION", "Información");
            this.langValues.Add("TRANSLATIONS", "Traducciones");
            this.langValues.Add("MODS", "Mods del Juego");
            this.langValues.Add("LICENSE", "Licencia");
            this.langValues.Add("TRANSLATIONS_THANKS", "Un agradecimiento a los traductores:");
            this.langValues.Add("AND", "y");
            this.langValues.Add("VPN_CLIENTS", "Clientes VPN");
            this.langValues.Add("IS_A_REGISTERED_TRADEMAEK_OF", "es una marca registrada de");
            this.langValues.Add("WEBSITE", "Pagina Web");


            this.langValues.Add("MOD_POPMOD", "Mod de Población");
            this.langValues.Add("SELECT_POPULATION", "Selecciona la población máxima:");

            this.langValues.Add("ENGLISH_GB", "Inglés (GB)");
            this.langValues.Add("SPANISH", "Español");
            this.langValues.Add("GALICIAN", "Gallego");
            this.langValues.Add("PORTUGUESE", "Portugués");
        }
    }
}
