using System.Collections.Generic;
using System.Linq;
using AutoMapper.QueryableExtensions;
using TCI.Domain;
using TCI.DomainService;
using TCI.Mapper;
using TCI.Model;

namespace TCI.Operation
{
    public abstract class BaseOperation<TEntity, TModel> : IBaseOperation<TEntity, TModel>
        where TEntity : BaseEntity
        where TModel : BaseModel
    {
        protected readonly BaseService<TEntity> BaseService;

        protected BaseOperation(BaseService<TEntity> baseService)
        {
            (new BaseMapper<TEntity, TModel>()).Register();
            BaseService = baseService;
        }

        public List<TModel> GetAll()
        {
            return BaseService.GetAll().ProjectTo<TModel>().ToList();
        }
    }
}