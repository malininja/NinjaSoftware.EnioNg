using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjaSoftware.Api.Mvc;
using NinjaSoftware.EnioNg.CoolJ.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.EnioNg.CoolJ;
using NinjaSoftware.EnioNg.CoolJ.EntityClasses;

namespace NinjaSoftware.EnioNg.Web.Models
{
    public class ArtiklPager : PagerBase
    {
        public override string DefaultSortField
        {
            get { return ArtiklFields.Naziv.Name; }
        }

        public override bool IsDefaultSortDirectionAscending
        {
            get { return true; }
        }

        protected override void SetDataSource(DataAccessAdapterBase adapter,
            RelationPredicateBucket bucket,
            int pageNumber,
            int pageSize,
            string sortField,
            bool isSortAscending)
        {
            PrefetchPath2 prefetchPath = new PrefetchPath2(EntityType.ArtiklEntity);
            prefetchPath.Add(ArtiklEntity.PrefetchPathPdv);

            this.DataSource = ArtiklEntity.FetchArtiklCollectionForPaging(adapter, bucket, prefetchPath, pageNumber, pageSize, sortField, isSortAscending);
            this.NoOfRecords = ArtiklEntity.GetNumberOfEntities(adapter, bucket);
        }
    }
}