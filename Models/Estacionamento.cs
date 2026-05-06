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
            string veiculo = "";

            do
            {
                Console.Clear();
                Console.Write("\nDigite a placa do veículo para estacionar: ");
                veiculo = Console.ReadLine();

                if (veiculo.Length != 7 || !veiculo.Contains("-"))
                {
                    Console.WriteLine("Formato de placa de veículo incorreto! Digite novamente!");
                    Thread.Sleep(1000);
                }
            } while (veiculo.Length != 7 || !veiculo.Contains("-"));

            veiculos.Add(veiculo);

            Console.WriteLine("Veículo estacionado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            veiculos.Remove("veiculo");
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("\nVeículos estacionados:");
                int i = 1;

                foreach (string veic in veiculos)
                {
                    Console.WriteLine(i + veic);
                }
            }
            else
            {
                Console.WriteLine("\nNão há veículos estacionados.");
            }
        }

    }
}