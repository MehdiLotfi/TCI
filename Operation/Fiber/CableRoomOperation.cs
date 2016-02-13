using System.Collections.Generic;
using System.Linq;
using AutoMapper.QueryableExtensions;
using TCI.DomainService.Fiber;
using TCI.Model;
using TCI.Operation.Fiber.Interface;

namespace TCI.Operation.Fiber
{
    public class CableRoomOperation : BaseOperation<Domain.CableRoom, Model.CableRoom>, ICableRoomOperation
    {
        public CableRoomOperation(CableRoomService baseService) : base(baseService)
        {
        }

        public List<CableRoom> GetByStation(int stationId)
        {
            return BaseService.GetAll(x => x.StationId == stationId).ProjectTo<Model.CableRoom>().ToList();
        }
    }
}
