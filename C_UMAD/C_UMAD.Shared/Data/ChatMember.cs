namespace C_UMAD.Shared.Data
{
    public class ChatMember : IEntity
    {
        public int Id { get; set; }
        public Chat? Chat { get; set; }
        public User? User { get; set; }
    }
}