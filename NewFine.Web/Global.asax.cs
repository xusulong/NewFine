﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace NewFine.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //
            AreaRegistration.RegisterAllAreas();
            //注册过滤器
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            //
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
