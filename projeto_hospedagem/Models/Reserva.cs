namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count)
                Hospedes = hospedes;
            else
                throw new Exception($"A quantidade de hospedes ({Suite.Capacidade}) excede a capacidade da suite ({hospedes.Count})");
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes() => Hospedes.Count;

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10) valor = AplicarDesconto(valor, percentualDesconto: 10);
            return valor;
        }

        private decimal AplicarDesconto(decimal valor, decimal percentualDesconto)
        {
            return valor - (valor * (percentualDesconto / 100));
        }
    }
}