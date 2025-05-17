using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jo_Ken_Po
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> certos = new List<int>();
            int acertos = 0;
            List<int> errados = new List<int>();
            int erros = 0;
            List<int> empate = new List<int>();
            int empates = 0;
            List<string> opcoes = new List<string>();
            opcoes.Add("Pedra");
            opcoes.Add("Papel");
            opcoes.Add("Tesoura");
            int jogadorInt = 0;
            bool continuar = false;
            while (!continuar)
            {
                Console.WriteLine("Escolha uma opção: [1 = Pedra]  [2 = Papel]  [3 = Tesoura");
                Console.WriteLine("Digite [0] para sair do jogo\n");
                bool escolhaValida = false;
                do 
                {
                    string jogador = Console.ReadLine();
                    if (int.TryParse(jogador, out jogadorInt))
                    {
                        if (jogadorInt >= 0 && jogadorInt <= 3)
                        {
                            escolhaValida = true;
                        }
                        else
                        {
                            Console.WriteLine("Escolha inválida. Tente novamente.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Escolha inválida. Tente novamente.");
                    }
                } while (!escolhaValida);
                if (jogadorInt == 0)
                {
                    continuar = true;
                    break;
                }
                int computador = random.Next(1, 4);
                if (computador == jogadorInt)
                {
                    Console.WriteLine("\nEmpate");
                    Console.WriteLine($"Você escolhe {opcoes[jogadorInt - 1]}");
                    Console.WriteLine($"O Computador escolheu {opcoes[computador - 1]}\n");
                    empate.Add(jogadorInt);
                    empates++;
                }
                else if (jogadorInt == 1 && computador == 2 || jogadorInt == 2 && computador == 3 || jogadorInt == 3 && computador == 1)
                {
                    Console.WriteLine("\nVocê perdeu!");
                    Console.WriteLine($"Você escolhe {opcoes[jogadorInt - 1]}");
                    Console.WriteLine($"O Computador escolheu {opcoes[computador - 1]}\n");
                    errados.Add(jogadorInt);
                    erros++;
                }
                else
                {
                    Console.WriteLine("\n\nVocê Ganhou!!!!!!\n");
                    Console.WriteLine($"Você escolhe {opcoes[jogadorInt - 1]}");
                    Console.WriteLine($"O Computador escolheu {opcoes[computador - 1]}\n");
                    certos.Add(jogadorInt);
                    acertos++;
                }
                    escolhaValida = false;
            }
            
            Console.WriteLine();
            Console.WriteLine("================================================================================================================================================================================================");
            Console.WriteLine();
            Console.WriteLine($"Você ganhou {acertos} veze(s)");
            Console.WriteLine("Com as escolha(s): ");
            foreach (int c in certos)
            {
                Console.WriteLine($"{opcoes[c-1]};");
            }
            Console.WriteLine($"\nVocê empatou {empates} veze(s)");
            Console.WriteLine("Com as escolha(s): ");
            foreach (int e in empate)
            {
                Console.WriteLine($"{opcoes[e - 1]};");
            }
            Console.WriteLine($"\nVocê perdeu {erros} veze(s)");
            Console.WriteLine("Com as escolha(s): ");
            foreach (int er in errados)
            {
                Console.WriteLine($"{opcoes[er - 1]};");
            }
            Console.ReadLine();
        }
    }
}
