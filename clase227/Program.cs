using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
            bool esPar = num % 2 == 0;
            int ContPar = 0;
            int ContImpar = 0;
            Console.WriteLine("\norden asccendente");
            while (num <=lnuma)
            {
                Console.WriteLine(num++);
            }
            if (esPar)
            {
                ContPar++;
            }
            else
            {
                ContImpar++;
            }
            Console.WriteLine($"\n los numeros pares son {ContPar}, mientras que los impares son {ContImpar}\n");

            Thread.Sleep(2000);
            Console.WriteLine("ingrese un numero alto para base descendente");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero de limite descendente: ");
            int lnumd= int.Parse(Console.ReadLine());
            bool esPar2= num % 2 == 0;
            int Contpar2 = 0;
            int ContImpar2 = 0;
            Console.WriteLine("\norden descendente");
            while (num2 >= lnumd)
            {
                Console.WriteLine(num2--);
            }
            if (esPar2)
            {
                Contpar2++;
            }
            else
            {
                ContImpar2++;
            }
            Console.WriteLine($"\n los numeros pares son {Contpar2}, mientras que los impares son {ContImpar2}\n");
            Thread.Sleep(5000);//pausa el programa por 5 segundos
            

        }
    }
}
