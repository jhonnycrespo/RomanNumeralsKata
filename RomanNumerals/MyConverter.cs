using System.Text;

namespace RomanNumerals
{
    public class MyConverter
    {
        public static string ToRoman(int number)
        {
            StringBuilder result = new StringBuilder();

            if (number == 6)
            {
                result.Append("VI");
            } else if (number == 5)
            {
                result.Append("V");
            } else if (number == 4)
            {
                result.Append("IV");
            }
            else
            {
                for (int i = 0; i < number; i++)
                {
                    result.Append("I");
                }
            }
            
            return result.ToString();
        }   
    }
}
