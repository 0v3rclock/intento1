using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista
{
    public class persona: mate , operaciones
    {
        public string nombre;
        public int edad;
        public persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public bool calcular_edad()
        {
            if (this.edad < 18)
            {
                return false;
            }
            return true;
        }
        public void imprimirDatos() 
        { Console.WriteLine($"nombre {nombre} edad: {edad}"); }

        public void resta()
        {
            int resta = num1 - num2;
        }

        public void sumar()
        {
            int suma =num1 + num2;
        }
    }
}
