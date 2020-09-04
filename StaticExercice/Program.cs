using System;

namespace StaticExercice
{
    class Program
    {
        static void Main(string[] args)
        {

            var ceulcius = TempConverter.FahrenheitToCelsius(68);

            Console.WriteLine($"celcius: {ceulcius}");


            var fahrenheit = TempConverter.CeulsiusToFahrenheit(20);

            Console.WriteLine($"fahrenheit: {fahrenheit}");
        }
    }
}
