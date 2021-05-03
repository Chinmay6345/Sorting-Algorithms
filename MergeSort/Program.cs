using System;
namespace MergeSort
{
    public static class AppHelper
    {
        public static void IMergeSort(int[] A, int n)
        {
            int p, l, h, mid, i;
            for (p = 2; p <= n; p = p * 2)
            {
                for (i = 0; i + p - 1 < n; i = i + p)
                {
                    l = i;
                    h = i + p - 1;
                    mid = (l + h) / 2; merge(A, l, mid, h);
                }
                if (n - i > p / 2)
                {
                    l = i;
                    h = i + p - 1;
                    mid = (l + h) / 2;
                    merge(A, l, mid, n - 1);
                }
            }
            if (p / 2 < n)
            {
                merge(A, 0, p / 2 - 1, n - 1);
            }
            int x = 1;
        }


        public static void merge(int[] A, int l, int mid, int h)
        {
            int i = l, j = mid + 1, k = l;
            int[] B = new int[100];
            while (i <= mid && j <= h)
            {
                if (A[i] < A[j])
                    B[k++] = A[i++];
                else
                    B[k++] = A[j++];
            }
            for (; i <= mid; i++)
                B[k++] = A[i];
            for (; j <= h; j++)
                B[k++] = A[j];
            for (i = l; i <= h; i++)
                A[i] = B[i];
        }
    }

    public static class Util
    {
        /// <summary>
        /// Time Complexity O(nlogn)
        /// Space Complexity O(nlogn)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        public static void mergeSort(ref int[] arr, int l, int r)
        {
            if (r > l)
            {
                int m = l + (r - l) / 2;
                mergeSort(ref arr, l, m);
                mergeSort(ref arr, m + 1, r);
                merge(ref arr, l, m, r);
            }
        }


        /// <summary>
        /// Time Complexity O((m+n)logn)
        /// Space Complexity O((m+n)logn)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        public static void merge(ref int[] arr, int l, int m, int h)
        {

            int n1 = m - l + 1, n2 = h - m;
            int[] left = new int[n1]; int[] right = new int[n2];
            for (int x = 0; x < n1; x++)
                left[x] = arr[x + l];
            for (int y = 0; y < n2; y++)
                right[y] = arr[m + 1 + y];

            int i = 0, j = 0, k = l;
            while (i < n1 && j < n2)
            {
                 if (left[i] <= right[j])
                    arr[k++] = left[i++];
                else
                    arr[k++] = right[j++];
            }
            while (i < n1)
                arr[k++] = left[i++];
            while (j < n2)
                arr[k++] = right[j++];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Int32[] arr = { 8, 5, 2, 9, 5, 6, 3 };
            Util.mergeSort(ref arr,0, arr.Length-1);
            Console.ReadLine();
        }
    }
}
