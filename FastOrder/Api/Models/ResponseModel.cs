namespace FastOrder.Api.Model
{
    public class ResponseModel<T>
    {
        public T? Content { get; set; }
        public string Mensage { get; set; } = string.Empty;
        public bool Status { get; set; }
    }
}
