using FastOrder.Domain.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace FastOrder.Api.Models
{
    public class ItemModel
    {
        public Guid Id { get; set; }
        public int DisplayId { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public Status Status { get; set; }
        public string? StatusName { get; set; }
        public ItemType ItemType { get; set; }

        public string? ItemTypeName { get; set; }
    }
}
