using System.Collections.Generic;
using System.Linq;
using AutoMapper.QueryableExtensions;
using TCI.Domain;
using TCI.DomainService;
using TCI.Mapper;
using TCI.Model;

namespace TCI.Operation
{
    public abstract class BaseOperation<TEntity, TModel>
        where TEntity : BaseEntity
        where TModel : BaseModel
    {
        private readonly BaseService<TEntity> _baseService;

        protected BaseOperation(BaseService<TEntity> baseService)
        {
            (new BaseMapper<TEntity, TModel>()).Register();
            _baseService = baseService;
        }

        public List<TModel> GetAll()
        {
            return _baseService.GetAll().ProjectTo<TModel>().ToList();
        }
    }
}