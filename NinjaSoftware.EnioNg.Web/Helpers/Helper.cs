using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.EnioNg.CoolJ.DatabaseSpecific;
using NinjaSoftware.EnioNg.CoolJ.EntityClasses;
using NinjaSoftware.Api.CoolJ;

namespace NinjaSoftware.EnioNg.Web.Helpers
{
    public class Helper
    {
        public static DataAccessAdapterBase GetDataAccessAdapter(string userName)
        {
            DataAccessAdapter adapter = new DataAccessAdapter();

            UserEntity user = UserEntity.FetchUser(adapter, userName);

            if (user == null)
            {
#if DEBUG
                ((INsDataAccessAdapter)adapter).UserId = -1;
#else
                ((INsDataAccessAdapter)adapter).UserId = null;
#endif
            }
            else
            {
                ((INsDataAccessAdapter)adapter).UserId = user.UserId;
            }

            return adapter;
        }
    }
}