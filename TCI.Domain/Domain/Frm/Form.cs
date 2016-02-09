using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCI.Domain
{
    [Table("Form", Schema = "frm")]
    public abstract class Form : BaseEntity
    {
        [Key]
        public int FormId { get; set; }

        [Required, ForeignKey("Contract")]
        public int ContractId { get; set; }

        public Contract Contract { get; set; }

        [Required, ForeignKey("Controller")]
        public int ControllerId { get; set; }

        public Controller Controller { get; set; }

        public DateTime Date { get; set; }

        public int Number { get; set; }

        public ICollection<FormVerifyItem> FormVerifyItems { get; set; }
    }
}
