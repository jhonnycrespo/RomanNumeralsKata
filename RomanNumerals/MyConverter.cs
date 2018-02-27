using System.Text;

namespace RomanNumerals
{
    public class MyConverter
    {
        public static string ToRoman(int number)
        {
            StringBuilder result = new StringBuilder();
            int remaining = number;

            remaining = AppendRomanNumerals(remaining, 9, "IX", result);
            remaining = AppendRomanNumerals(remaining, 5, "V", result);
            remaining = AppendRomanNumerals(remaining, 4, "IV", result);

            for (int i = 0; i < remaining; i++)
            {
                result.Append("I");
            }
            
            return result.ToString();
        }

        private static int AppendRomanNumerals(int arabic, int value, string romanDigits, StringBuilder builder)
        {
            int result = arabic;

            if (result >= value)
            {
                builder.Append(romanDigits);
                result -= value;
            }

            return result;
        }
    }
}
