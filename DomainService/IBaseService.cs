using System;
using System.Linq;
using System.Linq.Expressions;
using TCI.Domain;

namespace TCI.DomainService
{
    public interface IBaseService<TEntity>
        where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAll();
        TEntity GetFirst(Expression<Func<TEntity, bool>> predicate = null);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        void Save();
    }
}
