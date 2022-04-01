using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue;
            double temperature;
            do
            {
                Console.WriteLine("Enter a Fahrenheit temperature to convert to degrees Celsius: ");
                isTrue = double.TryParse(Console.ReadLine(), out temperature);
            } while (!isTrue);

            Console.WriteLine($"\n{temperature} degrees Fahrenheit = " +
                $"{TempConverter.FahrenheitToCelsius(temperature)} degrees Celsius.\n");
            Console.WriteLine("-------------------------------");

            do
            {
                Console.WriteLine("Enter a Celsius temperature to convert to degrees Fahrenheit: ");
                isTrue = double.TryParse(Console.ReadLine(), out temperature);
            } while (!isTrue);

            Console.WriteLine($"\n{temperature} degrees Celsius = " +
                $"{TempConverter.CelsiusToFahrenheit(temperature)} degrees Fahrenheit.\n");
        }
    }
}
