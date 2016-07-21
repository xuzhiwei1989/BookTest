using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book10._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Length = 20;
            rectangle.Width = 10;
            Console.WriteLine(rectangle.Area());

            iRectangle inRectangle = rectangle;
            Console.WriteLine(inRectangle.Area());
            inRectangle.Width = 20;
            Console.WriteLine(inRectangle.Area());
            Console.WriteLine(rectangle.Area());
        }

        public class Rectangle : iRectangle
        {
            public double Length { get; set; }
            public double Width { get; set; }

            public double Area()
            {
                return Length * Width;
            }
        }

        public interface iRectangle
        {
            double Length { get; set; }
            double Width { get; set; }

            double Area();
        }
    }
}
