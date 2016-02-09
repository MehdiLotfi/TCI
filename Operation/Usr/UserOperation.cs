using TCI.DomainService.Usr;
using TCI.Operation.Usr.Interface;

namespace TCI.Operation.Usr
{
    public class UserOperation : BaseOperation<Domain.Usr.User, Model.Usr.User>, IUserOperation
    {
        public UserOperation(UserService userService)
            : base(userService)
        {
        }

        public Model.Usr.User Login(Model.Usr.Login login)
        {
            var user = BaseService.GetFirst(x => x.UserName == login.UserName);
            if (user == null)
            {
                return null;
            }
            return PasswordHash.PasswordHash.ValidatePassword(login.Password, user.Password) ? AutoMapper.Mapper.Map<Model.Usr.User>(user) : null;
        }
    }
}
