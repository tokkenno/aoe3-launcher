using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Microsoft.Win32;
using AOEIII_Launcher.Utils;
using System.Xml;
using System.IO;

namespace AOEIII_Launcher
{
    public class Configuration
    {
        public enum configLocation { APPDIR, APPDATA, CUSTOM };

        private String path;

        private ArrayList keyList = new ArrayList();
        private ArrayList typeList = new ArrayList();
        private ArrayList valueList = new ArrayList();

        public Configuration(String fileName, configLocation fileLocation)
            : this(fileName, fileLocation, ".")
        {
        }

        public Configuration(String fileName, configLocation fileLocation, String filePath)
        {
            switch (fileLocation)
            {
                case configLocation.APPDIR:
                    this.path = "./" + fileName + ".conf";
                    break;
                case configLocation.APPDATA:
                    if (filePath == null)
                    {
                        throw new Exception("AppData directory name not found.");
                    }
                    else
                    {
                        if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/" + filePath))
                        {
                            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/" + filePath);
                        }

                        this.path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/" + filePath + "/" + fileName + ".conf";
                    }
                    break;

                case configLocation.CUSTOM:
                    if (filePath == null)
                    {
                        throw new Exception("Custom directory path not found.");
                    }
                    else
                    {
                        this.path = filePath + "/" + fileName + ".conf";
                    }
                    break;
            }
        }

        public void Set(String key, Object value)
        {
            int pos = this.keyList.IndexOf(key);

            if (pos == -1)
            {
                this.keyList.Add(key);
                this.typeList.Add(value.GetType());
                this.valueList.Add(value);
            }
            else
            {
                this.typeList[pos] = value.GetType();
                this.valueList[pos] = value;
            }
        }

        public Object Get(String key)
        {
            for (int i = 0; i < this.keyList.Count; i++)
            {
                if (this.keyList[i].ToString() == key)
                {
                    return this.valueList[i];
                }
            }

            return null;
        }

        public Type GetType(String key)
        {
            for (int i = 0; i < this.keyList.Count; i++)
            {
                if (this.keyList[i].ToString() == key)
                {
                    return (Type)this.typeList[i];
                }
            }

            return null;
        }

        public Int32 GetIndex(String key)
        {
            for (int i = 0; i < this.keyList.Count; i++)
            {
                if (this.keyList[i].ToString() == key)
                {
                    return i;
                }
            }

            return -1;
        }

        public Boolean Load()
        {
            if (!File.Exists(this.path))
            {
                return false;
            }

            /*try
            {*/
            using (FileStream oFile = new FileStream(this.path, FileMode.Open))
            {
                oFile.Seek(0, SeekOrigin.Begin);
                using (XmlTextReader xDoc = new XmlTextReader(oFile))
                {
                    this.keyList.Clear();
                    this.typeList.Clear();
                    this.valueList.Clear();

                    xDoc.ReadStartElement("Configuration");
                    while (xDoc.Read())
                    {
                        if (xDoc.NodeType == XmlNodeType.Element && xDoc.Name == "ConfigToken")
                        {
                            try
                            {
                                String Skey = xDoc.GetAttribute(0);
                                Type Stype = System.Type.GetType(xDoc.GetAttribute(1));
                                Object Svalue = System.Convert.ChangeType(xDoc.GetAttribute(2), Stype);
                                this.keyList.Add(Skey);
                                this.typeList.Add(Stype);
                                this.valueList.Add(Svalue);
                            }
                            catch (Exception e)
                            {
                                System.Windows.Forms.MessageBox.Show("Esto va mal: " + e.Message);
                            }
                        }
                    }
                }
            }

            return true;/*
            }
            catch { return false; }*/
        }

        public Boolean Save()
        {
            if (!Directory.Exists(path.Substring(0, path.LastIndexOf('\\'))))
            {
                Directory.CreateDirectory(path.Substring(0, path.LastIndexOf('\\')));
            }

            if (File.Exists(this.path))
            {
                File.Delete(this.path);
            }

            using (FileStream oFile = new FileStream(this.path, FileMode.Create))
            {
                oFile.Seek(0, SeekOrigin.Begin);
                using (XmlTextWriter textWriter = new XmlTextWriter(oFile, Encoding.UTF8))
                {
                    textWriter.WriteStartDocument();
                    textWriter.WriteStartElement("Configuration");
                    textWriter.Formatting = Formatting.Indented;
                    textWriter.WriteComment("AOE3Launcher Configuration File");


                    for (int i = 0; i < this.keyList.Count; i++)
                    {
                        textWriter.WriteStartElement("ConfigToken");
                        textWriter.WriteAttributeString("key", this.keyList[i].ToString());
                        textWriter.WriteAttributeString("type", this.typeList[i].ToString());
                        textWriter.WriteAttributeString("value", this.valueList[i].ToString());
                        textWriter.WriteEndElement();
                    }

                    textWriter.WriteEndElement();
                    textWriter.WriteEndDocument();

                    textWriter.Flush();
                }
                oFile.Close();
            }

            return true;
        }
    }
}
