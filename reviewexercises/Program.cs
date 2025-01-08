using System;
using static reviewexercises.MyMethods;

namespace reviewexercises
{
    public class Program
    {
        public static void Main()
        {
            const string MessageOne = "Enter the full price: ",
                MessageTwo = "Enter the price with discount: ",
                FinalMessage = "The price has a discount of {0}%",
                FormatExceptionMessage = "Incorrect format.",
                GeneralExceptionMessage = "General exception";

            double price, priceWithDiscount;

            Console.Write(MessageOne);
            try
            {
                price = Convert.ToDouble(Console.ReadLine());
                Console.Write(MessageTwo);
                priceWithDiscount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(FinalMessage, CalculateDiscount(price, priceWithDiscount));
            }
            catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
            catch (FormatException) { Console.WriteLine(FormatExceptionMessage); }
            catch (Exception) { Console.WriteLine(GeneralExceptionMessage); }

        }
    }
}