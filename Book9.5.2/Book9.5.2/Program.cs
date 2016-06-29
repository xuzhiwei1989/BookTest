using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book9._5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle2 rect = new Rectangle2();
            Rectangle1 rect1 = (Rectangle1)rect;
            double length, width;
            Console.Write("请输入矩形的长：");
            double.TryParse(Console.ReadLine().Trim(), out length);
            Console.Write("请输入矩形的宽：");
            double.TryParse(Console.ReadLine().Trim(), out width);

            rect.Length = length;
            rect.Width = width;
            Console.WriteLine("该矩形的面积为：" + rect.Area());
            Console.WriteLine("该矩形的面积为：" + rect1.Area());
        }

        public class Rectangle2 : Rectangle1
        {
            //如果为virtual和overide，则基类与派生类输出结果一致
            //public override double Area()
            //{
            //    return Length * Width;
            //}

            public new double Area()
            {
                return Length * Width;
            }
        }

        public class Rectangle1
        {
            double _length = 0.0;
            double _width = 0.0;

            public double Length
            {
                get { return _length; }
                set { _length = value; }
            }

            public double Width
            {
                get { return _width; }
                set { _width = value; }
            }

            public double Area()
            {
                return 50;
            }
        }
    }
}
