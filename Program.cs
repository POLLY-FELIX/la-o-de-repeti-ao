using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace laço_de_repetiçao
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int numero = 0;

            //Enquanto a condição for verdadeira, repita
            string resposta = "";

            while (resposta != "sim")
            {
                while (numero <= 1000)
                {
                    Console.WriteLine($"O número é: {numero}");
                    numero++;

                }
                numero = 0;

                Console.WriteLine("deseja para o programa?");
                resposta = Console.ReadLine();
            }
         }
    }
}
