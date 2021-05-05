using System;

namespace Chocolate_distribution_problem
{

    class Program
    {
        /// <summary>
        /// Time complexity O(nlogn)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        private static Int32 CDistribution(Int32 [] arr,Int32 n,Int32 m)
        {
            if (m > n)
                return -1;
            Array.Sort<Int32>(arr);
            Int32 res = arr[m - 1] - arr[0];
            for(Int32 i=1;(i+m-1)<n;i++)
            {
                res = Math.Min(res, (arr[i + m - 1] - arr[i]));
            }
            return res;
        }
        static void Main(string[] args)
        {
            Int32[] arr = { 7, 3, 2, 4, 9, 12, 56 };
            Console.WriteLine(CDistribution(arr, arr.Length, 3));
            Console.ReadLine();
        }
    }
}
