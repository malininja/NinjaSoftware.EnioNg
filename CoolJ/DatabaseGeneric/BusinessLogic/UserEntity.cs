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
            PrefetchPath2 prefetchPath = new PrefetchPath2(EntityType.UserEntity);
            prefetchPath.Add(UserEntity.PrefetchPathRole);
            IEnumerable<UserEntity> userCollection = UserEntity.FetchUserCollection(adapter, bucket, prefetchPath);
            return userCollection.SingleOrDefault();
        }
        
        public static bool ChangePassword(DataAccessAdapterBase adapter, string userName, string oldPassword, string newPassword)
        {
            UserEntity user = FetchUser(adapter, userName);
            
            bool isOldCorrect = Common.Cryptography.ValidatePassword(user.Password, oldPassword);
            
            if (isOldCorrect)
            {
                user.Password = Common.Cryptography.CreatePasswordPackage(newPassword);
                
                return adapter.SaveEntity(user);
            }
            
            return false;
        }

        public static long GetFirmaId(DataAccessAdapterBase adapter, string username)
        {
            RelationPredicateBucket bucket = new RelationPredicateBucket(UserFields.Username == username);
            IEnumerable<UserEntity> userCollection = UserEntity.FetchUserCollection(adapter, bucket, null);

            return userCollection.Single().FirmaId;
        }
    }
}
