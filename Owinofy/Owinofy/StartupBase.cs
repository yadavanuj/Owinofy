using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.StaticFiles;
using Owin;
using Owinofy.Configuration;

namespace Owinofy
{
    public class StartupBase
    {   
        public void Configuration(IAppBuilder app, HttpConfiguration routeConfiguration = null)
        {  
            //Add web api configuration
            var apiConfiguration = new ApiConfiguration(routeConfiguration);
            app.UseWebApi(apiConfiguration.GetApiConfiguration());

            // Turns on static files, without directory browsing, and default files.
            var staticFileFolder = ConfigurationManager.AppSettings["staticfilefolder"];
            if (!String.IsNullOrEmpty(staticFileFolder))
            {
                app.UseFileServer(new FileServerOptions()
                {
                    RequestPath = new PathString()
                });    
            }
        }
    }
}
