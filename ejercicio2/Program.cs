using System;
using System.Threading;

namespace CalculadoraBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pedir el primer número al usuario
            Console.Write("Ingrese el primer número: ");
            double numero1 = double.Parse(Console.ReadLine());

            // Pedir el segundo número al usuario
            Console.Write("Ingrese el segundo número: ");
            double numero2 = double.Parse(Console.ReadLine());

            // Realizar las operaciones básicas
            Console.WriteLine("\nSuma: {0} + {1} = {2}", numero1, numero2, numero1 + numero2);
            Console.WriteLine("Resta: {0} - {1} = {2}", numero1, numero2, numero1 - numero2);
            Console.WriteLine("Multiplicación: {0} * {1} = {2}", numero1, numero2, numero1 * numero2);
            Console.WriteLine("División: {0} / {1} = {2}", numero1, numero2, numero1 / numero2);
            Console.WriteLine("Modulo: {0} % {1} = {2}", numero1,numero2, numero1 % numero2);
            Console.WriteLine($"{numero1}<{numero2} es {numero1 < numero2}");

            // Pausar la ejecución por 2 segundos
            Thread.Sleep(2000); // Pausa por 2 segundos (2000 milliseconds)

            // Mensaje para indicar que se puede continuar
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
