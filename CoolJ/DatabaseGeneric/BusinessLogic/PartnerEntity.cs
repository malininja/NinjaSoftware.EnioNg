using System;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.EnioNg.CoolJ.HelperClasses;
using System.Linq;

namespace NinjaSoftware.EnioNg.CoolJ.EntityClasses
{
    public partial class PartnerEntity
    {
        public static EntityCollection<PartnerEntity> FetchActivePartnerCollection(DataAccessAdapterBase adapter, long firmaId)
        {
            RelationPredicateBucket bucket = new RelationPredicateBucket(PartnerFields.IsActive == true);
            bucket.PredicateExpression.Add(PartnerFields.FirmaId == firmaId);

            return FetchPartnerCollection(adapter, bucket, null);
        }
    }
}
