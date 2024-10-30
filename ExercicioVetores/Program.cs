using System;
using System.Numerics;

namespace ExercicioVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Cadastro[] vetor = new Cadastro[10]; // cria um vetor chamado cadastro com 10 variaveis
            
            Console.Write("Quantos quartos vão ser alugados: ");// é mostrado no console uma mensagem
            int n = int.Parse(Console.ReadLine()); // é criado uma variável int chamada m
            Console.WriteLine();
  
            for (int i = 1; i <= n; i++) // o int i vale 1, se int for menor ou igual a n faça e é adicionado+1 na variavel i
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
