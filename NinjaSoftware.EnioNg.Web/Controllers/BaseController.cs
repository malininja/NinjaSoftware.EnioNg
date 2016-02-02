using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using Newtonsoft.Json;

namespace NinjaSoftware.EnioNg.Web.Controllers
{
    public class BaseController : Controller
    {
        protected static ActionResult CreateJsonResponse(object response)
        {
            string json = JsonConvert.SerializeObject(response);
            
            ContentResult result = new ContentResult();
            result.Content = json;
            result.ContentType = "application/json";

            return result;
        }
    }
}
