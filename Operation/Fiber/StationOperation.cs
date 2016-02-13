using TCI.DomainService.Fiber.Interface;
using TCI.Operation.Fiber.Interface;

namespace TCI.Operation.Fiber
{
    public class StationOperation : BaseOperation<Domain.Station, Model.Station>, IStationOperation
    {
        public StationOperation(IStationService stationService)
            : base(stationService)
        {
        }

        public Model.Station GetDetails(int id)
        {
            return AutoMapper.Mapper.Map<Model.Station>(BaseService.GetFirst(x => x.StationId == id));
        }
    }
}
