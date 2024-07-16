using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace intento1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese su nombre: ");
                string NombreA = Console.ReadLine();
            Console.Write("ingrese su edad: ");
            int EdadA = Console.Read();
            Console.WriteLine("ingrese una letra: ");
            char letra1 = (char)Console.Read();
            Console.WriteLine("ingrese un valor decimal: ");
            double dec_1 = (double)Console.Read();
            Console.WriteLine("ingrese un numero: ");
            int numeroal = Console.Read();
            /*int numero77 = 85;
            int numero12 = 17;
            int auxiliar = 0;
            */
            //auxiliar = numero77;
            //numero12 = auxiliar;
            //Console.WriteLine(auxiliar);
            Thread.Sleep(2000);
            Console.WriteLine("pulse una tecla para finalizar el programa...");
            Console.ReadKey();
            
            
        }
    }
}
