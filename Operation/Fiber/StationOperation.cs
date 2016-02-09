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
    }
}
