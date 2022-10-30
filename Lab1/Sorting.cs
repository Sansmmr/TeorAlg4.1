using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Sorting
    {
        public Sorting()
        {
        }
        public int[] bubbleSort(int[] arr, bool descending = false)
        {
            int sign = 1;
            if (descending)
                sign = -1;
            int n = arr.Length;
            int[] arr_copy = new int[n];
            arr.CopyTo(arr_copy, 0);
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr_copy[j] * sign > arr_copy[j + 1] * sign)
                    {
                        int temp = arr_copy[j];
                        arr_copy[j] = arr_copy[j + 1];
                        arr_copy[j + 1] = temp;
                    }
            watch.Stop();
            return arr_copy;
        }
        public int[]  insertingSort(int[] arr, bool descending = false)
        {
            int sign = 1;
            if (descending)
                sign = -1;
            int n = arr.Length;
            int[] arr_copy = new int[n];
            arr.CopyTo(arr_copy, 0);
           
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 1; i < n; ++i)
            {
                int key = arr_copy[i];
                int j = i - 1;
                while (j >= 0 && arr_copy[j] * sign > key * sign)
                {
                    arr_copy[j + 1] = arr_copy[j];
                    j = j - 1;
                }
                arr_copy[j + 1] = key;
            }
            watch.Stop();
    
            return arr_copy;
        }
        public int[] perfectedBubbleSort(int[] arr, int n, bool descending = false)
        {
            int sign = 1;
            if (descending)
                sign = -1;
            int i, j, temp;
            bool swapped;
            int[] arr_copy = new int[n];
            arr.CopyTo(arr_copy, 0);
           
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr_copy[j] * sign > arr_copy[j + 1] * sign)
                    {
                        temp = arr_copy[j];
                        arr_copy[j] = arr_copy[j + 1];
                        arr_copy[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (swapped == false)
                    break;
            }
            watch.Stop();
            return arr_copy;
        }
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.Write("\n");
        }
    }
}
