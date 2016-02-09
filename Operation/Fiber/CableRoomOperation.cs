using TCI.DomainService.Fiber;
using TCI.Operation.Fiber.Interface;

namespace TCI.Operation.Fiber
{
    public class CableRoomOperation : BaseOperation<Domain.CableRoom, Model.CableRoom>, ICableRoomOperation
    {
        public CableRoomOperation(CableRoomService baseService) : base(baseService)
        {
        }
    }
}
