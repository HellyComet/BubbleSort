using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class Program
    {
        public static void BubbleSort(int[] a, int n)
        {
            int x, j, temp, swaps;

            for( x = n - 2; x >= 0; x--) // n - 1 passes
            {
                swaps = 0;
                for (j = 0; j <= x; j++) //First pass 
                {
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        swaps++;
                    }

                    if (swaps == 0)
                        break;
                }
            }
        }
        public static void Main(string[] args)
        {
            int i, n;

            int[] a = new int[20];

            Console.WriteLine("Enter the number of elements");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Enter element at:" + a[i] + "positon");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            BubbleSort(a, n);

            Console.WriteLine("Sorted array");
            for (i = 0; i < n; i++)
                Console.WriteLine(a[i] + "");
            Console.WriteLine();
        }
    }
}
