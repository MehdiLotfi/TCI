using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCI.Domain
{
    [Table("User", Schema = "usr")]
    public class User : BaseEntity
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required, ForeignKey("Person")]
        public int PersonId { get; set; }

        public Person Person { get; set; }

        public string Password { get; set; }
    }
}