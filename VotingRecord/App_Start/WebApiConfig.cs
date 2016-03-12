﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace VotingRecords
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // attribute based routing
            config.MapHttpAttributeRoutes();

            // convention based routing
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{name}",
                defaults: new { name = RouteParameter.Optional }
            );
        }
    }
}