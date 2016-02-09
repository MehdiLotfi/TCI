using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCI.Domain
{
    [Table("Executer", Schema = "ctr")]
    public class Executer : BaseEntity
    {
        [Key, ForeignKey("Person")]
        public int ExecuterId { get; set; }

        public Person Person { get; set; }
    }
}