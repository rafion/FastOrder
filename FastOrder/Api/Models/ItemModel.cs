using FastOrder.Domain.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace FastOrder.Api.Models
{
    public class ItemModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public ItemStatus Status { get; set; }
        public string? StatusName { get; set; }
        public ItemType ItemType { get; set; }

        public string? ItemTypeName { get; set; }
    }
}
