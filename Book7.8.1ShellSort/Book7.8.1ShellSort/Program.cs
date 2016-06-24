using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book7._8._1ShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pro = new Program();
            int[] arr = { 1, 8, 9, 4, 3, 6, 2, 10, 70, 5, 90, 40, 0, 100, 43 };
            //int[] res = pro.ShellSort(arr, arr.Length);
            pro.Sort(arr, arr.Length);
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public void Sort(int[] arr, int d)
        {
            //int d = arr.Length / 2;
            //while (d >= 1)
            //{
            //    ShellInsertSort(arr, d);
            //    d = d / 2;
            //}
            if (d < 1)
            {
                return;
            }

            ShellSort(arr, d);
            Sort(arr, d / 2);
        }

        public void ShellSort(int[] arr,int d)
        {
            //int[] res = arr;
            for (int i = d; i < arr.Length; i++)
            {
                if (arr[i] < arr[i - d])
                {
                    int j = i - d;
                    int x = arr[i];
                    while (j >= 0 && x < arr[j])
                    {
                        arr[j + d] = arr[j];
                        j -= d;
                    }
                    arr[j + d] = x;
                }
            }

            //return res;
        }
    }
}
