using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AOEIII_Launcher.Culture
{
    public abstract class Culture
    {
        protected String _STRING_NOT_FOUND_MESSAGE = String.Empty;
        protected Dictionary<String, String> langValues = new Dictionary<String, String>();

        protected G11N.Countries country = G11N.Countries.UNDEFINED;
        protected G11N.Languages language = G11N.Languages.UNDEFINED;

        public String getTranslateString(String id)
        {
            if (this.langValues.ContainsKey(id))
            {
                return this.langValues[id];
            }
            else
            {
                return this._STRING_NOT_FOUND_MESSAGE;
            }
        }

        public G11N.Languages Language
        {
            get { return this.language; }
        }

        public G11N.Countries Country
        {
            get { return this.country; }
        }
    }
}
