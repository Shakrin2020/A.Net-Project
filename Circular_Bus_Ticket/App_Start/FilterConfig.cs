﻿using System.Web;
using System.Web.Mvc;

namespace Circular_Bus_Ticket
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
