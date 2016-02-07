using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCI.Domain.Per
{
    [Table("RealPerson", Schema = "per")]
    public class RealPerson : Person
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RealPersonId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Family { get; set; }

        [NotMapped]
        public override string DisplayName => Name + " " + Family;
    }
}
