namespace TCI.Model.Usr
{
    public class User : BaseModel
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Family { get; set; }

        public string FullName => Name + " " + Family;
    }
}
