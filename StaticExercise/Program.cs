namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celcuis = TempConverter.FahrenheitToCelsius(68); //20
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);
            Console.WriteLine($"celsius {celcuis}");
            Console.WriteLine($"fahrenheit {fahrenheit}");
        }
    }
}
