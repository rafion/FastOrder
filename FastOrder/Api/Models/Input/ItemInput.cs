using FastOrder.Domain.Models;
using FastOrder.Domain.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace FastOrder.Api.Models.Input
{
    public class ItemInput
    {
        public Guid Id { get; set; }
        public int DisplayId { get; set; }

        [Required(ErrorMessage ="Informe um nome!")]
        [StringLength(160)]
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public Status Status { get; set; }

        public ItemType ItemType { get; set; }
    }
}
