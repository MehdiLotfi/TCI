using TCI.DataAccess.Interface;
using TCI.DomainService.Fiber.Interface;

namespace TCI.DomainService.Fiber
{
    public class CableRoomService : BaseService<Domain.CableRoom>, ICableRoomService
    {
        public CableRoomService(IFiberUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
