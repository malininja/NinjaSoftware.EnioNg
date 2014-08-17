using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace NinjaSoftware.EnioNg.Web.Controllers
{
    public class BaseController : Controller
    {
        protected static ActionResult CreateJsonResponse(string json)
        {
            ContentResult result = new ContentResult();
            result.Content = json;
            result.ContentType = "application/json";

            return result;
        }

        protected static string _jsonResponse = "{{ \"IsSaved\": \"{0}\" }}";

        #region JqGrid helpers

        private int? _jqGridPageSize;
        public int JqGridPageSize
        {
            get
            {
                if (!_jqGridPageSize.HasValue)
                {
                    _jqGridPageSize = int.Parse(ConfigurationManager.AppSettings["JqGridPageSize"]);
                }

                return _jqGridPageSize.Value;
            }
        }

        #endregion
    }
}
