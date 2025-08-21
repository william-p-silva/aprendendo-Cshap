using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonnavai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string escolhe;
            List<string> DECISAO = new List<string>();
            int dag = 0;
            int dor = 0;
            int semanas = int.Parse(Console.ReadLine());
            for (int i = 0; i < semanas; i++)
            {
                dor = int.Parse(Console.ReadLine());
                dag = int.Parse(Console.ReadLine());
                if (dor + dag > 40 && dag > dor)
                {
                    escolhe = "DAGMAR DECIDE E A NONNA VAI";
                    DECISAO.Add(escolhe);
                }
                else if (dag + dor > 40 && dor > dag)
                {
                    escolhe = "DOROTHY DECIDE E A NONNA VAI";
                    DECISAO.Add(escolhe);
                }
                else if (dag > dor)
                {
                    escolhe = "DAGMAR DECIDE";
                    DECISAO.Add(escolhe);
                }
                else if (dor > dag)
                {
                    escolhe = "DOROTHY DECIDE";
                    DECISAO.Add(escolhe);
                }
            }
            foreach (string d in DECISAO)
            {
                Console.WriteLine(d);
            }
        }
    }
}
