using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCI.Domain.Ctr
{
    [Table("ContractController", Schema = "ctr")]
    public class ContractController : BaseEntity
    {
        [Key]
        public int ContractControllerId { get; set; }

        [Required]
        public int ContractId { get; set; }

        [Required, ForeignKey("Controller")]
        public int ControllerId { get; set; }

        public Controller Controller { get; set; }
    }
}