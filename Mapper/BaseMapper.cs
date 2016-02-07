﻿using AutoMapper;
using TCI.Domain;
using TCI.Model;

namespace TCI.Mapper
{
    public class BaseMapper<TEntity, TModel>
        where TEntity : BaseEntity
        where TModel : BaseModel
    {
        private bool _registered;
        public IMappingExpression<TEntity, TModel> EntityToModelMapper { get; private set; }
        public IMappingExpression<TModel, TEntity> ModelToEntityMapper { get; private set; }

        public virtual void Register()
        {
            if (_registered) return;
            EntityToModelMapper = AutoMapper.Mapper.CreateMap<TEntity, TModel>();
            ModelToEntityMapper = AutoMapper.Mapper.CreateMap<TModel, TEntity>();
            _registered = true;
        }
    }
}
