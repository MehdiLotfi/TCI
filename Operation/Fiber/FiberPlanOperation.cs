using TCI.DomainService.Fiber.Interface;
using TCI.Operation.Fiber.Interface;

namespace TCI.Operation.Fiber
{
    public class FiberPlanOperation : BaseOperation<Domain.FiberPlan, Model.FiberPlan>, IFiberPlanOperation
    {
        public FiberPlanOperation(IFiberPlanService baseService) : base(baseService)
        {
        }
    }
}
