using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBanco
{
    public class Principal
    {
        public string Nombre;
        public string Apellido;
        public int saldo;

        public void depositar() 
        {
            Console.WriteLine("ingrese el valor a depositar");
        }
        public void retirar () 
        {
            Console.WriteLine("ingrese el valor a retirar");
        }
        public void consultar () 
        {
            Console.WriteLine($"su saldo es {this.saldo}");
        }

    }
}
