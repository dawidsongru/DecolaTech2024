//
// Sistema de Estacionamento em C#
// Autor: Dawidson Pereira
// Data: 09/01/2024
//
namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0M, precoPorHora = 0M;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            // this.precoInicial = Math.Round(precoInicial, 2);     // Se desejar arredondar valores
            // this.precoPorHora = Math.Round(precoPorHora, 2);     
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine().Trim().ToUpper();
            veiculos.Add(placa);
            Console.WriteLine($"Veículo {placa} estacionado com sucesso.");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine().Trim().ToUpper();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // Salvando a cultura atual
                var currentCulture = System.Threading.Thread.CurrentThread.CurrentCulture;

                try
                {
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("pt-BR");

                    decimal horas;

                    while (!decimal.TryParse(Console.ReadLine(), out horas) || horas < 0)
                    {
                        Console.WriteLine("Digite um número inteiro para a quantidade de horas (maior ou igual a zero):");
                    }

                    decimal valorTotal = Math.Round(precoInicial + (precoPorHora * horas), 2);
                    veiculos.Remove(placa);

                    Console.WriteLine($"O veículo com placa {placa} foi removido e o preço total a pagar é de {valorTotal:C2}");
                }
                finally
                {
                    // Restaurando a cultura original
                    System.Threading.Thread.CurrentThread.CurrentCulture = currentCulture;
                }
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine(veiculos.Any() ? "Os veículos estacionados são:" : "Não há veículos estacionados.");
                foreach (string placa in veiculos)
                {
                    Console.WriteLine(placa);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}