namespace C_UMAD.Shared.Data
{
    public class Student: IEntity
    {
        public int Id { get; set; }
        public User? User { get; set; }
        public Career? Career { get; set; }
    }
}