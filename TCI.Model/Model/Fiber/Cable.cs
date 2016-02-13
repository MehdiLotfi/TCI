namespace TCI.Model
{
    public class Cable : BaseModel
    {
        public int CableId { get; set; }
        public int Number { get; set; }
        public int LozCount { get; set; }
        public int CoreCount { get; set; }
        public int ExtendedLozCount { get; set; }
        public int ExtendedCoreCount { get; set; }
        public string Name => Number + "/" + LozCount * CoreCount + ExtendedLozCount * ExtendedCoreCount;

        public string FullName
            => LozCount + "*" + CoreCount + (ExtendedLozCount == 0 ? "" : ExtendedLozCount + "*" + ExtendedCoreCount);
    }
}
