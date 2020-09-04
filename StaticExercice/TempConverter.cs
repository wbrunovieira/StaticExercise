using System;
namespace StaticExercice
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double faherenheit)
        {
            var result = (faherenheit - 32) / 1.8;

            return result;
        }

        public static double CeulsiusToFahrenheit(double celcius)

        {
            var result = (celcius * 9) / 5 + 32;

            return result;

        }
             
         
    }
}
