using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace AlgorithmPrograms
{
    class MergeSort
    {
        static public void MainMerge<T>(T[] values, int left, int mid, int right) where T : IComparable<T>
        {
            T[] temp = new T[25];
            int i, eol, num, pos;

            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

        /*    while ((left <= eol) && (mid <= right))
            {
                if (values[left].IComparable.CompareTo(values[mid]))
                    temp[pos++] = values[left++];
                else
                    temp[pos++] = values[mid++];
            }*/

            while (left <= eol)
                temp[pos++] = values[left++];

            while (mid <= right)
                temp[pos++] = values[mid++];

            for (i = 0; i < num; i++)
            {
                values[right] = temp[right];
                right--;
            }
        }

        static public void SortMerge<T>(T[] values, int left, int right) where T : IComparable<T>
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge(values, left, mid);
                SortMerge(values, (mid + 1), right);

                MainMerge(values, left, (mid + 1), right);
            }
        }
    }
}
