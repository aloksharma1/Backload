﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Backload.HowTo.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "{controller}/{id}.{ext}",
            //    defaults: new { id = RouteParameter.Optional, ext = RouteParameter.Optional },
            //    constraints: new { id = "[^\\.]+" } // anything but a period
            //);

            // Heben Sie die Kommentierung der folgenden Codezeile auf, um Abfrageunterstützung für Aktionen mit dem Rückgabetyp "IQueryable" oder "IQueryable<T>" zu aktivieren.
            // Damit die Verarbeitung unerwarteter oder böswilliger Abfragen vermieden wird, verwenden Sie die Überprüfungseinstellungen für "QueryableAttribute" zum Überprüfen eingehender Abfragen.
            // Weitere Informationen finden Sie unter "http://go.microsoft.com/fwlink/?LinkId=279712".
            //config.EnableQuerySupport();

        }
    }
}
