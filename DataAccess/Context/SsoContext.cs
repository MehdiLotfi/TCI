using TCI.DataAccess.Interface;

namespace TCI.DataAccess.Context
{
    public class SsoContext : TciContext, ISsoUnitOfWork
    {
        public SsoContext(string connectionStrin)
            : base("SSOConnectionString")
        {
        }
    }
}
