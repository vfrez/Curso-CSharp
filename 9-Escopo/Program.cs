using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Projeto 8 ----------");

            int idadePessoa = 16;
            //int quantidadePessoas = 2;
            //bool acompanhado = quantidadePessoas >= 2;
            bool acompanhado = true; ;
            string mensagemAdic;

            if (acompanhado == true)
            {
                mensagemAdic = "TaCagalera";
            }
            else
            {
                mensagemAdic = "Alone";
            }                

            Console.WriteLine("Idade pessoa? " + idadePessoa);
            if (idadePessoa >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode passar!!!!!!!!!!, rapido !!!!!");
                Console.WriteLine(mensagemAdic);
            }
            else
            {
                Console.WriteLine("Cai fora muleke!!!!!!");
                Console.WriteLine(mensagemAdic);
            }


            Console.WriteLine("");
            Console.WriteLine("");

            int valor = 10;
            if (valor == 10)
                Console.WriteLine("1 é = a 1");

            Console.WriteLine("1 é = a 101010");

            Console.WriteLine("");
            Console.WriteLine("What you doing here?");
            Console.ReadLine();
        }
    }
}
