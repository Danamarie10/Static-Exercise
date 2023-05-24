namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(29.5);
            Console.WriteLine($"Fahrenheit to Celsius = {celsius}");

            var fahrenheit = TempConverter.CelsiusToFahrenheit(57.8);
            Console.WriteLine($"Celsius to Fahrenheit = {fahrenheit}");
        }
    }
}
