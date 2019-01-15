using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMultiplosDeTres
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int numero = 0; numero <= 100; numero++)
            {
                if(numero % 3 == 0)
                {
                    Console.WriteLine("O numero " + numero + " é multiplo de 3");
                }
            }

            Console.ReadLine();
        }
    }
}
