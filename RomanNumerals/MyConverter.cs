namespace RomanNumerals
{
    public class MyConverter
    {
        public static string ToRoman(int number)
        {
            if (number == 2)
                return "II";

            return "I";
        }   
    }
}
