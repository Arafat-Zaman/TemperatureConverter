using System;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Temperature Converter!");

            while (true)
            {
                Console.WriteLine("\nChoose the conversion type:");
                Console.WriteLine("1. Celsius to Fahrenheit");
                Console.WriteLine("2. Fahrenheit to Celsius");
                Console.WriteLine("3. Celsius to Kelvin");
                Console.WriteLine("4. Kelvin to Celsius");
                Console.WriteLine("5. Fahrenheit to Kelvin");
                Console.WriteLine("6. Kelvin to Fahrenheit");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice (1-7): ");

                string choice = Console.ReadLine();

                if (choice == "7")
                {
                    Console.WriteLine("Exiting the application. Goodbye!");
                    break;
                }

                Console.Write("Enter the temperature: ");
                string input = Console.ReadLine();

                try
                {
                    double temperature = ConvertToDouble(input);
                    double convertedTemperature = 0;

                    switch (choice)
                    {
                        case "1":
                            convertedTemperature = CelsiusToFahrenheit(temperature);
                            Console.WriteLine($"{temperature} °C is {convertedTemperature} °F");
                            break;
                        case "2":
                            convertedTemperature = FahrenheitToCelsius(temperature);
                            Console.WriteLine($"{temperature} °F is {convertedTemperature} °C");
                            break;
                        case "3":
                            convertedTemperature = CelsiusToKelvin(temperature);
                            Console.WriteLine($"{temperature} °C is {convertedTemperature} K");
                            break;
                        case "4":
                            convertedTemperature = KelvinToCelsius(temperature);
                            Console.WriteLine($"{temperature} K is {convertedTemperature} °C");
                            break;
                        case "5":
                            convertedTemperature = FahrenheitToKelvin(temperature);
                            Console.WriteLine($"{temperature} °F is {convertedTemperature} K");
                            break;
                        case "6":
                            convertedTemperature = KelvinToFahrenheit(temperature);
                            Console.WriteLine($"{temperature} K is {convertedTemperature} °F");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a numerical value for the temperature.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }

        static double ConvertToDouble(string input)
        {
            return double.Parse(input);
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        static double CelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        static double KelvinToCelsius(double kelvin)
        {
            return kelvin - 273.15;
        }

        static double FahrenheitToKelvin(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9 + 273.15;
        }

        static double KelvinToFahrenheit(double kelvin)
        {
            return (kelvin - 273.15) * 9 / 5 + 32;
        }
    }
}
