using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Lab1
{
       //public delegate void Action();
    public class Arr
    {
        public int size;
        public int[] arr;
        public int countInversions;
        public Arr()
        {
            arr = new int[0];
        }
        public Arr(int size,int T)
        {
            this.size = size;
            arr = new int[size];
            if(T==1)
            {
                A_Z();
            }
           else if(T==2)
            {
                Z_A();
            }
            else if(T==3)
            {
                Rand();
            }
        }
        public void A_Z()
        {

            for (int i = 0; i < size; i++)
            {
                arr[i] = i;
            }
        }
       public void Z_A()
        {

            int tmp = size;
            for (int i = 0; i < size; i++)
            {
                arr[i] = tmp;
                tmp--;
            }
        }
        public void Rand()
        {

            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(0, 100);
            }
        }

        public void bubbleSort()
        {
            for (int i = 0; i < size - 1; i++)
                for (int j = 0; j < size - i - 1; j++)
                    if (arr[j]  > arr[j + 1] )
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }
        public void insertingSort()
        {
            for (int i = 1; i < size; ++i)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j]  > key )
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
         }

        void merge(int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;
            for (i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];
            i = 0;
            j = 0;
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        void sort(int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                sort(l, m);
                sort( m + 1, r);
                merge(l, m, r);
            }
        }

        public void runMerge()
        {
            sort(0, size - 1);
        }

        public void mergeInversions()
        {
            countInversions = mergeSort();
           
        }
        int mergeSort()
        {
            int[] temp = new int[arr.Length];
            return _mergeSort(temp, 0, arr.Length - 1);
        }

        int _mergeSort(int[] temp, int left, int right)
        {
            int mid, inv_count = 0;
            if (right > left)
            {
                mid = (right + left) / 2;

                inv_count += _mergeSort(temp, left, mid);
                inv_count += _mergeSort(temp, mid + 1, right);

                inv_count += merge(temp, left, mid + 1, right);
            }
            return inv_count;
        }

        int merge(int[] temp, int left, int mid, int right)
        {
            int i, j, k;
            int inv_count = 0;

            i = left;
            j = mid;
            k = left;
            while ((i <= mid - 1) && (j <= right))
            {
                if (arr[i] <= arr[j])
                {
                    temp[k++] = arr[i++];
                }
                else
                {
                    countInversions++;
                    temp[k++] = arr[j++];
                    inv_count = inv_count + (mid - i);
                }
            }

            while (i <= mid - 1)
                temp[k++] = arr[i++];

            while (j <= right)
                temp[k++] = arr[j++];

            for (i = left; i <= right; i++)
                arr[i] = temp[i];

            return inv_count;
        }
        public void bruteForce()
        {
            countInversions = 0;
            int i = 0, j;
            while (i<size)
            {
                j = i + 1;
                while(j<size)
                {
                    if (arr[i] > arr[j])
                    {
                        countInversions++;
                    }
                    j++;
                }
                i++;
            }
        }
        void swap(int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        int partition(int low, int high)
        {
            int r=0;
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

        int partition_r( int low, int high)
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
                quickSortRand( low, pi);
                quickSortRand(pi + 1, high);
            }
        }
        public void quickSortRandRun()
        {
            quickSort(0, this.size - 1);
        }


    }
}
