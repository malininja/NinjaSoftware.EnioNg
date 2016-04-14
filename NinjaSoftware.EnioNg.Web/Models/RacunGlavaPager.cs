using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjaSoftware.Api.Mvc;
using NinjaSoftware.EnioNg.CoolJ.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.EnioNg.CoolJ.EntityClasses;
using NinjaSoftware.EnioNg.CoolJ;
using NinjaSoftware.Api.CoolJ;
using Newtonsoft.Json;

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

        public static RelationPredicateBucket CreateBucket(short godina, string jqGridFilters)
        {
            RelationPredicateBucket bucket = new RelationPredicateBucket(RacunGlavaFields.Godina == godina);
            if (!string.IsNullOrWhiteSpace(jqGridFilters))
            {
                bucket.PredicateExpression.Add(PredicateHelper.CreatePredicateFromJqGridFilterString(jqGridFilters, typeof(RacunGlavaFields), DbGenericHelper.GetDbGenericTypeByName));

                JqGridFilter jqGrid = JsonConvert.DeserializeObject<JqGridFilter>(jqGridFilters);
                if (jqGrid != null &&
                    jqGrid.rules != null)
                {
                    DateTime? datumOd = null;
                    DateTime? datumDo = null;
                    foreach (JqGridFilterItem item in jqGrid.rules.Where(r => r.field == "Datum"))
                    {
                        if (item.op == "ge")
                        {
                            datumOd = DateTime.Parse(item.data).Date;
                        }

                        if (item.op == "le")
                        {
                            datumDo = DateTime.Parse(item.data).Date.AddDays(1);
                        }

                        bucket.PredicateExpression.Add(PredicateHelper.FilterValidEntities(datumOd, datumDo, RacunGlavaFields.Datum));
                    }
                }
            }

            return bucket;
        }
    }
}