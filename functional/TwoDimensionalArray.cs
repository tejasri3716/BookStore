using System;
using System.Collections.Generic;
using System.Text;

namespace FuctionalPrograms
{
    class TwoDimesionalArray
    {
        public static void twoDimensionalIntArray()
        {
            int row, column, i, j;
            Console.WriteLine("enter row for the array");
            row = Utility.readInt();
            Console.WriteLine("enter column for the array");
            column = Utility.readInt();
            int[,] arr = new int[row, column];
           
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < column; j++)
                {
                    arr[i, j] = Utility.readInt();
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("2D Integer Array");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < column; j++)
                {
                    Console.WriteLine("\n");
                    Console.Write(arr[i, j]+" ");
                    Console.WriteLine("\n");
                }
            }
        }
        public static void twoDimensionalDoubleArray()
        {
            int row, column, i, j;
            Console.WriteLine("enter row for the array");
            row = Utility.readInt();
            Console.WriteLine("enter column for the array");
            column = Utility.readInt();
            double[,] arr = new double[row, column];
            
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < column; j++)
                {
                    arr[i, j] = Utility.readDouble();
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("2D Double Array");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < column; j++)
                {

                    Console.WriteLine(arr[i, j]+" ");
                    Console.WriteLine("\n");
                    
                }
            }
         }
        public static void twoDimensionalBooleanArray()
        {
            Console.WriteLine("enter number of rows");
            int row = Utility.readInt();
            Console.WriteLine("enter number of columns");
            int column = Utility.readInt();
            bool[,] arr = new bool[row, column];
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<column;j++)
                {
                    arr[i, j] = Utility.readBoolean();
                    Console.WriteLine("\n");
                }
            }
            Console.WriteLine("\n");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.WriteLine(arr[i, j] + " ");
                    Console.WriteLine("\n");
                }
            }
                   
        }
    }
}
