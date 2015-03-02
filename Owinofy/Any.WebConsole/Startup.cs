using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.StaticFiles;
using Owin;
using Owinofy;

namespace Any.WebConsole
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var startupBase = new StartupBase();
            startupBase.Configuration(app);
        }
    }
}
