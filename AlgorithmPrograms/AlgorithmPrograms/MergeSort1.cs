using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class MergeSort1
    {     
        public static void Sort(int[] arr,int start,int end)
    {
        if(start<end)
            {
                int mid = (start + end) / 2;
                Sort(arr, start, mid);
                Sort(arr, mid+1,end);
                Merge(arr, start, end);
             }
            }
        public static void Merge(int[] arr, int start, int end)
        {
            int mid = (start + end) / 2;
            int i = start;
            int j = mid + 1;
            int k = start;
            int[] temp = new int[10];
            while (i <= mid && j <= end)
            {
                if (arr[i] < arr[j])
                {
                    temp[k] = arr[i];
                    i++;
                }
                else
                {
                    temp[k] = arr[j];
                    j++;
                }
                k++;
            }
            while (i <= mid)
            {
                temp[k++] = arr[i++];
            }
            while (j <= end)
            {
                temp[k++] = arr[j++];
            }
            for (i = start; i <= end; i++)
            {
                arr[i] = temp[i];
            }
        }
            public static void CallerMethod()
            {
                Console.Write("enter no of elements in an array :");
                int n = Utility.readInt();
                int[] arr = new int[n];
            Console.WriteLine("enter array elements:");
                for(int i=0;i<n;i++)
                {
                    arr[i] = Utility.readInt();
                 }
                Sort(arr, 0, n - 1);
                for(int i=0;i<n;i++)
                {
                    Console.Write(arr[i] + " ");
                }
             }
         }
        
    }
