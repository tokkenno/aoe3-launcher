using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.IO;

namespace AOEIII_Launcher
{
    public static class VPN
    {
        public static String searchRemobo()
        {
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Remobo\\remobo-gui.exe"))
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Remobo\\remobo-gui.exe";
            }

            try
            {
                RegistryKey rk1 = Registry.LocalMachine;
                RegistryKey rk2 = rk1.OpenSubKey(@"SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\Remobo");
                
                String val = rk2.GetValue("UninstallString").ToString();
                
                if (!val.Contains("uninstall.exe"))
                {
                    return null;
                }

                val = val.Substring(1, val.LastIndexOf('\\')) + "remobo-gui.exe";
                return val;
            }
            catch
            {
                return null;
            }
        }
    }
}
