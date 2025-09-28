namespace FastOrder.Domain.Models.Abstractions
{
    public abstract class TenantSuport
    {
        public required Tenant Tenant { get; set; }
      
    }
}
