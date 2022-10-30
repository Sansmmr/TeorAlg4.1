using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
     public class array4:Lab1.Arr
    {
        void swap(int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        int partition(int low, int high)
        {
            int r = 0;
            Random random = new Random();
            int pivot = arr[high];
            int i = (low - 1);
            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    swap(i, j);
                }
            }
            swap(i + 1, high);

            return (i + 1);
        }

        void quickSort(int low, int high)
        {
            if (low < high)
            {
                int pi = partition(low, high);
                quickSort(low, pi - 1);
                quickSort(pi + 1, high);
            }
        }
        public void quickSortRun()
        {
            quickSort(0, this.size - 1);
        }


        int partitionRand(int low, int high)
        {
            int pivot = arr[low];
            int i = low - 1, j = high + 1;

            while (true)
            {
                do
                {
                    i++;
                } while (arr[i] < pivot);
                do
                {
                    j--;
                } while (arr[j] > pivot);
                if (i >= j)
                    return j;

                swap(arr[i], arr[j]);
            }
        }

        int partition_r(int low, int high)
        {

            Random r = new Random();
            int random = r.Next(low, high);
            swap(arr[random], arr[low]);
            return partitionRand(low, high);
        }
        void quickSortRand(int low, int high)
        {
            if (low < high)
            {
                int pi = partition_r(low, high);
                quickSortRand(low, pi);
                quickSortRand(pi + 1, high);
            }
        }
        public void quickSortRandRun()
        {
            quickSort(0, this.size - 1);
        }

    }
}
