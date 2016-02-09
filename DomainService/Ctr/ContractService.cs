using TCI.DataAccess;
using TCI.Domain;

namespace TCI.DomainService.Ctr
{
    public class ContractService : BaseService<Contract>
    {
        public ContractService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
