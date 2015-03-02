using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Routing;

namespace Owinofy.Configuration
{
    public class ApiConfiguration
    {
        private readonly HttpConfiguration _httpConfiguration;

        public ApiConfiguration(HttpConfiguration apiConfiguration)
        {
            //TODO:Create custom exceptions 
            //if there are no routes specified then use the default routes
            if (apiConfiguration == null || apiConfiguration.Routes.Count == 0)
            {
                apiConfiguration = new HttpConfiguration();
                apiConfiguration.Routes.Add("DefaultApi", new HttpRoute("api/{Controller}"));
            }

            _httpConfiguration = apiConfiguration;
        }

        /// <summary>
        /// This method returns the HttpConfiguration object for Web API. 
        /// If no route has been provided a default route "api/{Controller}" will be added.
        /// </summary>
        /// <returns></returns>
        public HttpConfiguration GetApiConfiguration()
        {
            return _httpConfiguration;
        }
    }
}
