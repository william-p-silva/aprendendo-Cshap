using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num = 0.0f;
            Apresentação();
            num = float.Parse(Console.ReadLine());
            Operações(num);
        }

        static void Apresentação()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Este programa vai realizar algumas operações matematicas");
            Console.WriteLine("Vamos começar :)");
        }
        static void Operações(float n)
        {
            Console.WriteLine($"O dobro do número {n} é {n * 2}");
            Console.WriteLine($"A metade do número {n} é {n / 2}");
            Console.WriteLine($"O quadrado do número {n} é {n * n}");
            Console.WriteLine($"A raiz quadrada do número {n} é {Math.Sqrt(n)}");
            Console.WriteLine($"10% do número {n} é {n * 0.10}");
        }
    }
}
