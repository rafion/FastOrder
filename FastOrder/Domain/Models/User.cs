namespace FastOrder.Domain.Models
{
    public class User
    {
        public Guid Id { get; init; }
        public required string Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public User() { }
    }
}
