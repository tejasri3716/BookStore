using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace AlgorithmPrograms
{
    class MergeSort
    {
        static public void MainMerge<T>(T[] values, int left, int right) where T : IComparable<T>
        {
            int mid = (left + right) / 2;
            T[] temp = new T[25];
            int i, num, pos;

            int j = mid + 1;
            pos = left;

            while ((left<=(mid)) && (j>=(right)))
            {
                if (values[left].CompareTo(values[mid]) < 0)
                    temp[pos++] = values[left++];
                else
                    temp[pos++] = values[mid++];
            }

            while (left <= mid)
                temp[pos++] = values[left++];

            while (mid <= right)
                temp[pos++] = values[mid++];

            for (i = 0; i < right; i++)
            {
                values[i] = temp[i];
            }
        }

        static public void SortMerge<T>(T[] values, int left, int right) where T : IComparable<T>
        {
           

            if (right > left)
            {
                int mid = (right + left) / 2;
                SortMerge(values, left, mid);
                SortMerge(values, (mid + 1), right);
               MainMerge(values, left, right);

            }
        }
        public static void CallingMethods()
        {

            Console.WriteLine("enter no of elements in an array");
            int n = Utility.readInt();
            String[] values = new String[n];
            for (int i = 0; i < n; i++)
            {
                values[i] = Utility.readString();
            }
            /* int left = 0;
             int right = n - 1;
             int mid = (left + right) / 2;
            MainMerge(values, 0, mid,n - 1);*/
            SortMerge(values, 0, n - 1);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(values[i]);
            }
        }
    }
}
