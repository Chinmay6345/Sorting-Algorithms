namespace Heap_Sort
{

    public static class AppHelper
    {
        public static void BuildHeap(ref int[] arr, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(ref arr, n, i);
        }
        public static void sort(ref int[] arr)
        {
            int n = arr.Length;

            BuildHeap(ref arr, n);

            for (int i = n - 1; i > 0; i--)
            {

                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                heapify(ref arr, i, 0);
            }
        }
        public static void heapify(ref int[] arr, int n, int i)
        {
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if (l < n && arr[l] > arr[largest])
                largest = l;

            if (r < n && arr[r] > arr[largest])
                largest = r;

            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                heapify(ref arr, n, largest);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 15, 50, 4, 20 };
            AppHelper.sort(ref arr);
        }
    }
}
