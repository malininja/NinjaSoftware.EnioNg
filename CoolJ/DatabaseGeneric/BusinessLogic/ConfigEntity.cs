using System;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System.Linq;

namespace NinjaSoftware.EnioNg.CoolJ.EntityClasses
{
    public partial class ConfigEntity
    {
        private static ConfigEntity _instance = null;
        public static ConfigEntity GetInstance(DataAccessAdapterBase adapter)
        {
            if (_instance == null)
            {
                _instance = ConfigEntity.FetchConfigCollection(adapter, null, null).Single();
            }

            return _instance;
        }

    }
}

