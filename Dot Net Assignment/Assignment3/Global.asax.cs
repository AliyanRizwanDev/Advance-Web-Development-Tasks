using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Assignment3.DB; 

namespace Assignment3
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            using (var dbContext = new AppDbContext())
            {
                AppDbContext.SeedData(dbContext);
                dbContext.SaveChanges();
            }
        }
    }
}
