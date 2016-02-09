using TCI.DataAccess;
using TCI.DataAccess.Interface;
using TCI.Domain;
using TCI.DomainService.Ctr.Interface;

namespace TCI.DomainService.Ctr
{
    public class ContractService : BaseService<Contract>, IContractService
    {
        public ContractService(ISupervisionUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
