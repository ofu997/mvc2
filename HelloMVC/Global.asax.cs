using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HelloMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

		//routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

  //          routes.MapRoute(
  //              "Default",                                              // Route name
  //              "{controller}/{action}/{id}",                           // URL with parameters
  //              new { controller = "Home", action = "Index", id = "" }  // Parameter defaults
  //          );
    }
}
