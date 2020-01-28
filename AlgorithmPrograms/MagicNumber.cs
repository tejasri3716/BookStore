using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class MagicNumber
    {
		public static int Number(int low, int high)
		{
			int str1 = 1;
			int str2 = 2;
			if ((high - low) == 0)
			{
				return high;
			}
			int mid = (low + high) / 2;
			Console.WriteLine("type 1 if it is less than  " + mid);
			Console.WriteLine("type 2 if it is greater than " + mid);
			int str = Utility.readInt();
			if (str == str1)
			{
				high = mid;
				return Number(low, high);
			}
			else if (str == str2)
			{
				low = mid;
				return Number(low, high);
			}
			else if (high == mid)
			{
				return mid;
			}
			else
			{
				Console.WriteLine(" invalid input");
			}

			return low;
		}
		public static void GuessNumber()
		{
			int n = 8;
			int N = (int)Math.Pow(2, n);
			Console.WriteLine(" think of a number between 0 and " + (N - 1));
			Console.WriteLine("your number is" + Number(0, N));
		}

	}
}

    