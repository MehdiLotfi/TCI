using System.Drawing;
using TCI.Model.Resource;

namespace TCI.Model.Types.Station
{
    public class Center : Station
    {
        public override bool HaveCableRoom => true;
        public override bool HaveOcdf => true;
        public override Image Image => ImageResource.Center;
    }
}
