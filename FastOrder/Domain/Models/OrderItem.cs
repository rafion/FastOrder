namespace FastOrder.Domain.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public required Order Order { get; init; }

        public int Index { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
