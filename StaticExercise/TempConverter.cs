using System;
namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheit)
        => (5 / 9) * (fahrenheit - 32);

        public static double CelsiusToFahrenheit(double celsius)
        => (9 / 5) * celsius + 32;
    }
}
