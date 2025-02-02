namespace reviewexercises
{
    public class MyMethods
    {
        public static int LlegirIntValid()
        {
            const string ErrorMessage = "Incorrect format. Try again: ";

            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.Write(ErrorMessage);
            }
            return input;
        }

        public static double CalculateTip(int money, int tip)
        {
            return Math.Round(money * (tip / 100.0), 2);
        }

        public static double CalculateTip(int money, int tip, int people)
        {
            return Math.Round(money * (tip / 100.0) / people, 2);
        }
    }
}
