using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Projeto 7 ----------");

            int idadePessoa = 16;
            int quantidadePessoas = 2;

            Console.WriteLine("Idade pessoa? " + idadePessoa);
            if (idadePessoa >= 18)
            {
                Console.WriteLine("Pode passar!!!!!!!!!!, rapido !!!!!");
            }
            else
            {
                if(quantidadePessoas >= 2)
                {
                    Console.WriteLine("Ta com sorte hoje muleke, cágalera pode ir!!!");
                }
                else
                {
                    Console.WriteLine("Cai fora muleke!!!!!!");
                }
            }

            int valor = 10;
            if(valor == 10)
                Console.WriteLine("1 é = a 1");

            Console.WriteLine("1 é = a 101010");

            Console.WriteLine("");
            Console.WriteLine("What you doing here?");
            Console.ReadLine();
        }
    }
}
