using System;
using System.Collections.Generic;
using System.Text;

namespace FuctionalPrograms
{
    class WindChill
    {
        public static void findTemperature()
        {
            Console.Write("enter temperature:");
            double temp = Utility.readDouble();
            Console.Write("enter windspeed:");
            double windspeed = Utility.readDouble();
            double temperature = Math.Abs(temp);
            if(temperature<=50)
            {
                if(windspeed<=120 && windspeed>=3)
                {
                    double windchill;
                    windchill = 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75)*Math.Pow(windspeed,0.16);
                    Console.WriteLine("temperature is:" + temperature);
                    Console.WriteLine("wind speed is" + windspeed);
                    Console.WriteLine("wind chill is:" + windchill);
                }
            }
            else
            {
                Console.WriteLine("enter the values within specified range");
            }
        }
    }
}
