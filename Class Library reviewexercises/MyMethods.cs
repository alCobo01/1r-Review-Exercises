namespace reviewexercises
{
    public class MyMethods
    {
        public static string SecondsToFullHour(int totalSeconds)
        {
            int hours = totalSeconds / 3600;
            int remainingSeconds = totalSeconds % 3600;
            int minutes = remainingSeconds / 60;
            int seconds = remainingSeconds % 60;

            return $"{hours} hora, {minutes} minuts i {seconds} segons.";
        }
    }
}
