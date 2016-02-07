using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TCI.Domain;

namespace TCI.Domain.Ctr
{
    [Table("Contract", Schema = "ctr")]
    public class Contract : BaseEntity
    {
        [Key]
        public int ContractId { get; set; }

        [Required, ForeignKey("Executer")]
        public int ExecuterId { get; set; }

        public Executer Executer { get; set; }

        public Collection<ContractItem> ContractItems { get; set; }

        public ICollection<ContractController> ContractControllers { get; set; }
    }
}
