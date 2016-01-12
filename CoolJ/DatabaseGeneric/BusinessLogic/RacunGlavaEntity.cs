using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NinjaSoftware.EnioNg.CoolJ.EntityClasses
{
    public partial class RacunGlavaEntity
    {
        public void RecalculateData(DataAccessAdapterBase adapter)
        {
            if (this.RacunStavkaCollection != null)
            {
                TarifaEntity tarifa = TarifaEntity.FetchTarifa(adapter, null, this.TarifaId);

                foreach (RacunStavkaEntity racunStavka in this.RacunStavkaCollection)
                {
                    racunStavka.RecalculateData(tarifa.Stopa);
                }
            }
        }

        public static RacunGlavaEntity FetchRacunGlavaForReport(DataAccessAdapterBase adapter, long racunGlavaId)
        {
            PrefetchPath2 prefetchPath = new PrefetchPath2(EntityType.RacunGlavaEntity);
            prefetchPath.Add(RacunGlavaEntity.PrefetchPathRacunStavkaCollection);
            prefetchPath.Add(RacunGlavaEntity.PrefetchPathPartner);
            prefetchPath.Add(RacunGlavaEntity.PrefetchPathStatus);

            return FetchRacunGlava(adapter, prefetchPath, racunGlavaId);
        }
    }
}
