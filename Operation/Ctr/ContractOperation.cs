using TCI.DomainService;
using TCI.DomainService.Ctr;

namespace TCI.Operation.Ctr
{
    public class ContractOperation : BaseOperation<Domain.Ctr.Contract, Model.Ctr.Contract>
    {
        public ContractOperation(ContractService contractService)
            : base(contractService)
        {
        }
    }
}
