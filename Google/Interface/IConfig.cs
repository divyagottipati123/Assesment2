using Google.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google.Interface
{
    public interface IConfig
    {
        BrowserType GetBrowser();
        String GetWebsite();
        String GetXlpath();
    }
}
