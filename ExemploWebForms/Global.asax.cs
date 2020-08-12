using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using ExemploWebForms.Models;

namespace ExemploWebForms
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Código que é executado na inicialização do aplicativo
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Database.SetInitializer(new DatabaseInitializer());
        }
    }
}