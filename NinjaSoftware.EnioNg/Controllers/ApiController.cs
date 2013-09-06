using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NinjaSoftware.EnioNg.CoolJ.DatabaseSpecific;
using NinjaSoftware.EnioNg.CoolJ.EntityClasses;
using Newtonsoft.Json;

namespace NinjaSoftware.EnioNg.Controllers
{
    public class ApiController : BaseController
    {
		private static string _jsonResponse = "{{ \"IsSaved\": \"{0}\" }}";

		[HttpPost]
		public ActionResult SavePartner (PartnerEntity partner)
		{
			DataAccessAdapter adapter = new DataAccessAdapter ();
			adapter.UserId = -1;

			using (adapter) 
			{
				if (partner.PartnerId == 0)
				{
					partner.IsActive = true;
				}

				adapter.SaveEntity(partner);
			}

			string response = string.Format(_jsonResponse, "true");

			return CreateJsonResponse (response);
		}
    }
}
