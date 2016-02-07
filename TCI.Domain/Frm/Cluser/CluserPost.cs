using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCI.Domain.Frm.Cluser
{
    public class CluserPost : Form
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CluserPostId { get; set; }
    }
}
