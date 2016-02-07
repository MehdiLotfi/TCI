using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TCI.Domain.Per;

namespace TCI.Domain.Ctr
{
    [Table("Controller", Schema = "frm")]
    public class Controller : BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None), ForeignKey("Person")]
        public int ControllerId { get; set; }

        public Person Person { get; set; }
    }
}