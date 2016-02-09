using TCI.DomainService.Fiber.Interface;
using TCI.Operation.Fiber.Interface;

namespace TCI.Operation.Fiber
{
    public class LineSystemOperation : BaseOperation<Domain.LineSystem, Model.LineSystem>, ILineSystemOperation
    {
        public LineSystemOperation(ILineSystemService baseService) : base(baseService)
        {
        }
    }
}
