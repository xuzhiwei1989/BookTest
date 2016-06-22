using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[]{ 3, 1, 5, 7, 2, 4, 9, 6 };
            InsertSort(arr);
            foreach (int a in arr)
            {
                Console.Write(a);
            }
            Console.WriteLine();
        }

        /**
         * 插入排序法
         * 将一个记录插入到已排序好的有序表中，从而得到一个新，记录数增1的有序表。即：先将序列的第1个记录看成是一个有序的子序列，然后从第2个记录逐个进行插入，直至整个序列有序为止。
         * 要点：设立哨兵，作为临时存储和判断数组边界之用。
        **/
        public static int[] InsertSort(int[] arr)
        {
            if (arr.Length < 2)
            {
                return arr;
            }

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    int temp = arr[i];
                    int j = i - 1;
                    while (j >= 0 && temp < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                    }
                    arr[j + 1] = temp;
                }
            }

            return arr;
        }
    }
}
