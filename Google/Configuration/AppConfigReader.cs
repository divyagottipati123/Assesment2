using Google.Interface;
using Google.Settings;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google.Configuration
{
   public class AppConfigReader:IConfig
    {
        public BrowserType GetBrowser()
        {
            String browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
            return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
        }

        public string GetWebsite()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Website);

        }
        public string GetXlpath()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Xlpath);
        }
    }
}
