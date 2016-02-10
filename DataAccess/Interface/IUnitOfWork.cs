using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using TCI.Domain;

namespace TCI.DataAccess.Interface
{
    public interface IUnitOfWork: IDisposable
    {
        IDbSet<TEntity> DbSet<TEntity>() where TEntity : BaseEntity;

        int SaveChanges();

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : BaseEntity;
    }
}
