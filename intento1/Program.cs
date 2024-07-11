using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("ingrese una letra");
            char letra1 = char.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un valor decimal");
            double dec_1 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero");
            int numeroal = int.Parse(Console.ReadLine());
            int numero77 = 85;
            int numero12 = 17;
            int auxiliar = 0;
            auxiliar = numero77;
            numero12 = auxiliar;
            Console.WriteLine(auxiliar);
            Console.ReadKey();
            
            
        }
    }
}
