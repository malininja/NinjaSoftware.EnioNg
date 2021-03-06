﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NinjaSoftware.EnioNg.CoolJ.EntityClasses;
using NinjaSoftware.EnioNg.CoolJ.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.Api.CoolJ;
using System.Configuration;
using NinjaSoftware.EnioNg.CoolJ;
using NinjaSoftware.EnioNg.Web.Helpers;
using NinjaSoftware.EnioNg.Web.Models;
using NinjaSoftware.Api.Mvc;
using System.Globalization;
using Newtonsoft.Json;

namespace NinjaSoftware.EnioNg.Web.Controllers
{
    public class JsonServiceController : BaseController
    {
        #region Artikl

        [HttpGet]
        public ActionResult GetArtikl(long artiklId)
        {
            using (DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter())
            {
                ArtiklEntity artikl = ArtiklEntity.FetchArtikl(adapter, null, artiklId);
                return CreateJsonResponse(artikl);
            }
        }

        [HttpGet]
        public ActionResult GetArtiklCollection()
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter(User.Identity.Name);
            using (adapter)
            {
                long firmaId = UserEntity.GetFirmaId(adapter, User.Identity.Name);
                IEnumerable<ArtiklEntity> artiklCollection = ArtiklEntity.FetchActiveArtiklCollection(adapter, firmaId).OrderBy(a => a.Naziv);
                return CreateJsonResponse(artiklCollection);
            }
        }

        [HttpGet]
        public ActionResult GetArtiklCollectionForPaging(string sidx, string sord, string filters, int page = 1)
        {
            using (DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter())
            {
                RelationPredicateBucket bucket = new RelationPredicateBucket();
                long firmaId = UserEntity.GetFirmaId(adapter, User.Identity.Name);
                bucket.PredicateExpression.Add(ArtiklFields.FirmaId == firmaId);

                if (filters != null)
                {
                    bucket.Relations.Add(ArtiklEntity.Relations.PdvEntityUsingPdvId);
					bucket.PredicateExpression.Add(PredicateHelper.CreatePredicateFromJqGridFilterString(filters, typeof(ArtiklFields), DbGenericHelper.GetDbGenericTypeByName));
                }

                bool? isSortAscending = PagerBase.IsJqgridSortAscending(sord);

                PrefetchPath2 prefetchPath = new PrefetchPath2(EntityType.ArtiklEntity);
                prefetchPath.Add(ArtiklEntity.PrefetchPathPdv);

                ArtiklPager artiklPager = new ArtiklPager();
                artiklPager.LoadData(adapter, bucket, page, Common.Config.JqGridPageSize, sidx, isSortAscending);

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
                adapter.StartTransaction(System.Data.IsolationLevel.Serializable, "SaveArtikl");
                
                ArtiklEntity artikl4Save;

                if (artikl.ArtiklId == 0)
                {
                    artikl4Save = artikl;
                    artikl4Save.IsActive = true;
                    artikl4Save.FirmaId = UserEntity.GetFirmaId(adapter, User.Identity.Name);
                }
                else
                {
                    artikl4Save = ArtiklEntity.FetchArtikl(adapter, null, artikl.ArtiklId);
                    artikl4Save.UpdateDataFromOtherObject(artikl, null, null);
                }

                isSaved = adapter.SaveEntity(artikl4Save);
                
                adapter.Commit();
            }

            dynamic response = new { IsSaved = isSaved };
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
                adapter.StartTransaction(System.Data.IsolationLevel.Serializable, "SavePartner");
                
                PartnerEntity partner4Save;

                if (partner.PartnerId == 0)
                {
                    partner.IsActive = true;
                    partner4Save = partner;
                    partner4Save.FirmaId = UserEntity.GetFirmaId(adapter, User.Identity.Name);
                }
                else
                {
                    partner4Save = PartnerEntity.FetchPartner(adapter, null, partner.PartnerId);
                    partner4Save.UpdateDataFromOtherObject(partner, null, null);
                }

                isSaved = adapter.SaveEntity(partner4Save);
                
                adapter.Commit();
            }

