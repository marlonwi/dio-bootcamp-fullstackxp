namespace DesafioDeCodigoUm;

public class Estacionamento
{
    private decimal precoInicial;
    private decimal precoPorHora;
    private List<String> veiculos;

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
        this.veiculos = new List<string>();
    }

    public void AdicionarVeiculo(String veiculo)
    {
        this.veiculos.Add(veiculo);
    }

    public void RemoverVeiculo(String veiculo, int horasEstacionado)
    {
        if(this.veiculos.Count == 0)
            Console.WriteLine("A lista está vazia!!!");
        else
        {
            foreach (String verificar in this.veiculos)
            {
                if (verificar == veiculo)
                {
                    decimal precoFinal = this.precoInicial + (this.precoPorHora / 60) * horasEstacionado;
                    this.veiculos.Remove(verificar);
                    Console.WriteLine("O veículo " + verificar + " foi removido. Valor total a ser pago = " + precoFinal);
                    return;
                }
            }
        }
        Console.WriteLine("Veículo não encontrado!!!");
    }

    public void ListarVeiculos()
    {
        if(this.veiculos.Count == 0)
            Console.WriteLine("A lista está vazia!!!");
        else
            this.veiculos.ForEach(veiculo => Console.WriteLine(veiculo));
    }
}