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
                ThirdMessage = "How many people are going to share the bill? ",
                FinalMessage = "The expected tip is {0}$, so each one has to pay {1}$";

            int amountMoney, tipPercentage, people;

            Console.Write(FirstMessage);
            amountMoney = LlegirIntValid();
            Console.Write(SecondMessage);
            tipPercentage = LlegirIntValid();
            Console.Write(ThirdMessage);
            people = LlegirIntValid();
            Console.Write(FinalMessage, MyMethods.CalculateTip(amountMoney, tipPercentage), CalculateTip(amountMoney, tipPercentage, people));


        }
    }
}