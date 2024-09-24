namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() 
        { 
            Hospedes = new List<Pessoa>(); // Inicializa a lista de hóspedes
        }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
            Hospedes = new List<Pessoa>(); // Inicializa a lista de hóspedes
        }

        // Implementado
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Implementado
                throw new Exception("A quantidade de hóspedes excede a capacidade da suíte.");
            }
        }

        // Implementado
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        // Implementado
        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        // Implementado
        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Implementado
            if (DiasReservados >= 10)
            {
                valor -= valor * 0.10m;
            }

            return valor;
        }
    }
}
