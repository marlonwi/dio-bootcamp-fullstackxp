// See https://aka.ms/new-console-template for more information
using DesafioDeCodigoUm;


int opcao = 0;
Estacionamento estacionamento = new Estacionamento(10, 15);
String veiculo;
int horas;

while (opcao != 4)
{
    Console.WriteLine("Sendo as opções:\n1 - Cadastrar veículo\n2 - Remover veículo\n3 - Listar veículos\n4 - Encerrar");
    Console.WriteLine("Selecione sua opçao:");
    opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Console.WriteLine("Digite o modelo do veículo: ");
            veiculo = Console.ReadLine();
            estacionamento.AdicionarVeiculo(veiculo);
            break;
        case 2:
            Console.WriteLine("Digite o modelo do veículo: ");
            veiculo = Console.ReadLine();
            Console.WriteLine("Digite quantas horas o veículo ficou estacionado em minutos: ");
            horas = int.Parse(Console.ReadLine());
            estacionamento.RemoverVeiculo(veiculo, horas);
            break;
        case 3:
            estacionamento.ListarVeiculos();
            break;
        case 4:
            Console.WriteLine("Encerrando... ");
            break;
        default:
            Console.WriteLine("Opção inválida!!!");
            break;
    }
    {
        
    }
}