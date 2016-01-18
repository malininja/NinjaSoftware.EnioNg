using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjaSoftware.Api.Mvc;
using NinjaSoftware.EnioNg.CoolJ.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.EnioNg.CoolJ.EntityClasses;
using NinjaSoftware.EnioNg.CoolJ;

namespace NinjaSoftware.EnioNg.Web.Models
{
    public class RacunGlavaPager: PagerBase
    {
        public override string DefaultSortField
        {
            get { return RacunGlavaFields.Datum.Name; }
        }

        public override bool IsDefaultSortDirectionAscending
        {
            get { return false; }
        }

        protected override void SetDataSource(DataAccessAdapterBase adapter,
            RelationPredicateBucket bucket, 
            int pageNumber, 
            int pageSize, 
            string sortField, 
            bool isSortAscending)
        {
            PrefetchPath2 prefetchPath = new PrefetchPath2(EntityType.RacunGlavaEntity);
            prefetchPath.Add(RacunGlavaEntity.PrefetchPathPartner);
            prefetchPath.Add(RacunGlavaEntity.PrefetchPathStatus);
            prefetchPath.Add(RacunGlavaEntity.PrefetchPathRacunStavkaCollection);

            this.DataSource = RacunGlavaEntity.FetchRacunGlavaCollectionForPaging(adapter, bucket, prefetchPath, pageNumber, pageSize, sortField, isSortAscending);
            this.NoOfRecords = RacunGlavaEntity.GetNumberOfEntities(adapter, bucket);
        }
    }
}