using System;
namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheit)
        => (5.0 / 9.0) * (fahrenheit - 32); //use double for 5 and 9 so there are no rounding errors

        public static double CelsiusToFahrenheit(double celsius)
        => (9.0 / 5.0) * celsius + 32;
    }
}
