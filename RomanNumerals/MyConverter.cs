using System.Collections.Generic;
using System.Text;

// https://remonsinnema.com/2011/12/05/practicing-tdd-using-the-roman-numerals-kata/
// https://github.com/boucardbruno/RomanNumerals-Kata

namespace RomanNumerals
{
    public class MyConverter
    {
        private static readonly Dictionary<int, string> Symbols = new Dictionary<int, string>
        {
            {1000, "M"},
            {900, "CM"},
            {500, "D"},
            {400, "CD"},
            {100, "C"},
            {90, "XC"},
            {50, "L"},
            {40, "XL"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1 , "I"}
        };

        public static string ToRoman(int number)
        {
            StringBuilder result = new StringBuilder();
            int remaining = number;

            foreach (var num in Symbols)
            {
                remaining = AppendRomanNumerals(remaining, num.Key, num.Value, result);
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
