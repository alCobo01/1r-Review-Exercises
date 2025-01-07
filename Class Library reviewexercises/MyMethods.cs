namespace reviewexercises
{
    public class MyMethods
    {
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 1.8) + 32;
        }

        public static double CelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        public static double KelvinToFahrenheit(double kelvin)
        {
            return 1.8 * (kelvin -273.15) + 32;
        }


    }
}
