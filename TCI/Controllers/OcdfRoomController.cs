using System.Web.Mvc;
using TCI.Operation.Fiber.Interface;

namespace TCI.Controllers
{
    public partial class OcdfRoomController : Controller
    {
        private readonly IOcdfRoomOperation _ocdfRoomOperation;

        public OcdfRoomController(IOcdfRoomOperation ocdfRoomOperation)
        {
            _ocdfRoomOperation = ocdfRoomOperation;
        }

        public virtual ActionResult Index(int stationId)
        {
            var ocdfRooms = _ocdfRoomOperation.GetByStation(stationId);
            return PartialView(ocdfRooms);
        }
    }
}