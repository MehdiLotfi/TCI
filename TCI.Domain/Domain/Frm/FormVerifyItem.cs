using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCI.Domain
{
    [Table("FormVerifyItem", Schema = "frm")]
    public class FormVerifyItem : BaseEntity
    {
        [Key]
        public int FormVerifyItemId { get; set; }

        [Required,ForeignKey("VerifyItemType")]
        public int VerifyItemTypeId { get; set; }

        public VerifyItemType VerifyItemType { get; set; }
    }
}
