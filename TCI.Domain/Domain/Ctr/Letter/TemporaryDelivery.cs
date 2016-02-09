using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCI.Domain.Letter
{
    [Table("TemporaryDelivery", Schema = "ltr")]
    public class TemporaryDelivery : ContractLetter
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TemporaryDeliveryId { get; set; }
        public override string DisplayName => "";
    }
}
