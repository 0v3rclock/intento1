    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace @while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 10;
            do
            {
                Console.WriteLine(num2--);
                
            }
            while (num2 >= num1);
            Thread.Sleep(2500);
        }
    }
}
