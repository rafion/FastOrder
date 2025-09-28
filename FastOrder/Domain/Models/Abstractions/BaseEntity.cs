namespace FastOrder.Domain.Models.Abstractions
{
    public abstract class BaseEntity
    {
        public Guid? Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }

        public BaseEntity()
        {
            if(Id == null)           
                Id = Guid.NewGuid();
                        
            CreatedAt = DateTime.UtcNow;
           
        }
    }
}
