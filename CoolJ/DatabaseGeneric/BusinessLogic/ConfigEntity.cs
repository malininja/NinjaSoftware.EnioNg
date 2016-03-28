using System;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System.Linq;

namespace NinjaSoftware.EnioNg.CoolJ.EntityClasses
{
    public partial class ConfigEntity
    {
        public static ConfigEntity GetInstance(DataAccessAdapterBase adapter)
        {
            return ConfigEntity.FetchConfigCollection(adapter, null, null).Single();
        }

    }
}

