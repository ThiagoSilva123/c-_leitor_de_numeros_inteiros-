using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitor_numeros_inteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            int z, ax, i;
            string r;
            i = 0;
            z = 0;

            do
            {
            
                    Console.Write("digite o {0} numero:", i + 1);
                    ax = int.Parse(Console.ReadLine());
         
                if (i == 0)
                {
                    z = ax;
                }
                else
                    if (ax < z)
                {
                    z = ax;
                }
                i++;
                do
                {
                    Console.WriteLine("Deseja continuar? se sim digite (s), caso deseje parar digite (n).");
                    r = Console.ReadLine().ToLower();
                }
                while (r != "s" && r != "n");
            }
            while (r == "s" || r == "S");
            Console.WriteLine("o menor numero é {0}", z);
            Console.ReadKey();
        }
    }
}
