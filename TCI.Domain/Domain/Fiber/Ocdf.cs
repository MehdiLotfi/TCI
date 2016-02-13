using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCI.Domain
{
    [Table("Ocdf", Schema = "fiber")]
    public class Ocdf : BaseEntity
    {
        [Key]
        public int OcdfId { get; set; }
        [Required, ForeignKey("OcdfRoom")]
        public int OcdfRoomId { get; set; }
        public OcdfRoom OcdfRoom { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

        public int RowNumber { get; set; }
        public bool IsASide { get; set; }
        public int BayNumber { get; set; }
        public int BayCount { get; set; }
        public ICollection<Section> Sections { get; set; }
        public ICollection<Odf> Odfs { get; set; }
    }
}
