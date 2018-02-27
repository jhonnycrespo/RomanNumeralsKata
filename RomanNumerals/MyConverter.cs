using System.Text;

// https://remonsinnema.com/2011/12/05/practicing-tdd-using-the-roman-numerals-kata/

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

            // It seems that the for loop does something similar to what appendRomanNumerals does.
            // The only difference is that the loop does it multiple times, while the method does it only once.
            // We can generalize the method and rewrite the loop to make this duplication more visible.

            //for (int i = 0; i < remaining; i++)
            //{
            //    result.Append("I");
            //}

            while (remaining >= 1)
            {
                result.Append("I");
                remaining -= 1;
            }   

            return result.ToString();
        }

        private static int AppendRomanNumerals(int number, int value, string romanDigits, StringBuilder builder)
        {
            int result = number;

            //if (result >= value)
            //{
            //    builder.Append(romanDigits);
            //    result -= value;
            //}

            while (result >= value)
            {
                builder.Append(romanDigits);
                result -= value;
            }

            return result;
        }
    }
}
