using System.Data.Entity;
using TCI.DataAccess.Interface;
using TCI.Domain;

namespace TCI.DataAccess.Context
{
    public class FiberContext : TciContext, IFiberUnitOfWork
    {
        public FiberContext()
            : base("FiberConnectionString")
        {
        }

        public DbSet<Station> Stations { get; set; }
        public DbSet<CableRoom> CableRooms { get; set; }
        public DbSet<OcdfRoom> OcdfRooms { get; set; }
    }
}
