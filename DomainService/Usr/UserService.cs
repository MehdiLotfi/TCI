using TCI.DataAccess;

namespace TCI.DomainService.Usr
{
    public class UserService : BaseService<Domain.Usr.User>
    {
        public UserService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
