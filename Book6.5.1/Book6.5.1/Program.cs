using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book6._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a number:");
            string input = Console.ReadLine().Trim();
            int num;
            int.TryParse(input, out num);
            if (num > 6)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("The number is lower than 6....");
            }
        }
    }
}
