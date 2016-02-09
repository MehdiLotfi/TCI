using TCI.DataAccess.Interface;
using TCI.Domain;
using TCI.DomainService.Ctr.Interface;

namespace TCI.DomainService.Ctr
{
    public class ExecuterService : BaseService<Executer>, IExecuterService
    {
        public ExecuterService(ISupervisionUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
