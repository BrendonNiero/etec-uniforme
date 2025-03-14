namespace pagamentos_uniforme_etec.Models;

public class Pedido
{
    public string Nome { get; set; } = string.Empty;
    public List<string> Tamanhos { get; set; } = new();
    public double Pago { get; set; }
    public double TotalAPagar { get; set; } 
}