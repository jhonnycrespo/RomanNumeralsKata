using System.Text;

namespace RomanNumerals
{
    public class MyConverter
    {
        public static string ToRoman(int number)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < number; i++)
            {
                result.Append("I");
            }
            return result.ToString();
        }   
    }
}
