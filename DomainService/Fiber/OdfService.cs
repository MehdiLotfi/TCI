using TCI.DataAccess.Interface;
using TCI.DomainService.Fiber.Interface;

namespace TCI.DomainService.Fiber
{
    public class OdfService : BaseService<Domain.Odf>, IOdfService
    {
        public OdfService(IFiberUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
