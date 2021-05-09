using System;
using System.Linq;
namespace Quick_Sort
{
    public static class AppHelper
    {
        /// <summary>
        /// worst case TC O(n*n)
        /// Best case TC O(nlogn)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        public static void QSort_Lomuto(ref Int32[] arr, Int32 low, Int32 high)
        {
            if (low < high)
            {
                Int32 p = LPartition(ref arr, low, high);
                QSort_Lomuto(ref arr, low, p-1);
                QSort_Lomuto(ref arr, p + 1, high);
            }
        }

        /// <summary>
        /// worst case TC O(n*n)
        /// Best case TC O(nlogn)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        public static void QSort_Hoare(ref Int32[] arr, Int32 low, Int32 high)
        {
            if (low < high)
            {
                Int32 p = HPartition(ref arr, low, high);
                QSort_Hoare(ref arr, low, p);
                QSort_Hoare(ref arr, p + 1, high);
            }
        }

        public static Int32 LPartition(ref Int32[] arr, Int32 low, Int32 high)
        {
            Int32 i = low - 1;
            Int32 pivot = arr[high];
            for (Int32 j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(ref arr, i, j);
                }
            }
            Swap(ref arr, i + 1, high);
            return i + 1;
        }

        public static Int32 HPartition(ref Int32 [] arr,Int32 low,Int32 high)
        {
            Int32 pivot = arr[low];
            Int32 i = low - 1;
            Int32 j = high + 1;
            while(true)
            {
                do { i++; } while (arr[i] < pivot);
                do { j--; } while (arr[j] > pivot);
                if (i >= j)
                    return j;
                Swap(ref arr, i, j);
            }
        } 

        public static void Swap(ref Int32[] arr, Int32 i, Int32 j)
        {
            Int32 temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Int32[] arr = { 2, 0, 1, 9, 4, 8 };
            AppHelper.QSort_Hoare(ref arr, 0, arr.Length-1);
            Console.WriteLine(String.Join(" ", arr.Select(g => g)));
            Console.ReadLine();
        }
    }
}
