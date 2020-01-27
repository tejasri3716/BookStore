using System;
using System.Collections.Generic;
using System.Text;

namespace FuctionalPrograms
{
    class Gambler
    {
        public static void GamblerSimulator()
            {
                Random random = new Random();
			
			Console.WriteLine("enter stake: ");
			int stake =Utility.readInt();
			Console.WriteLine("enter goal: ");
			int goal = Utility.readInt();
			Console.WriteLine("enter no of trails:");
			int trials = Utility.readInt();

			int bets = 0;
			int wins = 0;
			int cash = stake;
			int loss = 0;
			for (int t = 0; t < trials; t++)
			{
				if (cash > 0 && cash < goal)
				{
					bets++;
					if (random.NextDouble() < 0.5)
					{
						cash++;
						wins++;
					}
					else
					{
						cash--;
						loss++;
					}
				}
			}
			if (cash >= goal)
			{
				Console.WriteLine("goal reached");
			}
			else
			{
				Console.WriteLine("palyer lost");
			}
			Console.WriteLine(wins + " wins of " + trials);
			Console.WriteLine(loss + " loss of " + trials);
			Console.WriteLine("Percent of games won = " + 100.0 * wins / trials);
			Console.WriteLine("percentage of games lost = " + 100.0 * loss / trials);
			Console.WriteLine("Avg # bets = " + 1.0 * bets / trials);
			
		}
	}
    }
