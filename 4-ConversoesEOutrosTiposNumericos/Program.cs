using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {

            double salario;
            salario = 1200.50;

            /*Realizar Cast de uma variável*/
            int salarioInteiro;
            salarioInteiro = (int)salario;
            Console.WriteLine(salarioInteiro);

            /*int 32 bits long 64 bits short16 bits*/
            long idade;
            idade = 13000000000000;
            Console.WriteLine(idade);

            /*float tem que ter o sulfixo f, pois não é muito usado*/
            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.WriteLine("");
            Console.WriteLine("Un Forastero!!!!");
            Console.ReadLine();
        }
    }
}
