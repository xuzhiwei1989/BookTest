using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book8._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            fun();
        }

        static void fun()
        {
            MyClass myClass = new MyClass();
            myClass.fun2();
        }

    }

    public class MyClass
    {
        private void fun1()
        {
            Console.WriteLine("这是一个方法的示例！");
        }

        public void fun2()
        {
            this.fun1();
        }
    }
}
