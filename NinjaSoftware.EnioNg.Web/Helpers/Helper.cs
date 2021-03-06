﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.EnioNg.CoolJ.EntityClasses;
using NinjaSoftware.Api.CoolJ;

namespace NinjaSoftware.EnioNg.Web.Helpers
{
    public class Helper
    {
        /// <summary>
        /// Readonly data access adapter.
        /// </summary>
        public static DataAccessAdapterBase GetDataAccessAdapter()
        {
            return new CoolJ.SqlServer.DatabaseSpecific.DataAccessAdapter();
        }

        /// <summary>
        /// Read and write data access adapter
        /// </summary>
        /// <param name="userName">Used for audit info log.</param>
        public static DataAccessAdapterBase GetDataAccessAdapter(string userName)
        {
            CoolJ.SqlServer.DatabaseSpecific.DataAccessAdapter adapter = new CoolJ.SqlServer.DatabaseSpecific.DataAccessAdapter();

            UserEntity user = UserEntity.FetchUser(adapter, userName);

            if (user != null)
            {
                ((INsDataAccessAdapter)adapter).UserId = user.UserId;
            }

            return adapter;
        }
    }
}