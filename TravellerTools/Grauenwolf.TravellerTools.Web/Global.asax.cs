﻿using Grauenwolf.TravellerTools.Animals.AE;
using Grauenwolf.TravellerTools.Animals.Mgt;
using Grauenwolf.TravellerTools.TradeCalculator;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Grauenwolf.TravellerTools.Web
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            string appDataPath = Server.MapPath("~/app_data");
            TradeEngine1.SetDataPath(appDataPath);
            TradeEngine2.SetDataPath(appDataPath);
            AnimalBuilderMgt.SetDataPath(appDataPath);
            AnimalBuilderAE.SetDataPath(appDataPath);

        }

        public static readonly TradeEngine TradeEngine1 = new TradeEngineMgt();
        public static readonly TradeEngine TradeEngine2 = new TradeEngineMgt2();
    }
}
