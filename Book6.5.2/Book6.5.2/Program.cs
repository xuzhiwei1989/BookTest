using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book6._5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ball = new int[] { 10, 11, 22, 33, 44, 55, 66, 77, 88, 99 };
            List<int> balls = Test(ball);

            foreach (int i in balls)
            {
                Console.Write(ball[i] + " ");
            }
        }

        public static List<int> Test(int[] ballArray)
        {
            List<int> res = new List<int>();
            Random r = new Random();
            int randomNum;
            //for (int i = 0; i < 5; i++)
            //{
            //    GetRandomNum:
            //        randomNum = r.Next(10);

            //    if (res.Contains(randomNum))
            //    {
            //        goto GetRandomNum;
            //    }
            //    else
            //    {
            //        res.Add(randomNum);
            //    }
            //}
            while (res.Count < 5)
            {
                randomNum = r.Next(10);
                if (!res.Contains(randomNum))
                {
                    res.Add(randomNum);
                }
            }

            return res;
        }
    }
}
