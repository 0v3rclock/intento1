using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ejercicio1177
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero a imprimir: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine(i);
            }
            Thread.Sleep(1000);
            Console.WriteLine("Pulse una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
