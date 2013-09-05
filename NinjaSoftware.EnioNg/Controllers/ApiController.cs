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
    public class ApiController : Controller
    {
		private static string _jsonResponse = "{{ \"IsSaved\": \"{0}\" }}";

		private static ActionResult CreateJsonResponse (string json)
		{
			ContentResult result = new ContentResult();
			result.Content = json;
			result.ContentType = "application/json";

			return result;
		}

		[HttpGet]
		public ActionResult GetPartnerCollection()
		{
			DataAccessAdapter adapter = new DataAccessAdapter();
			IEnumerable<PartnerEntity> partnerCollection = PartnerEntity.FetchPartnerCollection(adapter, null, null);

			string json = JsonConvert.SerializeObject(partnerCollection);

			return CreateJsonResponse (json);
		}

		[HttpGet]
		public ActionResult GetPartnerCollectionForPaging(string sidx, string sord, string filters, int page = 1)
		{
			DataAccessAdapter adapter = new DataAccessAdapter();
			try 
			{
				using (adapter)
				{
					IEnumerable<PartnerEntity> partnerCollection = PartnerEntity.FetchPartnerCollectionForPaging(adapter, null, null, page, 10, sidx, true);
					int noOfRecords = PartnerEntity.GetNumberOfEntities(adapter, null);

					object result = new
					{
						page = page,
						total = 5,
						records = noOfRecords,
						rows = partnerCollection
					};

					string json = JsonConvert.SerializeObject(result);

					return CreateJsonResponse (json);
				}
			} 
			catch (Exception ex) 
			{
				return new ContentResult();
			}

		}

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
