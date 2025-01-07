using System;
using static reviewexercises.MyMethods;

namespace reviewexercises
{
    public class Program
    {
        public static void Main()
        {
            const string MessageOne = "Enter temperature in Celsius: ",
                MessageTwo = "Enter temperature in Kelvin: ",
                FormatExceptionMessage = "Incorrect format.",
                GeneralExceptionMessage = "General exception";

            double temperature;

            Console.Write(MessageOne);
            try
            {
                temperature = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{temperature}ºC is {MyMethods.CelsiusToFahrenheit(temperature)}ºF.");
                Console.Write(MessageOne);
                temperature = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{temperature}ºC is {MyMethods.CelsiusToKelvin(temperature)}ºK.");
                Console.Write(MessageTwo);
                temperature = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{temperature}ºK is {MyMethods.KelvinToFahrenheit(temperature)}ºF.");

            }
            catch (FormatException) { Console.WriteLine(FormatExceptionMessage); }
            catch (Exception) { Console.WriteLine(GeneralExceptionMessage); }


            
        }
    }
}