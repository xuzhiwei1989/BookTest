using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book5._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str1 = "abcd";
            //string str2 = "abcd";
            //object obj1 = str1;
            //object obj2 = str2;
            //Console.WriteLine(obj1.Equals(obj2));
            //Console.WriteLine(str1 == obj1);
            string str1 = "123456789";
            char[] ch = str1.ToCharArray();
            Array.Reverse(ch);            
            string str2 = new string(ch);
            Console.WriteLine(str2);
        }
    }
}
