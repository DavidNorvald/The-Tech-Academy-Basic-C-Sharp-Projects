﻿using System.Web;
using System.Web.Mvc;

namespace Car_Insurance_Drill
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
