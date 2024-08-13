using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<estudiante> listEs = new List<estudiante>();
            listEs.Add(new estudiante(5, 4, "Jose", 18));
            listEs.Add(new estudiante(2, 1, "laura", 17));
            listEs.Add(new estudiante(3, 2, "Alejandro", 32));
            listEs.Add(new estudiante(1, 3, "paul", 27));
            foreach (estudiante i in listEs)
            {
                bool esMayor = i.calcular_edad();
                if (!esMayor) 
                {
                    i.imprimirDatos();
                }

                
                    //Console.WriteLine(i.calcular_edad());
                
            }
            Thread.Sleep(5000);
            Console.ReadKey();
        }
    }
}
