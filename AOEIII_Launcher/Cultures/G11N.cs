using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AOEIII_Launcher.Culture
{
    public class G11N
    {
        /// <summary>
        /// Countries Code List (ISO 3166:1993)
        /// </summary>
        public enum Countries
        {
            AF, AL, DZ, AS, AD, AO, AI, AQ, AG, AR, AM, AW, AU, AT, AZ, ZR, ZM, ZW,
            BS, BH, BD, BB, BE, BZ, BJ, BM, BT, BO, BA, BW, BV, BR, IO, VG, BN, BG, BF, BI,
            BY, KH, CM, CA, CV, KY, CF, TD, CL, CN, CX, CC, CO, KM, CG, CK, CR, CI, HR, CU,
            CY, CZ, KP, DK, DJ, DM, DO, TP, EC, EG, SV, GQ, ER, EE, ET, FK, FO, DE, FJ, FI,
            FR, FX, GF, PF, TF, GA, GM, GE, GH, GI, GR, GL, GD, GP, GU, GT, GN, GW, GY, HT,
            HM, HN, HK, HU, IS, IN, ID, IR, IQ, IE, IL, IT, JM, JP, JO, KZ, KE, KI, KW, KG,
            LA, LV, LB, LS, LR, LY, LI, LT, LU, MO, MG, MW, MY, MV, ML, MT, MH, MQ, MR, MU,
            YT, MX, FM, MD, MC, MN, MS, MA, MZ, MM, NA, NR, NP, NL, AN, NC, NZ, NI, NE, NG,
            NU, NF, MP, NO, OM, PK, PW, PA, PG, PY, PE, PH, PN, PL, PT, PR, QA, KR, RE, RO,
            RU, RW, KN, LC, WS, SM, ST, SA, SN, SC, SL, SG, SK, SI, SB, SO, ZA, GS, ES, LK,
            SH, PM, VC, SD, SR, SJ, SZ, SE, CH, SY, TW, TJ, TH, TG, TK, TO, TT, TN, TR, TM,
            TC, TV, UG, UA, AE, GB, TZ, US, UM, VI, UY, UZ, VU, VA, VE, VN, WF, EH, YE, YU, UNDEFINED
        };

        /// <summary>
        /// Languages Code List (ISO 639-1)
        /// </summary>
        public enum Languages
        {
            AB, AF, AN, AR, AS, AZ, BE, BG, BN, BO, BR, BS, CA, CE, CO, CS, CU, CY, DA,
            DE, EL, EN, EO, ES, ET, EU, FA, FI, FJ, FO, FR, FY, GA, GD, GL, GV, HE, HI, HR, HT,
            HU, HY, ID, IS, IT, JA, JV, KA, KG, KO, KU, KW, KY, LA, LB, LI, LN, LT, LV, MG, MK,
            MN, MO, MS, MT, MY, NB, NE, NL, NN, NO, OC, PL, PT, RM, RO, RU, SC, SE, SK, SL, SO,
            SQ, SR, SV, SW, TK, TR, TY, UK, UR, UZ, VI, VO, YI, ZH, UNDEFINED
        };

        private Languages defaultLang = Languages.EN;
        private Countries defaultCountry = Countries.UNDEFINED;
        private Culture actualCulture = null;
        private Culture[] cultures = { new EN(), new EN_GB(), new ES(), new ES_ES(), new GL(), new GL_ES(), new PT(), new PT_PT() };

        public G11N() {
        }

        public Boolean setCulture()
        {
            return setCulture(System.Globalization.CultureInfo.CurrentCulture.TwoLetterISOLanguageName.ToUpper());
        }

        public Boolean setCulture(String language)
        {
            return setCulture(language, Enum.GetName(typeof(Countries), Countries.UNDEFINED));
        }

        public Boolean setCulture(String language, String country)
        {
            Languages lang = Languages.UNDEFINED;
            Countries count = Countries.UNDEFINED;

            foreach (Languages l in Enum.GetValues(typeof(Languages)))
            {
                if (Enum.GetName(typeof(Languages), l) == language)
                {
                    lang = l;
                    break;
                }
            }

            foreach (Countries c in Enum.GetValues(typeof(Countries)))
            {
                if (Countries.GetName(typeof(Countries), c) == country)
                {
                    count = c;
                    break;
                }
            }

            foreach (Culture c in cultures)
            {
                if (lang == c.Language && count == c.Country)
                {
                    return setCulture(lang, count);
                }
            }

            return setCulture(defaultLang, defaultCountry);
        }

        public Boolean setCulture(Languages language)
        {
            return setCulture(language, Countries.UNDEFINED);
        }

        public Boolean setCulture(Languages language, Countries country)
        {
            foreach (Culture c in cultures)
            {
                if (c.Language == language && c.Country == country)
                {
                    actualCulture = c;
                    return true;
                }
            }

            return false;
        }

        public Culture Culture
        {
            get { return actualCulture; }
        }

        public String getTranslateString(String ID)
        {
            if (actualCulture == null)
            {
                throw new Exception("Culture not selected yet.");
            }

            return actualCulture.getTranslateString(ID);
        }
    }
}
