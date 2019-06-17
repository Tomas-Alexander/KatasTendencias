using System;

namespace RomanNumeralsKata1
{
    public class Number
    {
        public static string ToRoman(int v)
        {
            string roman = "";
            for (int i = v.ToString().Length; i > 0; i--)
            {
                int result = v % Convert.ToInt32(Math.Pow(10, i));
                result = result - result % Convert.ToInt32(Math.Pow(10, i-1));

                switch (result)
                {
                    case 1:
                        roman += "I";
                        break;
                    case 2:
                        roman += "II";
                        break;
                    case 3:
                        roman += "III";
                        break;
                    case 4:
                        roman += "IV";
                        break;
                    case 5:
                        roman += "V";
                        break;
                    case 6:
                        roman += "VI";
                        break;
                    case 7:
                        roman += "VII";
                        break;
                    case 8:
                        roman += "VIII";
                        break;
                    case 9:
                        roman += "IX";
                        break;
                    case 10:
                        roman += "X";
                        break;
                    case 20:
                        roman += "XX";
                        break;
                    default:
                        roman += "";
                        break;
                }
            }

            return roman;
        }
    }
}