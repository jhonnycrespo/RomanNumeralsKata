using System.Text;

// https://remonsinnema.com/2011/12/05/practicing-tdd-using-the-roman-numerals-kata/

namespace RomanNumerals
{
    public class MyConverter
    {
        private static readonly int[] Values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        private static readonly string[] RomanSymbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL" ,"X" ,"IX", "V", "IV", "I" };

        public static string ToRoman(int number)
        {
            StringBuilder result = new StringBuilder();
            int remaining = number;

            for (int i = 0; i < Values.Length; i++)
            {
                remaining = AppendRomanNumerals(remaining, Values[i], RomanSymbols[i], result);
            }

            return result.ToString();
        }

        private static int AppendRomanNumerals(int number, int value, string romanDigits, StringBuilder builder)
        {
            int result = number;

            while (result >= value)
            {
                builder.Append(romanDigits);
                result -= value;
            }

            return result;
        }
    }
}
