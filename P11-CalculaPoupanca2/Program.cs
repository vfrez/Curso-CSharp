using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Projeto 11-------");

            double valorInvestido = 1000;

            for(int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Mes " + contadorMes + " valor final: " + valorInvestido);
            }

            Console.WriteLine("");
            Console.WriteLine("What you doing here?");
            Console.ReadLine();
        }
    
    }
}
