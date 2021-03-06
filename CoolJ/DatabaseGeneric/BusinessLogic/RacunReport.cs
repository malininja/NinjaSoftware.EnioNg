﻿using NinjaSoftware.EnioNg.CoolJ.EntityClasses;
using NinjaSoftware.EnioNg.CoolJ.Enums;
using NinjaSoftware.EnioNg.CoolJ.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NinjaSoftware.EnioNg.CoolJ.DatabaseGeneric.BusinessLogic
{
    public class RacunReport
    {
        public RacunGlavaEntity RacunGlava { get; set; }
        public IEnumerable<RacunStavkaEntity> RacunStavkaCollection { get; set; }
        public ConfigEntity Config { get; set; }
        public string Valuta { get; set; }
        public decimal Netto { get; set; }
        public decimal TarifaIznos { get; set; }
        public decimal PdvIznos { get; set; }
        public decimal Ukupno { get; set; }
        public decimal UkupnoBezPdv { get { return this.Ukupno - this.PdvIznos; } }
        public decimal PdvPosto { get; set; }

        public RacunReport(DataAccessAdapterBase adapter, long racunGlavaId)
        {
            RacunGlavaEntity racunGlava = RacunGlavaEntity.FetchRacunGlavaForReport(adapter, racunGlavaId);

            RelationPredicateBucket configBucket = new RelationPredicateBucket(ConfigFields.FirmaId == racunGlava.FirmaId);
            ConfigEntity config = ConfigEntity.FetchConfigCollection(adapter, configBucket, null).Single();

            CreateObject(racunGlava, config);
        }

        public RacunReport(RacunGlavaEntity racunGlava, ConfigEntity config)
        {
            CreateObject(racunGlava, config);
        }

        private void CreateObject(RacunGlavaEntity racunGlava, ConfigEntity config)
        {
            this.RacunGlava = racunGlava;
            this.Config = config;

            this.RacunStavkaCollection = this.RacunGlava.RacunStavkaCollection;

            switch ((StatusEnum)this.RacunGlava.StatusId)
            {
                case StatusEnum.Unpaid:
                    this.Valuta = "Valuta: " + Convert.ToDateTime(this.RacunGlava.Datum).AddDays(this.RacunGlava.Valuta).ToShortDateString();
                    break;
                default:
                    this.Valuta = this.RacunGlava.Status.Name;
                    break;
            }

            if (this.RacunStavkaCollection.Count() > 0)
            {
                this.PdvPosto = this.RacunStavkaCollection.First().PdvPosto;
            }

            foreach (RacunStavkaEntity racunStavka in this.RacunStavkaCollection)
            {
                this.Netto += racunStavka.Netto;
                this.TarifaIznos += racunStavka.TarifaIznos;
                this.PdvIznos += racunStavka.PdvIznos;
                this.Ukupno += racunStavka.Iznos;
            }
        }

        public static IEnumerable<RacunReport> GetRacunReportCollection(DataAccessAdapterBase adapter, RelationPredicateBucket bucket, long firmaId)
        {
            IEnumerable<RacunGlavaEntity> racunGlavaCollection = RacunGlavaEntity.FetchRacunGlavaCollectionForReport(adapter, bucket);

            RelationPredicateBucket configBucket = new RelationPredicateBucket(ConfigFields.FirmaId == firmaId);
            ConfigEntity config = ConfigEntity.FetchConfigCollection(adapter, configBucket, null).Single();

            foreach (RacunGlavaEntity racunGlava in racunGlavaCollection)
            {
                yield return new RacunReport(racunGlava, config);
            }
        }
    }
}
