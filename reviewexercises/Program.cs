using System;
using System.Reflection.Metadata;
using static reviewexercises.MyMethods;

namespace reviewexercises
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string FirstMessage = "Write a character string: ",
                FinalMessage = "Is what you entered a postcode? {0}",
                EmptyStringMessage = "Empty string, try again";

            string? userInput;
            bool isEmpty = false;

            Console.Write(FirstMessage);
            do
            {
                if (isEmpty) { Console.Write(EmptyStringMessage); } ;
                userInput = Console.ReadLine();
            } while (userInput == "");
            
            Console.Write(FinalMessage, IsPostcode(userInput));
        }
    }
}