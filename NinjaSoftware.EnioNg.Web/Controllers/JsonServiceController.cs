using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NinjaSoftware.EnioNg.CoolJ.EntityClasses;
using NinjaSoftware.EnioNg.CoolJ.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.Api.CoolJ;
using NinjaSoftware.EnioNg.CoolJ.DatabaseSpecific;
using Newtonsoft.Json;
using System.Configuration;
using NinjaSoftware.EnioNg.CoolJ;
using NinjaSoftware.EnioNg.Web.Helpers;
using NinjaSoftware.EnioNg.Web.Models;
using NinjaSoftware.Api.Mvc;
using System.Globalization;

namespace NinjaSoftware.EnioNg.Web.Controllers
{
    public class JsonServiceController : BaseController
    {
        #region Artikl

        [HttpGet]
        public ActionResult GetArtikl(long artiklId)
        {
            DataAccessAdapterBase adapter = new DataAccessAdapter();
            using (adapter)
            {
                ArtiklEntity artikl = ArtiklEntity.FetchArtikl(adapter, null, artiklId);

                string response = JsonConvert.SerializeObject(artikl);
                return CreateJsonResponse(response);
            }
        }

        [HttpGet]
        public ActionResult GetArtiklCollection()
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter(User.Identity.Name);
            using (adapter)
            {
                IEnumerable<ArtiklEntity> artiklCollection = ArtiklEntity.FetchArtiklCollection(adapter, null, null);
                string response = JsonConvert.SerializeObject(artiklCollection);
                return CreateJsonResponse(response);
            }
        }

        [HttpGet]
        public ActionResult GetArtiklCollectionForPaging(string sidx, string sord, string filters, int page = 1)
        {
            DataAccessAdapterBase adapter = new DataAccessAdapter();
            using (adapter)
            {
                RelationPredicateBucket bucket = new RelationPredicateBucket();
                if (filters != null)
                {
                    bucket.PredicateExpression.Add(PredicateHelper.CreatePredicateFromJqGridFilterString(filters, typeof(ArtiklFields)));
                }

                bool? isSortAscending = PagerBase.IsJqgridSortAscending(sord);

                PrefetchPath2 prefetchPath = new PrefetchPath2(EntityType.ArtiklEntity);
                prefetchPath.Add(ArtiklEntity.PrefetchPathPdv);

                ArtiklPager artiklPager = new ArtiklPager();
                artiklPager.LoadData(adapter, bucket, page, this.JqGridPageSize, sidx, isSortAscending);

                return CreateJsonResponse(artiklPager.CreateJqGridRespose());
            }
        }

        [HttpPost]
        public ActionResult SaveArtikl(ArtiklEntity artikl)
        {
            bool isSaved = false;

            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter(User.Identity.Name);
            using (adapter)
            {
                ArtiklEntity artikl4Save;

                if (artikl.ArtiklId == 0)
                {
                    artikl4Save = artikl;
                    artikl4Save.IsActive = true;
                }
                else
                {
                    artikl4Save = ArtiklEntity.FetchArtikl(adapter, null, artikl.ArtiklId);
                    artikl4Save.UpdateDataFromOtherObject(artikl, null, null);
                }

                isSaved = adapter.SaveEntity(artikl4Save);
            }

            string response = JsonResponse(isSaved);
            return CreateJsonResponse(response);
        }

        #endregion

        #region Partner

        [HttpPost]
        public ActionResult SavePartner(PartnerEntity partner)
        {
            bool isSaved = false;

            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter(User.Identity.Name);
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
                    partner4Save = PartnerEntity.FetchPartner(adapter, null, partner.PartnerId);
                    partner4Save.UpdateDataFromOtherObject(partner, null, null);
                }

