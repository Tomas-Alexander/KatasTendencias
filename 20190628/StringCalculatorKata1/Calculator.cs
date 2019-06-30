using System;

namespace StringCalculatorKata1
{
    public class Calculator
    {
        public static string Add(string v)
        {
            if (v.Length == 0)
            {
                return "0";
            }

            float result = 0;
            string delimeter = ",";
            if (v.StartsWith("//"))
            {
                delimeter = v.Substring(2, v.IndexOf("\n")-2);
                v = v.Substring(v.IndexOf("\n") + 1);
            }
            string[] numbers = v.Replace("\n", delimeter).Split(delimeter);
            
            foreach (string n in numbers)
            {
                if (!float.TryParse(n, out float b))
                {
                    throw new ArgumentException("Number expected but EOF found");
                }
                result += b;
            }

            return result.ToString();
        }
    }
}