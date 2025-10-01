using FastOrder.Domain.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace FastOrder.Domain.Models
{
    public class Item
    {
        public int Id { get; set; } //melhor para ordenação e paginação

        public Guid ExternalId { get; set; } = Guid.NewGuid();

        public string? Sku { get; set; }

        [Required]
        [MaxLength(160)]
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? Model { get; set; }
        public string? Reference { get; set; }
        public string? Ean { get; set; }
        public required string Unit { get; set; } = "UND";

        [Range(0.01, 100000.00)]
        public decimal Price { get; set; }

        public decimal CostPrice { get; set; }

        public int StockQuantity { get; set; }

        public Status Status { get; set; } = Status.Available;

        public ItemType ItemType { get; set; } = ItemType.Product;

    }
}
