using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NinjaSoftware.EnioNg.CoolJ.DatabaseSpecific;
using NinjaSoftware.EnioNg.CoolJ.EntityClasses;
using Newtonsoft.Json;
using NinjaSoftware.Api.CoolJ;

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
				PartnerEntity partner4Save;

				if (partner.PartnerId == 0)
				{
					partner.IsActive = true;
					partner4Save = partner;
				}
				else
				{
					partner4Save = PartnerEntity.FetchPartner (adapter, null, partner.PartnerId);

				}

				adapter.SaveEntity(partner4Save);
			}

			string response = string.Format(_jsonResponse, "true");

			return CreateJsonResponse (response);
		}

		[HttpGet]
		public ActionResult GetPartner (long partnerId)
		{
			DataAccessAdapter adapter = new DataAccessAdapter ();
			using (adapter) 
			{
				PartnerEntity partner = PartnerEntity.FetchPartner (adapter, null, partnerId);
				string response = JsonConvert.SerializeObject (partner);

				return CreateJsonResponse (response);
			}
		}
    }
}
