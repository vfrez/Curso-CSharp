using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETexto
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----------------Projeto 5----------------");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine("(char)65 - " + primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine("(char)(primeiraLetra + 1) - " + primeiraLetra);

            string titulo = "Teste do teste que se é testado quando se esta testanto algum teste";
            /*para poder usar string com quebra de linha, usa-se o @ antes do texto*/
            Console.WriteLine(titulo);

            string cursosProgramacao = 
@"Linha 1
- Linha 2
- Linha 3";
            Console.WriteLine(cursosProgramacao);


            



            Console.WriteLine("");
            Console.WriteLine("Un Forastero!!!!");
            Console.ReadLine();
        }
    }
}
