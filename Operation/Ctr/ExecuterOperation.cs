using TCI.DomainService.Ctr;

namespace TCI.Operation.Ctr
{
    public class ExecuterOperation : BaseOperation<Domain.Executer, Model.Executer>
    {
        public ExecuterOperation(ExecuterService executerService)
            : base(executerService)
        {
        }
    }
}
