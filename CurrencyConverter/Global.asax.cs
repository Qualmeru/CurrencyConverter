using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using CurrencyConverter.Models;

namespace CurrencyConverter
{
    public class MvcApplication : HttpApplication
    {
        public static CurrencyTable currencyTable;
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            currencyTable = new CurrencyTable();
        }
    }
}
