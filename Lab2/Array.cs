using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    //public delegate void Action();
    public class Arr
    {
        public int size;
        public int[] arr;

        public Arr()
        {
            size = 0;
            arr = null;
        }

        public Arr(int size, int T)

        {
            this.size = size;
            arr = new int[size];
            if (T == 1)
            {
                A_Z();
            }
            else if (T == 2)
            {
                Z_A();
            }
            else if (T == 3)
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
        public void insertingSort()
        {
            for (int i = 1; i < size; ++i)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

        public void merge(int l, int m, int r)
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
                sort(m + 1, r);
                merge(l, m, r);
            }
        }


    }
}
