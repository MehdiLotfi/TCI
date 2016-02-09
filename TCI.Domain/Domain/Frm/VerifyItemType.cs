using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TCI.Domain.Enums;

namespace TCI.Domain
{
    [Table("VerifyItemType", Schema = "frm")]
    public class VerifyItemType : BaseEntity
    {
        [Key]
        public int VerifyItemTypeId { get; set; }

        [Required, StringLength(250)]
        public string Title { get; set; }

        public VerifyStateType VerifyStateType { get; set; }

        [Required]
        public decimal PnaltyPercent { get; set; }
    }
}