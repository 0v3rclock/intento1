using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace clase317
{
    public class Matematica
    {
        public int n0;
        public int n1;

       public void IngreseNumeros() 
       {
            Console.WriteLine("ingrese un numero");
            n0 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro numero");
            n1 = int.Parse(Console.ReadLine());
       }
        public int Suma () 
        { 
            return this.n0 + this.n1; 
        }
        public int Sumar () 
        {
            return this.n0 + this.n1;
        }
        
           
            
        }
         
    }

