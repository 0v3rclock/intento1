using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejerciocio2157
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int numero = int.Parse(Console.ReadLine());
            if (numero > 0)
            {
                Console.WriteLine("numero positivo: " + numero);
            }
            else if (numero < 0)
            {
                Console.WriteLine("numero negativo: " + numero);
            }
            else
            {
                Console.WriteLine("numero cero: " + numero);
            }
            Thread.Sleep(5000);
            Console.WriteLine("Pulse una tecla para finalizar");
            Console.ReadKey();
        }
        
    }
}
