using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class TemperatureConversion
    {
         public static void temperatureConversion()
        {
            Console.WriteLine("enter the temperature in fahrenheit");
            int tempinFahrenheit = Utility.readInt();
            double a = tempinFahrenheit - 32;     // Fahrenheit to Celsius: (°F − 32) x 5 / 9 = °C
            double b = a * 5;
            double tempinCelsius= b / 9;
            Console.WriteLine("temperature in fahrenhiet:" + tempinFahrenheit + "temperature in celsius:" + tempinCelsius);
            int temperatureInFahreheit = (int)(((tempinCelsius * 9) / 5) + 32); //Celsius to Fahrenheit:   (°C × 9/5) + 32 = °F
            Console.WriteLine("temperature in celsius:" + tempinCelsius + "temperature in fahrenheit:" + temperatureInFahreheit);
        }
    }
}
