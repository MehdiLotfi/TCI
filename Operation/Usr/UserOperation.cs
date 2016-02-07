using TCI.DomainService.Usr;

namespace TCI.Operation.Usr
{
    public class UserOperation : BaseOperation<Domain.Usr.User, Model.Usr.User>
    {
        public UserOperation(UserService userService)
            : base(userService)
        {
        }
    }
}
