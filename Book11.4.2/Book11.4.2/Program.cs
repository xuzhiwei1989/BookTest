using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book11._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 1;
                bool b = true;
                int c = a + b;
                Console.WriteLine(c);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
