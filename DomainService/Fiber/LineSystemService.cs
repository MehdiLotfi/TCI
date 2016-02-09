using TCI.DataAccess.Interface;
using TCI.DomainService.Fiber.Interface;

namespace TCI.DomainService.Fiber
{
    public class LineSystemService : BaseService<Domain.LineSystem>, ILineSystemService
    {
        public LineSystemService(IFiberUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
