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
                Console.Write("Nome: ");// é mostrado no console de comando uma mensagem "nome"
                string nome = Console.ReadLine();// o usuário digita o nome no console com string

                Console.Write("Email: "); // mesma coisa no console nome
                string email = Console.ReadLine();// o usuario digita o email com string 

                Console.Write("Quarto: "); // é mostrado uma mensagem no console chamada "quarto"
                int quarto = int.Parse(Console.ReadLine()); // é criado uma variavel quarto que é armazenada como string

                vetor[quarto] = new Cadastro(nome, email); // é criado um vetor chamado quarto que armazena os strings de cadastro
                //nome e email
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine($"Quartos ocupados: ");// é mostrado no console uma mensagem chamada "quartos ocupados"
            for (int i = 0; i < 10; i++)// é criado um loop que comeca com int com valor 0, se a variavel for menor que 10 continua o loop
                // e adiciona +1 na variável i
            {
                if (vetor[i] != null) // se o vetor i for igual a null, mostra o valor da variavel i 
                {
                    Console.WriteLine(i + ": " + vetor[i]);
                }
            }          
        }
    }
}
