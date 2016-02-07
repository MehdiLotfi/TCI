using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCI.Domain.Per
{
    [Table("LegalPerson", Schema = "per")]
    public class LegalPerson : Person
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LegalPersonId { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [NotMapped]
        public override string DisplayName => Name;
    }
}