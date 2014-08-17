using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjaSoftware.EnioNg.CoolJ.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.Api.Mvc;
using NinjaSoftware.EnioNg.CoolJ.EntityClasses;

namespace NinjaSoftware.EnioNg.Web.Models
{
    public class PdvPager: PagerBase
    {
        public override string DefaultSortField
        {
            get { return PdvFields.Naziv.Name; }
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
            this.DataSource = PdvEntity.FetchPdvCollectionForPaging(adapter, bucket, null, pageNumber, pageSize, sortField, isSortAscending);
            this.NoOfRecords = PdvEntity.GetNumberOfEntities(adapter, bucket);
        }
    }
}