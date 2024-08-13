using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista
{
    public class estudiante : persona
    {
        public int credito;
        public int nivel;
        public estudiante(int credito, int nivel, string nombre, int edad) : base(nombre, edad)
        {
            this.credito = credito;
            this.nivel = nivel;
        }
        
    }
}
