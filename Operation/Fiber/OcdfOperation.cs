using TCI.DomainService.Fiber.Interface;

namespace TCI.Operation.Fiber
{
    public class OcdfOperation : BaseOperation<Domain.Ocdf, Model.Ocdf>
    {
        public OcdfOperation(IOcdfService baseService)
            : base(baseService)
        {
        }
    }
}
