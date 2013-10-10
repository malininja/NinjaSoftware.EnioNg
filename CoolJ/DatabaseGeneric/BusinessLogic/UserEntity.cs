using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.EnioNg.CoolJ.HelperClasses;

namespace NinjaSoftware.EnioNg.CoolJ.EntityClasses
{
    public partial class UserEntity
    {
        public static UserEntity FetchUser(DataAccessAdapterBase adapter, string userName)
        {
            RelationPredicateBucket bucket = new RelationPredicateBucket(UserFields.Username == userName);
            IEnumerable<UserEntity> userCollection = UserEntity.FetchUserCollection(adapter, bucket, null);
            return userCollection.SingleOrDefault();
        }
    }
}
