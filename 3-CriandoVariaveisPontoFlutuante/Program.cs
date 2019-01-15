using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Projeto 3---------");

            double salario;
            salario = 1002.23;

            Console.WriteLine(salario);

            salario = 100;
            Console.WriteLine(salario);

            /*O valor de resutado será o mesmo tipo da expressão que está do lado esquerdo*/
            double idade;
            idade = 15 / 2;
            Console.WriteLine("15 / 2 = " + idade);

            /*Para termos um valor com casa decimal, necessita-se trocar a expressão da exquerda para um numero com casa decimal*/
            idade = 15.0 / 2;
            Console.WriteLine("15.0 / 2 = " + idade);

            Console.WriteLine("");
            Console.WriteLine("Get Out Here!!!!");
            Console.ReadLine();
;
        }
    }
}
