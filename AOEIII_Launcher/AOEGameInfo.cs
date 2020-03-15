using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AOEIII_Launcher
{
    public class AOEGameInfo
    {
        private String _name;

        private Boolean _installed = false;
        private String _path = null;
        private String _realname = null;
        private String _version = null;
        private Int32 _lang = 0;

        public AOEGameInfo(String name)
        {
            this._name = name;
        }

        public String Name
        {
            get { return this._name; }
        }

        public String RealName
        {
            get { return this._realname; }
            set { this._realname = value; }
        }

        public Boolean Installed
        {
            get { return this._installed; }
            set { this._installed = value; }
        }

        public String SetupPath
        {
            get { return this._path; }
            set { this._path = value; }
        }

        public String Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        public Int32 Language
        {
            get { return this._lang; }
            set { this._lang = value; }
        }
    }
}
