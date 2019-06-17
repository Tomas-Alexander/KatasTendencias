
using System;

namespace NumbersInWordsKata1
{
    public class Numbers
    {
        public static string ToWords(int v)
        {
            string result = "";
            int number = v;
            for (int i = v.ToString().Length; i > 0; i--)
            {
                if (v >= 20)
                {
                    if (i != 1)
                    {
                        number = v % Convert.ToInt32(Math.Pow(10d,i)) - v % Convert.ToInt32(Math.Pow(10d,i-1));
                    }
                    else
                    {

                        number = v % Convert.ToInt32(Math.Pow(10d, i));
                    }
                }
                else
                {
                    i = 0;
                }



                switch (number)
                {
                    case 1:
                        result += "One";
                        break;
                    case 2:
                        result += "Two";
                        break;
                    case 3:
                        result += "Three";
                        break;
                    case 4:
                        result += "Four";
                        break;
                    case 5:
                        result += "Five";
                        break;
                    case 6:
                        result += "Six";
                        break;
                    case 7:
                        result += "Seven";
                        break;
                    case 8:
                        result += "Eigth";
                        break;
                    case 9:
                        result += "Nine";
                        break;
                    case 10:
                        result += "Ten";
                        break;
                    case 11:
                        result += "Eleven";
                        break;
                    case 12:
                        result += "Twelve";
                        break;
                    case 13:
                        result += "Thirteen";
                        break;
                    case 14:
                        result += "Fourteen";
                        break;
                    case 15:
                        result += "Fifteen";
                        break;
                    case 16:
                        result += "Sixteen";
                        break;
                    case 17:
                        result += "Seventeen";
                        break;
                    case 18:
                        result += "Eighteen";
                        break;
                    case 19:
                        result += "Nineteen";
                        break;
                    case 20:
                        result += "Twenty";
                        break;
                    default:
                        result += "";
                        break;
                }
                result += " ";
            }
            return result.Trim();

        }
    }
}