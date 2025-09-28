using System.ComponentModel;

namespace FastOrder.Domain.Models.Enums
{
    public enum ItemType
    {
        [Description("Produtos")]
        Product = 0,

        [Description("Serviços")]
        Service = 9,

        [Description("Outros")]
        Others = 99

    }
}
