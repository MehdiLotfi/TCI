using System.Collections.Generic;

namespace TCI.Model
{
    public class Ocdf : BaseModel
    {
        public int OcdfId { get; set; }
        public string Name { get; set; }

        public IList<Section> Sections { get; set; }
        public IList<Odf> Odfs { get; set; }
    }
}
