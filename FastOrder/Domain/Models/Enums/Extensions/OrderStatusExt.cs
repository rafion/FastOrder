namespace FastOrder.Domain.Models.Enums.Extensions
{
    public static class OrderStatusExt
    {
        //a palavra reservada 'this' no parametro do metodo estatico, faz com vire uma extension
        public static OrderStatus StatusUpdate(this OrderStatus currentStatus, OrderStatus newStatus)
        {
            // 1. Verifica se o status atual existe no mapeamento de transições
            if (!ValidTransitions.ContainsKey(currentStatus))
            {
                throw new InvalidOperationException($"Status atual '{currentStatus}' não é um ponto de partida válido.");
            }

            // 2. Verifica se o novoStatus está na lista de transições permitidas para o statusAtual
            if (ValidTransitions[currentStatus].Contains(newStatus))
            {
                return newStatus; // Transição VÁLIDA
            }
            else
            {
                throw new InvalidOperationException($"Transição de '{currentStatus}' para '{newStatus}' não é permitida pela regra de negócios.");
            }
        }

        // Mapeia o Status ATUAL para uma lista de Status FUTUROS VÁLIDOS
        private static readonly Dictionary<OrderStatus, List<OrderStatus>> ValidTransitions =
            new Dictionary<OrderStatus, List<OrderStatus>>
        {
    {
        OrderStatus.AwaitingCustomerApprovaL,
        new List<OrderStatus> { OrderStatus.New }
    },
    {
        OrderStatus.InQueue,
        new List<OrderStatus> { OrderStatus.AwaitingCustomerApprovaL, OrderStatus.Aproved }
    },
    {
        OrderStatus.Diagnosing,
        new List<OrderStatus> { OrderStatus.InQueue, OrderStatus.Aproved }
    },
    {
        OrderStatus.Completed,
        new List<OrderStatus>() // Nenhum estado futuro válido
    }
        };


    }
}
