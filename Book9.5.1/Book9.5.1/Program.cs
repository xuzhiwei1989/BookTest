using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book9._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入圆形的半径：");
            string str = Console.ReadLine().Trim();
            Circle circle = new Circle();
            double radius = 0.0;
            double.TryParse(str, out radius);
            circle.Radius = radius;
            Console.WriteLine("该圆形的面积为：" + circle.Area());
        }

        public struct Circle
        {
            private double r;
            public double Radius
            {
                get { return r; }
                set { r = value; }
            }

            Circle(double radius)
            {
                r = radius;
            }

            public double Area()
            {
                return 3.14 * r * r;
            }
        }
    }
}
