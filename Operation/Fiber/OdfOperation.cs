using TCI.DomainService.Fiber.Interface;
using TCI.Operation.Fiber.Interface;

namespace TCI.Operation.Fiber
{
    public class OdfOperation : BaseOperation<Domain.Odf, Model.Odf>, IOdfOperation

    {
        public OdfOperation(IOdfService baseService)
            : base(baseService)
        {
        }
    }
}
