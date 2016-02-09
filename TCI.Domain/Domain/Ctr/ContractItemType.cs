using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCI.Domain
{
    [Table("ContractItemType", Schema = "ctr")]
    public class ContractItemType : BaseEntity
    {
        [Key]
        public int ContractItemTypeId { get; set; }

        [StringLength(250)]
        public string ActionName { get; set; }

        [StringLength(250)]
        public string GoodsName { get; set; }
    }
}