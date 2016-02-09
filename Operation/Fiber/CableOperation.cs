using TCI.DomainService.Fiber.Interface;
using TCI.Operation.Fiber.Interface;

namespace TCI.Operation.Fiber
{
    public class CableOperation : BaseOperation<Domain.Cable, Model.Cable>, ICableOperation
    {
        public CableOperation(ICableService baseService)
            : base(baseService)
        {
        }
    }
}
