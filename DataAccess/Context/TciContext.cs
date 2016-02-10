using System.Data.Entity;
using System.Data.Entity.Infrastructure;
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

        public new DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            return base.Entry(entity);
        }
    }
}