using TCI.DomainService.Fiber.Interface;
using TCI.Operation.Fiber.Interface;

namespace TCI.Operation.Fiber
{
    public class SectionOperation : BaseOperation<Domain.Section, Model.Section>, ISectionOperation
    {
        public SectionOperation(ISectionService baseService)
            : base(baseService)
        {
        }
    }
}
