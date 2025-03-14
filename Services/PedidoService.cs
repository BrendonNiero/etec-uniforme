using pagamentos_uniforme_etec.Models;

namespace pagamentos_uniforme_etec.Services;

public class PedidoService 
{
    public List<Pedido> GetPedidos()
    {
        return new List<Pedido>
        {
            new Pedido { Nome = "Brendon Berzins", Tamanhos = new List<string> { "M" }, Pago = 45, TotalAPagar = 45 },
            new Pedido { Nome = "Emilly", Tamanhos = new List<string> { "M", "M" }, Pago = 0, TotalAPagar = 90 },
            new Pedido { Nome = "Tânia Regina", Tamanhos = new List<string> { "GG" }, Pago = 45, TotalAPagar = 45 },
            new Pedido { Nome = "Jaqueline", Tamanhos = new List<string> { "M" }, Pago = 45, TotalAPagar = 45 },
            new Pedido { Nome = "Marcelo", Tamanhos = new List<string> { "M" }, Pago = 45, TotalAPagar = 45 },
            new Pedido { Nome = "Prof. Marcelo", Tamanhos = new List<string> { "XGG" }, Pago = 45, TotalAPagar = 45 },
            new Pedido { Nome = "Yasmin", Tamanhos = new List<string> { "GG" }, Pago = 45, TotalAPagar = 45 },
            new Pedido { Nome = "Maria", Tamanhos = new List<string> { "GG" }, Pago = 45, TotalAPagar = 45 },
            new Pedido { Nome = "Paulo", Tamanhos = new List<string> { "GG", "GG" }, Pago = 90, TotalAPagar = 90 },
            new Pedido { Nome = "Ingrid", Tamanhos = new List<string> { "G" }, Pago = 45, TotalAPagar = 45 },
            new Pedido { Nome = "Geovana", Tamanhos = new List<string> { "BL" }, Pago = 45, TotalAPagar = 45 },
            new Pedido { Nome = "Bruno Emanuel", Tamanhos = new List<string> { "P", "P" }, Pago = 0, TotalAPagar = 45 },
            new Pedido { Nome = "Irene", Tamanhos = new List<string> { "PP" }, Pago = 0, TotalAPagar = 45 },
            new Pedido { Nome = "Josiane", Tamanhos = new List<string> { "BL" }, Pago = 45, TotalAPagar = 45 },
            new Pedido { Nome = "Ane Maria", Tamanhos = new List<string> { "G" }, Pago = 45, TotalAPagar = 45 },
            new Pedido { Nome = "João Augusto", Tamanhos = new List<string> { "G", "G" }, Pago = 45, TotalAPagar = 90 },
            new Pedido { Nome = "Thaísa", Tamanhos = new List<string> { "BLP" }, Pago = 45, TotalAPagar = 45 },
            new Pedido { Nome = "Murieli", Tamanhos = new List<string> { "BLP" }, Pago = 45, TotalAPagar = 45 },
            new Pedido { Nome = "Igor", Tamanhos = new List<string> { "XG" }, Pago = 45, TotalAPagar = 45 },
            new Pedido { Nome = "João", Tamanhos = new List<string> { "M" }, Pago = 45, TotalAPagar = 45 },
            new Pedido { Nome = "Kauã", Tamanhos = new List<string> { "G", "G" }, Pago = 0, TotalAPagar = 90 },
            new Pedido { Nome = "Wylian", Tamanhos = new List<string> { "G", "G" }, Pago = 90, TotalAPagar = 90 },
            new Pedido { Nome = "Gabriel Bueno", Tamanhos = new List<string> { "M", "M" }, Pago = 45, TotalAPagar = 90 },
        };
    }
}