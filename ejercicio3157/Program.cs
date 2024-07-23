using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ejercicio3157
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su estatura en metros: ");
            float estatura = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su peso: ");
            float peso = float.Parse(Console.ReadLine());
            float imc=(float)(peso/Math.Pow(estatura, 2));
            if (imc < 16.5)
            {
                Console.WriteLine("Bajopeso severo");
            }
            else if (imc >= 16.5 && imc < 18.5)
            {
                Console.WriteLine("bajopeso");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("peso normal");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("sobrepeso");
            }
            else if (imc >= 30 && imc < 35)
            {
                Console.WriteLine("obesidad tipo 1");
            }
            else if (imc >= 35 && imc < 40)
            {
                Console.WriteLine("obesidad tipo 2");
            }
            else
            {
                Console.WriteLine("obesidad tipo 3");
            }

            Thread.Sleep(1000);
            Console.WriteLine("pulse una tecla para salir...");
                Console.ReadKey();
        }
    }
}
