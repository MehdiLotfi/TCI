using TCI.DataAccess.Interface;
using TCI.DomainService.Fiber.Interface;

namespace TCI.DomainService.Fiber
{
    public class StationService : BaseService<Domain.Station>, IStationService
    {
        public StationService(IFiberUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
