using FastOrder.Domain.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace FastOrder.Domain.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(160)]
        public required string Name { get; set; }

        [Range(0.01, 100000.00)]
        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public ItemStatus Status { get; set; } = ItemStatus.Available;

        public ItemType ItemType { get; set; } = ItemType.Product;

    }
}
