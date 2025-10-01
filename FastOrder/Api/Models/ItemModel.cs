using FastOrder.Domain.Models.Enums;

namespace FastOrder.Api.Models
{
    public class ItemModel
    {
        public int Id { get; set; }

        public Guid ExternalId { get; set; }
        public string? Sku { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? Model { get; set; }
        public string? Reference { get; set; }
        public string? Ean { get; set; }
        public required string Unit { get; set; }
        public decimal Price { get; set; }
        public decimal CostPrice { get; set; }
        public int StockQuantity { get; set; }
        public Status Status { get; set; }
        public string? StatusName { get; set; }
        public ItemType ItemType { get; set; }
        public string? ItemTypeName { get; set; }
    }
}
