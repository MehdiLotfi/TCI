using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCI.Domain
{
    [Table("Station", Schema = "fiber")]
    public class Station : BaseEntity
    {
        [Key]
        public int StationId { get; set; }

        [StringLength(20)]
        public string Code { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }
    }
}
