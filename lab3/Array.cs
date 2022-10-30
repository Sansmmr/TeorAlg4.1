using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Array1
    {
        public int size;
        public int[] arr;
        public int countInversions;

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
            while (i < size)
            {
                j = i + 1;
                while (j < size)
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

    }
}
