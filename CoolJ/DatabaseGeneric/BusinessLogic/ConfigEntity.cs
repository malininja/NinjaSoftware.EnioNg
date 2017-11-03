using System;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System.Linq;
using NinjaSoftware.EnioNg.CoolJ.HelperClasses;

namespace NinjaSoftware.EnioNg.CoolJ.EntityClasses
{
    public partial class ConfigEntity
    {
        public static ConfigEntity GetInstance(DataAccessAdapterBase adapter, long firmaId)
        {
            RelationPredicateBucket bucket = new RelationPredicateBucket(ConfigFields.FirmaId == firmaId);
            return ConfigEntity.FetchConfigCollection(adapter, bucket, null).Single();
        }

    }
}

