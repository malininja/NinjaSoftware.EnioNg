using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NinjaSoftware.EnioNg.CoolJ.DatabaseSpecific;
using NinjaSoftware.EnioNg.CoolJ.EntityClasses;
using Newtonsoft.Json;
using NinjaSoftware.Api.CoolJ;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System.Configuration;
using NinjaSoftware.EnioNg.CoolJ.HelperClasses;

namespace NinjaSoftware.EnioNg.Controllers
{
    public class ApiController : BaseController
    {
		private static string _jsonResponse = "{{ \"IsSaved\": \"{0}\" }}";

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

        protected static bool IsSortAscending(string sord)
        {
            return "asc" == sord.ToLowerInvariant();
        }

        #endregion

        #region Artikl

        [HttpGet]
        public ActionResult GetArtiklCollectionForPaging(string sidx, string sord, string filters, int page = 1)
        {
            DataAccessAdapterBase adapter = new DataAccessAdapter();
            using (adapter)
            {
                if (string.IsNullOrWhiteSpace(sidx))
                {
                    sidx = "Naziv";
                }

                RelationPredicateBucket bucket = new RelationPredicateBucket();
                if (filters != null)
                {
                    bucket.PredicateExpression.Add(PredicateHelper.CreatePredicateFromJqGridFilterString(filters, typeof(ArtiklEntity)));
                }

                bool isSortAscending = IsSortAscending(sord);

                IEnumerable<ArtiklEntity> artiklCollection = ArtiklEntity.FetchArtiklCollectionForPaging(adapter, bucket, null, page, this.JqGridPageSize, sidx, isSortAscending);
                int noOfRecords = ArtiklEntity.GetNumberOfEntities(adapter, null);
                int pageCount = CalculateNoOfPages(noOfRecords, this.JqGridPageSize);

                object result = new
                {
                    page = page,
                    total = pageCount,
                    records = noOfRecords,
                    rows = artiklCollection
                };

                string json = JsonConvert.SerializeObject(result);

                return CreateJsonResponse(json);
            }
        }

        #endregion

        #region Partner

        [HttpPost]
		public ActionResult SavePartner (PartnerEntity partner)
		{
			DataAccessAdapterBase adapter = new DataAccessAdapter();
		    ((INsDataAccessAdapter)adapter).UserId = -1;

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
					partner4Save.UpdateDataFromOtherObject(partner, null, null);
				}

				adapter.SaveEntity(partner4Save);
			}

			string response = string.Format(_jsonResponse, "true");

			return CreateJsonResponse (response);
		}

		[HttpGet]
		public ActionResult GetPartner (long partnerId)
		{
			DataAccessAdapterBase adapter = new DataAccessAdapter ();
			using (adapter) 
			{
				PartnerEntity partner = PartnerEntity.FetchPartner (adapter, null, partnerId);
				string response = JsonConvert.SerializeObject (partner);

				return CreateJsonResponse (response);
			}
        }

        [HttpGet]
        public ActionResult GetPartnerCollectionForPaging(string sidx, string sord, string filters, int page = 1)
        {
            DataAccessAdapter adapter = new DataAccessAdapter();
            using (adapter)
            {
                if (string.IsNullOrWhiteSpace(sidx))
                {
                    sidx = "Naziv";
                }

                RelationPredicateBucket bucket = null;
                if (filters != null)
                {
                    bucket = new RelationPredicateBucket();
                    bucket.PredicateExpression.Add(PredicateHelper.CreatePredicateFromJqGridFilterString(filters, typeof(PartnerFields)));
                }

                bool isSortAscending = IsSortAscending(sord);

                IEnumerable<PartnerEntity> partnerCollection = PartnerEntity.FetchPartnerCollectionForPaging(adapter, bucket, null, page, this.JqGridPageSize, sidx, isSortAscending);
                int noOfRecords = PartnerEntity.GetNumberOfEntities(adapter, null);
                int pageCount = CalculateNoOfPages(noOfRecords, this.JqGridPageSize);

                object result = new
                {
                    page = page,
                    total = pageCount,
                    records = noOfRecords,
                    rows = partnerCollection
                };

                string json = JsonConvert.SerializeObject(result);

                return CreateJsonResponse(json);
            }
        }

        #endregion


        #region Pdv

        [HttpGet]
        public ActionResult GetPdv(long pdvId)
        {
            DataAccessAdapterBase adapter = new DataAccessAdapter();
            using (adapter)
            {
                PdvEntity pdv = PdvEntity.FetchPdv(adapter, null, pdvId);

                string response = JsonConvert.SerializeObject(pdv);
                return CreateJsonResponse(response);
            }
        }

        [HttpPost]
        public ActionResult SavePdv(PdvEntity pdv)
        {
            DataAccessAdapterBase adapter = new DataAccessAdapter();
            ((INsDataAccessAdapter)adapter).UserId = -1;

            using (adapter)
            {
                PdvEntity pdv4Save;

                if (pdv.PdvId == 0)
                {
                    pdv4Save = pdv;
                }
                else
                {
                    pdv4Save = PdvEntity.FetchPdv(adapter, null, pdv.PdvId);
                    pdv4Save.UpdateDataFromOtherObject(pdv, null, null);
                }

                adapter.SaveEntity(pdv4Save);
            }

            string response = string.Format(_jsonResponse, "true");

            return CreateJsonResponse(response);
        }

        [HttpGet]
        public ActionResult GetPdvCollection()
        {
            DataAccessAdapterBase adapter = new DataAccessAdapter();
            using (adapter)
            {
                IEnumerable<PdvEntity> pdvCollection = PdvEntity.FetchPdvCollection(adapter, null, null);
                string json = JsonConvert.SerializeObject(pdvCollection);
                return CreateJsonResponse(json);
            }
        }

        [HttpGet]
        public ActionResult GetPdvCollectionForPaging(string sidx, string sord, string filters, int page = 1)
        {
            DataAccessAdapterBase adapter = new DataAccessAdapter();
            using (adapter)
            {
                if (string.IsNullOrWhiteSpace(sidx))
                {
                    sidx = "Naziv";
                }

                RelationPredicateBucket bucket = new RelationPredicateBucket();
                if (filters != null)
                {
                    bucket.PredicateExpression.Add(PredicateHelper.CreatePredicateFromJqGridFilterString(filters, typeof(PdvEntity)));
                }

                bool isSortAscending = IsSortAscending(sord);

                IEnumerable<PdvEntity> pdvCollection = PdvEntity.FetchPdvCollectionForPaging(adapter, bucket, null, page, this.JqGridPageSize, sidx, isSortAscending);
                int noOfRecords = PdvEntity.GetNumberOfEntities(adapter, null);
                int pageCount = CalculateNoOfPages(noOfRecords, this.JqGridPageSize);

                object result = new
                {
                    page = page,
                    total = pageCount,
                    records = noOfRecords,
                    rows = pdvCollection
                };

                string json = JsonConvert.SerializeObject(result);

                return CreateJsonResponse(json);
            }
        }

        #endregion
    }
}
