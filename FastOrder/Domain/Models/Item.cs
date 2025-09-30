using FastOrder.Domain.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace FastOrder.Domain.Models
{
    public class Item
    {
        public Guid Id { get; set; }

        public int DisplayId { get; set; }

        [Required]
        [MaxLength(160)]
        public required string Name { get; set; }

        [Range(0.01, 100000.00)]
        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public Status Status { get; set; } = Status.Available;

        public ItemType ItemType { get; set; } = ItemType.Product;

    }
}
