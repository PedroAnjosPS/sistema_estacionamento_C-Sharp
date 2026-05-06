using sistemaEstacionamento_C_Sharp.Models;

int opcao = 0;

do
{
    Console.Write("Digite a sua opção: " +
            "\n1 - Cadastrar veículo" +
            "\n2 - Remover veículo" +
            "\n3 - Listar veículos" +
            "\n4 - Encerrar" +
            "\nResposta: ");

    opcao = int.Parse(Console.ReadLine());


} while (true);