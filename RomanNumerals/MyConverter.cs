using System.Text;

namespace RomanNumerals
{
    public class MyConverter
    {
        public static string ToRoman(int number)
        {
            StringBuilder result = new StringBuilder();
            int remaining = number;

            if (remaining >= 9)
            {
                result.Append("IX");
                remaining -= 9;
            }

            if (remaining >= 5)
            {
                result.Append("V");
                remaining -= 5;
            }

            if (remaining >= 4)
            {
                result.Append("IV");
                remaining -= 4;
            }
        
            for (int i = 0; i < remaining; i++)
            {
                result.Append("I");
            }
            
            return result.ToString();
        }   
    }
}
