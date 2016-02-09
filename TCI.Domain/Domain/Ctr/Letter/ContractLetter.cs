using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCI.Domain.Letter
{
    [Table("ContractLetter", Schema = "ltr")]
    public abstract class ContractLetter : BaseEntity
    {
        [Key]
        public int ContractLetterId { get; set; }

        [NotMapped]
        public abstract string DisplayName { get; }

        public DateTime Date { get; set; }

        [StringLength(30)]
        public string Number { get; set; }
    }
}
