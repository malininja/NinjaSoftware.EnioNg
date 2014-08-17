using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjaSoftware.Api.Mvc;
using NinjaSoftware.EnioNg.CoolJ.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.EnioNg.CoolJ.EntityClasses;

namespace NinjaSoftware.EnioNg.Web.Models
{
    public class PartnerPager: PagerBase
    {
        public override string DefaultSortField
        {
            get { return PartnerFields.Naziv.Name; }
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
            this.DataSource = PartnerEntity.FetchPartnerCollectionForPaging(adapter, bucket, null, pageNumber, pageSize, sortField, isSortAscending);
            this.NoOfRecords = PartnerEntity.GetNumberOfEntities(adapter, bucket);
        }
    }
}