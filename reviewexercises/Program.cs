using System;
using static reviewexercises.MyMethods;

namespace reviewexercises
{
    public class Program
    {
        public static void Main()
        {
            const string FormatExceptionMessage = "Incorrect format.",
                OverflowExceptionMessage = "Too large number";

            int seconds;

            try {
                seconds = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(MyMethods.SecondsToFullHour(seconds)); 
            } 
            catch (FormatException) { Console.WriteLine(FormatExceptionMessage); }
            catch (OverflowException) { Console.WriteLine(OverflowExceptionMessage); }
        }
    }
}