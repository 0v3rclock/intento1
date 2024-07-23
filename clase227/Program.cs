using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace clase227
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero bajo para base ascendente");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("escriba un numero de limite ascendente: ");
            int lnuma = int.Parse(Console.ReadLine());
            Console.WriteLine("\norden asccendente");
            while (num <=lnuma)
            {
                Console.WriteLine("hola" + num++);
            }
            Thread.Sleep(2000);
            Console.WriteLine("ingrese un numero alto para base descendente");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero de limite descendente: ");
            int lnumd= int.Parse(Console.ReadLine());
            Console.WriteLine("\norden descendente");
            while (num2 >= lnumd)
            {
                Console.WriteLine("hola" + num2--);
            }
                    Thread.Sleep(5000);//pausa el programa por 5 segundos
            

        }
    }
}
