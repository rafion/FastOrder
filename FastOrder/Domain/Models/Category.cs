using FastOrder.Domain.Models.Enums;

namespace FastOrder.Domain.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public Status Status { get; set; } = Status.Available;

        // Propriedade para o auto-relacionamento (subcategorias)
        public ICollection<Category>? Children { get; set; }
        // Propriedade para a categoria pai (opcional, para relacionamento bidirecional)
        public Guid? ParentId { get; set; }
        public Category? Parent { get; set; }

    }
}
