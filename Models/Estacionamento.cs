using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaEstacionamento_C_Sharp.Models
{
    /// <summary>
    /// Representa um modelo de estacionamento da vida real
    /// </summary>
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            string placa = "";

            // Valida o a máscara (o formato do conteúdo) e caracteres permitidos na placa do veículo
            do
            {
                Console.Clear();
                Console.Write("\nDigite a placa do veículo para estacionar: ");
                placa = Console.ReadLine().ToUpper();

                if (placa.Length != 8 || !placa.Contains("-"))
                {
                    Console.WriteLine("Formato de placa de veículo incorreto! Digite novamente!");
                    Thread.Sleep(1000);
                }
            } while (placa.Length != 8 || !placa.Contains("-"));

            veiculos.Add(placa);

            Console.WriteLine("Veículo estacionado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            string placa = string.Empty;

            // Valida o a máscara (o formato do conteúdo) e caracteres permitidos na placa do veículo
            do
            {
                Console.Clear();
                Console.Write("\nDigite a placa de um carro estacionado: ");
                placa = Console.ReadLine().ToUpper();

                if (placa.Length != 8 || !placa.Contains("-"))
                {
                    Console.WriteLine("Formato de placa de veículo incorreto! Digite novamente!");
                    Thread.Sleep(1000);
                }
            } while (placa.Length != 8 || !placa.Contains("-"));

            // verifica se existe a placa de veículo informada pelo usuário no estacionamento 
            if (veiculos.Contains(placa))
            {
                Console.Write("\nDigite a quantidade de horas que o veículo permaneceu estacionado: ");
                int horas = Convert.ToInt32(Console.ReadLine());

                decimal valorTotal = precoInicial + precoPorHora * horas;

                // Removendo a placa do veículo estacionado
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo de placa {placa} foi removido do estacionamento. O preço total foi de R$ {valorTotal:F2}!");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui.");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há algum conteúdo dentro da lista de veículos
            if (veiculos.Any())
            {
                Console.WriteLine("\nVeículos estacionados:");
                int i = 1;

                foreach (string veic in veiculos)
                {
                    Console.WriteLine(i + " - " + veic);
                    i++;
                }
            }
            else
            {
                Console.WriteLine("\nNão há veículos estacionados!");
            }
        }

    }
}