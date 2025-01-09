using System;
using static reviewexercises.MyMethods;

namespace reviewexercises
{
    public class Program
    {
        public static void Main()
        {
            const string FirstMessage = "Insert your ticket's cost: ",
                SecondMessage = "Insert the tip percentage you want to give: ",
                FinalMessage = "The tip that you should give is {0}$",
                FormatExceptionMessage = "Incorrect format.",
                OverflowExceptionMessage = "Too large number",
                GeneralExceptionMessage = "General exception";

            int amountMoney, tipPercentage;

            Console.Write(FirstMessage);
            try
            {
                amountMoney = Convert.ToInt32(Console.ReadLine());
                Console.Write(SecondMessage);
                tipPercentage = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(FinalMessage, MyMethods.CalculateTip(amountMoney, tipPercentage));
            }
            catch (FormatException) { Console.WriteLine(FormatExceptionMessage); }
            catch (OverflowException) { Console.WriteLine(OverflowExceptionMessage); }
            catch (Exception) { Console.WriteLine(GeneralExceptionMessage); }
            
        }
    }
}