using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCI.Domain.Ctr.Letter
{
    [Table("DefiniteDelivery", Schema = "ltr")]
    public class DefiniteDelivery : ContractLetter
    {
        [Key]
        public int DefiniteDeliveryId { get; set; }

        [NotMapped]
        public override string DisplayName => "";
    }
}
