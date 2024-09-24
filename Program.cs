using System;
using System.Collections.Generic;
using System.Text;
using DesafioProjetoHospedagem.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Cria os modelos de hóspedes
        List<Pessoa> hospedes = new List<Pessoa>();

        // Pergunta ao usuário quantos hóspedes
        Console.WriteLine("Quantos hóspedes você deseja cadastrar?");
        int quantidadeHospedes = int.Parse(Console.ReadLine());

        for (int i = 1; i <= quantidadeHospedes; i++)
        {
            Console.WriteLine($"Nome do hóspede {i}:");
            string nome = Console.ReadLine();
            hospedes.Add(new Pessoa(nome));
        }

        // Cria a suíte
        Console.WriteLine("Digite o tipo da suíte:");
        string tipoSuite = Console.ReadLine();
        Console.WriteLine("Digite a capacidade da suíte:");
        int capacidade = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor da diária:");
        decimal valorDiaria = decimal.Parse(Console.ReadLine());

        Suite suite = new Suite(tipoSuite, capacidade, valorDiaria);

        // Pergunta quantos dias reservados
        Console.WriteLine("Quantos dias a reserva será realizada?");
        int diasReservados = int.Parse(Console.ReadLine());

        // Cria uma nova reserva
        Reserva reserva = new Reserva(diasReservados);
        reserva.CadastrarSuite(suite);
        
        try
        {
            reserva.CadastrarHospedes(hospedes);
            // Exibe a quantidade de hóspedes e o valor da diária
            Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
