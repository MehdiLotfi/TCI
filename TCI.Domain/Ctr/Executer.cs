using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TCI.Domain.Per;

namespace TCI.Domain.Ctr
{
    [Table("Executer", Schema = "ctr")]
    public class Executer : BaseEntity
    {
        [Key, ForeignKey("Person")]
        public int ExecuterId { get; set; }

        public Person Person { get; set; }
    }
}