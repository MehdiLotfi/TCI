using TCI.DomainService.Ctr;

namespace TCI.Operation.Ctr
{
    public class ExecuterOperation : BaseOperation<Domain.Ctr.Executer, Model.Ctr.Executer>
    {
        public ExecuterOperation(ExecuterService executerService)
            : base(executerService)
        {
        }
    }
}
