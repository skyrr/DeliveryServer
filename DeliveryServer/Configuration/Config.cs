using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeliveryServer.Configuration
{
    public static class Config
    {
        static string urlCors = "http://localhost:4200";
        public static string GetURLForCORS() {
            return urlCors;
        }
    }
}