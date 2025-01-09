namespace reviewexercises
{
    public class MyMethods
    {
        public static double CalculateTip(int money, int tip)
        {
            return Math.Round(money * (tip / 100.0), 2);
        }
    }
}
