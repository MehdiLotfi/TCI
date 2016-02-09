using TCI.DataAccess.Interface;

namespace TCI.DataAccess.Context
{
    public class SupervisionContext : TciContext, ISupervisionUnitOfWork
    {
        public SupervisionContext()
            : base("SupervisionConnectionString")
        {
        }
    }
}