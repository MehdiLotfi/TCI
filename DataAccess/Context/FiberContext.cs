using TCI.DataAccess.Interface;

namespace TCI.DataAccess.Context
{
    public class FiberContext : TciContext, IFiberUnitOfWork
    {
        public FiberContext()
            : base("FiberConnectionString")
        {
        }
    }
}
