using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book4._5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine(++x);
            Console.WriteLine(x++);
            Console.WriteLine(x);

            Console.WriteLine(++x + 1 + 2);
            Console.WriteLine(1 + 2 + x++);
            Console.WriteLine(1 + 2 + x);
        }
    }
}