                isSaved = adapter.SaveEntity(partner4Save);
            }

            string response = JsonResponse(isSaved);
            return CreateJsonResponse(response);
        }

        [HttpGet]
        public ActionResult GetPartner(long partnerId)
        {
            DataAccessAdapterBase adapter = new DataAccessAdapter();
            using (adapter)
            {
                PartnerEntity partner = PartnerEntity.FetchPartner(adapter, null, partnerId);
                string response = JsonConvert.SerializeObject(partner);

                return CreateJsonResponse(response);
            }
        }

        [HttpGet]
        public ActionResult GetPartnerCollectionForPaging(string sidx, string sord, string filters, int page = 1)
        {
            DataAccessAdapter adapter = new DataAccessAdapter();
            using (adapter)
            {
                RelationPredicateBucket bucket = null;
                if (filters != null)
                {
                    bucket = new RelationPredicateBucket();
                    bucket.PredicateExpression.Add(PredicateHelper.CreatePredicateFromJqGridFilterString(filters, typeof(PartnerFields)));
                }
                bool isSortAscending = PagerBase.IsJqgridSortAscending(sord);

                PartnerPager partnerPager = new PartnerPager();
                partnerPager.LoadData(adapter, bucket, page, this.JqGridPageSize, sidx, isSortAscending);

                return CreateJsonResponse(partnerPager.CreateJqGridRespose());
            }
        }

        [HttpGet]
        public ActionResult GetPartnerCollection()
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter(User.Identity.Name);
            using (adapter)
            {
                IEnumerable<PartnerEntity> partnerCollection = PartnerEntity.FetchPartnerCollection(adapter, null, null).OrderBy(p => p.Naziv);
                string partnerCollectionJson = JsonConvert.SerializeObject(partnerCollection);
                return CreateJsonResponse(partnerCollectionJson);
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
            bool isSaved = false;

            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter(User.Identity.Name);
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

                isSaved = adapter.SaveEntity(pdv4Save);
            }

            string response = JsonResponse(isSaved);
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
                RelationPredicateBucket bucket = new RelationPredicateBucket();
                if (filters != null)
                {
                    bucket.PredicateExpression.Add(PredicateHelper.CreatePredicateFromJqGridFilterString(filters, typeof(PdvFields)));
                }

                bool isSortAscending = PagerBase.IsJqgridSortAscending(sord);

                PdvPager pdvPager = new PdvPager();
                pdvPager.LoadData(adapter, bucket, page, this.JqGridPageSize, sidx, isSortAscending);

                return CreateJsonResponse(pdvPager.CreateJqGridRespose());
            }
        }

        #endregion

        #region Tarifa

        [HttpGet]
        public ActionResult GetTarifa(long tarifaId)
        {
            DataAccessAdapterBase adapter = new DataAccessAdapter();
            using (adapter)
            {
                TarifaEntity tarifa = TarifaEntity.FetchTarifa(adapter, null, tarifaId);

                string response = JsonConvert.SerializeObject(tarifa);
                return CreateJsonResponse(response);
            }
        }

        [HttpGet]
        public ActionResult GetTarifaCollectionForPaging(string sidx, string sord, string filters, int page = 1)
        {
            DataAccessAdapterBase adapter = new DataAccessAdapter();
            using (adapter)
            {
                RelationPredicateBucket bucket = new RelationPredicateBucket();
                if (!string.IsNullOrWhiteSpace(filters))
                {
                    bucket.PredicateExpression.Add(PredicateHelper.CreatePredicateFromJqGridFilterString(filters, typeof(TarifaFields)));
                }

                bool isSortAscending = PagerBase.IsJqgridSortAscending(sord);

                TarifaPager tarifaPager = new TarifaPager();
                tarifaPager.LoadData(adapter, bucket, page, this.JqGridPageSize, sidx, isSortAscending);

                return CreateJsonResponse(tarifaPager.CreateJqGridRespose());
            }
        }

        [HttpPost]
        public ActionResult SaveTarifa(TarifaEntity tarifa)
        {
            bool isSaved = false;

            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter(User.Identity.Name);
            using (adapter)
            {
                TarifaEntity tarifa4Save;

                if (tarifa.TarifaId == 0)
                {
                    tarifa.IsActive = true;
                    tarifa4Save = tarifa;
                }
                else
                {
                    tarifa4Save = TarifaEntity.FetchTarifa(adapter, null, tarifa.TarifaId);
                    tarifa4Save.UpdateDataFromOtherObject(tarifa, null, null);
                }

                isSaved = adapter.SaveEntity(tarifa4Save);
            }

            string response = JsonResponse(isSaved);
            return CreateJsonResponse(response);
        }

        [HttpGet]
        public ActionResult GetTarifaCollection()
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter(User.Identity.Name);
            using (adapter)
            {
                IEnumerable<TarifaEntity> tarifaCollection = TarifaEntity.FetchTarifaCollection(adapter, null, null).OrderBy(t => t.Naziv);
                string tarifaCollectionJson = JsonConvert.SerializeObject(tarifaCollection);
                return CreateJsonResponse(tarifaCollectionJson);
            }
        }

        #endregion

        #region RacunGlava

        [HttpPost]
        public ActionResult SaveRacun(string racunGlavaJson, string racunStavkaCollectionJson)
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter(User.Identity.Name);
            using (adapter)
            {
                RacunGlavaEntity racunGlava4Save;

                JsonSerializerSettings jsonSettings = new JsonSerializerSettings();
                CultureInfo currentCulture = System.Threading.Thread.CurrentThread.CurrentCulture;
                jsonSettings.Culture = currentCulture;

                RacunGlavaEntity racunGlava = JsonConvert.DeserializeObject<RacunGlavaEntity>(racunGlavaJson, jsonSettings);

                if (racunGlava.RacunGlavaId == 0)
                {
                    racunGlava4Save = racunGlava;
                    racunGlava4Save.Godina = ConfigEntity.FetchConfigCollection(adapter, null, null).Single().AktivnaGodina;
                }
                else
                {
                    PrefetchPath2 prefetchPath = new PrefetchPath2(EntityType.RacunGlavaEntity);
                    prefetchPath.Add(RacunGlavaEntity.PrefetchPathRacunStavkaCollection);

                    racunGlava4Save = RacunGlavaEntity.FetchRacunGlava(adapter, prefetchPath, racunGlava.RacunGlavaId);
                    racunGlava4Save.UpdateDataFromOtherObject(racunGlava, null, null);
                }

                racunGlava4Save.TarifaStopa = TarifaEntity.FetchTarifa(adapter, null, racunGlava4Save.TarifaId).Stopa;
                racunGlava4Save.BrojRacuna = -1; // TODO: iz brojača

                adapter.SaveEntity(racunGlava4Save, true, false);

                IEnumerable<RacunStavkaEntity> racunStavkaCollectionToDelete = 
                    racunGlava4Save.RacunStavkaCollection.GetEntitiesNotIncludedInJson(racunStavkaCollectionJson, jsonSettings);

                foreach (RacunStavkaEntity racunStavka in racunStavkaCollectionToDelete)
                {
                    racunGlava4Save.RacunStavkaCollection.Remove(racunStavka);
                    adapter.DeleteEntity(racunStavka);
                }

                racunGlava4Save.RacunStavkaCollection.UpdateEntityCollectionFromJson(racunStavkaCollectionJson, RacunStavkaFields.RacunStavkaId, null, null, jsonSettings);
                foreach (RacunStavkaEntity racunStavka in racunGlava4Save.RacunStavkaCollection)
                {
                    racunStavka.RecalculateData(racunGlava.TarifaStopa);
                    adapter.SaveEntity(racunStavka, false, false);
                }

            } 

            string response = JsonResponse(true);
            return CreateJsonResponse(response);
        }

        [HttpGet]
        public ActionResult GetRacun(long racunGlavaId)
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter(User.Identity.Name);
            using (adapter)
            {
                PrefetchPath2 prefetchPath = new PrefetchPath2(EntityType.RacunGlavaEntity);
                prefetchPath.Add(RacunGlavaEntity.PrefetchPathRacunStavkaCollection).
                    SubPath.Add(RacunStavkaEntity.PrefetchPathArtikl);

                RacunGlavaEntity racunGlava = RacunGlavaEntity.FetchRacunGlava(adapter, prefetchPath, racunGlavaId);

                var toReturn = new
                {
                    RacunGlava = racunGlava,
                    RacunStavkaCollection = racunGlava.RacunStavkaCollection.OrderBy(rs => rs.Pozicija)
                };

                string toReturnJson = JsonConvert.SerializeObject(toReturn);
                return CreateJsonResponse(toReturnJson);
            }
        }

        [HttpGet]
        public ActionResult GetRacunGlavaCollectionForPaging(string sidx, string sord, string filters, int page = 1)
        {
            DataAccessAdapterBase adapter = new DataAccessAdapter();
            using (adapter)
            {
                RelationPredicateBucket bucket = new RelationPredicateBucket();
                if (!string.IsNullOrWhiteSpace(filters))
                { 
                    bucket.PredicateExpression.Add(PredicateHelper.CreatePredicateFromJqGridFilterString(filters, typeof(RacunGlavaFields)));
                }

                bool isSortAscending = PagerBase.IsJqgridSortAscending(sord);

                RacunGlavaPager pager = new RacunGlavaPager();
                pager.LoadData(adapter, bucket, page, this.JqGridPageSize, sidx, isSortAscending);

                return CreateJsonResponse(pager.CreateJqGridRespose());
            }
        }

        #endregion

        #region Status

        [HttpGet]
        public ActionResult GetStatusCollection()
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter(User.Identity.Name);
            using (adapter)
            {
                IEnumerable<StatusRoEntity> statusCollection = StatusRoEntity.FetchStatusRoCollection(adapter, null, null).OrderBy(s => s.Name);
                string statusCollectionJson = JsonConvert.SerializeObject(statusCollection);
                return CreateJsonResponse(statusCollectionJson);
            }
        }

        #endregion
    }
}
