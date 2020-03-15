using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Resources;
using System.Reflection;

namespace AOEIII_Launcher.Utils
{
    public static class ResourceExtractor
    {
        public static Boolean Extract(byte[] resource, string path)
        {
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

                Stream st = new MemoryStream(resource);

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
