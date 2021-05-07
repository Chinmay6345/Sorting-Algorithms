using System;
using System.Linq;

namespace Counting_Sort
{
    public static class AppHelper
    {
        /// <summary>
        /// Time Complexity O(n+k)
        /// Space Complexity O(n+k)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static Int32 [] CSort(Int32 [] arr)
        {
            Int32 n = arr.Length;
            Int32 k = n - 1;
            Int32 [] count = new Int32[k];
            for(Int32 i=0;i<n;i++)
            {
                count[arr[i]]++;
            }
            for(Int32 i=1;i<k;i++)
            {
                count[i] = count[i - 1] + count[i];
            }
            Int32[] output = new Int32[n];
            for(Int32 i=n-1;i>=0;i--)
            {
                output[count[arr[i]] - 1] = arr[i];
                count[arr[i]]--;
            }
            for(Int32 i=0;i<n;i++)
            {
                arr[i] = output[i];
            }
            return arr;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Int32[] arr = { 1, 4, 4, 1, 0, 1, 2 };
            Console.WriteLine(String.Join(",", AppHelper.CSort(arr).Select(g => g)));
            Console.ReadLine();
        }
    }
}
