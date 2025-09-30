namespace FastOrder.Domain.Models.Abstractions
{
    public abstract class TenantSuport
    {
        public required Guid TenantId { get; set; }
        public required Tenant Tenant { get; set; }
      
    }
}
