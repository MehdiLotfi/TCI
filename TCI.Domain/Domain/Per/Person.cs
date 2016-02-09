using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCI.Domain
{
    [Table("Person", Schema = "Per")]
    public abstract class Person : BaseEntity
    {
        [Key]
        public int PersonId { get; set; }

        [Required]
        public int Code { get; set; }

        [NotMapped]
        public abstract string DisplayName { get; }

    }
}