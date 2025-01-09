namespace reviewexercises
{
    public class MyMethods
    {
        public static bool IsPostcode(string postcode)
        {
            int numCount = 0;

            if (postcode.Length > 5) { return false; }
            for (int i = 0; i < postcode.Length; i++) {
                if (Char.IsNumber(postcode[i])) { numCount++; }
            }

            return numCount == 5;
        }
    }
}
