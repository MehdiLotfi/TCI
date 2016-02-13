using System.ComponentModel.DataAnnotations.Schema;

namespace TCI.Domain
{
    [Table("Cable", Schema = "fiber")]
    public class Cable : BaseEntity
    {
        public int CableId { get; set; }
        public int Number { get; set; }
        public int FromStationId { get; set; }
        public int? FromCableRoomId { get; set; }
        public int? FromOcdfRoomId { get; set; }
        public int? FromOcdfId { get; set; }
        public int ToStationId { get; set; }
        public int? ToCableRoomId { get; set; }
        public int? ToOcdfRoomId { get; set; }
        public int? ToOcdfId { get; set; }
        public int LozCount { get; set; }
        public int CoreCount { get; set; }
        public int? ExtendedLozCount { get; set; }
        public int? ExtendedCoreCount { get; set; }
    }
}
