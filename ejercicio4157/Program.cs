using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ejercicio4157
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un dia: ");
            string dia= Console.ReadLine().ToLower();

            string mensaje = "";
            switch (dia)
                {
                case "lunes": mensaje = " tiene 5 letras... "; 
                    break;
                case "martes": mensaje = " tiene 6 letras... "; 
                    break;
                case "miercoles": mensaje = " tiene 8 letras... "; 
                    break;
                case "jueves": mensaje = " tiene 6 letras... "; 
                    break;
                case "viernes": mensaje = " tiene 7 letras... ";
                    break;
                case "sabado": mensaje = " tiene 6 letras... ";
                    break;
                case "domingo": mensaje = " tiene 7 letras... ";
                    break;
                default:  mensaje = " no es un dia... "; 
                    break;
            }
            Console.WriteLine(dia + mensaje);
            Thread.Sleep(2000);//pausa el programa por 2 segundo (2000 milisegundos)
            Console.WriteLine("pulse para continuar...");
            Console.ReadKey();
        }
    }
}
