using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosEstrDados
{
    internal class Program
    {
        static void Exibir(int[,] matriz)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int c = 0; c < 8; c++)
                {
                    Console.Write(matriz[i, c] + " ");
                }
                Console.WriteLine();
            }
        }


        static int[,] Desafio01()
        {
            int[,] tabela = new int[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int c = 0; c < 8; c++)
                {
                    tabela[i, c] = 0;
                }
            }
            for (int i = 0; i < 8; i++)
            {

                tabela[i, 0] = 1;
            }
            return tabela;
        }


        static int[,] Desafio02()
        {
            int[,] tabela = new int[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int c = 0; c < 8; c++)
                {
                    tabela[i, c] = 0;
                }
            }
            for (int i = 0; i < 8; i++)
            {

                tabela[0, i] = 1;
            }
            return tabela;
        }
        

        static int[,] Desafio03()
        {
            int[,] tabela = new int[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int c = 0; c < 8; c++)
                {
                    tabela[i, c] = 0;
                }
            }
            for (int i = 0; i < 8; i++)
            {
                tabela[i, i] = 1;
            }
            return tabela;
        }

        static int[,] Desafio04()
        {
            int[,] tabela = new int[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int c = 0; c < 8; c++)
                {
                    tabela[i, c] = 0;
                }
            }
            for (int i = 0; i < 8; i++)
            {

                tabela[i, 0] = 1;
            }
            for (int i = 0; i < 8; i++)
            {

                tabela[0, i] = 1;
            }
            for (int i = 0; i < 8; i++)
            {

                tabela[i, 7] = 1;
            }
            for (int i = 0; i < 8; i++)
            {

                tabela[7, i] = 1;
            }

            return tabela;

        }

        static int[,] Desafio05()
        {
            int[,] tabela = new int[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int c = 0; c < 8; c++)
                {
                    tabela[i, c] = 0;
                }
            }
            for (int i = 0; i < 8; i++)
            {

                tabela[i, 0] = 1;
            }
            for (int i = 0; i < 8; i++)
            {

                tabela[0, i] = 1;
            }
            for (int i = 0; i < 8; i++)
            {
                tabela[i, i] = 1;
            }
            return tabela;

        }


        static int[,] Desafio06()
        {
            int[,] tabela = new int[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int c = 0; c < 8; c++)
                {
                    tabela[i, c] = 0;
                }
            }
            for (int i = 0; i < 8; i++)
            {
                tabela[i, i] = 1;
            }
            int f = 7;
            for (int i = 0; i < 8; i++)
            {
                
                tabela[f, i] = 1;
                f--;
            }
            return tabela;

        }

        static void Cabeça()
        {
            Console.WriteLine("Desafio 01: Preencher a primeira coluna com 1");
            Console.WriteLine("Desafio 02: Preencher a primeira linha com 1");
            Console.WriteLine("Desafio 03: Preencher a diagonal principal com 1");
            Console.WriteLine("Desafio 04: Preencher a primeira coluna, primeira linha, ultima coluna e ultima linha com 1");
            Console.WriteLine("Desafio 05: Preencher a primeira coluna, primeira linha e diagonal principal com 1");
            Console.WriteLine("Desafio 06: Preencher a diagonal principal e a diagonal secundaria com 1");
        }
        static int VerificarInt()
        {
            while (true)
            {
                string escolha = Console.ReadLine();
                bool sucesso = int.TryParse(escolha, out int numero);
                if (sucesso)
                {
                    if (numero < 0 || numero > 6)
                    {
                        Console.WriteLine("Por favor, digite um número entre 0 e 6.");
                    }
                    else
                    {
                        return numero;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro entre 0 e 6.");
                }
            }
        }

        static void Main(string[] args)
        {
            Cabeça();

            int contador = 0;
            while (true)
            {
                contador++;
                if (contador == 3)
                {
                    Cabeça();
                    contador = 0;
                }
                Console.WriteLine("Escolha o desafio que deseja ver (1-6): ");
                Console.WriteLine("Digite 0 para sair.");

                int escolha = VerificarInt();
                if (escolha == 1)
                {
                    Console.WriteLine();
                    int[,] desafio1 = Desafio01();
                    Exibir(desafio1);
                    Console.WriteLine();
                }
                else if (escolha == 2)
                {
                    Console.WriteLine();
                    int[,] desafio2 = Desafio02();
                    Exibir(desafio2);
                    Console.WriteLine();
                }
                else if (escolha == 3)
                {
                    Console.WriteLine();
                    int[,] desafio3 = Desafio03();
                    Exibir(desafio3);
                    Console.WriteLine();
                }
                else if (escolha == 4)
                {
                    Console.WriteLine();
                    int[,] desafio4 = Desafio04();
                    Exibir(desafio4);
                    Console.WriteLine();
                }
                else if (escolha == 5)
                {
                    Console.WriteLine();
                    int[,] desafio5 = Desafio05();
                    Exibir(desafio5);
                    Console.WriteLine();
                }
                else if (escolha == 6)
                {
                    Console.WriteLine();
                    int[,] desafio6 = Desafio06();
                    Exibir(desafio6);
                    Console.WriteLine();
                }
                if (escolha == 0)
                {
                    Console.WriteLine("Saindo...");
                    break;
                }
            }
        }
    }
}
