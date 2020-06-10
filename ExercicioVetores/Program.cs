using System;
using System.Numerics;

namespace ExercicioVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Cadastro[] vetor = new Cadastro[10]; // Vetor com 10 posições
            
            Console.Write("Quantos quartos vão ser alugados: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
  
            for (int i = 1; i <= n; i++)
            {
               
                Console.WriteLine($"Aluguel: {i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vetor[quarto] = new Cadastro(nome, email);
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine($"Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] != null)
                {
                    Console.WriteLine(i + ": " + vetor[i]);
                }
            }          
        }
    }
}
