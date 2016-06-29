using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book8._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Week week = new Week();
            week.Date = 11;
            Console.WriteLine(week.Date);
        }

        public class Week
        {
            private int _date;

            public int Date
            {
                get { return _date; }
                set
                {
                    _date = value > 7 ? 7 : value;
                }
            }
        }
    }
}
