﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
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

            Console.WriteLine("Idade pessoa? " + idadePessoa);
            if (idadePessoa >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode passar!!!!!!!!!!, rapido !!!!!");
            }
            else
            {
                Console.WriteLine("Cai fora muleke!!!!!!");
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
