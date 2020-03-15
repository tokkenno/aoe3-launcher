using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AOEIII_Launcher.Mods
{
    public static class PopMod
    {
        public static Boolean createPatchPopModExecutable(String path, String population)
        {
            if (System.Convert.ToInt32(population) > 999 || System.Convert.ToInt32(population) < 200)
            {
                return false;
            }

            try
            {
                if (!Directory.Exists(new FileInfo(path).DirectoryName))
                {
                    Directory.CreateDirectory(new FileInfo(path).DirectoryName);
                }

                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                Stream st = new MemoryStream(Properties.Resources.popmodtrainer);

                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                if (st != null)
                {
                    // Creo el Buffer
                    byte[] buffer = new byte[1024];
                    int readCnt = 0;
                    //escribo en el archivo
                    while ((readCnt = st.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        fs.Write(buffer, 0, readCnt);
                    }
                    
                    byte[] pop = new System.Text.ASCIIEncoding().GetBytes(population);
                    fs.Write(pop,0,3);

                    byte[] rest = new byte[421];
                    for (int i = 0; i < rest.Length; i++) { rest[i] = 0x00; }
                    fs.Write(rest, 0, rest.Length);

                    // close the streams
                    st.Close();
                    fs.Close();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
