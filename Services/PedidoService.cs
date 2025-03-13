using pagamentos_uniforme_etec.Models;

namespace pagamentos_uniforme_etec.Services;

public class PedidoService 
{
    public List<Pedido> GetPedidos()
    {
        return new List<Pedido>
        {
            new Pedido { Nome = "Brendon Berzins", Tamanhos = new List<string> { "M" }, Pago = 45, TotalAPagar = 45, Status = "Pago" }
        };
    }
}