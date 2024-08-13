using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista
{
    public class mate
    {
        public int num1;
        public int num2;
        public void pedirnumeros() 
        {
            Console.WriteLine("ingrese un numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro numero");
            num2 = int.Parse(Console.ReadLine());


        }
    }
}
