using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace aprendendo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jogador = " ";
            int jogadorInt = 0;
            bool entradaValida = false;
            Random random = new Random();
            List<int> certo = new List<int>();
            List<int> errado = new List<int>();
            
            while (true)
            {
                while (!entradaValida)
                {
                    Console.Write("Digite um número entre 0 e 10 (-1 para sair): ");
                    jogador = Console.ReadLine();
                    if (int.TryParse(jogador, out jogadorInt))
                    {
                        if (jogadorInt >= -1 && jogadorInt <= 10)
                        {
                            entradaValida = true;
                        }
                        else
                        {
                            Console.WriteLine("\nNúmero ínvalido, tente novamente");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nNúmero ínvalido, tente novamente");
                    }
                        

                    
                }
                jogadorInt = int.Parse(jogador);
                int numSecreto = random.Next(0, 10);
                if (jogadorInt == numSecreto)
                {
                    Console.WriteLine($"\nParabéns! Você acertou o número secreto: {numSecreto}\n");
                    certo.Add(jogadorInt);
                }
                else
                {
                    Console.WriteLine($"\nVocê errou! O número secreto era: {numSecreto}\n");
                    errado.Add(jogadorInt);
                }
                if (jogadorInt == -1)
                {
                    Console.WriteLine("\nSaindo do jogo...");
                    break;
                }

                entradaValida = false;
                jogador = " ";

            }

            Console.WriteLine($"\nVocê jogou {certo.Count + errado.Count} vezes.");
            Console.WriteLine("\nNúmeros certos: ");
            foreach (int num in certo)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("\nNúmeros errados: ");
            foreach (int num in errado)
            {
                Console.Write($"{num}, ");
            }
            Console.ReadLine();
        }
    }
}
