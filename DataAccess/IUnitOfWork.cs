using System.Data.Entity;
using TCI.Domain;

namespace TCI.DataAccess
{
    public interface IUnitOfWork
    {
        IDbSet<TEntity> DbSet<TEntity>() where TEntity : BaseEntity;
    }
}
