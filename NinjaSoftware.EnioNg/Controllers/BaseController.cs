using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NinjaSoftware.EnioNg.Controllers
{
    public class BaseController : Controller
    {
		protected static ActionResult CreateJsonResponse (string json)
		{
			ContentResult result = new ContentResult();
			result.Content = json;
			result.ContentType = "application/json";

			return result;
		}
    }
}
