namespace reviewexercises
{
    public class MyMethods
    {
        public static double CalculateDiscount(double price, double priceWithDiscount)
        {
            if (price < priceWithDiscount) throw new ArgumentException("El preu amb descompte ha de ser menor al preu inicial");
            return Math.Round(((price - priceWithDiscount) / price) * 100, 2);
        }
    }
}
