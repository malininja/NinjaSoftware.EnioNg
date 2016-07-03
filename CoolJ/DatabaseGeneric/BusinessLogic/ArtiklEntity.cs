using System;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.EnioNg.CoolJ.HelperClasses;
using System.Linq;

namespace NinjaSoftware.EnioNg.CoolJ.EntityClasses
{
    public partial class ArtiklEntity
    {
        public static EntityCollection<ArtiklEntity> FetchActiveArtiklCollection(DataAccessAdapterBase adapter)
        {
            RelationPredicateBucket bucket = new RelationPredicateBucket(ArtiklFields.IsActive == true);
            return FetchArtiklCollection(adapter, bucket, null);
        }
    }
}

