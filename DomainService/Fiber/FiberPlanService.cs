using TCI.DataAccess.Interface;
using TCI.DomainService.Fiber.Interface;

namespace TCI.DomainService.Fiber
{
    public class FiberPlanService : BaseService<Domain.FiberPlan>, IFiberPlanService
    {
        public FiberPlanService(IFiberUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
