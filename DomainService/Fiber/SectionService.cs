using TCI.DataAccess.Interface;
using TCI.DomainService.Fiber.Interface;

namespace TCI.DomainService.Fiber
{
    public class SectionService : BaseService<Domain.Section>, ISectionService
    {
        public SectionService(IFiberUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
