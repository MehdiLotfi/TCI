using System.Data.Entity;
using System.Linq;
using TCI.DataAccess;
using TCI.Domain;

namespace TCI.DomainService
{
    public abstract class BaseService<TEntity> 
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
    }
}
