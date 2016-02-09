using TCI.DataAccess;
using TCI.Domain;

namespace TCI.DomainService.Ctr
{
    public class ExecuterService : BaseService<Executer>
    {
        public ExecuterService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
