namespace FastOrder.Domain.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public required Guid OrderId { get; set; }
        public int Index { get; set; }
        public required string ProductName { get; set; } // como os itens são dinamicos, melhor registrar aqui
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }

        public required Order Order { get; init; }
    }
}
