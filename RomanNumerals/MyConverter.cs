using System.Text;

namespace RomanNumerals
{
    public class MyConverter
    {
        private static readonly int[] Values = { 9, 5, 4 };
        private static readonly string[] RomanSymbols = { "IX", "V", "IV" };

        public static string ToRoman(int number)
        {
            StringBuilder result = new StringBuilder();
            int remaining = number;

            for (int i = 0; i < Values.Length; i++)
            {
                remaining = AppendRomanNumerals(remaining, Values[i], RomanSymbols[i], result);
            }

            for (int i = 0; i < remaining; i++)
            {
                result.Append("I");
            }
            
            return result.ToString();
        }

        private static int AppendRomanNumerals(int number, int value, string romanDigits, StringBuilder builder)
        {
            int result = number;

            if (result >= value)
            {
                builder.Append(romanDigits);
                result -= value;
            }

            return result;
        }
    }
}
