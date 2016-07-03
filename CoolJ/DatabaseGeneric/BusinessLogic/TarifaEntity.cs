using System;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.EnioNg.CoolJ.HelperClasses;
using System.Linq;

namespace NinjaSoftware.EnioNg.CoolJ.EntityClasses
{
    public partial class TarifaEntity
    {
        public static EntityCollection<TarifaEntity> FetchActiveTarifaCollection(DataAccessAdapterBase adapter)
        {
            RelationPredicateBucket bucket = new RelationPredicateBucket(TarifaFields.IsActive == true);
            return FetchTarifaCollection(adapter, bucket, null);
        }
    }
}
