using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Overlapping_intervals
{
    public class Interval : IComparable<Interval>
    {
        public int s, e;

        public Interval(int s, int e)
        {
            this.s = s;
            this.e = e;
        }

        public int CompareTo(Interval a)
        {
            return this.s - a.s;
        }
    }

    class Program
    {
        static void mergeIntervals(Interval[] arr, int n)
        {
            Array.Sort(arr);

            int res = 0;

            for (int i = 1; i < n; i++)
            {
                if (arr[res].e >= arr[i].s)
                {
                    arr[res].e = Math.Max(arr[res].e, arr[i].e);
                    arr[res].s = Math.Min(arr[res].s, arr[i].s);
                }
                else
                {
                    res++;
                    arr[res] = arr[i];
                }
            }

            for (int i = 0; i <= res; i++)
                Console.WriteLine("[" + arr[i].s + ", " + arr[i].e + "] ");
        }

        static void Main(string[] args)
        {
            Interval[] arr = { new Interval(5,10),new Interval(3,15),new Interval(18,30),
                                        new Interval(2,7) };
            mergeIntervals(arr, arr.Length);
            Console.ReadLine();
        }
    }
}
