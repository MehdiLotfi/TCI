using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCI.Domain.Ctr
{
    [Table("ContractItem", Schema = "ctr")]
    public class ContractItem : BaseEntity
    {
        [Key]
        public int ContractItemId { get; set; }

        [Required, ForeignKey("Contract")]
        public int ContractId { get; set; }
        public Contract Contract { get; set; }

        public ContractItemType ContractItemType { get; set; }

        [Required]
        public decimal Quantity { get; set; }

        public decimal ActionPrice { get; set; }

        public decimal GoodsPrice { get; set; }
    }
}
