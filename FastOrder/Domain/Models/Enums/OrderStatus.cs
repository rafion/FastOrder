using System.ComponentModel;

namespace FastOrder.Domain.Models.Enums
{
    public enum OrderStatus
    {
        [Description("Novo")] //A ordem foi criada; o item acabou de ser recebido
        New = 1,

        [Description("Aprovado")] //O cliente aprovou o orçamento, mesmo antes do diagnostico
        Aproved = 2,

        [Description("Aguardando da Fila")] //O item está na fila, esperando ser designado a um técnico.
        InQueue = 3,

        [Description("Em Diagnostico")] //O técnico está inspecionando o item para determinar a causa da falha.
        Diagnosing = 4,

        [Description("Aguardando Aprovação do Cliente")] //O diagnóstico foi concluído e o orçamento foi enviado ao cliente.
        AwaitingCustomerApprovaL = 5,
                
        [Description("Em Reparo")] 
        InRepair = 6,

        [Description("Pausado")]
        Paused = 7,

        [Description("Aguardando Peças")]
        AwaitingParts = 8,

        [Description("Testando")]
        Testing = 9,

        [Description("Pronto Para Retirada")]
        ReadyforPickup = 10,

        [Description("Completo")]
        Completed = 11,

        [Description("Fechado")]
        Closed = 12,

        [Description("Em Entrega")]
        Delivered = 13,

        [Description("Cancelado")]
        Canceled = 14,

        [Description("Rejeitado")]
        Rejected = 15,

        [Description("Nenhuma Falha Encontrada")]
        NoFaultFound = 16,

        [Description("Perda Total")]
        BeyondRepair = 17

    }

    
}
