using System;
using System.Linq.Expressions;
using TCI.DomainService.Usr;

namespace TCI.Operation.Usr
{
    public class UserOperation : BaseOperation<Domain.Usr.User, Model.Usr.User>
    {
        public UserOperation(UserService userService)
            : base(userService)
        {
        }

        public bool Login(string userName, string password)
        {
            var user = BaseService.GetFirst(x => x.UserName == userName);
            if (user == null)
            {
                return false;
            }
            return PasswordHash.PasswordHash.ValidatePassword(password, user.Password);
        }
    }
}
