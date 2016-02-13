using System.Collections.Generic;
using TCI.Model;

namespace TCI.Operation.Fiber.Interface
{
    public interface ICableRoomOperation : IBaseOperation<Domain.CableRoom, Model.CableRoom>
    {
        List<CableRoom> GetByStation(int stationId);
    }
}
