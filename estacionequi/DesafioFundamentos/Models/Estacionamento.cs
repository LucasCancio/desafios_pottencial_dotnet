using System.Numerics;

namespace DesafioFundamentos.Models
{
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

        public int QuantidadeDeVeiculos
        {
            get
            {
                return veiculos.Count;
            }
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = RequisitarPlaca();
            if (string.IsNullOrEmpty(placa) == false)
            {
                if (veiculos.Contains(placa.ToUpper()))
                {
                    Console.WriteLine($"O veiculo {placa} já existe no estacionamento!");
                }
                else
                {
                    Console.WriteLine($"O veiculo {placa} foi adicionado no estacionamento!");
                    veiculos.Add(placa.ToUpper());
                }

            }
        }

        private string RequisitarPlaca()
        {
            var placa = string.Empty;
            bool placaValida;
            do
            {
                placa = Console.ReadLine();
                if (placa == "0") placa = string.Empty;

                placaValida = ValidarPlaca(placa);
                if (placaValida == false) Console.WriteLine("A placa está inválida, por favor digite novamente.");
            } while (placaValida == false);
            return placa;
        }

        private bool ValidarPlaca(string placa) => placa.Trim().Length > 0;

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = RequisitarPlaca();
            if (string.IsNullOrEmpty(placa)) return;

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int.TryParse(Console.ReadLine(), out int horas);
                decimal valorTotal = precoInicial + precoPorHora * horas;
                veiculos.Remove(placa.ToUpper());
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
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
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos) Console.WriteLine(veiculo);
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
