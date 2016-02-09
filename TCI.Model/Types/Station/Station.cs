using System.Drawing;

namespace TCI.Model.Types.Station
{
    public abstract class Station
    {
        public abstract bool HaveCableRoom { get; }
        public abstract bool HaveOcdf { get; }
        public abstract Image Image { get; }
    }
}