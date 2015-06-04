using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Mega.App
{
    public static class CUtil
    {
        static List<string> list = new List<string>();

        public static string DireccionServer
        {
            get {                
                return ConfigurationManager.AppSettings.Get("central");
            }
        }

        public static string MiBase
        {
            get {
                return ConfigurationManager.AppSettings.Get("base");
            }
        }

        public static List<string> ListBasesConectadas 
        {
            get {
                return list;
            }
            set {
                list = value;
            }
        }
    }    
}
