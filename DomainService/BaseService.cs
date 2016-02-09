using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using TCI.DataAccess;
using TCI.Domain;

namespace TCI.DomainService
{
    public abstract class BaseService<TEntity> : IBaseService<TEntity>
        where TEntity : BaseEntity
    {
        private IUnitOfWork _unitOfWork;
        private readonly IDbSet<TEntity> _entities;

        protected BaseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _entities = unitOfWork.DbSet<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _entities;
        }

        public TEntity GetFirst(Expression<Func<TEntity, bool>> predicate = null)
        {
            return predicate == null ? _entities.First() : _entities.Where(predicate).First();
        }
    }
}