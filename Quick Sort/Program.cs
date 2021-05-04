using System;

namespace Quick_Sort
{
    public static class AppHelper
    {
        public static void QSort(ref Int32[] arr, Int32 low, Int32 high)
        {
            if (low < high)
            {
                Int32 p = Partition(ref arr, low, high);
                QSort(ref arr, low, p - 1);
                QSort(ref arr, p + 1, high);
            }
        }
        public static Int32 Partition(ref Int32[] arr, Int32 low, Int32 high)
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
        }
    }
}
