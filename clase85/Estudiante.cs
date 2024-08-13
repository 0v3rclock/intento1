using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase85
{
    public class Estudiante : Persona1
    {
        public int credito;
        public int nivel;
        public Estudiante (int credito, int nivel, string nombre, int edad ) : base(nombre, edad)
        {
            this.credito = credito;
            this.nivel = nivel;
        }
         public void saludar() 
        {
            switch (nivel) 
            {
                case 1: Console.WriteLine($"bienvenido {nombre} al semestre {nivel}");
                    break;
                    case 2: Console.WriteLine($"Bienvenido {nombre} al semestre {nivel}");
                    break;
                    case 3: Console.WriteLine($"bienvenido {nombre} al semestre {nivel}");
                    break;
            }

        }
    }
    
}
