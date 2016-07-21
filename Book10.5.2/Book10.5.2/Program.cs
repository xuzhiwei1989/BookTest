using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book10._5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.Radius = 6;
            Console.WriteLine(circle.Area());
        }

        public class Circle : ACircle
        {
            public override double Area()
            {
                //throw new NotImplementedException();
                return Pi * Radius * Radius;
            }
        }

        public abstract class ACircle
        {
            private double _radius;
            private const double _pi = 3.14;

            public double Radius
            {
                get { return _radius; }
                set { _radius = value; }
            }

            public double Pi
            {
                get { return _pi; }
            }

            public abstract double Area();
        }
    }
}
