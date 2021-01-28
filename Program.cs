using System;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select the convertor direction");
            Console.WriteLine("1. From Celsius to Fahrenheit.");
            Console.WriteLine("2. From Fahrenheit to Celcius.");
            Console.WriteLine("3. From Celcius to Kelvin.");
            Console.WriteLine("4. From Fahrenheit to Kelvin.");
            Console.WriteLine("5. From Kelvin to Celcius.");
            Console.WriteLine("6. From Kelvin to Fahrenheit.");
            Console.Write(":");
            int selection = Convert.ToInt32(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    Console.Write("\nPlease Enter the Celcius Temperature : ");
                    double F = TemperatureConverter.CelciustoFahrenheit(Console.ReadLine());
                    Console.WriteLine("Temperature Fahrenheit : {0:F2}", F);
                    break;
                case 2:
                    Console.Write("\nPlease Enter the Fahrenheit Temperature : ");
                    double C = TemperatureConverter.FahrenheittoCelcius(Console.ReadLine());
                    Console.WriteLine("Temperature Celcius : {0:F2}", C);
                    break;
                case 3:
                    Console.Write("\nPlease Enter the Celcius Temperature : ");
                    double K = TemperatureConverter.CelciustoKelvin(Console.ReadLine());
                    Console.WriteLine("Temperature Kelvin : {0:F2}", K);
                    break;
                case 4:
                    Console.Write("\nPlease Enter the Fahrenheit Temperature : ");
                    K = TemperatureConverter.FahrenheittoKelvin(Console.ReadLine());
                    Console.WriteLine("Temperature Kelvin : {0:F2}", K);
                    break;
                default:
                    Console.WriteLine("Please select a convertor.");
                    break;
            }
            Console.ReadLine();
        }
    }

    class TemperatureConverter
    {
        public static double CelciustoFahrenheit(string temperatureCelcius)
        {
            double celcius = double.Parse(temperatureCelcius);
            double fahrenheit = (celcius * 9 / 5) + 32;

            return fahrenheit;
        }

        public static double FahrenheittoCelcius(string temperatureFahrenheit)
        {
            double fahrenheit = double.Parse(temperatureFahrenheit);
            double celcius = (fahrenheit - 32) * 5 / 9;

            return celcius;
        }

        public static double CelciustoKelvin(string temperatureCelcius)
        {
            double celcius = double.Parse(temperatureCelcius);
            double kelvin = celcius + 273.15;

            return kelvin;
        }

        public static double FahrenheittoKelvin(string temperatureFahreneheit)
        {
            double fahrenheit = double.Parse(temperatureFahreneheit);
            double kelvin = (fahrenheit - 32) * 5 / 9 + 273.15;

            return kelvin;
        }
    }
}
