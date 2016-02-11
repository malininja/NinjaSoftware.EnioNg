using System;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.EnioNg.CoolJ.EntityClasses;

namespace NinjaSoftware.EnioNg.Web.Helpers
{
    public class RoleProvider: System.Web.Security.RoleProvider
    {
        #region implemented abstract members of RoleProvider

        public override void AddUsersToRoles(string[] usernames, string[] rolenames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string rolename)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string rolename, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            using (DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter())
            {
                var user = UserEntity.FetchUser(adapter, username);
                return new string[] { user.Role.Name };
            }
        }

        public override string[] GetUsersInRole(string rolename)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string rolename)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] rolenames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string rolename)
        {
            throw new NotImplementedException();
        }

        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion


    }
}

