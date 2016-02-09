using System.Data.Entity;
using TCI.DataAccess.Interface;
using TCI.Domain;

namespace TCI.DataAccess.Context
{
    public class TciContext : DbContext, IUnitOfWork
    {
        public TciContext(string connectionString)
            : base(connectionString)
        {

        }

        public IDbSet<TEntity> DbSet<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }
    }
}