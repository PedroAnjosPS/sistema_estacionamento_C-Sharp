using sistemaEstacionamento_C_Sharp.Models;

// Coloca o enconding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.Write("\n======== BEM VINDO AO SISTEMA DE ESTACIONAMENTO! ========\n"
                + "\nDigite o preço inicial: ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.Write("Agora digite o preço por hora: ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento já com os valores inseridos anteriormente
Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);
string opcao = string.Empty;
bool exibirMenu = true;

do
{
    Console.Clear();
    Console.Write("Digite a sua opção: " +
            "\n1 - Cadastrar veículo" +
            "\n2 - Remover veículo" +
            "\n3 - Listar veículos" +
            "\n4 - Encerrar" +
            "\nResposta: ");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            estacionamento.AdicionarVeiculo();
            Thread.Sleep(1700);
            break;

        case "2":
            estacionamento.RemoverVeiculo();
            Thread.Sleep(1700);
            break;

        case "3":
            estacionamento.ListarVeiculos();
            Console.Write("\nPressione qualquer tecla para prosseguir a execução do programa:");
            opcao = Console.ReadLine();
            break;

        case "4":
            exibirMenu = false;
            Console.WriteLine("\nSaindo do sistema...");
            Thread.Sleep(1700);
            break;

        default:
            Console.WriteLine("\nOpção inválida!");
            Thread.Sleep(1700);
            break;    
    }


} while (exibirMenu);