using TCI.DataAccess.Interface;
using TCI.DomainService.Fiber.Interface;

namespace TCI.DomainService.Fiber
{
    public class OcdfService : BaseService<Domain.Ocdf>, IOcdfService
    {
        public OcdfService(IFiberUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
