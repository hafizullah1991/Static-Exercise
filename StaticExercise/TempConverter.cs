using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal class TempConverter
    {
      
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (5.0 / 9.0) * (fahrenheit - 32);
        }
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (9.0 / 5.0) * celsius + 32;
        }
    }
}
