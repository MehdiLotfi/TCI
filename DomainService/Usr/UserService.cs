using TCI.DataAccess;
using TCI.DataAccess.Interface;
using TCI.DomainService.Usr.Interface;

namespace TCI.DomainService.Usr
{
    public class UserService : BaseService<Domain.User>, IUserService
    {
        public UserService(ISsoUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
