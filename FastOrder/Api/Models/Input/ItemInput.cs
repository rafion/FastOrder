using FastOrder.Domain.Models;
using FastOrder.Domain.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace FastOrder.Api.Models.Input
{
    public class ItemInput
    {
        public int Id { get; set; }

        public Guid ExternalId { get; set; }
        public string? Sku { get; set; }

        [Required(ErrorMessage = "Informe um nome!")]
        [StringLength(160)]
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
        public int StatusId { get; set; }
        public ItemType ItemType { get; set; }
        public int itemTypeId { get; set; }
    }
}
