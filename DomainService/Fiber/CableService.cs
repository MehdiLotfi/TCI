using TCI.DataAccess.Interface;
using TCI.DomainService.Fiber.Interface;

namespace TCI.DomainService.Fiber
{
    public class CableService : BaseService<Domain.Cable>, ICableService
    {
        public CableService(IFiberUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
