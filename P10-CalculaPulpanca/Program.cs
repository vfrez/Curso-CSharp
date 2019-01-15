using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPulpanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Projeto 10-------");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Rendimento de " + contadorMes + " mês" + valorInvestido);

                //contadorMes += 1;
                contadorMes++;
            }
            //valorInvestido = valorInvestido + valorInvestido * 0.0036;
            //Console.WriteLine("rendimento de 1 mês" + valorInvestido);


            Console.WriteLine("");
            Console.WriteLine("What you doing here?");
            Console.ReadLine();
        }
    }
}
