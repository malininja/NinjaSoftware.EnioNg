﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NinjaSoftware.EnioNg.CoolJ.DatabaseSpecific;
using NinjaSoftware.EnioNg.CoolJ.EntityClasses;
using Newtonsoft.Json;
using System.Configuration;

namespace NinjaSoftware.EnioNg.Controllers
{
    public class JqGridController : BaseController
    {
		private int? _jqGridPageSize;
		public int JqGridPageSize {
			get
			{
				if (!_jqGridPageSize.HasValue)
				{
					_jqGridPageSize = int.Parse(ConfigurationManager.AppSettings["JqGridPageSize"]);
				}

				return _jqGridPageSize.Value;
			}
		}

        protected static int CalculateNoOfPages(int noOfRecords, int pageSize)
        {
            int toReturn;

            if (0 == pageSize)
            {
                toReturn = 0;
            }
            else
            {
                toReturn = noOfRecords / pageSize;

                if ((noOfRecords % pageSize) > 0)
                {
                    toReturn++;
                }
            }

            return toReturn;
        }

		[HttpGet]
		public ActionResult GetPartnerCollectionForPaging(string sidx, string sord, string filters, int page = 1)
		{
			DataAccessAdapter adapter = new DataAccessAdapter();
			using (adapter)
			{
				if (string.IsNullOrWhiteSpace (sidx))
				{
					sidx = "Naziv";
				}

				IEnumerable<PartnerEntity> partnerCollection = PartnerEntity.FetchPartnerCollectionForPaging(adapter, null, null, page, this.JqGridPageSize, sidx, true);
				int noOfRecords = PartnerEntity.GetNumberOfEntities(adapter, null);
				int pageCount = CalculateNoOfPages (noOfRecords, this.JqGridPageSize);

				object result = new
				{
					page = page,
					total = pageCount,
					records = noOfRecords,
					rows = partnerCollection
				};

				string json = JsonConvert.SerializeObject(result);

				return CreateJsonResponse (json);
			}
		}
    }
}