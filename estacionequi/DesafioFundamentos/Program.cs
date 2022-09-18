using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Seja bem vindo(a) ao sistema de estacionamento ESTACIONEQUI");

Console.ResetColor();
Console.WriteLine("Digite o preço inicial:");
decimal.TryParse(Console.ReadLine(), out precoInicial);

Console.WriteLine("Agora digite o preço por hora:");
decimal.TryParse(Console.ReadLine(), out precoPorHora);

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
var estacionamento = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("      ESTACIONEQUI");
    Console.WriteLine(@"        _______
       //  ||\ \
 _____//___||_\ \___
 )  _          _    \
 |_/ \________/ \___|
___\_/________\_/______");
    Console.ResetColor();
    Console.Write($"\n--> Preço inicial/base: ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"{precoInicial:C}");

    Console.ResetColor();
    Console.Write($"\n--> Preço por hora: ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"{precoPorHora:C}");

    Console.ResetColor();
    Console.WriteLine($"\n--> Carros estacionados: {estacionamento.QuantidadeDeVeiculos}");

    Console.WriteLine("\n\nDigite a sua opção:");
    Console.WriteLine("0 - Cancelar/Sair");
    Console.WriteLine("1 - Cadastrar veículo");
    if (estacionamento.QuantidadeDeVeiculos > 0)
    {
        Console.WriteLine("2 - Encerrar com veículo");
        Console.WriteLine("3 - Listar veículos");
    }
    Console.WriteLine("");

    switch (Console.ReadLine())
    {
        case "1":
            estacionamento.AdicionarVeiculo();
            break;

        case "2":
            if (estacionamento.QuantidadeDeVeiculos > 0)  estacionamento.RemoverVeiculo();
            break;

        case "3":
            if (estacionamento.QuantidadeDeVeiculos > 0) estacionamento.ListarVeiculos();
            break;

        case "0":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
