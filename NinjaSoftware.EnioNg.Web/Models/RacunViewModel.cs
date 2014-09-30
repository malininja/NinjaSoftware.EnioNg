using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjaSoftware.EnioNg.CoolJ.EntityClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.EnioNg.CoolJ;
using NinjaSoftware.Api.Mvc;
using NinjaSoftware.EnioNg.CoolJ.HelperClasses;
using Newtonsoft.Json;
using NinjaSoftware.Api.CoolJ;

namespace NinjaSoftware.EnioNg.Web.Models
{
    public class RacunViewModel: IViewModel
    {
        #region Properties

        public RacunGlavaEntity RacunGlava { get; set; }
        public List<RacunStavkaEntity> RacunStavkaListToDelete { get; set; }

        #endregion

        #region Constructors

        public RacunViewModel() { }

        public RacunViewModel(DataAccessAdapterBase adapter, long? racunGlavaId)
        {
            if (racunGlavaId.HasValue && racunGlavaId.Value > 0)
            {
                PrefetchPath2 prefetchPath = new PrefetchPath2(EntityType.RacunGlavaEntity);
                SortExpression sort = new SortExpression(RacunStavkaFields.Pozicija | SortOperator.Ascending);
                prefetchPath.Add(RacunGlavaEntity.PrefetchPathRacunStavkaCollection, 0, null, null, sort).
                    SubPath.Add(RacunStavkaEntity.PrefetchPathArtikl);

                this.RacunGlava = RacunGlavaEntity.FetchRacunGlava(adapter, prefetchPath, racunGlavaId.Value);
            }
            else
            {
                this.RacunGlava = new RacunGlavaEntity();
                this.RacunGlava.Datum = DateTime.Now;
            }
        }

        #endregion

        #region Public methods

        public void LoadViewSpecificData(DataAccessAdapterBase adapter)
        {
            //throw new NotImplementedException();
        }

        public void Save(DataAccessAdapterBase adapter)
        {
            foreach (RacunStavkaEntity racunStavka in this.RacunStavkaListToDelete)
            {
                adapter.DeleteEntity(racunStavka);
            }

            foreach (RacunStavkaEntity racunStavka in this.RacunGlava.RacunStavkaCollection)
            {
                if (racunStavka.IsDirty)
                {
                    this.RacunGlava.IsDirty = true;
                    adapter.SaveEntity(racunStavka, false, false);
                }
            }

            adapter.SaveEntity(this.RacunGlava, false, false);
        }

        public void UpdateModelFromJson(DataAccessAdapterBase adapter, string racunGlavaJson, string racunStavkaCollectionJson)
        {
            JsonSerializerSettings jsonSettings = new JsonSerializerSettings();
            jsonSettings.Culture = System.Threading.Thread.CurrentThread.CurrentCulture;

            RacunGlavaEntity racunGlavaDeserialized = JsonConvert.DeserializeObject<RacunGlavaEntity>(racunGlavaJson, jsonSettings);
            this.RacunGlava.UpdateDataFromOtherObject(racunGlavaDeserialized, null, null);

            this.RacunStavkaListToDelete = this.RacunGlava.RacunStavkaCollection.GetEntitiesNotIncludedInJson(racunStavkaCollectionJson, jsonSettings);
            foreach (RacunStavkaEntity racunStavka in this.RacunGlava.RacunStavkaCollection)
            {
                this.RacunGlava.RacunStavkaCollection.Remove(racunStavka);
            }

            this.RacunGlava.RacunStavkaCollection.UpdateEntityCollectionFromJson(racunStavkaCollectionJson, RacunStavkaFields.RacunStavkaId, null, null, jsonSettings);

            this.RacunGlava.RecalculateData(adapter);
        }

        #endregion
    }
}