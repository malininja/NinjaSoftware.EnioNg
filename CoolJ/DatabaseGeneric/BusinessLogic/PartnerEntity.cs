using System;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.EnioNg.CoolJ.HelperClasses;
using System.Linq;

namespace NinjaSoftware.EnioNg.CoolJ.EntityClasses
{
    public partial class PartnerEntity
    {
        public static EntityCollection<PartnerEntity> FetchActivePartnerCollection(DataAccessAdapterBase adapter)
        {
            RelationPredicateBucket bucket = new RelationPredicateBucket(PartnerFields.IsActive == true);
            return FetchPartnerCollection(adapter, bucket, null);
        }
    }
}
