using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Net;

namespace AOEIII_Launcher.Utils
{
    public static class NetInfo
    {
        static public ArrayList getIpAddresses()
        {
            ArrayList list = new ArrayList();

            try
            {
                String iphostname = Dns.GetHostName();
                IPHostEntry ipentry = Dns.GetHostEntry(iphostname);
                IPAddress[] addr = ipentry.AddressList;
                for (int i = 0; i < addr.Length; i++)
                {
                    String add = Convert.ToString(addr[i]);

                    if ((!addr[i].IsIPv6LinkLocal && !addr[i].IsIPv6Multicast && !addr[i].IsIPv6SiteLocal && !addr[i].IsIPv6Teredo) && (add[1] == '.' || add[2] == '.' || add[3] == '.') && (add != "127.0.0.1" && add != "0.0.0.0"))
                    {
                        list.Add(add);
                    }
                }
            }
            catch { }

            return list;
        }
    }
}
