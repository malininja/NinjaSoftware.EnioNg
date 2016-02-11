using System;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.EnioNg.CoolJ.EntityClasses;
using System.Web.Security;

namespace NinjaSoftware.EnioNg.Web.Helpers
{
    public class MembershipProvider: System.Web.Security.MembershipProvider
    {
        #region implemented abstract members of MembershipProvider
        public override bool ChangePassword(string name, string oldPwd, string newPwd)
        {
            using (DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter(name))
            {
                return CoolJ.EntityClasses.UserEntity.ChangePassword(adapter, name, oldPwd, newPwd);
            }
        }
        public override bool ChangePasswordQuestionAndAnswer(string name, string password, string newPwdQuestion, string newPwdAnswer)
        {
            throw new NotImplementedException();
        }
        public override MembershipUser CreateUser(string username, string password, string email, string pwdQuestion, string pwdAnswer, bool isApproved, object providerUserKey, out MembershipCreateStatus status)
        {
            throw new NotImplementedException();
        }
        public override bool DeleteUser(string name, bool deleteAllRelatedData)
        {
            throw new NotImplementedException();
        }
        public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }
        public override MembershipUserCollection FindUsersByName(string nameToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }
        public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }
        public override int GetNumberOfUsersOnline()
        {
            throw new NotImplementedException();
        }
        public override string GetPassword(string name, string answer)
        {
            throw new NotImplementedException();
        }
        public override MembershipUser GetUser(string name, bool userIsOnline)
        {
            UserEntity user;
            
            using (DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter())
            {
                user = UserEntity.FetchUser(adapter, name);
            }
            
            return new MembershipUser(this.Name,
                user.Username,
                user.UserId,
                string.Empty,
                string.Empty,
                string.Empty,
                true,
                false,
                DateTime.Now,
                DateTime.Now,
                DateTime.Now,
                DateTime.Now,
                DateTime.Now);
        }
        public override MembershipUser GetUser(object providerUserKey, bool userIsOnline)
        {
            throw new NotImplementedException();
        }
        public override string GetUserNameByEmail(string email)
        {
            throw new NotImplementedException();
        }
        public override string ResetPassword(string name, string answer)
        {
            throw new NotImplementedException();
        }
        public override void UpdateUser(MembershipUser user)
        {
            throw new NotImplementedException();
        }
        public override bool ValidateUser(string name, string password)
        {
            using (DataAccessAdapterBase adapter = Helper.GetDataAccessAdapter())
            {
                UserEntity user = UserEntity.FetchUser(adapter, name);
                
                if (user == null || 
                    !Common.Cryptography.ValidatePassword(user.Password, password))
                {
                    return false;
                }
            }
            
            return true;
        }
        public override bool UnlockUser(string userName)
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
        public override bool EnablePasswordReset
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public override bool EnablePasswordRetrieval
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public override bool RequiresQuestionAndAnswer
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public override int MaxInvalidPasswordAttempts
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public override int MinRequiredNonAlphanumericCharacters
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public override int MinRequiredPasswordLength
        {
            get
            {
                return Common.Config.MinPasswordLength;
            }
        }
        public override int PasswordAttemptWindow
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public override MembershipPasswordFormat PasswordFormat
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public override string PasswordStrengthRegularExpression
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public override bool RequiresUniqueEmail
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        #endregion
    
    }
}

