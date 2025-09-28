using FastOrder.Domain.Models.Enums;
using FastOrder.Domain.Models.Enums.Extensions;
using System.Runtime.CompilerServices;

namespace FastOrder.Domain.Models
{
    public class Order
    {
        public Guid Id { get; init; }

        private OrderStatus _status;
        public string DisplayValue { get; private set; } //private para ser alterado apenas dentro da classe
        public string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }
        public string? Technician { get; set; }
        public string? Task { get; set; }
        public string? ExtraInfo { get; set; }

        public ICollection<OrderItem> Items { get; set; }

        public Order(string displayValue)
        {
            Id = Guid.NewGuid();
            Status = OrderStatus.New;
            CustomerName = string.Empty;
            DisplayValue = displayValue;
            Items = new List<OrderItem>();
        }

        public OrderStatus Status
        {
            get { return _status; }
            set { _status = this.Status.StatusUpdate(value); }
        }

        //public void updateStatus(OrderStatus newStatus)
        //{
        //    //LANÇA uma exceção caso não obedeça a ordem (Atribuido -> Novo não é permitido)
        //    this.Status = this.Status.StatusUpdate(newStatus);

        //}

    }
}
