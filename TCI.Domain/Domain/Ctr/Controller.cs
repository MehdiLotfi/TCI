using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCI.Domain
{
    [Table("Controller", Schema = "frm")]
    public class Controller : BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None), ForeignKey("Person")]
        public int ControllerId { get; set; }

        public Person Person { get; set; }
    }
}