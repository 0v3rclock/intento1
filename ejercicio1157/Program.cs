using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ejercicio1157
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su edad: ");
            int Edad =int.Parse(Console.ReadLine());
            if (Edad >= 40)//condicion 1
            {
                Console.WriteLine("Usted es de tercera edad");
            }//cierre de condicion 1
            else if (Edad >= 18)//condicion 2
            {
                Console.WriteLine("Usted es mayor de edad");
            }//cierre de condicion 2
            else //condicion 3
            {
                Console.WriteLine("Usted es menor de edad");
            }//cierre de condicion 3
            Thread.Sleep(2000);//pausar el programa por 2000 milisegundos
            Console.WriteLine("Pulse una tecla para finalizar...");
            Console.ReadKey();
        }//llave cierre funcion
    }//llave cierre clase interna
}//llave cierre solucion
