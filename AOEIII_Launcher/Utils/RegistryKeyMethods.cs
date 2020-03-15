using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace AOEIII_Launcher.Utils
{
    public static class RegistryKeyMethods
    {
        public static Boolean ExistSubKey(RegistryKey rk, String subKey)
        {
            RegistryKey rk1 = rk.OpenSubKey(@subKey);

            return rk1 != null;
        }
    }
}
