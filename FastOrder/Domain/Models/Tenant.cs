using FastOrder.Domain.Models.Abstractions;

namespace FastOrder.Domain.Models
{
    public class Tenant : BaseEntity
    {
        public required String Name { get; set; }
        public string? Description { get; set; }
       
    }
}
