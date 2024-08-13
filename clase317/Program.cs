using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace clase317
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Matematica m = new Matematica();
            m.IngreseNumeros();
            int nsuma1 = m.n0;
            int nsuma2 = m.n1;
            m.Suma();
            m.Sumar();
            Console.WriteLine(m.Sumar());
            Thread.Sleep(2000);
            
        }
    }
}