            dynamic response = new { IsSaved = isSaved };
            return CreateJsonResponse(response);
        }

        [HttpGet]
        public ActionResult GetPartner(long partnerId)
        {
            using (DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter())
            {
                PartnerEntity partner = PartnerEntity.FetchPartner(adapter, null, partnerId);
                return CreateJsonResponse(partner);
            }
        }

        [HttpGet]
        public ActionResult GetPartnerCollectionForPaging(string sidx, string sord, string filters, int page = 1)
        {
            using (DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter())
            {
                RelationPredicateBucket bucket = new RelationPredicateBucket();
                long firmaId = UserEntity.GetFirmaId(adapter, User.Identity.Name);
                bucket.PredicateExpression.Add(PartnerFields.FirmaId == firmaId);
                
                if (filters != null)
                {
                    bucket.PredicateExpression.Add(PredicateHelper.CreatePredicateFromJqGridFilterString(filters, typeof(PartnerFields), DbGenericHelper.GetDbGenericTypeByName));
                }
                
                if (!string.IsNullOrWhiteSpace(filters))
                {
                    JqGridFilter jqGridFilter = JsonConvert.DeserializeObject<JqGridFilter>(filters); 
                    bool foo;
                    JqGridFilterItem filterItem = jqGridFilter.rules.Where(r => r.field == PartnerFields.IsActive.Name && bool.TryParse(r.data, out foo)).SingleOrDefault();
                    if (filterItem != null)
                    {
                        bool isActive = bool.Parse(filterItem.data);
                        bucket.PredicateExpression.Add(PartnerFields.IsActive == isActive);
                    }
                }
                
                bool? isSortAscending = PagerBase.IsJqgridSortAscending(sord);

                PartnerPager partnerPager = new PartnerPager();
                partnerPager.LoadData(adapter, bucket, page, Common.Config.JqGridPageSize, sidx, isSortAscending);

                return CreateJsonResponse(partnerPager.CreateJqGridRespose());
            }
        }

        [HttpGet]
        public ActionResult GetPartnerCollection()
        {
            using (DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter())
            {
                long firmaId = UserEntity.GetFirmaId(adapter, User.Identity.Name);
                IEnumerable<PartnerEntity> partnerCollection = PartnerEntity.FetchActivePartnerCollection(adapter, firmaId).OrderBy(p => p.Naziv);
                return CreateJsonResponse(partnerCollection);
            }
        }

        #endregion

        #region Pdv

        [HttpGet]
        public ActionResult GetPdv(long pdvId)
        {
            using (DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter())
            {
                PdvEntity pdv = PdvEntity.FetchPdv(adapter, null, pdvId);
                return CreateJsonResponse(pdv);
            }
        }

        [HttpPost]
        public ActionResult SavePdv(PdvEntity pdv)
        {
            bool isSaved = false;

            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter(User.Identity.Name);
            using (adapter)
            {
                adapter.StartTransaction(System.Data.IsolationLevel.Serializable, "SavePdv");
                
                PdvEntity pdv4Save;

                if (pdv.PdvId == 0)
                {
                    pdv4Save = pdv;
                    pdv4Save.FirmaId = UserEntity.GetFirmaId(adapter, User.Identity.Name);
                }
                else
                {
                    pdv4Save = PdvEntity.FetchPdv(adapter, null, pdv.PdvId);
                    pdv4Save.UpdateDataFromOtherObject(pdv, null, null);
                }

                isSaved = adapter.SaveEntity(pdv4Save);
                
                adapter.Commit();
            }

            dynamic response = new { IsSaved = isSaved };
            return CreateJsonResponse(response);
        }

        [HttpGet]
        public ActionResult GetPdvCollection()
        {
            using (DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter())
            {
                long firmaId = UserEntity.GetFirmaId(adapter, User.Identity.Name);
                RelationPredicateBucket bucket = new RelationPredicateBucket(PdvFields.FirmaId == firmaId);
                IEnumerable<PdvEntity> pdvCollection = PdvEntity.FetchPdvCollection(adapter, bucket, null);
                return CreateJsonResponse(pdvCollection);
            }
        }

        [HttpGet]
        public ActionResult GetPdvCollectionForPaging(string sidx, string sord, string filters, int page = 1)
        {
            using (DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter())
            {
                RelationPredicateBucket bucket = new RelationPredicateBucket();
                long firmaId = UserEntity.GetFirmaId(adapter, User.Identity.Name);
                bucket.PredicateExpression.Add(PdvFields.FirmaId == firmaId);

                if (filters != null)
                {
                    bucket.PredicateExpression.Add(PredicateHelper.CreatePredicateFromJqGridFilterString(filters, typeof(PdvFields), DbGenericHelper.GetDbGenericTypeByName));
                }

                bool? isSortAscending = PagerBase.IsJqgridSortAscending(sord);

                PdvPager pdvPager = new PdvPager();
                pdvPager.LoadData(adapter, bucket, page, Common.Config.JqGridPageSize, sidx, isSortAscending);

                return CreateJsonResponse(pdvPager.CreateJqGridRespose());
            }
        }

        #endregion

        #region Tarifa

        [HttpGet]
        public ActionResult GetTarifa(long tarifaId)
        {
            using (DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter())
            {
                TarifaEntity tarifa = TarifaEntity.FetchTarifa(adapter, null, tarifaId);
                return CreateJsonResponse(tarifa);
            }
        }

        [HttpGet]
        public ActionResult GetTarifaCollectionForPaging(string sidx, string sord, string filters, int page = 1)
        {
            using (DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter())
            {
                RelationPredicateBucket bucket = new RelationPredicateBucket();
                long firmaId = UserEntity.GetFirmaId(adapter, User.Identity.Name);
                bucket.PredicateExpression.Add(TarifaFields.FirmaId == firmaId);

                if (!string.IsNullOrWhiteSpace(filters))
                {
                    bucket.PredicateExpression.Add(PredicateHelper.CreatePredicateFromJqGridFilterString(filters, typeof(TarifaFields), DbGenericHelper.GetDbGenericTypeByName));
                }

                bool? isSortAscending = PagerBase.IsJqgridSortAscending(sord);

                TarifaPager tarifaPager = new TarifaPager();
                tarifaPager.LoadData(adapter, bucket, page, Common.Config.JqGridPageSize, sidx, isSortAscending);

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
                adapter.StartTransaction(System.Data.IsolationLevel.Serializable, "SaveTarifa");
                
                TarifaEntity tarifa4Save;

                if (tarifa.TarifaId == 0)
                {
                    tarifa.IsActive = true;
                    tarifa4Save = tarifa;
                    tarifa4Save.FirmaId = UserEntity.GetFirmaId(adapter, User.Identity.Name);
                }
                else
                {
                    tarifa4Save = TarifaEntity.FetchTarifa(adapter, null, tarifa.TarifaId);
                    tarifa4Save.UpdateDataFromOtherObject(tarifa, null, null);
                }

                isSaved = adapter.SaveEntity(tarifa4Save);
                
                adapter.Commit();
            }

            dynamic response = new { IsSaved = isSaved };
            return CreateJsonResponse(response);
        }

        [HttpGet]
        public ActionResult GetTarifaCollection()
        {
            using (DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter())
            {
                long firmaId = UserEntity.GetFirmaId(adapter, User.Identity.Name);
                IEnumerable<TarifaEntity> tarifaCollection = TarifaEntity.FetchActiveTarifaCollection(adapter, firmaId).OrderBy(t => t.Naziv);
                return CreateJsonResponse(tarifaCollection);
            }
        }

        #endregion

        #region RacunGlava

        [HttpPost]
        public ActionResult SaveRacun(string racunGlavaJson, string racunStavkaCollectionJson)
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter(User.Identity.Name);
            RacunGlavaEntity racunGlava4Save;
            bool isSaved = false;
			
            using (adapter)
            {
                adapter.StartTransaction(System.Data.IsolationLevel.Serializable, "SaveRacun");
                
                JsonSerializerSettings jsonSettings = new JsonSerializerSettings();
                CultureInfo currentCulture = System.Threading.Thread.CurrentThread.CurrentCulture;
                jsonSettings.Culture = currentCulture;

                RacunGlavaEntity racunGlava = JsonConvert.DeserializeObject<RacunGlavaEntity>(racunGlavaJson, jsonSettings);

                if (racunGlava.RacunGlavaId == 0)
                {
                    long firmaId = UserEntity.GetFirmaId(adapter, User.Identity.Name);

                    racunGlava4Save = racunGlava;
                    racunGlava4Save.Godina = ConfigEntity.GetInstance(adapter, firmaId).AktivnaGodina;
                    racunGlava4Save.BrojRacuna = BrojacEntity.GetNextNumber(adapter, firmaId, BrojacEnum.Racun, racunGlava4Save.Godina);
                    racunGlava4Save.FirmaId = firmaId;
                }
                else
                {
                    PrefetchPath2 prefetchPath = new PrefetchPath2(EntityType.RacunGlavaEntity);
                    prefetchPath.Add(RacunGlavaEntity.PrefetchPathRacunStavkaCollection);

                    racunGlava4Save = RacunGlavaEntity.FetchRacunGlava(adapter, prefetchPath, racunGlava.RacunGlavaId);
                    racunGlava4Save.UpdateDataFromOtherObject(racunGlava, null, null);
                }

                racunGlava4Save.TarifaStopa = TarifaEntity.FetchTarifa(adapter, null, racunGlava4Save.TarifaId).Stopa;

                if (racunGlava4Save.Godina != racunGlava4Save.Datum.Year)
                {
                    // TODO: create mechanism for pushing errors to client. Currently check is on client. Remove client check after push error mechanism is implemented.
                }
                else
                {
                    isSaved = adapter.SaveEntity(racunGlava4Save, true, false);
                }

                if (isSaved)
                {
                    IEnumerable<RacunStavkaEntity> racunStavkaCollectionToDelete = 
                    racunGlava4Save.RacunStavkaCollection.GetEntitiesNotIncludedInJson(racunStavkaCollectionJson, jsonSettings);

                    foreach (RacunStavkaEntity racunStavka in racunStavkaCollectionToDelete)
                    {
                        if (isSaved)
                        {
                            racunGlava4Save.RacunStavkaCollection.Remove(racunStavka);
                            isSaved = adapter.DeleteEntity(racunStavka);
                        }
                    }

                    racunGlava4Save.RacunStavkaCollection.UpdateEntityCollectionFromJson(racunStavkaCollectionJson, RacunStavkaFields.RacunStavkaId, null, null, jsonSettings);
                    foreach (RacunStavkaEntity racunStavka in racunGlava4Save.RacunStavkaCollection)
                    {
                        if (isSaved)
                        {
                            racunStavka.RecalculateData(racunGlava.TarifaStopa);
                            isSaved = adapter.SaveEntity(racunStavka, false, false);
                        }
                    }
                }
                
                adapter.Commit();
            } 
		           
            dynamic response = new 
            {
                IsSaved = isSaved,
                RacunGlavaId = racunGlava4Save.RacunGlavaId
            };
            
            return CreateJsonResponse(response);
        }

        [HttpGet]
        public ActionResult GetRacun(long racunGlavaId)
        {
            using (DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter())
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

                return CreateJsonResponse(toReturn);
            }
        }

        [HttpGet]
        public ActionResult GetRacunGlavaCollectionForPaging(string sidx, string sord, string filters, int page = 1)
        {
            using (DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter())
            {
                long firmaId = UserEntity.GetFirmaId(adapter, User.Identity.Name);

                short godina = ConfigEntity.GetInstance(adapter, firmaId).AktivnaGodina;
                RelationPredicateBucket bucket = RacunGlavaPager.CreateBucket(godina, filters);

                bucket.PredicateExpression.Add(RacunGlavaFields.FirmaId == firmaId);

                bucket.Relations.Add(RacunGlavaEntity.Relations.PartnerEntityUsingPartnerId);

                bool? isSortAscending = PagerBase.IsJqgridSortAscending(sord);

                RacunGlavaPager pager = new RacunGlavaPager();
                pager.LoadData(adapter, bucket, page, Common.Config.JqGridPageSize, sidx, isSortAscending);

                return CreateJsonResponse(pager.CreateJqGridRespose());
            }
        }

        #endregion

        #region Status

        [HttpGet]
        public ActionResult GetStatusCollection()
        {
            using (DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter())
            {
                IEnumerable<StatusRoEntity> statusCollection = StatusRoEntity.FetchStatusRoCollection(adapter, null, null).OrderBy(s => s.Name);
                return CreateJsonResponse(statusCollection);
            }
        }

        #endregion

        #region Config

        [HttpGet]
        public ActionResult GetConfig()
        {
            using (DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter())
            {
                long firmaId = UserEntity.GetFirmaId(adapter, User.Identity.Name);
                RelationPredicateBucket bucket = new RelationPredicateBucket(ConfigFields.FirmaId == firmaId);

                ConfigEntity config = ConfigEntity.FetchConfigCollection(adapter, bucket, null).SingleOrDefault();
                return CreateJsonResponse(config);
            }
        }

        [HttpPost]
        public ActionResult SaveConfig(ConfigEntity config)
        {
            bool isSaved = false;

            if (config.AktivnaGodina >= 2005 && config.AktivnaGodina <= 2025)
            {
                DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter(User.Identity.Name);
                using (adapter)
                {
                    adapter.StartTransaction(System.Data.IsolationLevel.Serializable, "SaveConfig");

                    ConfigEntity config4Save;
                    if (config.ConfigId == 0)
                    {
                        config4Save = config;
                        config4Save.FirmaId = UserEntity.GetFirmaId(adapter, User.Identity.Name);
                    }
                    else
                    {
                        config4Save = ConfigEntity.FetchConfig(adapter, null, config.ConfigId);
                        config4Save.UpdateDataFromOtherObject(config, null, null);
                    }

                    isSaved = adapter.SaveEntity(config4Save);
                    
                    adapter.Commit();
                }
            }

            dynamic response = new { IsSaved = isSaved };
            return CreateJsonResponse(response);
        }

        #endregion
    }
}
