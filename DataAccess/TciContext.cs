using System.Data.Entity;
using TCI.Domain;
using TCI.Domain.Per;

namespace TCI.DataAccess
{
    public class TciContext : DbContext, IUnitOfWork
    {
        public TciContext()
            : base("TCIConnectionString")
        {

        }

        #region DbSet
        public DbSet<LegalPerson> LegalPersons { get; set; }
        public DbSet<RealPerson> RealPersons { get; set; }
        #endregion

        public IDbSet<TEntity> DbSet<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }
    }
}