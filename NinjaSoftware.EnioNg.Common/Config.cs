using System;
using System.Configuration;

namespace NinjaSoftware.EnioNg.Common
{
    public class Config
    {
        public static int JqGridPageSize
        {
            get { return int.Parse(ConfigurationManager.AppSettings["JqGridPageSize"]); }
        }
        
        public static int MinPasswordLength
        {
            get { return int.Parse(ConfigurationManager.AppSettings["MinPasswordLength"]); }
        }
    }
}

