using System.Collections.Generic;
using TCI.Domain;
using TCI.Model;

namespace TCI.Operation
{
    public interface IBaseOperation<TEntity, TModel>
        where TEntity : BaseEntity
        where TModel : BaseModel
    {
        List<TModel> GetAll();
    }
}
